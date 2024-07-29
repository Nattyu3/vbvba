Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Ary(4) As Integer
        Me.Label1.Text = ""
        For i As Integer = 0 To 4
            Ary(i) = i * 2
            Me.Label1.Text &= "Ary(" & i.ToString() & ") = " & Ary(i)
            Me.Label1.Text &= ControlChars.NewLine
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Ary(2, 3) As Integer
        Me.Label1.Text = ""
        For i As Integer = 0 To 2
            For j As Integer = 0 To 3
                Ary(i, j) = i * j
                Me.Label1.Text &= "Ary(" & i.ToString() & ", " _
                                & j.ToString() & ") = " & Ary(i, j) & "　"
            Next
            Me.Label1.Text &= ControlChars.NewLine
        Next
    End Sub
End Class
