<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        MenuStrip1 = New MenuStrip()
        ManajemenDataToolStripMenuItem = New ToolStripMenuItem()
        AlatBeratToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        TentangSistemToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        RiwayatPerawatanToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ManajemenDataToolStripMenuItem, BantuanToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(425, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ManajemenDataToolStripMenuItem
        ' 
        ManajemenDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AlatBeratToolStripMenuItem, RiwayatPerawatanToolStripMenuItem})
        ManajemenDataToolStripMenuItem.Name = "ManajemenDataToolStripMenuItem"
        ManajemenDataToolStripMenuItem.Size = New Size(109, 20)
        ManajemenDataToolStripMenuItem.Text = "Manajemen Data"
        ' 
        ' AlatBeratToolStripMenuItem
        ' 
        AlatBeratToolStripMenuItem.Name = "AlatBeratToolStripMenuItem"
        AlatBeratToolStripMenuItem.Size = New Size(180, 22)
        AlatBeratToolStripMenuItem.Text = "Alat Berat"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TentangSistemToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(63, 20)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' TentangSistemToolStripMenuItem
        ' 
        TentangSistemToolStripMenuItem.Name = "TentangSistemToolStripMenuItem"
        TentangSistemToolStripMenuItem.Size = New Size(155, 22)
        TentangSistemToolStripMenuItem.Text = "Tentang Sistem"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(52, 20)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' RiwayatPerawatanToolStripMenuItem
        ' 
        RiwayatPerawatanToolStripMenuItem.Name = "RiwayatPerawatanToolStripMenuItem"
        RiwayatPerawatanToolStripMenuItem.Size = New Size(180, 22)
        RiwayatPerawatanToolStripMenuItem.Text = "Riwayat Perawatan"
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(425, 252)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormUtama"
        Text = "FormUtama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManajemenDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlatBeratToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangSistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiwayatPerawatanToolStripMenuItem As ToolStripMenuItem

End Class
