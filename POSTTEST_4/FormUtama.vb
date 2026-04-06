Public Class FormUtama
    ' Variabel global (opsional) untuk menyimpan data sementara jika belum masuk form hasil
    Public Shared dataSementara As String = ""

    Private Sub menuInput_Click(sender As Object, e As EventArgs) Handles menuInput.Click
        FormInput.Show()
    End Sub

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        FormHasil.Show()
    End Sub

    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click
        SaveFileDialog1.Filter = "Text File *.txt|CSV File *.csv"
        SaveFileDialog1.Title = "Simpan Data Komunitas"

        ' Memeriksa pilihan tombol dari MessageBox menggunakan DialogResult
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, dataSementara)
            MessageBox.Show("File berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBuka.Click
        OpenFileDialog1.Filter = "Text File *.txt|CSV File *.csv"
        OpenFileDialog1.Title = "Buka Data Komunitas"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isiData As String = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show("Isi Data: " & vbCrLf & isiData, "File Terpilih")
        End If
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Dim hasil As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class