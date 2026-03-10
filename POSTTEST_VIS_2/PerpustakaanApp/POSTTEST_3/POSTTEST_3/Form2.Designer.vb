<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        pnlHeader = New Panel()
        lblJudul1 = New Label()
        pnlFooter = New Panel()
        lblFooter = New Label()
        picHasil = New PictureBox()
        lblJNama = New Label()
        lblJUmur = New Label()
        lblJTgl = New Label()
        lblJJK = New Label()
        lblJTelp = New Label()
        lblJHobby = New Label()
        lblJAlamat = New Label()
        lblNama = New Label()
        lblUmur = New Label()
        lblTgl = New Label()
        lblJK = New Label()
        lblTelp = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        pnlStripe1 = New Panel()
        pnlStripe2 = New Panel()
        lblSubtitle = New Label()
        pnlStripe3 = New Panel()
        lblIDCard = New Label()
        pnlGaris = New Panel()
        pnlHeader.SuspendLayout()
        pnlFooter.SuspendLayout()
        CType(picHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(210), CByte(160), CByte(40))
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(pnlStripe2)
        pnlHeader.Controls.Add(pnlStripe1)
        pnlHeader.Controls.Add(lblJudul1)
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(620, 70)
        pnlHeader.TabIndex = 0
        ' 
        ' lblJudul1
        ' 
        lblJudul1.BackColor = Color.Transparent
        lblJudul1.Font = New Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul1.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblJudul1.Location = New Point(9, 5)
        lblJudul1.Name = "lblJudul1"
        lblJudul1.Size = New Size(620, 60)
        lblJudul1.TabIndex = 0
        lblJudul1.Text = "BIKINI BOTTOM"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(210), CByte(160), CByte(40))
        pnlFooter.Controls.Add(lblFooter)
        pnlFooter.Location = New Point(0, 355)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(620, 50)
        pnlFooter.TabIndex = 1
        ' 
        ' lblFooter
        ' 
        lblFooter.BackColor = Color.Transparent
        lblFooter.Font = New Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFooter.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblFooter.Location = New Point(120, -5)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(620, 40)
        lblFooter.TabIndex = 2
        lblFooter.Text = "COMMUNITY IDENTIFICATION"
        ' 
        ' picHasil
        ' 
        picHasil.BackColor = Color.FromArgb(CByte(200), CByte(190), CByte(220))
        picHasil.BorderStyle = BorderStyle.Fixed3D
        picHasil.Location = New Point(20, 85)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(155, 185)
        picHasil.SizeMode = PictureBoxSizeMode.Zoom
        picHasil.TabIndex = 2
        picHasil.TabStop = False
        ' 
        ' lblJNama
        ' 
        lblJNama.AutoSize = True
        lblJNama.BackColor = Color.Transparent
        lblJNama.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJNama.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblJNama.Location = New Point(185, 80)
        lblJNama.Name = "lblJNama"
        lblJNama.Size = New Size(77, 25)
        lblJNama.TabIndex = 3
        lblJNama.Text = "Nama :"
        ' 
        ' lblJUmur
        ' 
        lblJUmur.AutoSize = True
        lblJUmur.BackColor = Color.Transparent
        lblJUmur.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJUmur.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblJUmur.Location = New Point(185, 115)
        lblJUmur.Name = "lblJUmur"
        lblJUmur.Size = New Size(69, 25)
        lblJUmur.TabIndex = 4
        lblJUmur.Text = "Umur :"
        ' 
        ' lblJTgl
        ' 
        lblJTgl.AutoSize = True
        lblJTgl.BackColor = Color.Transparent
        lblJTgl.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJTgl.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblJTgl.Location = New Point(185, 150)
        lblJTgl.Name = "lblJTgl"
        lblJTgl.Size = New Size(136, 25)
        lblJTgl.TabIndex = 5
        lblJTgl.Text = "Tanggal Lahir :"
        ' 
        ' lblJJK
        ' 
        lblJJK.AutoSize = True
        lblJJK.BackColor = Color.Transparent
        lblJJK.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJJK.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblJJK.Location = New Point(185, 185)
        lblJJK.Name = "lblJJK"
        lblJJK.Size = New Size(129, 23)
        lblJJK.TabIndex = 6
        lblJJK.Text = "Jenis Kelamin :"
        ' 
        ' lblJTelp
        ' 
        lblJTelp.AutoSize = True
        lblJTelp.BackColor = Color.Transparent
        lblJTelp.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJTelp.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblJTelp.Location = New Point(185, 220)
        lblJTelp.Name = "lblJTelp"
        lblJTelp.Size = New Size(110, 23)
        lblJTelp.TabIndex = 7
        lblJTelp.Text = "No Telepon :"
        ' 
        ' lblJHobby
        ' 
        lblJHobby.AutoSize = True
        lblJHobby.BackColor = Color.Transparent
        lblJHobby.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJHobby.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblJHobby.Location = New Point(185, 255)
        lblJHobby.Name = "lblJHobby"
        lblJHobby.Size = New Size(77, 25)
        lblJHobby.TabIndex = 8
        lblJHobby.Text = "Hobby :"
        ' 
        ' lblJAlamat
        ' 
        lblJAlamat.AutoSize = True
        lblJAlamat.BackColor = Color.Transparent
        lblJAlamat.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJAlamat.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblJAlamat.Location = New Point(185, 300)
        lblJAlamat.Name = "lblJAlamat"
        lblJAlamat.Size = New Size(78, 23)
        lblJAlamat.TabIndex = 9
        lblJAlamat.Text = "Alamat :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.Black
        lblNama.Location = New Point(340, 80)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(15, 22)
        lblNama.TabIndex = 10
        lblNama.Text = "-"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUmur.ForeColor = Color.Black
        lblUmur.Location = New Point(340, 115)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(15, 22)
        lblUmur.TabIndex = 11
        lblUmur.Text = "-"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.BackColor = Color.Transparent
        lblTgl.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTgl.ForeColor = Color.Black
        lblTgl.Location = New Point(340, 150)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(15, 22)
        lblTgl.TabIndex = 12
        lblTgl.Text = "-"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.BackColor = Color.Transparent
        lblJK.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJK.ForeColor = Color.Black
        lblJK.Location = New Point(340, 185)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(15, 22)
        lblJK.TabIndex = 13
        lblJK.Text = "-"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.BackColor = Color.Transparent
        lblTelp.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTelp.ForeColor = Color.Black
        lblTelp.Location = New Point(340, 220)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(15, 22)
        lblTelp.TabIndex = 14
        lblTelp.Text = "-"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = Color.Transparent
        lblHobby.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHobby.ForeColor = Color.Black
        lblHobby.Location = New Point(340, 255)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(15, 22)
        lblHobby.TabIndex = 15
        lblHobby.Text = "-"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAlamat.ForeColor = Color.Black
        lblAlamat.Location = New Point(340, 300)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(15, 22)
        lblAlamat.TabIndex = 16
        lblAlamat.Text = "-"
        ' 
        ' pnlStripe1
        ' 
        pnlStripe1.BackColor = Color.FromArgb(CByte(160), CByte(110), CByte(20))
        pnlStripe1.Location = New Point(0, 0)
        pnlStripe1.Name = "pnlStripe1"
        pnlStripe1.Size = New Size(620, 12)
        pnlStripe1.TabIndex = 1
        ' 
        ' pnlStripe2
        ' 
        pnlStripe2.BackColor = Color.FromArgb(CByte(160), CByte(110), CByte(20))
        pnlStripe2.Location = New Point(0, 58)
        pnlStripe2.Name = "pnlStripe2"
        pnlStripe2.Size = New Size(620, 12)
        pnlStripe2.TabIndex = 2
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.BackColor = Color.Transparent
        lblSubtitle.Font = New Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(80))
        lblSubtitle.Location = New Point(430, 25)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(164, 20)
        lblSubtitle.TabIndex = 3
        lblSubtitle.Text = "COMMUNITY CARD"
        ' 
        ' pnlStripe3
        ' 
        pnlStripe3.BackColor = Color.FromArgb(CByte(160), CByte(110), CByte(20))
        pnlStripe3.Location = New Point(0, 345)
        pnlStripe3.Name = "pnlStripe3"
        pnlStripe3.Size = New Size(620, 10)
        pnlStripe3.TabIndex = 3
        ' 
        ' lblIDCard
        ' 
        lblIDCard.AutoSize = True
        lblIDCard.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIDCard.ForeColor = Color.FromArgb(CByte(0), CByte(150), CByte(0))
        lblIDCard.Location = New Point(65, 273)
        lblIDCard.Name = "lblIDCard"
        lblIDCard.Size = New Size(64, 18)
        lblIDCard.TabIndex = 17
        lblIDCard.Text = "B1-2024"
        ' 
        ' pnlGaris
        ' 
        pnlGaris.BackColor = Color.FromArgb(CByte(160), CByte(110), CByte(20))
        pnlGaris.Location = New Point(185, 75)
        pnlGaris.Name = "pnlGaris"
        pnlGaris.Size = New Size(415, 3)
        pnlGaris.TabIndex = 18
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(235), CByte(200))
        ClientSize = New Size(602, 383)
        Controls.Add(pnlGaris)
        Controls.Add(lblIDCard)
        Controls.Add(pnlStripe3)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(lblTelp)
        Controls.Add(lblJK)
        Controls.Add(lblTgl)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(lblJAlamat)
        Controls.Add(lblJHobby)
        Controls.Add(lblJTelp)
        Controls.Add(lblJJK)
        Controls.Add(lblJTgl)
        Controls.Add(lblJUmur)
        Controls.Add(lblJNama)
        Controls.Add(picHasil)
        Controls.Add(pnlFooter)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bikini Bottom Community Card"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlFooter.ResumeLayout(False)
        CType(picHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul1 As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblFooter As Label
    Friend WithEvents picHasil As PictureBox
    Friend WithEvents lblJNama As Label
    Friend WithEvents lblJUmur As Label
    Friend WithEvents lblJTgl As Label
    Friend WithEvents lblJJK As Label
    Friend WithEvents lblJTelp As Label
    Friend WithEvents lblJHobby As Label
    Friend WithEvents lblJAlamat As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents pnlStripe1 As Panel
    Friend WithEvents pnlStripe2 As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlStripe3 As Panel
    Friend WithEvents lblIDCard As Label
    Friend WithEvents pnlGaris As Panel
End Class
