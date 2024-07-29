Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		Me.FormBorderStyle = FormBorderStyle.Fixed3D
		Label1.Text = "Fixed3D"
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		Me.FormBorderStyle = FormBorderStyle.FixedDialog
		Label1.Text = "FixedDialog"
	End Sub

	Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
		Me.FormBorderStyle = FormBorderStyle.FixedSingle
		Label1.Text = "FixedSingle"
	End Sub

	Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
		Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
		Label1.Text = "FixedToolWindow"
	End Sub

	Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
		Me.FormBorderStyle = FormBorderStyle.Sizable
		Label1.Text = "Sizable"
	End Sub

	Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
		Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
		Label1.Text = "SizableToolWindow"
	End Sub
End Class
