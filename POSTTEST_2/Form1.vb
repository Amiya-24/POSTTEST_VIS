Public Class Form1
    Private Function CariIndeksBuku(ByVal judulYangDicari As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            Dim judulBuku As String = daftarBuku(i).Split("("c)(0).Trim()

            If judulBuku.ToLower() = judulYangDicari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub UpdateTampilanListBox(ByRef lstTampilan As ListBox)
        lstTampilan.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lstTampilan.Items.Add(daftarBuku(i))
        Next
    End Sub

    Private Sub TambahKeArray(ByVal judul As String, ByVal genre As String)
        ReDim Preserve daftarBuku(jumlahBuku)
        daftarBuku(jumlahBuku) = judul & " (" & genre & ")"
        jumlahBuku += 1
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btntambahbuku.Click
        Dim judul As String = txtjudultambah.Text.Trim()
        Dim genre As String = txtgenre.Text.Trim()

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        TambahKeArray(judul, genre)
        UpdateTampilanListBox(lstbuku)

        txtjudultambah.Clear()
        txtgenre.Clear()
        txtjudultambah.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnhapusbuku.Click
        Dim judulHapus As String = txtjudulhapus.Text.Trim()

        If judulHapus = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim indeks As Integer = CariIndeksBuku(judulHapus)

        If indeks <> -1 Then
            For i As Integer = indeks To jumlahBuku - 2
                daftarBuku(i) = daftarBuku(i + 1)
            Next

            jumlahBuku -= 1

            If jumlahBuku > 0 Then
                ReDim Preserve daftarBuku(jumlahBuku - 1)
            Else
                Erase daftarBuku
            End If

            UpdateTampilanListBox(lstbuku)
            MessageBox.Show("Buku berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtjudulhapus.Clear()
        Else
            MessageBox.Show("Buku tidak ditemukan di dalam daftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TambahKeArray("Harry Potter", "Fantasi")
        TambahKeArray("Sherlock Holmes", "Misteri")
        UpdateTampilanListBox(lstBuku)
    End Sub
End Class