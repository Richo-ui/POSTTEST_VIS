Imports MySqlConnector
Module DataModule

    Public Function SimpanAnime(judul As String, genre As String, episode As Integer, studio As String, rating As Double) As Boolean
        Try
            Dim query As String = "INSERT INTO anime (judul, genre, episode, studio,
                                    rating) " &
                                    "VALUES (@judul, @genre, @episode, @studio, @rating)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@episode", episode)
                    cmd.Parameters.AddWithValue("@studio", studio)
                    cmd.Parameters.AddWithValue("@rating", rating)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data anime: " & ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllAnime() As DataTable
        Dim dt As New DataTable
        Try
            Dim query As String = "SELECT * FROM anime"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function UbahAnime(id As Integer, judul As String, genre As String, episode As Integer, studio As String, rating As Double) As Boolean
        Try
            Dim query As String = "UPDATE anime SET judul = @judul,
                                    genre = @genre, " &
                                    "episode= @episode, studio= @studio,
                                    rating = @rating " &
                                    "WHERE id = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@episode", episode)
                    cmd.Parameters.AddWithValue("@studio", studio)
                    cmd.Parameters.AddWithValue("@rating", rating)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data anime: " & ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Gagal menghapus data anime: " & ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function JudulsudahAda(judul As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM anime WHERE judul = @judul"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa judul: " & ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module
