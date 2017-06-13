Imports ConfigurationResureses

Public Class IMSS_LOG
    Private _PathSettings As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\IMSS\Log\SettingsLog.txt"
    Public WriteOnly Property _IMSS_SecuritySettingsLogData_ReadLogDataFiles As Boolean
        Set(ByVal _IMSS_DATA As Boolean)
            Try
                _SecuritySettingsLogData.Clear()
                Dim _IMSS_LOAD As New IMSS_LOGS_OPER
                With _IMSS_LOAD
                    If ._IMSS_Connect = 1 Then
                        If ._IMSS_LOAD_TARGET_LIST(4, _SecuritySettingsLogData) = 1 Then
                        End If ' IMSS Else Catch Error
                    End If
                    If ._IMSS_Disconnect() = 1 Then .Dispose() Else ._IMSS_FORCE_COLSE() : .Dispose()
                End With
            Catch ex As Exception
            End Try
        End Set
    End Property
    Public WriteOnly Property _IMSS_SecuritySettingsLogData_ClearLogDataFiles As Boolean
        Set(ByVal _IMSS_STATUS As Boolean)
            If _IMSS_STATUS = True Then
                _IMSS_Q_Clear_Log()
            End If
        End Set
    End Property
    Private Sub _IMSS_Q_Clear_Log()
        _IMSS_SystemsExitMasseages("Are you sure you want to clear settings log data ?")
    End Sub
    Private Sub _IMSS_SystemsExitMasseages(ByVal _IMSS_Massesage As String)
        On Error Resume Next
        If MessageBox.Show(_IMSS_Massesage, "IMSS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            _SecuritySettingsLogData.Clear()
            Dim _IMSS_CLEAR_LOGS As New IMSS_LOGS_OPER
            With _IMSS_CLEAR_LOGS
                If ._IMSS_Connect() = 1 Then
                    ._IMSS_DELETE_TARGET(4)
                End If
                If ._IMSS_Disconnect() = 1 Then .Dispose() Else ._IMSS_FORCE_COLSE() : .Dispose()
            End With
        Else
            System.Threading.Thread.Sleep(400)
        End If
    End Sub
End Class
