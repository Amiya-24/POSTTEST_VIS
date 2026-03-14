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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pbProfil = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTgl = New Label()
        lblGender = New Label()
        lblNoTelp = New Label()
        lblHobi = New Label()
        txtNama = New TextBox()
        txtNoTelp = New TextBox()
        txtGender = New TextBox()
        txtHobi = New TextBox()
        txtTgl = New TextBox()
        txtUmur = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbProfil
        ' 
        pbProfil.BackColor = Color.White
        pbProfil.Location = New Point(46, 106)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(200, 257)
        pbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.White
        lblNama.Location = New Point(263, 106)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(45, 15)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama :"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.White
        lblUmur.Location = New Point(263, 144)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(43, 15)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur :"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.BackColor = Color.White
        lblTgl.Location = New Point(263, 182)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(84, 15)
        lblTgl.TabIndex = 3
        lblTgl.Text = "Tanggal Lahir :"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.White
        lblGender.Location = New Point(263, 221)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(84, 15)
        lblGender.TabIndex = 4
        lblGender.Text = "Jenis Kelamin :"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.BackColor = Color.White
        lblNoTelp.Location = New Point(263, 259)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(71, 15)
        lblNoTelp.TabIndex = 5
        lblNoTelp.Text = "No. Telpon :"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.BackColor = Color.White
        lblHobi.Location = New Point(263, 298)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(43, 15)
        lblHobi.TabIndex = 6
        lblHobi.Text = "Hobby"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.White
        txtNama.Location = New Point(375, 103)
        txtNama.Name = "txtNama"
        txtNama.ReadOnly = True
        txtNama.Size = New Size(200, 23)
        txtNama.TabIndex = 7
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.BackColor = Color.White
        txtNoTelp.Location = New Point(375, 256)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.ReadOnly = True
        txtNoTelp.Size = New Size(200, 23)
        txtNoTelp.TabIndex = 8
        ' 
        ' txtGender
        ' 
        txtGender.BackColor = Color.White
        txtGender.Location = New Point(375, 218)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(200, 23)
        txtGender.TabIndex = 9
        ' 
        ' txtHobi
        ' 
        txtHobi.BackColor = Color.White
        txtHobi.Location = New Point(375, 295)
        txtHobi.Name = "txtHobi"
        txtHobi.ReadOnly = True
        txtHobi.Size = New Size(200, 23)
        txtHobi.TabIndex = 10
        ' 
        ' txtTgl
        ' 
        txtTgl.BackColor = Color.White
        txtTgl.Location = New Point(375, 179)
        txtTgl.Name = "txtTgl"
        txtTgl.ReadOnly = True
        txtTgl.Size = New Size(200, 23)
        txtTgl.TabIndex = 11
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.White
        txtUmur.Location = New Point(375, 141)
        txtUmur.Name = "txtUmur"
        txtUmur.ReadOnly = True
        txtUmur.Size = New Size(200, 23)
        txtUmur.TabIndex = 12
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.White
        lblAlamat.Location = New Point(263, 343)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(45, 15)
        lblAlamat.TabIndex = 13
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.White
        txtAlamat.Location = New Point(375, 340)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.ReadOnly = True
        txtAlamat.Size = New Size(200, 23)
        txtAlamat.TabIndex = 14
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(txtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(txtUmur)
        Controls.Add(txtTgl)
        Controls.Add(txtHobi)
        Controls.Add(txtGender)
        Controls.Add(txtNoTelp)
        Controls.Add(txtNama)
        Controls.Add(lblHobi)
        Controls.Add(lblNoTelp)
        Controls.Add(lblGender)
        Controls.Add(lblTgl)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(pbProfil)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Form2"
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtHobi As TextBox
    Friend WithEvents txtTgl As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
End Class
