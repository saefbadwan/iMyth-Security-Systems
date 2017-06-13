Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class SubThems
#Region " Aero Style "
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyButtomheight As Integer
    End Structure

    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function
#End Region

    Public Shared Sub _IMSS_FEAD_OUT(ByRef _IMSS_FORM As Form)
        On Error Resume Next
        For FadeOut = 90 To 10 Step -10
            _IMSS_FORM.Opacity = FadeOut / 100
            _IMSS_FORM.Refresh()
            Threading.Thread.Sleep(4)
        Next
        _IMSS_FORM.Close()
    End Sub
End Class
