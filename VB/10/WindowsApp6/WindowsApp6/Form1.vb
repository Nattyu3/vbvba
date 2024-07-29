Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		MessageBox.Show("［OK］ボタン または [Enter] が押された", "結果")
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		MessageBox.Show("［Cancel］ボタン または [Esc] が押された", "結果")
		Me.Close()
	End Sub
End Class
