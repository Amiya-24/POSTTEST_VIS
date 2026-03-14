Public Class Form1

    ' 1. Logika Tombol Browse Foto
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Foto Profil"

        If ofd.ShowDialog() = DialogResult.OK Then
            pbProfil.Image = Image.FromFile(ofd.FileName)
            pbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    ' 2. Validasi: Input Nama HANYA HURUF dan spasi
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True ' Membatalkan input jika bukan huruf
        End If
    End Sub

    ' 3. Validasi: Input Umur dan No Telpon HANYA ANGKA
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtTelpon.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True ' Membatalkan input jika bukan angka
        End If
    End Sub

    ' 4. Logika Tombol Cetak Kartu (Error Handling & Passing Data)
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        ' A. Mengecek apakah TextBox kosong
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtUmur.Text) OrElse
           String.IsNullOrWhiteSpace(txtTelpon.Text) OrElse
           String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' B. Mengecek apakah RadioButton (Jenis Kelamin) ada yang dipilih
        If Not rbcowok.Checked AndAlso Not rbCewek.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' C. Mengecek apakah Foto sudah diupload
        If pbProfil.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' D. Mengecek apakah minimal 1 CheckBox (Hobby) dipilih & Menggabungkannya
        Dim hobbyTerpilih As Boolean = False
        Dim listHobby As String = ""

        For Each ctrl As Control In gbHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    hobbyTerpilih = True
                    listHobby &= chk.Text & ", "
                End If
            End If
        Next

        If Not hobbyTerpilih Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Merapikan string hobby (menghapus koma terakhir)
        listHobby = listHobby.Substring(0, listHobby.Length - 2)

        ' Menentukan string Jenis Kelamin
        Dim jenisKelamin As String = If(rbCowok.Checked, "Laki-Laki", "Perempuan")

        ' E. MENGIRIM DATA KE FORM 2
        Dim formHasil As New Form2()

        ' Memasukkan data ke komponen di Form 2
        formHasil.pbProfil.Image = pbProfil.Image
        formHasil.txtNama.Text = txtNama.Text
        formHasil.txtUmur.Text = txtUmur.Text
        formHasil.txtTgl.Text = dtptTgl.Value.ToString("dd/MM/yyyy")
        formHasil.txtGender.Text = jenisKelamin
        formHasil.txtNoTelp.Text = txtTelpon.Text
        formHasil.txtHobi.Text = listHobby
        formHasil.txtAlamat.Text = txtAlamat.Text

        ' Menampilkan Form 2
        formHasil.Show()
    End Sub

End Class