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
        txtMerk = New TextBox()
        txtSN = New TextBox()
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
        txtSparePart = New TextBox()
        dtpSILO = New DateTimePicker()
        lblSILO = New Label()
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
        ' txtMerk
        ' 
        txtMerk.Location = New Point(12, 52)
        txtMerk.Name = "txtMerk"
        txtMerk.PlaceholderText = "Merk"
        txtMerk.Size = New Size(144, 23)
        txtMerk.TabIndex = 1
        ' 
        ' txtSN
        ' 
        txtSN.Location = New Point(12, 91)
        txtSN.Name = "txtSN"
        txtSN.PlaceholderText = "Serial Number"
        txtSN.Size = New Size(144, 23)
        txtSN.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(12, 167)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search"
        txtSearch.Size = New Size(413, 23)
        txtSearch.TabIndex = 3
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Items.AddRange(New Object() {"Backhoe Loader", "", "", "Bulldozer", "", "", "Crawler Loader", "", "", "Dump Truck", "", "", "Excavator", "", "", "Forklift", "", "", "Mobile Crane", "", "", "Motor Grader", "", "", "Tower Crane", "", "", "Vibratory Roller (Vibro)", "", "", "Wheel Loader"})
        cbJenis.Location = New Point(225, 17)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(200, 23)
        cbJenis.TabIndex = 4
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Ready", "Maintenance", "Breakdown"})
        cbStatus.Location = New Point(225, 52)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(200, 23)
        cbStatus.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(62, 196)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(143, 196)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(224, 196)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(305, 196)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvAlat
        ' 
        dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlat.Location = New Point(12, 225)
        dgvAlat.Name = "dgvAlat"
        dgvAlat.Size = New Size(413, 150)
        dgvAlat.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(180, 60)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 15)
        lblStatus.TabIndex = 12
        lblStatus.Text = "Status"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(183, 20)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(32, 15)
        lblJenis.TabIndex = 13
        lblJenis.Text = "Jenis"
        ' 
        ' txtSparePart
        ' 
        txtSparePart.Location = New Point(12, 129)
        txtSparePart.Name = "txtSparePart"
        txtSparePart.PlaceholderText = "Spare Part"
        txtSparePart.Size = New Size(144, 23)
        txtSparePart.TabIndex = 14
        ' 
        ' dtpSILO
        ' 
        dtpSILO.Location = New Point(225, 91)
        dtpSILO.Name = "dtpSILO"
        dtpSILO.Size = New Size(200, 23)
        dtpSILO.TabIndex = 15
        ' 
        ' lblSILO
        ' 
        lblSILO.AutoSize = True
        lblSILO.Location = New Point(167, 97)
        lblSILO.Name = "lblSILO"
        lblSILO.Size = New Size(52, 15)
        lblSILO.TabIndex = 16
        lblSILO.Text = "SILO Exp"
        ' 
        ' FormAlatBerat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 387)
        Controls.Add(lblSILO)
        Controls.Add(dtpSILO)
        Controls.Add(txtSparePart)
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
        Controls.Add(txtSN)
        Controls.Add(txtMerk)
        Controls.Add(txtID)
        Name = "FormAlatBerat"
        Text = "FormAlatBerat"
        CType(dgvAlat, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents txtSN As TextBox
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
    Friend WithEvents txtSparePart As TextBox
    Friend WithEvents lblSILO As Label
    Friend WithEvents dtpSILO As DateTimePicker
End Class
