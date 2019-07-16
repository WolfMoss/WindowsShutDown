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
    ''' <summary>
    ''' 注册模拟鼠标移动方法
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    Private Declare Sub SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer)
    ''' <summary>
    ''' 注册模拟鼠标按键方法
    ''' </summary>
    ''' <param name="dwFlags"></param>
    ''' <param name="dx"></param>
    ''' <param name="dy"></param>
    ''' <param name="cButtons"></param>
    ''' <param name="dwExtraInfo"></param>
    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Private Const MOUSEEVENTF_LEFTDOWN = &H2 '鼠标左键按下
    Private Const MOUSEEVENTF_LEFTUP = &H4 '鼠标左键抬起
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8 '鼠标右键按下
    Private Const MOUSEEVENTF_RIGHTUP = &H10 '鼠标右键抬起
    ''' <summary>
    ''' 注册获取当前鼠标坐标方法
    ''' </summary>
    ''' <param name="lpPoint"></param>
    Private Declare Sub GetCursorPos Lib "user32" (lpPoint As Integer())

    '''' <summary>
    '''' 注册模拟按键方法
    '''' </summary>
    '''' <param name="wMsg"></param>
    '''' <param name="wParam"></param>
    '''' <returns></returns>
    'Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Long, ByVal wParam As Long) As Long
    'Private Const WM_KEYDOWN = &H100 '按下
    'Private Const WM_KEYUP = &H101 '释放

    ''' <summary>
    ''' 注册模拟按键方法
    ''' </summary>
    ''' <param name="bVk"></param>
    ''' <param name="Scan"></param>
    ''' <param name="dwFlags"></param>
    ''' <param name="dwExtraInfo"></param>
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal Scan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Const KEYEVENTF_KEYUP = &H2 '释放按键常数
    Private Const Key_UP = 38   '上
    Private Const Key_DOWN = 40   '下
    Private Const Key_LEFT = 37   '左
    Private Const Key_RIGHT = 39   '右

    ''' <summary>
    ''' 点击一次右键
    ''' </summary>
    Private Sub rightChick()
        mouse_event（MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0）
        mouse_event（MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0）
    End Sub
    ''' <summary>
    ''' 点击一次左键
    ''' </summary>
    Private Sub lefghtChick()
        mouse_event（MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0）
        mouse_event（MOUSEEVENTF_LEFTUP, 0, 0, 0, 0）
    End Sub
    ''' <summary>
    ''' 获取当前鼠标位置
    ''' </summary>
    ''' <returns></returns>
    Private Function getNowPos() As Integer()
        Dim pos(2) As Integer
        GetCursorPos(pos)
        Return pos
    End Function

    ''' <summary>
    ''' 立即关机
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Press(sender As Object, e As EventArgs) Handles Button1.Press

        System.Diagnostics.Process.Start("shutdown.exe", "-s -t 0")

    End Sub
    ''' <summary>
    ''' 鼠标上移
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Press(sender As Object, e As EventArgs) Handles Button2.Press
        Dim pos() As Integer = getNowPos()
        Call SetCursorPos(pos(0), pos(1) - CInt(txtPos.Text))

    End Sub
    ''' <summary>
    ''' 鼠标左移
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Press(sender As Object, e As EventArgs) Handles Button3.Press
        Dim pos() As Integer = getNowPos()
        Call SetCursorPos(pos(0) - CInt(txtPos.Text), pos(1))
    End Sub
    ''' <summary>
    ''' 鼠标右移
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button4_Press(sender As Object, e As EventArgs) Handles Button4.Press
        Dim pos() As Integer = getNowPos()
        Call SetCursorPos(pos(0) + CInt(txtPos.Text), pos(1))
    End Sub
    ''' <summary>
    ''' 鼠标下移
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button5_Press(sender As Object, e As EventArgs) Handles Button5.Press
        Dim pos() As Integer = getNowPos()
        Call SetCursorPos(pos(0), pos(1) + CInt(txtPos.Text))
    End Sub
    ''' <summary>
    ''' 键盘上
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button6_Press(sender As Object, e As EventArgs) Handles Button6.Press
        Call keybd_event(Key_UP, 0, 0, 0) '按下
        Call keybd_event(Key_UP, 0, KEYEVENTF_KEYUP, 0) '释放
    End Sub
    ''' <summary>
    ''' 键盘左
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button7_Press(sender As Object, e As EventArgs) Handles Button7.Press
        Call keybd_event(Key_LEFT, 0, 0, 0) '按下
        Call keybd_event(Key_LEFT, 0, KEYEVENTF_KEYUP, 0) '释放
    End Sub
    ''' <summary>
    ''' 键盘右
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button8_Press(sender As Object, e As EventArgs) Handles Button8.Press
        Call keybd_event(Key_RIGHT, 0, 0, 0) '按下
        Call keybd_event(Key_RIGHT, 0, KEYEVENTF_KEYUP, 0) '释放
    End Sub
    ''' <summary>
    ''' 键盘下
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button9_Press(sender As Object, e As EventArgs) Handles Button9.Press
        Call keybd_event(Key_DOWN, 0, 0, 0) '按下
        Call keybd_event(Key_DOWN, 0, KEYEVENTF_KEYUP, 0) '释放
    End Sub
    ''' <summary>
    ''' 左键单击
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button10_Press(sender As Object, e As EventArgs) Handles Button10.Press
        lefghtChick()
    End Sub
    ''' <summary>
    ''' 右键单击
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button11_Press(sender As Object, e As EventArgs) Handles Button11.Press
        rightChick()
    End Sub
End Class
