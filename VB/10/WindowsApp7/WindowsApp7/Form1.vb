Imports System.Reflection.Emit
Public Class Form1
	Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		'Me.Button1.Text = "OK"
		'Me.Button2.Text = "Cancel"
		Me.AcceptButton = Button1
		Me.CancelButton = Button2
		Label1.Text = ("フォーム読み込み時に承認ボタン、キャンセルボタンを設定しました")
	End Sub
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		MessageBox.Show("［OK］ボタンがクリックされました")
	End Sub
	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		MessageBox.Show("キャンセルします")
		Me.Close()
	End Sub
End Class
