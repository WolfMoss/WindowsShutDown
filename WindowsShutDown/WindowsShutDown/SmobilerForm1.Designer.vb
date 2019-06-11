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
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.Text = "立即关机"
        '
        'SmobilerForm1
        '
        Me.Controls.AddRange(New Smobiler.Core.Controls.MobileControl() {Me.Button1})
        Me.Name = "SmobilerForm1"

    End Sub

    Friend WithEvents Button1 As Controls.Button

#End Region

End Class
