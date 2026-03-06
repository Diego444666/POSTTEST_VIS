Module RakBuku
    Public koleksi(99, 1) As String
    Public total As Integer = 0

    Public Function CariJudul(nama As String) As Boolean
        For i As Integer = 0 To total - 1
            If koleksi(i, 0).ToLower() = nama.ToLower() Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub MasukkanBuku(ByVal nama As String, ByVal tipe As String)
        If total >= 100 Then
            MessageBox.Show("Rak sudah penuh!")
            Return
        End If
        If CariJudul(nama) Then
            MessageBox.Show("Buku ini sudah terdaftar!")
            Return
        End If
        koleksi(total, 0) = nama
        koleksi(total, 1) = tipe
        total += 1
        MessageBox.Show("Berhasil menambahkan!")
    End Sub

    Public Sub KeluarkanBuku(ByRef nama As String)
        Dim indeks As Integer = -1
        For i As Integer = 0 To total - 1
            If koleksi(i, 0).ToLower() = nama.ToLower() Then
                indeks = i
                Exit For
            End If
        Next
        If indeks = -1 Then
            MessageBox.Show("Buku tidak ketemu!")
            Return
        End If
        For i As Integer = indeks To total - 2
            koleksi(i, 0) = koleksi(i + 1, 0)
            koleksi(i, 1) = koleksi(i + 1, 1)
        Next
        total -= 1
        nama = ""
        MessageBox.Show("Berhasil menghapus!")
    End Sub
End Module