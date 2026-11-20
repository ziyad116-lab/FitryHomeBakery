Public Module IdPesananHelper

    ''' <summary>
    ''' Membuat ID berikutnya dari ID terakhir. Contoh: "PSN-0009" menjadi "PSN-0010".
    ''' Jika idTerakhir kosong atau formatnya tidak cocok, hasilnya "PSN-0001".
    ''' Untuk ID lain (mis. pembayaran) cukup ganti prefix, contoh: BuatIdBerikutnya(idTerakhir, "BYR-").
    ''' </summary>
    Public Function BuatIdBerikutnya(idTerakhir As String, Optional prefix As String = "PSN-") As String
        Dim nomor As Integer = 0
        If Not String.IsNullOrWhiteSpace(idTerakhir) Then
            Dim id As String = idTerakhir.Trim()
            If id.StartsWith(prefix, StringComparison.OrdinalIgnoreCase) Then
                Integer.TryParse(id.Substring(prefix.Length), nomor)
            End If
        End If
        Return prefix & (nomor + 1).ToString("0000")
    End Function

End Module