Public Class FormUtama
    Private Sub DataAlatBeratToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlatBeratToolStripMenuItem.Click
        ' Membuka form CRUD
        FormAlatBerat.Show()
    End Sub

    Private Sub TentangSistemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangSistemToolStripMenuItem.Click
        MessageBox.Show("Sistem Manajemen Inventaris Alat Berat" & vbCrLf &
                        "Dikembangkan oleh: Muhammad Faiz Lazuardi" & vbCrLf &
                        "NIM: 2409106031" & vbCrLf &
                        "Universitas Mulawarman", "Tentang", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class