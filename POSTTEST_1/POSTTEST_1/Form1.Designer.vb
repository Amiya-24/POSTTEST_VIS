<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KalkulatorIP
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
        lblIPS = New Label()
        lblIPK = New Label()
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        btnTambah = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' lblIPS
        ' 
        lblIPS.AutoSize = True
        lblIPS.Location = New Point(253, 144)
        lblIPS.Name = "lblIPS"
        lblIPS.Size = New Size(68, 15)
        lblIPS.TabIndex = 0
        lblIPS.Text = "IP Semester"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Location = New Point(253, 226)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(72, 15)
        lblIPK.TabIndex = 1
        lblIPK.Text = "IP Kumulatif"
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(370, 141)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(156, 23)
        txtIPS.TabIndex = 2
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(370, 223)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(156, 23)
        txtIPK.TabIndex = 3
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(370, 270)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(50, 15)
        lblPredikat.TabIndex = 4
        lblPredikat.Text = "Predikat"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(370, 181)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(451, 181)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' KalkulatorIP
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(803, 450)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Controls.Add(lblIPK)
        Controls.Add(lblIPS)
        ForeColor = SystemColors.ControlText
        Name = "KalkulatorIP"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPS As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button

End Class
