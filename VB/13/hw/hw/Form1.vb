Public Class Form1
    '変数のPublic宣言
    Public y0 As Integer
    Public yh As Integer
    Public x0 As Integer
    Public xw As Integer
    Public g As Graphics
    Public points(2) As Point
    Public xyz(2, 2) As Double      '配列変数にxyz座標を設定
    Public ang As Double            '回転角度変数宣言
    Public mat(2, 2) As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g = Me.PictureBox1.CreateGraphics()

        y0 = Me.PictureBox1.Height / 2.0
        yh = Me.PictureBox1.Height
        x0 = Me.PictureBox1.Width / 2.0
        xw = Me.PictureBox1.Width

        '座標データをクリア
        TextBox1.Text = 0       'x1 xyz(0,0)
        TextBox2.Text = 0       'y1 xyz(0,1)　
        TextBox3.Text = 0       'z1 xyz(0,2)
        TextBox4.Text = 0       'x2 xyz(1,0)
        TextBox5.Text = 0       'y2 xyz(1,1)
        TextBox6.Text = 0       'z2 xyz(1,2)
        TextBox7.Text = 0       'x3 xyz(2,0)
        TextBox8.Text = 0       'y3 xyz(2,1)
        TextBox9.Text = 0       'z3 xyz(2,2)

        ang = 0.2           '回転角度 0.2(rad)

        mat(0, 0) = Math.Cos(ang)
        mat(0, 1) = -Math.Sin(ang)
        mat(0, 2) = 0
        mat(1, 0) = Math.Sin(ang)
        mat(1, 1) = Math.Cos(ang)
        mat(1, 2) = 0
        mat(2, 0) = 0
        mat(2, 1) = 0
        mat(2, 2) = 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Point_set()         '(Sub)回転前の点を設定
        g.DrawPolygon(Pens.White, points)   '閉ライン(白)を引く(過去のラインを消す)
        coodrinate()            '(Sub)座標軸表示
        '座標の初期設定
        TextBox1.Text = 80  'x1
        TextBox2.Text = 60  'y1
        TextBox3.Text = 70  'z1

        TextBox4.Text = -70 'x2
        TextBox5.Text = -80 'y2
        TextBox6.Text = -70 'z2

        TextBox7.Text = 10  'x3
        TextBox8.Text = 40  'y3
        TextBox9.Text = -50 'z3

        Conv_text()                       'xyzにTextBoxを代入
        Point_set()                       '(Sub)回転後の点を設定
        g.DrawPolygon(Pens.Black, points) '閉ライン(黒)を引く
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Point_set()
        g.DrawPolygon(Pens.White, points)
        coodrinate()

        Dim M(2, 2) As Double
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                M(i, j) = mat(2 - i, 2 - j)
            Next
        Next

        rotate(M)

        Point_set()
        g.DrawPolygon(Pens.Black, points)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Point_set()
        g.DrawPolygon(Pens.White, points)
        coodrinate()

        Dim M(2, 2) As Double
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                M(i, j) = mat((i * 2) Mod 3, (j * 2) Mod 3)
            Next
        Next

        rotate(M)

        Point_set()
        g.DrawPolygon(Pens.Black, points)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Point_set()
        g.DrawPolygon(Pens.White, points)
        coodrinate()

        Dim M(2, 2) As Double
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                M(i, j) = mat(i, j)
            Next
        Next

        rotate(M)

        Point_set()
        g.DrawPolygon(Pens.Black, points)
    End Sub

    Sub coodrinate()    '座標軸表示
        g.DrawLine(Pens.Black, 0, y0, xw, y0)
        g.DrawLine(Pens.Black, x0, 0, x0, yh)
    End Sub

    Sub Point_set() 'ラインを結ぶ点を設定
        points(0) = New Point(CInt(TextBox1.Text) + x0, -CInt(TextBox2.Text) + y0)
        points(1) = New Point(CInt(TextBox4.Text) + x0, -CInt(TextBox5.Text) + y0)
        points(2) = New Point(CInt(TextBox7.Text) + x0, -CInt(TextBox8.Text) + y0)
    End Sub

    Sub Conv_text() 'TextBoxデータを配列に代入
        xyz(0, 0) = TextBox1.Text
        xyz(0, 1) = TextBox2.Text
        xyz(0, 2) = TextBox3.Text
        xyz(1, 0) = TextBox4.Text
        xyz(1, 1) = TextBox5.Text
        xyz(1, 2) = TextBox6.Text
        xyz(2, 0) = TextBox7.Text
        xyz(2, 1) = TextBox8.Text
        xyz(2, 2) = TextBox9.Text
    End Sub

    Sub rotate(M As Double(,)) '座標を回転
        Dim xyz2(2, 2) As Double
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                xyz2(i, j) = 0
                For k As Integer = 0 To 2
                    xyz2(i, j) += xyz(i, k) * M(k, j)
                Next
            Next
        Next
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                xyz(i, j) = xyz2(i, j)
            Next
        Next

        TextBox1.Text = xyz(0, 0)
        TextBox2.Text = xyz(0, 1)
        TextBox3.Text = xyz(0, 2)
        TextBox4.Text = xyz(1, 0)
        TextBox5.Text = xyz(1, 1)
        TextBox6.Text = xyz(1, 2)
        TextBox7.Text = xyz(2, 0)
        TextBox8.Text = xyz(2, 1)
        TextBox9.Text = xyz(2, 2)
    End Sub

End Class
