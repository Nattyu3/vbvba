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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFileSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxMain = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuItemFile
        '
        Me.MenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemFileNew, Me.MenuItemFileOpen, Me.MenuItemFileSave, Me.MenuItemFileSaveAs, Me.MenuItemFileSeparator1, Me.MenuItemFileExit})
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
        'MenuItemFileExit
        '
        Me.MenuItemFileExit.Name = "MenuItemFileExit"
        Me.MenuItemFileExit.Size = New System.Drawing.Size(231, 26)
        Me.MenuItemFileExit.Text = "終了(&X)"
        '
        'TextBoxMain
        '
        Me.TextBoxMain.Location = New System.Drawing.Point(315, 163)
        Me.TextBoxMain.Name = "TextBoxMain"
        Me.TextBoxMain.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxMain.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
End Class
