<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnComfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'richTextBox1
        '
        Me.richTextBox1.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.richTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.ReadOnly = True
        Me.richTextBox1.Size = New System.Drawing.Size(571, 266)
        Me.richTextBox1.TabIndex = 1
        Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
        '
        'btnComfirm
        '
        Me.btnComfirm.Location = New System.Drawing.Point(264, 285)
        Me.btnComfirm.Name = "btnComfirm"
        Me.btnComfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnComfirm.TabIndex = 2
        Me.btnComfirm.Text = "确定"
        Me.btnComfirm.UseVisualStyleBackColor = True
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 320)
        Me.Controls.Add(Me.btnComfirm)
        Me.Controls.Add(Me.richTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "帮助"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents richTextBox1 As RichTextBox
    Private WithEvents btnComfirm As Button
End Class
