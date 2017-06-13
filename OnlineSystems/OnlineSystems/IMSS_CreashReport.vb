'بسم الله الرحمن الرحيم

Imports System.Net.Mail
Imports System.Text
Imports System.Security.Cryptography
Imports System.Net
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class IMSS_CreashReport

#Region "IMSS Decluration"
    Public _IMSS_WaitEqual = False
    Private _IMSS_MyMailSubject As String = String.Empty
    Private _IMSS_MyMailMessageBody As String = String.Empty
    Private _FullErrorReportData As String = String.Empty
    Private _IMSS_MainPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\IMSS\IMSS.exe"

    'API Definitions

    ''' <summary>
    ''' Determines if a process is running on a 64 bit Operating System but in 32 bit emulation mode (WOW64)
    ''' </summary>
    ''' <param name="hProcess">A handle to the process to check</param>
    ''' <param name="Wow64Process">Output parameter. A boolean that will be set to True if the process is running in WOW64 mode</param>
    <System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint:="IsWow64Process")> _
    Public Shared Function IsWow64Process(<System.Runtime.InteropServices.InAttribute()> ByVal hProcess As System.IntPtr, <System.Runtime.InteropServices.OutAttribute()> ByRef Wow64Process As Boolean) As <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)> Boolean
    End Function

    ''' <summary>
    ''' Determines if a method exists in the specified DLL
    ''' </summary>
    ''' <param name="moduleName">The DLL to look for the method in</param>
    ''' <param name="methodName">The method to look for</param>
    Public Shared Function DoesWin32MethodExist(ByVal moduleName As String, ByVal methodName As String) As Boolean
        Dim moduleHandle As IntPtr = GetModuleHandle(moduleName)
        If (moduleHandle = IntPtr.Zero) Then
            Return False
        End If
        Return (GetProcAddress(moduleHandle, methodName) <> IntPtr.Zero)
    End Function

    ''' <summary>
    ''' Gets a handle to a specified DLL
    ''' </summary>
    ''' <param name="moduleName">The module to return a handle for</param>
    <Runtime.ConstrainedExecution.ReliabilityContract(Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, Runtime.ConstrainedExecution.Cer.MayFail), DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function GetModuleHandle(ByVal moduleName As String) As IntPtr
    End Function

    ''' <summary>
    ''' Retrieves the address of an exported function or variable from the specified dynamic-link library (DLL)
    ''' </summary>
    ''' <param name="hModule">A handle to the DLL to look for the method in</param>
    ''' <param name="methodName">The method to look for</param>
    <DllImport("kernel32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function GetProcAddress(ByVal hModule As IntPtr, ByVal methodName As String) As IntPtr
    End Function
#End Region

    Public Property _IMSS_SET_REPORT_CONRENT As String
        Get
            Return _IMSS_ERRORReportingTextBox.Text
        End Get
        Set(ByVal _IMSS_CONTENT As String)
            _IMSS_ERRORReportingTextBox.Text = _IMSS_CONTENT
        End Set
    End Property

    Private Sub IMSS_CreashReport_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        On Error Resume Next
        System.Threading.Thread.Sleep(400)
        Shell(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\_IMSS_Cleaner.bat", AppWinStyle.Hide)
        _IMSS_WaitEqual = True
    End Sub

    Private Sub IMSS_CreashReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim _IMSS_StringBulider As New System.Text.StringBuilder
        _IMSS_StringBulider.AppendLine("cd \")
        _IMSS_StringBulider.AppendLine("PING 1.1.1.1 -n 1 -w 4000 > NUL")
        _IMSS_StringBulider.AppendLine("TaskKill /F /IM IMSS.exe")
        _IMSS_StringBulider.AppendLine("PING 1.1.1.1 -n 1 -w 3000 > NUL")
        _IMSS_StringBulider.AppendLine("""" + _IMSS_MainPath + """")
        _IMSS_StringBulider.AppendLine("exit")
        IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\_IMSS_Cleaner.bat", _IMSS_StringBulider.ToString())
    End Sub

    Private Sub IMSS_CreashReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Label3.Text = "Error At : " & Date.Now.ToString
        Dim _IMSS_Random_Number As String = GetRandom()
        Dim _IMSS_RemoteFile_Name As String = "IMSS_" & Environment.UserName.Replace(" ", "").ToString & "_" & _IMSS_Random_Number & "Version_1" & ".txt".ToString
        _IMSS_MyMailSubject = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\" & _IMSS_RemoteFile_Name
        _IMSS_MyMailMessageBody = _IMSS_ERRORReportingTextBox.Text.ToString
        System.Threading.Thread.Sleep(400)
        If _IMSS_IsConnectionAvailable() = True Then
            _IMSS_SET_COMPUTER_USER_INFO(_IMSS_MyMailMessageBody)
            If _IMSS_CreateReport(_IMSS_MyMailSubject, _IMSS_MyMailMessageBody) = True Then
                System.Threading.Thread.Sleep(400)
                _IMSS_UploadToFTP(ConfigurationResureses.LinkVar._IMSS_ErrorReportPage & _IMSS_RemoteFile_Name, "imiss", "19911024", _IMSS_MyMailSubject)
                System.Threading.Thread.Sleep(400)
                IO.File.Delete(_IMSS_MyMailSubject)
            End If
        Else
            Label2.Text = "Unhandled Exception (ERROR) has occurred Error Report will be sent " & Environment.NewLine & "when connection is available to iMyth laboratories, Thank you."
        End If
    End Sub

    Private Sub _IMSS_SET_COMPUTER_USER_INFO(ByRef _IMSS_EX_INFO As String)

        _IMSS_EX_INFO += Environment.NewLine() & Environment.NewLine() & Environment.NewLine() & Environment.NewLine() & _
            "--------------------------------------------------------------------" & Environment.NewLine() & _
            "iMyth Security Systems Version : 1" & Environment.NewLine() & _
            "OS Name : " & _IMSS_GET_OS_NAME() & Environment.NewLine() & _
            "Date : " & Now.ToString() & Environment.NewLine() & _
            "Is 64 Bit OS : " & Is64BitOperatingSystem().ToString()
    End Sub
    Public Function Is64BitOperatingSystem() As Boolean
        Try
            If IntPtr.Size = 8 Then
                Return True
            Else
                Dim Is64 As Boolean = False
                If DoesWin32MethodExist("kernel32.dll", "IsWow64Process") Then
                    IsWow64Process(Process.GetCurrentProcess.Handle, Is64)
                End If
                Return Is64
            End If
        Catch
            Return "_IMSS_ERROR"
        End Try
    End Function


    Private Function _IMSS_GET_OS_NAME() As String
        Dim osInfo As System.OperatingSystem = System.Environment.OSVersion
        Select Case osInfo.Version.Major
            Case 5
                Select Case osInfo.Version.Minor
                    Case 0
                        Return "Windows 2000"
                    Case 1
                        Return "Window XP"
                    Case Else
                        Return "_IMSS_ERROR"
                End Select
            Case 6
                Select Case osInfo.Version.Minor
                    Case 0
                        Return "Windows Vista Or Windows Server 2008"
                    Case 1
                        Return "Windows 7"
                    Case 2
                        Return "Windows 8 Or Windows Server 2012"
                    Case Is >= 3
                        Return "Windows 8.1 Or Windows Server 2012 R2"
                    Case Else
                        Return "_IMSS_ERROR"
                End Select
            Case Else
                Return "_IMSS_ERROR"
        End Select
    End Function

    Private Function GetRandom()
        On Error Resume Next
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Sub _IMSS_UploadToFTP(ByVal _IMSS_FTPServer As String, ByVal _IMSS_FTPUserName As String, ByVal _IMSS_FTP_PassWord As String, ByVal _IMSS_LocalReportName As String)
        On Error Resume Next
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(_IMSS_FTPServer), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(_IMSS_FTPUserName, _IMSS_FTP_PassWord)
        request.Method = System.Net.WebRequestMethods.Ftp.UploadFile
        Dim file() As Byte = System.IO.File.ReadAllBytes(_IMSS_LocalReportName)
        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(file, 0, file.Length)
        strz.Close()
        strz.Dispose()
    End Sub
    Private Function _IMSS_CreateReport(ByVal _IMSS_ReportName As String, ByVal _IMSS_RebortData As String) As Boolean
        Try
            IO.File.Create(_IMSS_ReportName).Dispose()
            If System.IO.File.Exists(_IMSS_ReportName) = True Then
                Dim objWriter As New System.IO.StreamWriter(_IMSS_ReportName)
                objWriter.Write(_IMSS_RebortData)
                objWriter.Close()
            End If
            System.Threading.Thread.Sleep(400)
            Return True
        Catch
            Return False
        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        Application.Restart()
    End Sub
    Private Function _IMSS_IsConnectionAvailable() As Boolean
        Dim _IMSS_URL As New System.Uri("http://www.google.com/")
        Dim _IMSS_WebRequest As System.Net.WebRequest
        _IMSS_WebRequest = System.Net.WebRequest.Create(_IMSS_URL)
        Dim _IMSS_WebResponse As System.Net.WebResponse
        Try
            _IMSS_WebResponse = _IMSS_WebRequest.GetResponse()
            _IMSS_WebResponse.Close()
            _IMSS_WebRequest = Nothing
            Return True
        Catch
            _IMSS_WebRequest = Nothing
            Return False
        End Try
    End Function
    'Private Function GenerateHash(ByVal SourceText As String) As String
    '    'Create an encoding object to ensure the encoding standard for the source text
    '    Dim Ue As New UnicodeEncoding()
    '    'Retrieve a byte array based on the source text
    '    Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
    '    'Instantiate an MD5 Provider object
    '    Dim Md5 As New MD5CryptoServiceProvider()
    '    'Compute the hash value from the source
    '    Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
    '    'And convert it to String format for return
    '    Return Convert.ToBase64String(ByteHash)
    'End Function

End Class