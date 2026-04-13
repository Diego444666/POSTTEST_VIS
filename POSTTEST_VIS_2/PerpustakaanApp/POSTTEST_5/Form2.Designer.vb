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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        lblTotal = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        lblRata = New Label()
        Panel4 = New Panel()
        Label4 = New Label()
        lblTertinggi = New Label()
        Panel5 = New Panel()
        Label5 = New Label()
        lblTerendah = New Label()
        dgvDashboard = New DataGridView()
        btnKembali = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        CType(dgvDashboard, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(720, 70)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 38)
        Label1.TabIndex = 0
        Label1.Text = "DASHBOARD NILAI SISWA"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(lblTotal)
        Panel2.Location = New Point(15, 85)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(160, 80)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.FromArgb(CByte(180), CByte(210), CByte(255))
        Label2.Location = New Point(35, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 1
        Label2.Text = "Total Data"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.Transparent
        lblTotal.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.White
        lblTotal.Location = New Point(50, 10)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(43, 50)
        lblTotal.TabIndex = 0
        lblTotal.Text = "0"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(140), CByte(0))
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(lblRata)
        Panel3.Location = New Point(190, 85)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(160, 80)
        Panel3.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(200), CByte(255), CByte(200))
        Label3.Location = New Point(40, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 1
        Label3.Text = "Rata-rata"
        ' 
        ' lblRata
        ' 
        lblRata.AutoSize = True
        lblRata.BackColor = Color.Transparent
        lblRata.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRata.ForeColor = Color.White
        lblRata.Location = New Point(50, 10)
        lblRata.Name = "lblRata"
        lblRata.Size = New Size(43, 50)
        lblRata.TabIndex = 0
        lblRata.Text = "0"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(200), CByte(120), CByte(0))
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(lblTertinggi)
        Panel4.Location = New Point(365, 85)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(160, 80)
        Panel4.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(235), CByte(180))
        Label4.Location = New Point(42, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 20)
        Label4.TabIndex = 1
        Label4.Text = "Tertinggi"
        ' 
        ' lblTertinggi
        ' 
        lblTertinggi.AutoSize = True
        lblTertinggi.BackColor = Color.Transparent
        lblTertinggi.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTertinggi.ForeColor = Color.White
        lblTertinggi.Location = New Point(50, 10)
        lblTertinggi.Name = "lblTertinggi"
        lblTertinggi.Size = New Size(43, 50)
        lblTertinggi.TabIndex = 0
        lblTertinggi.Text = "0"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(180), CByte(50), CByte(50))
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(lblTerendah)
        Panel5.Location = New Point(540, 85)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(160, 80)
        Panel5.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(200))
        Label5.Location = New Point(42, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 1
        Label5.Text = "Terendah"
        ' 
        ' lblTerendah
        ' 
        lblTerendah.AutoSize = True
        lblTerendah.BackColor = Color.Transparent
        lblTerendah.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTerendah.ForeColor = Color.White
        lblTerendah.Location = New Point(50, 10)
        lblTerendah.Name = "lblTerendah"
        lblTerendah.Size = New Size(43, 50)
        lblTerendah.TabIndex = 0
        lblTerendah.Text = "0"
        ' 
        ' dgvDashboard
        ' 
        dgvDashboard.AllowUserToAddRows = False
        dgvDashboard.BackgroundColor = Color.White
        dgvDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDashboard.Location = New Point(15, 180)
        dgvDashboard.Name = "dgvDashboard"
        dgvDashboard.ReadOnly = True
        dgvDashboard.RowHeadersWidth = 51
        dgvDashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDashboard.Size = New Size(685, 245)
        dgvDashboard.TabIndex = 5
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(25), CByte(50), CByte(120))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(15, 431)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(130, 35)
        btnKembali.TabIndex = 6
        btnKembali.Text = "◀ Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(255))
        ClientSize = New Size(702, 473)
        Controls.Add(btnKembali)
        Controls.Add(dgvDashboard)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard Nilai Siswa"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(dgvDashboard, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRata As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTertinggi As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTerendah As Label
    Friend WithEvents dgvDashboard As DataGridView
    Friend WithEvents btnKembali As Button
End Class
