Imports System.Drawing.Drawing2D

Public Class Form1
	Dim X, Y As Integer  '始点
	Dim flg As Boolean
	Dim rnd As New System.Random(1000)

	Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
		Dim g As Graphics = sender.CreateGraphics()
		Dim liner As New Pen(Color.FromKnownColor(KnownColor.Black), HScrollBar1.Value / 10)        'HScrollBarで線の太さを変えて描画する
		g.SmoothingMode = SmoothingMode.AntiAlias

		If e.Button = MouseButtons.Left Then
			If flg = True Then
				g.DrawLine(liner, X, Y, e.X, e.Y)
				flg = False
			End If
			flg = True
			X = e.X : Y = e.Y
		Else
			flg = False
		End If

		If e.Button = MouseButtons.Right Then
			g.FillEllipse(Brushes.White, e.X, e.Y, 30, 30)
		End If
	End Sub
End Class
