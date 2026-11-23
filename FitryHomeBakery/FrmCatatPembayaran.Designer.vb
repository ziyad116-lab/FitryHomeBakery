<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCatatPembayaran
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlJudul = New System.Windows.Forms.Panel()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblPilihPesanan = New System.Windows.Forms.Label()
        Me.cmbPilihPesanan = New System.Windows.Forms.ComboBox()
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.lblTotalTagihan = New System.Windows.Forms.Label()
        Me.txtTotalTagihan = New System.Windows.Forms.TextBox()
        Me.lblTotalDibayar = New System.Windows.Forms.Label()
        Me.txtTotalDibayar = New System.Windows.Forms.TextBox()
        Me.lblSisaTagihan = New System.Windows.Forms.Label()
        Me.txtSisaTagihan = New System.Windows.Forms.TextBox()
        Me.lblJumlahBayar = New System.Windows.Forms.Label()
        Me.txtJumlahBayar = New System.Windows.Forms.TextBox()
        Me.lblMetodePembayaran = New System.Windows.Forms.Label()
        Me.cmbMetodePembayaran = New System.Windows.Forms.ComboBox()
        Me.lblTanggalPembayaran = New System.Windows.Forms.Label()
        Me.dtpTanggalPembayaran = New System.Windows.Forms.DateTimePicker()
        Me.btnSimpanPembayaran = New System.Windows.Forms.Button()
        Me.btnBatalPembayaran = New System.Windows.Forms.Button()
        Me.pnlJudul.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlJudul
        '
        Me.pnlJudul.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlJudul.Controls.Add(Me.lblJudul)
        Me.pnlJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlJudul.Location = New System.Drawing.Point(0, 0)
        Me.pnlJudul.Name = "pnlJudul"
        Me.pnlJudul.Size = New System.Drawing.Size(580, 56)
        Me.pnlJudul.TabIndex = 100
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = System.Drawing.Color.White
        Me.lblJudul.Location = New System.Drawing.Point(24, 12)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(200, 28)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Catat Pembayaran"
        '
        'lblPilihPesanan
        '
        Me.lblPilihPesanan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPilihPesanan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblPilihPesanan.Location = New System.Drawing.Point(24, 76)
        Me.lblPilihPesanan.Name = "lblPilihPesanan"
        Me.lblPilihPesanan.Size = New System.Drawing.Size(160, 28)
        Me.lblPilihPesanan.TabIndex = 101
        Me.lblPilihPesanan.Text = "Pilih Pesanan"
        Me.lblPilihPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPilihPesanan
        '
        Me.cmbPilihPesanan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPilihPesanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPilihPesanan.FormattingEnabled = True
        Me.cmbPilihPesanan.Location = New System.Drawing.Point(190, 76)
        Me.cmbPilihPesanan.Name = "cmbPilihPesanan"
        Me.cmbPilihPesanan.Size = New System.Drawing.Size(360, 28)
        Me.cmbPilihPesanan.TabIndex = 0
        '
        'lblNamaPelanggan
        '
        Me.lblNamaPelanggan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaPelanggan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblNamaPelanggan.Location = New System.Drawing.Point(24, 116)
        Me.lblNamaPelanggan.Name = "lblNamaPelanggan"
        Me.lblNamaPelanggan.Size = New System.Drawing.Size(160, 28)
        Me.lblNamaPelanggan.TabIndex = 102
        Me.lblNamaPelanggan.Text = "Nama Pelanggan"
        Me.lblNamaPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaPelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(190, 116)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.ReadOnly = True
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(360, 30)
        Me.txtNamaPelanggan.TabStop = False
        '
        'lblTotalTagihan
        '
        Me.lblTotalTagihan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalTagihan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTotalTagihan.Location = New System.Drawing.Point(24, 156)
        Me.lblTotalTagihan.Name = "lblTotalTagihan"
        Me.lblTotalTagihan.Size = New System.Drawing.Size(160, 28)
        Me.lblTotalTagihan.TabIndex = 103
        Me.lblTotalTagihan.Text = "Total Tagihan"
        Me.lblTotalTagihan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalTagihan
        '
        Me.txtTotalTagihan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalTagihan.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtTotalTagihan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalTagihan.Location = New System.Drawing.Point(190, 156)
        Me.txtTotalTagihan.Name = "txtTotalTagihan"
        Me.txtTotalTagihan.ReadOnly = True
        Me.txtTotalTagihan.Size = New System.Drawing.Size(360, 30)
        Me.txtTotalTagihan.TabStop = False
        '
        'lblTotalDibayar
        '
        Me.lblTotalDibayar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDibayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTotalDibayar.Location = New System.Drawing.Point(24, 196)
        Me.lblTotalDibayar.Name = "lblTotalDibayar"
        Me.lblTotalDibayar.Size = New System.Drawing.Size(160, 28)
        Me.lblTotalDibayar.TabIndex = 104
        Me.lblTotalDibayar.Text = "Total Dibayar"
        Me.lblTotalDibayar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalDibayar
        '
        Me.txtTotalDibayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDibayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtTotalDibayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDibayar.Location = New System.Drawing.Point(190, 196)
        Me.txtTotalDibayar.Name = "txtTotalDibayar"
        Me.txtTotalDibayar.ReadOnly = True
        Me.txtTotalDibayar.Size = New System.Drawing.Size(360, 30)
        Me.txtTotalDibayar.TabStop = False
        '
        'lblSisaTagihan
        '
        Me.lblSisaTagihan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSisaTagihan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblSisaTagihan.Location = New System.Drawing.Point(24, 236)
        Me.lblSisaTagihan.Name = "lblSisaTagihan"
        Me.lblSisaTagihan.Size = New System.Drawing.Size(160, 28)
        Me.lblSisaTagihan.TabIndex = 105
        Me.lblSisaTagihan.Text = "Sisa Tagihan"
        Me.lblSisaTagihan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSisaTagihan
        '
        Me.txtSisaTagihan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSisaTagihan.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtSisaTagihan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSisaTagihan.Location = New System.Drawing.Point(190, 236)
        Me.txtSisaTagihan.Name = "txtSisaTagihan"
        Me.txtSisaTagihan.ReadOnly = True
        Me.txtSisaTagihan.Size = New System.Drawing.Size(360, 30)
        Me.txtSisaTagihan.TabStop = False
        '
        'lblJumlahBayar
        '
        Me.lblJumlahBayar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJumlahBayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblJumlahBayar.Location = New System.Drawing.Point(24, 276)
        Me.lblJumlahBayar.Name = "lblJumlahBayar"
        Me.lblJumlahBayar.Size = New System.Drawing.Size(160, 28)
        Me.lblJumlahBayar.TabIndex = 106
        Me.lblJumlahBayar.Text = "Jumlah Pembayaran"
        Me.lblJumlahBayar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtJumlahBayar
        '
        Me.txtJumlahBayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJumlahBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJumlahBayar.Location = New System.Drawing.Point(190, 276)
        Me.txtJumlahBayar.Name = "txtJumlahBayar"
        Me.txtJumlahBayar.Size = New System.Drawing.Size(360, 30)
        Me.txtJumlahBayar.TabIndex = 1
        '
        'lblMetodePembayaran
        '
        Me.lblMetodePembayaran.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMetodePembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblMetodePembayaran.Location = New System.Drawing.Point(24, 316)
        Me.lblMetodePembayaran.Name = "lblMetodePembayaran"
        Me.lblMetodePembayaran.Size = New System.Drawing.Size(160, 28)
        Me.lblMetodePembayaran.TabIndex = 107
        Me.lblMetodePembayaran.Text = "Metode Pembayaran"
        Me.lblMetodePembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbMetodePembayaran
        '
        Me.cmbMetodePembayaran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMetodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMetodePembayaran.FormattingEnabled = True
        Me.cmbMetodePembayaran.Items.AddRange(New Object() {"Tunai", "Transfer Bank", "QRIS"})
        Me.cmbMetodePembayaran.Location = New System.Drawing.Point(190, 316)
        Me.cmbMetodePembayaran.Name = "cmbMetodePembayaran"
        Me.cmbMetodePembayaran.Size = New System.Drawing.Size(360, 28)
        Me.cmbMetodePembayaran.TabIndex = 2
        '
        'lblTanggalPembayaran
        '
        Me.lblTanggalPembayaran.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTanggalPembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTanggalPembayaran.Location = New System.Drawing.Point(24, 356)
        Me.lblTanggalPembayaran.Name = "lblTanggalPembayaran"
        Me.lblTanggalPembayaran.Size = New System.Drawing.Size(160, 28)
        Me.lblTanggalPembayaran.TabIndex = 108
        Me.lblTanggalPembayaran.Text = "Tanggal Pembayaran"
        Me.lblTanggalPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpTanggalPembayaran
        '
        Me.dtpTanggalPembayaran.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTanggalPembayaran.Location = New System.Drawing.Point(190, 356)
        Me.dtpTanggalPembayaran.Name = "dtpTanggalPembayaran"
        Me.dtpTanggalPembayaran.Size = New System.Drawing.Size(160, 30)
        Me.dtpTanggalPembayaran.TabIndex = 3
        '
        'btnSimpanPembayaran
        '
        Me.btnSimpanPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnSimpanPembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpanPembayaran.FlatAppearance.BorderSize = 0
        Me.btnSimpanPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanPembayaran.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpanPembayaran.ForeColor = System.Drawing.Color.White
        Me.btnSimpanPembayaran.Location = New System.Drawing.Point(190, 406)
        Me.btnSimpanPembayaran.Name = "btnSimpanPembayaran"
        Me.btnSimpanPembayaran.Size = New System.Drawing.Size(170, 40)
        Me.btnSimpanPembayaran.TabIndex = 4
        Me.btnSimpanPembayaran.Text = "Simpan Pembayaran"
        Me.btnSimpanPembayaran.UseVisualStyleBackColor = False
        '
        'btnBatalPembayaran
        '
        Me.btnBatalPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnBatalPembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatalPembayaran.FlatAppearance.BorderSize = 0
        Me.btnBatalPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatalPembayaran.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatalPembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBatalPembayaran.Location = New System.Drawing.Point(370, 406)
        Me.btnBatalPembayaran.Name = "btnBatalPembayaran"
        Me.btnBatalPembayaran.Size = New System.Drawing.Size(110, 40)
        Me.btnBatalPembayaran.TabIndex = 5
        Me.btnBatalPembayaran.Text = "Batal"
        Me.btnBatalPembayaran.UseVisualStyleBackColor = False
        '
        'FrmCatatPembayaran
        '
        Me.AcceptButton = Me.btnSimpanPembayaran
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.CancelButton = Me.btnBatalPembayaran
        Me.ClientSize = New System.Drawing.Size(580, 500)
        Me.Controls.Add(Me.btnBatalPembayaran)
        Me.Controls.Add(Me.btnSimpanPembayaran)
        Me.Controls.Add(Me.dtpTanggalPembayaran)
        Me.Controls.Add(Me.lblTanggalPembayaran)
        Me.Controls.Add(Me.cmbMetodePembayaran)
        Me.Controls.Add(Me.lblMetodePembayaran)
        Me.Controls.Add(Me.txtJumlahBayar)
        Me.Controls.Add(Me.lblJumlahBayar)
        Me.Controls.Add(Me.txtSisaTagihan)
        Me.Controls.Add(Me.lblSisaTagihan)
        Me.Controls.Add(Me.txtTotalDibayar)
        Me.Controls.Add(Me.lblTotalDibayar)
        Me.Controls.Add(Me.txtTotalTagihan)
        Me.Controls.Add(Me.lblTotalTagihan)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.Controls.Add(Me.lblNamaPelanggan)
        Me.Controls.Add(Me.cmbPilihPesanan)
        Me.Controls.Add(Me.lblPilihPesanan)
        Me.Controls.Add(Me.pnlJudul)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 450)
        Me.Name = "FrmCatatPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Catat Pembayaran"
        Me.pnlJudul.ResumeLayout(False)
        Me.pnlJudul.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlJudul As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblPilihPesanan As System.Windows.Forms.Label
    Friend WithEvents cmbPilihPesanan As System.Windows.Forms.ComboBox
    Friend WithEvents lblNamaPelanggan As System.Windows.Forms.Label
    Friend WithEvents txtNamaPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalTagihan As System.Windows.Forms.Label
    Friend WithEvents txtTotalTagihan As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalDibayar As System.Windows.Forms.Label
    Friend WithEvents txtTotalDibayar As System.Windows.Forms.TextBox
    Friend WithEvents lblSisaTagihan As System.Windows.Forms.Label
    Friend WithEvents txtSisaTagihan As System.Windows.Forms.TextBox
    Friend WithEvents lblJumlahBayar As System.Windows.Forms.Label
    Friend WithEvents txtJumlahBayar As System.Windows.Forms.TextBox
    Friend WithEvents lblMetodePembayaran As System.Windows.Forms.Label
    Friend WithEvents cmbMetodePembayaran As System.Windows.Forms.ComboBox
    Friend WithEvents lblTanggalPembayaran As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalPembayaran As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSimpanPembayaran As System.Windows.Forms.Button
    Friend WithEvents btnBatalPembayaran As System.Windows.Forms.Button

End Class
