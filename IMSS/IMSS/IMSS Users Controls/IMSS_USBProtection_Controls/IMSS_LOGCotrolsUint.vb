Imports ConfigurationResureses

Public Class IMSS_LOGCotrolsUint

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        On Error Resume Next
        'My.Computer.Audio.Play(My.Resources.IMSS_Click, AudioPlayMode.Background)
        'If _IMSS_AR = True Then
        '    _IMSS_SystemsExitMasseages("هل أنت متأكد بأنك تريد محو جميع بينات السجل ؟")
        'ElseIf _IMSS_FR = True Then

        'ElseIf _IMSS_RS = True Then

        'ElseIf _IMSS_ES = True Then

        'Else
        _IMSS_SystemsExitMasseages("Are you sure you want to clear log data ?")
        'End If
    End Sub

    Private Sub _IMSS_SystemsExitMasseages(ByVal _IMSS_Massesage As String)
        On Error Resume Next
        If MessageBox.Show(_IMSS_Massesage, "IMSS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            _ClearLog()
        Else
            System.Threading.Thread.Sleep(400)
        End If
    End Sub
    Public Sub _ClearLog()
        Try
            _SecurityLog.Clear()
            _SystemLog.Clear()
            _USBLog.Clear()
            Dim _IMSS_CLEAR_LOGS As New IMSS_LOGS_OPER
            With _IMSS_CLEAR_LOGS
                If ._IMSS_Connect() = 1 Then
                    ._IMSS_DELETE_TARGET(0)
                    ._IMSS_DELETE_TARGET(1)
                    ._IMSS_DELETE_TARGET(2)
                End If
                If ._IMSS_Disconnect() = 1 Then .Dispose() Else ._IMSS_FORCE_COLSE() : .Dispose()
            End With
            MessageBox.Show("Log files was cleared successfully !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub
End Class
