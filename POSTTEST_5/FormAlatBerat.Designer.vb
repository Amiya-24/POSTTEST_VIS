<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlatBerat
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
        txtID = New TextBox()
        txtNama = New TextBox()
        txtHM = New TextBox()
        txtSearch = New TextBox()
        cbJenis = New ComboBox()
        cbStatus = New ComboBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvAlat = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        lblStatus = New Label()
        lblJenis = New Label()
        CType(dgvAlat, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(12, 14)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID"
        txtID.Size = New Size(144, 23)
        txtID.TabIndex = 0
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(12, 57)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(144, 23)
        txtNama.TabIndex = 1
        ' 
        ' txtHM
        ' 
        txtHM.Location = New Point(12, 98)
        txtHM.Name = "txtHM"
        txtHM.PlaceholderText = "Hour Meter"
        txtHM.Size = New Size(144, 23)
        txtHM.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(205, 98)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search"
        txtSearch.Size = New Size(144, 23)
        txtSearch.TabIndex = 3
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Items.AddRange(New Object() {"Ekskavator", "Buldoser", "Crane", "Dump Truck"})
        cbJenis.Location = New Point(205, 17)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(144, 23)
        cbJenis.TabIndex = 4
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Aktif", "Maintenance", "Rusak"})
        cbStatus.Location = New Point(205, 57)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(144, 23)
        cbStatus.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(20, 155)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(101, 155)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(182, 155)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(263, 155)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvAlat
        ' 
        dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlat.Location = New Point(12, 184)
        dgvAlat.Name = "dgvAlat"
        dgvAlat.Size = New Size(337, 150)
        dgvAlat.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(162, 60)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 15)
        lblStatus.TabIndex = 12
        lblStatus.Text = "Status"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(167, 17)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(32, 15)
        lblJenis.TabIndex = 13
        lblJenis.Text = "Jenis"
        ' 
        ' FormAlatBerat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 346)
        Controls.Add(lblJenis)
        Controls.Add(lblStatus)
        Controls.Add(dgvAlat)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(cbStatus)
        Controls.Add(cbJenis)
        Controls.Add(txtSearch)
        Controls.Add(txtHM)
        Controls.Add(txtNama)
        Controls.Add(txtID)
        Name = "FormAlatBerat"
        Text = "FormAlatBerat"
        CType(dgvAlat, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHM As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvAlat As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblStatus As Label
End Class
