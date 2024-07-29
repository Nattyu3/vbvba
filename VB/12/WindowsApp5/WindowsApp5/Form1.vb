Imports System.Drawing.Drawing2D

Public Class Form1
	Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
		Dim g As Graphics = sender.CreateGraphics()
		g.SmoothingMode = SmoothingMode.AntiAlias
		If e.Button = MouseButtons.Left Then
			g.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5)
		ElseIf e.Button = MouseButtons.Right Then
			g.FillEllipse(Brushes.White, e.X, e.Y, 30, 30)
		End If
	End Sub
End Class
