Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim d = 1.5
		MessageBox.Show(d, "実数")
		MessageBox.Show(d.ToString("F4"), "文字列")

		Dim s = "123"
		Dim t = "456"
		MessageBox.Show(s + t, "文字列")
		MessageBox.Show(Integer.Parse(s) + Integer.Parse(t), "整数")

	End Sub
End Class
