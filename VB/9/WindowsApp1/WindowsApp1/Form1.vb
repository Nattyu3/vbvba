Imports System.Reflection.Emit
Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		'オブジェクト「Label1」に現在の時刻を表示する（プロパティの設定）
		Label1.Text = TimeString
	End Sub
End Class
