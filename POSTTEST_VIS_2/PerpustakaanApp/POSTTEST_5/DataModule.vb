Imports MySqlConnector

Module DataModule

    Public Function GetKeterangan(nilai As Integer) As String
        If nilai >= 90 Then Return "A - Sangat Baik"
        If nilai >= 80 Then Return "B - Baik"
        If nilai >= 70 Then Return "C - Cukup"
        If nilai >= 60 Then Return "D - Kurang"
        Return "E - Tidak Lulus"
    End Function

    Public Function GetAllNilai() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT id, nama_siswa, kelas, mata_pelajaran, nilai, keterangan FROM tb_nilai ORDER BY id ASC", conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchNilai(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT id, nama_siswa, kelas, mata_pelajaran, nilai, keterangan FROM tb_nilai WHERE nama_siswa LIKE @kw OR kelas LIKE @kw OR mata_pelajaran LIKE @kw ORDER BY id ASC", conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanNilai(nama As String, kelas As String, mapel As String, nilai As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO tb_nilai (nama_siswa, kelas, mata_pelajaran, nilai, keterangan) VALUES (@nama, @kelas, @mapel, @nilai, @ket)", conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kelas", kelas)
                    cmd.Parameters.AddWithValue("@mapel", mapel)
                    cmd.Parameters.AddWithValue("@nilai", nilai)
                    cmd.Parameters.AddWithValue("@ket", GetKeterangan(nilai))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahNilai(id As Integer, nama As String, kelas As String, mapel As String, nilai As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE tb_nilai SET nama_siswa=@nama, kelas=@kelas, mata_pelajaran=@mapel, nilai=@nilai, keterangan=@ket WHERE id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kelas", kelas)
                    cmd.Parameters.AddWithValue("@mapel", mapel)
                    cmd.Parameters.AddWithValue("@nilai", nilai)
                    cmd.Parameters.AddWithValue("@ket", GetKeterangan(nilai))
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusNilai(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM tb_nilai WHERE id=@id", conn)
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