Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s = "123.45"
        MessageBox.Show("文字列 : " + s, "文字列")

        Dim x As Double = CDbl(s)
        MessageBox.Show("実数 : " & x, "実数")

        Const c As Double = 67.89
        x += c
        MessageBox.Show("実数 : " & x, "実数")

        MessageBox.Show("文字列 : " + x.ToString("F5"), "文字列")
    End Sub
End Class
