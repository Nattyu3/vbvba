Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("こんにちは！")
        MessageBox.Show("こんにちは！", "タイトル")
        MessageBox.Show("こ” & Environment.NewLine & “んにちは！")
        MessageBox.Show("こん” & vbCrLf & “にちは！")
    End Sub


End Class
