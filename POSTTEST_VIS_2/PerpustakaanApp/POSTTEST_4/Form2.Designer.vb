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
        pnlCard = New Panel()
        pnlCardHeader = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        picHasil = New PictureBox()
        pnlGaris = New Panel()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblPeran = New Label()
        lblTelp = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        lblJNama = New Label()
        lblJID = New Label()
        lblJKomunitas = New Label()
        lblJPeran = New Label()
        lblJTelp = New Label()
        lblJHobby = New Label()
        lblJAlamat = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        btnKembali = New Button()
        pnlCard.SuspendLayout()
        pnlCardHeader.SuspendLayout()
        CType(picHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(55))
        pnlCard.BorderStyle = BorderStyle.FixedSingle
        pnlCard.Controls.Add(btnKembali)
        pnlCard.Controls.Add(Panel1)
        pnlCard.Controls.Add(lblJAlamat)
        pnlCard.Controls.Add(lblJHobby)
        pnlCard.Controls.Add(lblJTelp)
        pnlCard.Controls.Add(lblJPeran)
        pnlCard.Controls.Add(lblJKomunitas)
        pnlCard.Controls.Add(lblJID)
        pnlCard.Controls.Add(lblJNama)
        pnlCard.Controls.Add(lblAlamat)
        pnlCard.Controls.Add(lblHobby)
        pnlCard.Controls.Add(lblTelp)
        pnlCard.Controls.Add(lblPeran)
        pnlCard.Controls.Add(lblKomunitas)
        pnlCard.Controls.Add(lblID)
        pnlCard.Controls.Add(lblNama)
        pnlCard.Controls.Add(pnlGaris)
        pnlCard.Controls.Add(picHasil)
        pnlCard.Controls.Add(pnlCardHeader)
        pnlCard.Location = New Point(15, 21)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(575, 390)
        pnlCard.TabIndex = 0
        ' 
        ' pnlCardHeader
        ' 
        pnlCardHeader.BackColor = Color.BlueViolet
        pnlCardHeader.Controls.Add(Label3)
        pnlCardHeader.Controls.Add(Label2)
        pnlCardHeader.Controls.Add(Label1)
        pnlCardHeader.Location = New Point(0, 0)
        pnlCardHeader.Name = "pnlCardHeader"
        pnlCardHeader.Size = New Size(575, 60)
        pnlCardHeader.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(15, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(294, 38)
        Label1.TabIndex = 0
        Label1.Text = "NEXUS COMMUNITY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.DarkTurquoise
        Label2.Location = New Point(19, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 20)
        Label2.TabIndex = 1
        Label2.Text = "MEMBER ID CARD"
        ' 
        ' picHasil
        ' 
        picHasil.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(65))
        picHasil.BorderStyle = BorderStyle.Fixed3D
        picHasil.Location = New Point(20, 80)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(130, 155)
        picHasil.SizeMode = PictureBoxSizeMode.Zoom
        picHasil.TabIndex = 1
        picHasil.TabStop = False
        ' 
        ' pnlGaris
        ' 
        pnlGaris.BackColor = Color.DarkTurquoise
        pnlGaris.Location = New Point(165, 67)
        pnlGaris.Name = "pnlGaris"
        pnlGaris.Size = New Size(3, 290)
        pnlGaris.TabIndex = 2
        ' 
        ' lblNama
        ' 
        lblNama.BackColor = Color.Transparent
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(290, 80)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(260, 20)
        lblNama.TabIndex = 3
        lblNama.Text = "-"
        ' 
        ' lblID
        ' 
        lblID.BackColor = Color.Transparent
        lblID.ForeColor = Color.White
        lblID.Location = New Point(290, 115)
        lblID.Name = "lblID"
        lblID.Size = New Size(260, 20)
        lblID.TabIndex = 4
        lblID.Text = "-"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.BackColor = Color.Transparent
        lblKomunitas.ForeColor = Color.White
        lblKomunitas.Location = New Point(290, 150)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(260, 20)
        lblKomunitas.TabIndex = 5
        lblKomunitas.Text = "-"
        ' 
        ' lblPeran
        ' 
        lblPeran.BackColor = Color.Transparent
        lblPeran.ForeColor = Color.White
        lblPeran.Location = New Point(290, 185)
        lblPeran.Name = "lblPeran"
        lblPeran.Size = New Size(260, 20)
        lblPeran.TabIndex = 6
        lblPeran.Text = "-"
        ' 
        ' lblTelp
        ' 
        lblTelp.BackColor = Color.Transparent
        lblTelp.ForeColor = Color.White
        lblTelp.Location = New Point(290, 220)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(260, 20)
        lblTelp.TabIndex = 7
        lblTelp.Text = "-"
        ' 
        ' lblHobby
        ' 
        lblHobby.BackColor = Color.Transparent
        lblHobby.ForeColor = Color.White
        lblHobby.Location = New Point(290, 255)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(260, 20)
        lblHobby.TabIndex = 8
        lblHobby.Text = "-"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.ForeColor = Color.White
        lblAlamat.Location = New Point(290, 305)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(260, 20)
        lblAlamat.TabIndex = 9
        lblAlamat.Text = "-"
        ' 
        ' lblJNama
        ' 
        lblJNama.AutoSize = True
        lblJNama.BackColor = Color.Transparent
        lblJNama.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJNama.ForeColor = Color.DarkTurquoise
        lblJNama.Location = New Point(201, 80)
        lblJNama.Name = "lblJNama"
        lblJNama.Size = New Size(51, 20)
        lblJNama.TabIndex = 10
        lblJNama.Text = "Nama"
        ' 
        ' lblJID
        ' 
        lblJID.AutoSize = True
        lblJID.BackColor = Color.Transparent
        lblJID.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJID.ForeColor = Color.DarkTurquoise
        lblJID.Location = New Point(201, 115)
        lblJID.Name = "lblJID"
        lblJID.Size = New Size(90, 20)
        lblJID.TabIndex = 11
        lblJID.Text = "ID Anggota"
        ' 
        ' lblJKomunitas
        ' 
        lblJKomunitas.AutoSize = True
        lblJKomunitas.BackColor = Color.Transparent
        lblJKomunitas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJKomunitas.ForeColor = Color.DarkTurquoise
        lblJKomunitas.Location = New Point(201, 150)
        lblJKomunitas.Name = "lblJKomunitas"
        lblJKomunitas.Size = New Size(85, 20)
        lblJKomunitas.TabIndex = 12
        lblJKomunitas.Text = "Komunitas"
        ' 
        ' lblJPeran
        ' 
        lblJPeran.AutoSize = True
        lblJPeran.BackColor = Color.Transparent
        lblJPeran.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJPeran.ForeColor = Color.DarkTurquoise
        lblJPeran.Location = New Point(201, 185)
        lblJPeran.Name = "lblJPeran"
        lblJPeran.Size = New Size(49, 20)
        lblJPeran.TabIndex = 13
        lblJPeran.Text = "Peran"
        ' 
        ' lblJTelp
        ' 
        lblJTelp.AutoSize = True
        lblJTelp.BackColor = Color.Transparent
        lblJTelp.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJTelp.ForeColor = Color.DarkTurquoise
        lblJTelp.Location = New Point(201, 220)
        lblJTelp.Name = "lblJTelp"
        lblJTelp.Size = New Size(58, 20)
        lblJTelp.TabIndex = 14
        lblJTelp.Text = "No. HP"
        ' 
        ' lblJHobby
        ' 
        lblJHobby.AutoSize = True
        lblJHobby.BackColor = Color.Transparent
        lblJHobby.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJHobby.ForeColor = Color.DarkTurquoise
        lblJHobby.Location = New Point(201, 255)
        lblJHobby.Name = "lblJHobby"
        lblJHobby.Size = New Size(55, 20)
        lblJHobby.TabIndex = 15
        lblJHobby.Text = "Hobby"
        ' 
        ' lblJAlamat
        ' 
        lblJAlamat.AutoSize = True
        lblJAlamat.BackColor = Color.Transparent
        lblJAlamat.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJAlamat.ForeColor = Color.DarkTurquoise
        lblJAlamat.Location = New Point(201, 305)
        lblJAlamat.Name = "lblJAlamat"
        lblJAlamat.Size = New Size(60, 20)
        lblJAlamat.TabIndex = 16
        lblJAlamat.Text = "Alamat"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.BlueViolet
        Panel1.Location = New Point(0, 360)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(575, 30)
        Panel1.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(147, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(214, 20)
        Label3.TabIndex = 18
        Label3.Text = "✦ NEXUS COMMUNITY 2026 ✦"
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(90))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(20, 305)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(130, 38)
        btnKembali.TabIndex = 18
        btnKembali.Text = "◀ Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(35))
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(602, 433)
        Controls.Add(pnlCard)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NEXUS ID Card"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlCardHeader.ResumeLayout(False)
        pnlCardHeader.PerformLayout()
        CType(picHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard As Panel
    Friend WithEvents pnlCardHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlGaris As Panel
    Friend WithEvents picHasil As PictureBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblPeran As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblJAlamat As Label
    Friend WithEvents lblJHobby As Label
    Friend WithEvents lblJTelp As Label
    Friend WithEvents lblJPeran As Label
    Friend WithEvents lblJKomunitas As Label
    Friend WithEvents lblJID As Label
    Friend WithEvents lblJNama As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label3 As Label
End Class
