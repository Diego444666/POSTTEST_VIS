<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        mnuData = New ToolStripMenuItem()
        mnuDashboard = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        pnlHeader = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        pnlInput = New Panel()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        lblKet = New Label()
        txtNilai = New TextBox()
        Label6 = New Label()
        txtMapel = New TextBox()
        Label5 = New Label()
        txtKelas = New TextBox()
        Label4 = New Label()
        txtNama = New TextBox()
        Label3 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        pnlBawah = New Panel()
        dgvNilai = New DataGridView()
        txtSearch = New TextBox()
        Label7 = New Label()
        mnuCatatan = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlInput.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        pnlBawah.SuspendLayout()
        CType(dgvNilai, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuData, mnuDashboard, mnuKeluar, mnuCatatan})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(902, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuData
        ' 
        mnuData.ForeColor = Color.White
        mnuData.Name = "mnuData"
        mnuData.Size = New Size(90, 24)
        mnuData.Text = "Data Nilai"
        ' 
        ' mnuDashboard
        ' 
        mnuDashboard.ForeColor = Color.White
        mnuDashboard.Name = "mnuDashboard"
        mnuDashboard.Size = New Size(96, 24)
        mnuDashboard.Text = "Dashboard"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.ForeColor = Color.White
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(65, 24)
        mnuKeluar.Text = "Keluar"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        pnlHeader.Controls.Add(Label2)
        pnlHeader.Controls.Add(Label1)
        pnlHeader.Location = New Point(0, 27)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(920, 75)
        pnlHeader.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(180), CByte(210), CByte(255))
        Label2.Location = New Point(22, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(265, 20)
        Label2.TabIndex = 1
        Label2.Text = "Informatika — Universitas Mulawarman"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(20, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(565, 38)
        Label1.TabIndex = 0
        Label1.Text = "SISTEM MANAJEMEN DATA NILAI SISWA"
        ' 
        ' pnlInput
        ' 
        pnlInput.BackColor = Color.Transparent
        pnlInput.BorderStyle = BorderStyle.FixedSingle
        pnlInput.Controls.Add(btnBatal)
        pnlInput.Controls.Add(btnHapus)
        pnlInput.Controls.Add(btnUbah)
        pnlInput.Controls.Add(btnSimpan)
        pnlInput.Controls.Add(lblKet)
        pnlInput.Controls.Add(txtNilai)
        pnlInput.Controls.Add(Label6)
        pnlInput.Controls.Add(txtMapel)
        pnlInput.Controls.Add(Label5)
        pnlInput.Controls.Add(txtKelas)
        pnlInput.Controls.Add(Label4)
        pnlInput.Controls.Add(txtNama)
        pnlInput.Controls.Add(Label3)
        pnlInput.Location = New Point(15, 115)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(885, 175)
        pnlInput.TabIndex = 2
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(100), CByte(100), CByte(130))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(390, 130)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(110, 35)
        btnBatal.TabIndex = 12
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(200), CByte(50), CByte(50))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(265, 130)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(110, 35)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(220), CByte(120), CByte(0))
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(140, 130)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(110, 35)
        btnUbah.TabIndex = 10
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(15, 130)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(110, 35)
        btnSimpan.TabIndex = 9
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' lblKet
        ' 
        lblKet.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblKet.ForeColor = Color.FromArgb(CByte(0), CByte(140), CByte(0))
        lblKet.Location = New Point(15, 98)
        lblKet.Name = "lblKet"
        lblKet.Size = New Size(500, 22)
        lblKet.TabIndex = 8
        lblKet.Text = "Keterangan: -"
        ' 
        ' txtNilai
        ' 
        txtNilai.Location = New Point(480, 57)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(110, 27)
        txtNilai.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        Label6.Location = New Point(380, 60)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 20)
        Label6.TabIndex = 6
        Label6.Text = "Nilai (0-100)"
        ' 
        ' txtMapel
        ' 
        txtMapel.Location = New Point(130, 57)
        txtMapel.Name = "txtMapel"
        txtMapel.Size = New Size(220, 27)
        txtMapel.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        Label5.Location = New Point(15, 60)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 20)
        Label5.TabIndex = 4
        Label5.Text = "Mata Pelajaran"
        ' 
        ' txtKelas
        ' 
        txtKelas.Location = New Point(440, 17)
        txtKelas.Name = "txtKelas"
        txtKelas.Size = New Size(150, 27)
        txtKelas.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        Label4.Location = New Point(380, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 2
        Label4.Text = "Kelas"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(130, 17)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(220, 27)
        txtNama.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        Label3.Location = New Point(15, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 20)
        Label3.TabIndex = 0
        Label3.Text = "Nama Siswa"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' pnlBawah
        ' 
        pnlBawah.BackColor = Color.White
        pnlBawah.BorderStyle = BorderStyle.FixedSingle
        pnlBawah.Controls.Add(dgvNilai)
        pnlBawah.Controls.Add(txtSearch)
        pnlBawah.Controls.Add(Label7)
        pnlBawah.Location = New Point(15, 305)
        pnlBawah.Name = "pnlBawah"
        pnlBawah.Size = New Size(885, 315)
        pnlBawah.TabIndex = 3
        ' 
        ' dgvNilai
        ' 
        dgvNilai.AllowUserToAddRows = False
        dgvNilai.BackgroundColor = Color.White
        dgvNilai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNilai.Location = New Point(10, 45)
        dgvNilai.Name = "dgvNilai"
        dgvNilai.ReadOnly = True
        dgvNilai.RowHeadersWidth = 51
        dgvNilai.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvNilai.Size = New Size(860, 260)
        dgvNilai.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(70, 9)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(280, 27)
        txtSearch.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        Label7.Location = New Point(10, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 20)
        Label7.TabIndex = 0
        Label7.Text = "Cari:"
        ' 
        ' mnuCatatan
        ' 
        mnuCatatan.ForeColor = Color.White
        mnuCatatan.Name = "mnuCatatan"
        mnuCatatan.Size = New Size(115, 24)
        mnuCatatan.Text = "Catatan Siswa"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(255))
        ClientSize = New Size(902, 613)
        Controls.Add(pnlBawah)
        Controls.Add(pnlInput)
        Controls.Add(pnlHeader)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Data Nilai Siswa"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        pnlBawah.ResumeLayout(False)
        pnlBawah.PerformLayout()
        CType(dgvNilai, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuData As ToolStripMenuItem
    Friend WithEvents mnuDashboard As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlInput As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblKet As Label
    Friend WithEvents txtNilai As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMapel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKelas As TextBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents pnlBawah As Panel
    Friend WithEvents dgvNilai As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mnuCatatan As ToolStripMenuItem

End Class
