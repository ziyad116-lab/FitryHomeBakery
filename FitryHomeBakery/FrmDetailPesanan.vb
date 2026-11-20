''' <summary>
''' Detail satu pesanan. Jumlah tiap item bisa diubah dengan NumericUpDown (0 = hapus item dari pesanan).
''' Dibangun lewat kode, tidak perlu file Designer.
''' </summary>
Public Class FrmDetailPesanan
    Inherits Form

    Private ReadOnly nomor As String
    Private ReadOnly daftarItem As List(Of ItemKeranjang)
    Private ReadOnly daftarNud As New List(Of NumericUpDown)
    Private ReadOnly daftarSubtotal As New List(Of Label)
    Private ReadOnly lblTotal As New Label()
    Private ReadOnly lblSisa As New Label()
    Private ReadOnly bisaUbah As Boolean

    Public Sub New(nomorPesanan As String)
        nomor = nomorPesanan
        daftarItem = DataStore.AmbilItem(nomor)
        Dim baris As DataRow = DataStore.AmbilPesanan(nomor)
        Dim status As String = If(baris Is Nothing, "", baris("Status").ToString())
        bisaUbah = DataStore.BelumSelesai(status)

        Text = "Detail Pesanan " & nomor
        FormBorderStyle = FormBorderStyle.FixedDialog
        StartPosition = FormStartPosition.CenterParent
        MaximizeBox = False
        MinimizeBox = False
        ShowInTaskbar = False
        BackColor = Tema.Krem
        Font = New Font("Segoe UI", 10.0F)
        ClientSize = New Size(640, 540)

        If baris Is Nothing Then
            Close()
            Return
        End If

        ' ----- header coklat -----
        Dim pnlJudul As New Panel With {.Dock = DockStyle.Top, .Height = 56, .BackColor = Tema.CoklatTua}
        pnlJudul.Controls.Add(New Label With {
            .Text = "Detail Pesanan " & nomor, .AutoSize = True,
            .Font = New Font("Segoe UI", 15.0F, FontStyle.Bold),
            .ForeColor = Color.White, .Location = New Point(24, 12)
        })
        Controls.Add(pnlJudul)

        ' ----- info pelanggan -----
        Dim y As Integer = 74
        BuatInfo("Pelanggan", baris("NamaPelanggan").ToString() & "  (" & baris("NoWA").ToString() & ")", y) : y += 28
        BuatInfo("Tanggal ambil", CDate(baris("TanggalAmbil")).ToString("dd/MM/yyyy") & "  " & baris("JamAmbil").ToString(), y) : y += 28
        BuatInfo("Status", status, y) : y += 28
        BuatInfo("Jenis", baris("Jenis").ToString(), y) : y += 28
        If baris("Catatan").ToString() <> "" Then
            BuatInfo("Catatan", baris("Catatan").ToString(), y) : y += 28
        End If

        ' ----- daftar item -----
        y += 8
        Dim pnlItem As New Panel With {
            .Location = New Point(24, y), .Size = New Size(592, 190),
            .BackColor = Color.White, .AutoScroll = True
        }
        Dim tbl As New TableLayoutPanel With {.Location = New Point(0, 0), .Width = 575, .AutoSize = True, .ColumnCount = 4}
        tbl.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 215))
        tbl.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 110))
        tbl.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 90))
        tbl.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 160))
        TambahSel(tbl, "Produk", 0, True, ContentAlignment.MiddleLeft)
        TambahSel(tbl, "Harga", 1, True, ContentAlignment.MiddleRight)
        TambahSel(tbl, "Jumlah", 2, True, ContentAlignment.MiddleCenter)
        TambahSel(tbl, "Subtotal", 3, True, ContentAlignment.MiddleRight)

        For i As Integer = 0 To daftarItem.Count - 1
            Dim it As ItemKeranjang = daftarItem(i)
            TambahSel(tbl, it.Nama, 0, False, ContentAlignment.MiddleLeft)
            TambahSel(tbl, Tema.Rupiah(it.Harga), 1, False, ContentAlignment.MiddleRight)

            Dim nud As New NumericUpDown With {
                .Minimum = 0, .Maximum = 99, .Value = Math.Min(99, Math.Max(0, it.Qty)),
                .Width = 70, .TextAlign = HorizontalAlignment.Center,
                .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold),
                .Enabled = bisaUbah, .Anchor = AnchorStyles.None
            }
            AddHandler nud.ValueChanged, AddressOf HitungUlang
            daftarNud.Add(nud)
            tbl.Controls.Add(nud, 2, i + 1)

            Dim lblSub As Label = TambahSel(tbl, Tema.Rupiah(it.Subtotal), 3, False, ContentAlignment.MiddleRight)
            daftarSubtotal.Add(lblSub)
        Next
        pnlItem.Controls.Add(tbl)
        Controls.Add(pnlItem)
        y += pnlItem.Height + 12

        ' ----- total & sisa -----
        lblTotal.AutoSize = False
        lblTotal.SetBounds(24, y, 592, 28)
        lblTotal.TextAlign = ContentAlignment.MiddleRight
        lblTotal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTotal.ForeColor = Tema.CoklatTua
        Controls.Add(lblTotal)
        lblSisa.AutoSize = False
        lblSisa.SetBounds(24, y + 28, 592, 24)
        lblSisa.TextAlign = ContentAlignment.MiddleRight
        lblSisa.Font = New Font("Segoe UI", 9.5F)
        Controls.Add(lblSisa)

        ' ----- tombol -----
        Dim btnTutup As New Button With {
            .Text = If(bisaUbah, "Batal", "Tutup"), .Size = New Size(130, 40), .Location = New Point(486, 488),
            .FlatStyle = FlatStyle.Flat, .BackColor = Tema.Pasir, .ForeColor = Tema.CoklatTua,
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold), .Cursor = Cursors.Hand, .DialogResult = DialogResult.Cancel
        }
        btnTutup.FlatAppearance.BorderSize = 0
        Controls.Add(btnTutup)
        CancelButton = btnTutup

        If bisaUbah Then
            Dim btnSimpan As New Button With {
                .Text = "Simpan Perubahan", .Size = New Size(170, 40), .Location = New Point(306, 488),
                .FlatStyle = FlatStyle.Flat, .BackColor = Tema.CoklatSedang, .ForeColor = Color.White,
                .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold), .Cursor = Cursors.Hand
            }
            btnSimpan.FlatAppearance.BorderSize = 0
            AddHandler btnSimpan.Click, AddressOf SaatSimpan
            Controls.Add(btnSimpan)
        Else
            Controls.Add(New Label With {
                .Text = "Pesanan yang sudah selesai / dibatalkan tidak bisa diubah jumlahnya.",
                .AutoSize = True, .ForeColor = Tema.TeksRedup, .Location = New Point(24, 498)
            })
        End If

        HitungUlang(Nothing, EventArgs.Empty)
    End Sub

    Private Sub BuatInfo(judul As String, isi As String, y As Integer)
        Controls.Add(New Label With {
            .Text = judul, .AutoSize = True, .Location = New Point(24, y),
            .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold), .ForeColor = Tema.CoklatSedang
        })
        Controls.Add(New Label With {
            .Text = isi, .AutoSize = False, .Size = New Size(440, 24), .AutoEllipsis = True,
            .Location = New Point(176, y - 2), .ForeColor = Tema.CoklatTua
        })
    End Sub

    Private Function TambahSel(tbl As TableLayoutPanel, teks As String, kolom As Integer, header As Boolean, rata As ContentAlignment) As Label
        Dim sel As New Label With {
            .Text = teks, .AutoSize = False, .Height = 34, .Dock = DockStyle.Fill,
            .TextAlign = rata, .AutoEllipsis = True, .Margin = New Padding(0),
            .Padding = New Padding(8, 0, 8, 0),
            .Font = New Font("Segoe UI", 9.5F, If(header, FontStyle.Bold, FontStyle.Regular)),
            .ForeColor = If(header, Tema.CoklatSedang, Tema.CoklatTua),
            .BackColor = If(header, Tema.Krem, Color.White)
        }
        tbl.Controls.Add(sel, kolom, tbl.RowCount)
        If kolom = 3 Then tbl.RowCount += 1
        Return sel
    End Function

    Private Sub HitungUlang(sender As Object, e As EventArgs)
        Dim total As Decimal = 0D
        For i As Integer = 0 To daftarItem.Count - 1
            Dim sub1 As Decimal = daftarItem(i).Harga * CInt(daftarNud(i).Value)
            daftarSubtotal(i).Text = Tema.Rupiah(sub1)
            total += sub1
        Next
        lblTotal.Text = "Total: " & Tema.Rupiah(total)

        Dim dibayar As Decimal = DataStore.HitungDibayar(nomor)
        If dibayar >= total Then
            lblSisa.Text = "Dibayar " & Tema.Rupiah(dibayar) & "  -  Lunas"
            lblSisa.ForeColor = Tema.Sukses
        Else
            lblSisa.Text = "Dibayar " & Tema.Rupiah(dibayar) & "  -  Sisa " & Tema.Rupiah(total - dibayar)
            lblSisa.ForeColor = Tema.Peringatan
        End If
    End Sub

    Private Sub SaatSimpan(sender As Object, e As EventArgs)
        Dim baru As New List(Of ItemKeranjang)
        For i As Integer = 0 To daftarItem.Count - 1
            Dim q As Integer = CInt(daftarNud(i).Value)
            If q > 0 Then baru.Add(New ItemKeranjang With {.Nama = daftarItem(i).Nama, .Harga = daftarItem(i).Harga, .Qty = q})
        Next
        If baru.Count = 0 Then
            MessageBox.Show("Pesanan harus punya minimal satu item." & vbCrLf &
                            "Untuk membatalkan pesanan, ubah statusnya menjadi Dibatalkan.",
                            "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        DataStore.UbahItem(nomor, baru)
        DialogResult = DialogResult.OK
        Close()
    End Sub

End Class
