Imports System.Globalization

Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvPesananMendatang.RowTemplate.Height = 35
        dgvPesananMendatang.RowHeadersVisible = False
        dgvPesananMendatang.AllowUserToAddRows = False
        dgvPesananMendatang.AllowUserToDeleteRows = False
        dgvPesananMendatang.ReadOnly = True
        dgvPesananMendatang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPesananMendatang.MultiSelect = False
        dgvProdukTerlaris.RowHeadersVisible = False
        dgvProdukTerlaris.AllowUserToAddRows = False
        dgvProdukTerlaris.AllowUserToDeleteRows = False
        dgvProdukTerlaris.ReadOnly = True
        dgvProdukTerlaris.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProdukTerlaris.MultiSelect = False
        cmbPeriodePenjualan.SelectedIndex = 2

    End Sub

    ' ===== Warna tombol sidebar =====
    Private ReadOnly warnaNormal As Color = Tema.CoklatTua
    Private ReadOnly warnaAktif As Color = Tema.CoklatSedang

    Private pnlBeranda As Panel
    Private halamanAktif As UserControl
    Private daftarTombol As List(Of Button)

    ' Nama berbeda dari FormMain_Load lama, jadi tidak bentrok
    Private Sub SiapkanNavigasi(sender As Object, e As EventArgs) Handles MyBase.Load
        daftarTombol = New List(Of Button) From {
            btnBeranda, btnTambahPesanan, btnDataPesanan,
            btnCustomPesanan, btnPembayaran, btnManajemenProduk, btnPengaturan
        }

        ' Bungkus isi dashboard ke dalam pnlBeranda
        pnlBeranda = New Panel With {
            .Dock = DockStyle.Fill,
            .AutoScroll = True,
            .BackColor = pnlContent.BackColor,
            .Padding = pnlContent.Padding,
            .AutoScrollMargin = pnlContent.AutoScrollMargin
        }

        Dim isiDashboard = pnlContent.Controls.Cast(Of Control)().ToList()
        pnlContent.SuspendLayout()
        For Each c In isiDashboard
            pnlBeranda.Controls.Add(c)
        Next
        pnlContent.Padding = New Padding(0)
        pnlContent.AutoScroll = False
        pnlContent.Controls.Add(pnlBeranda)
        pnlContent.ResumeLayout()

        ' Panel dashboard dilebarkan mengikuti jendela (tidak memakai Anchor, supaya tidak meluber)
        For Each p In New Panel() {pnlPesananMendatang, pnlRingkasanPenjualan, pnlProdukTerlaris}
            p.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        Next
        AddHandler pnlBeranda.SizeChanged, AddressOf RapikanBeranda
        AddHandler pnlGrafikPenjualan.SizeChanged, Sub(s, ev) pnlGrafikPenjualan.Invalidate()
        AktifkanDoubleBuffer(pnlGrafikPenjualan)
        For Each b In New Panel() {pnlBatangPenjualan1, pnlBatangPenjualan2, pnlBatangPenjualan3, pnlBatangPenjualan4}
            b.Visible = False   ' batang contoh diganti grafik yang digambar dari data
        Next
        RapikanBeranda(Nothing, EventArgs.Empty)

        TampilkanHalaman(Nothing, "Beranda", btnBeranda)
    End Sub

    Private Sub RapikanBeranda(sender As Object, e As EventArgs)
        If pnlBeranda Is Nothing Then Return
        Dim lebar As Integer = Math.Max(400, pnlBeranda.ClientSize.Width - 48)
        For Each p In New Panel() {pnlPesananMendatang, pnlRingkasanPenjualan, pnlProdukTerlaris}
            p.Left = 24
            p.Width = lebar
        Next
    End Sub

    Private Sub AktifkanDoubleBuffer(kontrol As Control)
        GetType(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic).
            SetValue(kontrol, True, Nothing)
    End Sub

    ' halaman = Nothing berarti tampilkan Beranda
    Private Sub TampilkanHalaman(halaman As UserControl, judul As String, tombol As Button)
        pnlContent.SuspendLayout()

        If halamanAktif IsNot Nothing Then
            pnlContent.Controls.Remove(halamanAktif)
            halamanAktif.Dispose()
            halamanAktif = Nothing
        End If

        If halaman Is Nothing Then
            MuatBeranda()
            pnlBeranda.Visible = True
        Else
            pnlBeranda.Visible = False
            halaman.Dock = DockStyle.Fill
            pnlContent.Controls.Add(halaman)
            halaman.BringToFront()
            halamanAktif = halaman
        End If

        lblJudulHalaman.Text = judul

        For Each b In daftarTombol
            b.BackColor = If(b Is tombol, warnaAktif, warnaNormal)
        Next

        pnlContent.ResumeLayout()
    End Sub


    ' ============================================================
    '  BERANDA: ISI DATA DARI DataStore
    ' ============================================================
    Private dataGrafik As New List(Of KeyValuePair(Of String, Decimal))

    Private Sub MuatBeranda()
        Dim hariIni As Date = Date.Today
        Dim besok As Date = hariIni.AddDays(1)

        Dim aktif As List(Of DataRow) = DataStore.Pesanan.Rows.Cast(Of DataRow)().
            Where(Function(r) r("Status").ToString() <> "Dibatalkan").ToList()

        ' ----- kartu ringkasan -----
        lblAngkaPesananHariIni.Text = aktif.Where(Function(r) CDate(r("TanggalPesan")).Date = hariIni).Count().ToString()
        lblAngkaPesananBesok.Text = aktif.Where(Function(r) CDate(r("TanggalAmbil")).Date = besok).Count().ToString()
        lblAngkaBelumSelesai.Text = aktif.Where(Function(r) DataStore.BelumSelesai(r("Status").ToString())).Count().ToString()
        lblAngkaBelumLunas.Text = aktif.Where(Function(r) DataStore.SisaTagihan(r("NomorPesanan").ToString()) > 0D).Count().ToString()

        ' ----- pesanan mendatang -----
        dgvPesananMendatang.Rows.Clear()
        Dim mendatang As List(Of DataRow) = aktif.
            Where(Function(r) DataStore.BelumSelesai(r("Status").ToString()) AndAlso CDate(r("TanggalAmbil")).Date >= hariIni).
            OrderBy(Function(r) CDate(r("TanggalAmbil")).Date).
            ThenBy(Function(r) r("JamAmbil").ToString()).
            Take(10).ToList()
        For Each r In mendatang
            dgvPesananMendatang.Rows.Add(
                r("NomorPesanan").ToString(), r("NamaPelanggan").ToString(), r("Produk").ToString(),
                CInt(r("Jumlah")), CDate(r("TanggalAmbil")).ToString("dd/MM/yyyy"),
                r("JamAmbil").ToString(), r("Status").ToString())
        Next
        dgvPesananMendatang.Visible = mendatang.Count > 0
        lblBelumAdaPesanan.Visible = mendatang.Count = 0
        dgvPesananMendatang.ClearSelection()

        ' ----- produk terlaris -----
        Dim batal As New HashSet(Of String)(
            DataStore.Pesanan.Rows.Cast(Of DataRow)().
            Where(Function(r) r("Status").ToString() = "Dibatalkan").
            Select(Function(r) r("NomorPesanan").ToString()))
        Dim terlaris = DataStore.ItemPesanan.Rows.Cast(Of DataRow)().
            Where(Function(r) Not batal.Contains(r("NomorPesanan").ToString())).
            GroupBy(Function(r) r("NamaProduk").ToString()).
            Select(Function(g) New KeyValuePair(Of String, Integer)(g.Key, g.Sum(Function(x) CInt(x("Qty"))))).
            OrderByDescending(Function(k) k.Value).
            Take(5).ToList()
        dgvProdukTerlaris.Rows.Clear()
        For i As Integer = 0 To terlaris.Count - 1
            dgvProdukTerlaris.Rows.Add(i + 1, terlaris(i).Key, terlaris(i).Value)
        Next
        dgvProdukTerlaris.Visible = terlaris.Count > 0
        lblBelumAdaProduk.Visible = terlaris.Count = 0
        dgvProdukTerlaris.ClearSelection()

        PerbaruiPenjualan()
    End Sub

    ' warna status pada tabel pesanan mendatang
    Private Sub dgvPesananMendatang_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPesananMendatang.CellFormatting
        If e.RowIndex < 0 OrElse e.ColumnIndex <> StatusPesanan.Index OrElse e.Value Is Nothing Then Return
        Select Case e.Value.ToString()
            Case "Siap Diambil"
                e.CellStyle.BackColor = Tema.LatarSukses
                e.CellStyle.ForeColor = Tema.Sukses
            Case Else
                e.CellStyle.BackColor = Tema.LatarPeringatan
                e.CellStyle.ForeColor = Tema.CoklatAksen
        End Select
        e.CellStyle.SelectionBackColor = e.CellStyle.BackColor
        e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor
    End Sub

    ' ============================================================
    '  RINGKASAN & GRAFIK PENJUALAN
    ' ============================================================
    Private Sub cmbPeriodePenjualan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPeriodePenjualan.SelectedIndexChanged
        PerbaruiPenjualan()
    End Sub

    Private Sub PerbaruiPenjualan()
        Dim periode As String = If(cmbPeriodePenjualan.SelectedItem Is Nothing, "Bulan Ini", cmbPeriodePenjualan.SelectedItem.ToString())
        dataGrafik = HitungGrafik(periode)
        lblNominalPenjualan.Text = Tema.Rupiah(dataGrafik.Sum(Function(k) k.Value))
        lblPeriodePenjualan.Text = "Akumulasi penjualan " & periode.ToLower()
        pnlGrafikPenjualan.Invalidate()
    End Sub

    Private Function Jumlahkan(dari As Date, sampai As Date, Optional jenis As String = "") As Decimal
        Dim total As Decimal = 0D
        For Each r As DataRow In DataStore.Pesanan.Rows
            If r("Status").ToString() = "Dibatalkan" Then Continue For
            If jenis <> "" AndAlso r("Jenis").ToString() <> jenis Then Continue For
            Dim tgl As Date = CDate(r("TanggalPesan")).Date
            If tgl >= dari.Date AndAlso tgl <= sampai.Date Then total += CDec(r("TotalTagihan"))
        Next
        Return total
    End Function

    Private Function HitungGrafik(periode As String) As List(Of KeyValuePair(Of String, Decimal))
        Dim hasil As New List(Of KeyValuePair(Of String, Decimal))
        Dim h As Date = Date.Today
        Select Case periode
            Case "Hari Ini"
                hasil.Add(New KeyValuePair(Of String, Decimal)("Reguler", Jumlahkan(h, h, "Reguler")))
                hasil.Add(New KeyValuePair(Of String, Decimal)("Custom", Jumlahkan(h, h, "Custom")))
            Case "Minggu Ini"
                Dim senin As Date = h.AddDays(-((CInt(h.DayOfWeek) + 6) Mod 7))
                Dim nama As String() = {"Sen", "Sel", "Rab", "Kam", "Jum", "Sab", "Min"}
                For i As Integer = 0 To 6
                    hasil.Add(New KeyValuePair(Of String, Decimal)(nama(i), Jumlahkan(senin.AddDays(i), senin.AddDays(i))))
                Next
            Case "Bulan Ini", "Bulan Lalu"
                Dim awal As New Date(h.Year, h.Month, 1)
                If periode = "Bulan Lalu" Then awal = awal.AddMonths(-1)
                Dim akhir As Date = awal.AddMonths(1).AddDays(-1)
                hasil.Add(New KeyValuePair(Of String, Decimal)("Mgg 1", Jumlahkan(awal, awal.AddDays(6))))
                hasil.Add(New KeyValuePair(Of String, Decimal)("Mgg 2", Jumlahkan(awal.AddDays(7), awal.AddDays(13))))
                hasil.Add(New KeyValuePair(Of String, Decimal)("Mgg 3", Jumlahkan(awal.AddDays(14), awal.AddDays(20))))
                hasil.Add(New KeyValuePair(Of String, Decimal)("Mgg 4", Jumlahkan(awal.AddDays(21), akhir)))
            Case "Tahun Ini"
                Dim bulan As String() = {"Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Agu", "Sep", "Okt", "Nov", "Des"}
                For i As Integer = 1 To 12
                    Dim awal As New Date(h.Year, i, 1)
                    hasil.Add(New KeyValuePair(Of String, Decimal)(bulan(i - 1), Jumlahkan(awal, awal.AddMonths(1).AddDays(-1))))
                Next
        End Select
        Return hasil
    End Function

    Private Function FormatSingkat(nilai As Decimal) As String
        Dim id As CultureInfo = CultureInfo.GetCultureInfo("id-ID")
        If nilai >= 1000000D Then Return (nilai / 1000000D).ToString("0.#", id) & " jt"
        If nilai >= 1000D Then Return (nilai / 1000D).ToString("0", id) & " rb"
        Return nilai.ToString("0", id)
    End Function

    Private Sub pnlGrafikPenjualan_Paint(sender As Object, e As PaintEventArgs) Handles pnlGrafikPenjualan.Paint
        Dim g As Graphics = e.Graphics
        Dim skala As Single = pnlGrafikPenjualan.DeviceDpi / 96.0F
        Dim atas As Integer = lblKeteranganGrafik.Bottom + CInt(34 * skala)
        Dim area As New Rectangle(CInt(24 * skala), atas,
                                  pnlGrafikPenjualan.ClientSize.Width - CInt(48 * skala),
                                  pnlGrafikPenjualan.ClientSize.Height - atas - CInt(32 * skala))
        If area.Height < 30 OrElse area.Width < 60 Then Return

        Using fon As New Font("Segoe UI", 9.0F)
            Dim maks As Decimal = If(dataGrafik.Count = 0, 0D, dataGrafik.Max(Function(k) k.Value))
            If maks <= 0D Then
                TextRenderer.DrawText(g, "Belum ada data penjualan pada periode ini.", fon, area, Tema.TeksRedup,
                                      TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
                Return
            End If

            Using garis As New Pen(Tema.Pasir, 1.0F)
                g.DrawLine(garis, area.Left, area.Bottom, area.Right, area.Bottom)
            End Using

            Dim slot As Single = area.Width / CSng(dataGrafik.Count)
            Dim lebarBatang As Single = Math.Min(64.0F * skala, slot * 0.55F)
            Dim tinggiMaks As Single = area.Height - 24.0F * skala

            Using kuas As New SolidBrush(Tema.CoklatAksen)
                For i As Integer = 0 To dataGrafik.Count - 1
                    Dim nilai As Decimal = dataGrafik(i).Value
                    Dim tinggi As Single = CSng(nilai / maks) * tinggiMaks
                    Dim x As Single = area.Left + i * slot + (slot - lebarBatang) / 2.0F
                    Dim y As Single = area.Bottom - tinggi

                    If nilai > 0D Then
                        g.FillRectangle(kuas, x, y, lebarBatang, tinggi)
                        TextRenderer.DrawText(g, FormatSingkat(nilai), fon,
                            New Rectangle(CInt(x - 24 * skala), CInt(y - 22 * skala), CInt(lebarBatang + 48 * skala), CInt(20 * skala)),
                            Tema.CoklatTua, TextFormatFlags.HorizontalCenter Or TextFormatFlags.Bottom)
                    End If
                    TextRenderer.DrawText(g, dataGrafik(i).Key, fon,
                        New Rectangle(CInt(area.Left + i * slot), area.Bottom + CInt(5 * skala), CInt(slot), CInt(22 * skala)),
                        Tema.TeksRedup, TextFormatFlags.HorizontalCenter Or TextFormatFlags.Top)
                Next
            End Using
        End Using
    End Sub

    ' ===== Klik tombol sidebar =====
    Private Sub btnBeranda_Click(sender As Object, e As EventArgs) Handles btnBeranda.Click
        TampilkanHalaman(Nothing, "Beranda", btnBeranda)
    End Sub

    Private Sub btnTambahPesanan_Click(sender As Object, e As EventArgs) Handles btnTambahPesanan.Click
        TampilkanHalaman(New UcTambahPesanan(), "Tambah Pesanan", btnTambahPesanan)
    End Sub

    Private Sub btnDataPesanan_Click(sender As Object, e As EventArgs) Handles btnDataPesanan.Click
        TampilkanHalaman(New UcDataPesanan(), "Data Pesanan", btnDataPesanan)
    End Sub

    Private Sub btnCustomPesanan_Click(sender As Object, e As EventArgs) Handles btnCustomPesanan.Click
        TampilkanHalaman(New UcCustomPesanan(), "Custom Pesanan", btnCustomPesanan)
    End Sub

    Private Sub btnManajemenProduk_Click(sender As Object, e As EventArgs) Handles btnManajemenProduk.Click
        TampilkanHalaman(New UcManajemenProduk(), "Manajemen Produk", btnManajemenProduk)
    End Sub

    Private Sub btnPengaturan_Click(sender As Object, e As EventArgs) Handles btnPengaturan.Click
        TampilkanHalaman(New UcPengaturan(), "Pengaturan", btnPengaturan)
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        TampilkanHalaman(New UcPembayaran(), "Pembayaran", btnPembayaran)
    End Sub

End Class