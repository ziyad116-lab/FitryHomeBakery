Imports System.Drawing
Imports System.Globalization

''' <summary>
''' Palet warna dan format yang dipakai seluruh aplikasi Fitry Homebakery.
''' Pakai ini di kode (mis. saat menandai menu aktif atau mewarnai status) supaya
''' warnanya selalu sama dengan yang ada di Designer.
''' </summary>
Public Module Tema
    Public ReadOnly CoklatTua As Color = Color.FromArgb(73, 51, 43)     ' header, sidebar, judul, angka
    Public ReadOnly CoklatSedang As Color = Color.FromArgb(121, 85, 72) ' tombol utama, menu aktif, label field
    Public ReadOnly CoklatAksen As Color = Color.FromArgb(184, 111, 82) ' aksen grafik, harga
    Public ReadOnly CoklatHover As Color = Color.FromArgb(96, 68, 58)   ' hover menu sidebar
    Public ReadOnly Pasir As Color = Color.FromArgb(233, 222, 211)      ' tombol sekunder, garis tabel, baris terpilih
    Public ReadOnly Krem As Color = Color.FromArgb(248, 244, 238)       ' latar halaman, baris selang-seling
    Public ReadOnly TeksRedup As Color = Color.FromArgb(117, 107, 101)  ' deskripsi / teks pendukung
    Public ReadOnly TeksBannerTerang As Color = Color.FromArgb(238, 228, 220)
    Public ReadOnly Bahaya As Color = Color.FromArgb(176, 58, 46)       ' Hapus / Batal
    Public ReadOnly Peringatan As Color = Color.FromArgb(180, 110, 0)   ' Belum lunas / sisa tagihan
    Public ReadOnly Sukses As Color = Color.FromArgb(6, 95, 70)         ' Lunas / total diterima / Tersedia
    Public ReadOnly LatarSukses As Color = Color.FromArgb(209, 250, 229)    ' latar badge Lunas / Tersedia
    Public ReadOnly LatarPeringatan As Color = Color.FromArgb(255, 228, 214) ' latar badge Belum Lunas
    Public ReadOnly LatarBahaya As Color = Color.FromArgb(255, 224, 224)     ' latar badge Tidak Tersedia

    ''' <summary>Format rupiah seragam di semua halaman, contoh: Rp1.250.000</summary>
    Public Function Rupiah(nilai As Decimal) As String
        Return "Rp" & nilai.ToString("N0", New CultureInfo("id-ID"))
    End Function
End Module
