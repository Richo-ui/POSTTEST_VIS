Imports System.Diagnostics.Eventing

Module Validasi
    Dim grupHobi() As CheckBox
    Dim grupGender() As RadioButton
    Dim grupJabatan() As RadioButton
    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(txt As TextBox, pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If

        Return True
    End Function

    Public Function validasiComboBox(grupCombo() As ComboBox, pesan As String) As Boolean
        For Each combo As ComboBox In grupCombo
            If combo Is Nothing Then Continue For

            If combo.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(combo.Text) Then
                MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                combo.Focus()
                Return False
            End If
        Next

        Return True
    End Function

    Public Function ValidasiMaskedTextBox(mtb As MaskedTextBox, pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(mtb.Text) Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtb.Focus()
            Return False
        End If

        Return True
    End Function

    Public Function ValidasiCheckBox(grupCheckBox() As CheckBox, pesan As String) As Boolean
        For Each cb As CheckBox In grupCheckBox
            If cb.Checked Then
                Return True
            End If
        Next
        MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function

    Public Function ValidasiRadioButton(grupRadio() As RadioButton, pesan As String) As Boolean
        For Each rb As RadioButton In grupRadio
            If rb.Checked Then
                Return True
            End If
        Next
        MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function

    Public Function ValidasiPictureBox(pic As PictureBox, pesan As String) As Boolean
        If pic.Image Is Nothing Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Public Function CekData(
        txtNama As TextBox,
        txtID As TextBox,
        cmbDivisi As ComboBox,
        rbLaki As RadioButton,
        rbPerempuan As RadioButton,
        mtbNoHp As MaskedTextBox,
        txtEmail As TextBox,
        txtAlamat As TextBox,
        pbPfp As PictureBox,
        cbGaming As CheckBox,
        cbMembaca As CheckBox,
        cbMenulis As CheckBox,
        cbOlahraga As CheckBox,
        cbBelanja As CheckBox,
        cbBermusik As CheckBox,
        cbMenggambar As CheckBox,
        cbMemasak As CheckBox,
        rbLeader As RadioButton,
        rbViceLeader As RadioButton,
        rbAdmin As RadioButton,
        rbIntel As RadioButton,
        rbMember As RadioButton
    ) As Boolean
        grupGender = {rbLaki, rbPerempuan}
        grupHobi = {cbGaming, cbMembaca, cbMenulis, cbOlahraga, cbBelanja, cbBermusik, cbMenggambar, cbMemasak}
        grupJabatan = {rbLeader, rbViceLeader, rbAdmin, rbIntel, rbMember}

        Dim namaValid As Boolean = ValidasiTextBox(txtNama, "Nama Anggota di Tab 'Data Utama' Tidak Boleh Kosong")
        Dim IdValid As Boolean = ValidasiTextBox(txtID, "ID Anggota di Tab 'Data Utama' Tidak Boleh Kosong")
        Dim genderValid As Boolean = ValidasiRadioButton(grupGender, "Pilih Jenis Kelamin Anda di Tab 'Data Utama', Tidak boleh Kosong")
        Dim divisiValid As Boolean = validasiComboBox({cmbDivisi}, "Pilih Divisi Anda di Tab 'Data Utama', Tidak boleh Kosong")
        Dim TeleponValid As Boolean = ValidasiMaskedTextBox(mtbNoHp, "Nomor Telepon di Tab 'Kontak & Info' Tidak Boleh Kosong")
        Dim emailValid As Boolean = ValidasiTextBox(txtEmail, "Email di Tab 'Kontak & Info' Tidak Boleh Kosong")
        Dim alamatValid As Boolean = ValidasiTextBox(txtAlamat, "Alamat di Tab 'Kontak & Info' Tidak Boleh Kosong")
        Dim pfpValid As Boolean = ValidasiPictureBox(pbPfp, "Pilih Foto Profil Anda di Tab 'Profil & Aktivitas', Tidak boleh Kosong")
        Dim hobiValid As Boolean = ValidasiCheckBox(grupHobi, "Pilih Minimal 1 Hobi di Tab 'Profil & Aktivitas', Tidak boleh Kosong")
        Dim jabatanValid As Boolean = ValidasiRadioButton(grupJabatan, "Pilih Jabatan Anda di Tab 'Profil & Aktivitas', Tidak boleh Kosong")

        Return namaValid And IdValid And genderValid And divisiValid And TeleponValid And emailValid And alamatValid And pfpValid And hobiValid And jabatanValid

    End Function

End Module

'CekData(txtNama, txtID, cmbDivisi, rbLaki, rbPerempuan, mtbNoHp, txtEmail, txtAlamat, pbPfp, cbGaming, cbMembaca, cbMenulis, cbOlahraga, cbBelanja, cbBermusik, cbMenggambar, cbMemasak, rbLeader, rbViceLeader, rbAdmin, rbIntel, rbMember)