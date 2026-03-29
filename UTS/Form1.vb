Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" AndAlso txtPassword.Text = "admin" Then
            Dim formInput As New Form2()
            formInput.Show()
            Me.Hide()
        Else
            MessageBox.Show("username dan password salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

End Class