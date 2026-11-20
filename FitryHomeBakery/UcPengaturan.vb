Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Partial Public Class UcPengaturan

    Private lokasiLogo As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnUploadLogo_Click(sender As Object, e As EventArgs) Handles btnUploadLogo.Click
        If ofdLogoUsaha.ShowDialog() <> DialogResult.OK Then Return
        Try
            Dim gambarBaru As Image
            Using fs As New FileStream(ofdLogoUsaha.FileName, FileMode.Open, FileAccess.Read)
                Using img As Image = Image.FromStream(fs)
                    gambarBaru = New Bitmap(img)
                End Using
            End Using
            If picLogoUsaha.Image IsNot Nothing Then picLogoUsaha.Image.Dispose()
            picLogoUsaha.Image = gambarBaru
            lokasiLogo = ofdLogoUsaha.FileName
        Catch
            MessageBox.Show("File gambar tidak dapat dibuka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnHapusLogo_Click(sender As Object, e As EventArgs) Handles btnHapusLogo.Click
        If picLogoUsaha.Image IsNot Nothing Then
            picLogoUsaha.Image.Dispose()
            picLogoUsaha.Image = Nothing
        End If
        lokasiLogo = ""
    End Sub

    Private Sub btnSimpanPengaturan_Click(sender As Object, e As EventArgs) Handles btnSimpanPengaturan.Click
        If txtNamaUsaha.Text.Trim() = "" Then
            MessageBox.Show("Nama usaha harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaUsaha.Focus()
            Return
        End If
        If txtNomorWhatsApp.Text.Trim() = "" Then
            MessageBox.Show("Nomor WhatsApp harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNomorWhatsApp.Focus()
            Return
        End If

        MessageBox.Show("Informasi sudah diperiksa. Hubungkan tombol ini ke MySQL agar perubahan tersimpan permanen.",
                        "Pengaturan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
