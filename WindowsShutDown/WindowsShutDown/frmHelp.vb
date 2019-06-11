Public Class frmHelp
    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        Me.Close()
    End Sub

    Private Sub richTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles richTextBox1.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub frmHelp_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        System.Diagnostics.Process.Start("http://smobiler.com/developers.html")
    End Sub
End Class