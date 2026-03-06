Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTampilan()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim nama As String = txtNama.Text.Trim()
        Dim kategori As String = txtKategori.Text.Trim()

        If nama = "" Or kategori = "" Then
            MessageBox.Show("Lengkapi data dulu!")
            Return
        End If

        MasukkanBuku(nama, kategori)
        txtNama.Clear()
        txtKategori.Clear()
        UpdateTampilan()
    End Sub

    Private Sub btnBuang_Click(sender As Object, e As EventArgs) Handles btnBuang.Click
        Dim nama As String = txtHapus.Text.Trim()

        If nama = "" Then
            MessageBox.Show("Isi nama buku!")
            Return
        End If

        KeluarkanBuku(nama)
        txtHapus.Text = nama
        UpdateTampilan()
    End Sub

    Private Sub UpdateTampilan()
        If total = 0 Then
            txtTampilan.Text = "Rak masih kosong."
            Return
        End If

        Dim daftar As String = ""
        For i As Integer = 0 To total - 1
            daftar = daftar & (i + 1) & ". " & koleksi(i, 0) & " - " & koleksi(i, 1) & vbCrLf
        Next
        txtTampilan.Text = daftar
    End Sub

    Private Function JumlahBuku() As Integer
        Return total
    End Function

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class