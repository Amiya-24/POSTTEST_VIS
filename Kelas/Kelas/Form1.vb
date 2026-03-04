Public Class Form1
    Public nama As String
    Public nim As String
    Public index As Integer

    Private Sub clearInput()
        txtnama.Clear()
        txtnim.Clear()
    End Sub

    Private Sub tampilData()
        dgvhasil.Rows.Clear()
        For i As Integer = 0 To jumlahMahasiswa - 1
            dgvhasil.Rows.Add(daftarMahasiswa(i, 0), daftarMahasiswa(i, 1))
        Next
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        nama = txtnama.Text
        nim = txtnim.Text
        TambahMahasiswa(nama, nim)
        tampilData()
        clearInput()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        index = dgvhasil.CurrentCell.RowIndex
        If index >= 0 And index < jumlahMahasiswa Then
            nama = txtnama.Text
            nim = txtnim.Text
            editMahasiswa(index, nama, nim)
            tampilData()
            clearInput()
        Else
            MessageBox.Show("Pilih data yang ingin diedit.")
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        index = dgvhasil.CurrentCell.RowIndex
        If index >= 0 And index < jumlahMahasiswa Then
            HapusMahasiswa(index)
            tampilData()
            clearInput()
        Else
            MessageBox.Show("Pilih data yang ingin dihapus.")
        End If
    End Sub
End Class
