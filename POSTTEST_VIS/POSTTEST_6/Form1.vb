Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Public Class Form1

    Dim selectedId As Integer = -1

    Sub TampilData()
        DataGridView1.DataSource = DataModule.GetAllAnime()
        DataGridView1.Columns("photo").Visible = False
        If DataGridView1.Columns.Contains("status") Then
            DataGridView1.Columns("status").Visible = False
        End If
        If DataGridView1.Columns.Contains("status_name") Then
            DataGridView1.Columns("status_name").HeaderText = "Status"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        LoadStatus()
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

        Return hasil.Trim().TrimEnd(","c)

    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Dim statusId As Integer = 0
        If cmbStatus.SelectedValue IsNot Nothing Then
            Integer.TryParse(cmbStatus.SelectedValue.ToString(), statusId)
        End If

        Dim photo As String = If(pbPhoto.Tag IsNot Nothing, pbPhoto.Tag.ToString(), "")

        If Not ValidasiAnime(txtJudul.Text, AmbilGenre(), txtEpisode.Text, txtStudio.Text, txtRating.Text, photo, statusId) Then Exit Sub

        If JudulsudahAda(txtJudul.Text) Then
            MessageBox.Show("Judul sudah ada, silakan gunakan judul lain.", "Validasi Gagal",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim episodeNum As Integer
        Dim ratingVal As Double
        If Not Integer.TryParse(txtEpisode.Text, episodeNum) Then
            MessageBox.Show("Episode harus angka!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not Double.TryParse(txtRating.Text, ratingVal) Then
            MessageBox.Show("Rating harus angka!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanAnime(txtJudul.Text, AmbilGenre(), episodeNum, txtStudio.Text, ratingVal, photo, statusId) Then
            MessageBox.Show("Data anime berhasil disimpan.", "Sukses",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        End If

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        Dim statusId As Integer = CInt(cmbStatus.SelectedValue)

        If Not ValidasiAnime(txtJudul.Text, AmbilGenre(), txtEpisode.Text, txtStudio.Text, txtRating.Text, pbPhoto.Tag.ToString, statusId) Then Exit Sub

        Dim judul As String = txtJudul.Text.Trim()
        Dim genre As String = AmbilGenre()
        Dim episode As Integer
        Dim studio As String = txtStudio.Text.Trim()
        Dim rating As Double
        Dim photo As String = pbPhoto.Tag.ToString()


        If selectedId = -1 Then
            MessageBox.Show("Pilih data yang akan diubah terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not Integer.TryParse(txtEpisode.Text, episode) Then
            MessageBox.Show("Episode harus angka!")
            Exit Sub
        End If
        If Not Double.TryParse(txtRating.Text, rating) Then
            MessageBox.Show("Rating harus angka!")
            Exit Sub
        End If

        If UbahAnime(selectedId, judul, genre, episode, studio, rating, photo, statusId) Then
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
        Dim fotoPath As String = If(row.Cells("photo").Value IsNot Nothing, row.Cells("photo").Value.ToString(), "")
        If row.Cells("status_name") IsNot Nothing AndAlso row.Cells("status_name").Value IsNot Nothing Then
            cmbStatus.Text = row.Cells("status_name").Value.ToString()
        Else
            cmbStatus.Text = If(row.Cells("status").Value IsNot Nothing, row.Cells("status").Value.ToString(), "")
        End If

        If IO.File.Exists(fotoPath) Then
            pbPhoto.Image = Image.FromFile(fotoPath)
            pbPhoto.Tag = fotoPath
        Else
            pbPhoto.Image = Nothing
            pbPhoto.Tag = Nothing
        End If

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

    Private Sub txtEpisode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEpisode.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtRating_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRating.KeyPress
        HanyaAngkaDesimal(sender, e)
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

    Public Sub LoadStatus()
        Dim dt As DataTable = GetStatus()

        cmbStatus.DataSource = dt
        cmbStatus.DisplayMember = "status"
        cmbStatus.ValueMember = "id"
    End Sub

    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click

        If selectedId = -1 Then
            MessageBox.Show("Pilih data terlebih dahulu!", "Informasi",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        Dim judul As String = row.Cells("judul").Value.ToString()
        Dim genre As String = row.Cells("genre").Value.ToString()
        Dim episode As String = row.Cells("episode").Value.ToString()
        Dim studio As String = row.Cells("studio").Value.ToString()
        Dim rating As String = row.Cells("rating").Value.ToString()
        Dim status As String = If(row.Cells("status_name") IsNot Nothing AndAlso row.Cells("status_name").Value IsNot Nothing, row.Cells("status_name").Value.ToString(), If(row.Cells("status") IsNot Nothing AndAlso row.Cells("status").Value IsNot Nothing, row.Cells("status").Value.ToString(), ""))

        Dim foto As String = ""
        If row.Cells("photo").Value IsNot Nothing Then
            foto = row.Cells("photo").Value.ToString()
        End If

        Dim formDetail As New Form2(judul, genre, episode, studio, rating, status, foto)
        formDetail.ShowDialog()

    End Sub
End Class
