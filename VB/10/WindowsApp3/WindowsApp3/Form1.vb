Public Class Form1
	Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
		MessageBox.Show("ラベルに表示する文字はTextプロパティで指定します")
	End Sub

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		MessageBox.Show("ボタンに表示する文字はTextプロパティで指定します")
	End Sub
End Class
