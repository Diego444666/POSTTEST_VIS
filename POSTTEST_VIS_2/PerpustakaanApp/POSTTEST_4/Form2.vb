Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan data dari Module
        lblNama.Text = DataKomunitas.Nama
        lblID.Text = DataKomunitas.IDAnggota
        lblKomunitas.Text = DataKomunitas.Komunitas
        lblPeran.Text = DataKomunitas.Peran
        lblTelp.Text = DataKomunitas.NoTelp
        lblHobby.Text = DataKomunitas.Hobby
        lblAlamat.Text = DataKomunitas.Alamat

        ' Tampilkan foto
        If DataKomunitas.FotoPath <> "" AndAlso IO.File.Exists(DataKomunitas.FotoPath) Then
            picHasil.Image = Image.FromFile(DataKomunitas.FotoPath)
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

End Class