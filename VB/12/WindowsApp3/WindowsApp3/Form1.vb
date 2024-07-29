Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim g_Ell As Graphics = Me.PictureBox1.CreateGraphics() 'Grahicsオブジェクトを取得
		'円を描画する
		g_Ell.DrawEllipse(Pens.Black, 10, 10, 100, 100)
		'塗り潰した楕円を描画する
		g_Ell.FillEllipse(Brushes.Blue, 50, 50, 200, 100)
	End Sub
End Class
