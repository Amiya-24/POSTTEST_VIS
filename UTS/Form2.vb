Public Class Form2
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtNim.Text) OrElse String.IsNullOrWhiteSpace(txtIPK.Text) Then
            MessageBox.Show("Harap lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ipk As Double
        If Double.TryParse(txtIPK.Text.Replace(".", ","), ipk) Then
            Dim predikat As String

            If ipk > 3.5 Then
                predikat = "CUMLAUDE"
            Else
                predikat = "SANGAT MEMUASKAN"
            End If

            Dim gelar As String = ""
            Select Case cmbProdi.Text
                Case "Informatika", "Sistem Informasi", "Ilmu Komputer"
                    gelar = "SARJANA KOMPUTER (S.KOM)"
                Case "Teknik Sipil", "Teknik Elektro", "Teknik Industri", "Teknik Lingkungan", "Teknik Pertambangan", "Teknik Kimia", "Arsitektur", "Teknik Geologi"
                    gelar = "SARJANA TEKNIK (S.T)"
                Case "Pendidikan Dokter"
                    gelar = "SARJANA KEDOKTERAN (S.Ked)"
                Case "Manajemen", "Akuntansi"
                    gelar = "SARJANA EKONOMI (S.E)"
                Case "Hukum"
                    gelar = "SARJANA HUKUM (S.H)"
                Case "Ilmu Komunikasi"
                    gelar = "SARJANA ILMU KOMUNIKASI (S.I.Kom)"
                Case Else
                    gelar = "SARJANA (S.1)"
            End Select

            Dim formIjazah As New Form3(txtNama.Text, txtNim.Text, cmbProdi.Text, predikat, gelar)
            formIjazah.Show()
        Else
            MessageBox.Show("Format IPK tidak valid. Masukkan angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim formLogin As New Form1()
        formLogin.Show()
        Me.Close()
    End Sub
End Class