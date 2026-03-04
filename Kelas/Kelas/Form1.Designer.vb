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
        lblnama = New Label()
        lblnim = New Label()
        btntambah = New Button()
        btnhapus = New Button()
        btnedit = New Button()
        txtnama = New TextBox()
        txtnim = New TextBox()
        dgvhasil = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        CType(dgvhasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblnama
        ' 
        lblnama.AutoSize = True
        lblnama.Location = New Point(49, 52)
        lblnama.Name = "lblnama"
        lblnama.Size = New Size(43, 15)
        lblnama.TabIndex = 0
        lblnama.Text = "NAMA"
        ' 
        ' lblnim
        ' 
        lblnim.AutoSize = True
        lblnim.Location = New Point(49, 120)
        lblnim.Name = "lblnim"
        lblnim.Size = New Size(30, 15)
        lblnim.TabIndex = 1
        lblnim.Text = "NIM"
        ' 
        ' btntambah
        ' 
        btntambah.BackColor = Color.LawnGreen
        btntambah.Location = New Point(49, 172)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(75, 23)
        btntambah.TabIndex = 2
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = False
        ' 
        ' btnhapus
        ' 
        btnhapus.BackColor = Color.OrangeRed
        btnhapus.Location = New Point(211, 172)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(75, 23)
        btnhapus.TabIndex = 3
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.Yellow
        btnedit.Location = New Point(130, 172)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(75, 23)
        btnedit.TabIndex = 4
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' txtnama
        ' 
        txtnama.ForeColor = SystemColors.WindowText
        txtnama.Location = New Point(130, 49)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(156, 23)
        txtnama.TabIndex = 5
        txtnama.Tag = ""
        ' 
        ' txtnim
        ' 
        txtnim.ForeColor = SystemColors.WindowText
        txtnim.Location = New Point(130, 117)
        txtnim.Name = "txtnim"
        txtnim.Size = New Size(156, 23)
        txtnim.TabIndex = 6
        ' 
        ' dgvhasil
        ' 
        dgvhasil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvhasil.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvhasil.Location = New Point(339, 49)
        dgvhasil.Name = "dgvhasil"
        dgvhasil.Size = New Size(243, 146)
        dgvhasil.TabIndex = 7
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NAMA"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "NIM"
        Column2.Name = "Column2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvhasil)
        Controls.Add(txtnim)
        Controls.Add(txtnama)
        Controls.Add(btnedit)
        Controls.Add(btnhapus)
        Controls.Add(btntambah)
        Controls.Add(lblnim)
        Controls.Add(lblnama)
        Name = "Form1"
        Text = "Form1"
        CType(dgvhasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblnama As Label
    Friend WithEvents lblnim As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtnim As TextBox
    Friend WithEvents dgvhasil As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
