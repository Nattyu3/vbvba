Public Class Form1
	Private FileName As String = ""  '　名前を付けて保存対策
	Private PrintString As String

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.Text = "MyMemo"
		TextBoxMain.Multiline = True
		TextBoxMain.ScrollBars = ScrollBars.Vertical
		TextBoxMain.Dock = DockStyle.Fill
		SaveFileDialog1.Filter = "テキスト文章|*.txt|すべてのファイル|*.**"
		MenuItemEdit_DropDownOpening(sender, e)
		FontDialog1.ShowEffects = False
		FontDialog1.AllowScriptChange = False

		PrintDialog1.Document = PrintDocument1
		PrintPreviewDialog1.Document = PrintDocument1
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

	'　「上書き保存」メソッド
	Private Sub MenuItemFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFileSave.Click
		SaveFile(SaveFileDialog1.FileName)
	End Sub

	'　「名前を付けて保存」メソッド
	Private Sub MenuItemFileSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFileSaveAs.Click
		'　（追加）名前を付けて保存対策
		SaveFileDialog1.FileName = System.IO.Path.GetFileName(FileName)
		If DialogResult.OK = SaveFileDialog1.ShowDialog() Then
			SaveFile(SaveFileDialog1.FileName)
		End If
	End Sub

	'　SaveFileメソッド
	Private Sub SaveFile(ByVal Value As String)
		System.IO.File.WriteAllText(Value, TextBoxMain.Text)
		FileName = Value  '　（追加）名前を付けて保存対策
	End Sub

	'　「切り取り」メソッド
	Private Sub MenuItemEditCut_Click(sender As Object, e As EventArgs) Handles MenuItemEditCut.Click
		TextBoxMain.Cut()
	End Sub

	'　「コピー」メソッド
	Private Sub MenuItemEditCopy_Click(sender As Object, e As EventArgs) Handles MenuItemEditCopy.Click
		TextBoxMain.Copy()
	End Sub

	'　「貼り付け」メソッド
	Private Sub MenuItemEditPaste_Click(sender As Object, e As EventArgs) Handles MenuItemEditPaste.Click
		TextBoxMain.Paste()
	End Sub

	'　「削除」メソッド
	Private Sub MenuItemEditDelete_Click(sender As Object, e As EventArgs) Handles MenuItemEditDelete.Click
		TextBoxMain.SelectedText = ""
	End Sub

	'　「すべて選択」メソッド
	Private Sub MenuItemEditSelectAll_Click(sender As Object, e As EventArgs) Handles MenuItemEditSelectAll.Click
		TextBoxMain.SelectAll()
	End Sub

	' Deleteキー（1文字を削除）対策　（飛ばしても良い）
	Private Sub MenuItemEdit_DropDownOpening(sender As Object, e As EventArgs) Handles MenuItemEdit.DropDownOpening
		MenuItemEditPaste.Enabled = Clipboard.ContainsText
		Dim sa = TextBoxMain.SelectionLength = 0
		MenuItemEditCut.Enabled = Not sa
		MenuItemEditCopy.Enabled = Not sa
		MenuItemEditDelete.Enabled = Not sa
		sa = TextBoxMain.TextLength = 0
		MenuItemEditSelectAll.Enabled = Not sa
	End Sub

	' Deleteキー（1文字を削除）対策
	Private Sub MenuItemEdit_DropDownClosed(sender As Object, e As EventArgs) Handles MenuItemEdit.DropDownClosed
		MenuItemEditDelete.Enabled = False
	End Sub

	' 「フォント」メソッド
	Private Sub MenuItemSettingFont_Click(sender As Object, e As EventArgs) Handles MenuItemSettingFont.Click
		FontDialog1.Font = TextBoxMain.Font
		If DialogResult.OK = FontDialog1.ShowDialog() Then
			TextBoxMain.Font = FontDialog1.Font
		End If
	End Sub

	' 「印刷」メソッド
	Private Sub MenuItemFilePrint_Click(sender As Object, e As EventArgs) Handles MenuItemFilePrint.Click
		'SetPrintDocument1()		‘コメント文に変更
		'PrintDocument1.Print()

		If DialogResult.OK = PrintDialog1.ShowDialog() Then 'Dialog付
			SetPrintDocument1()
			PrintDocument1.Print()
		End If
	End Sub

	'　SetPrintDocument1メソッド
	Private Sub SetPrintDocument1()
		PrintString = TextBoxMain.Text
		PrintDocument1.DefaultPageSettings.Margins = New Printing.Margins(20, 60, 20, 60)
		PrintDocument1.DocumentName = FileName
	End Sub

	'　PrintDocument1_PrintPageメソッド
	Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
		Dim charactersOnPage As Integer = 0
		Dim linesPerPage As Integer = 0
		e.Graphics.MeasureString(PrintString, TextBoxMain.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, charactersOnPage, linesPerPage)
		e.Graphics.DrawString(PrintString, TextBoxMain.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic)
		PrintString = PrintString.Substring(charactersOnPage)
		If PrintString.Length > 0 Then
			e.HasMorePages = True
		Else
			e.HasMorePages = False
			PrintString = TextBoxMain.Text
		End If
	End Sub

	'　「印刷プレビュー」メソッド
	Private Sub MenuItemFilePrintPreview_Click(sender As Object, e As EventArgs) Handles MenuItemFilePrintPreview.Click

		Dim b = TextBoxMain.TextLength = 0
		MenuItemFilePrint.Enabled = Not b
		MenuItemFilePrintPreview.Enabled = Not b

		SetPrintDocument1()
		PrintPreviewDialog1.ShowDialog()

	End Sub

End Class
