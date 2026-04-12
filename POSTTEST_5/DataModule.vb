Imports MySqlConnector

Module DataModule
    ' --- READ & SEARCH ---
    Public Function GetAllAlat() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tb_alat_berat ORDER BY id_alat ASC"
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
            Dim query As String = "SELECT * FROM tb_alat_berat WHERE id_alat LIKE @keyword OR nama_alat LIKE @keyword"
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
    Public Function SimpanAlat(id As String, nama As String, jenis As String, status As String, hm As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_alat_berat (id_alat, nama_alat, jenis, status, hm_terkini) VALUES (@id, @nama, @jenis, @status, @hm)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@hm", hm)
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
    Public Function UbahAlat(id As String, nama As String, jenis As String, status As String, hm As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tb_alat_berat SET nama_alat=@nama, jenis=@jenis, status=@status, hm_terkini=@hm WHERE id_alat=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@hm", hm)
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
End Module