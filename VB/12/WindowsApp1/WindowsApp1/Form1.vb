Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		Dim g_Line As Graphics = Me.PictureBox1.CreateGraphics()    ' Grahicsオブジェクトを取得
		' 普通の直線
		g_Line.DrawLine(Pens.Black, 10, 20, Me.PictureBox1.Width - 10, Me.PictureBox1.Height - 20)
		' 太い線
		Dim boldPen As New Pen(Color.Black, 5)      '新しいペンの設定
		g_Line.DrawLine(boldPen, 0, 60, Me.PictureBox1.Width - 20, 50)

		' 点線
		Dim dotPen As New Pen(Color.Red)    '新しいペンの設定
		dotPen.DashStyle = Drawing2D.DashStyle.Dot  '点線の設定
		g_Line.DrawLine(dotPen, 50, 10, 50, Me.PictureBox1.Height - 20)
	End Sub
End Class
