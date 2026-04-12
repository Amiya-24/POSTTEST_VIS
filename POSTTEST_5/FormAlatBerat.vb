Public Class FormAlatBerat

    Private Sub Kosongkan()
        txtID.Clear()
        txtNama.Clear()
        txtHM.Clear()
        cbJenis.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
        txtSearch.Clear()
        txtID.Enabled = True
        ErrorProvider1.Clear()
        txtID.Focus()
    End Sub

    Private Sub TampilData()
        dgvAlat.DataSource = GetAllAlat()
    End Sub

    Private Sub FormAlatBerat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosongkan()
    End Sub

    ' --- TOMBOL SIMPAN (CREATE) ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiTextBox(ErrorProvider1, txtID, "ID wajib diisi") OrElse Not ValidasiTextBox(ErrorProvider1, txtNama, "Nama wajib diisi") Then Exit Sub
        If cbJenis.Text = "" Or cbStatus.Text = "" Or txtHM.Text = "" Then
            MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanAlat(txtID.Text, txtNama.Text, cbJenis.Text, cbStatus.Text, Convert.ToInt32(txtHM.Text)) Then
            MessageBox.Show("Alat berat berhasil didata!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosongkan()
        End If
    End Sub

    ' --- DATA GRID KLIK (READ TO FORM) ---
    Private Sub dgvAlat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlat.CellClick
        If e.RowIndex >= 0 Then
            txtID.Text = dgvAlat.Rows(e.RowIndex).Cells("id_alat").Value.ToString()
            txtNama.Text = dgvAlat.Rows(e.RowIndex).Cells("nama_alat").Value.ToString()
            cbJenis.Text = dgvAlat.Rows(e.RowIndex).Cells("jenis").Value.ToString()
            cbStatus.Text = dgvAlat.Rows(e.RowIndex).Cells("status").Value.ToString()
            txtHM.Text = dgvAlat.Rows(e.RowIndex).Cells("hm_terkini").Value.ToString()

            txtID.Enabled = False ' ID tidak boleh diubah saat update
        End If
    End Sub

    ' --- TOMBOL UBAH (UPDATE) ---
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtID.Text = "" Then Exit Sub

        If UbahAlat(txtID.Text, txtNama.Text, cbJenis.Text, cbStatus.Text, Convert.ToInt32(txtHM.Text)) Then
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosongkan()
        End If
    End Sub

    ' --- TOMBOL HAPUS (DELETE) ---
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text = "" Then Exit Sub

        Dim dialog As DialogResult = MessageBox.Show("Yakin ingin menghapus aset ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            If HapusAlat(txtID.Text) Then
                MessageBox.Show("Data terhapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosongkan()
            End If
        End If
    End Sub

    ' --- FITUR PENCARIAN (SEARCH) ---
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvAlat.DataSource = SearchAlat(txtSearch.Text.Trim())
        End If
    End Sub

    ' --- VALIDASI INPUT ---
    Private Sub txtHM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHM.KeyPress
        HanyaAngka(e) ' Memanggil dari ValidationModule agar HM hanya bisa diisi angka
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosongkan()
    End Sub
End Class