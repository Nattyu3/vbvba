Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ary() As String = {"月", "火", "水", "木", "金", "土", "日"}
        MessageBox.Show(Ary(3))
    End Sub
End Class
