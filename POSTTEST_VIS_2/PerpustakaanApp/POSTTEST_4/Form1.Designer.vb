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
        mnuInputData = New ToolStripMenuItem()
        mnuLihatKartu = New ToolStripMenuItem()
        mnuSimpanData = New ToolStripMenuItem()
        mnuBukaData = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        pnlHeader = New Panel()
        picLogo = New PictureBox()
        lblJudul = New Label()
        lblSubJudul = New Label()
        TabControl1 = New TabControl()
        tabDataUtama = New TabPage()
        tabKontak = New TabPage()
        tabProfil = New TabPage()
        lblNama = New Label()
        txtNama = New TextBox()
        lblID = New Label()
        txtID = New TextBox()
        lblTgl = New Label()
        dtpTglLahir = New DateTimePicker()
        grpJK = New GroupBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        lblKomunitas = New Label()
        cmbKomunitas = New ComboBox()
        btnKeTab2 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        lblTelp = New Label()
        mtbTelp = New MaskedTextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        btnKeTab1 = New Button()
        btnKeTab3 = New Button()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        grpPeran = New GroupBox()
        rbKetua = New RadioButton()
        rbWakil = New RadioButton()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKoordinator = New RadioButton()
        grpHobby = New GroupBox()
        chkGaming = New CheckBox()
        chkCoding = New CheckBox()
        chkDesign = New CheckBox()
        chkMusic = New CheckBox()
        chkPhoto = New CheckBox()
        chkTravel = New CheckBox()
        chkReading = New CheckBox()
        chkSports = New CheckBox()
        chkCooking = New CheckBox()
        chkArt = New CheckBox()
        btnSimpanCetak = New Button()
        btnKeTab2B = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        tabDataUtama.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        grpJK.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpPeran.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(55))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuInputData, mnuLihatKartu, mnuSimpanData, mnuBukaData, mnuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(802, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuInputData
        ' 
        mnuInputData.ForeColor = Color.White
        mnuInputData.Name = "mnuInputData"
        mnuInputData.Size = New Size(93, 24)
        mnuInputData.Text = "Input Data"
        ' 
        ' mnuLihatKartu
        ' 
        mnuLihatKartu.ForeColor = Color.White
        mnuLihatKartu.Name = "mnuLihatKartu"
        mnuLihatKartu.Size = New Size(94, 24)
        mnuLihatKartu.Text = "Lihat Kartu"
        ' 
        ' mnuSimpanData
        ' 
        mnuSimpanData.ForeColor = Color.White
        mnuSimpanData.Name = "mnuSimpanData"
        mnuSimpanData.Size = New Size(109, 24)
        mnuSimpanData.Text = "Simpan Data"
        ' 
        ' mnuBukaData
        ' 
        mnuBukaData.ForeColor = Color.White
        mnuBukaData.Name = "mnuBukaData"
        mnuBukaData.Size = New Size(91, 24)
        mnuBukaData.Text = "Buka Data"
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
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(55))
        pnlHeader.Controls.Add(lblSubJudul)
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Controls.Add(picLogo)
        pnlHeader.Location = New Point(0, 27)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(820, 90)
        pnlHeader.TabIndex = 1
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Location = New Point(15, 10)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(70, 70)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.BackColor = Color.Transparent
        lblJudul.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.BlueViolet
        lblJudul.Location = New Point(100, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(359, 46)
        lblJudul.TabIndex = 1
        lblJudul.Text = "NEXUS COMMUNITY"
        ' 
        ' lblSubJudul
        ' 
        lblSubJudul.AutoSize = True
        lblSubJudul.BackColor = Color.Transparent
        lblSubJudul.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSubJudul.ForeColor = Color.DarkTurquoise
        lblSubJudul.Location = New Point(103, 55)
        lblSubJudul.Name = "lblSubJudul"
        lblSubJudul.Size = New Size(268, 23)
        lblSubJudul.TabIndex = 2
        lblSubJudul.Text = "✦ Member Management System ✦"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabDataUtama)
        TabControl1.Controls.Add(tabKontak)
        TabControl1.Controls.Add(tabProfil)
        TabControl1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(15, 125)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(785, 490)
        TabControl1.TabIndex = 2
        ' 
        ' tabDataUtama
        ' 
        tabDataUtama.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(45))
        tabDataUtama.Controls.Add(btnKeTab2)
        tabDataUtama.Controls.Add(cmbKomunitas)
        tabDataUtama.Controls.Add(lblKomunitas)
        tabDataUtama.Controls.Add(grpJK)
        tabDataUtama.Controls.Add(dtpTglLahir)
        tabDataUtama.Controls.Add(lblTgl)
        tabDataUtama.Controls.Add(txtID)
        tabDataUtama.Controls.Add(lblID)
        tabDataUtama.Controls.Add(txtNama)
        tabDataUtama.Controls.Add(lblNama)
        tabDataUtama.Location = New Point(4, 32)
        tabDataUtama.Name = "tabDataUtama"
        tabDataUtama.Padding = New Padding(3)
        tabDataUtama.Size = New Size(777, 454)
        tabDataUtama.TabIndex = 0
        tabDataUtama.Text = "Data Utama"
        ' 
        ' tabKontak
        ' 
        tabKontak.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(45))
        tabKontak.Controls.Add(btnKeTab3)
        tabKontak.Controls.Add(btnKeTab1)
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Controls.Add(lblAlamat)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Controls.Add(lblEmail)
        tabKontak.Controls.Add(mtbTelp)
        tabKontak.Controls.Add(lblTelp)
        tabKontak.Location = New Point(4, 32)
        tabKontak.Name = "tabKontak"
        tabKontak.Padding = New Padding(3)
        tabKontak.Size = New Size(777, 454)
        tabKontak.TabIndex = 1
        tabKontak.Text = "Kontak & Info"
        ' 
        ' tabProfil
        ' 
        tabProfil.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(45))
        tabProfil.Controls.Add(btnKeTab2B)
        tabProfil.Controls.Add(btnSimpanCetak)
        tabProfil.Controls.Add(grpHobby)
        tabProfil.Controls.Add(grpPeran)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(picFoto)
        tabProfil.Location = New Point(4, 32)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(777, 454)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil & Aktivitas"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(30, 30)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(131, 23)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Lengkap"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(65))
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(200, 27)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 30)
        txtNama.TabIndex = 1
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.ForeColor = Color.White
        lblID.Location = New Point(30, 80)
        lblID.Name = "lblID"
        lblID.Size = New Size(103, 23)
        lblID.TabIndex = 2
        lblID.Text = "ID Anggota"
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(65))
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.ForeColor = Color.White
        txtID.Location = New Point(200, 77)
        txtID.Name = "txtID"
        txtID.Size = New Size(250, 30)
        txtID.TabIndex = 3
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.BackColor = Color.Transparent
        lblTgl.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTgl.ForeColor = Color.White
        lblTgl.Location = New Point(30, 130)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(119, 23)
        lblTgl.TabIndex = 4
        lblTgl.Text = "Tanggal Lahir"
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Format = DateTimePickerFormat.Short
        dtpTglLahir.Location = New Point(200, 127)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(250, 30)
        dtpTglLahir.TabIndex = 5
        ' 
        ' grpJK
        ' 
        grpJK.BackColor = Color.Transparent
        grpJK.Controls.Add(rbPerempuan)
        grpJK.Controls.Add(rbLaki)
        grpJK.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpJK.ForeColor = Color.DarkTurquoise
        grpJK.Location = New Point(30, 175)
        grpJK.Name = "grpJK"
        grpJK.Size = New Size(250, 75)
        grpJK.TabIndex = 6
        grpJK.TabStop = False
        grpJK.Text = "Jenis Kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.ForeColor = Color.White
        rbLaki.Location = New Point(15, 30)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(88, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.ForeColor = Color.White
        rbPerempuan.Location = New Point(120, 30)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(110, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.BackColor = Color.Transparent
        lblKomunitas.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKomunitas.ForeColor = Color.White
        lblKomunitas.Location = New Point(30, 270)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(157, 23)
        lblKomunitas.TabIndex = 7
        lblKomunitas.Text = "Divisi / Komunitas"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(65))
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKomunitas.ForeColor = Color.White
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Location = New Point(200, 267)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(250, 31)
        cmbKomunitas.TabIndex = 8
        ' 
        ' btnKeTab2
        ' 
        btnKeTab2.BackColor = Color.BlueViolet
        btnKeTab2.FlatStyle = FlatStyle.Flat
        btnKeTab2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeTab2.ForeColor = Color.White
        btnKeTab2.Location = New Point(610, 390)
        btnKeTab2.Name = "btnKeTab2"
        btnKeTab2.Size = New Size(130, 40)
        btnKeTab2.TabIndex = 9
        btnKeTab2.Text = "Lanjut ▶"
        btnKeTab2.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.BackColor = Color.Transparent
        lblTelp.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTelp.ForeColor = Color.White
        lblTelp.Location = New Point(30, 40)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(94, 23)
        lblTelp.TabIndex = 0
        lblTelp.Text = "Nomor HP"
        ' 
        ' mtbTelp
        ' 
        mtbTelp.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(65))
        mtbTelp.ForeColor = Color.White
        mtbTelp.Location = New Point(200, 37)
        mtbTelp.Mask = "0000-0000-0000"
        mtbTelp.Name = "mtbTelp"
        mtbTelp.Size = New Size(250, 30)
        mtbTelp.TabIndex = 1
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.Transparent
        lblEmail.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.White
        lblEmail.Location = New Point(30, 90)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 23)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(65))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(200, 87)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 30)
        txtEmail.TabIndex = 3
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamat.ForeColor = Color.White
        lblAlamat.Location = New Point(30, 140)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 23)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(65))
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.ForeColor = Color.White
        txtAlamat.Location = New Point(200, 137)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(250, 60)
        txtAlamat.TabIndex = 5
        ' 
        ' btnKeTab1
        ' 
        btnKeTab1.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(90))
        btnKeTab1.FlatStyle = FlatStyle.Flat
        btnKeTab1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeTab1.ForeColor = Color.White
        btnKeTab1.Location = New Point(460, 390)
        btnKeTab1.Name = "btnKeTab1"
        btnKeTab1.Size = New Size(130, 40)
        btnKeTab1.TabIndex = 6
        btnKeTab1.Text = "◀ Kembali"
        btnKeTab1.UseVisualStyleBackColor = False
        ' 
        ' btnKeTab3
        ' 
        btnKeTab3.BackColor = Color.BlueViolet
        btnKeTab3.FlatStyle = FlatStyle.Flat
        btnKeTab3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeTab3.ForeColor = Color.White
        btnKeTab3.Location = New Point(610, 390)
        btnKeTab3.Name = "btnKeTab3"
        btnKeTab3.Size = New Size(130, 40)
        btnKeTab3.TabIndex = 7
        btnKeTab3.Text = "Lanjut ▶"
        btnKeTab3.UseVisualStyleBackColor = False
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(65))
        picFoto.BorderStyle = BorderStyle.Fixed3D
        picFoto.Location = New Point(30, 20)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(120, 140)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DarkTurquoise
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.ForeColor = Color.FromArgb(CByte(18), CByte(18), CByte(35))
        btnBrowse.Location = New Point(30, 170)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(120, 35)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' grpPeran
        ' 
        grpPeran.BackColor = Color.Transparent
        grpPeran.Controls.Add(rbKoordinator)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Controls.Add(rbWakil)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPeran.ForeColor = Color.HotPink
        grpPeran.Location = New Point(175, 20)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(250, 160)
        grpPeran.TabIndex = 2
        grpPeran.TabStop = False
        grpPeran.Text = "Peran"
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.ForeColor = Color.White
        rbKetua.Location = New Point(15, 25)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(71, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' rbWakil
        ' 
        rbWakil.AutoSize = True
        rbWakil.ForeColor = Color.White
        rbWakil.Location = New Point(15, 55)
        rbWakil.Name = "rbWakil"
        rbWakil.Size = New Size(113, 24)
        rbWakil.TabIndex = 1
        rbWakil.TabStop = True
        rbWakil.Text = "Wakil Ketua"
        rbWakil.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.ForeColor = Color.White
        rbAdmin.Location = New Point(15, 85)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(77, 24)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.ForeColor = Color.White
        rbAnggota.Location = New Point(15, 115)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(91, 24)
        rbAnggota.TabIndex = 3
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKoordinator
        ' 
        rbKoordinator.AutoSize = True
        rbKoordinator.ForeColor = Color.White
        rbKoordinator.Location = New Point(130, 25)
        rbKoordinator.Name = "rbKoordinator"
        rbKoordinator.Size = New Size(115, 24)
        rbKoordinator.TabIndex = 4
        rbKoordinator.TabStop = True
        rbKoordinator.Text = "Koordinator"
        rbKoordinator.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.BackColor = Color.Transparent
        grpHobby.Controls.Add(chkArt)
        grpHobby.Controls.Add(chkCooking)
        grpHobby.Controls.Add(chkSports)
        grpHobby.Controls.Add(chkReading)
        grpHobby.Controls.Add(chkTravel)
        grpHobby.Controls.Add(chkPhoto)
        grpHobby.Controls.Add(chkMusic)
        grpHobby.Controls.Add(chkDesign)
        grpHobby.Controls.Add(chkCoding)
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHobby.ForeColor = Color.DarkTurquoise
        grpHobby.Location = New Point(30, 220)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(730, 130)
        grpHobby.TabIndex = 3
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby & Aktivitas"
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.ForeColor = Color.White
        chkGaming.Location = New Point(10, 30)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(86, 24)
        chkGaming.TabIndex = 0
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.ForeColor = Color.White
        chkCoding.Location = New Point(150, 30)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(80, 24)
        chkCoding.TabIndex = 1
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkDesign
        ' 
        chkDesign.AutoSize = True
        chkDesign.ForeColor = Color.White
        chkDesign.Location = New Point(290, 30)
        chkDesign.Name = "chkDesign"
        chkDesign.Size = New Size(79, 24)
        chkDesign.TabIndex = 2
        chkDesign.Text = "Design"
        chkDesign.UseVisualStyleBackColor = True
        ' 
        ' chkMusic
        ' 
        chkMusic.AutoSize = True
        chkMusic.ForeColor = Color.White
        chkMusic.Location = New Point(430, 30)
        chkMusic.Name = "chkMusic"
        chkMusic.Size = New Size(72, 24)
        chkMusic.TabIndex = 3
        chkMusic.Text = "Music"
        chkMusic.UseVisualStyleBackColor = True
        ' 
        ' chkPhoto
        ' 
        chkPhoto.AutoSize = True
        chkPhoto.ForeColor = Color.White
        chkPhoto.Location = New Point(570, 30)
        chkPhoto.Name = "chkPhoto"
        chkPhoto.Size = New Size(122, 24)
        chkPhoto.TabIndex = 4
        chkPhoto.Text = "Photography"
        chkPhoto.UseVisualStyleBackColor = True
        ' 
        ' chkTravel
        ' 
        chkTravel.AutoSize = True
        chkTravel.ForeColor = Color.White
        chkTravel.Location = New Point(10, 70)
        chkTravel.Name = "chkTravel"
        chkTravel.Size = New Size(95, 24)
        chkTravel.TabIndex = 5
        chkTravel.Text = "Traveling"
        chkTravel.UseVisualStyleBackColor = True
        ' 
        ' chkReading
        ' 
        chkReading.AutoSize = True
        chkReading.ForeColor = Color.White
        chkReading.Location = New Point(150, 70)
        chkReading.Name = "chkReading"
        chkReading.Size = New Size(88, 24)
        chkReading.TabIndex = 6
        chkReading.Text = "Reading"
        chkReading.UseVisualStyleBackColor = True
        ' 
        ' chkSports
        ' 
        chkSports.AutoSize = True
        chkSports.ForeColor = Color.White
        chkSports.Location = New Point(290, 70)
        chkSports.Name = "chkSports"
        chkSports.Size = New Size(76, 24)
        chkSports.TabIndex = 7
        chkSports.Text = "Sports"
        chkSports.UseVisualStyleBackColor = True
        ' 
        ' chkCooking
        ' 
        chkCooking.AutoSize = True
        chkCooking.ForeColor = Color.White
        chkCooking.Location = New Point(430, 70)
        chkCooking.Name = "chkCooking"
        chkCooking.Size = New Size(88, 24)
        chkCooking.TabIndex = 8
        chkCooking.Text = "Cooking"
        chkCooking.UseVisualStyleBackColor = True
        ' 
        ' chkArt
        ' 
        chkArt.AutoSize = True
        chkArt.ForeColor = Color.White
        chkArt.Location = New Point(570, 70)
        chkArt.Name = "chkArt"
        chkArt.Size = New Size(54, 24)
        chkArt.TabIndex = 9
        chkArt.Text = "Art"
        chkArt.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.HotPink
        btnSimpanCetak.FlatStyle = FlatStyle.Flat
        btnSimpanCetak.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanCetak.ForeColor = Color.White
        btnSimpanCetak.Location = New Point(490, 380)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(250, 50)
        btnSimpanCetak.TabIndex = 4
        btnSimpanCetak.Text = "Simpan Dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' btnKeTab2B
        ' 
        btnKeTab2B.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(90))
        btnKeTab2B.FlatStyle = FlatStyle.Flat
        btnKeTab2B.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeTab2B.ForeColor = Color.White
        btnKeTab2B.Location = New Point(340, 380)
        btnKeTab2B.Name = "btnKeTab2B"
        btnKeTab2B.Size = New Size(130, 50)
        btnKeTab2B.TabIndex = 5
        btnKeTab2B.Text = "◀ Kembali"
        btnKeTab2B.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(35))
        ClientSize = New Size(802, 633)
        Controls.Add(TabControl1)
        Controls.Add(pnlHeader)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NEXUS Community Card"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        tabDataUtama.ResumeLayout(False)
        tabDataUtama.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        grpJK.ResumeLayout(False)
        grpJK.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuInputData As ToolStripMenuItem
    Friend WithEvents mnuLihatKartu As ToolStripMenuItem
    Friend WithEvents mnuSimpanData As ToolStripMenuItem
    Friend WithEvents mnuBukaData As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblSubJudul As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDataUtama As TabPage
    Friend WithEvents tabKontak As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents lblTgl As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents grpJK As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents btnKeTab2 As Button
    Friend WithEvents lblTelp As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents mtbTelp As MaskedTextBox
    Friend WithEvents btnKeTab3 As Button
    Friend WithEvents btnKeTab1 As Button
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents rbKoordinator As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbWakil As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents chkArt As CheckBox
    Friend WithEvents chkCooking As CheckBox
    Friend WithEvents chkSports As CheckBox
    Friend WithEvents chkReading As CheckBox
    Friend WithEvents chkTravel As CheckBox
    Friend WithEvents chkPhoto As CheckBox
    Friend WithEvents chkMusic As CheckBox
    Friend WithEvents chkDesign As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents btnKeTab2B As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
