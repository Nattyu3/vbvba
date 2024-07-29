Public Class Form1
    Private Structure myPoint      '構造体を定義
        Public xPoint As Integer
        Public yPoint As Integer
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pt As myPoint
        'プロシージャを呼び出して、構造体を戻り値として受け取る
        pt = TwicePoint(10, 25)
        MessageBox.Show("　xの位置　：　" & pt.xPoint & vbCrLf _
                  & "　yの位置　：　" & pt.yPoint, "戻り値")
    End Sub

    '構造体を戻り値として返すプロシージャ
    Private Function TwicePoint(ByVal x As Integer, ByVal y As Integer) As myPoint
        Dim DispPoint As myPoint        '構造体型変数を宣言
        DispPoint.xPoint = x * 5
        DispPoint.yPoint = y * 5
        Return DispPoint                '構造体を返す
    End Function
End Class

