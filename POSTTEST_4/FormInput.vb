Public Class FormInput
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = "-"c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFoto.ImageLocation = OpenFileDialog1.FileName
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Function ValidasiInput() As Boolean
        Dim isValid As Boolean = True
        ErrorProvider1.Clear()

        Dim textBoxes() As TextBox = {txtNama, txtID, txtEmail, txtAlamat}
        For Each tb In textBoxes
            If tb.Text.Trim() = "" Then
                ErrorProvider1.SetError(tb, "Inputan tidak boleh kosong")
                isValid = False
            End If
        Next

        If cbDivisi.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cbDivisi, "Inputan tidak boleh kosong")
            isValid = False
        End If

        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "Format nomor HP harus lengkap")
            isValid = False
        End If

        If pbFoto.Image Is Nothing AndAlso pbFoto.ImageLocation Is Nothing Then
            ErrorProvider1.SetError(btnBrowse, "Foto tidak boleh kosong")
            isValid = False
        End If

        Dim cekHobby As Boolean = chk1.Checked Or chk2.Checked Or chk3.Checked Or chk4.Checked Or chk5.Checked Or chk6.Checked Or chk7.Checked Or chk8.Checked
        If Not cekHobby Then
            ErrorProvider1.SetError(chk1, "Inputan tidak boleh kosong (Pilih minimal 1)")
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If ValidasiInput() Then
            Dim hasil As DialogResult = MessageBox.Show("Data sudah benar? Lanjutkan cetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If hasil = DialogResult.Yes Then
                Dim hobiList As String = ""
                Dim chkBoxes() As CheckBox = {chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8}
                For Each chk In chkBoxes
                    If chk.Checked Then
                        hobiList &= chk.Text & ", "
                    End If
                Next

                If hobiList.Length > 0 Then
                    hobiList = hobiList.TrimEnd(","c, " "c)
                End If
                FormUtama.dataSementara = $"Nama: {txtNama.Text}, ID: {txtID.Text}, Komunitas: {cbDivisi.Text}"

                FormHasil.lblNama.Text = "Nama: " & txtNama.Text
                FormHasil.lblID.Text = "ID: " & txtID.Text
                FormHasil.lblDivisi.Text = "Divisi: " & cbDivisi.Text
                FormHasil.lblKontak.Text = "Gmail & No Telepon: " & txtEmail.Text & " | " & mtbTelepon.Text
                FormHasil.lblHobby.Text = "Aktivitas: " & hobiList
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