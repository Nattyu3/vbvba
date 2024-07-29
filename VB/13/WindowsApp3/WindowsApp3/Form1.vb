Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '初期設定
        Dim Ary() As String = {"H", "He", "Li", "Be", "B", "C", "N", "O", "F", "N"}
        Me.Label1.Text = Ary(0) & ", " & Ary(1) & ", " & Ary(2) & ", " & Ary(3) & ", " & Ary(4) & ", " _
                                    & Ary(5) & ", " & Ary(6) & ", " & Ary(7) & ", " & Ary(8) & ", " & Ary(9)

        Array.Clear(Ary, 3, 4)        'Ary(3)の要素から4つの要素をクリア
        Me.Label2.Text = Ary(0) & ", " & Ary(1) & ", " & Ary(2) & ", " & Ary(3) & ", " & Ary(4) & ", " _
                                    & Ary(5) & ", " & Ary(6) & ", " & Ary(7) & ", " & Ary(8) & ", " & Ary(9)
    End Sub
End Class

