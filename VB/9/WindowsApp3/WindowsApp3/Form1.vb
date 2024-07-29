Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		'「Button1」をクリック
		'現在の日付を「Label1」に表示する
		Label1.Text = "現在の時刻：" & TimeString
	End Sub

	Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
		'「Label1」をクリック
		'現在の日付を「Label1」に表示する
		Label1.Text = "現在の時刻：" & TimeString
	End Sub

	Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
		'マウスが「Button1」上を移動
		'現在の日付を「Label1」に表示する
		Label1.Text = "今日の日付：" & DateString
	End Sub
End Class
