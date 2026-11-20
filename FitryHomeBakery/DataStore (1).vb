Imports System.Globalization
Imports System.IO

''' <summary>Satu item di keranjang / pesanan.</summary>
Public Class ItemKeranjang
    Public Property Nama As String = ""
    Public Property Harga As Decimal
    Public Property Qty As Integer

    Public ReadOnly Property Subtotal As Decimal
        Get
            Return Harga * Qty
        End Get
    End Property
End Class

''' <summary>
''' Penyimpanan data pesanan yang dipakai bersama oleh semua halaman
''' (Tambah Pesanan, Custom Pesanan, Data Pesanan, Pembayaran, Beranda).
''' Data otomatis disimpan ke file XML di folder AppData dan dimuat lagi saat aplikasi dibuka.
''' Nanti bisa diganti ke MySQL tanpa mengubah halaman-halamannya, cukup isi Muat() dan Simpan().
''' </summary>
Public Module DataStore

    Public ReadOnly DaftarStatus As String() = {"Menunggu", "Diproses", "Siap Diambil", "Selesai", "Dibatalkan"}

    Public ReadOnly Data As New DataSet("FitryHomebakery")
    Public ReadOnly Pesanan As New DataTable("Pesanan")
    Public ReadOnly ItemPesanan As New DataTable("ItemPesanan")
    Public ReadOnly Pembayaran As New DataTable("Pembayaran")

    Private ReadOnly lokasiFile As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FitryHomebakery", "data.xml")

    Sub New()
        With Pesanan.Columns
            .Add("NomorPesanan", GetType(String))
            .Add("NamaPelanggan", GetType(String))
            .Add("NoWA", GetType(String))
            .Add("Jenis", GetType(String))            ' Reguler / Custom
            .Add("Produk", GetType(String))           ' ringkasan produk
            .Add("Jumlah", GetType(Integer))          ' total qty
            .Add("TotalTagihan", GetType(Decimal))
            .Add("TanggalPesan", GetType(Date))
            .Add("TanggalAmbil", GetType(Date))
            .Add("JamAmbil", GetType(String))
            .Add("Status", GetType(String))
            .Add("Catatan", GetType(String))
            .Add("Referensi", GetType(String))        ' lokasi foto referensi (custom)
        End With
        Pesanan.Columns("TanggalPesan").DateTimeMode = DataSetDateTime.Unspecified
        Pesanan.Columns("TanggalAmbil").DateTimeMode = DataSetDateTime.Unspecified

        With ItemPesanan.Columns
            .Add("NomorPesanan", GetType(String))
            .Add("NamaProduk", GetType(String))
            .Add("Harga", GetType(Decimal))
            .Add("Qty", GetType(Integer))
        End With

        With Pembayaran.Columns
            .Add("IDPembayaran", GetType(String))
            .Add("NomorPesanan", GetType(String))
            .Add("Jumlah", GetType(Decimal))
            .Add("Metode", GetType(String))
            .Add("Tanggal", GetType(Date))
        End With
        Pembayaran.Columns("Tanggal").DateTimeMode = DataSetDateTime.Unspecified

        Data.Tables.Add(Pesanan)
        Data.Tables.Add(ItemPesanan)
        Data.Tables.Add(Pembayaran)

        Muat()
    End Sub

    ' ============================================================
    '  SIMPAN / MUAT
    ' ============================================================
    Public Sub Simpan()
        Try
            Directory.CreateDirectory(Path.GetDirectoryName(lokasiFile))
            Data.WriteXml(lokasiFile, XmlWriteMode.IgnoreSchema)
        Catch ex As Exception
            MessageBox.Show("Data gagal disimpan ke file: " & ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Muat()
        Try
            If File.Exists(lokasiFile) Then Data.ReadXml(lokasiFile, XmlReadMode.IgnoreSchema)
        Catch
            ' file rusak: mulai dari data kosong
            Pesanan.Clear()
            ItemPesanan.Clear()
            Pembayaran.Clear()
        End Try
    End Sub

    ' ============================================================
    '  PESANAN
    ' ============================================================
    Public Function BuatNomorPesanan() As String
        Dim terakhir As String = ""
        For Each r As DataRow In Pesanan.Rows
            Dim n As String = r("NomorPesanan").ToString()
            If String.Compare(n, terakhir, StringComparison.OrdinalIgnoreCase) > 0 Then terakhir = n
        Next
        Return BuatIdBerikutnya(terakhir)
    End Function

    Public Function BelumSelesai(status As String) As Boolean
        Return status <> "Selesai" AndAlso status <> "Dibatalkan"
    End Function

    Public Function RingkasProduk(items As List(Of ItemKeranjang)) As String
        Return String.Join(", ", items.Select(Function(i) i.Nama & " x" & i.Qty.ToString()))
    End Function

    ''' <summary>Simpan pesanan baru. dp > 0 berarti langsung dicatat sebagai pembayaran.</summary>
    Public Function SimpanPesanan(nama As String, noWa As String, jenis As String, items As List(Of ItemKeranjang),
                                  tglPesan As Date, tglAmbil As Date, jamAmbil As String,
                                  catatan As String, referensi As String,
                                  dp As Decimal, metode As String) As String
        Dim nomor As String = BuatNomorPesanan()
        Dim total As Decimal = items.Sum(Function(i) i.Subtotal)

        Dim baris As DataRow = Pesanan.NewRow()
        baris("NomorPesanan") = nomor
        baris("NamaPelanggan") = nama
        baris("NoWA") = noWa
        baris("Jenis") = jenis
        baris("Produk") = RingkasProduk(items)
        baris("Jumlah") = items.Sum(Function(i) i.Qty)
        baris("TotalTagihan") = total
        baris("TanggalPesan") = tglPesan.Date
        baris("TanggalAmbil") = tglAmbil.Date
        baris("JamAmbil") = jamAmbil
        baris("Status") = "Menunggu"
        baris("Catatan") = catatan
        baris("Referensi") = referensi
        Pesanan.Rows.Add(baris)

        For Each i In items
            ItemPesanan.Rows.Add(nomor, i.Nama, i.Harga, i.Qty)
        Next

        If dp > 0D Then CatatPembayaran(nomor, dp, metode, tglPesan, False)
        Simpan()
        Return nomor
    End Function

    Public Function AmbilPesanan(nomor As String) As DataRow
        For Each r As DataRow In Pesanan.Rows
            If String.Equals(r("NomorPesanan").ToString(), nomor, StringComparison.OrdinalIgnoreCase) Then Return r
        Next
        Return Nothing
    End Function

    Public Function AmbilItem(nomor As String) As List(Of ItemKeranjang)
        Dim hasil As New List(Of ItemKeranjang)
        For Each r As DataRow In ItemPesanan.Rows
            If r("NomorPesanan").ToString() = nomor Then
                hasil.Add(New ItemKeranjang With {
                    .Nama = r("NamaProduk").ToString(),
                    .Harga = CDec(r("Harga")),
                    .Qty = CInt(r("Qty"))
                })
            End If
        Next
        Return hasil
    End Function

    ''' <summary>Ganti seluruh item sebuah pesanan (dipakai saat jumlah diubah di Detail Pesanan).</summary>
    Public Sub UbahItem(nomor As String, items As List(Of ItemKeranjang))
        For i As Integer = ItemPesanan.Rows.Count - 1 To 0 Step -1
            If ItemPesanan.Rows(i)("NomorPesanan").ToString() = nomor Then ItemPesanan.Rows.RemoveAt(i)
        Next
        For Each it In items
            ItemPesanan.Rows.Add(nomor, it.Nama, it.Harga, it.Qty)
        Next
        Dim baris As DataRow = AmbilPesanan(nomor)
        If baris IsNot Nothing Then
            baris("Produk") = RingkasProduk(items)
            baris("Jumlah") = items.Sum(Function(x) x.Qty)
            baris("TotalTagihan") = items.Sum(Function(x) x.Subtotal)
        End If
        Simpan()
    End Sub

    Public Sub UbahStatus(nomor As String, statusBaru As String)
        Dim baris As DataRow = AmbilPesanan(nomor)
        If baris Is Nothing Then Return
        baris("Status") = statusBaru
        Simpan()
    End Sub

    ' ============================================================
    '  PEMBAYARAN
    ' ============================================================
    Public Function HitungDibayar(nomor As String) As Decimal
        Dim total As Decimal = 0D
        For Each r As DataRow In Pembayaran.Rows
            If r("NomorPesanan").ToString() = nomor Then total += CDec(r("Jumlah"))
        Next
        Return total
    End Function

    Public Function SisaTagihan(nomor As String) As Decimal
        Dim baris As DataRow = AmbilPesanan(nomor)
        If baris Is Nothing Then Return 0D
        Return Math.Max(CDec(baris("TotalTagihan")) - HitungDibayar(nomor), 0D)
    End Function

    Public Function StatusPembayaran(nomor As String) As String
        Return If(SisaTagihan(nomor) = 0D, "Lunas", "Belum Lunas")
    End Function

    Public Sub CatatPembayaran(nomor As String, jumlah As Decimal, metode As String, tanggal As Date, Optional langsungSimpan As Boolean = True)
        Dim id As String = "PAY" & (Pembayaran.Rows.Count + 1).ToString("000")
        Pembayaran.Rows.Add(id, nomor, jumlah, metode, tanggal.Date)
        If langsungSimpan Then Simpan()
    End Sub

End Module

''' <summary>Dialog kecil yang dipakai beberapa halaman.</summary>
Public Module DialogBantu

    ''' <summary>
    ''' Meminta nominal rupiah lewat kotak input. Mengembalikan Nothing jika dibatalkan.
    ''' bolehKosong = True: input kosong dianggap 0.
    ''' </summary>
    Public Function TanyaNominal(pertanyaan As String, judul As String, maksimal As Decimal, bolehKosong As Boolean) As Decimal?
        Do
            Dim teks As String = Microsoft.VisualBasic.Interaction.InputBox(pertanyaan, judul, "")
            If teks Is Nothing OrElse (teks = "" AndAlso Not bolehKosong) Then Return Nothing
            If teks.Trim() = "" Then Return 0D

            Dim nilai As Decimal
            If Decimal.TryParse(teks.Trim(), NumberStyles.Number, CultureInfo.GetCultureInfo("id-ID"), nilai) AndAlso nilai >= 0D AndAlso nilai <= maksimal Then
                Return nilai
            End If
            MessageBox.Show("Masukkan angka antara 0 dan " & Tema.Rupiah(maksimal) & ".", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Loop
    End Function

End Module
