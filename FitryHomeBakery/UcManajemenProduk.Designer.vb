<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcManajemenProduk
    Inherits System.Windows.Forms.UserControl

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents txtCariProduk As TextBox
    Friend WithEvents cmbFilterKategori As ComboBox
    Friend WithEvents btnTambahProduk As Button
    Friend WithEvents pnlKartuDaftar As Panel
    Friend WithEvents lblDaftarProduk As Label
    Friend WithEvents lblKolomNama As Label
    Friend WithEvents lblKolomHarga As Label
    Friend WithEvents lblKolomStatus As Label
    Friend WithEvents pnlBarisProduk As FlowLayoutPanel

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtCariProduk = New TextBox()
        cmbFilterKategori = New ComboBox()
        btnTambahProduk = New Button()
        pnlKartuDaftar = New Panel()
        pnlBarisProduk = New FlowLayoutPanel()
        lblKolomNama = New Label()
        lblKolomHarga = New Label()
        lblKolomStatus = New Label()
        lblDaftarProduk = New Label()
        lblDeskripsiProduk = New Label()
        lblJudulManajemenProduk = New Label()
        pnlHeader = New Panel()
        pnlKartuDaftar.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        pnlHeader.Controls.Add(lblJudulManajemenProduk)
        pnlHeader.Controls.Add(lblDeskripsiProduk)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1138, 48)
        pnlHeader.TabIndex = 0
        ' 
        ' lblDeskripsiProduk
        ' 
        lblDeskripsiProduk.AutoSize = True
        lblDeskripsiProduk.Font = New Font("Segoe UI", 10.5F)
        lblDeskripsiProduk.ForeColor = Color.FromArgb(CByte(238), CByte(228), CByte(220))
        lblDeskripsiProduk.Location = New Point(24, 10)
        lblDeskripsiProduk.Name = "lblDeskripsiProduk"
        lblDeskripsiProduk.Size = New Size(374, 28)
        lblDeskripsiProduk.TabIndex = 1
        lblDeskripsiProduk.Text = "Kelola daftar produk Fitry Homebakery."
        ' 
        ' lblJudulManajemenProduk (judul sudah tampil di header utama, jadi disembunyikan)
        ' 
        lblJudulManajemenProduk.AutoSize = True
        lblJudulManajemenProduk.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblJudulManajemenProduk.ForeColor = Color.White
        lblJudulManajemenProduk.Location = New Point(24, 8)
        lblJudulManajemenProduk.Name = "lblJudulManajemenProduk"
        lblJudulManajemenProduk.Size = New Size(392, 54)
        lblJudulManajemenProduk.TabIndex = 0
        lblJudulManajemenProduk.Text = "Manajemen Produk"
        lblJudulManajemenProduk.Visible = False
        ' 
        ' txtCariProduk
        ' 
        txtCariProduk.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCariProduk.BorderStyle = BorderStyle.FixedSingle
        txtCariProduk.Font = New Font("Segoe UI", 10.5F)
        txtCariProduk.Location = New Point(24, 64)
        txtCariProduk.Name = "txtCariProduk"
        txtCariProduk.PlaceholderText = "Cari nama produk..."
        txtCariProduk.Size = New Size(626, 35)
        txtCariProduk.TabIndex = 1
        ' 
        ' cmbFilterKategori
        ' 
        cmbFilterKategori.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbFilterKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilterKategori.Font = New Font("Segoe UI", 10.5F)
        cmbFilterKategori.FormattingEnabled = True
        cmbFilterKategori.Items.AddRange(New Object() {"Semua Kategori", "Brownies", "Kue Bolu", "Jajanan Pasar", "Pastry", "Kue Kering", "Donat", "Asinan", "Pizza"})
        cmbFilterKategori.Location = New Point(662, 64)
        cmbFilterKategori.Name = "cmbFilterKategori"
        cmbFilterKategori.Size = New Size(240, 38)
        cmbFilterKategori.TabIndex = 2
        ' 
        ' btnTambahProduk
        ' 
        btnTambahProduk.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTambahProduk.BackColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        btnTambahProduk.Cursor = Cursors.Hand
        btnTambahProduk.FlatAppearance.BorderSize = 0
        btnTambahProduk.FlatStyle = FlatStyle.Flat
        btnTambahProduk.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnTambahProduk.ForeColor = Color.White
        btnTambahProduk.Location = New Point(914, 64)
        btnTambahProduk.Name = "btnTambahProduk"
        btnTambahProduk.Size = New Size(200, 36)
        btnTambahProduk.TabIndex = 3
        btnTambahProduk.Text = "+ Tambah Produk"
        btnTambahProduk.UseVisualStyleBackColor = False
        ' 
        ' pnlKartuDaftar
        ' 
        pnlKartuDaftar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlKartuDaftar.BackColor = Color.White
        pnlKartuDaftar.Controls.Add(pnlBarisProduk)
        pnlKartuDaftar.Controls.Add(lblKolomNama)
        pnlKartuDaftar.Controls.Add(lblKolomHarga)
        pnlKartuDaftar.Controls.Add(lblKolomStatus)
        pnlKartuDaftar.Controls.Add(lblDaftarProduk)
        pnlKartuDaftar.Location = New Point(24, 116)
        pnlKartuDaftar.Name = "pnlKartuDaftar"
        pnlKartuDaftar.Padding = New Padding(12)
        pnlKartuDaftar.Size = New Size(1090, 581)
        pnlKartuDaftar.TabIndex = 4
        ' 
        ' lblDaftarProduk
        ' 
        lblDaftarProduk.AutoSize = True
        lblDaftarProduk.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblDaftarProduk.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblDaftarProduk.Location = New Point(12, 12)
        lblDaftarProduk.Name = "lblDaftarProduk"
        lblDaftarProduk.Size = New Size(160, 32)
        lblDaftarProduk.TabIndex = 0
        lblDaftarProduk.Text = "Daftar Produk"
        ' 
        ' lblKolomNama
        ' 
        lblKolomNama.AutoSize = True
        lblKolomNama.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKolomNama.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblKolomNama.Location = New Point(12, 59)
        lblKolomNama.Name = "lblKolomNama"
        lblKolomNama.Size = New Size(141, 28)
        lblKolomNama.TabIndex = 1
        lblKolomNama.Text = "Nama Produk"
        ' 
        ' lblKolomHarga
        ' 
        lblKolomHarga.Anchor = AnchorStyles.Top
        lblKolomHarga.AutoSize = True
        lblKolomHarga.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKolomHarga.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblKolomHarga.Location = New Point(542, 59)
        lblKolomHarga.Name = "lblKolomHarga"
        lblKolomHarga.Size = New Size(69, 28)
        lblKolomHarga.TabIndex = 2
        lblKolomHarga.Text = "Harga"
        ' 
        ' lblKolomStatus
        ' 
        lblKolomStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblKolomStatus.AutoSize = True
        lblKolomStatus.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKolomStatus.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblKolomStatus.Location = New Point(1000, 59)
        lblKolomStatus.Name = "lblKolomStatus"
        lblKolomStatus.Size = New Size(71, 28)
        lblKolomStatus.TabIndex = 3
        lblKolomStatus.Text = "Status"
        ' 
        ' pnlBarisProduk
        ' 
        pnlBarisProduk.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlBarisProduk.AutoScroll = True
        pnlBarisProduk.FlowDirection = FlowDirection.TopDown
        pnlBarisProduk.Location = New Point(12, 91)
        pnlBarisProduk.Name = "pnlBarisProduk"
        pnlBarisProduk.Size = New Size(1066, 478)
        pnlBarisProduk.TabIndex = 4
        pnlBarisProduk.WrapContents = False
        ' 
        ' UcManajemenProduk
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        Controls.Add(pnlKartuDaftar)
        Controls.Add(btnTambahProduk)
        Controls.Add(cmbFilterKategori)
        Controls.Add(txtCariProduk)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 10.0F)
        Name = "UcManajemenProduk"
        Size = New Size(1138, 721)
        pnlKartuDaftar.ResumeLayout(False)
        pnlKartuDaftar.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDeskripsiProduk As Label
    Friend WithEvents lblJudulManajemenProduk As Label
    Friend WithEvents pnlHeader As Panel
End Class