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
        lblDivisi = New Label()
        lblHobby = New Label()
        lblKontak = New Label()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.Location = New Point(12, 101)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(172, 221)
        pbFotoHasil.TabIndex = 0
        pbFotoHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.White
        lblNama.Location = New Point(199, 135)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(41, 15)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.White
        lblID.Location = New Point(199, 169)
        lblID.Name = "lblID"
        lblID.Size = New Size(41, 15)
        lblID.TabIndex = 2
        lblID.Text = "Label2"
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.BackColor = Color.White
        lblDivisi.Location = New Point(199, 240)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(41, 15)
        lblDivisi.TabIndex = 3
        lblDivisi.Text = "Label3"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = Color.White
        lblHobby.Location = New Point(199, 275)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(41, 15)
        lblHobby.TabIndex = 4
        lblHobby.Text = "Label4"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.BackColor = Color.White
        lblKontak.Location = New Point(199, 202)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(41, 15)
        lblKontak.TabIndex = 6
        lblKontak.Text = "Label6"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.form_kartu_2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(657, 334)
        Controls.Add(lblKontak)
        Controls.Add(lblHobby)
        Controls.Add(lblDivisi)
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
    Friend WithEvents lblDivisi As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblKontak As Label
End Class
