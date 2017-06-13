Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing

Public Class MainWindow

#Region "Aero Effects  Settings Functions"

    <DllImport("dwmapi")> _
    Private Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function
    <DllImport("dwmapi")> _
    Private Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function
    <DllImport("dwmapi.dll")> _
    Private Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer
    End Function

    Private Const CS_DROPSHADOW As Integer = &H20000
    Private Const WM_NCPAINT As Integer = &H85
    Private AeroEnabled As Boolean

    Public Structure MARGINS
        Public leftWidth As Integer
        Public rightWidth As Integer
        Public topHeight As Integer
        Public bottomHeight As Integer
    End Structure
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            _IMSS_CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not AeroEnabled Then
                cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
                Return cp
            Else
                Return cp
            End If
        End Get
    End Property

    Private Sub _IMSS_CheckAeroEnabled()
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            Dim response As Integer = DwmIsCompositionEnabled(enabled)
            AeroEnabled = (enabled = 1)
        Else
            AeroEnabled = False
        End If
    End Sub
#End Region

    Public Property _IMSS_UPDATE_ASMBLE_URL As String = String.Empty
    Public Property _IMSS_UPDATE_VERSION As String = String.Empty
    Private _IMSS_LOCATION_Y As Integer = 0

    Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        _IMSS_UPDATE_USERCONTROL.Dispose()
    End Sub


    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        _IMSS_UPDATE_USERCONTROL._IMSS_UPDATE_ASMBLE_URL = Me._IMSS_UPDATE_ASMBLE_URL
        _IMSS_UPDATE_USERCONTROL._IMSS_UPDATE_VERSION = Me._IMSS_UPDATE_VERSION
        _IMSS_UPDATE_USERCONTROL._IMSS_SET_EXIT_CALL(AddressOf _IMSS_EXIT)
        _IMSS_UPDATE_USERCONTROL._IMSS_LOAD_UPDATE_INFO()

        If AeroEnabled Then
            DwmSetWindowAttribute(Handle, 2, 2, 4)
            Dim bla As New MARGINS()
            With bla
                .bottomHeight = 1
                .leftWidth = 1
                .rightWidth = 1
                .topHeight = 1
            End With
            DwmExtendFrameIntoClientArea(Handle, bla)
        End If



        'System.Threading.Thread.Sleep(1400)

        ' Slide form with main sliding window.

        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        _IMSS_LOCATION_Y = Me.Location.Y
        Me.Location = New Point(Me.Location.X - 4, Me.Location.Y + 164)
        Me.Show()
        Do Until Me.Location.Y <= _IMSS_LOCATION_Y - 40
            System.Threading.Thread.Sleep(10)
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 10)
            Application.DoEvents()
        Loop
        For i = 0 To 20 Step 1
            System.Threading.Thread.Sleep(4)
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 2)
            Application.DoEvents()
        Next i

        Me.Activate()

    End Sub

    Private Sub _IMSS_EXIT_PICTUREBOX_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_EXIT_PICTUREBOX.MouseEnter
        Me._IMSS_EXIT_PICTUREBOX.Image = My.Resources._IMSS_UpdateExit_MouseOver_Icon_34x24
    End Sub

    Private Sub _IMSS_EXIT_PICTUREBOX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_EXIT_PICTUREBOX.MouseLeave
        Me._IMSS_EXIT_PICTUREBOX.Image = My.Resources._IMSS_UpdateExit_Icon_34x24
    End Sub

    Private Sub _IMSS_EXIT_PICTUREBOX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_EXIT_PICTUREBOX.Click

        _IMSS_UPDATE_USERCONTROL._IMSS_EXIT_ALL_THREAD()

        _IMSS_UPDATE_USERCONTROL._IMSS_EXIT_DOWNLOAD_CLIENT()

        _IMSS_EXIT()

    End Sub

    Private Sub _IMSS_EXIT()
        Me.Close()
    End Sub

End Class