Public Class Form1
	Private FileName As String = ""  '（追加）名前を付けて保存対策

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Text = "MyMemo"

		TextBoxMain.Multiline = True
		TextBoxMain.ScrollBars = ScrollBars.Vertical
		TextBoxMain.Dock = DockStyle.Fill

		SaveFileDialog1.Filter = "テキスト文章|*.txt|すべてのファイル|*.**"
	End Sub

	'　「終了」メソッド
	Private Sub MenuItemFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFileExit.Click
		Me.Close()
	End Sub

	'　「新規」メソッド
	Private Sub MenuItemFileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFileNew.Click
		TextBoxMain.Text = “”
	End Sub

	'　「開く」メソッド
	Private Sub MenuItemFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFileOpen.Click
		OpenFileDialog1.FileName = ""
		'OpenFileDialog1.ShowDialog()
		'LoadFile(OpenFileDialog1.FileName)

		If DialogResult.OK = OpenFileDialog1.ShowDialog() Then
			LoadFile(OpenFileDialog1.FileName)
		End If

		SaveFileDialog1.FileName = OpenFileDialog1.FileName
	End Sub

	'　LoadFileメソッド
	Private Sub LoadFile(ByVal Value As String)
		TextBoxMain.Text = System.IO.File.ReadAllText(Value)

		FileName = Value  '　（追加）名前を付けて保存対策
	End Sub

	'　「上書き保存」メソッド - 1
	Private Sub MenuItemFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFileSave.Click
		SaveFile(SaveFileDialog1.FileName)
	End Sub

	'　「名前を付けて保存」メソッド - 1
	Private Sub MenuItemFileSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFileSaveAs.Click
		'　（追加）名前を付けて保存対策
		SaveFileDialog1.FileName = System.IO.Path.GetFileName(FileName)

		If DialogResult.OK = SaveFileDialog1.ShowDialog() Then
			SaveFile(SaveFileDialog1.FileName)
		End If
	End Sub

	'　SaveFileメソッド - 1
	Private Sub SaveFile(ByVal Value As String)
		System.IO.File.WriteAllText(Value, TextBoxMain.Text)

		FileName = Value  '　（追加）名前を付けて保存対策
	End Sub

End Class
