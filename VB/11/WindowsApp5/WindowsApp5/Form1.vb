Public Class Form1
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

		Dim f As Single = 100000000
		f = f + 1
		MessageBox.Show("Single型 ⇒ " + f.ToString("F"))

		Dim g As Double = 100000000
		g = g + 1
		MessageBox.Show("Double型 ⇒ " & g.ToString("F"))

	End Sub
End Class
