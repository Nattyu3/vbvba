Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xAry() As String = {"東京", "上野", "大宮", "仙台", "盛岡"}
        Dim yAry() As String
        '初期値の配列を表示
        Me.Label1.Text = ""
        For i As Integer = 0 To xAry.GetUpperBound(0)
            Me.Label1.Text &= xAry(i) & vbCrLf
        Next
        '配列を渡す
        yAry = AryProc(xAry)
        '返値の配列を表示
        Me.Label3.Text = ""
        For i As Integer = 0 To yAry.GetUpperBound(0)
            Me.Label3.Text &= yAry(i) & vbCrLf
        Next
    End Sub

    Private Function AryProc(ByVal aParam() As String) As String()
        '受け取って配列を表示
        Me.Label2.Text = ""
        For i As Integer = 0 To aParam.GetUpperBound(0)
            Me.Label2.Text &= aParam(i) & vbCrLf
        Next
        '配列の値を変更
        aParam(3) = "雪のため遅れ"          '配列の4番目の要素を変更
        aParam(4) = ""                      '配列の5番目の要素を変更
        '配列を返す
        AryProc = aParam
    End Function
End Class
