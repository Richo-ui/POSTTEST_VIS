Imports MySqlConnector
Module DataModule

    Public Function SimpanAnime(judul As String, genre As String, episode As Integer, studio As String, rating As Double, photo As String, statusId As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO anime (judul, genre, episode, studio, rating, photo, status) " &
                                    "VALUES (@judul, @genre, @episode, @studio, @rating, @photo, @status)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@episode", episode)
                    cmd.Parameters.AddWithValue("@studio", studio)
                    cmd.Parameters.AddWithValue("@rating", rating)
                    cmd.Parameters.AddWithValue("@photo", photo)
                    cmd.Parameters.AddWithValue("@status", statusId)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data anime: " & vbCrLf & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllAnime() As DataTable
        Dim dt As New DataTable
        Try
            Dim query As String = "SELECT anime.*, status.status AS status_name,
                                    CASE
                                        WHEN anime.photo IS NULL OR anime.photo = '' THEN 'Tidak Ada'
                                        ELSE 'Ada'
                                    END AS status_photo
                                    FROM anime
                                    LEFT JOIN status ON anime.status = status.id
                                    ORDER BY anime.id DESC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & vbCrLf & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function UbahAnime(id As Integer, judul As String, genre As String, episode As Integer, studio As String, rating As Double, photo As String, statusId As Integer) As Boolean
        Try
            Dim query As String = "UPDATE anime SET judul = @judul,
                                    genre = @genre,
                                    episode = @episode,
                                    studio = @studio,
                                    rating = @rating,
                                    photo = @photo,
                                    status = @status
                                    WHERE id = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@episode", episode)
                    cmd.Parameters.AddWithValue("@studio", studio)
                    cmd.Parameters.AddWithValue("@rating", rating)
                    cmd.Parameters.AddWithValue("@photo", photo)
                    cmd.Parameters.AddWithValue("@status", statusId)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data anime: " & vbCrLf & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusAnime(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM anime WHERE id = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data anime: " & vbCrLf & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function JudulsudahAda(judul As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM anime WHERE LOWER(judul) = LOWER(@judul)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa judul: " & vbCrLf & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetStatus() As DataTable
        Dim dt As New DataTable

        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM status", conn)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
        End Using

        Return dt
    End Function

End Module
