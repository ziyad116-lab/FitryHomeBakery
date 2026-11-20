Imports System.Globalization

Public Class FrmCatatPembayaran

    Private ReadOnly budaya As New CultureInfo("id-ID")
    Private ReadOnly dtTagihan As DataTable
    Private ReadOnly dtTransaksi As DataTable
    Private ReadOnly nomorAwal As String

    ' Angka asli (bukan teks) dari pesanan yang sedang dipilih
    Private totalTagihanTerpilih As Decimal
    Private totalDibayarTerpilih As Decimal
    Private sisaTerpilih As Decimal

    ' Kontrol (dibuat lewat kode, nama sesuai modul)
    Private lblPilihPesanan, lblNamaPelanggan, lblTotalTagihan, lblTotalDibayar As Label
    Private lblSisaTagihan, lblJumlahBayar, lblMetodePembayaran, lblTanggalPembayaran As Label
    Private WithEvents cmbPilihPesanan As ComboBox
    Private txtNamaPelanggan, txtTotalTagihan, txtTotalDibayar, txtSisaTagihan As TextBox
    Private WithEvents txtJumlahBayar As TextBox
    Private cmbMetodePembayaran As ComboBox
    Private dtpTanggalPembayaran As DateTimePicker
    Private WithEvents btnSimpanPembayaran As Button
    Private WithEvents btnBatalPembayaran As Button

    Private ReadOnly warnaTeks As Color = Color.FromArgb(73, 51, 43)

    Public Sub New(tagihan As DataTable, transaksi As DataTable, Optional nomorPesananAwal As String = "")
        InitializeComponent()
        dtTagihan = tagihan
        dtTransaksi = transaksi
        nomorAwal = nomorPesananAwal
    End Sub

    ' ============================================================
    '  LOAD
    ' ============================================================
    Private Sub FrmCatatPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BangunTampilan()
        IsiDaftarPesanan()
    End Sub

    Private Function BuatLabel(teks As String, y As Integer) As Label
        Dim lbl As New Label With {
            .Text = teks,
            .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
            .ForeColor = Tema.CoklatSedang,
            .AutoSize = False,
            .Size = New Size(160, 28),
            .TextAlign = ContentAlignment.MiddleLeft,
            .Location = New Point(24, y)
        }
        Controls.Add(lbl)
        Return lbl
    End Function

    Private Function BuatTextBox(nama As String, y As Integer, readOnlyBox As Boolean) As TextBox
        Dim t As New TextBox With {
            .Name = nama,
            .ReadOnly = readOnlyBox,
            .BorderStyle = BorderStyle.FixedSingle,
            .Location = New Point(190, y),
            .Size = New Size(360, 28),
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        }
        If readOnlyBox Then t.BackColor = Tema.Pasir
        Controls.Add(t)
        Return t
    End Function

    Private Function BuatCombo(nama As String, y As Integer) As ComboBox
        Dim c As New ComboBox With {
            .Name = nama,
            .DropDownStyle = ComboBoxStyle.DropDownList,
            .Location = New Point(190, y),
            .Size = New Size(360, 28),
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        }
        Controls.Add(c)
        Return c
    End Function

    Private Sub BangunTampilan()
        ' Header coklat, sama seperti halaman lain
        Dim pnlJudul As New Panel With {.Dock = DockStyle.Top, .Height = 56, .BackColor = Tema.CoklatTua}
        pnlJudul.Controls.Add(New Label With {
            .Text = "Catat Pembayaran", .AutoSize = True,
            .Font = New Font("Segoe UI", 15.0F, FontStyle.Bold),
            .ForeColor = Color.White, .Location = New Point(24, 12)
        })
        Controls.Add(pnlJudul)
        ClientSize = New Size(580, 500)

        Dim y As Integer = 76
        Const langkah As Integer = 40

        lblPilihPesanan = BuatLabel("Pilih Pesanan", y)
        cmbPilihPesanan = BuatCombo("cmbPilihPesanan", y) : y += langkah

        lblNamaPelanggan = BuatLabel("Nama Pelanggan", y)
        txtNamaPelanggan = BuatTextBox("txtNamaPelanggan", y, True) : y += langkah

        lblTotalTagihan = BuatLabel("Total Tagihan", y)
        txtTotalTagihan = BuatTextBox("txtTotalTagihan", y, True) : y += langkah

        lblTotalDibayar = BuatLabel("Total Dibayar", y)
        txtTotalDibayar = BuatTextBox("txtTotalDibayar", y, True) : y += langkah

        lblSisaTagihan = BuatLabel("Sisa Tagihan", y)
        txtSisaTagihan = BuatTextBox("txtSisaTagihan", y, True) : y += langkah

        lblJumlahBayar = BuatLabel("Jumlah Pembayaran", y)
        txtJumlahBayar = BuatTextBox("txtJumlahBayar", y, False) : y += langkah

        lblMetodePembayaran = BuatLabel("Metode Pembayaran", y)
        cmbMetodePembayaran = BuatCombo("cmbMetodePembayaran", y)
        cmbMetodePembayaran.Items.AddRange(New Object() {"Tunai", "Transfer Bank", "QRIS"})
        cmbMetodePembayaran.SelectedIndex = -1   ' dikosongkan: dipilih sendiri oleh pengguna
        y += langkah

        lblTanggalPembayaran = BuatLabel("Tanggal Pembayaran", y)
        dtpTanggalPembayaran = New DateTimePicker With {
            .Name = "dtpTanggalPembayaran",
            .Format = DateTimePickerFormat.Short,
            .Location = New Point(190, y),
            .Size = New Size(160, 28)
        }
        Controls.Add(dtpTanggalPembayaran)
        y += langkah + 10

        btnSimpanPembayaran = New Button With {
            .Name = "btnSimpanPembayaran",
            .Text = "Simpan Pembayaran",
            .Size = New Size(170, 40),
            .Location = New Point(190, y),
            .BackColor = Tema.CoklatSedang,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat,
            .Cursor = Cursors.Hand
        }
        btnSimpanPembayaran.FlatAppearance.BorderSize = 0
        Controls.Add(btnSimpanPembayaran)

        btnBatalPembayaran = New Button With {
            .Name = "btnBatalPembayaran",
            .Text = "Batal",
            .Size = New Size(110, 40),
            .Location = New Point(370, y),
            .BackColor = Tema.Pasir,
            .ForeColor = warnaTeks,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat,
            .Cursor = Cursors.Hand
        }
        btnBatalPembayaran.FlatAppearance.BorderSize = 0
        Controls.Add(btnBatalPembayaran)

        AcceptButton = btnSimpanPembayaran
        CancelButton = btnBatalPembayaran
    End Sub

    ' ============================================================
    '  DAFTAR PESANAN & PERHITUNGAN
    ' ============================================================
    Private Function Rp(nilai As Decimal) As String
        Return Tema.Rupiah(nilai)
    End Function

    Private Function HitungDibayar(nomor As String) As Decimal
        Dim hasil As Object = dtTransaksi.Compute("SUM(Jumlah)", "NomorPesanan = '" & nomor.Replace("'", "''") & "'")
        If IsDBNull(hasil) Then Return 0D
        Return CDec(hasil)
    End Function

    Private Sub IsiDaftarPesanan()
        Dim daftar As New List(Of KeyValuePair(Of String, String))

        ' Hanya pesanan yang masih punya sisa tagihan
        For Each r As DataRow In dtTagihan.Rows
            If r("Status").ToString() = "Dibatalkan" Then Continue For
            Dim nomor As String = r("NomorPesanan").ToString()
            If CDec(r("TotalTagihan")) - HitungDibayar(nomor) > 0D Then
                daftar.Add(New KeyValuePair(Of String, String)(nomor, nomor & " - " & r("NamaPelanggan").ToString()))
            End If
        Next

        If daftar.Count = 0 Then
            MessageBox.Show("Tidak ada pesanan dengan sisa tagihan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BeginInvoke(New Action(Sub() Close()))
            Return
        End If

        cmbPilihPesanan.DisplayMember = "Value"
        cmbPilihPesanan.ValueMember = "Key"
        cmbPilihPesanan.DataSource = daftar

        ' Kosongkan: pengguna memilih pesanan sendiri, tidak ada yang terisi otomatis
        cmbPilihPesanan.SelectedIndex = -1
        TampilkanInfoPesanan()
    End Sub

    Private Sub cmbPilihPesanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPilihPesanan.SelectedIndexChanged
        TampilkanInfoPesanan()
    End Sub

    Private Sub TampilkanInfoPesanan()
        If cmbPilihPesanan.SelectedIndex < 0 OrElse cmbPilihPesanan.SelectedValue Is Nothing Then
            KosongkanInfo()
            Return
        End If
        If TypeOf cmbPilihPesanan.SelectedValue Is KeyValuePair(Of String, String) Then Return

        Dim nomor As String = cmbPilihPesanan.SelectedValue.ToString()
        Dim baris() As DataRow = dtTagihan.Select("NomorPesanan = '" & nomor.Replace("'", "''") & "'")
        If baris.Length = 0 Then Return

        txtNamaPelanggan.Text = baris(0)("NamaPelanggan").ToString()
        totalTagihanTerpilih = CDec(baris(0)("TotalTagihan"))
        totalDibayarTerpilih = HitungDibayar(nomor)

        txtTotalTagihan.Text = Rp(totalTagihanTerpilih)
        txtTotalDibayar.Text = Rp(totalDibayarTerpilih)
        HitungSisaPembayaran()
        txtJumlahBayar.Clear()
    End Sub

    Private Sub KosongkanInfo()
        totalTagihanTerpilih = 0D
        totalDibayarTerpilih = 0D
        sisaTerpilih = 0D
        If txtNamaPelanggan Is Nothing Then Return
        txtNamaPelanggan.Clear()
        txtTotalTagihan.Clear()
        txtTotalDibayar.Clear()
        txtSisaTagihan.Clear()
        txtJumlahBayar.Clear()
    End Sub

    ' Sisa Pembayaran = Total Tagihan - Total Dibayar
    Private Sub HitungSisaPembayaran()
        sisaTerpilih = Math.Max(totalTagihanTerpilih - totalDibayarTerpilih, 0D)
        txtSisaTagihan.Text = Rp(sisaTerpilih)
    End Sub

    ' ============================================================
    '  INPUT JUMLAH (hanya angka)
    ' ============================================================
    Private Sub txtJumlahBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahBayar.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    ' ============================================================
    '  SIMPAN / BATAL
    ' ============================================================
    Private Sub btnSimpanPembayaran_Click(sender As Object, e As EventArgs) Handles btnSimpanPembayaran.Click
        If cmbPilihPesanan.SelectedIndex < 0 Then
            MessageBox.Show("Pilih pesanan terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbMetodePembayaran.SelectedIndex < 0 Then
            MessageBox.Show("Pilih metode pembayaran.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbMetodePembayaran.Focus()
            Return
        End If

        Dim jumlah As Decimal
        If Not Decimal.TryParse(txtJumlahBayar.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, jumlah) OrElse jumlah <= 0D Then
            MessageBox.Show("Masukkan jumlah pembayaran yang valid (lebih dari 0).", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlahBayar.Focus()
            Return
        End If

        If jumlah > sisaTerpilih Then
            MessageBox.Show("Jumlah pembayaran melebihi sisa tagihan (" & Rp(sisaTerpilih) & ").",
                            "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlahBayar.Focus()
            Return
        End If

        ' Simpan sebagai transaksi BARU, data pembayaran lama tidak diubah
        Dim idBaru As String = "PAY" & (dtTransaksi.Rows.Count + 1).ToString("000")
        dtTransaksi.Rows.Add(idBaru,
                             cmbPilihPesanan.SelectedValue.ToString(),
                             jumlah,
                             cmbMetodePembayaran.Text,
                             dtpTanggalPembayaran.Value.Date)

        Dim sisaBaru As Decimal = sisaTerpilih - jumlah
        MessageBox.Show("Pembayaran " & Rp(jumlah) & " berhasil dicatat." & vbCrLf &
                        If(sisaBaru = 0D, "Status pesanan: Lunas.", "Sisa tagihan: " & Rp(sisaBaru)),
                        "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnBatalPembayaran_Click(sender As Object, e As EventArgs) Handles btnBatalPembayaran.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class