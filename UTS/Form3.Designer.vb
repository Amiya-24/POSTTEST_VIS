<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblNama = New Label()
        lblNim = New Label()
        lblProdi = New Label()
        lblGelar = New Label()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblNama.Location = New Point(361, 176)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(60, 21)
        lblNama.TabIndex = 0
        lblNama.Text = "Label1"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.BackColor = Color.Transparent
        lblNim.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblNim.Location = New Point(361, 200)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(60, 21)
        lblNim.TabIndex = 1
        lblNim.Text = "Label2"
        ' 
        ' lblProdi
        ' 
        lblProdi.AutoSize = True
        lblProdi.BackColor = Color.Transparent
        lblProdi.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblProdi.Location = New Point(361, 265)
        lblProdi.Name = "lblProdi"
        lblProdi.Size = New Size(60, 21)
        lblProdi.TabIndex = 2
        lblProdi.Text = "Label3"
        ' 
        ' lblGelar
        ' 
        lblGelar.AutoSize = True
        lblGelar.BackColor = Color.Transparent
        lblGelar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblGelar.Location = New Point(361, 334)
        lblGelar.Name = "lblGelar"
        lblGelar.Size = New Size(60, 21)
        lblGelar.TabIndex = 3
        lblGelar.Text = "Label4"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.BackColor = Color.Transparent
        lblPredikat.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPredikat.Location = New Point(389, 363)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(60, 21)
        lblPredikat.TabIndex = 4
        lblPredikat.Text = "Label5"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.form_3
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(lblGelar)
        Controls.Add(lblProdi)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        DoubleBuffered = True
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblProdi As Label
    Friend WithEvents lblGelar As Label
    Friend WithEvents lblPredikat As Label
End Class
