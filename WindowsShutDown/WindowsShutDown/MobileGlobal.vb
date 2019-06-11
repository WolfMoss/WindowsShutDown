Imports Smobiler.Core

''' <summary>
''' 全局类
''' </summary>
Public Class MobileGlobal
    ''' <summary>
    ''' 在服务启动时触发
    ''' </summary>
    ''' <param name="server"></param>
    Public Shared Sub OnServerStart(ByVal server As MobileServer)
    End Sub

    ''' <summary>
    ''' 在服务停止时触发
    ''' </summary>
    ''' <param name="server"></param>
    Public Shared Sub OnServerStop(ByVal server As MobileServer)
    End Sub

    ''' <summary>
    ''' 在客户端会话第一次开始时触发
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Shared Sub OnSessionStart(ByVal sender As Object, ByVal e As SmobilerSessionEventArgs)
    End Sub

    ''' <summary>
    ''' 在客户端会话结束时触发
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Shared Sub OnSessionStop(ByVal sender As Object, ByVal e As SmobilerSessionEventArgs)
    End Sub

    ''' <summary>
    ''' 在客户端会话重新连接时触发
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Shared Sub OnSessionConnect(ByVal sender As Object, ByVal e As SmobilerSessionEventArgs)
    End Sub

    ''' <summary>
    ''' 在回调推送被客户端点击时触发
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Shared Sub OnPushCallBack(ByVal sender As Object, ByVal e As ClientPushOpenedEventArgs)
    End Sub
End Class
