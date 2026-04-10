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
        components = New ComponentModel.Container()
        lblJenisKode = New Label()
        lblJenis = New Label()
        lblCariBuku = New Label()
        txtKodeJenis = New TextBox()
        txtJenis = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvJenis = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvJenis, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJenisKode
        ' 
        lblJenisKode.AutoSize = True
        lblJenisKode.Location = New Point(12, 22)
        lblJenisKode.Name = "lblJenisKode"
        lblJenisKode.Size = New Size(62, 15)
        lblJenisKode.TabIndex = 0
        lblJenisKode.Text = "Jenis Kode"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(12, 61)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(32, 15)
        lblJenis.TabIndex = 1
        lblJenis.Text = "Jenis"
        ' 
        ' lblCariBuku
        ' 
        lblCariBuku.AutoSize = True
        lblCariBuku.Location = New Point(12, 99)
        lblCariBuku.Name = "lblCariBuku"
        lblCariBuku.Size = New Size(58, 15)
        lblCariBuku.TabIndex = 2
        lblCariBuku.Text = "Cari Buku"
        ' 
        ' txtKodeJenis
        ' 
        txtKodeJenis.Location = New Point(107, 19)
        txtKodeJenis.Name = "txtKodeJenis"
        txtKodeJenis.PlaceholderText = "Jenis Kode"
        txtKodeJenis.Size = New Size(223, 23)
        txtKodeJenis.TabIndex = 3
        ' 
        ' txtJenis
        ' 
        txtJenis.Location = New Point(107, 58)
        txtJenis.Name = "txtJenis"
        txtJenis.PlaceholderText = "Jenis"
        txtJenis.Size = New Size(223, 23)
        txtJenis.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(107, 96)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari Buku"
        txtSearch.Size = New Size(223, 23)
        txtSearch.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(12, 141)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(93, 141)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(174, 141)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(255, 141)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvJenis
        ' 
        dgvJenis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJenis.Location = New Point(12, 170)
        dgvJenis.Name = "dgvJenis"
        dgvJenis.Size = New Size(321, 94)
        dgvJenis.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(342, 276)
        Controls.Add(dgvJenis)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtJenis)
        Controls.Add(txtKodeJenis)
        Controls.Add(lblCariBuku)
        Controls.Add(lblJenis)
        Controls.Add(lblJenisKode)
        Name = "Form1"
        Text = "Form1"
        CType(dgvJenis, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJenisKode As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblCariBuku As Label
    Friend WithEvents txtKodeJenis As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvJenis As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
