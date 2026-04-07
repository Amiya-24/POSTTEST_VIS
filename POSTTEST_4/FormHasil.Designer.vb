<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
        pbFotoHasil = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        lblKontak = New Label()
        lblTanggalLahir = New Label()
        lblJenisKelamin = New Label()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.Location = New Point(12, 101)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(172, 193)
        pbFotoHasil.TabIndex = 0
        pbFotoHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.White
        lblNama.Location = New Point(201, 124)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(41, 15)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.White
        lblID.Location = New Point(201, 158)
        lblID.Name = "lblID"
        lblID.Size = New Size(41, 15)
        lblID.TabIndex = 2
        lblID.Text = "Label2"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.BackColor = Color.White
        lblKomunitas.Location = New Point(434, 158)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(41, 15)
        lblKomunitas.TabIndex = 3
        lblKomunitas.Text = "Label3"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = Color.White
        lblHobby.Location = New Point(434, 191)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(41, 15)
        lblHobby.TabIndex = 4
        lblHobby.Text = "Label4"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.White
        lblAlamat.Location = New Point(434, 124)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(41, 15)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Label5"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.BackColor = Color.White
        lblKontak.Location = New Point(201, 191)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(41, 15)
        lblKontak.TabIndex = 6
        lblKontak.Text = "Label6"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.BackColor = Color.White
        lblTanggalLahir.Location = New Point(201, 227)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(41, 15)
        lblTanggalLahir.TabIndex = 7
        lblTanggalLahir.Text = "Label7"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.BackColor = Color.White
        lblJenisKelamin.Location = New Point(201, 262)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(41, 15)
        lblJenisKelamin.TabIndex = 8
        lblJenisKelamin.Text = "Label8"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.form_kartu_2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(650, 308)
        Controls.Add(lblJenisKelamin)
        Controls.Add(lblTanggalLahir)
        Controls.Add(lblKontak)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(pbFotoHasil)
        DoubleBuffered = True
        Name = "FormHasil"
        Text = "FormHasil"
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblJenisKelamin As Label
End Class
