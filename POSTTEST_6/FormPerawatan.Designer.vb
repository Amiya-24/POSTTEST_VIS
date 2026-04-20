<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerawatan
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
        txtIDPerawatan = New TextBox()
        cbIDAlat = New ComboBox()
        dtpTanggal = New DateTimePicker()
        cbJenisPerawatan = New ComboBox()
        txtKeterangan = New TextBox()
        txtBiaya = New TextBox()
        dgvPerawatan = New DataGridView()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        lblIdAlat = New Label()
        lblJenisPerawatan = New Label()
        lblTanggal = New Label()
        txtSearch = New TextBox()
        CType(dgvPerawatan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtIDPerawatan
        ' 
        txtIDPerawatan.Location = New Point(12, 12)
        txtIDPerawatan.Name = "txtIDPerawatan"
        txtIDPerawatan.PlaceholderText = "ID Perawatan"
        txtIDPerawatan.Size = New Size(140, 23)
        txtIDPerawatan.TabIndex = 0
        ' 
        ' cbIDAlat
        ' 
        cbIDAlat.FormattingEnabled = True
        cbIDAlat.Location = New Point(285, 12)
        cbIDAlat.Name = "cbIDAlat"
        cbIDAlat.Size = New Size(140, 23)
        cbIDAlat.TabIndex = 1
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(225, 87)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(200, 23)
        dtpTanggal.TabIndex = 2
        ' 
        ' cbJenisPerawatan
        ' 
        cbJenisPerawatan.FormattingEnabled = True
        cbJenisPerawatan.Items.AddRange(New Object() {"Rutin", "Ganti Sparepart", "Overhaul"})
        cbJenisPerawatan.Location = New Point(285, 51)
        cbJenisPerawatan.Name = "cbJenisPerawatan"
        cbJenisPerawatan.Size = New Size(140, 23)
        cbJenisPerawatan.TabIndex = 3
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(12, 51)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.PlaceholderText = "Keterangan"
        txtKeterangan.Size = New Size(140, 23)
        txtKeterangan.TabIndex = 4
        ' 
        ' txtBiaya
        ' 
        txtBiaya.Location = New Point(12, 90)
        txtBiaya.Name = "txtBiaya"
        txtBiaya.PlaceholderText = "Biaya"
        txtBiaya.Size = New Size(140, 23)
        txtBiaya.TabIndex = 5
        ' 
        ' dgvPerawatan
        ' 
        dgvPerawatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPerawatan.Location = New Point(13, 199)
        dgvPerawatan.Name = "dgvPerawatan"
        dgvPerawatan.Size = New Size(412, 146)
        dgvPerawatan.TabIndex = 6
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(55, 170)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(136, 170)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 8
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(217, 170)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(298, 170)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 10
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' lblIdAlat
        ' 
        lblIdAlat.AutoSize = True
        lblIdAlat.Location = New Point(185, 15)
        lblIdAlat.Name = "lblIdAlat"
        lblIdAlat.Size = New Size(72, 15)
        lblIdAlat.TabIndex = 11
        lblIdAlat.Text = "ID Alat Berat"
        ' 
        ' lblJenisPerawatan
        ' 
        lblJenisPerawatan.AutoSize = True
        lblJenisPerawatan.Location = New Point(185, 54)
        lblJenisPerawatan.Name = "lblJenisPerawatan"
        lblJenisPerawatan.Size = New Size(90, 15)
        lblJenisPerawatan.TabIndex = 12
        lblJenisPerawatan.Text = "Jenis Perawatan"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(185, 93)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(23, 15)
        lblTanggal.TabIndex = 13
        lblTanggal.Text = "Tgl"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(13, 141)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari Riwayat Perawatan"
        txtSearch.Size = New Size(412, 23)
        txtSearch.TabIndex = 14
        ' 
        ' FormPerawatan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 357)
        Controls.Add(txtSearch)
        Controls.Add(lblTanggal)
        Controls.Add(lblJenisPerawatan)
        Controls.Add(lblIdAlat)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(dgvPerawatan)
        Controls.Add(txtBiaya)
        Controls.Add(txtKeterangan)
        Controls.Add(cbJenisPerawatan)
        Controls.Add(dtpTanggal)
        Controls.Add(cbIDAlat)
        Controls.Add(txtIDPerawatan)
        Name = "FormPerawatan"
        Text = "FormPerawatan"
        CType(dgvPerawatan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIDPerawatan As TextBox
    Friend WithEvents cbIDAlat As ComboBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents cbJenisPerawatan As ComboBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents dgvPerawatan As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblIdAlat As Label
    Friend WithEvents lblJenisPerawatan As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents txtSearch As TextBox
End Class
