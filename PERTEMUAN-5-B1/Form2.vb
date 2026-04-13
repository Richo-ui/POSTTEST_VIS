Public Class Form2
    Private Sub Kosong()
        txtKode.Clear()
        cbJenis.SelectedIndex = -1
        cbJenis.Text = ""
        txtJudul.Clear()
        txtPengarang.Clear()
        txtPenerbit.Clear()
        txtJumlahBuku.Clear()
        txtDeskripsi.Clear()
        ErrorProvider1.Clear()
        txtKode.Focus()
    End Sub

    Private Sub TampilData()
        dgvBuku.DataSource = DataModule.GetAllBuku()
    End Sub
    Private Sub Form_DataBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtJenis As DataTable = DataModule.GetAllJenis()
        cbJenis.DataSource = dtJenis
        cbJenis.DisplayMember = "jenis"
        cbJenis.ValueMember = "kodeJenis"
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataBuku(ErrorProvider1, txtKode, cbJenis,
        txtJudul, txtPengarang, txtPenerbit, txtJumlahBuku) Then Exit Sub
        Dim kode As String = txtKode.Text.Trim()
        Dim kodeJenis As String = cbJenis.SelectedValue.ToString()
        Dim judul As String = txtJudul.Text.Trim()
        Dim pengarang As String = txtPengarang.Text.Trim()
        Dim penerbit As String = txtPenerbit.Text.Trim()
        Dim jumlah As Integer = Convert.ToInt32(txtJumlahBuku.Text.Trim())
        Dim deskripsi As String = txtDeskripsi.Text.Trim()
        If DataModule.KodeBukuSudahAda(kode) Then
            MessageBox.Show("Kode Buku sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKode.Focus()
            Exit Sub
        End If
        If DataModule.SimpanBuku(kode, kodeJenis, judul, pengarang, penerbit, jumlah,
        deskripsi) Then

            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataBuku(ErrorProvider1, txtKode, cbJenis,
        txtJudul, txtPengarang, txtPenerbit, txtJumlahBuku) Then Exit Sub
        Dim kode As String = txtKode.Text.Trim()
        Dim kodeJenis As String = cbJenis.SelectedValue.ToString()
        Dim judul As String = txtJudul.Text.Trim()
        Dim pengarang As String = txtPengarang.Text.Trim()
        Dim penerbit As String = txtPenerbit.Text.Trim()
        Dim jumlah As Integer = Convert.ToInt32(txtJumlahBuku.Text.Trim())
        Dim deskripsi As String = txtDeskripsi.Text.Trim()
        If DataModule.UbahBuku(kode, kodeJenis, judul, pengarang, penerbit, jumlah, deskripsi) Then

            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKode.Focus()
            Exit Sub
        End If
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If DataModule.HapusBuku(txtKode.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvBuku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuku.CellClick

        If e.RowIndex = 0 Then
            txtKode.Text = dgvBuku.Rows(e.RowIndex).Cells(0).Value.ToString()
            cbJenis.Text = dgvBuku.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtJudul.Text = dgvBuku.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtPengarang.Text = dgvBuku.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtPenerbit.Text = dgvBuku.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtJumlahBuku.Text = dgvBuku.Rows(e.RowIndex).Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub txtKodeBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKode.KeyPress
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = DataModule.GetBukuByKode(txtKode.Text.Trim())
            If dt.Rows.Count > 0 Then
                cbJenis.SelectedValue = dt.Rows(0)("KodeJenis").ToString()
                txtJudul.Text = dt.Rows(0)("Judul").ToString()
                txtPengarang.Text = dt.Rows(0)("Pengarang").ToString()
                txtPenerbit.Text = dt.Rows(0)("Penerbit").ToString()
                txtJumlahBuku.Text = dt.Rows(0)("JumlahBuku").ToString()
                txtDeskripsi.Text = dt.Rows(0)("Deskripsi").ToString()
            Else
                cbJenis.SelectedIndex = -1
                txtJudul.Clear()
                txtPengarang.Clear()
                txtPenerbit.Clear()
                txtJumlahBuku.Clear()
                txtDeskripsi.Clear()
            End If
            cbJenis.Focus()
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahBuku.KeyPress
        ValidationModule.HanyaAngka(e)
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            txtCari.Focus()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvBuku.DataSource = DataModule.SearchBuku(txtCari.Text.Trim())
        End If
    End Sub
End Class