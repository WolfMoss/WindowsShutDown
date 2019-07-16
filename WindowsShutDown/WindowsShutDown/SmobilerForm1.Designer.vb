Imports Smobiler.Core

Partial Public Class SmobilerForm1
    Inherits Smobiler.Core.Controls.MobileForm

#Region "SmobilerForm Designer generated code "

    'SmobilerForm overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub


    'NOTE: The following procedure is required by the SmobilerForm
    'It can be modified using the SmobilerForm.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New Smobiler.Core.Controls.Button()
        Me.Line1 = New Smobiler.Core.Controls.Line()
        Me.Label1 = New Smobiler.Core.Controls.Label()
        Me.Button2 = New Smobiler.Core.Controls.Button()
        Me.Button3 = New Smobiler.Core.Controls.Button()
        Me.Button4 = New Smobiler.Core.Controls.Button()
        Me.Button5 = New Smobiler.Core.Controls.Button()
        Me.Line2 = New Smobiler.Core.Controls.Line()
        Me.Label2 = New Smobiler.Core.Controls.Label()
        Me.Button6 = New Smobiler.Core.Controls.Button()
        Me.Button7 = New Smobiler.Core.Controls.Button()
        Me.Button8 = New Smobiler.Core.Controls.Button()
        Me.Button9 = New Smobiler.Core.Controls.Button()
        Me.txtPos = New Smobiler.Core.Controls.TextBox()
        Me.Line3 = New Smobiler.Core.Controls.Line()
        Me.Button10 = New Smobiler.Core.Controls.Button()
        Me.Button11 = New Smobiler.Core.Controls.Button()
        Me.Label3 = New Smobiler.Core.Controls.Label()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.Text = "立即关机"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(0, 54)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(300, 2)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.Text = "鼠标移动"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.Text = "上"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 30)
        Me.Button3.Text = "左"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(207, 125)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 30)
        Me.Button4.Text = "右"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(95, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 30)
        Me.Button5.Text = "下"
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(0, 204)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(300, 2)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.Text = "键盘方向"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(95, 235)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 30)
        Me.Button6.Text = "上"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(0, 274)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 30)
        Me.Button7.Text = "左"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(207, 274)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 30)
        Me.Button8.Text = "右"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(95, 315)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 30)
        Me.Button9.Text = "下"
        '
        'txtPos
        '
        Me.txtPos.Location = New System.Drawing.Point(195, 56)
        Me.txtPos.Name = "txtPos"
        Me.txtPos.Size = New System.Drawing.Size(100, 24)
        Me.txtPos.Text = "10"
        '
        'Line3
        '
        Me.Line3.Location = New System.Drawing.Point(0, 358)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(300, 2)
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(0, 398)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(100, 30)
        Me.Button10.Text = "左键单击"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(207, 398)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(100, 30)
        Me.Button11.Text = "右键单击"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(135, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.Text = "移动像素:"
        '
        'SmobilerForm1
        '
        Me.Controls.AddRange(New Smobiler.Core.Controls.MobileControl() {Me.Button1, Me.Line1, Me.Label1, Me.Button2, Me.Button3, Me.Button4, Me.Button5, Me.Line2, Me.Label2, Me.Button6, Me.Button7, Me.Button8, Me.Button9, Me.txtPos, Me.Line3, Me.Button10, Me.Button11, Me.Label3})
        Me.Name = "SmobilerForm1"

    End Sub

    Friend WithEvents Button1 As Controls.Button
    Friend WithEvents Line1 As Controls.Line
    Friend WithEvents Label1 As Controls.Label
    Friend WithEvents Button2 As Controls.Button
    Friend WithEvents Button3 As Controls.Button
    Friend WithEvents Button4 As Controls.Button
    Friend WithEvents Button5 As Controls.Button
    Friend WithEvents Line2 As Controls.Line
    Friend WithEvents Label2 As Controls.Label
    Friend WithEvents Button6 As Controls.Button
    Friend WithEvents Button7 As Controls.Button
    Friend WithEvents Button8 As Controls.Button
    Friend WithEvents Button9 As Controls.Button
    Friend WithEvents txtPos As Controls.TextBox
    Friend WithEvents Line3 As Controls.Line
    Friend WithEvents Button10 As Controls.Button
    Friend WithEvents Button11 As Controls.Button
    Friend WithEvents Label3 As Controls.Label

#End Region

End Class
