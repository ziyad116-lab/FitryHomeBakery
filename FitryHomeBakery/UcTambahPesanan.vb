Imports System.Globalization

Public Class UcTambahPesanan

    Private Class KartuProduk
        Public Nama As String = ""
        Public Harga As Decimal
        Public Qty As Integer = 0
        Public LabelQty As Label
    End Class

    Private Const MaksQty As Integer = 99

    Private ReadOnly daftarKartu As New List(Of KartuProduk)
    Private flpKeranjang As FlowLayoutPanel
    Private lblIdPesanan As Label
    Private idPesananBaru As String = ""
    Private tampilanSudahDiatur As Boolean = False

    Private Sub AturTampilan(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode OrElse tampilanSudahDiatur Then Return
        tampilanSudahDiatur = True
        Try
            AturTampilanInti()
        Catch ex As Exception
            Me.ResumeLayout(True)
            MessageBox.Show("Halaman Tambah Pesanan gagal disiapkan:" & vbCrLf & vbCrLf & ex.ToString(),
                            "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AturTampilanInti()
        Me.SuspendLayout()

        ' ===== 1. KATALOG: kartu produk masuk FlowLayoutPanel =====
        Dim kartu = pnlKatalog.Controls.OfType(Of Panel)().
                    OrderBy(Function(p) p.Top).ThenBy(Function(p) p.Left).ToList()

        Dim flpKatalog As New FlowLayoutPanel With {
            .Dock = DockStyle.Fill,
            .AutoScroll = True,
            .WrapContents = True,
            .FlowDirection = FlowDirection.LeftToRight,
            .BackColor = pnlKatalog.BackColor,
            .Padding = New Padding(8)
        }
        For Each k In kartu
            k.Margin = New Padding(8)
            flpKatalog.Controls.Add(k)
        Next

        Label1.AutoSize = False
        Label1.Dock = DockStyle.Top
        Label1.Height = 56
        Label1.Padding = New Padding(16, 0, 0, 0)
        Label1.TextAlign = ContentAlignment.MiddleLeft

        pnlKatalog.Controls.Add(flpKatalog)
        flpKatalog.BringToFront()

        ' Jumlah tiap produk dimulai dari 0 dan diatur dengan tombol - dan +
        PasangKartu(Panel1, lblNamaBolen, lblHargaBolen, Label2, Button7, Button1)
        PasangKartu(Panel2, lblNamaDonat, lblHargaDonat, Label3, Button8, Button2)
        PasangKartu(Panel3, lblNamaBrownies, lblHargaBrownies, Label4, Button9, Button3)
        PasangKartu(Panel4, lblNamaAsinan, lblHargaAsinan, Label5, Button10, Button4)
        PasangKartu(Panel6, lblNamaBoluKetanHitam, lblHargaBoluKetanHitam, Label6, Button11, Button5)
        PasangKartu(Panel5, lblNamaPizzaMini, lblHargaPizzaMini, Label7, Button12, Button6)

        ' ===== 2. KERANJANG (Panel7) =====
        ' isi tiruan dari Designer disembunyikan, diganti keranjang yang berisi pesanan sebenarnya
        For Each l In New Label() {Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16, Label17}
            l.Visible = False
        Next

        Panel7.Padding = New Padding(0, 52, 0, 16)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.WrapContents = False
        AddHandler FlowLayoutPanel1.SizeChanged, AddressOf SesuaikanTotal
        AddHandler Panel7.Resize,
            Sub(s, ev) Label8.Left = (Panel7.ClientSize.Width - Label8.Width) \ 2

        Dim pnlIsi As New Panel With {.Dock = DockStyle.Fill, .BackColor = Color.White}
        flpKeranjang = New FlowLayoutPanel With {
            .Dock = DockStyle.Fill,
            .FlowDirection = FlowDirection.TopDown,
            .WrapContents = False,
            .AutoScroll = True,
            .BackColor = Color.White,
            .Padding = New Padding(12, 4, 12, 4)
        }
        Dim pnlJudulKolom As New Panel With {.Dock = DockStyle.Top, .Height = 34, .BackColor = Tema.Krem, .Padding = New Padding(12, 0, 12, 0)}
        Dim barisJudul As TableLayoutPanel = BuatBaris("Produk", "Qty", "Subtotal", True, 100)
        barisJudul.Dock = DockStyle.Fill
        pnlJudulKolom.Controls.Add(barisJudul)
        pnlIsi.Controls.Add(flpKeranjang)
        pnlIsi.Controls.Add(pnlJudulKolom)


        ' ===== 3. KERANGKA 2 KOLOM =====
        Dim lebarKanan As Integer = CInt(380 * Me.DeviceDpi / 96.0)
        Dim tinggiPanel8 As Integer = Panel8.Height

        Panel8.Dock = DockStyle.Fill
        Panel8.Margin = New Padding(16, 8, 8, 8)
        Panel7.Margin = New Padding(8)

        Dim tlp As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 2,
            .RowCount = 2,
            .BackColor = Me.BackColor
        }
        tlp.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlp.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, lebarKanan))
        tlp.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, tinggiPanel8 + Panel8.Margin.Vertical))

        tlp.Controls.Add(pnlKatalog, 0, 0)
        tlp.Controls.Add(Panel8, 0, 1)
        tlp.Controls.Add(Panel7, 1, 0)
        tlp.SetRowSpan(Panel7, 2)
        pnlKatalog.Dock = DockStyle.Fill
        Panel7.Dock = DockStyle.Fill

        Me.Controls.Add(tlp)
        tlp.BringToFront()

        ' ===== 4. LABEL ID PESANAN (di samping judul "Data Pelanggan") =====
        lblIdPesanan = New Label With {
            .AutoSize = True,
            .Font = New Font("Segoe UI", 11.0F, FontStyle.Bold),
            .ForeColor = Tema.CoklatSedang,
            .Location = New Point(Label20.Right + 40, Label20.Top + 4)
        }
        Panel8.Controls.Add(lblIdPesanan)

        ' ===== 5. ISIAN DATA PELANGGAN =====
        TextBox1.PlaceholderText = "Nama pelanggan"
        TextBox2.PlaceholderText = "Nomor WhatsApp"
        ComboBox1.Items.AddRange(New Object() {"Belum Bayar", "DP", "Lunas"})
        SetelAwalForm()

        Me.ResumeLayout(True)

        ' keranjang dikosongkan lebih dulu (Rp0), baru nomor pesanan dimuat
        PerbaruiKeranjang()
        MuatIdPesanan()
    End Sub

    ' ============================================================
    '  KARTU PRODUK + NUMERICUPDOWN
    ' ============================================================
    Private Sub PasangKartu(kartu As Panel, lblNama As Label, lblHarga As Label, lblQty As Label, btnMin As Button, btnPlus As Button)
        Dim k As New KartuProduk With {
            .Nama = lblNama.Text,
            .Harga = UraiRupiah(lblHarga.Text),
            .Qty = 0,
            .LabelQty = lblQty
        }
        daftarKartu.Add(k)

        ' angka di antara tombol - dan +, selalu mulai dari 0
        lblQty.AutoSize = False
        lblQty.Location = New Point(btnMin.Right + 4, btnMin.Top)
        lblQty.Size = New Size(btnPlus.Left - btnMin.Right - 8, btnMin.Height)
        lblQty.TextAlign = ContentAlignment.MiddleCenter
        lblQty.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblQty.Text = "0"
        lblQty.Visible = True
        btnMin.Visible = True
        btnPlus.Visible = True
        btnMin.Enabled = False
        btnMin.Cursor = Cursors.Hand
        btnPlus.Cursor = Cursors.Hand

        AddHandler btnPlus.Click, Sub(s, ev) UbahQty(k, btnMin, btnPlus, 1)
        AddHandler btnMin.Click, Sub(s, ev) UbahQty(k, btnMin, btnPlus, -1)
    End Sub

    Private Sub UbahQty(k As KartuProduk, btnMin As Button, btnPlus As Button, selisih As Integer)
        k.Qty = Math.Max(0, Math.Min(MaksQty, k.Qty + selisih))
        k.LabelQty.Text = k.Qty.ToString()
        btnMin.Enabled = k.Qty > 0
        btnPlus.Enabled = k.Qty < MaksQty
        PerbaruiKeranjang()
    End Sub

    Private Function UraiRupiah(teks As String) As Decimal
        Dim bagian As String = teks.Split(","c)(0)
        Dim angka As String = New String(bagian.Where(Function(c) Char.IsDigit(c)).ToArray())
        If angka = "" Then Return 0D
        Return Decimal.Parse(angka, CultureInfo.InvariantCulture)
    End Function

    ' ============================================================
    '  KERANJANG
    ' ============================================================
    Private Function BuatSel(teks As String, rata As ContentAlignment, fon As Font, warna As Color) As Label
        Return New Label With {
            .Text = teks, .Dock = DockStyle.Fill, .TextAlign = rata,
            .AutoEllipsis = True, .Font = fon, .ForeColor = warna, .Margin = New Padding(0)
        }
    End Function

    Private Function BuatBaris(nama As String, qty As String, subtotal As String, header As Boolean, lebar As Integer) As TableLayoutPanel
        Dim baris As New TableLayoutPanel With {
            .ColumnCount = 3,
            .RowCount = 1,
            .Height = If(header, 34, 32),
            .Width = lebar,
            .Margin = New Padding(0),
            .BackColor = If(header, Tema.Krem, Color.White)
        }
        baris.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        baris.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        baris.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
        baris.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))

        Dim fon As New Font("Segoe UI", 9.5F, If(header, FontStyle.Bold, FontStyle.Regular))
        Dim warna As Color = If(header, Tema.CoklatSedang, Tema.CoklatTua)
        baris.Controls.Add(BuatSel(nama, ContentAlignment.MiddleLeft, fon, warna), 0, 0)
        baris.Controls.Add(BuatSel(qty, ContentAlignment.MiddleCenter, fon, warna), 1, 0)
        baris.Controls.Add(BuatSel(subtotal, ContentAlignment.MiddleRight, fon, warna), 2, 0)
        Return baris
    End Function

    Private Sub PerbaruiKeranjang()
        If flpKeranjang Is Nothing Then Return

        flpKeranjang.SuspendLayout()
        Dim lama As List(Of Control) = flpKeranjang.Controls.Cast(Of Control)().ToList()
        flpKeranjang.Controls.Clear()
        For Each c In lama
            c.Dispose()
        Next

        Dim lebar As Integer = Math.Max(100, flpKeranjang.ClientSize.Width - flpKeranjang.Padding.Horizontal)
        Dim total As Decimal = 0D
        For Each k In daftarKartu
            Dim q As Integer = k.Qty
            If q > 0 Then
                Dim subtotal As Decimal = k.Harga * q
                total += subtotal
                flpKeranjang.Controls.Add(BuatBaris(k.Nama, "x" & q.ToString(), Tema.Rupiah(subtotal), False, lebar))
            End If
        Next

        If total = 0D Then
            flpKeranjang.Controls.Add(New Label With {
                .Text = "Keranjang masih kosong." & vbCrLf & "Atur jumlah produk di katalog.",
                .AutoSize = False, .Width = lebar, .Height = 60,
                .TextAlign = ContentAlignment.MiddleCenter, .ForeColor = Tema.TeksRedup
            })
        End If

        Label19.Text = Tema.Rupiah(total)
        flpKeranjang.ResumeLayout()
    End Sub

    Private Sub SesuaikanTotal(sender As Object, e As EventArgs)
        Dim sisa As Integer = FlowLayoutPanel1.ClientSize.Width -
                              Label18.Width - Label18.Margin.Horizontal - Label19.Margin.Horizontal - 4
        If sisa > 50 Then Label19.Width = sisa
    End Sub

    Private Function KumpulkanItem() As List(Of ItemKeranjang)
        Dim hasil As New List(Of ItemKeranjang)
        For Each k In daftarKartu
            If k.Qty > 0 Then
                hasil.Add(New ItemKeranjang With {.Nama = k.Nama, .Harga = k.Harga, .Qty = k.Qty})
            End If
        Next
        Return hasil
    End Function

    ' ============================================================
    '  ID PESANAN OTOMATIS
    ' ============================================================
    Private Sub MuatIdPesanan()
        idPesananBaru = DataStore.BuatNomorPesanan()
        lblIdPesanan.Text = "No. Pesanan: " & idPesananBaru
    End Sub

    ' ============================================================
    '  FORM
    ' ============================================================
    Private Sub SetelAwalForm()
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = 0
        DateTimePicker1.Value = Date.Today
        DateTimePicker2.Value = Date.Today.AddDays(1)
        dtpJamAmbil.Value = Date.Today.AddHours(10)
        For Each k In daftarKartu
            k.Qty = 0
            k.LabelQty.Text = "0"
            For Each c As Control In k.LabelQty.Parent.Controls
                If TypeOf c Is Button AndAlso c.Text = "-" Then c.Enabled = False
                If TypeOf c Is Button AndAlso c.Text = "+" Then c.Enabled = True
            Next
        Next
    End Sub

    ' No. WhatsApp: hanya angka dan tanda +
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c Then e.Handled = True
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        SetelAwalForm()
        PerbaruiKeranjang()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Nama pelanggan harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Return
        End If
        If TextBox2.Text.Trim() = "" Then
            MessageBox.Show("Nomor WhatsApp harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            Return
        End If
        Dim items As List(Of ItemKeranjang) = KumpulkanItem()
        If items.Count = 0 Then
            MessageBox.Show("Pilih minimal satu produk di katalog (atur jumlahnya).", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If DateTimePicker2.Value.Date < DateTimePicker1.Value.Date Then
            MessageBox.Show("Tanggal ambil tidak boleh sebelum tanggal pesan.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker2.Focus()
            Return
        End If

        Dim total As Decimal = items.Sum(Function(i) i.Subtotal)
        Dim dp As Decimal = 0D
        Select Case ComboBox1.Text
            Case "Lunas"
                dp = total
            Case "DP"
                Dim nominal As Decimal? = DialogBantu.TanyaNominal(
                    "Total tagihan " & Tema.Rupiah(total) & "." & vbCrLf & "Masukkan nominal DP (angka saja):",
                    "DP Pesanan", total, False)
                If Not nominal.HasValue OrElse nominal.Value <= 0D Then Return
                dp = nominal.Value
        End Select

        Dim nomor As String = DataStore.SimpanPesanan(
            TextBox1.Text.Trim(), TextBox2.Text.Trim(), "Reguler", items,
            DateTimePicker1.Value, DateTimePicker2.Value, dtpJamAmbil.Value.ToString("HH:mm"),
            "", "", dp, "Tunai")

        MessageBox.Show("Pesanan " & nomor & " berhasil disimpan." & vbCrLf &
                        "Total: " & Tema.Rupiah(total) & If(dp > 0D, vbCrLf & "Dibayar: " & Tema.Rupiah(dp), ""),
                        "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

        SetelAwalForm()
        PerbaruiKeranjang()
        MuatIdPesanan()
    End Sub

End Class