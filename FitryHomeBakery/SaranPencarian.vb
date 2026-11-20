''' <summary>
''' Saran otomatis untuk kotak pencarian: saat mengetik, muncul daftar yang MENGANDUNG teks tersebut
''' (mis. ketik "br" -> "Brownies", "Fudgy Brownies", "Abrar"). Panah atas/bawah + Enter atau klik untuk memilih.
''' Pemakaian:  saran = New SaranPencarian(txtCari, AddressOf DaftarSaran)
''' dengan DaftarSaran() As IEnumerable(Of String) yang mengembalikan semua teks yang boleh disarankan.
''' </summary>
Public Class SaranPencarian

    Private Class DaftarSaranBox
        Inherits ListBox

        Public Sub New()
            SetStyle(ControlStyles.Selectable, False)   ' tidak merebut fokus dari kotak teks
            DrawMode = DrawMode.OwnerDrawFixed
            BorderStyle = BorderStyle.FixedSingle
            IntegralHeight = False
            Font = New Font("Segoe UI", 10.0F)
            Visible = False
        End Sub

        Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
            If e.Index < 0 Then Return
            Dim terpilih As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected
            Using kuas As New SolidBrush(If(terpilih, Tema.Pasir, Color.White))
                e.Graphics.FillRectangle(kuas, e.Bounds)
            End Using
            Dim area As New Rectangle(e.Bounds.X + 8, e.Bounds.Y, e.Bounds.Width - 12, e.Bounds.Height)
            TextRenderer.DrawText(e.Graphics, Items(e.Index).ToString(), Font, area, Tema.CoklatTua,
                                  TextFormatFlags.VerticalCenter Or TextFormatFlags.Left Or TextFormatFlags.EndEllipsis)
        End Sub

        Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            Dim i As Integer = IndexFromPoint(e.Location)
            If i >= 0 AndAlso i <> SelectedIndex Then SelectedIndex = i
        End Sub
    End Class

    Private Const MaksSaran As Integer = 8

    Private ReadOnly kotak As TextBox
    Private ReadOnly sumber As Func(Of IEnumerable(Of String))
    Private ReadOnly daftar As New DaftarSaranBox()
    Private sedangMengisi As Boolean = False

    Public Sub New(kotakTeks As TextBox, sumberSaran As Func(Of IEnumerable(Of String)))
        kotak = kotakTeks
        sumber = sumberSaran
        AddHandler kotak.TextChanged, AddressOf SaatTeksBerubah
        AddHandler kotak.KeyDown, AddressOf SaatTombol
        AddHandler kotak.Leave, AddressOf SaatKeluar
        AddHandler kotak.Disposed, AddressOf SaatKotakDibuang
        AddHandler daftar.MouseClick, AddressOf SaatKlik
    End Sub

    Public Sub Sembunyikan()
        daftar.Visible = False
    End Sub

    Private Sub SaatKeluar(sender As Object, e As EventArgs)
        Sembunyikan()
    End Sub

    Private Sub SaatKotakDibuang(sender As Object, e As EventArgs)
        If daftar.Parent IsNot Nothing Then daftar.Parent.Controls.Remove(daftar)
        daftar.Dispose()
    End Sub

    Private Sub SaatTeksBerubah(sender As Object, e As EventArgs)
        If sedangMengisi Then Return
        Dim kata As String = kotak.Text.Trim()
        If kata = "" OrElse Not kotak.Focused Then
            Sembunyikan()
            Return
        End If

        Dim hasil As List(Of String) = sumber().
            Where(Function(s) Not String.IsNullOrWhiteSpace(s)).
            Distinct(StringComparer.OrdinalIgnoreCase).
            Where(Function(s) s.IndexOf(kata, StringComparison.OrdinalIgnoreCase) >= 0 AndAlso
                              Not String.Equals(s, kata, StringComparison.OrdinalIgnoreCase)).
            OrderBy(Function(s) If(s.StartsWith(kata, StringComparison.OrdinalIgnoreCase), 0, 1)).
            ThenBy(Function(s) s).
            Take(MaksSaran).
            ToList()

        If hasil.Count = 0 Then
            Sembunyikan()
        Else
            Tampilkan(hasil)
        End If
    End Sub

    Private Sub Tampilkan(hasil As List(Of String))
        Dim form As Form = kotak.FindForm()
        If form Is Nothing OrElse kotak.Parent Is Nothing Then Return

        If daftar.Parent IsNot form Then
            If daftar.Parent IsNot Nothing Then daftar.Parent.Controls.Remove(daftar)
            form.Controls.Add(daftar)
        End If

        daftar.BeginUpdate()
        daftar.Items.Clear()
        For Each h As String In hasil
            daftar.Items.Add(h)
        Next
        daftar.EndUpdate()
        daftar.SelectedIndex = -1

        daftar.ItemHeight = CInt(28 * kotak.DeviceDpi / 96.0)
        Dim titik As Point = form.PointToClient(kotak.Parent.PointToScreen(New Point(kotak.Left, kotak.Bottom)))
        daftar.SetBounds(titik.X, titik.Y + 1, Math.Max(kotak.Width, CInt(260 * kotak.DeviceDpi / 96.0)),
                         daftar.ItemHeight * hasil.Count + 4)
        daftar.Visible = True
        daftar.BringToFront()
    End Sub

    Private Sub SaatTombol(sender As Object, e As KeyEventArgs)
        If Not daftar.Visible Then Return
        Select Case e.KeyCode
            Case Keys.Down
                daftar.SelectedIndex = Math.Min(daftar.Items.Count - 1, daftar.SelectedIndex + 1)
                e.Handled = True
                e.SuppressKeyPress = True
            Case Keys.Up
                If daftar.SelectedIndex > 0 Then daftar.SelectedIndex -= 1
                e.Handled = True
                e.SuppressKeyPress = True
            Case Keys.Enter
                If daftar.SelectedIndex >= 0 Then
                    Pilih(daftar.SelectedItem.ToString())
                    e.Handled = True
                    e.SuppressKeyPress = True
                Else
                    Sembunyikan()
                End If
            Case Keys.Escape
                Sembunyikan()
                e.Handled = True
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub SaatKlik(sender As Object, e As MouseEventArgs)
        Dim i As Integer = daftar.IndexFromPoint(e.Location)
        If i >= 0 Then Pilih(daftar.Items(i).ToString())
    End Sub

    Private Sub Pilih(teks As String)
        sedangMengisi = True
        kotak.Text = teks
        kotak.SelectionStart = kotak.Text.Length
        sedangMengisi = False
        Sembunyikan()
        kotak.Focus()
    End Sub

End Class
