<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcPengaturan
    Inherits System.Windows.Forms.UserControl

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            If picLogoUsaha IsNot Nothing AndAlso picLogoUsaha.Image IsNot Nothing Then picLogoUsaha.Image.Dispose()
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudulPengaturan As Label
    Friend WithEvents lblDeskripsiPengaturan As Label
    Friend WithEvents pnlInformasiUsaha As Panel
    Friend WithEvents lblBagianInformasi As Label
    Friend WithEvents lblNamaUsaha As Label
    Friend WithEvents txtNamaUsaha As TextBox
    Friend WithEvents lblNomorWhatsApp As Label
    Friend WithEvents txtNomorWhatsApp As TextBox
    Friend WithEvents lblAlamatUsaha As Label
    Friend WithEvents txtAlamatUsaha As TextBox
    Friend WithEvents pnlLogoUsaha As Panel
    Friend WithEvents lblBagianLogo As Label
    Friend WithEvents picLogoUsaha As PictureBox
    Friend WithEvents lblLogoUsaha As Label
    Friend WithEvents btnUploadLogo As Button
    Friend WithEvents btnHapusLogo As Button
    Friend WithEvents btnSimpanPengaturan As Button
    Friend WithEvents ofdLogoUsaha As OpenFileDialog

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblJudulPengaturan = New System.Windows.Forms.Label()
        Me.lblDeskripsiPengaturan = New System.Windows.Forms.Label()
        Me.pnlInformasiUsaha = New System.Windows.Forms.Panel()
        Me.lblBagianInformasi = New System.Windows.Forms.Label()
        Me.lblNamaUsaha = New System.Windows.Forms.Label()
        Me.txtNamaUsaha = New System.Windows.Forms.TextBox()
        Me.lblNomorWhatsApp = New System.Windows.Forms.Label()
        Me.txtNomorWhatsApp = New System.Windows.Forms.TextBox()
        Me.lblAlamatUsaha = New System.Windows.Forms.Label()
        Me.txtAlamatUsaha = New System.Windows.Forms.TextBox()
        Me.pnlLogoUsaha = New System.Windows.Forms.Panel()
        Me.lblBagianLogo = New System.Windows.Forms.Label()
        Me.picLogoUsaha = New System.Windows.Forms.PictureBox()
        Me.lblLogoUsaha = New System.Windows.Forms.Label()
        Me.btnUploadLogo = New System.Windows.Forms.Button()
        Me.btnHapusLogo = New System.Windows.Forms.Button()
        Me.btnSimpanPengaturan = New System.Windows.Forms.Button()
        Me.ofdLogoUsaha = New System.Windows.Forms.OpenFileDialog()
        Me.pnlHeader.SuspendLayout()
        Me.pnlInformasiUsaha.SuspendLayout()
        Me.pnlLogoUsaha.SuspendLayout()
        CType(Me.picLogoUsaha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(73, 51, 43)
        Me.pnlHeader.Controls.Add(Me.lblJudulPengaturan)
        Me.pnlHeader.Controls.Add(Me.lblDeskripsiPengaturan)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1126, 92)
        Me.pnlHeader.TabIndex = 0
        '
        'lblJudulPengaturan
        '
        Me.lblJudulPengaturan.AutoSize = True
        Me.lblJudulPengaturan.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudulPengaturan.ForeColor = System.Drawing.Color.White
        Me.lblJudulPengaturan.Location = New System.Drawing.Point(18, 8)
        Me.lblJudulPengaturan.Name = "lblJudulPengaturan"
        Me.lblJudulPengaturan.Size = New System.Drawing.Size(150, 37)
        Me.lblJudulPengaturan.TabIndex = 0
        Me.lblJudulPengaturan.Text = "Pengaturan"
        '
        'lblDeskripsiPengaturan
        '
        Me.lblDeskripsiPengaturan.AutoSize = True
        Me.lblDeskripsiPengaturan.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.lblDeskripsiPengaturan.ForeColor = System.Drawing.Color.FromArgb(238, 228, 220)
        Me.lblDeskripsiPengaturan.Location = New System.Drawing.Point(19, 49)
        Me.lblDeskripsiPengaturan.Name = "lblDeskripsiPengaturan"
        Me.lblDeskripsiPengaturan.Size = New System.Drawing.Size(253, 19)
        Me.lblDeskripsiPengaturan.TabIndex = 1
        Me.lblDeskripsiPengaturan.Text = "Kelola informasi dan identitas usaha."
        '
        'pnlInformasiUsaha
        '
        Me.pnlInformasiUsaha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInformasiUsaha.BackColor = System.Drawing.Color.White
        Me.pnlInformasiUsaha.Controls.Add(Me.lblBagianInformasi)
        Me.pnlInformasiUsaha.Controls.Add(Me.lblNamaUsaha)
        Me.pnlInformasiUsaha.Controls.Add(Me.txtNamaUsaha)
        Me.pnlInformasiUsaha.Controls.Add(Me.lblNomorWhatsApp)
        Me.pnlInformasiUsaha.Controls.Add(Me.txtNomorWhatsApp)
        Me.pnlInformasiUsaha.Controls.Add(Me.lblAlamatUsaha)
        Me.pnlInformasiUsaha.Controls.Add(Me.txtAlamatUsaha)
        Me.pnlInformasiUsaha.Location = New System.Drawing.Point(18, 110)
        Me.pnlInformasiUsaha.Name = "pnlInformasiUsaha"
        Me.pnlInformasiUsaha.Size = New System.Drawing.Size(1090, 394)
        Me.pnlInformasiUsaha.TabIndex = 1
        '
        'lblBagianInformasi
        '
        Me.lblBagianInformasi.AutoSize = True
        Me.lblBagianInformasi.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblBagianInformasi.Location = New System.Drawing.Point(18, 18)
        Me.lblBagianInformasi.Name = "lblBagianInformasi"
        Me.lblBagianInformasi.Size = New System.Drawing.Size(204, 28)
        Me.lblBagianInformasi.TabIndex = 0
        Me.lblBagianInformasi.Text = "01. Informasi Usaha"
        '
        'lblNamaUsaha
        '
        Me.lblNamaUsaha.AutoSize = True
        Me.lblNamaUsaha.ForeColor = System.Drawing.Color.DimGray
        Me.lblNamaUsaha.Location = New System.Drawing.Point(18, 65)
        Me.lblNamaUsaha.Name = "lblNamaUsaha"
        Me.lblNamaUsaha.Size = New System.Drawing.Size(86, 19)
        Me.lblNamaUsaha.TabIndex = 1
        Me.lblNamaUsaha.Text = "Nama Usaha"
        '
        'txtNamaUsaha
        '
        Me.txtNamaUsaha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaUsaha.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtNamaUsaha.Location = New System.Drawing.Point(18, 94)
        Me.txtNamaUsaha.Name = "txtNamaUsaha"
        Me.txtNamaUsaha.Size = New System.Drawing.Size(1054, 26)
        Me.txtNamaUsaha.TabIndex = 2
        Me.txtNamaUsaha.Text = "Fitry Homebakery"
        '
        'lblNomorWhatsApp
        '
        Me.lblNomorWhatsApp.AutoSize = True
        Me.lblNomorWhatsApp.ForeColor = System.Drawing.Color.DimGray
        Me.lblNomorWhatsApp.Location = New System.Drawing.Point(18, 139)
        Me.lblNomorWhatsApp.Name = "lblNomorWhatsApp"
        Me.lblNomorWhatsApp.Size = New System.Drawing.Size(115, 19)
        Me.lblNomorWhatsApp.TabIndex = 3
        Me.lblNomorWhatsApp.Text = "Nomor WhatsApp"
        '
        'txtNomorWhatsApp
        '
        Me.txtNomorWhatsApp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomorWhatsApp.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtNomorWhatsApp.Location = New System.Drawing.Point(18, 168)
        Me.txtNomorWhatsApp.Name = "txtNomorWhatsApp"
        Me.txtNomorWhatsApp.Size = New System.Drawing.Size(1054, 26)
        Me.txtNomorWhatsApp.TabIndex = 4
        Me.txtNomorWhatsApp.PlaceholderText = "Masukkan nomor WhatsApp usaha"
        '
        'lblAlamatUsaha
        '
        Me.lblAlamatUsaha.AutoSize = True
        Me.lblAlamatUsaha.ForeColor = System.Drawing.Color.DimGray
        Me.lblAlamatUsaha.Location = New System.Drawing.Point(18, 213)
        Me.lblAlamatUsaha.Name = "lblAlamatUsaha"
        Me.lblAlamatUsaha.Size = New System.Drawing.Size(89, 19)
        Me.lblAlamatUsaha.TabIndex = 5
        Me.lblAlamatUsaha.Text = "Alamat Usaha"
        '
        'txtAlamatUsaha
        '
        Me.txtAlamatUsaha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right) Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtAlamatUsaha.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtAlamatUsaha.Location = New System.Drawing.Point(18, 242)
        Me.txtAlamatUsaha.Multiline = True
        Me.txtAlamatUsaha.Name = "txtAlamatUsaha"
        Me.txtAlamatUsaha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamatUsaha.Size = New System.Drawing.Size(1054, 132)
        Me.txtAlamatUsaha.TabIndex = 6
        Me.txtAlamatUsaha.PlaceholderText = "Masukkan alamat usaha..."
        '
        'pnlLogoUsaha
        '
        Me.pnlLogoUsaha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLogoUsaha.BackColor = System.Drawing.Color.White
        Me.pnlLogoUsaha.Controls.Add(Me.lblBagianLogo)
        Me.pnlLogoUsaha.Controls.Add(Me.picLogoUsaha)
        Me.pnlLogoUsaha.Controls.Add(Me.lblLogoUsaha)
        Me.pnlLogoUsaha.Controls.Add(Me.btnUploadLogo)
        Me.pnlLogoUsaha.Controls.Add(Me.btnHapusLogo)
        Me.pnlLogoUsaha.Location = New System.Drawing.Point(18, 520)
        Me.pnlLogoUsaha.Name = "pnlLogoUsaha"
        Me.pnlLogoUsaha.Size = New System.Drawing.Size(1090, 220)
        Me.pnlLogoUsaha.TabIndex = 2
        '
        'lblBagianLogo
        '
        Me.lblBagianLogo.AutoSize = True
        Me.lblBagianLogo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblBagianLogo.Location = New System.Drawing.Point(18, 18)
        Me.lblBagianLogo.Name = "lblBagianLogo"
        Me.lblBagianLogo.Size = New System.Drawing.Size(150, 28)
        Me.lblBagianLogo.TabIndex = 0
        Me.lblBagianLogo.Text = "02. Logo Usaha"
        '
        'picLogoUsaha
        '
        Me.picLogoUsaha.BackColor = System.Drawing.Color.White
        Me.picLogoUsaha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogoUsaha.Location = New System.Drawing.Point(18, 62)
        Me.picLogoUsaha.Name = "picLogoUsaha"
        Me.picLogoUsaha.Size = New System.Drawing.Size(180, 140)
        Me.picLogoUsaha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogoUsaha.TabIndex = 1
        Me.picLogoUsaha.TabStop = False
        '
        'lblLogoUsaha
        '
        Me.lblLogoUsaha.AutoSize = True
        Me.lblLogoUsaha.ForeColor = System.Drawing.Color.DimGray
        Me.lblLogoUsaha.Location = New System.Drawing.Point(220, 66)
        Me.lblLogoUsaha.Name = "lblLogoUsaha"
        Me.lblLogoUsaha.Size = New System.Drawing.Size(153, 19)
        Me.lblLogoUsaha.TabIndex = 2
        Me.lblLogoUsaha.Text = "Logo Fitry Homebakery"
        '
        'btnUploadLogo
        '
        Me.btnUploadLogo.BackColor = System.Drawing.Color.FromArgb(121, 85, 72)
        Me.btnUploadLogo.FlatAppearance.BorderSize = 0
        Me.btnUploadLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadLogo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUploadLogo.ForeColor = System.Drawing.Color.White
        Me.btnUploadLogo.Location = New System.Drawing.Point(220, 99)
        Me.btnUploadLogo.Name = "btnUploadLogo"
        Me.btnUploadLogo.Size = New System.Drawing.Size(130, 38)
        Me.btnUploadLogo.TabIndex = 3
        Me.btnUploadLogo.Text = "Upload Logo"
        Me.btnUploadLogo.UseVisualStyleBackColor = False
        '
        'btnHapusLogo
        '
        Me.btnHapusLogo.BackColor = System.Drawing.Color.FromArgb(150, 120, 105)
        Me.btnHapusLogo.FlatAppearance.BorderSize = 0
        Me.btnHapusLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusLogo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapusLogo.ForeColor = System.Drawing.Color.White
        Me.btnHapusLogo.Location = New System.Drawing.Point(220, 147)
        Me.btnHapusLogo.Name = "btnHapusLogo"
        Me.btnHapusLogo.Size = New System.Drawing.Size(130, 38)
        Me.btnHapusLogo.TabIndex = 4
        Me.btnHapusLogo.Text = "Hapus Logo"
        Me.btnHapusLogo.UseVisualStyleBackColor = False
        '
        'btnSimpanPengaturan
        '
        Me.btnSimpanPengaturan.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.btnSimpanPengaturan.BackColor = System.Drawing.Color.FromArgb(121, 85, 72)
        Me.btnSimpanPengaturan.FlatAppearance.BorderSize = 0
        Me.btnSimpanPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanPengaturan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpanPengaturan.ForeColor = System.Drawing.Color.White
        Me.btnSimpanPengaturan.Location = New System.Drawing.Point(938, 755)
        Me.btnSimpanPengaturan.Name = "btnSimpanPengaturan"
        Me.btnSimpanPengaturan.Size = New System.Drawing.Size(170, 42)
        Me.btnSimpanPengaturan.TabIndex = 3
        Me.btnSimpanPengaturan.Text = "Simpan Pengaturan"
        Me.btnSimpanPengaturan.UseVisualStyleBackColor = False
        '
        'ofdLogoUsaha
        '
        Me.ofdLogoUsaha.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        Me.ofdLogoUsaha.Title = "Pilih Logo Fitry Homebakery"
        '
        'UcPengaturan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(248, 244, 238)
        Me.Controls.Add(Me.btnSimpanPengaturan)
        Me.Controls.Add(Me.pnlLogoUsaha)
        Me.Controls.Add(Me.pnlInformasiUsaha)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Name = "UcPengaturan"
        Me.Size = New System.Drawing.Size(1126, 820)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlInformasiUsaha.ResumeLayout(False)
        Me.pnlInformasiUsaha.PerformLayout()
        Me.pnlLogoUsaha.ResumeLayout(False)
        Me.pnlLogoUsaha.PerformLayout()
        CType(Me.picLogoUsaha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
End Class
