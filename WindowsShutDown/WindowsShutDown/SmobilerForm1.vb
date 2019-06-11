Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Smobiler.Core
Imports Smobiler.Core.Controls
Imports System.Runtime.InteropServices

Public Class SmobilerForm1
    Inherits Smobiler.Core.Controls.MobileForm

    Public Sub New()
        MyBase.New()

        'This call is required by the SmobilerForm.
        InitializeComponent()

    End Sub

    Private Sub Button1_Press(sender As Object, e As EventArgs) Handles Button1.Press

        System.Diagnostics.Process.Start("shutdown.exe", "-s -t 0")

    End Sub

End Class
