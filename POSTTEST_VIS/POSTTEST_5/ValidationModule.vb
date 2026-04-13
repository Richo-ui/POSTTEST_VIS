Module ValidationModule

    Public Function TidakKosong(teks As String) As Boolean
        Return teks.Trim() <> ""
    End Function

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngkaDesimal(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
        If e.KeyChar = "."c AndAlso CType(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiCheckBox(ep As ErrorProvider, cb As CheckBox, pesan As String) As Boolean
        If Not cb.Checked Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiAnime(judul As String, genre As String, episode As String, studio As String, rating As String) As Boolean
        If String.IsNullOrWhiteSpace(judul) Then
            MessageBox.Show("Judul tidak boleh kosong.", "Validasi Gagal",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(genre) Then
            MessageBox.Show("Genre tidak boleh kosong.", "Validasi Gagal",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Dim episodeNumber As Integer
        If Not Integer.TryParse(episode, episodeNumber) OrElse episodeNumber < 0 Then
            MessageBox.Show("Episode harus berupa angka positif.", "Validasi Gagal",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(studio) Then
            MessageBox.Show("Studio tidak boleh kosong.", "Validasi Gagal",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Dim ratingValue As Double
        If Not Double.TryParse(rating, ratingValue) OrElse ratingValue < 0 OrElse ratingValue > 10 Then
            MessageBox.Show("Rating harus berupa angka antara 0 dan 10.", "Validasi Gagal",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

End Module
