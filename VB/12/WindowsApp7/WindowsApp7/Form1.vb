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

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		Dim g_Box As Graphics = Me.PictureBox1.CreateGraphics()     ' Grahicsオブジェクトを取得
		'四角形を描画する
		g_Box.DrawRectangle(Pens.Black, 10, 10, 100, 100)
		'塗り潰した四角形を描画する
		g_Box.FillRectangle(Brushes.Red, 50, 50, 200, 100)
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Dim g_Ell As Graphics = Me.PictureBox1.CreateGraphics() 'Grahicsオブジェクトを取得
		'円を描画する
		g_Ell.DrawEllipse(Pens.Black, 10, 10, 100, 100)
		'塗り潰した楕円を描画する
		g_Ell.FillEllipse(Brushes.Blue, 50, 50, 200, 100)
	End Sub

	Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
		Dim g As Graphics = Me.PictureBox1.CreateGraphics()  ' Grahicsオブジェクトを取得
		Dim points(7) As Point      '配列
		'折れ線グラフを描画する
		points(0) = New Point(10, 100)
		points(1) = New Point(40, 50)
		points(2) = New Point(80, 70)
		points(3) = New Point(120, 20)
		points(4) = New Point(160, 80)
		points(5) = New Point(200, 50)
		points(6) = New Point(240, 70)
		points(7) = New Point(280, 20)
		g.DrawLines(Pens.Black, points)
		'閉じた多角形を描画する
		points(0) = New Point(20, 150)
		points(1) = New Point(50, 100)
		points(2) = New Point(90, 120)
		points(3) = New Point(130, 70)
		points(4) = New Point(170, 130)
		points(5) = New Point(210, 100)
		points(6) = New Point(250, 120)
		points(7) = New Point(290, 70)
		g.DrawPolygon(Pens.Red, points)
	End Sub

	Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
		Dim g_Lin As Graphics = Me.PictureBox1.CreateGraphics()
		'普通の直線
		Dim y0 As Integer = Me.PictureBox1.Height / 2.0
		Dim yh As Integer = Me.PictureBox1.Height
		Dim x0 As Integer = Me.PictureBox1.Width / 2.0
		Dim xw As Integer = Me.PictureBox1.Width
		g_Lin.DrawLine(Pens.Black, 0, y0, xw, y0)
		g_Lin.DrawLine(Pens.Black, x0, 0, x0, yh)
	End Sub

End Class
