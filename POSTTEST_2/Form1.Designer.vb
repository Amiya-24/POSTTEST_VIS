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
        lbljudultambah = New Label()
        lblgenre = New Label()
        txtjudultambah = New TextBox()
        txtgenre = New TextBox()
        btntambahbuku = New Button()
        btnhapusbuku = New Button()
        grptambahbuku = New GroupBox()
        grphapusbuku = New GroupBox()
        lbljudulhapus = New Label()
        txtjudulhapus = New TextBox()
        lstbuku = New ListBox()
        grptambahbuku.SuspendLayout()
        grphapusbuku.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbljudultambah
        ' 
        lbljudultambah.AutoSize = True
        lbljudultambah.Location = New Point(6, 36)
        lbljudultambah.Name = "lbljudultambah"
        lbljudultambah.Size = New Size(65, 15)
        lbljudultambah.TabIndex = 0
        lbljudultambah.Text = "Judul Buku"
        ' 
        ' lblgenre
        ' 
        lblgenre.AutoSize = True
        lblgenre.Location = New Point(6, 89)
        lblgenre.Name = "lblgenre"
        lblgenre.Size = New Size(38, 15)
        lblgenre.TabIndex = 1
        lblgenre.Text = "Genre"
        ' 
        ' txtjudultambah
        ' 
        txtjudultambah.Location = New Point(86, 33)
        txtjudultambah.Name = "txtjudultambah"
        txtjudultambah.Size = New Size(100, 23)
        txtjudultambah.TabIndex = 2
        ' 
        ' txtgenre
        ' 
        txtgenre.Location = New Point(86, 86)
        txtgenre.Name = "txtgenre"
        txtgenre.Size = New Size(100, 23)
        txtgenre.TabIndex = 3
        ' 
        ' btntambahbuku
        ' 
        btntambahbuku.Location = New Point(111, 132)
        btntambahbuku.Name = "btntambahbuku"
        btntambahbuku.Size = New Size(75, 23)
        btntambahbuku.TabIndex = 4
        btntambahbuku.Text = "Tambah"
        btntambahbuku.UseVisualStyleBackColor = True
        ' 
        ' btnhapusbuku
        ' 
        btnhapusbuku.Location = New Point(113, 132)
        btnhapusbuku.Name = "btnhapusbuku"
        btnhapusbuku.Size = New Size(75, 23)
        btnhapusbuku.TabIndex = 5
        btnhapusbuku.Text = "Hapus"
        btnhapusbuku.UseVisualStyleBackColor = True
        ' 
        ' grptambahbuku
        ' 
        grptambahbuku.Controls.Add(lbljudultambah)
        grptambahbuku.Controls.Add(lblgenre)
        grptambahbuku.Controls.Add(txtjudultambah)
        grptambahbuku.Controls.Add(txtgenre)
        grptambahbuku.Controls.Add(btntambahbuku)
        grptambahbuku.Location = New Point(12, 12)
        grptambahbuku.Name = "grptambahbuku"
        grptambahbuku.Size = New Size(194, 161)
        grptambahbuku.TabIndex = 6
        grptambahbuku.TabStop = False
        grptambahbuku.Text = "Tambah Buku"
        ' 
        ' grphapusbuku
        ' 
        grphapusbuku.Controls.Add(lbljudulhapus)
        grphapusbuku.Controls.Add(txtjudulhapus)
        grphapusbuku.Controls.Add(btnhapusbuku)
        grphapusbuku.Location = New Point(244, 12)
        grphapusbuku.Name = "grphapusbuku"
        grphapusbuku.Size = New Size(194, 161)
        grphapusbuku.TabIndex = 7
        grphapusbuku.TabStop = False
        grphapusbuku.Text = "Hapus Buku"
        ' 
        ' lbljudulhapus
        ' 
        lbljudulhapus.AutoSize = True
        lbljudulhapus.Location = New Point(6, 36)
        lbljudulhapus.Name = "lbljudulhapus"
        lbljudulhapus.Size = New Size(65, 15)
        lbljudulhapus.TabIndex = 8
        lbljudulhapus.Text = "Judul Buku"
        ' 
        ' txtjudulhapus
        ' 
        txtjudulhapus.Location = New Point(88, 33)
        txtjudulhapus.Name = "txtjudulhapus"
        txtjudulhapus.Size = New Size(100, 23)
        txtjudulhapus.TabIndex = 9
        ' 
        ' lstbuku
        ' 
        lstbuku.FormattingEnabled = True
        lstbuku.Location = New Point(123, 179)
        lstbuku.Name = "lstbuku"
        lstbuku.Size = New Size(194, 154)
        lstbuku.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 345)
        Controls.Add(grphapusbuku)
        Controls.Add(lstbuku)
        Controls.Add(grptambahbuku)
        Name = "Form1"
        Text = "Form1"
        grptambahbuku.ResumeLayout(False)
        grptambahbuku.PerformLayout()
        grphapusbuku.ResumeLayout(False)
        grphapusbuku.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbljudultambah As Label
    Friend WithEvents lblgenre As Label
    Friend WithEvents txtjudultambah As TextBox
    Friend WithEvents txtgenre As TextBox
    Friend WithEvents btntambahbuku As Button
    Friend WithEvents btnhapusbuku As Button
    Friend WithEvents grptambahbuku As GroupBox
    Friend WithEvents grphapusbuku As GroupBox
    Friend WithEvents lbljudulhapus As Label
    Friend WithEvents txtjudulhapus As TextBox
    Friend WithEvents lstbuku As ListBox

End Class
