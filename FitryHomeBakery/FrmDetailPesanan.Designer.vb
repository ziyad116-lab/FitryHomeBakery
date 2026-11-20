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
        pnlHeader = New Panel()
        lblJudul = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(800, 55)
        pnlHeader.TabIndex = 0
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F)
        lblJudul.Location = New Point(54, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(136, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Detail Pesanan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 0
        Label1.Text = "Pelanggan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 15)
        Label2.TabIndex = 1
        Label2.Text = "Tanggal Ambil"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(54, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 3
        Label4.Text = "Jenis"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(54, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 15)
        Label5.TabIndex = 4
        Label5.Text = "Catatan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(224, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 5
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(229, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 6
        Label7.Text = "Label7"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(231, 181)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 7
        Label8.Text = "Label8"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(235, 239)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 15)
        Label9.TabIndex = 8
        Label9.Text = "Label9"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(238, 299)
        Label10.Name = "Label10"
        Label10.Size = New Size(47, 15)
        Label10.TabIndex = 9
        Label10.Text = "Label10"
        ' 
        ' FrmDetailPesanan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(pnlHeader)
        Name = "FrmDetailPesanan"
        Text = "FrmDetailPesanan"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
