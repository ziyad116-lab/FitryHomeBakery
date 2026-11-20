Imports System.Globalization

Public Class UcPembayaran

    Private ReadOnly budaya As New CultureInfo("id-ID")

    ' Tagihan = satu baris per pesanan (dari DataStore, diisi lewat Tambah Pesanan / Custom Pesanan)
    Private ReadOnly dtTagihan As DataTable = DataStore.Pesanan
    ' Transaksi = setiap pembayaran (DP, pelunasan, dst.) sebagai baris sendiri
    Private ReadOnly dtTransaksi As DataTable = DataStore.Pembayaran

    Private saran As SaranPencarian

    ' ============================================================
    '  LOAD
    ' ============================================================
    Private Sub UcPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DesignMode Then Return

        ' Gaya tabel (header coklat, baris selang-seling, perataan kolom) sudah diatur di Designer
        colStatusPembayaran.DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        cmbFilterPembayaran.SelectedIndex = 0

        saran = New SaranPencarian(txtCariPembayaran, AddressOf DaftarSaran)
        TampilkanData()
    End Sub

    ' ============================================================
    '  SARAN PENCARIAN: nomor pesanan, nama pelanggan, ID pembayaran
    ' ============================================================
    Private Function DaftarSaran() As IEnumerable(Of String)
        Dim hasil As New List(Of String)
        For Each r As DataRow In dtTagihan.Rows
            hasil.Add(r("NomorPesanan").ToString())
            hasil.Add(r("NamaPelanggan").ToString())
        Next
        For Each r As DataRow In dtTransaksi.Rows
            hasil.Add(r("IDPembayaran").ToString())
        Next
        Return hasil
    End Function

    Private Function Rp(nilai As Decimal) As String
        Return Tema.Rupiah(nilai)
    End Function

    Private Function HitungTotalDibayar(nomorPesanan As String) As Decimal
        Dim hasil As Object = dtTransaksi.Compute("SUM(Jumlah)", "NomorPesanan = '" & nomorPesanan.Replace("'", "''") & "'")
        If IsDBNull(hasil) Then Return 0D
        Return CDec(hasil)
    End Function

    Private Function IDTerakhir(nomorPesanan As String) As String
        Dim baris() As DataRow = dtTransaksi.Select("NomorPesanan = '" & nomorPesanan.Replace("'", "''") & "'", "IDPembayaran DESC")
        If baris.Length = 0 Then Return "-"
        Return baris(0)("IDPembayaran").ToString()
    End Function

    Private Sub TampilkanData()
        Dim kata As String = txtCariPembayaran.Text.Trim().ToLower()
        Dim filter As String = cmbFilterPembayaran.Text

        Dim sumTagihan As Decimal = 0D
        Dim sumDiterima As Decimal = 0D

        dgvPembayaran.Rows.Clear()

        For Each r As DataRow In dtTagihan.Rows
            If r("Status").ToString() = "Dibatalkan" Then Continue For
            Dim nomor As String = r("NomorPesanan").ToString()
            Dim total As Decimal = CDec(r("TotalTagihan"))
            Dim dibayar As Decimal = HitungTotalDibayar(nomor)
            Dim sisa As Decimal = Math.Max(total - dibayar, 0D)
            Dim status As String = If(sisa = 0D, "Lunas", "Belum Lunas")

            ' Kartu ringkasan dihitung dari semua pesanan (tidak terpengaruh filter)
            sumTagihan += total
            sumDiterima += dibayar

            If kata <> "" Then
                Dim cocok As Boolean = nomor.ToLower().Contains(kata) OrElse
                                       r("NamaPelanggan").ToString().ToLower().Contains(kata) OrElse
                                       IDTerakhir(nomor).ToLower().Contains(kata)
                If Not cocok Then Continue For
            End If
            If filter <> "Semua Status" AndAlso status <> filter Then Continue For

            dgvPembayaran.Rows.Add(IDTerakhir(nomor), nomor, r("NamaPelanggan"),
                                   Rp(total), Rp(dibayar), Rp(sisa), status)
        Next

        lblNilaiTotalTagihan.Text = Rp(sumTagihan)
        lblNilaiTotalDiterima.Text = Rp(sumDiterima)
        lblNilaiSisaTagihan.Text = Rp(Math.Max(sumTagihan - sumDiterima, 0D))
    End Sub

    ' ============================================================
    '  PENCARIAN & FILTER
    ' ============================================================
    Private Sub btnCariPembayaran_Click(sender As Object, e As EventArgs) Handles btnCariPembayaran.Click
        TampilkanData()
    End Sub

    Private Sub txtCariPembayaran_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariPembayaran.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            TampilkanData()
        End If
    End Sub

    Private Sub cmbFilterPembayaran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterPembayaran.SelectedIndexChanged
        If dtTagihan.Columns.Count > 0 Then TampilkanData()
    End Sub

    ' Pencarian langsung saat mengetik (placeholder memakai PlaceholderText bawaan di Designer)
    Private Sub txtCariPembayaran_TextChanged(sender As Object, e As EventArgs) Handles txtCariPembayaran.TextChanged
        If dtTagihan.Columns.Count > 0 Then TampilkanData()
    End Sub

    ' ============================================================
    '  WARNA STATUS
    ' ============================================================
    Private Sub dgvPembayaran_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPembayaran.CellFormatting
        If e.RowIndex < 0 OrElse e.ColumnIndex <> colStatusPembayaran.Index OrElse e.Value Is Nothing Then Return

        If e.Value.ToString() = "Lunas" Then
            e.CellStyle.BackColor = Tema.LatarSukses
            e.CellStyle.ForeColor = Tema.Sukses
        Else
            e.CellStyle.BackColor = Tema.LatarPeringatan
            e.CellStyle.ForeColor = Tema.CoklatAksen
        End If
        e.CellStyle.SelectionBackColor = e.CellStyle.BackColor
        e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor
    End Sub

    ' ============================================================
    '  CATAT PEMBAYARAN
    ' ============================================================
    Private Sub btnCatatPembayaran_Click(sender As Object, e As EventArgs) Handles btnCatatPembayaran.Click
        ' Form selalu dibuka kosong: pesanan, metode, dan nominal dipilih/diisi sendiri oleh pengguna
        Dim nomorAwal As String = ""

        Using form As New FrmCatatPembayaran(dtTagihan, dtTransaksi, nomorAwal)
            If form.ShowDialog(Me.FindForm()) = DialogResult.OK Then
                ' Transaksi baru sudah ditambahkan ke dtTransaksi oleh form
                DataStore.Simpan()
                TampilkanData()
            End If
        End Using
    End Sub

End Class