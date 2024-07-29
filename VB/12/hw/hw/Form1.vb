Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim PG As Graphics = Me.PictureBox1.CreateGraphics()

        Dim xw As Integer = Me.PictureBox1.Width
        Dim yh As Integer = Me.PictureBox1.Height
        Dim x0 As Integer = xw / 2
        Dim y0 As Integer = yh / 2
        PG.DrawLine(Pens.Black, 0, y0, xw, y0)
        PG.DrawLine(Pens.Black, x0, 0, x0, yh)

        Dim dx As Integer = xw / 20
        Dim dy As Integer = yh / 20
        For i As Integer = 1 To 10
            Dim ty As Integer = i * dy
            PG.DrawLine(Pens.Black, x0 - 5, y0 + ty, x0 + 5, y0 + ty)
            PG.DrawLine(Pens.Black, x0 - 5, y0 - ty, x0 + 5, y0 - ty)
        Next
        For i As Integer = 1 To 10
            Dim tx As Integer = i * dx
            PG.DrawLine(Pens.Black, x0 + tx, y0 - 5, x0 + tx, y0 + 5)
            PG.DrawLine(Pens.Black, x0 - tx, y0 - 5, x0 - tx, y0 + 5)
        Next

        Dim Plot(199) As Point
        Dim X As Double = -dx
        Dim Y As Double
        For i As Integer = 0 To 199
            X += dx / 100
            Y = X * X + X - 6
            Plot(i) = New Point(X * dx + x0, -Y * dy + y0)
        Next
        PG.DrawLines(Pens.DarkOrange, Plot)
    End Sub
End Class
