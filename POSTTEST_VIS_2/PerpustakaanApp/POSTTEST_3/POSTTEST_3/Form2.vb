Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan semua data dari Module
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Umur & " Tahun"
        lblTgl.Text = DataModule.TanggalLahir
        lblJK.Text = DataModule.JenisKelamin
        lblTelp.Text = DataModule.NoTelpon
        lblHobby.Text = DataModule.Hobby
        lblAlamat.Text = DataModule.Alamat

        ' Tampilkan foto
        If DataModule.FotoPath <> "" AndAlso IO.File.Exists(DataModule.FotoPath) Then
            picHasil.Image = Image.FromFile(DataModule.FotoPath)
        End If
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Saat Form2 ditutup, tampilkan kembali Form1
        Form1.Show()
    End Sub

End Class