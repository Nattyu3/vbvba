Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
End Class
