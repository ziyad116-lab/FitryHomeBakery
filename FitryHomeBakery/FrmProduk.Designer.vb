<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProduk
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            If picFotoProduk IsNot Nothing AndAlso picFotoProduk.Image IsNot Nothing Then picFotoProduk.Image.Dispose()
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlHeaderProduk As Panel
    Friend WithEvents lblJudulFormProduk As Label
    Friend WithEvents lblNamaProduk As Label
    Friend WithEvents txtNamaProduk As TextBox
    Friend WithEvents lblKategoriProduk As Label
    Friend WithEvents cmbKategoriProduk As ComboBox
    Friend WithEvents lblHargaProduk As Label
    Friend WithEvents txtHargaProduk As TextBox
    Friend WithEvents lblStatusProduk As Label
    Friend WithEvents cmbStatusProduk As ComboBox
    Friend WithEvents lblFotoProduk As Label
    Friend WithEvents picFotoProduk As PictureBox
    Friend WithEvents btnUploadFoto As Button
    Friend WithEvents btnSimpanProduk As Button
    Friend WithEvents btnBatalProduk As Button
    Friend WithEvents ofdFotoProduk As OpenFileDialog

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeaderProduk = New System.Windows.Forms.Panel()
        Me.lblJudulFormProduk = New System.Windows.Forms.Label()
        Me.lblNamaProduk = New System.Windows.Forms.Label()
        Me.txtNamaProduk = New System.Windows.Forms.TextBox()
        Me.lblKategoriProduk = New System.Windows.Forms.Label()
        Me.cmbKategoriProduk = New System.Windows.Forms.ComboBox()
        Me.lblHargaProduk = New System.Windows.Forms.Label()
        Me.txtHargaProduk = New System.Windows.Forms.TextBox()
        Me.lblStatusProduk = New System.Windows.Forms.Label()
        Me.cmbStatusProduk = New System.Windows.Forms.ComboBox()
        Me.lblFotoProduk = New System.Windows.Forms.Label()
        Me.picFotoProduk = New System.Windows.Forms.PictureBox()
        Me.btnUploadFoto = New System.Windows.Forms.Button()
        Me.btnSimpanProduk = New System.Windows.Forms.Button()
        Me.btnBatalProduk = New System.Windows.Forms.Button()
        Me.ofdFotoProduk = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picFotoProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeaderProduk
        Me.pnlHeaderProduk.BackColor = System.Drawing.Color.FromArgb(73, 51, 43)
        Me.pnlHeaderProduk.Controls.Add(Me.lblJudulFormProduk)
        Me.pnlHeaderProduk.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderProduk.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderProduk.Name = "pnlHeaderProduk"
        Me.pnlHeaderProduk.Size = New System.Drawing.Size(620, 60)
        Me.pnlHeaderProduk.TabIndex = 14
        'lblJudulFormProduk
        '
        Me.lblJudulFormProduk.AutoSize = True
        Me.lblJudulFormProduk.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudulFormProduk.ForeColor = System.Drawing.Color.White
        Me.lblJudulFormProduk.Location = New System.Drawing.Point(24, 14)
        Me.lblJudulFormProduk.Name = "lblJudulFormProduk"
        Me.lblJudulFormProduk.Size = New System.Drawing.Size(150, 31)
        Me.lblJudulFormProduk.TabIndex = 0
        Me.lblJudulFormProduk.Text = "Data Produk"
        '
        'lblNamaProduk
        '
        Me.lblNamaProduk.AutoSize = True
        Me.lblNamaProduk.Location = New System.Drawing.Point(28, 76)
        Me.lblNamaProduk.Name = "lblNamaProduk"
        Me.lblNamaProduk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaProduk.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72)
        Me.lblNamaProduk.Size = New System.Drawing.Size(87, 19)
        Me.lblNamaProduk.TabIndex = 1
        Me.lblNamaProduk.Text = "Nama Produk"
        '
        'txtNamaProduk
        '
        Me.txtNamaProduk.Location = New System.Drawing.Point(28, 101)
        Me.txtNamaProduk.Name = "txtNamaProduk"
        Me.txtNamaProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaProduk.Size = New System.Drawing.Size(270, 25)
        Me.txtNamaProduk.TabIndex = 2
        '
        'lblKategoriProduk
        '
        Me.lblKategoriProduk.AutoSize = True
        Me.lblKategoriProduk.Location = New System.Drawing.Point(28, 145)
        Me.lblKategoriProduk.Name = "lblKategoriProduk"
        Me.lblKategoriProduk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblKategoriProduk.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72)
        Me.lblKategoriProduk.Size = New System.Drawing.Size(105, 19)
        Me.lblKategoriProduk.TabIndex = 3
        Me.lblKategoriProduk.Text = "Kategori Produk"
        '
        'cmbKategoriProduk
        '
        Me.cmbKategoriProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKategoriProduk.FormattingEnabled = True
        Me.cmbKategoriProduk.Items.AddRange(New Object() {"Brownies", "Kue Bolu", "Jajanan Pasar", "Pastry", "Kue Kering", "Donat", "Asinan", "Pizza"})
        Me.cmbKategoriProduk.Location = New System.Drawing.Point(28, 170)
        Me.cmbKategoriProduk.Name = "cmbKategoriProduk"
        Me.cmbKategoriProduk.Size = New System.Drawing.Size(270, 25)
        Me.cmbKategoriProduk.TabIndex = 4
        '
        'lblHargaProduk
        '
        Me.lblHargaProduk.AutoSize = True
        Me.lblHargaProduk.Location = New System.Drawing.Point(28, 214)
        Me.lblHargaProduk.Name = "lblHargaProduk"
        Me.lblHargaProduk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHargaProduk.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72)
        Me.lblHargaProduk.Size = New System.Drawing.Size(94, 19)
        Me.lblHargaProduk.TabIndex = 5
        Me.lblHargaProduk.Text = "Harga Produk"
        '
        'txtHargaProduk
        '
        Me.txtHargaProduk.Location = New System.Drawing.Point(28, 239)
        Me.txtHargaProduk.Name = "txtHargaProduk"
        Me.txtHargaProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHargaProduk.Size = New System.Drawing.Size(270, 25)
        Me.txtHargaProduk.TabIndex = 6
        '
        'lblStatusProduk
        '
        Me.lblStatusProduk.AutoSize = True
        Me.lblStatusProduk.Location = New System.Drawing.Point(28, 283)
        Me.lblStatusProduk.Name = "lblStatusProduk"
        Me.lblStatusProduk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatusProduk.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72)
        Me.lblStatusProduk.Size = New System.Drawing.Size(93, 19)
        Me.lblStatusProduk.TabIndex = 7
        Me.lblStatusProduk.Text = "Status Produk"
        '
        'cmbStatusProduk
        '
        Me.cmbStatusProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusProduk.FormattingEnabled = True
        Me.cmbStatusProduk.Items.AddRange(New Object() {"Tersedia", "Tidak Tersedia"})
        Me.cmbStatusProduk.Location = New System.Drawing.Point(28, 308)
        Me.cmbStatusProduk.Name = "cmbStatusProduk"
        Me.cmbStatusProduk.Size = New System.Drawing.Size(270, 25)
        Me.cmbStatusProduk.TabIndex = 8
        '
        'lblFotoProduk
        '
        Me.lblFotoProduk.AutoSize = True
        Me.lblFotoProduk.Location = New System.Drawing.Point(348, 76)
        Me.lblFotoProduk.Name = "lblFotoProduk"
        Me.lblFotoProduk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFotoProduk.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72)
        Me.lblFotoProduk.Size = New System.Drawing.Size(81, 19)
        Me.lblFotoProduk.TabIndex = 9
        Me.lblFotoProduk.Text = "Foto Produk"
        '
        'picFotoProduk
        '
        Me.picFotoProduk.BackColor = System.Drawing.Color.White
        Me.picFotoProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFotoProduk.Location = New System.Drawing.Point(352, 101)
        Me.picFotoProduk.Name = "picFotoProduk"
        Me.picFotoProduk.Size = New System.Drawing.Size(230, 190)
        Me.picFotoProduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFotoProduk.TabIndex = 10
        Me.picFotoProduk.TabStop = False
        '
        'btnUploadFoto
        '
        Me.btnUploadFoto.BackColor = System.Drawing.Color.FromArgb(121, 85, 72)
        Me.btnUploadFoto.FlatAppearance.BorderSize = 0
        Me.btnUploadFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadFoto.ForeColor = System.Drawing.Color.White
        Me.btnUploadFoto.Location = New System.Drawing.Point(352, 303)
        Me.btnUploadFoto.Name = "btnUploadFoto"
        Me.btnUploadFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadFoto.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUploadFoto.Size = New System.Drawing.Size(130, 35)
        Me.btnUploadFoto.TabIndex = 11
        Me.btnUploadFoto.Text = "Upload Foto"
        Me.btnUploadFoto.UseVisualStyleBackColor = False
        '
        'btnSimpanProduk
        '
        Me.btnSimpanProduk.BackColor = System.Drawing.Color.FromArgb(121, 85, 72)
        Me.btnSimpanProduk.FlatAppearance.BorderSize = 0
        Me.btnSimpanProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanProduk.ForeColor = System.Drawing.Color.White
        Me.btnSimpanProduk.Location = New System.Drawing.Point(420, 455)
        Me.btnSimpanProduk.Name = "btnSimpanProduk"
        Me.btnSimpanProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpanProduk.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpanProduk.Size = New System.Drawing.Size(150, 40)
        Me.btnSimpanProduk.TabIndex = 12
        Me.btnSimpanProduk.Text = "Simpan"
        Me.btnSimpanProduk.UseVisualStyleBackColor = False
        '
        'btnBatalProduk
        '
        Me.btnBatalProduk.BackColor = System.Drawing.Color.FromArgb(233, 222, 211)
        Me.btnBatalProduk.FlatAppearance.BorderSize = 0
        Me.btnBatalProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatalProduk.Location = New System.Drawing.Point(320, 455)
        Me.btnBatalProduk.Name = "btnBatalProduk"
        Me.btnBatalProduk.ForeColor = System.Drawing.Color.FromArgb(73, 51, 43)
        Me.btnBatalProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatalProduk.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatalProduk.Size = New System.Drawing.Size(90, 40)
        Me.btnBatalProduk.TabIndex = 13
        Me.btnBatalProduk.Text = "Batal"
        Me.btnBatalProduk.UseVisualStyleBackColor = False
        '
        'ofdFotoProduk
        '
        Me.ofdFotoProduk.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        Me.ofdFotoProduk.Title = "Pilih Foto Produk"
        '
        'FrmProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(248, 244, 238)
        Me.ClientSize = New System.Drawing.Size(620, 525)
        Me.Controls.Add(Me.btnBatalProduk)
        Me.Controls.Add(Me.btnSimpanProduk)
        Me.Controls.Add(Me.btnUploadFoto)
        Me.Controls.Add(Me.picFotoProduk)
        Me.Controls.Add(Me.lblFotoProduk)
        Me.Controls.Add(Me.cmbStatusProduk)
        Me.Controls.Add(Me.lblStatusProduk)
        Me.Controls.Add(Me.txtHargaProduk)
        Me.Controls.Add(Me.lblHargaProduk)
        Me.Controls.Add(Me.cmbKategoriProduk)
        Me.Controls.Add(Me.lblKategoriProduk)
        Me.Controls.Add(Me.txtNamaProduk)
        Me.Controls.Add(Me.lblNamaProduk)
        Me.Controls.Add(Me.pnlHeaderProduk)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Produk"
        CType(Me.picFotoProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class