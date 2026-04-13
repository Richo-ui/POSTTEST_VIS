Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Safely populate labels from shared DataModule. Use empty string when data missing.
        lblNama.Text = If(String.IsNullOrWhiteSpace(DataModule.Nama), String.Empty, DataModule.Nama)
        lblID.Text = If(String.IsNullOrWhiteSpace(DataModule.ID), String.Empty, DataModule.ID)
        lblNoHp.Text = If(String.IsNullOrWhiteSpace(DataModule.Telepon), String.Empty, DataModule.Telepon)
        lblEmail.Text = If(String.IsNullOrWhiteSpace(DataModule.Email), String.Empty, DataModule.Email)
        lblAlamat.Text = If(String.IsNullOrWhiteSpace(DataModule.Alamat), String.Empty, DataModule.Alamat)
        lblHobi.Text = If(String.IsNullOrWhiteSpace(DataModule.Hobi), String.Empty, DataModule.Hobi)
        lblDivisi.Text = If(String.IsNullOrWhiteSpace(DataModule.Divisi), String.Empty, DataModule.Divisi)

        ' Some designer files use lblKomunitas, others lblDivisi. Try both if present.
        Try
            If Me.GetType().GetField("lblDivisi", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Public) IsNot Nothing Then
                lblDivisi.Text = If(String.IsNullOrWhiteSpace(DataModule.Divisi), String.Empty, DataModule.Divisi)
            ElseIf Me.GetType().GetField("lblKomunitas", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Public) IsNot Nothing Then
                lblDivisi.Text = If(String.IsNullOrWhiteSpace(DataModule.Divisi), String.Empty, DataModule.Divisi)
            End If
        Catch
            ' ignore if neither field exists
        End Try

        ' Load picture only if path is provided and file exists
        Try
            Dim pics = Me.Controls.Find("PictureBox1", True)
            If pics.Length > 0 AndAlso TypeOf pics(0) Is PictureBox Then
                Dim picBox = DirectCast(pics(0), PictureBox)
                If Not String.IsNullOrWhiteSpace(DataModule.Foto) AndAlso IO.File.Exists(DataModule.Foto) Then
                    picBox.Image = Image.FromFile(DataModule.Foto)
                Else
                    picBox.Image = Nothing
                End If
            End If
        Catch
            ' ignore image load errors
        End Try
    End Sub
End Class