<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetailPesanan
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
        lblJudul = New Label()
        lblPelangganJudul = New Label()
        lblPelanggan = New Label()
        lblTanggalJudul = New Label()
        lblTanggal = New Label()
        lblStatus = New Label()
        lblJenis = New Label()
        lblStatusJudul = New Label()
        pnlJudul = New Panel()
        lblJenisJudul = New Label()
        lblCatatanJudul = New Label()
        lblCatatan = New Label()
        lblTotal = New Label()
        pnlItem = New Panel()
        tblItem = New TableLayoutPanel()
        lblSisa = New Label()
        btnSimpan = New Button()
        btnTutup = New Button()
        lblInfoSelesai = New Label()
        pnlJudul.SuspendLayout()
        pnlItem.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(24, 12)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(253, 28)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Detail Pesanan PSN-0001"
        ' 
        ' lblPelangganJudul
        ' 
        lblPelangganJudul.AutoSize = True
        lblPelangganJudul.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPelangganJudul.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblPelangganJudul.Location = New Point(24, 74)
        lblPelangganJudul.Name = "lblPelangganJudul"
        lblPelangganJudul.Size = New Size(64, 15)
        lblPelangganJudul.TabIndex = 2
        lblPelangganJudul.Text = "Pelanggan"
        ' 
        ' lblPelanggan
        ' 
        lblPelanggan.AutoEllipsis = True
        lblPelanggan.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblPelanggan.Location = New Point(176, 72)
        lblPelanggan.Name = "lblPelanggan"
        lblPelanggan.Size = New Size(440, 24)
        lblPelanggan.TabIndex = 3
        lblPelanggan.Text = "Label3"
        ' 
        ' lblTanggalJudul
        ' 
        lblTanggalJudul.AutoSize = True
        lblTanggalJudul.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTanggalJudul.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblTanggalJudul.Location = New Point(24, 102)
        lblTanggalJudul.Name = "lblTanggalJudul"
        lblTanggalJudul.Size = New Size(82, 15)
        lblTanggalJudul.TabIndex = 4
        lblTanggalJudul.Text = "Tanggal ambil"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblTanggal.Location = New Point(176, 100)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(440, 24)
        lblTanggal.TabIndex = 5
        lblTanggal.Text = "Label5"
        ' 
        ' lblStatus
        ' 
        lblStatus.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblStatus.Location = New Point(176, 128)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(440, 24)
        lblStatus.TabIndex = 7
        lblStatus.Text = "Label7"
        ' 
        ' lblJenis
        ' 
        lblJenis.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblJenis.Location = New Point(176, 156)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(440, 24)
        lblJenis.TabIndex = 10
        lblJenis.Text = "Label2"
        ' 
        ' lblStatusJudul
        ' 
        lblStatusJudul.AutoSize = True
        lblStatusJudul.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStatusJudul.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblStatusJudul.Location = New Point(24, 130)
        lblStatusJudul.Name = "lblStatusJudul"
        lblStatusJudul.Size = New Size(42, 15)
        lblStatusJudul.TabIndex = 21
        lblStatusJudul.Text = "Status"
        ' 
        ' pnlJudul
        ' 
        pnlJudul.BackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        pnlJudul.Controls.Add(lblJudul)
        pnlJudul.Dock = DockStyle.Top
        pnlJudul.Location = New Point(0, 0)
        pnlJudul.Name = "pnlJudul"
        pnlJudul.Size = New Size(640, 56)
        pnlJudul.TabIndex = 8
        ' 
        ' lblJenisJudul
        ' 
        lblJenisJudul.AutoSize = True
        lblJenisJudul.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblJenisJudul.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblJenisJudul.Location = New Point(24, 158)
        lblJenisJudul.Name = "lblJenisJudul"
        lblJenisJudul.Size = New Size(34, 15)
        lblJenisJudul.TabIndex = 22
        lblJenisJudul.Text = "Jenis"
        ' 
        ' lblCatatanJudul
        ' 
        lblCatatanJudul.AutoSize = True
        lblCatatanJudul.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCatatanJudul.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblCatatanJudul.Location = New Point(24, 186)
        lblCatatanJudul.Name = "lblCatatanJudul"
        lblCatatanJudul.Size = New Size(49, 15)
        lblCatatanJudul.TabIndex = 11
        lblCatatanJudul.Text = "Catatan"
        ' 
        ' lblCatatan
        ' 
        lblCatatan.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblCatatan.Location = New Point(176, 184)
        lblCatatan.Name = "lblCatatan"
        lblCatatan.Size = New Size(440, 24)
        lblCatatan.TabIndex = 12
        lblCatatan.Text = "Label8"
        ' 
        ' lblTotal
        ' 
        lblTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblTotal.Location = New Point(24, 424)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(592, 28)
        lblTotal.TabIndex = 14
        lblTotal.Text = "Label9"
        lblTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlItem
        ' 
        pnlItem.AutoScroll = True
        pnlItem.BackColor = Color.White
        pnlItem.Controls.Add(tblItem)
        pnlItem.Location = New Point(24, 222)
        pnlItem.Name = "pnlItem"
        pnlItem.Size = New Size(592, 190)
        pnlItem.TabIndex = 15
        ' 
        ' tblItem
        ' 
        tblItem.AutoSize = True
        tblItem.BackColor = Color.White
        tblItem.ColumnCount = 4
        tblItem.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 215F))
        tblItem.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 110F))
        tblItem.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 90F))
        tblItem.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 160F))
        tblItem.ForeColor = Color.White
        tblItem.Location = New Point(0, 0)
        tblItem.Name = "tblItem"
        tblItem.RowCount = 1
        tblItem.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblItem.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tblItem.Size = New Size(592, 32)
        tblItem.TabIndex = 0
        ' 
        ' lblSisa
        ' 
        lblSisa.Font = New Font("Segoe UI", 9F)
        lblSisa.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblSisa.Location = New Point(24, 452)
        lblSisa.Name = "lblSisa"
        lblSisa.Size = New Size(592, 24)
        lblSisa.TabIndex = 16
        lblSisa.Text = "Label10"
        lblSisa.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(310, 486)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(170, 40)
        btnSimpan.TabIndex = 17
        btnSimpan.Text = "Simpan Perubahan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        btnTutup.Cursor = Cursors.Hand
        btnTutup.DialogResult = DialogResult.Cancel
        btnTutup.FlatAppearance.BorderSize = 0
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        btnTutup.Location = New Point(486, 488)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(130, 40)
        btnTutup.TabIndex = 18
        btnTutup.Text = "Batal"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' lblInfoSelesai
        ' 
        lblInfoSelesai.AutoSize = True
        lblInfoSelesai.ForeColor = Color.FromArgb(CByte(117), CByte(107), CByte(101))
        lblInfoSelesai.Location = New Point(24, 541)
        lblInfoSelesai.Name = "lblInfoSelesai"
        lblInfoSelesai.Size = New Size(428, 19)
        lblInfoSelesai.TabIndex = 20
        lblInfoSelesai.Text = "Pesanan yang sudah selesai / dibatalkan tidak bisa diubah jumlahnya"
        ' 
        ' FrmDetailPesanan
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(243), CByte(235))
        ClientSize = New Size(640, 588)
        Controls.Add(lblJenisJudul)
        Controls.Add(lblStatusJudul)
        Controls.Add(lblInfoSelesai)
        Controls.Add(btnTutup)
        Controls.Add(btnSimpan)
        Controls.Add(lblSisa)
        Controls.Add(pnlItem)
        Controls.Add(lblTotal)
        Controls.Add(lblCatatan)
        Controls.Add(lblCatatanJudul)
        Controls.Add(lblTanggal)
        Controls.Add(lblJenis)
        Controls.Add(pnlJudul)
        Controls.Add(lblStatus)
        Controls.Add(lblTanggalJudul)
        Controls.Add(lblPelanggan)
        Controls.Add(lblPelangganJudul)
        Font = New Font("Segoe UI", 10F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmDetailPesanan"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Detail Pesanan"
        pnlJudul.ResumeLayout(False)
        pnlJudul.PerformLayout()
        pnlItem.ResumeLayout(False)
        pnlItem.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblPelangganJudul As Label
    Friend WithEvents lblPelanggan As Label
    Friend WithEvents lblTanggalJudul As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblStatusJudul As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblJenisJudul As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents pnlJudul As Panel
    Friend WithEvents lblCatatanJudul As Label
    Friend WithEvents lblCatatan As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents pnlItem As Panel
    Friend WithEvents tblItem As TableLayoutPanel
    Friend WithEvents lblSisa As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents lblInfoSelesai As Label

End Class
