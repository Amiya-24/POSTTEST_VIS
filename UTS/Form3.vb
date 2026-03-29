Public Class Form3
    Public Sub New(nama As String, nim As String, prodi As String, predikat As String, gelar As String)
        InitializeComponent()

        lblNama.Text = nama.ToUpper()
        lblNim.Text = "NIM: " & nim
        lblProdi.Text = prodi.ToUpper()
        lblPredikat.Text = predikat
        lblGelar.Text = gelar
    End Sub

End Class