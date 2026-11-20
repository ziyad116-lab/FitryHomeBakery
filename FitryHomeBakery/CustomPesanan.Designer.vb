<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomPesanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomPesanan))
        pnlSidebar = New Panel()
        btnPengaturan = New Button()
        btnPembayaran = New Button()
        btnManajemenProduk = New Button()
        btnCustomPesanan = New Button()
        btnDataPesanan = New Button()
        btnTambahPesanan = New Button()
        btnBeranda = New Button()
        lblNamaAplikasi = New Label()
        pnlHeader = New Panel()
        lblJudulHalaman = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label21 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Panel2 = New Panel()
        Label6 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label7 = New Label()
        pnlSidebar.SuspendLayout()
        pnlHeader.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        pnlSidebar.Controls.Add(btnPengaturan)
        pnlSidebar.Controls.Add(btnPembayaran)
        pnlSidebar.Controls.Add(btnManajemenProduk)
        pnlSidebar.Controls.Add(btnCustomPesanan)
        pnlSidebar.Controls.Add(btnDataPesanan)
        pnlSidebar.Controls.Add(btnTambahPesanan)
        pnlSidebar.Controls.Add(btnBeranda)
        pnlSidebar.Controls.Add(lblNamaAplikasi)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(240, 599)
        pnlSidebar.TabIndex = 1
        ' 
        ' btnPengaturan
        ' 
        btnPengaturan.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPengaturan.ForeColor = Color.White
        btnPengaturan.Location = New Point(16, 376)
        btnPengaturan.Name = "btnPengaturan"
        btnPengaturan.Size = New Size(210, 45)
        btnPengaturan.TabIndex = 7
        btnPengaturan.Text = "Pengaturan"
        btnPengaturan.TextAlign = ContentAlignment.MiddleLeft
        btnPengaturan.UseVisualStyleBackColor = False
        ' 
        ' btnPembayaran
        ' 
        btnPembayaran.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPembayaran.ForeColor = Color.White
        btnPembayaran.Location = New Point(16, 325)
        btnPembayaran.Name = "btnPembayaran"
        btnPembayaran.Size = New Size(210, 45)
        btnPembayaran.TabIndex = 6
        btnPembayaran.Text = "Pembayaran"
        btnPembayaran.TextAlign = ContentAlignment.MiddleLeft
        btnPembayaran.UseVisualStyleBackColor = False
        ' 
        ' btnManajemenProduk
        ' 
        btnManajemenProduk.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManajemenProduk.ForeColor = Color.White
        btnManajemenProduk.Location = New Point(16, 274)
        btnManajemenProduk.Name = "btnManajemenProduk"
        btnManajemenProduk.Size = New Size(210, 45)
        btnManajemenProduk.TabIndex = 5
        btnManajemenProduk.Text = "Manajemen Produk"
        btnManajemenProduk.TextAlign = ContentAlignment.MiddleLeft
        btnManajemenProduk.UseVisualStyleBackColor = False
        ' 
        ' btnCustomPesanan
        ' 
        btnCustomPesanan.BackColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        btnCustomPesanan.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCustomPesanan.ForeColor = Color.White
        btnCustomPesanan.Location = New Point(16, 223)
        btnCustomPesanan.Name = "btnCustomPesanan"
        btnCustomPesanan.Size = New Size(210, 45)
        btnCustomPesanan.TabIndex = 4
        btnCustomPesanan.Text = "Custom Pesanan"
        btnCustomPesanan.TextAlign = ContentAlignment.MiddleLeft
        btnCustomPesanan.UseVisualStyleBackColor = False
        ' 
        ' btnDataPesanan
        ' 
        btnDataPesanan.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDataPesanan.ForeColor = Color.White
        btnDataPesanan.Location = New Point(16, 172)
        btnDataPesanan.Name = "btnDataPesanan"
        btnDataPesanan.Size = New Size(210, 45)
        btnDataPesanan.TabIndex = 3
        btnDataPesanan.Text = "Data Pesanan"
        btnDataPesanan.TextAlign = ContentAlignment.MiddleLeft
        btnDataPesanan.UseVisualStyleBackColor = False
        ' 
        ' btnTambahPesanan
        ' 
        btnTambahPesanan.BackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        btnTambahPesanan.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambahPesanan.ForeColor = Color.White
        btnTambahPesanan.Location = New Point(16, 121)
        btnTambahPesanan.Name = "btnTambahPesanan"
        btnTambahPesanan.Size = New Size(210, 45)
        btnTambahPesanan.TabIndex = 2
        btnTambahPesanan.Text = "Tambah Pesanan"
        btnTambahPesanan.TextAlign = ContentAlignment.MiddleLeft
        btnTambahPesanan.UseVisualStyleBackColor = False
        ' 
        ' btnBeranda
        ' 
        btnBeranda.BackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        btnBeranda.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBeranda.ForeColor = Color.White
        btnBeranda.Location = New Point(16, 70)
        btnBeranda.Name = "btnBeranda"
        btnBeranda.Size = New Size(210, 45)
        btnBeranda.TabIndex = 1
        btnBeranda.Text = "Beranda"
        btnBeranda.TextAlign = ContentAlignment.MiddleLeft
        btnBeranda.UseVisualStyleBackColor = False
        ' 
        ' lblNamaAplikasi
        ' 
        lblNamaAplikasi.AutoSize = True
        lblNamaAplikasi.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaAplikasi.ForeColor = Color.White
        lblNamaAplikasi.Location = New Point(16, 20)
        lblNamaAplikasi.Name = "lblNamaAplikasi"
        lblNamaAplikasi.Size = New Size(207, 28)
        lblNamaAplikasi.TabIndex = 0
        lblNamaAplikasi.Text = "FITRY HOMEBAKERY"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblJudulHalaman)
        pnlHeader.Location = New Point(246, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(658, 82)
        pnlHeader.TabIndex = 2
        ' 
        ' lblJudulHalaman
        ' 
        lblJudulHalaman.AutoSize = True
        lblJudulHalaman.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulHalaman.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblJudulHalaman.Location = New Point(3, 20)
        lblJudulHalaman.Name = "lblJudulHalaman"
        lblJudulHalaman.Size = New Size(265, 45)
        lblJudulHalaman.TabIndex = 0
        lblJudulHalaman.Text = "Custom Pesanan"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(246, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(658, 388)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(15, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 25)
        Label1.TabIndex = 1
        Label1.Text = " "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 25)
        Label2.TabIndex = 2
        Label2.Text = "Upload Referensi"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.SaddleBrown
        Label21.Location = New Point(237, 23)
        Label21.Name = "Label21"
        Label21.Size = New Size(85, 25)
        Label21.TabIndex = 13
        Label21.Text = "Kategori"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(237, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 25)
        Label3.TabIndex = 14
        Label3.Text = "Ukuran"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(237, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 25)
        Label4.TabIndex = 15
        Label4.Text = "Warna/Tema"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SaddleBrown
        Label5.Location = New Point(237, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 25)
        Label5.TabIndex = 16
        Label5.Text = "Tulisan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(391, 23)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 17
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(391, 71)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 33)
        ComboBox2.TabIndex = 18
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(391, 119)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 31)
        TextBox1.TabIndex = 19
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(391, 165)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(182, 31)
        TextBox2.TabIndex = 20
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(3, 222)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(652, 163)
        Panel2.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(10, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 25)
        Label6.TabIndex = 17
        Label6.Text = "Notes Pelanggan :"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.SaddleBrown
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(646, 44)
        Panel3.TabIndex = 18
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.SaddleBrown
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(249, 482)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(646, 105)
        Panel4.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(23, 37)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 25)
        Label7.TabIndex = 17
        Label7.Text = "Estimasi Harga :"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CustomPesanan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 599)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(pnlHeader)
        Controls.Add(pnlSidebar)
        Name = "CustomPesanan"
        Text = "CustomPesanan"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnPengaturan As Button
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents btnManajemenProduk As Button
    Friend WithEvents btnCustomPesanan As Button
    Friend WithEvents btnDataPesanan As Button
    Friend WithEvents btnTambahPesanan As Button
    Friend WithEvents btnBeranda As Button
    Friend WithEvents lblNamaAplikasi As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudulHalaman As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
End Class
