Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahsemester As Integer = 0
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ips As Double

        If Double.TryParse(txtIPS.Text, ips) Then

            totalIP += ips
            jumlahsemester += 1

            Dim ipk As Double = totalIP / jumlahsemester
            txtIPK.Text = ipk.ToString("0.00")

            'Predikat
            If ipk >= 2.0 And ipk <= 2.7 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If

        Else
            MessageBox.Show("Masukkan Nilai yang valid!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahsemester = 0
        txtIPS.Text = ""
        txtIPK.Text = "0.00"
        lblPredikat.Text = "Nilai telah direset!"
    End Sub
End Class