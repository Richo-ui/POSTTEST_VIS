Public Class Form1

    'ini Function untuk cek teks hanya angka
    Private Function bukanAngka(ByVal teks As String) As Boolean

        For Each karakter As Char In teks
            If Not Char.IsDigit(karakter) Then
                Return False
            End If
        Next

        Return True

    End Function

    'ini Function untuk cek teks mengandung angka
    Private Function adaAngka(ByVal teks As String) As Boolean

        For Each karakter As Char In teks
            If Char.IsDigit(karakter) Then
                Return True
            End If
        Next

        Return False

    End Function

    'Ini Function untuk cari buku
    Private Function cariBuku(ByVal judul As String) As Integer

        For i As Integer = 0 To jumlahBuku - 1
            Dim data As String() = daftarBuku(i).Split(";"c)
            If data(0) = judul Then
                Return i
            End If
        Next

        Return -1

    End Function

    'Ini procedure untuk hapus buku (pakai ByRef)
    Private Sub hapusBuku(ByRef index As Integer)

        For i As Integer = index To jumlahBuku - 2
            daftarBuku(i) = daftarBuku(i + 1)
        Next

        jumlahBuku -= 1

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudul1.Text = "" Then
            MessageBox.Show("Judul tidak boleh kosong!")
            Exit Sub
        End If

        If txtPenulis.Text = "" Then
            MessageBox.Show("Penulis tidak boleh kosong!")
            Exit Sub
        ElseIf adaAngka(txtPenulis.Text) Then
            MessageBox.Show("Nama Penulis tidak boleh ada angka!")
            Exit Sub
        End If

        If txtGenre.Text = "" Then
            MessageBox.Show("Genre tidak boleh kosong!")
            Exit Sub
        ElseIf adaAngka(txtGenre.Text) Then
            MessageBox.Show("Genre tidak boleh ada angka!")
            Exit Sub
        End If

        If txtTahun.Text = "" Then
            MessageBox.Show("Tahun Terbit tidak boleh kosong!")
            Exit Sub
        ElseIf txtTahun.Text <= 0 Then
            MessageBox.Show("Tahun Terbit tidak boleh negatif atau nol!")
            Exit Sub
        ElseIf Not bukanAngka(txtTahun.Text) Then
            MessageBox.Show("Tahun Terbit harus berupa angka!")
            Exit Sub
        End If

        daftarBuku(jumlahBuku) = txtJudul1.Text & ";" & txtPenulis.Text & ";" & txtGenre.Text & ";" & txtTahun.Text
        jumlahBuku += 1

        dgvBuku.Rows.Add(txtJudul1.Text, txtPenulis.Text, txtGenre.Text, txtTahun.Text)

        MessageBox.Show("Buku berhasil ditambahkan!")

        txtJudul1.Clear()
        txtPenulis.Clear()
        txtGenre.Clear()
        txtTahun.Clear()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim index As Integer = cariBuku(txtJudul2.Text)

        If txtJudul2.Text = "" Then
            MessageBox.Show("Judul tidak boleh kosong!")
            Exit Sub
        End If

        If index <> -1 Then

            hapusBuku(index)

            dgvBuku.Rows.RemoveAt(index)

            MessageBox.Show("Buku berhasil dihapus!")

        Else
            MessageBox.Show("Buku tidak ditemukan!")
        End If

        txtJudul2.Clear()

    End Sub
End Class
