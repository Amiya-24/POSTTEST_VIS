Public Class Form3
    Public Sub New(nama As String, nim As String, prodi As String, predikat As String, gelar As String)
        InitializeComponent()

        lblNama.Text = nama.ToUpper()
        lblNim.Text = "NIM: " & nim
        lblProdi.Text = prodi.ToUpper()
        lblGelar.Text = gelar
        lblPredikat.Text = predikat

        lblNama.Left = (Me.ClientSize.Width - lblNama.Width) / 2
        lblNim.Left = (Me.ClientSize.Width - lblNim.Width) / 2
        lblProdi.Left = (Me.ClientSize.Width - lblProdi.Width) / 2
        lblGelar.Left = (Me.ClientSize.Width - lblGelar.Width) / 2
    End Sub
End Class