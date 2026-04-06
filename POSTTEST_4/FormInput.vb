Public Class FormInput

    ' 1. Validasi Inputan Nama (Hanya Huruf)
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) Then
            e.Handled = True
        End If
    End Sub

    ' 2. Validasi Inputan Telepon (Hanya Angka)
    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = "-"c) Then
            e.Handled = True
        End If
    End Sub

    ' 3. Fitur Browse Foto
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFoto.ImageLocation = OpenFileDialog1.FileName
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    ' 4. Fungsi Validasi Kosong & Format
    Private Function ValidasiInput() As Boolean
        Dim isValid As Boolean = True
        ErrorProvider1.Clear()

        ' Cek TextBox biasa
        Dim textBoxes() As TextBox = {txtNama, txtID, txtEmail, txtAlamat}
        For Each tb In textBoxes
            If tb.Text.Trim() = "" Then
                ErrorProvider1.SetError(tb, "Inputan tidak boleh kosong")
                isValid = False
            End If
        Next

        ' Cek ComboBox
        If cbKomunitas.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cbKomunitas, "Inputan tidak boleh kosong")
            isValid = False
        End If

        ' Cek MaskedTextBox (Sesuai modul untuk mengecek format lengkap)
        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "Format nomor HP harus lengkap")
            isValid = False
        End If

        ' Cek Foto
        If pbFoto.Image Is Nothing AndAlso pbFoto.ImageLocation Is Nothing Then
            ErrorProvider1.SetError(btnBrowse, "Foto tidak boleh kosong")
            isValid = False
        End If

        ' Cek CheckBox (Minimal 1 Hobby Terpilih)
        Dim cekHobby As Boolean = chk1.Checked Or chk2.Checked Or chk3.Checked Or chk4.Checked Or chk5.Checked Or chk6.Checked Or chk7.Checked Or chk8.Checked
        If Not cekHobby Then
            ErrorProvider1.SetError(chk1, "Inputan tidak boleh kosong (Pilih minimal 1)")
            isValid = False
        End If

        Return isValid
    End Function

    ' 5. Tombol Simpan & Cetak
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If ValidasiInput() Then
            Dim hasil As DialogResult = MessageBox.Show("Data sudah benar? Lanjutkan cetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If hasil = DialogResult.Yes Then
                ' Kumpulkan hobby yang dicentang
                Dim hobiList As String = ""
                Dim chkBoxes() As CheckBox = {chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8}
                For Each chk In chkBoxes
                    If chk1.Checked Then
                        hobiList &= chk1.Text & ", "
                    End If
                Next

                ' Simpan sementara untuk fitur "Simpan Data" di Form Utama
                FormUtama.dataSementara = $"Nama: {txtNama.Text}, ID: {txtID.Text}, Komunitas: {cbKomunitas.Text}"

                ' Kirim data ke Form Hasil
                FormHasil.lblNama.Text = txtNama.Text
                FormHasil.lblID.Text = "ID: " & txtID.Text
                FormHasil.lblKomunitas.Text = cbKomunitas.Text
                FormHasil.lblKontak.Text = txtEmail.Text & " | " & mtbTelepon.Text
                FormHasil.lblHobby.Text = "Aktivitas: " & hobiList.TrimEnd(","c, " "c)
                FormHasil.lblAlamat.Text = "Alamat: " & txtAlamat.Text
                FormHasil.lblJenisKelamin.Text = "Jenis Kelamin: " & If(rbLaki.Checked, "Laki-laki", "Perempuan")
                FormHasil.pbFotoHasil.ImageLocation = pbFoto.ImageLocation
                FormHasil.pbFotoHasil.SizeMode = PictureBoxSizeMode.Zoom

                FormHasil.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Mohon lengkapi data yang ditandai merah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class