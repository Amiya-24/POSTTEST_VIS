Public Class KalkulatorIP
    Dim total_IP As Double = 0
    Dim jumlah_Semester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipS As Double
        Dim ipK As Double

        If Double.TryParse(txtIPS.Text, ipS) Then
            total_IP = total_IP + ipS
            jumlah_Semester = jumlah_Semester + 1
            ipK = total_IP / jumlah_Semester

            txtIPK.Text = ipK.ToString()

            If ipK >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            ElseIf ipK >= 2.76 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipK >= 2.0 Then
                lblPredikat.Text = "Cukup"
            Else
                lblPredikat.Text = "Tidak Cukup"
            End If

            txtIPS.Text = ""

        Else
            MessageBox.Show("Masukkan angka yang benar!")

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        total_IP = 0
        jumlah_Semester = 0
        txtIPS.Text = ""
        txtIPK.Text = ""
        lblPredikat.Text = ""
    End Sub
End Class
