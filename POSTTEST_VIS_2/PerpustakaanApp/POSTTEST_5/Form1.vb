Public Class Form1

    Dim selectedId As Integer = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub Kosong()
        txtNama.Clear()
        txtKelas.Clear()
        txtMapel.Clear()
        txtNilai.Clear()
        lblKet.Text = "Keterangan: -"
        lblKet.ForeColor = Color.FromArgb(100, 100, 130)
        ErrorProvider1.Clear()
        selectedId = -1
        txtNama.Focus()
    End Sub

    Private Sub TampilData()
        dgvNilai.DataSource = GetAllNilai()
    End Sub

    ' Hanya huruf untuk nama
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    ' Hanya angka untuk nilai
    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        HanyaAngka(e)
    End Sub

    ' Update keterangan otomatis saat ketik nilai
    Private Sub txtNilai_TextChanged(sender As Object, e As EventArgs) Handles txtNilai.TextChanged
        Dim n As Integer
        If Integer.TryParse(txtNilai.Text, n) AndAlso n >= 0 AndAlso n <= 100 Then
            Dim ket As String = GetKeterangan(n)
            lblKet.Text = "Keterangan: " & ket

            If n >= 80 Then
                lblKet.ForeColor = Color.FromArgb(0, 140, 0)
            ElseIf n >= 60 Then
                lblKet.ForeColor = Color.FromArgb(200, 130, 0)
            Else
                lblKet.ForeColor = Color.FromArgb(200, 50, 50)
            End If
        Else
            lblKet.Text = "Keterangan: -"
            lblKet.ForeColor = Color.FromArgb(100, 100, 130)
        End If
    End Sub

    ' Klik baris di DataGridView → isi field
    Private Sub dgvNilai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNilai.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvNilai.Rows(e.RowIndex)
        selectedId = Convert.ToInt32(row.Cells("id").Value)
        txtNama.Text = row.Cells("nama_siswa").Value.ToString()
        txtKelas.Text = row.Cells("kelas").Value.ToString()
        txtMapel.Text = row.Cells("mata_pelajaran").Value.ToString()
        txtNilai.Text = row.Cells("nilai").Value.ToString()
    End Sub

    ' Search real-time
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvNilai.DataSource = SearchNilai(txtSearch.Text.Trim())
        End If
    End Sub

    ' SIMPAN
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        Dim v1 = CekKosong(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
        Dim v2 = CekKosong(ErrorProvider1, txtKelas, "Kelas tidak boleh kosong")
        Dim v3 = CekKosong(ErrorProvider1, txtMapel, "Mata pelajaran tidak boleh kosong")
        Dim v4 = CekKosong(ErrorProvider1, txtNilai, "Nilai tidak boleh kosong")

        If Not (v1 And v2 And v3 And v4) Then Return

        Dim n As Integer
        If Not Integer.TryParse(txtNilai.Text, n) OrElse n < 0 OrElse n > 100 Then
            MessageBox.Show("Nilai harus angka antara 0 - 100!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNilai.Focus()
            Return
        End If

        If SimpanNilai(txtNama.Text.Trim(), txtKelas.Text.Trim(), txtMapel.Text.Trim(), n) Then
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    ' UBAH
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data yang akan diubah dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ErrorProvider1.Clear()

        Dim v1 = CekKosong(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
        Dim v2 = CekKosong(ErrorProvider1, txtKelas, "Kelas tidak boleh kosong")
        Dim v3 = CekKosong(ErrorProvider1, txtMapel, "Mata pelajaran tidak boleh kosong")
        Dim v4 = CekKosong(ErrorProvider1, txtNilai, "Nilai tidak boleh kosong")

        If Not (v1 And v2 And v3 And v4) Then Return

        Dim n As Integer
        If Not Integer.TryParse(txtNilai.Text, n) OrElse n < 0 OrElse n > 100 Then
            MessageBox.Show("Nilai harus angka antara 0 - 100!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If UbahNilai(selectedId, txtNama.Text.Trim(), txtKelas.Text.Trim(), txtMapel.Text.Trim(), n) Then
            MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    ' HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data yang akan dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusNilai(selectedId) Then
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    ' BATAL
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    ' MENU
    Private Sub mnuData_Click(sender As Object, e As EventArgs) Handles mnuData.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub mnuDashboard_Click(sender As Object, e As EventArgs) Handles mnuDashboard.Click
        Dim frm2 As New Form2()
        frm2.ShowDialog()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class