Imports System.Windows.Forms
Imports System.Drawing

Public Class IMSS_StartButton
    Private _IMSS_StartPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\iMyth Security Systems\All functions"
    Private _IMSS_ValuePath As String = String.Empty
    Public Property _IMSS_StartsPath As String
        Get
            Return _IMSS_ValuePath
        End Get
        Set(ByVal _IMSS_Value As String)
            _IMSS_ValuePath = _IMSS_Value
        End Set
    End Property

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Start_Button.MouseEnter
        _IMSS_Start_Button.ForeColor = Color.Silver
        _IMSS_Start_Button.BackgroundImage = My.Resources.IMSS_StartButtonOnMouseOver
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_Start_Button.MouseLeave
        _IMSS_Start_Button.ForeColor = Color.DimGray
        _IMSS_Start_Button.BackgroundImage = My.Resources.IMSS_StartButtonOnMouseStand
    End Sub

    Private Sub _IMSS_Start_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Start_Button.Click
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_Start_Button.Enabled = False
        If _IMSS_StartAsAdmin(_IMSS_StartPath & "\" & _IMSS_ValuePath) = True Then
            _IMSS_WriteToLog(Date.Now.ToString() & ":>> Starting " & _IMSS_ValuePath & " ..." & Environment.NewLine())
        End If
        _IMSS_Start_Button.Enabled = True
    End Sub
    Private Sub _IMSS_WriteToLog(ByVal _IMSS_ToolName As String)
        Dim _IMSS_LogPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\IMSS\Log\_IMSS_ToolsLog.IMSSDATA"
        If Not IO.File.Exists(_IMSS_LogPath) = True Then IO.File.Create(_IMSS_LogPath).Dispose()
        My.Computer.FileSystem.WriteAllText(_IMSS_LogPath, _IMSS_ToolName, True)
    End Sub
    Private Function _IMSS_StartAsAdmin(ByVal _PluginFile As String)
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
        Catch : End Try
        Return False
    End Function
End Class
