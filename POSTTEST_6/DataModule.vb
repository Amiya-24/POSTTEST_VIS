Imports MySqlConnector

Module DataModule
    ' --- READ & SEARCH ---
    Public Function GetAllAlat() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_alat AS 'ID', merk AS 'Merk', serial_number AS 'SN', jenis_alat AS 'Jenis', status AS 'Status', DATE_FORMAT(silo_expired, '%d-%m-%Y') AS 'SILO Exp', spare_part_kritis AS 'Spare Part Kritis' FROM tb_alat_berat ORDER BY id_alat ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchAlat(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_alat AS 'ID', merk AS 'Merk', serial_number AS 'SN', jenis_alat AS 'Jenis', status AS 'Status', DATE_FORMAT(silo_expired, '%d-%m-%Y') AS 'SILO Exp', spare_part_kritis AS 'Spare Part Kritis' FROM tb_alat_berat WHERE id_alat LIKE @keyword OR serial_number LIKE @keyword OR merk LIKE @keyword"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Pencarian gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' --- CREATE ---
    Public Function SimpanAlat(id As String, merk As String, sn As String, jenis As String, status As String, silo As DateTime, part As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_alat_berat (id_alat, merk, serial_number, jenis_alat, status, silo_expired, spare_part_kritis) VALUES (@id, @merk, @sn, @jenis, @status, @silo, @part)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@merk", merk)
                    cmd.Parameters.AddWithValue("@sn", sn)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@silo", silo.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@part", part)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' --- UPDATE ---
    Public Function UbahAlat(id As String, merk As String, sn As String, jenis As String, status As String, silo As DateTime, part As String) As Boolean
        Try
            Dim query As String = "UPDATE tb_alat_berat SET merk=@merk, serial_number=@sn, jenis_alat=@jenis, status=@status, silo_expired=@silo, spare_part_kritis=@part WHERE id_alat=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@merk", merk)
                    cmd.Parameters.AddWithValue("@sn", sn)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@silo", silo.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@part", part)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' --- DELETE ---
    Public Function HapusAlat(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_alat_berat WHERE id_alat=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' --- FUNGSI UNTUK RIWAYAT PERAWATAN ---
    Public Function GetIDAlatList() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_alat, merk FROM tb_alat_berat"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil list ID Alat: " & ex.Message)
        End Try
        Return dt
    End Function

    ' READ Riwayat Perawatan
    Public Function GetAllPerawatan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT p.id_perawatan AS 'ID', p.id_alat AS 'ID Alat', a.merk AS 'Merk', DATE_FORMAT(p.tanggal_perawatan, '%d-%m-%Y') AS 'Tanggal', p.jenis_perawatan AS 'Jenis', p.keterangan AS 'Keterangan', p.biaya AS 'Biaya' FROM tb_riwayat_perawatan p JOIN tb_alat_berat a ON p.id_alat = a.id_alat ORDER BY p.tanggal_perawatan DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data perawatan: " & ex.Message)
        End Try
        Return dt
    End Function

    ' CREATE Riwayat Perawatan
    Public Function SimpanPerawatan(id_perawatan As String, id_alat As String, tgl As DateTime, jenis As String, ket As String, biaya As Decimal) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_riwayat_perawatan (id_perawatan, id_alat, tanggal_perawatan, jenis_perawatan, keterangan, biaya) VALUES (@id_perawatan, @id_alat, @tgl, @jenis, @ket, @biaya)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_perawatan", id_perawatan)
                    cmd.Parameters.AddWithValue("@id_alat", id_alat)
                    cmd.Parameters.AddWithValue("@tgl", tgl.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    cmd.Parameters.AddWithValue("@biaya", biaya)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan perawatan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' UPDATE Riwayat Perawatan
    Public Function UbahPerawatan(id_perawatan As String, tgl As DateTime, jenis As String, ket As String, biaya As Decimal) As Boolean
        Try
            Dim query As String = "UPDATE tb_riwayat_perawatan SET tanggal_perawatan=@tgl, jenis_perawatan=@jenis, keterangan=@ket, biaya=@biaya WHERE id_perawatan=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id_perawatan)
                    cmd.Parameters.AddWithValue("@tgl", tgl.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    cmd.Parameters.AddWithValue("@biaya", biaya)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah perawatan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' DELETE Riwayat Perawatan
    Public Function HapusPerawatan(id_perawatan As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_riwayat_perawatan WHERE id_perawatan=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id_perawatan)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' --- SEARCH Riwayat Perawatan ---
    Public Function SearchPerawatan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT p.id_perawatan AS 'ID', p.id_alat AS 'ID Alat', a.merk AS 'Merk', DATE_FORMAT(p.tanggal_perawatan, '%d-%m-%Y') AS 'Tanggal', p.jenis_perawatan AS 'Jenis', p.keterangan AS 'Keterangan', p.biaya AS 'Biaya' FROM tb_riwayat_perawatan p JOIN tb_alat_berat a ON p.id_alat = a.id_alat WHERE p.id_alat LIKE @keyword OR a.merk LIKE @keyword OR p.jenis_perawatan LIKE @keyword OR p.keterangan LIKE @keyword ORDER BY p.tanggal_perawatan DESC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Pencarian gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
End Module