Imports System.IO

Public Class Form1

    ' ===== VALIDASI: txtNama hanya huruf =====
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' ===== VALIDASI: txtUmur hanya angka =====
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' ===== VALIDASI: txtTelp hanya angka =====
    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' ===== BUTTON BROWSE FOTO =====
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFile.Title = "Pilih Foto Profil"

        If openFile.ShowDialog() = DialogResult.OK Then
            Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            Dim fileName As String = "profil" & Path.GetExtension(openFile.FileName)
            Dim destPath As String = Path.Combine(folderPath, fileName)

            File.Copy(openFile.FileName, destPath, True)

            DataModule.FotoPath = destPath
            picFoto.Image = Image.FromFile(destPath)
        End If
    End Sub

    ' ===== BUTTON CETAK KARTU =====
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        ' --- Cek Nama ---
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Nama belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        ' --- Cek Umur ---
        If txtUmur.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Umur belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return
        End If

        ' --- Cek No Telepon ---
        If txtTelp.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "No Telepon belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelp.Focus()
            Return
        End If

        ' --- Cek Alamat ---
        If txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Alamat belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlamat.Focus()
            Return
        End If

        ' --- Cek Jenis Kelamin ---
        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Jenis Kelamin belum dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Cek Hobby (minimal 1) ---
        Dim hobbyList As New List(Of String)
        If chkGaming.Checked Then hobbyList.Add("Gaming")
        If chkCoding.Checked Then hobbyList.Add("Coding")
        If chkMasak.Checked Then hobbyList.Add("Memasak")
        If chkMusik.Checked Then hobbyList.Add("Musik")
        If chkMenggambar.Checked Then hobbyList.Add("Menggambar")
        If chkMembaca.Checked Then hobbyList.Add("Membaca")
        If chkOlahraga.Checked Then hobbyList.Add("Olahraga")
        If chkMenyanyi.Checked Then hobbyList.Add("Menyanyi")
        If chkMenulis.Checked Then hobbyList.Add("Menulis")
        If chkFotografi.Checked Then hobbyList.Add("Fotografi")

        If hobbyList.Count = 0 Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Pilih minimal 1 Hobby.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Cek Foto ---
        If DataModule.FotoPath = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Foto profil belum dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Simpan ke Module ---
        DataModule.Nama = txtNama.Text.Trim()
        DataModule.Umur = txtUmur.Text.Trim()
        DataModule.TanggalLahir = dtpTanggal.Value.ToString("dd/MM/yyyy")
        DataModule.JenisKelamin = If(rbLaki.Checked, "Laki-Laki", "Perempuan")
        DataModule.NoTelpon = txtTelp.Text.Trim()
        DataModule.Hobby = String.Join(", ", hobbyList)
        DataModule.Alamat = txtAlamat.Text.Trim()

        ' --- Buka Form2 ---
        Dim frm2 As New Form2()
        frm2.Show()
        Me.Hide()

    End Sub

End Class