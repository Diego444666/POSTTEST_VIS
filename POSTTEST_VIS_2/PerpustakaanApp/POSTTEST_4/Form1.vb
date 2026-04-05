Imports System.IO

Public Class Form1

    ' ===== LOAD FORM =====
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox Komunitas
        cmbKomunitas.Items.Clear()
        cmbKomunitas.Items.Add("🖥️ Technology")
        cmbKomunitas.Items.Add("🎨 Creative Arts")
        cmbKomunitas.Items.Add("⚽ Sports & Fitness")
        cmbKomunitas.Items.Add("🎵 Music & Entertainment")
        cmbKomunitas.Items.Add("💼 Business & Entrepreneurship")
        cmbKomunitas.Items.Add("🤝 Social & Community")
        cmbKomunitas.SelectedIndex = 0

        ' Mulai dari Tab 1
        TabControl1.SelectedTab = tabDataUtama
    End Sub

    ' ===== VALIDASI NAMA: hanya huruf =====
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' ===== MASKEDTEXTBOX VALIDASI =====
    Private Sub mtbTelp_Leave(sender As Object, e As EventArgs) Handles mtbTelp.Leave
        If Not mtbTelp.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelp, "Nomor HP harus lengkap! Format: 0000-0000-0000")
        Else
            ErrorProvider1.SetError(mtbTelp, "")
        End If
    End Sub

    ' ===== NAVIGATE TABS =====
    Private Sub btnKeTab2_Click(sender As Object, e As EventArgs) Handles btnKeTab2.Click
        TabControl1.SelectedTab = tabKontak
    End Sub

    Private Sub btnKeTab1_Click(sender As Object, e As EventArgs) Handles btnKeTab1.Click
        TabControl1.SelectedTab = tabDataUtama
    End Sub

    Private Sub btnKeTab3_Click(sender As Object, e As EventArgs) Handles btnKeTab3.Click
        TabControl1.SelectedTab = tabProfil
    End Sub

    Private Sub btnKeTab2B_Click(sender As Object, e As EventArgs) Handles btnKeTab2B.Click
        TabControl1.SelectedTab = tabKontak
    End Sub

    ' ===== BROWSE FOTO =====
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Foto Profil"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            Dim fileName As String = "profil" & Path.GetExtension(OpenFileDialog1.FileName)
            Dim destPath As String = Path.Combine(folderPath, fileName)
            File.Copy(OpenFileDialog1.FileName, destPath, True)
            DataKomunitas.FotoPath = destPath
            picFoto.Image = Image.FromFile(destPath)
        End If
    End Sub

    ' ===== VALIDASI SEMUA INPUT =====
    Private Function ValidasiSemua() As Boolean
        ErrorProvider1.Clear()
        Dim valid As Boolean = True

        ' Tab 1
        If txtNama.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
            valid = False
        End If
        If txtID.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtID, "Inputan tidak boleh kosong")
            valid = False
        End If
        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Jenis kelamin belum dipilih!",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            valid = False
        End If

        ' Tab 2
        If Not mtbTelp.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelp, "Nomor HP harus lengkap!")
            valid = False
        End If
        If txtEmail.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtEmail, "Inputan tidak boleh kosong")
            valid = False
        End If
        If txtAlamat.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong")
            valid = False
        End If

        ' Tab 3 - Peran
        If Not rbKetua.Checked AndAlso Not rbWakil.Checked AndAlso
           Not rbAdmin.Checked AndAlso Not rbAnggota.Checked AndAlso
           Not rbKoordinator.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Peran belum dipilih!",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            valid = False
        End If

        ' Tab 3 - Hobby
        Dim adaHobby As Boolean = chkGaming.Checked OrElse chkCoding.Checked OrElse
            chkDesign.Checked OrElse chkMusic.Checked OrElse chkPhoto.Checked OrElse
            chkTravel.Checked OrElse chkReading.Checked OrElse chkSports.Checked OrElse
            chkCooking.Checked OrElse chkArt.Checked

        If Not adaHobby Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Pilih minimal 1 hobby!",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            valid = False
        End If

        ' Foto
        If DataKomunitas.FotoPath = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Foto belum dipilih!",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            valid = False
        End If

        Return valid
    End Function

    ' ===== SIMPAN & CETAK KARTU =====
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Not ValidasiSemua() Then Return

        ' Konfirmasi cetak
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data sudah benar dan ingin dicetak?",
            "Konfirmasi Cetak", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            ' Kumpulkan hobby
            Dim hobbyList As New List(Of String)
            If chkGaming.Checked Then hobbyList.Add("Gaming")
            If chkCoding.Checked Then hobbyList.Add("Coding")
            If chkDesign.Checked Then hobbyList.Add("Design")
            If chkMusic.Checked Then hobbyList.Add("Music")
            If chkPhoto.Checked Then hobbyList.Add("Photography")
            If chkTravel.Checked Then hobbyList.Add("Traveling")
            If chkReading.Checked Then hobbyList.Add("Reading")
            If chkSports.Checked Then hobbyList.Add("Sports")
            If chkCooking.Checked Then hobbyList.Add("Cooking")
            If chkArt.Checked Then hobbyList.Add("Art")

            ' Tentukan peran
            Dim peranDipilih As String = ""
            If rbKetua.Checked Then peranDipilih = "👑 Ketua"
            If rbWakil.Checked Then peranDipilih = "⭐ Wakil Ketua"
            If rbAdmin.Checked Then peranDipilih = "🔧 Admin"
            If rbAnggota.Checked Then peranDipilih = "👤 Anggota"
            If rbKoordinator.Checked Then peranDipilih = "🎯 Koordinator"

            ' Simpan ke Module
            DataKomunitas.Nama = txtNama.Text.Trim()
            DataKomunitas.IDAnggota = txtID.Text.Trim()
            DataKomunitas.TglLahir = dtpTglLahir.Value.ToString("dd MMMM yyyy")
            DataKomunitas.JenisKelamin = If(rbLaki.Checked, "Laki-laki", "Perempuan")
            DataKomunitas.Komunitas = cmbKomunitas.SelectedItem.ToString()
            DataKomunitas.NoTelp = mtbTelp.Text
            DataKomunitas.Email = txtEmail.Text.Trim()
            DataKomunitas.Alamat = txtAlamat.Text.Trim()
            DataKomunitas.Peran = peranDipilih
            DataKomunitas.Hobby = String.Join(", ", hobbyList)

            ' Buka Form2
            Dim frm2 As New Form2()
            frm2.Show()
            Me.Hide()

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Data tidak disimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ===== MENU: INPUT DATA =====
    Private Sub mnuInputData_Click(sender As Object, e As EventArgs) Handles mnuInputData.Click
        TabControl1.SelectedTab = tabDataUtama
    End Sub

    ' ===== MENU: LIHAT KARTU =====
    Private Sub mnuLihatKartu_Click(sender As Object, e As EventArgs) Handles mnuLihatKartu.Click
        If DataKomunitas.Nama = "" Then
            MessageBox.Show("Belum ada data! Isi form terlebih dahulu.",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm2 As New Form2()
            frm2.Show()
            Me.Hide()
        End If
    End Sub

    ' ===== MENU: SIMPAN DATA =====
    Private Sub mnuSimpanData_Click(sender As Object, e As EventArgs) Handles mnuSimpanData.Click
        If DataKomunitas.Nama = "" Then
            MessageBox.Show("Belum ada data yang bisa disimpan!",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim konfirmasi As DialogResult
        konfirmasi = MessageBox.Show("Simpan data ke file?", "Konfirmasi Simpan",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
            SaveFileDialog1.Title = "Simpan Data Anggota"
            SaveFileDialog1.FileName = DataKomunitas.Nama & "_data"

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim isi As String = "=== DATA ANGGOTA NEXUS COMMUNITY ===" & vbCrLf &
                    "Nama       : " & DataKomunitas.Nama & vbCrLf &
                    "ID         : " & DataKomunitas.IDAnggota & vbCrLf &
                    "Tgl Lahir  : " & DataKomunitas.TglLahir & vbCrLf &
                    "JK         : " & DataKomunitas.JenisKelamin & vbCrLf &
                    "Komunitas  : " & DataKomunitas.Komunitas & vbCrLf &
                    "No HP      : " & DataKomunitas.NoTelp & vbCrLf &
                    "Email      : " & DataKomunitas.Email & vbCrLf &
                    "Alamat     : " & DataKomunitas.Alamat & vbCrLf &
                    "Peran      : " & DataKomunitas.Peran & vbCrLf &
                    "Hobby      : " & DataKomunitas.Hobby

                File.WriteAllText(SaveFileDialog1.FileName, isi)
                MessageBox.Show("Data berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    ' ===== MENU: BUKA DATA =====
    Private Sub mnuBukaData_Click(sender As Object, e As EventArgs) Handles mnuBukaData.Click
        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        OpenFileDialog1.Title = "Buka File Data"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isi As String = File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show(isi, "Isi File: " & OpenFileDialog1.FileName,
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ===== MENU: KELUAR =====
    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim konfirmasi As DialogResult
        konfirmasi = MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' Kalau Form1 muncul lagi dari Form2
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Show()
    End Sub

End Class