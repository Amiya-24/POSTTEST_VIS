Public Class FormAlatBerat

    Private Sub Kosongkan()
        txtID.Clear()
        txtMerk.Clear()
        txtSN.Clear()
        cbJenis.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
        dtpSILO.Value = DateTime.Now
        txtSparePart.Clear()
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
        dtpSILO.Format = DateTimePickerFormat.Custom
        dtpSILO.CustomFormat = "dd-MM-yyyy"
    End Sub

    ' --- TOMBOL SIMPAN (CREATE) ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        ' Validasi form
        If Not ValidasiTextBox(ErrorProvider1, txtID, "ID wajib diisi") OrElse
           Not ValidasiTextBox(ErrorProvider1, txtMerk, "Merk wajib diisi") OrElse
           Not ValidasiTextBox(ErrorProvider1, txtSN, "Serial Number wajib diisi") Then Exit Sub

        If cbJenis.Text = "" Or cbStatus.Text = "" Then
            MessageBox.Show("Pilih Jenis Alat dan Status!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanAlat(txtID.Text, txtMerk.Text, txtSN.Text, cbJenis.Text, cbStatus.Text, dtpSILO.Value, txtSparePart.Text) Then
            MessageBox.Show("Alat berat berhasil didata!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosongkan()
        End If
    End Sub

    ' --- DATA GRID KLIK (READ TO FORM) ---
    Private Sub dgvAlat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlat.CellClick
        If e.RowIndex >= 0 Then
            txtID.Text = dgvAlat.Rows(e.RowIndex).Cells("ID").Value.ToString()
            txtMerk.Text = dgvAlat.Rows(e.RowIndex).Cells("Merk").Value.ToString()
            txtSN.Text = dgvAlat.Rows(e.RowIndex).Cells("SN").Value.ToString()
            cbJenis.Text = dgvAlat.Rows(e.RowIndex).Cells("Jenis").Value.ToString()
            cbStatus.Text = dgvAlat.Rows(e.RowIndex).Cells("Status").Value.ToString()

            Dim tglSILO As DateTime
            If DateTime.TryParseExact(dgvAlat.Rows(e.RowIndex).Cells("SILO Exp").Value.ToString(), "dd-MM-yyyy", Nothing, Globalization.DateTimeStyles.None, tglSILO) Then
                dtpSILO.Value = tglSILO
            End If

            txtSparePart.Text = dgvAlat.Rows(e.RowIndex).Cells("Spare Part Kritis").Value.ToString()

            txtID.Enabled = False
        End If
    End Sub

    ' --- TOMBOL UBAH (UPDATE) ---
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtID.Text = "" Then Exit Sub

        If UbahAlat(txtID.Text, txtMerk.Text, txtSN.Text, cbJenis.Text, cbStatus.Text, dtpSILO.Value, txtSparePart.Text) Then
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosongkan()
        End If
    End Sub

    ' --- TOMBOL HAPUS (DELETE) ---
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text = "" Then Exit Sub

        Dim dialog As DialogResult = MessageBox.Show("Yakin ingin menghapus aset " & txtMerk.Text & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosongkan()
    End Sub
End Class