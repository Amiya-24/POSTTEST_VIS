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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblDeskripsi = New Label()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        txtPengarang = New TextBox()
        txtPenerbit = New TextBox()
        txtJumlahBuku = New TextBox()
        cbJenis = New ComboBox()
        txtCari = New TextBox()
        dgvBuku = New DataGridView()
        txtDeskripsi = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        btnPreviewCetak = New Button()
        btnCetak = New Button()
        docLaporan = New Printing.PrintDocument()
        dlgPreview = New PrintPreviewDialog()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "Kode Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 1
        Label2.Text = "Judul"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 2
        Label3.Text = "Pengarang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 3
        Label4.Text = "Penerbit"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 172)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 15)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah Buku"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(220, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 5
        Label6.Text = "Jenis Buku"
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.Location = New Point(568, 29)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(54, 15)
        lblDeskripsi.TabIndex = 6
        lblDeskripsi.Text = "Deskripsi"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(95, 18)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(107, 23)
        txtKodeBuku.TabIndex = 7
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(95, 55)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(300, 23)
        txtJudul.TabIndex = 8
        ' 
        ' txtPengarang
        ' 
        txtPengarang.Location = New Point(95, 95)
        txtPengarang.Name = "txtPengarang"
        txtPengarang.Size = New Size(300, 23)
        txtPengarang.TabIndex = 9
        ' 
        ' txtPenerbit
        ' 
        txtPenerbit.Location = New Point(95, 130)
        txtPenerbit.Name = "txtPenerbit"
        txtPenerbit.Size = New Size(300, 23)
        txtPenerbit.TabIndex = 10
        ' 
        ' txtJumlahBuku
        ' 
        txtJumlahBuku.Location = New Point(95, 169)
        txtJumlahBuku.Name = "txtJumlahBuku"
        txtJumlahBuku.Size = New Size(300, 23)
        txtJumlahBuku.TabIndex = 11
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Location = New Point(288, 21)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(107, 23)
        cbJenis.TabIndex = 12
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(12, 255)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(714, 23)
        txtCari.TabIndex = 13
        ' 
        ' dgvBuku
        ' 
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(12, 284)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.Size = New Size(714, 154)
        dgvBuku.TabIndex = 14
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(450, 55)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(276, 137)
        txtDeskripsi.TabIndex = 15
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(11, 226)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 16
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(92, 226)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 17
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(173, 226)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 18
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(254, 226)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 19
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnPreviewCetak
        ' 
        btnPreviewCetak.Location = New Point(517, 226)
        btnPreviewCetak.Name = "btnPreviewCetak"
        btnPreviewCetak.Size = New Size(75, 23)
        btnPreviewCetak.TabIndex = 20
        btnPreviewCetak.Text = "Preview"
        btnPreviewCetak.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(598, 226)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(75, 23)
        btnCetak.TabIndex = 21
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' dlgPreview
        ' 
        dlgPreview.AutoScrollMargin = New Size(0, 0)
        dlgPreview.AutoScrollMinSize = New Size(0, 0)
        dlgPreview.ClientSize = New Size(400, 300)
        dlgPreview.Enabled = True
        dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), Icon)
        dlgPreview.Name = "PrintPreviewDialog1"
        dlgPreview.Visible = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(741, 450)
        Controls.Add(btnCetak)
        Controls.Add(btnPreviewCetak)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtDeskripsi)
        Controls.Add(dgvBuku)
        Controls.Add(txtCari)
        Controls.Add(cbJenis)
        Controls.Add(txtJumlahBuku)
        Controls.Add(txtPenerbit)
        Controls.Add(txtPengarang)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblDeskripsi)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents txtJumlahBuku As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnPreviewCetak As Button
    Friend WithEvents docLaporan As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
End Class
