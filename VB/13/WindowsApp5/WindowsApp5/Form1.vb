Public Class Form1
    Private Structure myMenu      '構造体を定義
        Public Menu As String
        Public Price As Integer
        Public ReadOnly Property discount() As Integer
            Get
                Return Price * (1 - 0.4)
            End Get
        End Property
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kzt As myMenu        '構造体の宣言
        '構造体の値を設定し、プロパティを使う
        kzt.Menu = "スラックス"
        kzt.Price = 19800
        MessageBox.Show("値引き価格 -- \" & kzt.discount.ToString(), kzt.Menu)
    End Sub
End Class

