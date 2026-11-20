<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcDataPesanan
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
        Dim DgvHdr As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DgvCell As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DgvAlt As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvDataPesanan = New DataGridView()
        lblPetunjuk = New Label()
        btnEditStatus = New Button()
        btnLihatDetail = New Button()
        btnResetFilter = New Button()
        dtpTanggalAkhir = New DateTimePicker()
        lblSampai = New Label()
        dtpTanggalMulai = New DateTimePicker()
        pnlTombol = New Panel()
        lblTanggalAmbil = New Label()
        btnCariPesanan = New Button()
        txtCariPesanan = New TextBox()
        pnlTabel = New Panel()
        pnlFilter = New Panel()
        cmbFilterStatus = New ComboBox()
        pnlHeader = New Panel()
        lblDeskripsiHalaman = New Label()
        CType(dgvDataPesanan, ComponentModel.ISupportInitialize).BeginInit()
        pnlTombol.SuspendLayout()
        pnlTabel.SuspendLayout()
        pnlFilter.SuspendLayout()
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
        pnlHeader.TabIndex = 3
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
        lblDeskripsiHalaman.Text = "Lihat, cari, dan perbarui status pesanan pelanggan."
        ' 
        ' pnlFilter
        ' 
        pnlFilter.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        pnlFilter.Controls.Add(btnResetFilter)
        pnlFilter.Controls.Add(dtpTanggalAkhir)
        pnlFilter.Controls.Add(lblSampai)
        pnlFilter.Controls.Add(dtpTanggalMulai)
        pnlFilter.Controls.Add(lblTanggalAmbil)
        pnlFilter.Controls.Add(cmbFilterStatus)
        pnlFilter.Controls.Add(btnCariPesanan)
        pnlFilter.Controls.Add(txtCariPesanan)
        pnlFilter.Dock = DockStyle.Top
        pnlFilter.Location = New Point(0, 48)
        pnlFilter.Name = "pnlFilter"
        pnlFilter.Size = New Size(1098, 110)
        pnlFilter.TabIndex = 2
        ' 
        ' txtCariPesanan
        ' 
        txtCariPesanan.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCariPesanan.BorderStyle = BorderStyle.FixedSingle
        txtCariPesanan.Location = New Point(24, 16)
        txtCariPesanan.Name = "txtCariPesanan"
        txtCariPesanan.PlaceholderText = "Cari nama pelanggan atau nomor pesanan..."
        txtCariPesanan.Size = New Size(938, 31)
        txtCariPesanan.TabIndex = 0
        ' 
        ' btnCariPesanan
        ' 
        btnCariPesanan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCariPesanan.BackColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        btnCariPesanan.Cursor = Cursors.Hand
        btnCariPesanan.FlatAppearance.BorderSize = 0
        btnCariPesanan.FlatStyle = FlatStyle.Flat
        btnCariPesanan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCariPesanan.ForeColor = Color.White
        btnCariPesanan.Location = New Point(974, 15)
        btnCariPesanan.Name = "btnCariPesanan"
        btnCariPesanan.Size = New Size(100, 33)
        btnCariPesanan.TabIndex = 1
        btnCariPesanan.Text = "Cari"
        btnCariPesanan.UseVisualStyleBackColor = False
        ' 
        ' cmbFilterStatus
        ' 
        cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilterStatus.FormattingEnabled = True
        cmbFilterStatus.Location = New Point(24, 60)
        cmbFilterStatus.Name = "cmbFilterStatus"
        cmbFilterStatus.Size = New Size(160, 33)
        cmbFilterStatus.TabIndex = 2
        ' 
        ' lblTanggalAmbil
        ' 
        lblTanggalAmbil.AutoSize = True
        lblTanggalAmbil.ForeColor = Color.FromArgb(CByte(117), CByte(107), CByte(101))
        lblTanggalAmbil.Location = New Point(204, 66)
        lblTanggalAmbil.Name = "lblTanggalAmbil"
        lblTanggalAmbil.Size = New Size(126, 25)
        lblTanggalAmbil.TabIndex = 3
        lblTanggalAmbil.Text = "Tanggal ambil:"
        ' 
        ' lblSampai
        ' 
        lblSampai.AutoSize = True
        lblSampai.ForeColor = Color.FromArgb(CByte(117), CByte(107), CByte(101))
        lblSampai.Location = New Point(476, 66)
        lblSampai.Name = "lblSampai"
        lblSampai.Size = New Size(126, 25)
        lblSampai.TabIndex = 5
        lblSampai.Text = "s/d"
        ' 
        ' dtpTanggalMulai
        ' 
        dtpTanggalMulai.Checked = False
        dtpTanggalMulai.Format = DateTimePickerFormat.Short
        dtpTanggalMulai.Location = New Point(336, 60)
        dtpTanggalMulai.Name = "dtpTanggalMulai"
        dtpTanggalMulai.ShowCheckBox = True
        dtpTanggalMulai.Size = New Size(130, 31)
        dtpTanggalMulai.TabIndex = 4
        ' 
        ' dtpTanggalAkhir
        ' 
        dtpTanggalAkhir.Checked = False
        dtpTanggalAkhir.Format = DateTimePickerFormat.Short
        dtpTanggalAkhir.Location = New Point(520, 60)
        dtpTanggalAkhir.Name = "dtpTanggalAkhir"
        dtpTanggalAkhir.ShowCheckBox = True
        dtpTanggalAkhir.Size = New Size(130, 31)
        dtpTanggalAkhir.TabIndex = 6
        ' 
        ' btnResetFilter
        ' 
        btnResetFilter.BackColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        btnResetFilter.Cursor = Cursors.Hand
        btnResetFilter.FlatAppearance.BorderSize = 0
        btnResetFilter.FlatStyle = FlatStyle.Flat
        btnResetFilter.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnResetFilter.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        btnResetFilter.Location = New Point(673, 59)
        btnResetFilter.Name = "btnResetFilter"
        btnResetFilter.Size = New Size(90, 33)
        btnResetFilter.TabIndex = 7
        btnResetFilter.Text = "Reset"
        btnResetFilter.UseVisualStyleBackColor = False
        ' 
        ' pnlTabel
        ' 
        pnlTabel.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        pnlTabel.Controls.Add(dgvDataPesanan)
        pnlTabel.Dock = DockStyle.Fill
        pnlTabel.Location = New Point(0, 158)
        pnlTabel.Name = "pnlTabel"
        pnlTabel.Padding = New Padding(24, 0, 24, 0)
        pnlTabel.Size = New Size(1098, 499)
        pnlTabel.TabIndex = 1
        ' 
        ' dgvDataPesanan
        ' 
        dgvDataPesanan.AllowUserToAddRows = False
        dgvDataPesanan.AllowUserToDeleteRows = False
        dgvDataPesanan.AllowUserToResizeRows = False
        dgvDataPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvHdr.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvHdr.BackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DgvHdr.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DgvHdr.ForeColor = Color.White
        DgvHdr.SelectionBackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DgvHdr.SelectionForeColor = Color.White
        DgvHdr.WrapMode = DataGridViewTriState.False
        DgvCell.Alignment = DataGridViewContentAlignment.MiddleLeft
        DgvCell.BackColor = Color.White
        DgvCell.Font = New Font("Segoe UI", 10.0F)
        DgvCell.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DgvCell.SelectionBackColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        DgvCell.SelectionForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DgvAlt.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        DgvAlt.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DgvAlt.SelectionBackColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        DgvAlt.SelectionForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        dgvDataPesanan.AlternatingRowsDefaultCellStyle = DgvAlt
        dgvDataPesanan.BackgroundColor = Color.White
        dgvDataPesanan.BorderStyle = BorderStyle.None
        dgvDataPesanan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvDataPesanan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvDataPesanan.ColumnHeadersDefaultCellStyle = DgvHdr
        dgvDataPesanan.ColumnHeadersHeight = 40
        dgvDataPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvDataPesanan.DefaultCellStyle = DgvCell
        dgvDataPesanan.EnableHeadersVisualStyles = False
        dgvDataPesanan.GridColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        dgvDataPesanan.RowTemplate.Height = 40
        dgvDataPesanan.Dock = DockStyle.Fill
        dgvDataPesanan.Location = New Point(24, 0)
        dgvDataPesanan.MultiSelect = False
        dgvDataPesanan.Name = "dgvDataPesanan"
        dgvDataPesanan.ReadOnly = True
        dgvDataPesanan.RowHeadersVisible = False
        dgvDataPesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDataPesanan.Size = New Size(1050, 499)
        dgvDataPesanan.TabIndex = 0
        ' 
        ' pnlTombol
        ' 
        pnlTombol.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        pnlTombol.Controls.Add(lblPetunjuk)
        pnlTombol.Controls.Add(btnEditStatus)
        pnlTombol.Controls.Add(btnLihatDetail)
        pnlTombol.Dock = DockStyle.Bottom
        pnlTombol.Location = New Point(0, 657)
        pnlTombol.Name = "pnlTombol"
        pnlTombol.Size = New Size(1098, 64)
        pnlTombol.TabIndex = 0
        ' 
        ' lblPetunjuk
        ' 
        lblPetunjuk.AutoSize = True
        lblPetunjuk.ForeColor = Color.FromArgb(CByte(117), CByte(107), CByte(101))
        lblPetunjuk.Location = New Point(24, 20)
        lblPetunjuk.Name = "lblPetunjuk"
        lblPetunjuk.Size = New Size(529, 25)
        lblPetunjuk.TabIndex = 2
        lblPetunjuk.Text = "Pilih satu pesanan di tabel. Klik 2x pada baris untuk melihat detail."
        ' 
        ' btnLihatDetail
        ' 
        btnLihatDetail.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLihatDetail.BackColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        btnLihatDetail.Cursor = Cursors.Hand
        btnLihatDetail.FlatAppearance.BorderSize = 0
        btnLihatDetail.FlatStyle = FlatStyle.Flat
        btnLihatDetail.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnLihatDetail.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        btnLihatDetail.Location = New Point(802, 12)
        btnLihatDetail.Name = "btnLihatDetail"
        btnLihatDetail.Size = New Size(130, 40)
        btnLihatDetail.TabIndex = 1
        btnLihatDetail.Text = "Lihat Detail"
        btnLihatDetail.UseVisualStyleBackColor = False
        ' 
        ' btnEditStatus
        ' 
        btnEditStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEditStatus.BackColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        btnEditStatus.Cursor = Cursors.Hand
        btnEditStatus.FlatAppearance.BorderSize = 0
        btnEditStatus.FlatStyle = FlatStyle.Flat
        btnEditStatus.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnEditStatus.ForeColor = Color.White
        btnEditStatus.Location = New Point(944, 12)
        btnEditStatus.Name = "btnEditStatus"
        btnEditStatus.Size = New Size(130, 40)
        btnEditStatus.TabIndex = 0
        btnEditStatus.Text = "Ubah Status"
        btnEditStatus.UseVisualStyleBackColor = False
        ' 
        ' UcDataPesanan
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        Controls.Add(pnlTabel)
        Controls.Add(pnlTombol)
        Controls.Add(pnlFilter)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 10.0F)
        Name = "UcDataPesanan"
        Size = New Size(1098, 721)
        CType(dgvDataPesanan, ComponentModel.ISupportInitialize).EndInit()
        pnlTombol.ResumeLayout(False)
        pnlTombol.PerformLayout()
        pnlTabel.ResumeLayout(False)
        pnlFilter.ResumeLayout(False)
        pnlFilter.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvDataPesanan As DataGridView
    Friend WithEvents lblPetunjuk As Label
    Friend WithEvents btnEditStatus As Button
    Friend WithEvents btnLihatDetail As Button
    Friend WithEvents btnResetFilter As Button
    Friend WithEvents dtpTanggalAkhir As DateTimePicker
    Friend WithEvents lblSampai As Label
    Friend WithEvents dtpTanggalMulai As DateTimePicker
    Friend WithEvents pnlTombol As Panel
    Friend WithEvents lblTanggalAmbil As Label
    Friend WithEvents btnCariPesanan As Button
    Friend WithEvents txtCariPesanan As TextBox
    Friend WithEvents pnlTabel As Panel
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents cmbFilterStatus As ComboBox

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblDeskripsiHalaman As Label

End Class