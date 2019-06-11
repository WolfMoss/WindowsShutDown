Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports Smobiler.Utility.Encoding

Public Class frmMain
    ''' <summary>
    ''' 网卡字典
    ''' </summary>
    ''' <remarks></remarks>
    Dim networkDict As New Dictionary(Of String, String)
    ''' <summary>
    ''' Smobiler服务
    ''' </summary>
    ''' <remarks></remarks>
    Dim WithEvents server As Smobiler.Core.MobileServer

    ''' <summary>
    ''' 窗体加载
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InitialNetworkInterfaces()
            '定义Smobiler服务
            server = New Smobiler.Core.MobileServer
            '设置默认网卡
            If networkDict.Count > 0 Then
                Me.combNets.Items.AddRange(networkDict.Keys.ToArray)
                Me.combNets.SelectedIndex = 0
            End If
            '启动Smobiler服务
            StartServer()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
    End Sub

    ''' <summary>
    ''' 获取当前可用的网卡信息
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitialNetworkInterfaces()
        Dim i As Integer = 1
        Dim NetworkInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        For Each NetworkIntf As NetworkInterface In NetworkInterfaces
            If NetworkIntf.OperationalStatus = OperationalStatus.Up AndAlso NetworkIntf.NetworkInterfaceType <> NetworkInterfaceType.Loopback Then
                Dim IPInterfaceProperties As IPInterfaceProperties = NetworkIntf.GetIPProperties()
                Dim UnicastIPAddressInformationCollection As UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses
                For Each UnicastIPAddressInformation As UnicastIPAddressInformation In UnicastIPAddressInformationCollection
                    If UnicastIPAddressInformation.Address.AddressFamily = AddressFamily.InterNetwork Then
                        networkDict.Add(i.ToString + ":" + NetworkIntf.Name + "/" + NetworkIntf.Description, UnicastIPAddressInformation.Address.ToString())
                        i += 1
                    End If
                Next
            End If
        Next
    End Sub

    ''' <summary>
    ''' 开始服务
    ''' </summary>
    Private Sub StartServer()
        Try
            '服务起始界面
            server.StartUpForm = GetType(SmobilerForm1)
            '服务TCP端口，默认为2323   
            Me.txtTcpPort.Text = server.Setting.TcpServerPort.ToString()
            '服务HTTP端口，默认为2324  
            Me.txtHTTPPort.Text = server.Setting.HttpServerPort.ToString()
            '绑定事件
            AddHandler server.SessionStart, AddressOf MobileGlobal.OnSessionStart
            AddHandler server.SessionStop, AddressOf MobileGlobal.OnSessionStop
            AddHandler server.SessionConnect, AddressOf MobileGlobal.OnSessionConnect
            AddHandler server.ClientPushOpened, AddressOf MobileGlobal.OnPushCallBack
            '启用服务
            server.StartServer()
            MobileGlobal.OnServerStart(server)
        Catch ex As System.Net.HttpListenerException
            '遇到HTTP监听无法添加的异常时，需要注册HTTP监听，一般原因是由于当前用户没有管理员权限
            '运行下面的代码，会提示用户账户控制（网络命令外壳），这时请点击是
            '如果出现拒绝访问并且没有提示用户账户控制，请在 控制面板\安全性与维护\更改用户账户控制设置 选择 仅当应用尝试更改我的计算机时通知我（默认）
            Dim psi As New ProcessStartInfo("netsh", "http delete urlacl url=http://+:" + server.Setting.HttpServerPort.ToString() + "/")
            psi.Verb = "runas"
            psi.CreateNoWindow = True
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.UseShellExecute = True
            Process.Start(psi).WaitForExit()
            psi = New ProcessStartInfo("netsh", "http add urlacl url=http://+:" + server.Setting.HttpServerPort.ToString() + "/ user=" + Environment.UserDomainName + "\" + Environment.UserName)
            psi.Verb = "runas"
            psi.CreateNoWindow = True
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.UseShellExecute = True
            Process.Start(psi).WaitForExit()
            server.StartServer()
        End Try
    End Sub

    ''' <summary>
    ''' 停止服务
    ''' </summary>
    Private Sub StopServer()
        If server IsNot Nothing Then
            RemoveHandler server.SessionStart, AddressOf MobileGlobal.OnSessionStart
            RemoveHandler server.SessionStop, AddressOf MobileGlobal.OnSessionStop
            RemoveHandler server.SessionConnect, AddressOf MobileGlobal.OnSessionConnect
            RemoveHandler server.ClientPushOpened, AddressOf MobileGlobal.OnPushCallBack
            server.StopServer()
            MobileGlobal.OnServerStop(server)
        End If
    End Sub

    ''' <summary>
    ''' 在下拉框选择变更事件重新生成二维码
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub combNets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combNets.SelectedIndexChanged
        If networkDict.Count > 0 Then
            Me.txtNetAddress.Text = networkDict.Item(Me.combNets.SelectedItem)
            qrcodeControl.SetServerInfo(Me.txtNetAddress.Text, server.Setting.TcpServerPort, server.Setting.HttpServerPort, Me.txtName.Text)
        End If
    End Sub

    ''' <summary>
    ''' 打开设置界面
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Try
            Dim setting As New frmSetting()
            If setting.ShowDialog() = DialogResult.Yes Then
                StopServer()
                '重置设置
                server.Setting.InitialData()
                StartServer()
                qrcodeControl.SetServerInfo(Me.txtNetAddress.Text, server.Setting.TcpServerPort, server.Setting.HttpServerPort, Me.txtName.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
    End Sub

    ''' <summary>
    ''' 打开帮助界面
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim help As New frmHelp()
        help.ShowDialog()
    End Sub

    ''' <summary>
    ''' 关闭窗体前保存设定值
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        StopServer()
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' 点击完成按钮后保存设定值重新生成二维码
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnsavename_Click(sender As Object, e As EventArgs) Handles btnsavename.Click
        My.Settings.Save()
        If networkDict.Count > 0 Then
            Me.txtNetAddress.Text = networkDict.Item(Me.combNets.SelectedItem)
            qrcodeControl.SetServerInfo(Me.txtNetAddress.Text, server.Setting.TcpServerPort, server.Setting.HttpServerPort, Me.txtName.Text)
        End If
    End Sub

    ''' <summary>
    ''' 打开生成服务端二维码界面
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnGenerateQRcode_Click(sender As Object, e As EventArgs) Handles btnGenerateQRcode.Click
        Dim GenerateQRcode As New frmGenerateQRcode()
        GenerateQRcode.ShowDialog()
    End Sub
End Class
