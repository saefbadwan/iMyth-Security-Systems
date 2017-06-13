Imports System.Windows.Forms

Public Class IMSS_LogSection
    Public Sub _IMSS_LoadLog()
        Dim _IMSS_LogPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\IMSS\Log\_IMSS_ToolsLog.IMSSDATA"
        If IO.File.Exists(_IMSS_LogPath) = True Then
            _IMSS_ToolsLog_TextBox.Text = My.Computer.FileSystem.ReadAllText(_IMSS_LogPath)
        End If
    End Sub

    Private Sub _IMSS_ClearLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ClearLog.Click
        On Error Resume Next
        Dim _IMSS_LogPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\IMSS\Log\_IMSS_ToolsLog.IMSSDATA"
        If IO.File.Exists(_IMSS_LogPath) = True Then
            IO.File.Delete(_IMSS_LogPath)
            IO.File.Create(_IMSS_LogPath).Dispose()
            _IMSS_ToolsLog_TextBox.Clear()
        End If
        MessageBox.Show("Log files was cleared successfully !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
End Class
