Public Class frmGenerateQRcode

    Private Sub btnGenerateQRcode_Click(sender As Object, e As EventArgs) Handles btnGenerateQRcode.Click
        Try
            qrcodeControl.SetServerInfo(Me.txtNetAddress.Text, Me.txtTcpPort.Text, Me.txtHTTPPort.Text, Me.txtName.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class