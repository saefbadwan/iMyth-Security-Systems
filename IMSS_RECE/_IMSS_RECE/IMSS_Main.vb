Imports System.Collections.ObjectModel
Imports System.Windows.Forms

Module IMSS_Main
    Private _IMSS_MAIN_TARGET As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\iMyth Security Systems\IMSS.exe"
    Sub Main()
        Dim _IMSS_CommandLineArgs As ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        For i As Integer = 0 To _IMSS_CommandLineArgs.Count - 1
            Select Case _IMSS_CommandLineArgs(i)
                Case "_RESTART"
                    Shell("TaskKill /F /IM IMSS.exe", AppWinStyle.Hide, True)
                    System.Threading.Thread.Sleep(1000)
                    Process.Start(_IMSS_MAIN_TARGET)
                    Exit For : Exit Select
                Case "_RESTARTAS"
                    Shell("TaskKill /F /IM IMSS.exe", AppWinStyle.Hide, True)
                    System.Threading.Thread.Sleep(1000)
                    _IMSS_START_AS(_IMSS_MAIN_TARGET)
                    Exit For : Exit Select
                Case Else
            End Select
        Next
    End Sub
    Private Function _IMSS_START_AS(ByVal _PluginFile As String)
        Try
            Dim process As System.Diagnostics.Process = Nothing
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            processStartInfo = New System.Diagnostics.ProcessStartInfo()
            processStartInfo.FileName = _PluginFile
            If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                processStartInfo.Verb = "runas"
            Else
                ' No need to prompt to run as admin
            End If
            processStartInfo.Arguments = ""
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            processStartInfo.UseShellExecute = True
            Try
                process = System.Diagnostics.Process.Start(processStartInfo)
                Return True
            Catch ex As Exception
                Return False
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Not (process Is Nothing) Then
                    process.Dispose()
                End If
            End Try
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
End Module
