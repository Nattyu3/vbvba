Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		If Me.WindowState <> FormWindowState.Maximized Then
			Me.WindowState = FormWindowState.Maximized
		Else
			Me.WindowState = FormWindowState.Normal
		End If
	End Sub
End Class
