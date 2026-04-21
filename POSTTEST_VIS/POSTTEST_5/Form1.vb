Public Class Form1

    Dim selectedId As Integer = -1

    Sub TampilData()
        DataGridView1.DataSource = DataModule.GetAllAnime()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub KosongkanForm()
        txtJudul.Clear()
        txtEpisode.Clear()
        txtStudio.Clear()
        txtRating.Clear()
        For Each ctrl As Control In gbGenre.Controls
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If
        Next
        selectedId = -1
    End Sub

    Private Function AmbilGenre() As String

        Dim hasil As String = ""

        For Each ctrl As Control In gbGenre.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    hasil &= cb.Text & ", "
                End If
            End If
        Next

        Return hasil.TrimEnd(", ".ToCharArray())

    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not ValidasiAnime(txtJudul.Text, AmbilGenre(), txtEpisode.Text, txtStudio.Text, txtRating.Text, pbPhoto.Tag.ToString) Then Exit Sub

        If JudulsudahAda(txtJudul.Text) Then
            MessageBox.Show("Judul sudah ada, silakan gunakan judul lain.", "Validasi Gagal",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanAnime(txtJudul.Text, AmbilGenre(), txtEpisode.Text, txtStudio.Text, txtRating.Text, pbPhoto.Tag.ToString) Then
            MessageBox.Show("Data anime berhasil disimpan.", "Sukses",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        End If

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        If Not ValidasiAnime(txtJudul.Text, AmbilGenre(), txtEpisode.Text, txtStudio.Text, txtRating.Text, pbPhoto.Tag.ToString) Then Exit Sub

        Dim judul As String = txtJudul.Text.Trim()
        Dim genre As String = AmbilGenre()
        Dim episode As Integer
        Dim studio As String = txtStudio.Text.Trim()
        Dim rating As Double

        If selectedId = -1 Then
            MessageBox.Show("Pilih data yang akan diubah terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Integer.TryParse(txtEpisode.Text, episode)
        Double.TryParse(txtRating.Text, rating)

        If UbahAnime(selectedId, judul, genre, episode, studio, rating) Then
            MessageBox.Show("Data anime berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        Else
            MessageBox.Show("Data tidak Ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusAnime(selectedId) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
        TampilData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        If row.IsNewRow Then Exit Sub

        Try
            selectedId = Convert.ToInt32(row.Cells("id").Value)
        Catch
            selectedId = -1
        End Try

        txtJudul.Text = If(row.Cells("judul").Value IsNot Nothing, row.Cells("judul").Value.ToString(), "")
        txtEpisode.Text = If(row.Cells("episode").Value IsNot Nothing, row.Cells("episode").Value.ToString(), "")
        txtStudio.Text = If(row.Cells("studio").Value IsNot Nothing, row.Cells("studio").Value.ToString(), "")
        txtRating.Text = If(row.Cells("rating").Value IsNot Nothing, row.Cells("rating").Value.ToString(), "")

        Dim genreText As String = If(row.Cells("genre").Value IsNot Nothing, row.Cells("genre").Value.ToString(), "")
        Dim genres As New List(Of String)(genreText.Split(New String() {","}, StringSplitOptions.RemoveEmptyEntries))
        For i As Integer = 0 To genres.Count - 1
            genres(i) = genres(i).Trim()
        Next

        For Each ctrl As Control In gbGenre.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                cb.Checked = genres.Contains(cb.Text)
            End If
        Next

    End Sub

    Private Sub txtJudul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJudul.KeyPress

    End Sub

    Private Sub txtJudul_TextChanged(sender As Object, e As EventArgs) Handles txtJudul.TextChanged

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If ofd.ShowDialog = DialogResult.OK Then
            pbPhoto.Image = Image.FromFile(ofd.FileName)
            pbPhoto.Tag = ofd.FileName
        End If

    End Sub
End Class
