Public Class FormPerawatan
    Private Sub Kosongkan()
        txtIDPerawatan.Clear()
        cbIDAlat.SelectedIndex = -1
        dtpTanggal.Value = DateTime.Now
        cbJenisPerawatan.SelectedIndex = -1
        txtKeterangan.Clear()
        txtBiaya.Clear()
        txtSearch.Clear()

        txtIDPerawatan.Enabled = True
        cbIDAlat.Enabled = True
        txtIDPerawatan.Focus()
    End Sub

    Private Sub TampilData()
        dgvPerawatan.DataSource = GetAllPerawatan()
    End Sub

    Private Sub LoadComboAlat()
        cbIDAlat.DataSource = GetIDAlatList()
        cbIDAlat.DisplayMember = "id_alat"
        cbIDAlat.ValueMember = "id_alat"
    End Sub

    Private Sub FormPerawatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboAlat()
        TampilData()
        Kosongkan()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIDPerawatan.Text.Trim() = "" Then
            MessageBox.Show("ID Perawatan wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIDPerawatan.Focus()
            Exit Sub
        End If

        If cbIDAlat.SelectedValue Is Nothing Or cbJenisPerawatan.Text = "" Then
            MessageBox.Show("Pilih ID Alat dan Jenis Perawatan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim biaya As Decimal = 0
        Decimal.TryParse(txtBiaya.Text, biaya)

        If SimpanPerawatan(txtIDPerawatan.Text.Trim(), cbIDAlat.SelectedValue.ToString(), dtpTanggal.Value, cbJenisPerawatan.Text, txtKeterangan.Text, biaya) Then
            MessageBox.Show("Riwayat perawatan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosongkan()
        End If
    End Sub

    Private Sub dgvPerawatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerawatan.CellClick
        If e.RowIndex >= 0 Then
            txtIDPerawatan.Text = dgvPerawatan.Rows(e.RowIndex).Cells("ID").Value.ToString()
            cbIDAlat.Text = dgvPerawatan.Rows(e.RowIndex).Cells("ID Alat").Value.ToString()
            cbJenisPerawatan.Text = dgvPerawatan.Rows(e.RowIndex).Cells("Jenis").Value.ToString()
            txtKeterangan.Text = dgvPerawatan.Rows(e.RowIndex).Cells("Keterangan").Value.ToString()
            txtBiaya.Text = dgvPerawatan.Rows(e.RowIndex).Cells("Biaya").Value.ToString()

            Dim tgl As DateTime
            If DateTime.TryParseExact(dgvPerawatan.Rows(e.RowIndex).Cells("Tanggal").Value.ToString(), "dd-MM-yyyy", Nothing, Globalization.DateTimeStyles.None, tgl) Then
                dtpTanggal.Value = tgl
            End If

            txtIDPerawatan.Enabled = False
            cbIDAlat.Enabled = False
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtIDPerawatan.Text.Trim() = "" Then Exit Sub

        Dim biaya As Decimal = 0
        Decimal.TryParse(txtBiaya.Text, biaya)

        If UbahPerawatan(txtIDPerawatan.Text.Trim(), dtpTanggal.Value, cbJenisPerawatan.Text, txtKeterangan.Text, biaya) Then
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosongkan()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIDPerawatan.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim dialog As DialogResult = MessageBox.Show("Yakin ingin menghapus riwayat perawatan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = DialogResult.Yes Then
            If HapusPerawatan(txtIDPerawatan.Text.Trim()) Then
                MessageBox.Show("Data berhasil terhapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosongkan()
            Else
                MessageBox.Show("Data tidak ditemukan atau gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub txtBiaya_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBiaya.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosongkan()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPerawatan.DataSource = SearchPerawatan(txtSearch.Text.Trim())
        End If
    End Sub
End Class