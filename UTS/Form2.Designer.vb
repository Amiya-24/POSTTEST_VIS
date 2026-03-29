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
        cmbProdi = New ComboBox()
        btnCetak = New Button()
        btnKembali = New Button()
        lblNama = New Label()
        lblNIM = New Label()
        lblProdi = New Label()
        lblAngkatan = New Label()
        lblIPK = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        txtIPK = New TextBox()
        txtAngkatan = New TextBox()
        SuspendLayout()
        ' 
        ' cmbProdi
        ' 
        cmbProdi.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProdi.FormattingEnabled = True
        cmbProdi.Items.AddRange(New Object() {"Informatika", "", "", "Sistem Informasi", "", "", "Teknik Elektro", "", "", "Teknik Sipil", "", "", "Teknik Industri", "", "", "Teknik Lingkungan", "", "", "Teknik Pertambangan", "", "", "Teknik Kimia", "", "", "Arsitektur", "", "", "Teknik Geologi"})
        cmbProdi.Location = New Point(321, 266)
        cmbProdi.Name = "cmbProdi"
        cmbProdi.Size = New Size(247, 23)
        cmbProdi.TabIndex = 0
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(448, 402)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(120, 23)
        btnCetak.TabIndex = 1
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(321, 402)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(121, 23)
        btnKembali.TabIndex = 2
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(130, 188)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(87, 15)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama Lengkap"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.BackColor = Color.Transparent
        lblNIM.ForeColor = Color.White
        lblNIM.Location = New Point(130, 228)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(139, 15)
        lblNIM.TabIndex = 4
        lblNIM.Text = "Nomor Induk Mahasiswa"
        ' 
        ' lblProdi
        ' 
        lblProdi.AutoSize = True
        lblProdi.BackColor = Color.Transparent
        lblProdi.ForeColor = Color.White
        lblProdi.Location = New Point(130, 269)
        lblProdi.Name = "lblProdi"
        lblProdi.Size = New Size(83, 15)
        lblProdi.TabIndex = 5
        lblProdi.Text = "Program Studi"
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.BackColor = Color.Transparent
        lblAngkatan.ForeColor = Color.White
        lblAngkatan.Location = New Point(130, 312)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(58, 15)
        lblAngkatan.TabIndex = 6
        lblAngkatan.Text = "Angkatan"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.BackColor = Color.Transparent
        lblIPK.ForeColor = Color.White
        lblIPK.Location = New Point(130, 354)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(139, 15)
        lblIPK.TabIndex = 7
        lblIPK.Text = "Indeks Prestasi Kumulatif"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(321, 185)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(247, 23)
        txtNama.TabIndex = 8
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(321, 225)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(247, 23)
        txtNim.TabIndex = 9
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(321, 351)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(247, 23)
        txtIPK.TabIndex = 10
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(321, 309)
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(247, 23)
        txtAngkatan.TabIndex = 11
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.form_2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(txtAngkatan)
        Controls.Add(txtIPK)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(lblIPK)
        Controls.Add(lblAngkatan)
        Controls.Add(lblProdi)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Controls.Add(btnKembali)
        Controls.Add(btnCetak)
        Controls.Add(cmbProdi)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbProdi As ComboBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblProdi As Label
    Friend WithEvents lblAngkatan As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents txtAngkatan As TextBox
End Class
