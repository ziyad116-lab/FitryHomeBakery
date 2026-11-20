Imports System.Globalization
Imports System.IO

Public Class UcCustomPesanan

    Private lokasiReferensi As String = ""
    Private gambarBawaan As Image
    Private ReadOnly ofdReferensi As New OpenFileDialog With {
        .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
        .Title = "Pilih Foto Referensi"
    }

    Private Sub UcCustomPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode Then Return

        gambarBawaan = PictureBox1.Image
        Label2.Cursor = Cursors.Hand
        Label2.Text = "Upload Referensi (klik gambar)"

        ComboBox1.Items.AddRange(New Object() {"Kue Ulang Tahun", "Cupcake", "Brownies", "Hampers", "Lainnya"})
        ComboBox2.Items.AddRange(New Object() {"Diameter 16 cm", "Diameter 18 cm", "Diameter 20 cm", "Diameter 22 cm", "Diameter 24 cm", "Lainnya"})

        txtNamaPelanggan.PlaceholderText = "Nama pelanggan"
        txtNoWA.PlaceholderText = "Nomor WhatsApp"
        TextBox1.PlaceholderText = "Contoh: pink pastel"
        TextBox2.PlaceholderText = "Contoh: Happy Birthday Sinta"
        TextBox3.PlaceholderText = "Harga dalam rupiah, mis. 250000"
        TextBox4.PlaceholderText = "Catatan tambahan dari pelanggan..."

        Kosongkan()
    End Sub

    ' ============================================================
    '  UPLOAD FOTO REFERENSI (klik gambar atau tulisannya)
    ' ============================================================
    Private Sub PilihFoto(sender As Object, e As EventArgs) Handles PictureBox1.Click, Label2.Click
        If ofdReferensi.ShowDialog(Me.FindForm()) <> DialogResult.OK Then Return
        Try
            Dim baru As Image
            Using fs As New FileStream(ofdReferensi.FileName, FileMode.Open, FileAccess.Read)
                Using asli As Image = Image.FromStream(fs)
                    baru = New Bitmap(asli)
                End Using
            End Using

            If PictureBox1.Image IsNot Nothing AndAlso Not ReferenceEquals(PictureBox1.Image, gambarBawaan) Then
                PictureBox1.Image.Dispose()
            End If
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Image = baru
            lokasiReferensi = ofdReferensi.FileName
            Label2.Text = "Ganti Referensi"
        Catch ex As Exception
            MessageBox.Show("Foto tidak bisa dibuka: " & ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' ============================================================
    '  FORM
    ' ============================================================
    Private Sub Kosongkan()
        txtNamaPelanggan.Clear()
        txtNoWA.Clear()
        dtpTglAmbil.Value = Date.Today.AddDays(1)
        dtpJamAmbil.Value = Date.Today.AddHours(10)
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        If PictureBox1.Image IsNot Nothing AndAlso Not ReferenceEquals(PictureBox1.Image, gambarBawaan) Then
            PictureBox1.Image.Dispose()
        End If
        PictureBox1.Image = gambarBawaan
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        lokasiReferensi = ""
        Label2.Text = "Upload Referensi (klik gambar)"
    End Sub

    ' No. WhatsApp: angka dan +, harga: hanya angka
    Private Sub txtNoWA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoWA.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c Then e.Handled = True
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MessageBox.Show("Kosongkan semua isian pesanan custom ini?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Kosongkan()
    End Sub

    Private Sub Peringatan(pesan As String, kontrol As Control)
        MessageBox.Show(pesan, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        kontrol.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaPelanggan.Text.Trim() = "" Then Peringatan("Nama pelanggan harus diisi.", txtNamaPelanggan) : Return
        If txtNoWA.Text.Trim() = "" Then Peringatan("Nomor WhatsApp harus diisi.", txtNoWA) : Return
        If ComboBox1.SelectedIndex < 0 Then Peringatan("Pilih kategori pesanan.", ComboBox1) : Return
        If ComboBox2.SelectedIndex < 0 Then Peringatan("Pilih ukuran pesanan.", ComboBox2) : Return

        Dim harga As Decimal
        If Not Decimal.TryParse(TextBox3.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, harga) OrElse harga <= 0D Then
            Peringatan("Harga harus diisi dengan angka lebih dari 0.", TextBox3)
            Return
        End If
        If dtpTglAmbil.Value.Date < Date.Today Then Peringatan("Tanggal ambil tidak boleh sebelum hari ini.", dtpTglAmbil) : Return

        Dim catatan As New List(Of String)
        If TextBox1.Text.Trim() <> "" Then catatan.Add("Warna/Tema: " & TextBox1.Text.Trim())
        If TextBox2.Text.Trim() <> "" Then catatan.Add("Tulisan: " & TextBox2.Text.Trim())
        If TextBox4.Text.Trim() <> "" Then catatan.Add("Catatan: " & TextBox4.Text.Trim())

        Dim items As New List(Of ItemKeranjang) From {
            New ItemKeranjang With {.Nama = "Custom " & ComboBox1.Text & " " & ComboBox2.Text, .Harga = harga, .Qty = 1}
        }

        Dim nominal As Decimal? = DialogBantu.TanyaNominal(
            "Total " & Tema.Rupiah(harga) & "." & vbCrLf & "Masukkan nominal DP (angka saja, kosongkan jika belum ada DP):",
            "DP Pesanan Custom", harga, True)
        Dim dp As Decimal = If(nominal.HasValue, nominal.Value, 0D)

        Dim nomor As String = DataStore.SimpanPesanan(
            txtNamaPelanggan.Text.Trim(), txtNoWA.Text.Trim(), "Custom", items,
            Date.Today, dtpTglAmbil.Value, dtpJamAmbil.Value.ToString("HH:mm"),
            String.Join("; ", catatan), lokasiReferensi, dp, "Tunai")

        MessageBox.Show("Pesanan custom " & nomor & " berhasil disimpan.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Kosongkan()
    End Sub

End Class