Imports MySqlConnector

Module ConnectionModule
    Public ReadOnly ConnString As String = "Server=localhost;Port=3306;Database=db_nilai_siswa;User ID=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnString)
    End Function
End Module