<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        dtpTanggal = New DateTimePicker()
        Label5 = New Label()
        txtCatatan = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        cmbNilai = New ComboBox()
        ErrorProvider1 = New ErrorProvider(components)
        Panel3 = New Panel()
        btnKembali = New Button()
        dgvCatatan = New DataGridView()
        txtSearch = New TextBox()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(dgvCatatan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(100), CByte(100))
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(920, 75)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(180), CByte(235), CByte(235))
        Label2.Location = New Point(22, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(286, 20)
        Label2.TabIndex = 0
        Label2.Text = "Tabel Relasi — tb_catatan_siswa → tb_nilai"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(100), CByte(100))
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(20, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 31)
        Label1.TabIndex = 1
        Label1.Text = "CATATAN SISWA"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnBatal)
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(btnUbah)
        Panel2.Controls.Add(btnSimpan)
        Panel2.Controls.Add(dtpTanggal)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtCatatan)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(cmbNilai)
        Panel2.Location = New Point(15, 90)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(885, 175)
        Panel2.TabIndex = 2
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(100), CByte(100), CByte(130))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(390, 130)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(110, 35)
        btnBatal.TabIndex = 11
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(200), CByte(50), CByte(50))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(265, 130)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(110, 35)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(220), CByte(120), CByte(0))
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(140, 130)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(110, 35)
        btnUbah.TabIndex = 9
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(15, 130)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(110, 35)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = " Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(130, 99)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(200, 27)
        dtpTanggal.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(100), CByte(100))
        Label5.Location = New Point(15, 102)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 7
        Label5.Text = "Tanggal"
        ' 
        ' txtCatatan
        ' 
        txtCatatan.Location = New Point(130, 59)
        txtCatatan.Name = "txtCatatan"
        txtCatatan.Size = New Size(400, 27)
        txtCatatan.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(100), CByte(100))
        Label4.Location = New Point(15, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 20)
        Label4.TabIndex = 5
        Label4.Text = "Catatan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(100), CByte(100))
        Label3.Location = New Point(15, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 4
        Label3.Text = "Pilih Siswa"
        ' 
        ' cmbNilai
        ' 
        cmbNilai.DropDownStyle = ComboBoxStyle.DropDownList
        cmbNilai.FormattingEnabled = True
        cmbNilai.Location = New Point(130, 17)
        cmbNilai.Name = "cmbNilai"
        cmbNilai.Size = New Size(400, 28)
        cmbNilai.TabIndex = 3
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnKembali)
        Panel3.Controls.Add(dgvCatatan)
        Panel3.Controls.Add(txtSearch)
        Panel3.Controls.Add(Label6)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(15, 280)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(885, 340)
        Panel3.TabIndex = 3
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(0), CByte(100), CByte(100))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.Location = New Point(15, 291)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(200, 35)
        btnKembali.TabIndex = 3
        btnKembali.Text = "◀ Kembali ke Data Nilai"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' dgvCatatan
        ' 
        dgvCatatan.AllowUserToAddRows = False
        dgvCatatan.BackgroundColor = Color.White
        dgvCatatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCatatan.Location = New Point(10, 45)
        dgvCatatan.Name = "dgvCatatan"
        dgvCatatan.ReadOnly = True
        dgvCatatan.RowHeadersWidth = 51
        dgvCatatan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCatatan.Size = New Size(860, 240)
        dgvCatatan.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(70, 9)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(280, 27)
        txtSearch.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(100), CByte(100))
        Label6.Location = New Point(10, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 20)
        Label6.TabIndex = 0
        Label6.Text = "Cari:"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(255))
        ClientSize = New Size(902, 613)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Catatan Siswa"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvCatatan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbNilai As ComboBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCatatan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvCatatan As DataGridView
    Friend WithEvents txtSearch As TextBox
End Class
