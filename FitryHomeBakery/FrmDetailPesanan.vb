Public Class FrmDetailPesanan

    Private ReadOnly nomor As String
    Private ReadOnly daftarItem As List(Of ItemKeranjang)
    Private ReadOnly daftarNud As New List(Of NumericUpDown)
    Private ReadOnly daftarSubtotal As New List(Of Label)
    Private ReadOnly bisaUbah As Boolean

    Public Sub New(nomorPesanan As String)
        InitializeComponent()

        nomor = nomorPesanan
        daftarItem = DataStore.AmbilItem(nomor)
        Dim baris As DataRow = DataStore.AmbilPesanan(nomor)
        Dim status As String = If(baris Is Nothing, "", baris("Status").ToString())
        bisaUbah = DataStore.BelumSelesai(status)

        If baris Is Nothing Then
            Close()
            Return
        End If

        TerapkanTema()

        ' ----- isi teks -----
        Text = "Detail Pesanan " & nomor
        lblJudul.Text = "Detail Pesanan " & nomor
        lblPelanggan.Text = baris("NamaPelanggan").ToString() & "  (" & baris("NoWA").ToString() & ")"
        lblTanggal.Text = CDate(baris("TanggalAmbil")).ToString("dd/MM/yyyy") & "  " & baris("JamAmbil").ToString()
        lblStatus.Text = status
        lblJenis.Text = baris("Jenis").ToString()
        lblCatatan.Text = If(baris("Catatan").ToString() = "", "-", baris("Catatan").ToString())

        ' ----- tabel item (diisi lewat kode karena jumlah baris dinamis) -----
        tblItem.RowCount = 0
        TambahSel(tblItem, "Produk", 0, True, ContentAlignment.MiddleLeft)
        TambahSel(tblItem, "Harga", 1, True, ContentAlignment.MiddleRight)
        TambahSel(tblItem, "Jumlah", 2, True, ContentAlignment.MiddleCenter)
        TambahSel(tblItem, "Subtotal", 3, True, ContentAlignment.MiddleRight)

        For i As Integer = 0 To daftarItem.Count - 1
            Dim it As ItemKeranjang = daftarItem(i)
            TambahSel(tblItem, it.Nama, 0, False, ContentAlignment.MiddleLeft)
            TambahSel(tblItem, Tema.Rupiah(it.Harga), 1, False, ContentAlignment.MiddleRight)

            Dim nud As New NumericUpDown With {
                .Minimum = 0, .Maximum = 99, .Value = Math.Min(99, Math.Max(0, it.Qty)),
                .Width = 70, .TextAlign = HorizontalAlignment.Center,
                .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold),
                .Enabled = bisaUbah, .Anchor = AnchorStyles.None
            }
            AddHandler nud.ValueChanged, AddressOf HitungUlang
            daftarNud.Add(nud)
            tblItem.Controls.Add(nud, 2, i + 1)

            Dim lblSub As Label = TambahSel(tblItem, Tema.Rupiah(it.Subtotal), 3, False, ContentAlignment.MiddleRight)
            daftarSubtotal.Add(lblSub)
        Next

        ' ----- tombol sesuai status -----
        btnTutup.Text = If(bisaUbah, "Batal", "Tutup")
        btnSimpan.Visible = bisaUbah
        lblInfoSelesai.Visible = Not bisaUbah

        HitungUlang(Nothing, EventArgs.Empty)
    End Sub

    ' Warna diambil dari kelas Tema supaya konsisten satu aplikasi
    Private Sub TerapkanTema()
        BackColor = Tema.Krem
        pnlJudul.BackColor = Tema.CoklatTua
        For Each l As Label In {lblPelangganJudul, lblTanggalJudul, lblStatusJudul, lblJenisJudul, lblCatatanJudul}
            l.ForeColor = Tema.CoklatSedang
        Next
        For Each l As Label In {lblPelanggan, lblTanggal, lblStatus, lblJenis, lblCatatan}
            l.ForeColor = Tema.CoklatTua
        Next
        lblTotal.ForeColor = Tema.CoklatTua
        lblInfoSelesai.ForeColor = Tema.TeksRedup
        btnTutup.BackColor = Tema.Pasir
        btnTutup.ForeColor = Tema.CoklatTua
        btnSimpan.BackColor = Tema.CoklatSedang
        btnSimpan.ForeColor = Color.White
    End Sub

    Private Function TambahSel(tbl As TableLayoutPanel, teks As String, kolom As Integer, header As Boolean, rata As ContentAlignment) As Label
        Dim sel As New Label With {
            .Text = teks, .AutoSize = False, .Height = 34, .Dock = DockStyle.Fill,
            .TextAlign = rata, .AutoEllipsis = True, .Margin = New Padding(0),
            .Padding = New Padding(8, 0, 8, 0),
            .Font = New Font("Segoe UI", 9.5F, If(header, FontStyle.Bold, FontStyle.Regular)),
            .ForeColor = If(header, Tema.CoklatSedang, Tema.CoklatTua),
            .BackColor = If(header, Tema.Krem, Color.White)
        }
        tbl.Controls.Add(sel, kolom, tbl.RowCount)
        If kolom = 3 Then tbl.RowCount += 1
        Return sel
    End Function

    Private Sub HitungUlang(sender As Object, e As EventArgs)
        Dim total As Decimal = 0D
        For i As Integer = 0 To daftarItem.Count - 1
            Dim sub1 As Decimal = daftarItem(i).Harga * CInt(daftarNud(i).Value)
            daftarSubtotal(i).Text = Tema.Rupiah(sub1)
            total += sub1
        Next
        lblTotal.Text = "Total: " & Tema.Rupiah(total)

        Dim dibayar As Decimal = DataStore.HitungDibayar(nomor)
        If dibayar >= total Then
            lblSisa.Text = "Dibayar " & Tema.Rupiah(dibayar) & "  -  Lunas"
            lblSisa.ForeColor = Tema.Sukses
        Else
            lblSisa.Text = "Dibayar " & Tema.Rupiah(dibayar) & "  -  Sisa " & Tema.Rupiah(total - dibayar)
            lblSisa.ForeColor = Tema.Peringatan
        End If
    End Sub

    Private Sub SaatSimpan(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim baru As New List(Of ItemKeranjang)
        For i As Integer = 0 To daftarItem.Count - 1
            Dim q As Integer = CInt(daftarNud(i).Value)
            If q > 0 Then baru.Add(New ItemKeranjang With {.Nama = daftarItem(i).Nama, .Harga = daftarItem(i).Harga, .Qty = q})
        Next
        If baru.Count = 0 Then
            MessageBox.Show("Pesanan harus punya minimal satu item." & vbCrLf &
                            "Untuk membatalkan pesanan, ubah statusnya menjadi Dibatalkan.",
                            "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        DataStore.UbahItem(nomor, baru)
        DialogResult = DialogResult.OK
        Close()
    End Sub

End Class