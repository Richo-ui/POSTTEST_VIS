Imports System.Collections.Generic

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Data Jamaah"

        'AturComboBox()
        AturMaskedTextBox()
        AturFormAwal()

        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProvider1.BlinkRate = 0
    End Sub

    'Private Sub AturComboBox()
    '    cboJenisKelamin.Items.Clear()
    '    cboJenisKelamin.Items.Add("Laki-laki")
    '    cboJenisKelamin.Items.Add("Perempuan")
    '    cboJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList

    '    cboProdi.Items.Clear()
    '    cboProdi.Items.Add("Informatika")
    '    cboProdi.Items.Add("Sistem Informasi")
    '    cboProdi.Items.Add("Teknik Komputer")
    '    cboProdi.DropDownStyle = ComboBoxStyle.DropDownList
    'End Sub

    Private Sub AturMaskedTextBox()
        mtxtNoHp.Mask = "0000-0000-0000"
        mtxtNoHp.PromptChar = "_"c
        mtxtNoHp.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
    End Sub

    Private Sub AturFormAwal()
        txtNama.CharacterCasing = CharacterCasing.Upper
        'txtNIM.MaxLength = 15
        txtAlamat.Multiline = True
        TabControl1.SelectedTab = tcIdentitas
        lblRingkasan.Text = ""
    End Sub

    ' VALIDASI INPUT KARAKTER
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    'Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
    '    HanyaAngka(e)
    'End Sub

    ' VALIDASI LANGSUNG
    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
    End Sub

    'Private Sub txtNIM_TextChanged(sender As Object, e As EventArgs) Handles txtNIM.TextChanged
    '    ValidasiTextBox(ErrorProvider1, txtNIM, "NIM tidak boleh kosong")
    'End Sub

    'Private Sub cboJenisKelamin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJenisKelamin.SelectedIndexChanged
    '    ValidasiComboBox(ErrorProvider1, cboJenisKelamin, "Jenis kelamin harus dipilih")
    'End Sub

    'Private Sub cboProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProdi.SelectedIndexChanged
    '    ValidasiComboBox(ErrorProvider1, cboProdi, "Prodi harus dipilih")
    'End Sub

    Private Sub mtbNoHP_TextChanged(sender As Object, e As EventArgs) Handles mtxtNoHp.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, mtxtNoHp, "Nomor HP belum lengkap")
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
        ValidasiTextBox(ErrorProvider1, txtAlamat, "Alamat tidak boleh kosong")
    End Sub

    ' RINGKASAN
    Private Sub PerbaruiRingkasan()
        lblRingkasan.Text = BuatRingkasan(
            txtNama.Text,
            mtxtNoHp.Text,
            txtAlamat.Text
        )
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is tcRingkasan Then
            PerbaruiRingkasan()
        End If
    End Sub


    ' TOMBOL SIMPAN

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiSemuaInput(ErrorProvider1, txtNama, mtxtNoHp, txtAlamat) Then
            MessageBox.Show(
                "Masih ada input yang belum valid.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah data ingin disimpan?",
            "Konfirmasi Simpan",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Dim isi As String = BuatIsiFile(
                txtNama.Text,
                mtxtNoHp.Text,
                txtAlamat.Text
            )

            If SimpanDataKeFile(SaveFileDialog1, isi, "data_jamaah.txt") Then
                PerbaruiRingkasan()
                TabControl1.SelectedTab = tcRingkasan

                MessageBox.Show(
                    "Data berhasil disimpan.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
            End If

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show(
                "Data tidak jadi disimpan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show(
                "Proses dibatalkan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            )
        End If
    End Sub

    ' TOMBOL RESET

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah data ingin direset?",
            "Konfirmasi Reset",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            KosongkanForm()
        End If
    End Sub

    Private Sub KosongkanForm()
        txtNama.Clear()

        mtxtNoHp.Clear()
        txtAlamat.Clear()
        lblRingkasan.Text = ""

        ErrorProvider1.Clear()

        TabControl1.SelectedTab = tcIdentitas
        txtNama.Focus()
    End Sub

    ' MENU

    Private Sub mnuInputData_Click(sender As Object, e As EventArgs) Handles InputData.Click
        TabControl1.SelectedTab = tcIdentitas
        txtNama.Focus()
    End Sub

    Private Sub mnuBukaFile_Click(sender As Object, e As EventArgs) Handles BukaFile.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)

        If data Is Nothing Then Exit Sub

        KosongkanForm()
        IsiDataKeForm(data)
        PerbaruiRingkasan()
        TabControl1.SelectedTab = tcRingkasan

        MessageBox.Show(
            "File berhasil dibuka.",
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub mnuSimpanFile_Click(sender As Object, e As EventArgs) Handles tcIdentitas.Click
        btnSimpan.PerformClick()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles Kembali.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    ' LOAD DATA KE FORM
    Private Sub IsiDataKeForm(data As Dictionary(Of String, String))
        txtNama.Text = AmbilNilai(data, "Nama")
        mtxtNoHp.Text = AmbilNilai(data, "NoHP")
        txtAlamat.Text = AmbilNilai(data, "Alamat")
    End Sub

End Class