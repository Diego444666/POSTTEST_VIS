Public Class Form3

    Dim selectedId As Integer = -1

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropdown()
        TampilData()
        Kosong()
    End Sub

    Private Sub LoadDropdown()
        Dim dt As DataTable = GetNilaiDropdown()
        cmbNilai.DataSource = dt
        cmbNilai.DisplayMember = "label"
        cmbNilai.ValueMember = "id"
    End Sub

    Private Sub TampilData()
        dgvCatatan.DataSource = GetAllCatatan()
    End Sub

    Private Sub Kosong()
        If cmbNilai.Items.Count > 0 Then cmbNilai.SelectedIndex = 0
        txtCatatan.Clear()
        dtpTanggal.Value = DateTime.Now
        ErrorProvider1.Clear()
        selectedId = -1
    End Sub

    ' Klik baris tabel
    Private Sub dgvCatatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatatan.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvCatatan.Rows(e.RowIndex)
        selectedId = Convert.ToInt32(row.Cells("id").Value)
        txtCatatan.Text = row.Cells("catatan").Value.ToString()

        Dim tgl As Date
        If Date.TryParse(row.Cells("tanggal").Value.ToString(), tgl) Then
            dtpTanggal.Value = tgl
        End If

        ' Cari di dropdown berdasarkan nama_siswa + mapel
        Dim namaSiswa As String = row.Cells("nama_siswa").Value.ToString()
        Dim mapel As String = row.Cells("mata_pelajaran").Value.ToString()
        For i As Integer = 0 To cmbNilai.Items.Count - 1
            Dim dt As DataRowView = CType(cmbNilai.Items(i), DataRowView)
            If dt("label").ToString().Contains(namaSiswa) AndAlso dt("label").ToString().Contains(mapel) Then
                cmbNilai.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    ' Search
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvCatatan.DataSource = SearchCatatan(txtSearch.Text.Trim())
        End If
    End Sub

    ' SIMPAN
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not CekKosong(ErrorProvider1, txtCatatan, "Catatan tidak boleh kosong") Then Return

        Dim idNilai As Integer = Convert.ToInt32(cmbNilai.SelectedValue)

        If SimpanCatatan(idNilai, txtCatatan.Text.Trim(), dtpTanggal.Value) Then
            MessageBox.Show("Catatan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    ' UBAH
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih catatan yang akan diubah dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ErrorProvider1.Clear()
        If Not CekKosong(ErrorProvider1, txtCatatan, "Catatan tidak boleh kosong") Then Return

        Dim idNilai As Integer = Convert.ToInt32(cmbNilai.SelectedValue)

        If UbahCatatan(selectedId, idNilai, txtCatatan.Text.Trim(), dtpTanggal.Value) Then
            MessageBox.Show("Catatan berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    ' HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih catatan yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Yakin ingin menghapus catatan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            If HapusCatatan(selectedId) Then
                MessageBox.Show("Catatan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    ' KEMBALI
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

End Class