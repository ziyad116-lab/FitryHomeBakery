<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcCustomPesanan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcCustomPesanan))
        Panel1 = New Panel()
        TextBox4 = New TextBox()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        btnHapus = New Button()
        TextBox2 = New TextBox()
        btnSimpan = New Button()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label21 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        pnlHeader = New Panel()
        lblDeskripsiHalaman = New Label()
        lblNamaPelanggan = New Label()
        txtNamaPelanggan = New TextBox()
        lblNoWA = New Label()
        txtNoWA = New TextBox()
        lblTglAmbil = New Label()
        dtpTglAmbil = New DateTimePicker()
        dtpJamAmbil = New DateTimePicker()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        pnlHeader.Controls.Add(lblDeskripsiHalaman)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1098, 48)
        pnlHeader.TabIndex = 1
        ' 
        ' lblDeskripsiHalaman
        ' 
        lblDeskripsiHalaman.AutoSize = True
        lblDeskripsiHalaman.Font = New Font("Segoe UI", 10.5F)
        lblDeskripsiHalaman.ForeColor = Color.FromArgb(CByte(238), CByte(228), CByte(220))
        lblDeskripsiHalaman.Location = New Point(24, 10)
        lblDeskripsiHalaman.Name = "lblDeskripsiHalaman"
        lblDeskripsiHalaman.Size = New Size(520, 28)
        lblDeskripsiHalaman.TabIndex = 0
        lblDeskripsiHalaman.Text = "Catat pesanan khusus (custom) lengkap dengan referensi desain dari pelanggan."
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(btnSimpan)
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
        Panel1.Controls.Add(dtpTglAmbil)
        Panel1.Controls.Add(dtpJamAmbil)
        Panel1.Controls.Add(lblTglAmbil)
        Panel1.Controls.Add(txtNoWA)
        Panel1.Controls.Add(lblNoWA)
        Panel1.Controls.Add(txtNamaPelanggan)
        Panel1.Controls.Add(lblNamaPelanggan)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1098, 673)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(324, 271)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        Label2.Location = New Point(24, 303)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 25)
        Label2.TabIndex = 1
        Label2.Text = "Upload Referensi"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 25)
        Label1.TabIndex = 2
        Label1.Text = " "
        Label1.Visible = False
        ' 
        ' lblNamaPelanggan
        ' 
        lblNamaPelanggan.AutoSize = True
        lblNamaPelanggan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaPelanggan.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblNamaPelanggan.Location = New Point(377, 28)
        lblNamaPelanggan.Name = "lblNamaPelanggan"
        lblNamaPelanggan.Size = New Size(120, 25)
        lblNamaPelanggan.TabIndex = 3
        lblNamaPelanggan.Text = "Nama Pelanggan"
        ' 
        ' txtNamaPelanggan
        ' 
        txtNamaPelanggan.Location = New Point(531, 24)
        txtNamaPelanggan.Name = "txtNamaPelanggan"
        txtNamaPelanggan.Size = New Size(543, 31)
        txtNamaPelanggan.TabIndex = 4
        ' 
        ' lblNoWA
        ' 
        lblNoWA.AutoSize = True
        lblNoWA.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNoWA.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblNoWA.Location = New Point(377, 76)
        lblNoWA.Name = "lblNoWA"
        lblNoWA.Size = New Size(120, 25)
        lblNoWA.TabIndex = 5
        lblNoWA.Text = "No WhatsApp"
        ' 
        ' txtNoWA
        ' 
        txtNoWA.Location = New Point(531, 72)
        txtNoWA.Name = "txtNoWA"
        txtNoWA.Size = New Size(543, 31)
        txtNoWA.TabIndex = 6
        ' 
        ' lblTglAmbil
        ' 
        lblTglAmbil.AutoSize = True
        lblTglAmbil.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTglAmbil.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblTglAmbil.Location = New Point(377, 124)
        lblTglAmbil.Name = "lblTglAmbil"
        lblTglAmbil.Size = New Size(120, 25)
        lblTglAmbil.TabIndex = 7
        lblTglAmbil.Text = "Tanggal Ambil"
        ' 
        ' dtpTglAmbil
        ' 
        dtpTglAmbil.Format = DateTimePickerFormat.Short
        dtpTglAmbil.Location = New Point(531, 120)
        dtpTglAmbil.Name = "dtpTglAmbil"
        dtpTglAmbil.Size = New Size(220, 31)
        dtpTglAmbil.TabIndex = 8
        ' 
        ' dtpJamAmbil
        ' 
        dtpJamAmbil.CustomFormat = "HH:mm"
        dtpJamAmbil.Format = DateTimePickerFormat.Custom
        dtpJamAmbil.Location = New Point(771, 120)
        dtpJamAmbil.Name = "dtpJamAmbil"
        dtpJamAmbil.ShowUpDown = True
        dtpJamAmbil.Size = New Size(110, 31)
        dtpJamAmbil.TabIndex = 8
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        Label21.Location = New Point(377, 172)
        Label21.Name = "Label21"
        Label21.Size = New Size(120, 25)
        Label21.TabIndex = 9
        Label21.Text = "Kategori"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(531, 168)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(543, 33)
        ComboBox1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        Label3.Location = New Point(377, 220)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 25)
        Label3.TabIndex = 11
        Label3.Text = "Ukuran"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(531, 216)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(543, 33)
        ComboBox2.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        Label4.Location = New Point(377, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 25)
        Label4.TabIndex = 13
        Label4.Text = "Warna/Tema"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(531, 264)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(543, 31)
        TextBox1.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        Label5.Location = New Point(377, 316)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 25)
        Label5.TabIndex = 15
        Label5.Text = "Tulisan"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(531, 312)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(543, 31)
        TextBox2.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        Label6.Location = New Point(377, 364)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 25)
        Label6.TabIndex = 17
        Label6.Text = "Harga"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(531, 360)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(543, 31)
        TextBox3.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        Label7.Location = New Point(377, 412)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 25)
        Label7.TabIndex = 19
        Label7.Text = "Note Pelanggan"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(531, 408)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.ScrollBars = ScrollBars.Vertical
        TextBox4.Size = New Size(543, 90)
        TextBox4.TabIndex = 20
        ' 
        ' btnHapus
        ' 
        btnHapus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnHapus.BackColor = Color.FromArgb(CByte(176), CByte(58), CByte(46))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(810, 520)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(126, 40)
        btnHapus.TabIndex = 21
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSimpan.BackColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(948, 520)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(126, 40)
        btnSimpan.TabIndex = 22
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' UcCustomPesanan
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        Controls.Add(Panel1)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 10.0F)
        Name = "UcCustomPesanan"
        Size = New Size(1098, 721)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblDeskripsiHalaman As Label
    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents lblNoWA As Label
    Friend WithEvents txtNoWA As TextBox
    Friend WithEvents lblTglAmbil As Label
    Friend WithEvents dtpTglAmbil As DateTimePicker
    Friend WithEvents dtpJamAmbil As DateTimePicker

End Class