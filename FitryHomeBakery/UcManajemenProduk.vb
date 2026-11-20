Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Globalization
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Linq

Partial Public Class UcManajemenProduk

    Private ReadOnly produk As New BindingList(Of ProdukItem)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UcManajemenProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If produk.Count = 0 Then
            produk.Add(New ProdukItem With {.Kode = "PRD001", .Nama = "Fudgy Brownies", .Kategori = "Brownies", .Harga = 45000D, .Status = "Tersedia"})
            produk.Add(New ProdukItem With {.Kode = "PRD002", .Nama = "Brownies Lumer", .Kategori = "Brownies", .Harga = 50000D, .Status = "Tersedia"})
            produk.Add(New ProdukItem With {.Kode = "PRD003", .Nama = "Donat Cokelat", .Kategori = "Donat", .Harga = 12000D, .Status = "Tidak Tersedia"})
            TampilkanProduk()
        End If
        AddHandler pnlKartuDaftar.Resize, AddressOf JadwalkanTampilUlang
        saran = New SaranPencarian(txtCariProduk, AddressOf DaftarSaran)
    End Sub

    ' Saran pencarian: nama, kode, dan kategori produk (yang MENGANDUNG teks yang diketik)
    Private saran As SaranPencarian
    Private Function DaftarSaran() As IEnumerable(Of String)
        Dim hasil As New List(Of String)
        For Each p In produk
            hasil.Add(p.Nama)
            hasil.Add(p.Kategori)
            hasil.Add(p.Kode)
        Next
        Return hasil
    End Function

    ' Susun ulang baris saat ukuran jendela berubah, supaya kolom tetap sejajar dengan judul kolom
    Private tampilUlangTerjadwal As Boolean = False
    Private Sub JadwalkanTampilUlang(sender As Object, e As EventArgs)
        If tampilUlangTerjadwal OrElse Not IsHandleCreated Then Return
        tampilUlangTerjadwal = True
        BeginInvoke(New Action(Sub()
                                   tampilUlangTerjadwal = False
                                   TampilkanProduk()
                               End Sub))
    End Sub

    Private Sub txtCariProduk_TextChanged(sender As Object, e As EventArgs) Handles txtCariProduk.TextChanged
        TampilkanProduk()
    End Sub

    Private Sub cmbFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterKategori.SelectedIndexChanged
        TampilkanProduk()
    End Sub

    Private Sub btnTambahProduk_Click(sender As Object, e As EventArgs) Handles btnTambahProduk.Click
        Using frm As New FrmProduk()
            If frm.ShowDialog(Me.FindForm()) = DialogResult.OK Then
                frm.DataProduk.Kode = "PRD" & (produk.Count + 1).ToString("000")
                produk.Add(frm.DataProduk)
                TampilkanProduk()
            End If
        End Using
    End Sub

    Private Sub TampilkanProduk()
        If pnlBarisProduk Is Nothing Then Return
        pnlBarisProduk.SuspendLayout()
        pnlBarisProduk.Controls.Clear()

        Dim kata As String = txtCariProduk.Text.Trim().ToLowerInvariant()
        Dim kategori As String = If(cmbFilterKategori.SelectedItem Is Nothing, "Semua Kategori", cmbFilterKategori.SelectedItem.ToString())

        Dim hasil = produk.Where(Function(p) _
            (p.Nama.ToLowerInvariant().Contains(kata) OrElse p.Kode.ToLowerInvariant().Contains(kata)) AndAlso
            (kategori = "Semua Kategori" OrElse p.Kategori = kategori)).ToList()

        ' Posisi kolom dihitung dari lebar baris, lalu judul kolom disejajarkan ke posisi yang sama
        Dim lebarBaris As Integer = Math.Max(500, pnlBarisProduk.ClientSize.Width - 8)
        Dim pusatHarga As Integer = lebarBaris \ 2 + 40
        Dim pusatStatus As Integer = lebarBaris - 75
        lblKolomHarga.Left = pnlBarisProduk.Left + pusatHarga - lblKolomHarga.Width \ 2
        lblKolomStatus.Left = pnlBarisProduk.Left + pusatStatus - lblKolomStatus.Width \ 2

        For Each p In hasil
            Dim baris As New Panel With {
                .Width = lebarBaris,
                .Height = 104, .BackColor = Color.White, .Margin = New Padding(0)
            }

            Dim nama As New Label With {
                .Text = p.Nama, .AutoSize = True, .Location = New Point(0, 18),
                .Font = New Font("Segoe UI", 14.0F, FontStyle.Bold),
                .ForeColor = Tema.CoklatTua
            }
            Dim kategoriLabel As New Label With {
                .Text = p.Kategori, .AutoSize = True, .Location = New Point(0, 57),
                .Font = New Font("Segoe UI", 10.5F),
                .ForeColor = Tema.TeksRedup
            }
            Dim harga As New Label With {
                .Text = Tema.Rupiah(p.Harga),
                .Size = New Size(150, 35), .Location = New Point(pusatHarga - 75, 32),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Font = New Font("Segoe UI", 10.5F),
                .ForeColor = Tema.CoklatTua
            }
            Dim tersedia As Boolean = (p.Status = "Tersedia")
            Dim status As New Label With {
                .Text = p.Status, .AutoSize = True,
                .Padding = New Padding(9, 4, 9, 4),
                .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold),
                .BackColor = If(tersedia, Tema.LatarSukses, Tema.LatarBahaya),
                .ForeColor = If(tersedia, Tema.Sukses, Tema.Bahaya)
            }
            status.Location = New Point(pusatStatus - status.Width \ 2, 34)
            Dim garis As New Panel With {.Dock = DockStyle.Bottom, .Height = 1, .BackColor = Tema.Pasir}
            baris.Controls.Add(nama)
            baris.Controls.Add(kategoriLabel)
            baris.Controls.Add(harga)
            baris.Controls.Add(status)
            baris.Controls.Add(garis)
            pnlBarisProduk.Controls.Add(baris)
        Next

        If hasil.Count = 0 Then
            pnlBarisProduk.Controls.Add(New Label With {
                .Text = "Belum ada produk yang sesuai.", .AutoSize = True,
                .Padding = New Padding(8, 20, 8, 20), .ForeColor = Tema.TeksRedup
            })
        End If

        pnlBarisProduk.ResumeLayout()
    End Sub

End Class

Public Class ProdukItem
    Public Property Kode As String = ""
    Public Property Nama As String = ""
    Public Property Kategori As String = ""
    Public Property Harga As Decimal
    Public Property Status As String = "Tersedia"
    Public Property LokasiFoto As String = ""
End Class