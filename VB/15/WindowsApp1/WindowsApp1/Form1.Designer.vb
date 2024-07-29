<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemFilePrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemEditUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemEditSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemEditDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemEditSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSettingFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxMain = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemFile, Me.MenuItemEdit, Me.MenuItemSetting})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuItemFile
        '
        Me.MenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemFileNew, Me.MenuItemFileOpen, Me.MenuItemFileSave, Me.MenuItemFileSaveAs, Me.MenuItemFileSeparator1, Me.MenuItemFilePrintPreview, Me.MenuItemFilePrint, Me.MenuItemFileSeparator2, Me.MenuItemFileExit})
        Me.MenuItemFile.Name = "MenuItemFile"
        Me.MenuItemFile.Size = New System.Drawing.Size(82, 24)
        Me.MenuItemFile.Text = "ファイル(&F)"
        '
        'MenuItemFileNew
        '
        Me.MenuItemFileNew.Name = "MenuItemFileNew"
        Me.MenuItemFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MenuItemFileNew.Size = New System.Drawing.Size(231, 26)
        Me.MenuItemFileNew.Text = "新規(&N)"
        '
        'MenuItemFileOpen
        '
        Me.MenuItemFileOpen.Name = "MenuItemFileOpen"
        Me.MenuItemFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.MenuItemFileOpen.Size = New System.Drawing.Size(231, 26)
        Me.MenuItemFileOpen.Text = "開く(&O)"
        '
        'MenuItemFileSave
        '
        Me.MenuItemFileSave.Name = "MenuItemFileSave"
        Me.MenuItemFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MenuItemFileSave.Size = New System.Drawing.Size(231, 26)
        Me.MenuItemFileSave.Text = "上書き保存(&S)"
        '
        'MenuItemFileSaveAs
        '
        Me.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs"
        Me.MenuItemFileSaveAs.Size = New System.Drawing.Size(231, 26)
        Me.MenuItemFileSaveAs.Text = "名前を付けて保存(&A)"
        '
        'MenuItemFileSeparator1
        '
        Me.MenuItemFileSeparator1.Name = "MenuItemFileSeparator1"
        Me.MenuItemFileSeparator1.Size = New System.Drawing.Size(228, 6)
        '
        'MenuItemFilePrintPreview
        '
        Me.MenuItemFilePrintPreview.Name = "MenuItemFilePrintPreview"
        Me.MenuItemFilePrintPreview.Size = New System.Drawing.Size(231, 26)
        Me.MenuItemFilePrintPreview.Text = "印刷プレビュー(&V)"
        '
        'MenuItemFilePrint
        '
        Me.MenuItemFilePrint.Name = "MenuItemFilePrint"
        Me.MenuItemFilePrint.Size = New System.Drawing.Size(231, 26)
        Me.MenuItemFilePrint.Text = "印刷(&P)"
        '
        'MenuItemFileSeparator2
        '
        Me.MenuItemFileSeparator2.Name = "MenuItemFileSeparator2"
        Me.MenuItemFileSeparator2.Size = New System.Drawing.Size(228, 6)
        '
        'MenuItemFileExit
        '
        Me.MenuItemFileExit.Name = "MenuItemFileExit"
        Me.MenuItemFileExit.Size = New System.Drawing.Size(231, 26)
        Me.MenuItemFileExit.Text = "終了(&X)"
        '
        'MenuItemEdit
        '
        Me.MenuItemEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemEditUndo, Me.MenuItemEditSeparator1, Me.MenuItemEditCut, Me.MenuItemEditCopy, Me.MenuItemEditPaste, Me.MenuItemEditDelete, Me.MenuItemEditSeparator2, Me.MenuItemEditSelectAll})
        Me.MenuItemEdit.Name = "MenuItemEdit"
        Me.MenuItemEdit.Size = New System.Drawing.Size(71, 24)
        Me.MenuItemEdit.Text = "編集(&E)"
        '
        'MenuItemEditUndo
        '
        Me.MenuItemEditUndo.Name = "MenuItemEditUndo"
        Me.MenuItemEditUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.MenuItemEditUndo.Size = New System.Drawing.Size(229, 26)
        Me.MenuItemEditUndo.Text = "元に戻す(&U)"
        '
        'MenuItemEditSeparator1
        '
        Me.MenuItemEditSeparator1.Name = "MenuItemEditSeparator1"
        Me.MenuItemEditSeparator1.Size = New System.Drawing.Size(226, 6)
        '
        'MenuItemEditCut
        '
        Me.MenuItemEditCut.Name = "MenuItemEditCut"
        Me.MenuItemEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.MenuItemEditCut.Size = New System.Drawing.Size(229, 26)
        Me.MenuItemEditCut.Text = "切り取り(&X)"
        '
        'MenuItemEditCopy
        '
        Me.MenuItemEditCopy.Name = "MenuItemEditCopy"
        Me.MenuItemEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.MenuItemEditCopy.Size = New System.Drawing.Size(229, 26)
        Me.MenuItemEditCopy.Text = "コピー(&C)"
        '
        'MenuItemEditPaste
        '
        Me.MenuItemEditPaste.Name = "MenuItemEditPaste"
        Me.MenuItemEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MenuItemEditPaste.Size = New System.Drawing.Size(229, 26)
        Me.MenuItemEditPaste.Text = "貼り付け(&P)"
        '
        'MenuItemEditDelete
        '
        Me.MenuItemEditDelete.Name = "MenuItemEditDelete"
        Me.MenuItemEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.MenuItemEditDelete.Size = New System.Drawing.Size(229, 26)
        Me.MenuItemEditDelete.Text = "削除(&L)"
        '
        'MenuItemEditSeparator2
        '
        Me.MenuItemEditSeparator2.Name = "MenuItemEditSeparator2"
        Me.MenuItemEditSeparator2.Size = New System.Drawing.Size(226, 6)
        '
        'MenuItemEditSelectAll
        '
        Me.MenuItemEditSelectAll.Name = "MenuItemEditSelectAll"
        Me.MenuItemEditSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MenuItemEditSelectAll.Size = New System.Drawing.Size(229, 26)
        Me.MenuItemEditSelectAll.Text = "すべて選択(&A)"
        '
        'MenuItemSetting
        '
        Me.MenuItemSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemSettingFont})
        Me.MenuItemSetting.Name = "MenuItemSetting"
        Me.MenuItemSetting.Size = New System.Drawing.Size(74, 24)
        Me.MenuItemSetting.Text = "書式(&O)"
        '
        'MenuItemSettingFont
        '
        Me.MenuItemSettingFont.Name = "MenuItemSettingFont"
        Me.MenuItemSettingFont.Size = New System.Drawing.Size(224, 26)
        Me.MenuItemSettingFont.Text = "フォント(&F)"
        '
        'TextBoxMain
        '
        Me.TextBoxMain.Location = New System.Drawing.Point(340, 261)
        Me.TextBoxMain.Name = "TextBoxMain"
        Me.TextBoxMain.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxMain.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuItemFile As ToolStripMenuItem
    Friend WithEvents MenuItemFileExit As ToolStripMenuItem
    Friend WithEvents TextBoxMain As TextBox
    Friend WithEvents MenuItemFileNew As ToolStripMenuItem
    Friend WithEvents MenuItemFileOpen As ToolStripMenuItem
    Friend WithEvents MenuItemFileSave As ToolStripMenuItem
    Friend WithEvents MenuItemFileSaveAs As ToolStripMenuItem
    Friend WithEvents MenuItemFileSeparator1 As ToolStripSeparator
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MenuItemEdit As ToolStripMenuItem
    Friend WithEvents MenuItemEditUndo As ToolStripMenuItem
    Friend WithEvents MenuItemEditSeparator1 As ToolStripSeparator
    Friend WithEvents MenuItemEditCut As ToolStripMenuItem
    Friend WithEvents MenuItemEditCopy As ToolStripMenuItem
    Friend WithEvents MenuItemEditPaste As ToolStripMenuItem
    Friend WithEvents MenuItemEditDelete As ToolStripMenuItem
    Friend WithEvents MenuItemEditSeparator2 As ToolStripSeparator
    Friend WithEvents MenuItemEditSelectAll As ToolStripMenuItem
    Friend WithEvents MenuItemSetting As ToolStripMenuItem
    Friend WithEvents MenuItemSettingFont As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents MenuItemFilePrintPreview As ToolStripMenuItem
    Friend WithEvents MenuItemFilePrint As ToolStripMenuItem
    Friend WithEvents MenuItemFileSeparator2 As ToolStripSeparator
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
