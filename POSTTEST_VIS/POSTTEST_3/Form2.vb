Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Umur
        lblTelepon.Text = DataModule.Telepon
        lblAlamat.Text = DataModule.Alamat
        lblTLahir.Text = DataModule.Tglahir
        lblJK.Text = DataModule.JK
        lblHobi.Text = DataModule.Hobi
        pbProfil.Image = Image.FromFile(DataModule.Foto)
    End Sub
End Class