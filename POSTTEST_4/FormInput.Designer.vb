<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        TabControl1 = New TabControl()
        tpDataUtama = New TabPage()
        lblJenisKelamin = New Label()
        lblKomunitas = New Label()
        lblTanggalLahir = New Label()
        lblID = New Label()
        lblNama = New Label()
        rbPerempuan = New RadioButton()
        cbKomunitas = New ComboBox()
        rbLaki = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        tpKontakdanInfo = New TabPage()
        lblEmail = New Label()
        lblAlamat = New Label()
        lblTelepon = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbTelepon = New MaskedTextBox()
        tpProfil = New TabPage()
        btnSimpanCetak = New Button()
        gbHobby = New GroupBox()
        chk8 = New CheckBox()
        chk7 = New CheckBox()
        chk6 = New CheckBox()
        chk5 = New CheckBox()
        chk4 = New CheckBox()
        chk3 = New CheckBox()
        chk2 = New CheckBox()
        chk1 = New CheckBox()
        gbPeran = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbFoto = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        TabControl1.SuspendLayout()
        tpDataUtama.SuspendLayout()
        tpKontakdanInfo.SuspendLayout()
        tpProfil.SuspendLayout()
        gbHobby.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpDataUtama)
        TabControl1.Controls.Add(tpKontakdanInfo)
        TabControl1.Controls.Add(tpProfil)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(462, 357)
        TabControl1.TabIndex = 2
        ' 
        ' tpDataUtama
        ' 
        tpDataUtama.BackgroundImageLayout = ImageLayout.Stretch
        tpDataUtama.Controls.Add(lblJenisKelamin)
        tpDataUtama.Controls.Add(lblKomunitas)
        tpDataUtama.Controls.Add(lblTanggalLahir)
        tpDataUtama.Controls.Add(lblID)
        tpDataUtama.Controls.Add(lblNama)
        tpDataUtama.Controls.Add(rbPerempuan)
        tpDataUtama.Controls.Add(cbKomunitas)
        tpDataUtama.Controls.Add(rbLaki)
        tpDataUtama.Controls.Add(dtpTanggalLahir)
        tpDataUtama.Controls.Add(txtID)
        tpDataUtama.Controls.Add(txtNama)
        tpDataUtama.Location = New Point(4, 24)
        tpDataUtama.Name = "tpDataUtama"
        tpDataUtama.Padding = New Padding(3)
        tpDataUtama.Size = New Size(454, 329)
        tpDataUtama.TabIndex = 0
        tpDataUtama.Text = "Data Utama"
        tpDataUtama.UseVisualStyleBackColor = True
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Location = New Point(34, 217)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(78, 15)
        lblJenisKelamin.TabIndex = 10
        lblJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(34, 173)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(64, 15)
        lblKomunitas.TabIndex = 9
        lblKomunitas.Text = "Komunitas"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.Location = New Point(34, 124)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(78, 15)
        lblTanggalLahir.TabIndex = 8
        lblTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(34, 69)
        lblID.Name = "lblID"
        lblID.Size = New Size(18, 15)
        lblID.TabIndex = 7
        lblID.Text = "ID"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(34, 26)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(39, 15)
        lblNama.TabIndex = 6
        lblNama.Text = "Nama"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(294, 215)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 5
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' cbKomunitas
        ' 
        cbKomunitas.FormattingEnabled = True
        cbKomunitas.Location = New Point(191, 170)
        cbKomunitas.Name = "cbKomunitas"
        cbKomunitas.Size = New Size(200, 23)
        cbKomunitas.TabIndex = 4
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(191, 215)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(72, 19)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(191, 118)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(200, 23)
        dtpTanggalLahir.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(191, 66)
        txtID.Name = "txtID"
        txtID.Size = New Size(200, 23)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(191, 23)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 23)
        txtNama.TabIndex = 0
        ' 
        ' tpKontakdanInfo
        ' 
        tpKontakdanInfo.Controls.Add(lblEmail)
        tpKontakdanInfo.Controls.Add(lblAlamat)
        tpKontakdanInfo.Controls.Add(lblTelepon)
        tpKontakdanInfo.Controls.Add(txtAlamat)
        tpKontakdanInfo.Controls.Add(txtEmail)
        tpKontakdanInfo.Controls.Add(mtbTelepon)
        tpKontakdanInfo.Location = New Point(4, 24)
        tpKontakdanInfo.Name = "tpKontakdanInfo"
        tpKontakdanInfo.Padding = New Padding(3)
        tpKontakdanInfo.Size = New Size(454, 329)
        tpKontakdanInfo.TabIndex = 1
        tpKontakdanInfo.Text = "Kontak & Info"
        tpKontakdanInfo.UseVisualStyleBackColor = True
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(20, 133)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(38, 15)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Gmail"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(20, 79)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(45, 15)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Location = New Point(20, 29)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(71, 15)
        lblTelepon.TabIndex = 3
        lblTelepon.Text = "No. Telepon"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(125, 76)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(200, 23)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(125, 130)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "example@gmail.com"
        txtEmail.Size = New Size(200, 23)
        txtEmail.TabIndex = 1
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(125, 26)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(200, 23)
        mtbTelepon.TabIndex = 0
        ' 
        ' tpProfil
        ' 
        tpProfil.Controls.Add(btnSimpanCetak)
        tpProfil.Controls.Add(gbHobby)
        tpProfil.Controls.Add(gbPeran)
        tpProfil.Controls.Add(btnBrowse)
        tpProfil.Controls.Add(pbFoto)
        tpProfil.Location = New Point(4, 24)
        tpProfil.Name = "tpProfil"
        tpProfil.Padding = New Padding(3)
        tpProfil.Size = New Size(454, 329)
        tpProfil.TabIndex = 2
        tpProfil.Text = "Profil & Aktifitas"
        tpProfil.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(369, 298)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(81, 23)
        btnSimpanCetak.TabIndex = 4
        btnSimpanCetak.Text = "Simpan"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(chk8)
        gbHobby.Controls.Add(chk7)
        gbHobby.Controls.Add(chk6)
        gbHobby.Controls.Add(chk5)
        gbHobby.Controls.Add(chk4)
        gbHobby.Controls.Add(chk3)
        gbHobby.Controls.Add(chk2)
        gbHobby.Controls.Add(chk1)
        gbHobby.Location = New Point(187, 151)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(261, 141)
        gbHobby.TabIndex = 3
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' chk8
        ' 
        chk8.AutoSize = True
        chk8.Location = New Point(156, 116)
        chk8.Name = "chk8"
        chk8.Size = New Size(74, 19)
        chk8.TabIndex = 7
        chk8.Text = "Olahraga"
        chk8.UseVisualStyleBackColor = True
        ' 
        ' chk7
        ' 
        chk7.AutoSize = True
        chk7.Location = New Point(156, 82)
        chk7.Name = "chk7"
        chk7.Size = New Size(76, 19)
        chk7.TabIndex = 6
        chk7.Text = "Berakting"
        chk7.UseVisualStyleBackColor = True
        ' 
        ' chk6
        ' 
        chk6.AutoSize = True
        chk6.Location = New Point(156, 47)
        chk6.Name = "chk6"
        chk6.Size = New Size(70, 19)
        chk6.TabIndex = 5
        chk6.Text = "Bermain"
        chk6.UseVisualStyleBackColor = True
        ' 
        ' chk5
        ' 
        chk5.AutoSize = True
        chk5.Location = New Point(156, 16)
        chk5.Name = "chk5"
        chk5.Size = New Size(78, 19)
        chk5.TabIndex = 4
        chk5.Text = "Bernyanyi"
        chk5.UseVisualStyleBackColor = True
        ' 
        ' chk4
        ' 
        chk4.AutoSize = True
        chk4.Location = New Point(6, 116)
        chk4.Name = "chk4"
        chk4.Size = New Size(91, 19)
        chk4.TabIndex = 3
        chk4.Text = "Mengambar"
        chk4.UseVisualStyleBackColor = True
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Location = New Point(6, 47)
        chk3.Name = "chk3"
        chk3.Size = New Size(68, 19)
        chk3.TabIndex = 2
        chk3.Text = "Menulis"
        chk3.UseVisualStyleBackColor = True
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Location = New Point(6, 82)
        chk2.Name = "chk2"
        chk2.Size = New Size(67, 19)
        chk2.TabIndex = 1
        chk2.Text = "Melukis"
        chk2.UseVisualStyleBackColor = True
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Location = New Point(6, 16)
        chk1.Name = "chk1"
        chk1.Size = New Size(79, 19)
        chk1.TabIndex = 0
        chk1.Text = "Membaca"
        chk1.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAdmin)
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Location = New Point(187, 18)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(261, 117)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(6, 82)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(61, 19)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(6, 47)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(71, 19)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(6, 16)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(55, 19)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(54, 223)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' pbFoto
        ' 
        pbFoto.Location = New Point(17, 18)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(151, 199)
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(486, 381)
        Controls.Add(TabControl1)
        DoubleBuffered = True
        Name = "FormInput"
        Text = "FormInput"
        TabControl1.ResumeLayout(False)
        tpDataUtama.ResumeLayout(False)
        tpDataUtama.PerformLayout()
        tpKontakdanInfo.ResumeLayout(False)
        tpKontakdanInfo.PerformLayout()
        tpProfil.ResumeLayout(False)
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpDataUtama As TabPage
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cbKomunitas As ComboBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents tpKontakdanInfo As TabPage
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents tpProfil As TabPage
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
End Class
