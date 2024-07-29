Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Label1.Text = "透明度   " & CInt(Me.Opacity * 100) & "%"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Opacity -= 0.1
        Label1.Text = "透明度   " & CInt(Me.Opacity * 100) & "%"
    End Sub
End Class
