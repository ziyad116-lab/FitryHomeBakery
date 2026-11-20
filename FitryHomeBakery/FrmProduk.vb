Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Partial Public Class FrmProduk

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property DataProduk As New ProdukItem()
    Private lokasiFoto As String = ""

    Public Sub New()
        InitializeComponent()
        cmbKategoriProduk.SelectedIndex = 0
        cmbStatusProduk.SelectedIndex = 0
    End Sub

    Private Sub btnUploadFoto_Click(sender As Object, e As EventArgs) Handles btnUploadFoto.Click
        If ofdFotoProduk.ShowDialog(Me) <> DialogResult.OK Then Return
        Try
            Dim gambarBaru As Image
            Using fs As New FileStream(ofdFotoProduk.FileName, FileMode.Open, FileAccess.Read)
                Using img As Image = Image.FromStream(fs)
                    gambarBaru = New Bitmap(img)
                End Using
            End Using
            If picFotoProduk.Image IsNot Nothing Then picFotoProduk.Image.Dispose()
            picFotoProduk.Image = gambarBaru
            lokasiFoto = ofdFotoProduk.FileName
        Catch
            MessageBox.Show("Foto tidak dapat dibuka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnSimpanProduk_Click(sender As Object, e As EventArgs) Handles btnSimpanProduk.Click
        Dim harga As Decimal
        If txtNamaProduk.Text.Trim() = "" Then
            MessageBox.Show("Nama produk harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaProduk.Focus()
            Return
        End If
        If Not Decimal.TryParse(txtHargaProduk.Text.Trim(), harga) OrElse harga < 0D Then
            MessageBox.Show("Masukkan harga berupa angka yang benar.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHargaProduk.Focus()
            Return
        End If

        DataProduk = New ProdukItem With {
            .Nama = txtNamaProduk.Text.Trim(),
            .Kategori = cmbKategoriProduk.Text,
            .Harga = harga,
            .Status = cmbStatusProduk.Text,
            .Kode = ""
        }
        lokasiFoto = lokasiFoto
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBatalProduk_Click(sender As Object, e As EventArgs) Handles btnBatalProduk.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
