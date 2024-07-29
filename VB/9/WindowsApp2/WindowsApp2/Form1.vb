Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		'「TextBox2」に「TextBox1」の文字列を追加する
		'引数のあるメソッド
		TextBox2.AppendText(TextBox1.Text)
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		'「TextBox2」の文字列を消去する（引数のないメソッド）
		TextBox2.Clear()
	End Sub

End Class
