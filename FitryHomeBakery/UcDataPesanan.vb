Public Class UcDataPesanan

    Private saran As SaranPencarian
    Private ReadOnly menuStatus As New ContextMenuStrip()
    Private sedangMuat As Boolean = True

    Private Sub UcDataPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode Then Return

        SiapkanKolom()

        cmbFilterStatus.Items.Add("Semua Status")
        cmbFilterStatus.Items.AddRange(DataStore.DaftarStatus.Cast(Of Object)().ToArray())
        cmbFilterStatus.SelectedIndex = 0

        SiapkanMenuStatus()
        saran = New SaranPencarian(txtCariPesanan, AddressOf DaftarSaran)

        sedangMuat = False
        TampilkanData()
    End Sub

    ' ============================================================
    '  KOLOM TABEL
    ' ============================================================
    Private Sub SiapkanKolom()
        With dgvDataPesanan
            .Columns.Add("colNomor", "No. Pesanan")
            .Columns.Add("colNama", "Nama Pelanggan")
            .Columns.Add("colProduk", "Produk")
            .Columns.Add("colJumlah", "Jumlah")
            .Columns.Add("colTglAmbil", "Tgl Ambil")
            .Columns.Add("colJam", "Jam")
            .Columns.Add("colTotal", "Total")
            .Columns.Add("colStatus", "Status")
            .Columns.Add("colBayar", "Pembayaran")

            .Columns("colNomor").FillWeight = 85
            .Columns("colNama").FillWeight = 110
            .Columns("colProduk").FillWeight = 190
            .Columns("colJumlah").FillWeight = 60
            .Columns("colTglAmbil").FillWeight = 85
            .Columns("colJam").FillWeight = 55
            .Columns("colTotal").FillWeight = 90
            .Columns("colStatus").FillWeight = 90
            .Columns("colBayar").FillWeight = 90

            .Columns("colJumlah").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("colTglAmbil").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("colJam").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("colTotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("colStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("colBayar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("colStatus").DefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            .Columns("colBayar").DefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)

            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .MultiSelect = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    ' ============================================================
    '  SARAN PENCARIAN: nomor pesanan, nama pelanggan, nama produk
    ' ============================================================
    Private Function DaftarSaran() As IEnumerable(Of String)
        Dim hasil As New List(Of String)
        For Each r As DataRow In DataStore.Pesanan.Rows
            hasil.Add(r("NomorPesanan").ToString())
            hasil.Add(r("NamaPelanggan").ToString())
        Next
        For Each r As DataRow In DataStore.ItemPesanan.Rows
            hasil.Add(r("NamaProduk").ToString())
        Next
        Return hasil
    End Function

    ' ============================================================
    '  ISI TABEL + FILTER
    ' ============================================================
    Private Sub TampilkanData()
        If sedangMuat Then Return

        Dim kata As String = txtCariPesanan.Text.Trim()
        Dim status As String = If(cmbFilterStatus.SelectedIndex > 0, cmbFilterStatus.Text, "")
        Dim dipilih As String = NomorTerpilih()

        Dim baris As List(Of DataRow) = DataStore.Pesanan.Rows.Cast(Of DataRow)().
            OrderBy(Function(r) CDate(r("TanggalAmbil")).Date).
            ThenBy(Function(r) r("NomorPesanan").ToString()).ToList()

        dgvDataPesanan.Rows.Clear()
        For Each r In baris
            Dim nomor As String = r("NomorPesanan").ToString()
            Dim tglAmbil As Date = CDate(r("TanggalAmbil")).Date

            If kata <> "" Then
                Dim cocok As Boolean =
                    nomor.IndexOf(kata, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
                    r("NamaPelanggan").ToString().IndexOf(kata, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
                    r("Produk").ToString().IndexOf(kata, StringComparison.OrdinalIgnoreCase) >= 0
                If Not cocok Then Continue For
            End If
            If status <> "" AndAlso r("Status").ToString() <> status Then Continue For
            If dtpTanggalMulai.Checked AndAlso tglAmbil < dtpTanggalMulai.Value.Date Then Continue For
            If dtpTanggalAkhir.Checked AndAlso tglAmbil > dtpTanggalAkhir.Value.Date Then Continue For

            dgvDataPesanan.Rows.Add(
                nomor, r("NamaPelanggan").ToString(), r("Produk").ToString(), CInt(r("Jumlah")),
                tglAmbil.ToString("dd/MM/yyyy"), r("JamAmbil").ToString(),
                Tema.Rupiah(CDec(r("TotalTagihan"))), r("Status").ToString(),
                DataStore.StatusPembayaran(nomor))
        Next

        ' kembalikan pilihan baris sebelumnya
        dgvDataPesanan.ClearSelection()
        If dipilih <> "" Then
            For Each row As DataGridViewRow In dgvDataPesanan.Rows
                If row.Cells("colNomor").Value.ToString() = dipilih Then
                    row.Selected = True
                    Exit For
                End If
            Next
        End If

        lblPetunjuk.Text = If(dgvDataPesanan.Rows.Count = 0,
            "Belum ada pesanan yang cocok. Tambahkan lewat menu Tambah Pesanan.",
            "Pilih satu pesanan di tabel. Klik 2x pada baris untuk melihat detail dan mengubah jumlah.")
    End Sub

    Private Function NomorTerpilih() As String
        If dgvDataPesanan.SelectedRows.Count = 0 Then Return ""
        Return dgvDataPesanan.SelectedRows(0).Cells("colNomor").Value.ToString()
    End Function

    ' warna status & pembayaran
    Private Sub dgvDataPesanan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDataPesanan.CellFormatting
        If e.RowIndex < 0 OrElse e.Value Is Nothing Then Return
        Dim kolom As String = dgvDataPesanan.Columns(e.ColumnIndex).Name
        If kolom <> "colStatus" AndAlso kolom <> "colBayar" Then Return

        Select Case e.Value.ToString()
            Case "Selesai", "Lunas", "Siap Diambil"
                e.CellStyle.BackColor = Tema.LatarSukses
                e.CellStyle.ForeColor = Tema.Sukses
            Case "Dibatalkan"
                e.CellStyle.BackColor = Tema.LatarBahaya
                e.CellStyle.ForeColor = Tema.Bahaya
            Case Else
                e.CellStyle.BackColor = Tema.LatarPeringatan
                e.CellStyle.ForeColor = Tema.CoklatAksen
        End Select
        e.CellStyle.SelectionBackColor = e.CellStyle.BackColor
        e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor
    End Sub

    ' ============================================================
    '  EVENT FILTER
    ' ============================================================
    Private Sub txtCariPesanan_TextChanged(sender As Object, e As EventArgs) Handles txtCariPesanan.TextChanged
        TampilkanData()
    End Sub

    Private Sub btnCariPesanan_Click(sender As Object, e As EventArgs) Handles btnCariPesanan.Click
        TampilkanData()
    End Sub

    Private Sub txtCariPesanan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariPesanan.KeyDown
        If e.KeyCode = Keys.Enter Then
            TampilkanData()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub FilterBerubah(sender As Object, e As EventArgs) Handles cmbFilterStatus.SelectedIndexChanged, dtpTanggalMulai.ValueChanged, dtpTanggalAkhir.ValueChanged
        TampilkanData()
    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
        sedangMuat = True
        txtCariPesanan.Clear()
        If cmbFilterStatus.Items.Count > 0 Then cmbFilterStatus.SelectedIndex = 0
        dtpTanggalMulai.Checked = False
        dtpTanggalAkhir.Checked = False
        sedangMuat = False
        TampilkanData()
    End Sub

    ' ============================================================
    '  DETAIL (ubah jumlah dengan NumericUpDown) & UBAH STATUS
    ' ============================================================
    Private Sub dgvDataPesanan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataPesanan.CellDoubleClick
        If e.RowIndex >= 0 Then BukaDetail()
    End Sub

    Private Sub btnLihatDetail_Click(sender As Object, e As EventArgs) Handles btnLihatDetail.Click
        BukaDetail()
    End Sub

    Private Sub BukaDetail()
        Dim nomor As String = NomorTerpilih()
        If nomor = "" Then
            MessageBox.Show("Pilih satu pesanan terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Using f As New FrmDetailPesanan(nomor)
            f.ShowDialog(Me.FindForm())
        End Using
        TampilkanData()
    End Sub

    Private Sub SiapkanMenuStatus()
        menuStatus.Font = New Font("Segoe UI", 10.0F)
        For Each s In DataStore.DaftarStatus
            Dim item As New ToolStripMenuItem(s)
            AddHandler item.Click, AddressOf SaatStatusDipilih
            menuStatus.Items.Add(item)
        Next
    End Sub

    Private Sub btnEditStatus_Click(sender As Object, e As EventArgs) Handles btnEditStatus.Click
        If NomorTerpilih() = "" Then
            MessageBox.Show("Pilih satu pesanan terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        menuStatus.Show(btnEditStatus, New Point(0, btnEditStatus.Height))
    End Sub

    Private Sub SaatStatusDipilih(sender As Object, e As EventArgs)
        Dim nomor As String = NomorTerpilih()
        If nomor = "" Then Return
        Dim statusBaru As String = DirectCast(sender, ToolStripMenuItem).Text

        If statusBaru = "Dibatalkan" Then
            If MessageBox.Show("Batalkan pesanan " & nomor & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        End If
        DataStore.UbahStatus(nomor, statusBaru)
        TampilkanData()
    End Sub

End Class