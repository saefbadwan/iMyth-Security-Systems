Imports System.Windows.Forms
Imports System.Drawing

Public Class LinkVar
#Region "iMyth Security Systems Main Settings"
    Public Shared _IMSS_RemoteHostURL As String = "http://www.im-ss.net/"
    Public Shared _IMSS_MainURL As String = _IMSS_RemoteHostURL
    ' Public Shared _IMSS_WebBrowserNavigate As String = _IMSS_RemoteHostURL & "_IMSS_UPDATA/_IMSSUPDATESYSTEMS.aspx?_IMSS_CURRNT_ID_VERSION=" & Application.ProductVersion
    Public Shared _IMSS_HomePage As String = _IMSS_RemoteHostURL & "Default.aspx"
    Public Shared _IMSS_HelpPage As String = _IMSS_RemoteHostURL & "Default.aspx"
    Public Shared _IMSS_FreamWork_4_AR As String = "http://www.microsoft.com/downloads/details.aspx?familyid=0a391abd-25c1-4fc0-919f-b21f31ab88b7&displaylang=ar"
    Public Shared _IMSS_FreamWork_4_EN As String = "http://www.microsoft.com/en-us/download/details.aspx?id=17851"
    Public Shared _IMSS_ScanMangaerHelpPage As String = _IMSS_RemoteHostURL & "ScanManagerHelp.aspx"
    Public Shared _IMSS_SysMonitorHelpPage As String = _IMSS_RemoteHostURL & "imss/SysMonitor.aspx"
    Public Shared _IMSS_USBMonitorHelpPage As String = _IMSS_RemoteHostURL & "imss/UsbMonitor.aspx"
    Public Shared _IMSS_OS_Version As Boolean = True
    Public Shared _IMSS_ErrorReportPage As String = "ftp://camellia.arvixe.com/im-ss.net/wwwroot/IMSS_ERROR_REPORTS/"
    Public Shared _IMSS_DEEPSCANORNOT_ As Boolean = False
    Public Shared _IMSS_URL_CONFIG_VERSION As String = "http://im-ss.net/IMSSUpdate/_IMSS_UP_SETTINGS.xml"
    Public Shared _IMSS_LOCAL_CONFIG_VERSION As Integer = 2
    Public Shared _IMSS_UPDATE_ASMBLE_URL As String = "http://im-ss.net/IMSSUpdate/IMSS_UPDATES.exe"
    Public Shared _IMSS_Q As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSS"
    Public Shared _IMSS_CommonApplicationData As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
#End Region

#Region "Sound effects files"
    Public Shared ReadOnly Property _IMSS_CLEAR_SCAN As System.IO.UnmanagedMemoryStream
        Get
            Return My.Resources.IMSSClear
        End Get
    End Property
    Public Shared ReadOnly Property _IMSS_SECURITY_BREACH As System.IO.UnmanagedMemoryStream
        Get
            Return My.Resources._IMSSALARM
        End Get
    End Property
    Public Shared ReadOnly Property _IMSS_ON_MOUSE_CLICK As System.IO.UnmanagedMemoryStream
        Get
            Return My.Resources._IMSS_SoundMouseOver
        End Get
    End Property
    Public Shared ReadOnly Property _IMSS_MOUSE_CLICK As System.IO.UnmanagedMemoryStream
        Get
            Return My.Resources.IMSS_Click
        End Get
    End Property
#End Region

    Public Shared Function _IMSS_SetSubIconForItems(ByVal _IMSS_TARGET As String) As Integer
        Select Case _IMSS_TARGET
            Case ".exe" ' IMSS Exe types
                Return 0 : Exit Select
            Case ".bat"
                Return 0 : Exit Select
            Case ".com"
                Return 0 : Exit Select
            Case ".pif"
                Return 0 : Exit Select
            Case ".scr"
                Return 0 : Exit Select
            Case ".png"
                Return 1 : Exit Select ' IMSS Images types
            Case ".jpg"
                Return 1 : Exit Select
            Case ".gif"
                Return 1 : Exit Select
            Case ".bmp"
                Return 1 : Exit Select
            Case ".psd"
                Return 1 : Exit Select
            Case ".pspimage"
                Return 1 : Exit Select
            Case ".thm"
                Return 1 : Exit Select
            Case ".tif"
                Return 1 : Exit Select
            Case ".yuv"
                Return 1 : Exit Select
            Case ".doc" ' IMSS doc types
                Return 2 : Exit Select
            Case "docx"
                Return 2 : Exit Select
            Case ".txt" ' IMSS text file
                Return 3 : Exit Select
            Case ".rtf"
                Return 3 : Exit Select
            Case ".log"
                Return 3 : Exit Select
            Case ".rar"
                Return 4 : Exit Select
            Case ".zip"
                Return 4 : Exit Select
            Case ".html"
                Return 5 : Exit Select
            Case ".htm"
                Return 5 : Exit Select
            Case ".ppt"
                Return 6 : Exit Select
            Case ".pptm"
                Return 6 : Exit Select
            Case ".pptx"
                Return 6 : Exit Select
            Case ".xlsx"
                Return 7 : Exit Select
            Case ".xlsm"
                Return 7 : Exit Select
            Case ".xlsb"
                Return 7 : Exit Select
            Case ".xlt"
                Return 7 : Exit Select
            Case ".swf"
                Return 8 : Exit Select
            Case ".flv"
                Return 8 : Exit Select
            Case ".lnk"
                Return 9 : Exit Select
            Case Else
                Return 10 : Exit Select
        End Select
        '  Try : Return _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_TARGET).ToBitmap(), 16, 16) : Catch : Return My.Resources._IMSS_ErrorExtracting_Icon_16x16 : End Try
    End Function

    Public Shared Sub _IMSS_PutLocations(ByRef _IMSS_TARGET As Form)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        p.AddLine(20, 0, _IMSS_TARGET.Width - 20, 0)
        p.AddArc(New Rectangle(_IMSS_TARGET.Width - 20, 0, 20, 20), -90, 90)
        p.AddLine(_IMSS_TARGET.Width, 20, _IMSS_TARGET.Width, _IMSS_TARGET.Height - 20)
        p.AddArc(New Rectangle(_IMSS_TARGET.Width - 20, _IMSS_TARGET.Height - 20, 20, 20), 0, 90)
        p.AddLine(_IMSS_TARGET.Width - 20, _IMSS_TARGET.Height, 20, _IMSS_TARGET.Height)
        p.AddArc(New Rectangle(0, _IMSS_TARGET.Height - 20, 20, 20), 90, 90)
        p.CloseFigure()
        _IMSS_TARGET.Region = New Region(p)
        p.Dispose()
    End Sub

    Public Shared Function _IMSS_START_AS(ByVal _IMSS_FILEINFO() As String)
        Try
            Dim process As System.Diagnostics.Process = Nothing
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            processStartInfo = New System.Diagnostics.ProcessStartInfo()
            processStartInfo.FileName = _IMSS_FILEINFO(0)
            If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                processStartInfo.Verb = "runas"
                'Else
                ' No need to prompt to run as admin
            End If
            processStartInfo.Arguments = _IMSS_FILEINFO(1)
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            processStartInfo.UseShellExecute = True
            Try
                process = System.Diagnostics.Process.Start(processStartInfo)
                Return True
            Catch ex As Exception
                Return False
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Finally
                If Not (process Is Nothing) Then
                    process.Dispose()
                End If
            End Try
        Catch : End Try
        Return False
    End Function


End Class
