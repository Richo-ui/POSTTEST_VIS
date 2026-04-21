Public Class Form2

    Public Sub New(judul As String, genre As String, episode As String,
               studio As String, rating As String,
               status As String, foto As String)

        InitializeComponent()

        lblJudul.Text = judul
        lblGenre.Text = genre
        lblEpisode.Text = episode
        lblStudio.Text = studio
        lblRating.Text = rating
        lblStatus.Text = status
        lblAnime.Text = judul

        If IO.File.Exists(foto) Then
            pbPhoto.Image = Image.FromFile(foto)
        End If

    End Sub

End Class