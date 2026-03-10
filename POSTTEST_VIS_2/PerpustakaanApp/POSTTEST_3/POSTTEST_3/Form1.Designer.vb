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
        picFoto = New PictureBox()
        lblHeader = New Label()
        lblNama = New Label()
        txtNama = New TextBox()
        lblUmur = New Label()
        txtUmur = New TextBox()
        lblTgl = New Label()
        dtpTanggal = New DateTimePicker()
        lblTelp = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        txtTelp = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        grpJK = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grpHobby = New GroupBox()
        chkFotografi = New CheckBox()
        chkMenulis = New CheckBox()
        chkMenyanyi = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMembaca = New CheckBox()
        chkMenggambar = New CheckBox()
        chkMusik = New CheckBox()
        chkMasak = New CheckBox()
        chkCoding = New CheckBox()
        chkGaming = New CheckBox()
        btnBrowse = New Button()
        btnCetak = New Button()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpJK.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.White
        picFoto.BorderStyle = BorderStyle.Fixed3D
        picFoto.Location = New Point(20, 60)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(160, 180)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.FromArgb(CByte(34), CByte(85), CByte(150))
        lblHeader.Font = New Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(780, 50)
        lblHeader.TabIndex = 1
        lblHeader.Text = "BIKINI BOTTOM"
        lblHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(200, 70)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(71, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(336, 67)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 27)
        txtNama.TabIndex = 3
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(200, 105)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(69, 25)
        lblUmur.TabIndex = 4
        lblUmur.Text = "Umur :"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(336, 102)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(200, 27)
        txtUmur.TabIndex = 5
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTgl.Location = New Point(200, 140)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(136, 25)
        lblTgl.TabIndex = 6
        lblTgl.Text = "Tanggal Lahir :"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(336, 140)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(200, 27)
        dtpTanggal.TabIndex = 7
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTelp.Location = New Point(200, 175)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(110, 25)
        lblTelp.TabIndex = 8
        lblTelp.Text = "No Telpon :"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(0, 0)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(125, 27)
        MaskedTextBox1.TabIndex = 9
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(336, 175)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(200, 27)
        txtTelp.TabIndex = 10
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(200, 210)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(82, 25)
        lblAlamat.TabIndex = 11
        lblAlamat.Text = "Alamat :"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(336, 213)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(200, 27)
        txtAlamat.TabIndex = 12
        ' 
        ' grpJK
        ' 
        grpJK.Controls.Add(rbPerempuan)
        grpJK.Controls.Add(rbLaki)
        grpJK.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpJK.Location = New Point(200, 245)
        grpJK.Name = "grpJK"
        grpJK.Size = New Size(150, 80)
        grpJK.TabIndex = 13
        grpJK.TabStop = False
        grpJK.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(10, 45)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(106, 25)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(10, 20)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(94, 25)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(chkFotografi)
        grpHobby.Controls.Add(chkMenulis)
        grpHobby.Controls.Add(chkMenyanyi)
        grpHobby.Controls.Add(chkOlahraga)
        grpHobby.Controls.Add(chkMembaca)
        grpHobby.Controls.Add(chkMenggambar)
        grpHobby.Controls.Add(chkMusik)
        grpHobby.Controls.Add(chkMasak)
        grpHobby.Controls.Add(chkCoding)
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHobby.Location = New Point(370, 245)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(370, 200)
        grpHobby.TabIndex = 14
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Location = New Point(190, 125)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(99, 25)
        chkFotografi.TabIndex = 9
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Location = New Point(190, 100)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(84, 25)
        chkMenulis.TabIndex = 8
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkMenyanyi
        ' 
        chkMenyanyi.AutoSize = True
        chkMenyanyi.Location = New Point(190, 75)
        chkMenyanyi.Name = "chkMenyanyi"
        chkMenyanyi.Size = New Size(97, 25)
        chkMenyanyi.TabIndex = 7
        chkMenyanyi.Text = "Menyanyi"
        chkMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Location = New Point(190, 50)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(96, 25)
        chkOlahraga.TabIndex = 6
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.Location = New Point(190, 25)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(98, 25)
        chkMembaca.TabIndex = 5
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' chkMenggambar
        ' 
        chkMenggambar.AutoSize = True
        chkMenggambar.Location = New Point(10, 125)
        chkMenggambar.Name = "chkMenggambar"
        chkMenggambar.Size = New Size(121, 25)
        chkMenggambar.TabIndex = 4
        chkMenggambar.Text = "Menggambar"
        chkMenggambar.UseVisualStyleBackColor = True
        ' 
        ' chkMusik
        ' 
        chkMusik.AutoSize = True
        chkMusik.Location = New Point(10, 100)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(72, 25)
        chkMusik.TabIndex = 3
        chkMusik.Text = "Musik"
        chkMusik.UseVisualStyleBackColor = True
        ' 
        ' chkMasak
        ' 
        chkMasak.AutoSize = True
        chkMasak.Location = New Point(10, 75)
        chkMasak.Name = "chkMasak"
        chkMasak.Size = New Size(96, 25)
        chkMasak.TabIndex = 2
        chkMasak.Text = "Memasak"
        chkMasak.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(10, 50)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(78, 25)
        chkCoding.TabIndex = 1
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Location = New Point(10, 25)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(82, 25)
        chkGaming.TabIndex = 0
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(CByte(34), CByte(85), CByte(150))
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(20, 250)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(160, 35)
        btnBrowse.TabIndex = 10
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCetak.BackColor = Color.FromArgb(CByte(34), CByte(85), CByte(150))
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(20, 460)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(720, 40)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(223), CByte(100))
        ClientSize = New Size(762, 513)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Controls.Add(grpHobby)
        Controls.Add(grpJK)
        Controls.Add(txtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(txtTelp)
        Controls.Add(MaskedTextBox1)
        Controls.Add(lblTelp)
        Controls.Add(dtpTanggal)
        Controls.Add(lblTgl)
        Controls.Add(txtUmur)
        Controls.Add(lblUmur)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(lblHeader)
        Controls.Add(picFoto)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bikini Bottom Community Card"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpJK.ResumeLayout(False)
        grpJK.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblUmur As Label
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents lblTgl As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lblTelp As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents grpJK As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents chkMenggambar As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkMasak As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkMenyanyi As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button

End Class
