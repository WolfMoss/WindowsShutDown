<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateQRcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerateQRcode))
        Me.btnGenerateQRcode = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtHTTPPort = New System.Windows.Forms.TextBox()
        Me.txtTcpPort = New System.Windows.Forms.TextBox()
        Me.txtNetAddress = New System.Windows.Forms.TextBox()
        Me.labHTTPPort = New System.Windows.Forms.Label()
        Me.labTCPPort = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.qrcodeControl = New Smobiler.Utility.Encoding.Windows.Forms.QrCodeImgControl()
        Me.txtName = New System.Windows.Forms.TextBox()
        CType(Me.qrcodeControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerateQRcode
        '
        Me.btnGenerateQRcode.Location = New System.Drawing.Point(14, 88)
        Me.btnGenerateQRcode.Name = "btnGenerateQRcode"
        Me.btnGenerateQRcode.Size = New System.Drawing.Size(306, 23)
        Me.btnGenerateQRcode.TabIndex = 35
        Me.btnGenerateQRcode.Text = "生成二维码"
        Me.btnGenerateQRcode.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 12)
        Me.label2.TabIndex = 34
        Me.label2.Text = "名称"
        '
        'txtHTTPPort
        '
        Me.txtHTTPPort.BackColor = System.Drawing.Color.White
        Me.txtHTTPPort.Location = New System.Drawing.Point(244, 61)
        Me.txtHTTPPort.Name = "txtHTTPPort"
        Me.txtHTTPPort.Size = New System.Drawing.Size(76, 21)
        Me.txtHTTPPort.TabIndex = 4
        '
        'txtTcpPort
        '
        Me.txtTcpPort.BackColor = System.Drawing.Color.White
        Me.txtTcpPort.Location = New System.Drawing.Point(83, 61)
        Me.txtTcpPort.Name = "txtTcpPort"
        Me.txtTcpPort.Size = New System.Drawing.Size(76, 21)
        Me.txtTcpPort.TabIndex = 3
        '
        'txtNetAddress
        '
        Me.txtNetAddress.BackColor = System.Drawing.Color.White
        Me.txtNetAddress.Location = New System.Drawing.Point(83, 34)
        Me.txtNetAddress.Name = "txtNetAddress"
        Me.txtNetAddress.Size = New System.Drawing.Size(237, 21)
        Me.txtNetAddress.TabIndex = 2
        '
        'labHTTPPort
        '
        Me.labHTTPPort.AutoSize = True
        Me.labHTTPPort.Location = New System.Drawing.Point(185, 64)
        Me.labHTTPPort.Name = "labHTTPPort"
        Me.labHTTPPort.Size = New System.Drawing.Size(53, 12)
        Me.labHTTPPort.TabIndex = 26
        Me.labHTTPPort.Text = "HTTP端口"
        '
        'labTCPPort
        '
        Me.labTCPPort.AutoSize = True
        Me.labTCPPort.Location = New System.Drawing.Point(12, 64)
        Me.labTCPPort.Name = "labTCPPort"
        Me.labTCPPort.Size = New System.Drawing.Size(47, 12)
        Me.labTCPPort.TabIndex = 27
        Me.labTCPPort.Text = "TCP端口"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "服务器地址"
        '
        'qrcodeControl
        '
        Me.qrcodeControl.ErrorCorrectLevel = Smobiler.Utility.Encoding.ErrorCorrectionLevel.M
        Me.qrcodeControl.Image = CType(resources.GetObject("qrcodeControl.Image"), System.Drawing.Image)
        Me.qrcodeControl.Location = New System.Drawing.Point(14, 121)
        Me.qrcodeControl.Name = "qrcodeControl"
        Me.qrcodeControl.QuietZoneModule = Smobiler.Utility.Encoding.Windows.Render.QuietZoneModules.Two
        Me.qrcodeControl.Size = New System.Drawing.Size(306, 276)
        Me.qrcodeControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.qrcodeControl.TabIndex = 32
        Me.qrcodeControl.TabStop = False
        Me.qrcodeControl.Text = "lgdY7aMX70DtIt/TmG1ANg=="
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(83, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(237, 21)
        Me.txtName.TabIndex = 1
        '
        'frmGenerateQRcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 407)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnGenerateQRcode)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtHTTPPort)
        Me.Controls.Add(Me.txtTcpPort)
        Me.Controls.Add(Me.txtNetAddress)
        Me.Controls.Add(Me.labHTTPPort)
        Me.Controls.Add(Me.labTCPPort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.qrcodeControl)
        Me.Name = "frmGenerateQRcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGenerateQRcode"
        CType(Me.qrcodeControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnGenerateQRcode As Button
    Friend WithEvents label2 As Label
    Friend WithEvents txtHTTPPort As TextBox
    Friend WithEvents txtTcpPort As TextBox
    Friend WithEvents txtNetAddress As TextBox
    Friend WithEvents labHTTPPort As Label
    Friend WithEvents labTCPPort As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents qrcodeControl As Smobiler.Utility.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents txtName As TextBox
End Class
