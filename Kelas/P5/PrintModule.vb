Imports System.Drawing.Printing
Module PrintModule
    Public LaporanBukuData As DataTable = Nothing
    Public CurrentRow As Integer = 0
    Public Sub SetLaporanBuku(data As DataTable)
        LaporanBukuData = data
        CurrentRow = 0
    End Sub
    Public Sub RenderLaporanBuku(e As PrintPageEventArgs)
        If LaporanBukuData Is Nothing OrElse LaporanBukuData.Rows.Count = 0 Then
            Using fontKosong As New Font("Calibri", 12, FontStyle.Regular)
                e.Graphics.DrawString("Tidak ada data yang dapat dicetak.", fontKosong, Brushes.Black, 50, 50)

            End Using
            e.HasMorePages = False
            Return
        End If
        Dim area As Rectangle = e.MarginBounds
        Dim currentY As Integer = area.Top
        Dim rowHeight As Integer = 28
        Using fontJudul As New Font("Times New Roman", 18, FontStyle.Bold),
              fontSubJudul As New Font("Calibri", 10, FontStyle.Italic),
              fontHeader As New Font("Calibri", 10, FontStyle.Bold),
              fontIsi As New Font("Calibri", 10, FontStyle.Regular),
              penaTabel As New Pen(Color.Black, 1),
              brushHeader As New SolidBrush(Color.Gainsboro)
            e.Graphics.DrawString("LAPORAN DATA BUKU", fontJudul, Brushes.Black, area.Left, currentY)
            currentY += 30
            e.Graphics.DrawString("Perpustakaan - Hasil Cetak Sistem", fontSubJudul, Brushes.Gray, area.Left, currentY)
            currentY += 20
            e.Graphics.DrawLine(penaTabel, area.Left, currentY, area.Right, currentY)
            currentY += 10
            Dim kolom() As String = {"Kode", "Jenis", "Judul", "Pengarang", "Penerbit", "Jumlah"}

            Dim lebar() As Integer = {70, 100, 180, 120, 120, 70}
            Dim x As Integer = area.Left
            For i As Integer = 0 To kolom.Length - 1
                Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                DrawCell(e.Graphics, kolom(i), fontHeader, Brushes.Black, penaTabel, rect, StringAlignment.Center, brushHeader)
                x += lebar(i)
            Next
            currentY += rowHeight
            While CurrentRow < LaporanBukuData.Rows.Count
                If currentY + rowHeight > area.Bottom - 30 Then
                    e.HasMorePages = True
                    Return
                End If
                Dim row As DataRow = LaporanBukuData.Rows(CurrentRow)
                Dim isi() As String = {
                    row("KodeBuku").ToString(),
                    row("JenisBuku").ToString(),
                    row("JudulBuku").ToString(),
                    row("Pengarang").ToString(),
                    row("Penerbit").ToString(),
                    row("JumlahBuku").ToString()
                }
                x = area.Left
                For i As Integer = 0 To isi.Length - 1
                    Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                    If i = 5 Then
                        DrawCell(e.Graphics, isi(i), fontIsi, Brushes.Black, penaTabel, rect, StringAlignment.Center)

                    Else
                        DrawCell(e.Graphics, isi(i), fontIsi, Brushes.Black, penaTabel, rect, StringAlignment.Near)

                    End If
                    x += lebar(i)
                Next
                currentY += rowHeight
                CurrentRow += 1
            End While
            e.Graphics.DrawString("Total Data: " & LaporanBukuData.Rows.Count.ToString(),
            New Font("Calibri", 9, FontStyle.Italic),
            Brushes.Black,
            area.Left,
            currentY + 8
            )
        End Using
        e.HasMorePages = False
    End Sub
    Private Sub DrawCell(
g As Graphics,
text As String,
font As Font,
brush As Brush,
pen As Pen,
rect As Rectangle,
alignment As StringAlignment,
Optional fillBrush As Brush = Nothing
)
        If fillBrush IsNot Nothing Then
            g.FillRectangle(fillBrush, rect)
        End If
        g.DrawRectangle(pen, rect)
        Dim sf As New StringFormat()
        sf.Alignment = alignment
        sf.LineAlignment = StringAlignment.Center
        sf.Trimming = StringTrimming.EllipsisCharacter
        Dim innerRect As New RectangleF(rect.X + 4, rect.Y + 2, rect.Width - 8,
rect.Height - 4)
        g.DrawString(text, font, brush, innerRect, sf)
    End Sub
End Module