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
        pbProfil = New PictureBox()
        lblName = New Label()
        lblUmur = New Label()
        lblTgl = New Label()
        lblNoTlp = New Label()
        lblAlamat = New Label()
        btnBrowse = New Button()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtAlamat = New TextBox()
        txtTelpon = New TextBox()
        gbGender = New GroupBox()
        rbCowok = New RadioButton()
        rbCewek = New RadioButton()
        gbHobi = New GroupBox()
        chkMenari = New CheckBox()
        chkMenyanyi = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMembaca = New CheckBox()
        chkMemancing = New CheckBox()
        chkMenulis = New CheckBox()
        chkMenggambar = New CheckBox()
        chkTraveling = New CheckBox()
        chkCoding = New CheckBox()
        chkGaming = New CheckBox()
        dtptTgl = New DateTimePicker()
        btnCetakKartu = New Button()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbGender.SuspendLayout()
        gbHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbProfil
        ' 
        pbProfil.BackColor = Color.White
        pbProfil.Location = New Point(12, 26)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(250, 370)
        pbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.White
        lblName.Location = New Point(284, 43)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 1
        lblName.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.White
        lblUmur.Location = New Point(284, 81)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(37, 15)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.BackColor = Color.White
        lblTgl.Location = New Point(284, 118)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(78, 15)
        lblTgl.TabIndex = 3
        lblTgl.Text = "Tanggal Lahir"
        ' 
        ' lblNoTlp
        ' 
        lblNoTlp.AutoSize = True
        lblNoTlp.BackColor = Color.White
        lblNoTlp.Location = New Point(284, 161)
        lblNoTlp.Name = "lblNoTlp"
        lblNoTlp.Size = New Size(62, 15)
        lblNoTlp.TabIndex = 4
        lblNoTlp.Text = "No Telpon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.White
        lblAlamat.Location = New Point(284, 206)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(45, 15)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.White
        btnBrowse.FlatStyle = FlatStyle.System
        btnBrowse.ForeColor = SystemColors.ControlText
        btnBrowse.Location = New Point(89, 408)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(93, 30)
        btnBrowse.TabIndex = 6
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.White
        txtNama.Location = New Point(418, 40)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 23)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.White
        txtUmur.Location = New Point(418, 78)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(199, 23)
        txtUmur.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.White
        txtAlamat.Location = New Point(419, 203)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(199, 23)
        txtAlamat.TabIndex = 9
        ' 
        ' txtTelpon
        ' 
        txtTelpon.BackColor = Color.White
        txtTelpon.Location = New Point(417, 158)
        txtTelpon.Name = "txtTelpon"
        txtTelpon.Size = New Size(200, 23)
        txtTelpon.TabIndex = 10
        ' 
        ' gbGender
        ' 
        gbGender.BackColor = Color.White
        gbGender.Controls.Add(rbCowok)
        gbGender.Controls.Add(rbCewek)
        gbGender.Location = New Point(284, 251)
        gbGender.Name = "gbGender"
        gbGender.Size = New Size(228, 145)
        gbGender.TabIndex = 11
        gbGender.TabStop = False
        gbGender.Text = "Jenis Kelamin"
        ' 
        ' rbCowok
        ' 
        rbCowok.AutoSize = True
        rbCowok.Location = New Point(15, 22)
        rbCowok.Name = "rbCowok"
        rbCowok.Size = New Size(72, 19)
        rbCowok.TabIndex = 13
        rbCowok.TabStop = True
        rbCowok.Text = "Laki-Laki"
        rbCowok.UseVisualStyleBackColor = True
        ' 
        ' rbCewek
        ' 
        rbCewek.AutoSize = True
        rbCewek.Location = New Point(15, 58)
        rbCewek.Name = "rbCewek"
        rbCewek.Size = New Size(86, 19)
        rbCewek.TabIndex = 14
        rbCewek.TabStop = True
        rbCewek.Text = "Perempuan"
        rbCewek.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.BackColor = Color.White
        gbHobi.Controls.Add(chkMenari)
        gbHobi.Controls.Add(chkMenyanyi)
        gbHobi.Controls.Add(chkOlahraga)
        gbHobi.Controls.Add(chkMembaca)
        gbHobi.Controls.Add(chkMemancing)
        gbHobi.Controls.Add(chkMenulis)
        gbHobi.Controls.Add(chkMenggambar)
        gbHobi.Controls.Add(chkTraveling)
        gbHobi.Controls.Add(chkCoding)
        gbHobi.Controls.Add(chkGaming)
        gbHobi.Location = New Point(535, 251)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(234, 145)
        gbHobi.TabIndex = 12
        gbHobi.TabStop = False
        gbHobi.Text = "Hobby"
        ' 
        ' chkMenari
        ' 
        chkMenari.AutoSize = True
        chkMenari.Location = New Point(128, 120)
        chkMenari.Name = "chkMenari"
        chkMenari.Size = New Size(63, 19)
        chkMenari.TabIndex = 9
        chkMenari.Text = "Menari"
        chkMenari.UseVisualStyleBackColor = True
        ' 
        ' chkMenyanyi
        ' 
        chkMenyanyi.AutoSize = True
        chkMenyanyi.Location = New Point(128, 97)
        chkMenyanyi.Name = "chkMenyanyi"
        chkMenyanyi.Size = New Size(78, 19)
        chkMenyanyi.TabIndex = 8
        chkMenyanyi.Text = "Menyanyi"
        chkMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Location = New Point(128, 72)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(74, 19)
        chkOlahraga.TabIndex = 7
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.Location = New Point(128, 47)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(79, 19)
        chkMembaca.TabIndex = 6
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' chkMemancing
        ' 
        chkMemancing.AutoSize = True
        chkMemancing.Location = New Point(128, 22)
        chkMemancing.Name = "chkMemancing"
        chkMemancing.Size = New Size(90, 19)
        chkMemancing.TabIndex = 5
        chkMemancing.Text = "Memancing"
        chkMemancing.UseVisualStyleBackColor = True
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Location = New Point(18, 122)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(68, 19)
        chkMenulis.TabIndex = 4
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkMenggambar
        ' 
        chkMenggambar.AutoSize = True
        chkMenggambar.Location = New Point(18, 97)
        chkMenggambar.Name = "chkMenggambar"
        chkMenggambar.Size = New Size(98, 19)
        chkMenggambar.TabIndex = 3
        chkMenggambar.Text = "Menggambar"
        chkMenggambar.UseVisualStyleBackColor = True
        ' 
        ' chkTraveling
        ' 
        chkTraveling.AutoSize = True
        chkTraveling.Location = New Point(18, 72)
        chkTraveling.Name = "chkTraveling"
        chkTraveling.Size = New Size(74, 19)
        chkTraveling.TabIndex = 2
        chkTraveling.Text = "Traveling"
        chkTraveling.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(18, 47)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(65, 19)
        chkCoding.TabIndex = 1
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Location = New Point(18, 22)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(68, 19)
        chkGaming.TabIndex = 0
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' dtptTgl
        ' 
        dtptTgl.CalendarMonthBackground = Color.White
        dtptTgl.Location = New Point(418, 112)
        dtptTgl.Name = "dtptTgl"
        dtptTgl.Size = New Size(200, 23)
        dtptTgl.TabIndex = 15
        ' 
        ' btnCetakKartu
        ' 
        btnCetakKartu.BackColor = Color.White
        btnCetakKartu.FlatStyle = FlatStyle.System
        btnCetakKartu.Location = New Point(284, 407)
        btnCetakKartu.Name = "btnCetakKartu"
        btnCetakKartu.Size = New Size(485, 33)
        btnCetakKartu.TabIndex = 16
        btnCetakKartu.Text = "Cetak Kartu"
        btnCetakKartu.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.form_1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnCetakKartu)
        Controls.Add(dtptTgl)
        Controls.Add(gbHobi)
        Controls.Add(gbGender)
        Controls.Add(txtTelpon)
        Controls.Add(txtAlamat)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(btnBrowse)
        Controls.Add(lblAlamat)
        Controls.Add(lblNoTlp)
        Controls.Add(lblTgl)
        Controls.Add(lblUmur)
        Controls.Add(lblName)
        Controls.Add(pbProfil)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        gbGender.ResumeLayout(False)
        gbGender.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblNoTlp As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents rbCowok As RadioButton
    Friend WithEvents rbCewek As RadioButton
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents dtptTgl As DateTimePicker
    Friend WithEvents btnCetakKartu As Button
    Friend WithEvents chkMenari As CheckBox
    Friend WithEvents chkMenyanyi As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkMemancing As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkMenggambar As CheckBox

End Class
