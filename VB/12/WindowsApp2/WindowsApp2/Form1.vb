Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		Dim g_Box As Graphics = Me.PictureBox1.CreateGraphics()     ' Grahicsオブジェクトを取得
		'四角形を描画する
		g_Box.DrawRectangle(Pens.Black, 10, 10, 100, 100)
		'塗り潰した四角形を描画する
		g_Box.FillRectangle(Brushes.Red, 50, 50, 200, 100)
	End Sub
End Class
