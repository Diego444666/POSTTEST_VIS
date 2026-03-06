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
        GroupBox1 = New GroupBox()
        btnSimpan = New Button()
        txtKategori = New TextBox()
        Label2 = New Label()
        txtNama = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        btnBuang = New Button()
        txtHapus = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtTampilan = New TextBox()
        PictureBox2 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(btnSimpan)
        GroupBox1.Controls.Add(txtKategori)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(20, 54)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(260, 140)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input Buku"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = SystemColors.HotTrack
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = SystemColors.ButtonHighlight
        btnSimpan.Location = New Point(105, 93)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' txtKategori
        ' 
        txtKategori.BackColor = SystemColors.ButtonHighlight
        txtKategori.Location = New Point(105, 60)
        txtKategori.Name = "txtKategori"
        txtKategori.Size = New Size(125, 27)
        txtKategori.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 20)
        Label2.TabIndex = 2
        Label2.Text = "Kategori:"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = SystemColors.ButtonHighlight
        txtNama.Location = New Point(105, 23)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(38, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Control
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(btnBuang)
        GroupBox2.Controls.Add(txtHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(20, 222)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(260, 140)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Data"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources._CITYPNG_COM_The_Pusheen_Cat_Cute_Pixel_Art_HD_Transparent_Background___1500x1500
        PictureBox1.Location = New Point(6, 95)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 55)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btnBuang
        ' 
        btnBuang.BackColor = Color.Red
        btnBuang.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuang.ForeColor = SystemColors.ButtonHighlight
        btnBuang.Location = New Point(102, 93)
        btnBuang.Name = "btnBuang"
        btnBuang.Size = New Size(94, 29)
        btnBuang.TabIndex = 2
        btnBuang.Text = "Buang"
        btnBuang.UseVisualStyleBackColor = False
        ' 
        ' txtHapus
        ' 
        txtHapus.BackColor = SystemColors.ButtonHighlight
        txtHapus.Location = New Point(102, 40)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(125, 27)
        txtHapus.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(44, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 0
        Label3.Text = "Nama:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(299, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 2
        Label4.Text = "Isi Rak"
        ' 
        ' txtTampilan
        ' 
        txtTampilan.BackColor = SystemColors.Control
        txtTampilan.Location = New Point(299, 32)
        txtTampilan.Multiline = True
        txtTampilan.Name = "txtTampilan"
        txtTampilan.ReadOnly = True
        txtTampilan.ScrollBars = ScrollBars.Vertical
        txtTampilan.Size = New Size(271, 359)
        txtTampilan.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.PngItem_3031434
        PictureBox2.Location = New Point(216, -1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 55)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(582, 403)
        Controls.Add(PictureBox2)
        Controls.Add(txtTampilan)
        Controls.Add(Label4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Aplikasi Buku"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuang As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTampilan As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
