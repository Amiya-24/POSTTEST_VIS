Imports MySqlConnector

Module ConnectionModule
    Public ReadOnly ConnectionString As String = "Server=localhost; Port=3306; Database=db_inventaris_alat_berat; User ID=root; Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module