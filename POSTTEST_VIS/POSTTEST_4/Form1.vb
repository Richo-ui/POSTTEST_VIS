Imports System.IO

Public Class Form1
    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        'btnSimpan.PerformClick()
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"

        If sfd.ShowDialog = DialogResult.OK Then
            Dim data As String =
                txtNama.Text & ";" &
                txtID.Text & ";" &
                cmbDivisi.Text & ";" &
                mtbNoHp.Text & ";" &
                txtEmail.Text

            IO.File.WriteAllText(sfd.FileName, data)
            MessageBox.Show("Data disimpan")
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)

        If data Is Nothing Then Exit Sub

        'KosongkanForm()
        'IsiDataKeForm(data)
        'PerbaruiRingkasan()
        'TabControl1.SelectedTab = tcRingkasan

        MessageBox.Show(
            "File berhasil dibuka.",
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
    '    If Not CekData(txtNama, txtID, cmbDivisi, rbLaki, rbPerempuan, mtbNoHp, txtEmail,
    '                   txtAlamat, pbPfp, cbGaming, cbMembaca, cbMenulis, cbOlahraga, cbBelanja,
    '                   cbBermusik, cbMenggambar, cbMemasak, rbLeader, rbViceLeader, rbAdmin, rbIntel,
    '                   rbMember) Then
    '        MessageBox.Show(
    '            "Masih ada input yang belum valid.",
    '            "Peringatan",
    '            MessageBoxButtons.OK,
    '            MessageBoxIcon.Warning
    '        )
    '        Exit Sub
    '    End If

    '    Dim hasil As DialogResult
    '    hasil = MessageBox.Show(
    '        "Apakah data ingin disimpan?",
    '        "Konfirmasi Simpan",
    '        MessageBoxButtons.YesNoCancel,
    '        MessageBoxIcon.Question
    '    )

    '    If hasil = DialogResult.Yes Then
    '        Dim isi As String = BuatIsiFile(
    '            txtNama.Text,
    '            mtxtNoHp.Text,
    '            txtAlamat.Text
    '        )

    '        If SimpanDataKeFile(SaveFileDialog1, isi, "data_jamaah.txt") Then
    '            PerbaruiRingkasan()
    '            TabControl1.SelectedTab = tcRingkasan

    '            MessageBox.Show(
    '                "Data berhasil disimpan.",
    '                "Informasi",
    '                MessageBoxButtons.OK,
    '                MessageBoxIcon.Information
    '            )
    '        End If

    '    ElseIf hasil = DialogResult.No Then
    '        MessageBox.Show(
    '            "Data tidak jadi disimpan.",
    '            "Informasi",
    '            MessageBoxButtons.OK,
    '            MessageBoxIcon.Information
    '        )

    '    ElseIf hasil = DialogResult.Cancel Then
    '        MessageBox.Show(
    '            "Proses dibatalkan.",
    '            "Informasi",
    '            MessageBoxButtons.OK,
    '            MessageBoxIcon.Exclamation
    '        )
    '    End If
    'End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If Not CekData(txtNama, txtID, cmbDivisi, rbLaki, rbPerempuan, mtbNoHp, txtEmail,
                       txtAlamat, pbPfp, cbGaming, cbMembaca, cbMenulis, cbOlahraga, cbBelanja,
                       cbBermusik, cbMenggambar, cbMemasak, rbLeader, rbViceLeader, rbAdmin, rbIntel,
                       rbMember) Then
            Dim NamaFile As String = txtNama.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                File.Copy(openFileDialog.FileName, destinationPath, True)
                DataModule.Foto = destinationPath
                pbPfp.Image = Image.FromFile(destinationPath)
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekData(txtNama, txtID, cmbDivisi, rbLaki, rbPerempuan, mtbNoHp, txtEmail,
                       txtAlamat, pbPfp, cbGaming, cbMembaca, cbMenulis, cbOlahraga, cbBelanja,
                       cbBermusik, cbMenggambar, cbMemasak, rbLeader, rbViceLeader, rbAdmin, rbIntel,
                       rbMember) Then
            Dim grupGender = {rbLaki, rbPerempuan}
            Dim grupHobi = {cbGaming, cbMembaca, cbMenulis, cbOlahraga, cbBelanja, cbBermusik, cbMenggambar, cbMemasak}
            Dim grupJabatan = {rbLeader, rbViceLeader, rbAdmin, rbIntel, rbMember}

            Dim gender_selected As String = GetSelectedRadioButton(grupGender)
            Dim hobi_selected As String = GetSelectedCheckBox(grupHobi)
            Dim jabatan_selected As String = GetSelectedRadioButton(grupJabatan)

            DataModule.Nama = txtNama.Text
            DataModule.ID = txtID.Text
            DataModule.Tglahir = dtpLahir.Value.ToShortDateString()
            DataModule.Gender = gender_selected
            DataModule.Divisi = cmbDivisi.Text
            DataModule.Telepon = mtbNoHp.Text
            DataModule.Email = txtEmail.Text
            DataModule.Alamat = txtAlamat.Text
            DataModule.Hobi = hobi_selected
            DataModule.Jabatan = jabatan_selected
            Form2.Show()

        End If
    End Sub

End Class
