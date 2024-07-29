Public Class Form1
    Private Structure myMenu      '構造体を定義
        Public Menu As String
        Public Price As Integer
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kzt As myMenu
        '構造体の値を設定し、プロシージャを呼び出す
        kzt.Menu = "スーツ"
        kzt.Price = 54800
        ShowData(kzt)
    End Sub

    '構造体を引数として受け取るプロシージャ
    Private Sub ShowData(ByVal nMenu As myMenu)
        MessageBox.Show(nMenu.Menu & "：" & nMenu.Price.ToString & "円", "●●デパート")
    End Sub
End Class
