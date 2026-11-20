Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcPembayaran
    Inherits System.Windows.Forms.UserControl

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblDeskripsi = New Label()
        lblJudulPembayaran = New Label()
        tlpRingkasanPembayaran = New TableLayoutPanel()
        pnlTotalTagihan = New Panel()
        lblNilaiTotalTagihan = New Label()
        lblJudulTotalTagihan = New Label()
        pnlTotalDiterima = New Panel()
        lblNilaiTotalDiterima = New Label()
        lblJudulTotalDiterima = New Label()
        pnlSisaTagihan = New Panel()
        lblNilaiSisaTagihan = New Label()
        lblJudulSisaTagihan = New Label()
        txtCariPembayaran = New TextBox()
        cmbFilterPembayaran = New ComboBox()
        btnCariPembayaran = New Button()
        btnCatatPembayaran = New Button()
        dgvPembayaran = New DataGridView()
        colIDPembayaran = New DataGridViewTextBoxColumn()
        colNomorPesanan = New DataGridViewTextBoxColumn()
        colNamaPelanggan = New DataGridViewTextBoxColumn()
        colTotalTagihan = New DataGridViewTextBoxColumn()
        colTotalDibayar = New DataGridViewTextBoxColumn()
        colSisaPembayaran = New DataGridViewTextBoxColumn()
        colStatusPembayaran = New DataGridViewTextBoxColumn()
        pnlHeader.SuspendLayout()
        tlpRingkasanPembayaran.SuspendLayout()
        pnlTotalTagihan.SuspendLayout()
        pnlTotalDiterima.SuspendLayout()
        pnlSisaTagihan.SuspendLayout()
        CType(dgvPembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        pnlHeader.Controls.Add(lblDeskripsi)
        pnlHeader.Controls.Add(lblJudulPembayaran)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1098, 48)
        pnlHeader.TabIndex = 0
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.Font = New Font("Segoe UI", 10.5F)
        lblDeskripsi.ForeColor = Color.FromArgb(CByte(238), CByte(228), CByte(220))
        lblDeskripsi.Location = New Point(24, 10)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(558, 30)
        lblDeskripsi.TabIndex = 0
        lblDeskripsi.Text = "Kelola pembayaran DP dan pelunasan pesanan pelanggan."
        ' 
        ' lblJudulPembayaran
        ' 
        lblJudulPembayaran.AutoSize = True
        lblJudulPembayaran.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblJudulPembayaran.ForeColor = Color.White
        lblJudulPembayaran.Location = New Point(24, 6)
        lblJudulPembayaran.Name = "lblJudulPembayaran"
        lblJudulPembayaran.Size = New Size(259, 54)
        lblJudulPembayaran.TabIndex = 1
        lblJudulPembayaran.Text = "Pembayaran"
        lblJudulPembayaran.Visible = False
        ' 
        ' tlpRingkasanPembayaran
        ' 
        tlpRingkasanPembayaran.ColumnCount = 3
        tlpRingkasanPembayaran.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpRingkasanPembayaran.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpRingkasanPembayaran.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.34F))
        tlpRingkasanPembayaran.Controls.Add(pnlTotalTagihan, 0, 0)
        tlpRingkasanPembayaran.Controls.Add(pnlTotalDiterima, 1, 0)
        tlpRingkasanPembayaran.Controls.Add(pnlSisaTagihan, 2, 0)
        tlpRingkasanPembayaran.Dock = DockStyle.Top
        tlpRingkasanPembayaran.Location = New Point(0, 48)
        tlpRingkasanPembayaran.Name = "tlpRingkasanPembayaran"
        tlpRingkasanPembayaran.Padding = New Padding(24, 16, 12, 8)
        tlpRingkasanPembayaran.RowCount = 1
        tlpRingkasanPembayaran.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpRingkasanPembayaran.Size = New Size(1098, 124)
        tlpRingkasanPembayaran.TabIndex = 1
        ' 
        ' pnlTotalTagihan
        ' 
        pnlTotalTagihan.BackColor = Color.White
        pnlTotalTagihan.Controls.Add(lblNilaiTotalTagihan)
        pnlTotalTagihan.Controls.Add(lblJudulTotalTagihan)
        pnlTotalTagihan.Dock = DockStyle.Fill
        pnlTotalTagihan.Location = New Point(24, 16)
        pnlTotalTagihan.Margin = New Padding(0, 0, 12, 0)
        pnlTotalTagihan.Name = "pnlTotalTagihan"
        pnlTotalTagihan.Padding = New Padding(15)
        pnlTotalTagihan.Size = New Size(341, 100)
        pnlTotalTagihan.TabIndex = 0
        ' 
        ' lblNilaiTotalTagihan
        ' 
        lblNilaiTotalTagihan.AutoSize = True
        lblNilaiTotalTagihan.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblNilaiTotalTagihan.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        lblNilaiTotalTagihan.Location = New Point(13, 40)
        lblNilaiTotalTagihan.Name = "lblNilaiTotalTagihan"
        lblNilaiTotalTagihan.Size = New Size(257, 54)
        lblNilaiTotalTagihan.TabIndex = 1
        lblNilaiTotalTagihan.Text = "Rp2.500.000"
        ' 
        ' lblJudulTotalTagihan
        ' 
        lblJudulTotalTagihan.AutoSize = True
        lblJudulTotalTagihan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblJudulTotalTagihan.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblJudulTotalTagihan.Location = New Point(15, 14)
        lblJudulTotalTagihan.Name = "lblJudulTotalTagihan"
        lblJudulTotalTagihan.Size = New Size(139, 28)
        lblJudulTotalTagihan.TabIndex = 0
        lblJudulTotalTagihan.Text = "Total Tagihan"
        ' 
        ' pnlTotalDiterima
        ' 
        pnlTotalDiterima.BackColor = Color.White
        pnlTotalDiterima.Controls.Add(lblNilaiTotalDiterima)
        pnlTotalDiterima.Controls.Add(lblJudulTotalDiterima)
        pnlTotalDiterima.Dock = DockStyle.Fill
        pnlTotalDiterima.Location = New Point(377, 16)
        pnlTotalDiterima.Margin = New Padding(0, 0, 12, 0)
        pnlTotalDiterima.Name = "pnlTotalDiterima"
        pnlTotalDiterima.Padding = New Padding(15)
        pnlTotalDiterima.Size = New Size(341, 100)
        pnlTotalDiterima.TabIndex = 1
        ' 
        ' lblNilaiTotalDiterima
        ' 
        lblNilaiTotalDiterima.AutoSize = True
        lblNilaiTotalDiterima.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblNilaiTotalDiterima.ForeColor = Color.FromArgb(CByte(6), CByte(95), CByte(70))
        lblNilaiTotalDiterima.Location = New Point(13, 40)
        lblNilaiTotalDiterima.Name = "lblNilaiTotalDiterima"
        lblNilaiTotalDiterima.Size = New Size(257, 54)
        lblNilaiTotalDiterima.TabIndex = 1
        lblNilaiTotalDiterima.Text = "Rp1.800.000"
        ' 
        ' lblJudulTotalDiterima
        ' 
        lblJudulTotalDiterima.AutoSize = True
        lblJudulTotalDiterima.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblJudulTotalDiterima.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblJudulTotalDiterima.Location = New Point(15, 14)
        lblJudulTotalDiterima.Name = "lblJudulTotalDiterima"
        lblJudulTotalDiterima.Size = New Size(148, 28)
        lblJudulTotalDiterima.TabIndex = 0
        lblJudulTotalDiterima.Text = "Total Diterima"
        ' 
        ' pnlSisaTagihan
        ' 
        pnlSisaTagihan.BackColor = Color.White
        pnlSisaTagihan.Controls.Add(lblNilaiSisaTagihan)
        pnlSisaTagihan.Controls.Add(lblJudulSisaTagihan)
        pnlSisaTagihan.Dock = DockStyle.Fill
        pnlSisaTagihan.Location = New Point(730, 16)
        pnlSisaTagihan.Margin = New Padding(0, 0, 12, 0)
        pnlSisaTagihan.Name = "pnlSisaTagihan"
        pnlSisaTagihan.Padding = New Padding(15)
        pnlSisaTagihan.Size = New Size(344, 100)
        pnlSisaTagihan.TabIndex = 2
        ' 
        ' lblNilaiSisaTagihan
        ' 
        lblNilaiSisaTagihan.AutoSize = True
        lblNilaiSisaTagihan.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblNilaiSisaTagihan.ForeColor = Color.FromArgb(CByte(180), CByte(110), CByte(0))
        lblNilaiSisaTagihan.Location = New Point(13, 40)
        lblNilaiSisaTagihan.Name = "lblNilaiSisaTagihan"
        lblNilaiSisaTagihan.Size = New Size(223, 54)
        lblNilaiSisaTagihan.TabIndex = 1
        lblNilaiSisaTagihan.Text = "Rp700.000"
        ' 
        ' lblJudulSisaTagihan
        ' 
        lblJudulSisaTagihan.AutoSize = True
        lblJudulSisaTagihan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblJudulSisaTagihan.ForeColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        lblJudulSisaTagihan.Location = New Point(15, 14)
        lblJudulSisaTagihan.Name = "lblJudulSisaTagihan"
        lblJudulSisaTagihan.Size = New Size(129, 28)
        lblJudulSisaTagihan.TabIndex = 0
        lblJudulSisaTagihan.Text = "Sisa Tagihan"
        ' 
        ' txtCariPembayaran
        ' 
        txtCariPembayaran.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCariPembayaran.BorderStyle = BorderStyle.FixedSingle
        txtCariPembayaran.Font = New Font("Segoe UI", 10.5F)
        txtCariPembayaran.Location = New Point(24, 184)
        txtCariPembayaran.Name = "txtCariPembayaran"
        txtCariPembayaran.PlaceholderText = "Cari nama pelanggan atau nomor pesanan..."
        txtCariPembayaran.Size = New Size(574, 35)
        txtCariPembayaran.TabIndex = 2
        ' 
        ' cmbFilterPembayaran
        ' 
        cmbFilterPembayaran.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbFilterPembayaran.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilterPembayaran.Font = New Font("Segoe UI", 10.5F)
        cmbFilterPembayaran.FormattingEnabled = True
        cmbFilterPembayaran.Items.AddRange(New Object() {"Semua Status", "Belum Lunas", "Lunas"})
        cmbFilterPembayaran.Location = New Point(610, 184)
        cmbFilterPembayaran.Name = "cmbFilterPembayaran"
        cmbFilterPembayaran.Size = New Size(150, 38)
        cmbFilterPembayaran.TabIndex = 3
        ' 
        ' btnCariPembayaran
        ' 
        btnCariPembayaran.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCariPembayaran.BackColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        btnCariPembayaran.Cursor = Cursors.Hand
        btnCariPembayaran.FlatAppearance.BorderSize = 0
        btnCariPembayaran.FlatStyle = FlatStyle.Flat
        btnCariPembayaran.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCariPembayaran.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        btnCariPembayaran.Location = New Point(772, 184)
        btnCariPembayaran.Name = "btnCariPembayaran"
        btnCariPembayaran.Size = New Size(100, 36)
        btnCariPembayaran.TabIndex = 4
        btnCariPembayaran.Text = "Cari"
        btnCariPembayaran.UseVisualStyleBackColor = False
        ' 
        ' btnCatatPembayaran
        ' 
        btnCatatPembayaran.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCatatPembayaran.BackColor = Color.FromArgb(CByte(121), CByte(85), CByte(72))
        btnCatatPembayaran.Cursor = Cursors.Hand
        btnCatatPembayaran.FlatAppearance.BorderSize = 0
        btnCatatPembayaran.FlatStyle = FlatStyle.Flat
        btnCatatPembayaran.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCatatPembayaran.ForeColor = Color.White
        btnCatatPembayaran.Location = New Point(884, 184)
        btnCatatPembayaran.Name = "btnCatatPembayaran"
        btnCatatPembayaran.Size = New Size(190, 36)
        btnCatatPembayaran.TabIndex = 5
        btnCatatPembayaran.Text = "+ Catat Pembayaran"
        btnCatatPembayaran.UseVisualStyleBackColor = False
        ' 
        ' dgvPembayaran
        ' 
        dgvPembayaran.AllowUserToAddRows = False
        dgvPembayaran.AllowUserToDeleteRows = False
        dgvPembayaran.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        dgvPembayaran.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvPembayaran.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPembayaran.BackgroundColor = Color.White
        dgvPembayaran.BorderStyle = BorderStyle.None
        dgvPembayaran.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPembayaran.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvPembayaran.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvPembayaran.ColumnHeadersHeight = 40
        dgvPembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPembayaran.Columns.AddRange(New DataGridViewColumn() {colIDPembayaran, colNomorPesanan, colNamaPelanggan, colTotalTagihan, colTotalDibayar, colSisaPembayaran, colStatusPembayaran})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(73), CByte(51), CByte(43))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvPembayaran.DefaultCellStyle = DataGridViewCellStyle5
        dgvPembayaran.EnableHeadersVisualStyles = False
        dgvPembayaran.GridColor = Color.FromArgb(CByte(233), CByte(222), CByte(211))
        dgvPembayaran.Location = New Point(24, 236)
        dgvPembayaran.MultiSelect = False
        dgvPembayaran.Name = "dgvPembayaran"
        dgvPembayaran.ReadOnly = True
        dgvPembayaran.RowHeadersVisible = False
        dgvPembayaran.RowHeadersWidth = 62
        dgvPembayaran.RowTemplate.Height = 40
        dgvPembayaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembayaran.Size = New Size(1050, 461)
        dgvPembayaran.TabIndex = 6
        ' 
        ' colIDPembayaran
        ' 
        colIDPembayaran.HeaderText = "ID Pembayaran"
        colIDPembayaran.MinimumWidth = 8
        colIDPembayaran.Name = "colIDPembayaran"
        colIDPembayaran.ReadOnly = True
        ' 
        ' colNomorPesanan
        ' 
        colNomorPesanan.HeaderText = "Nomor Pesanan"
        colNomorPesanan.MinimumWidth = 8
        colNomorPesanan.Name = "colNomorPesanan"
        colNomorPesanan.ReadOnly = True
        ' 
        ' colNamaPelanggan
        ' 
        colNamaPelanggan.HeaderText = "Nama Pelanggan"
        colNamaPelanggan.MinimumWidth = 8
        colNamaPelanggan.Name = "colNamaPelanggan"
        colNamaPelanggan.ReadOnly = True
        ' 
        ' colTotalTagihan
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        colTotalTagihan.DefaultCellStyle = DataGridViewCellStyle3
        colTotalTagihan.HeaderText = "Total Tagihan"
        colTotalTagihan.MinimumWidth = 8
        colTotalTagihan.Name = "colTotalTagihan"
        colTotalTagihan.ReadOnly = True
        ' 
        ' colTotalDibayar
        ' 
        colTotalDibayar.DefaultCellStyle = DataGridViewCellStyle3
        colTotalDibayar.HeaderText = "Total Dibayar"
        colTotalDibayar.MinimumWidth = 8
        colTotalDibayar.Name = "colTotalDibayar"
        colTotalDibayar.ReadOnly = True
        ' 
        ' colSisaPembayaran
        ' 
        colSisaPembayaran.DefaultCellStyle = DataGridViewCellStyle3
        colSisaPembayaran.HeaderText = "Sisa Pembayaran"
        colSisaPembayaran.MinimumWidth = 8
        colSisaPembayaran.Name = "colSisaPembayaran"
        colSisaPembayaran.ReadOnly = True
        ' 
        ' colStatusPembayaran
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        colStatusPembayaran.DefaultCellStyle = DataGridViewCellStyle4
        colStatusPembayaran.HeaderText = "Status Pembayaran"
        colStatusPembayaran.MinimumWidth = 8
        colStatusPembayaran.Name = "colStatusPembayaran"
        colStatusPembayaran.ReadOnly = True
        ' 
        ' UcPembayaran
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(238))
        Controls.Add(dgvPembayaran)
        Controls.Add(btnCatatPembayaran)
        Controls.Add(btnCariPembayaran)
        Controls.Add(cmbFilterPembayaran)
        Controls.Add(txtCariPembayaran)
        Controls.Add(tlpRingkasanPembayaran)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 10F)
        Name = "UcPembayaran"
        Size = New Size(1098, 721)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        tlpRingkasanPembayaran.ResumeLayout(False)
        pnlTotalTagihan.ResumeLayout(False)
        pnlTotalTagihan.PerformLayout()
        pnlTotalDiterima.ResumeLayout(False)
        pnlTotalDiterima.PerformLayout()
        pnlSisaTagihan.ResumeLayout(False)
        pnlSisaTagihan.PerformLayout()
        CType(dgvPembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudulPembayaran As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents tlpRingkasanPembayaran As TableLayoutPanel
    Friend WithEvents pnlTotalTagihan As Panel
    Friend WithEvents lblJudulTotalTagihan As Label
    Friend WithEvents lblNilaiTotalTagihan As Label
    Friend WithEvents pnlTotalDiterima As Panel
    Friend WithEvents lblJudulTotalDiterima As Label
    Friend WithEvents lblNilaiTotalDiterima As Label
    Friend WithEvents pnlSisaTagihan As Panel
    Friend WithEvents lblJudulSisaTagihan As Label
    Friend WithEvents lblNilaiSisaTagihan As Label
    Friend WithEvents txtCariPembayaran As TextBox
    Friend WithEvents cmbFilterPembayaran As ComboBox
    Friend WithEvents btnCariPembayaran As Button
    Friend WithEvents btnCatatPembayaran As Button
    Friend WithEvents dgvPembayaran As DataGridView
    Friend WithEvents colIDPembayaran As DataGridViewTextBoxColumn
    Friend WithEvents colNomorPesanan As DataGridViewTextBoxColumn
    Friend WithEvents colNamaPelanggan As DataGridViewTextBoxColumn
    Friend WithEvents colTotalTagihan As DataGridViewTextBoxColumn
    Friend WithEvents colTotalDibayar As DataGridViewTextBoxColumn
    Friend WithEvents colSisaPembayaran As DataGridViewTextBoxColumn
    Friend WithEvents colStatusPembayaran As DataGridViewTextBoxColumn
End Class