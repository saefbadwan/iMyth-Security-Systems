' بسم الله الرحمن الرحيم

Public Class IMSS_UpdateSettings

    Private _IMSS_STATUSCHECK As Boolean

    Private Sub IMSS_Language_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            _IMSS_UpdateNotfiyCheckBox.DropDownStyle = ComboBoxStyle.DropDownList
        Catch : End Try
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Height = 60
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Height = 52
    End Sub
    Public WriteOnly Property _IMSS_SET_APPLY As Boolean
        Set(ByVal _IMSS_STATUS As Boolean)
            If _IMSS_STATUS = True Then
                _IMSS_SET_APPLY_SUB()
            End If
        End Set
    End Property
    Public WriteOnly Property _IMSS_SET_DEFAULT As Boolean
        Set(ByVal _IMSS_STATUS As Boolean)
            If _IMSS_STATUS = True Then
                _IMSS_SET_DEFAULT_SUB()
            End If
        End Set
    End Property
    Private Sub _IMSS_SET_APPLY_SUB()
        Try
            If _IMSS_AutoUpdateCheckBox.CheckState = CheckState.Checked Then
                Select Case CType(_IMSS_UpdateNotfiyCheckBox.SelectedItem, String)
                    Case "Every 4 days"
                        My.Settings._IMSS_UPDATE_INTEGER = 4
                    Case "Every 8 days"
                        My.Settings._IMSS_UPDATE_INTEGER = 8
                    Case "Every 10 days"
                        My.Settings._IMSS_UPDATE_INTEGER = 10
                    Case "Every 12 days"
                        My.Settings._IMSS_UPDATE_INTEGER = 12
                    Case "Every 14 days"
                        My.Settings._IMSS_UPDATE_INTEGER = 14
                    Case Else
                End Select
            End If
            MessageBox.Show("New update setting has been set", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _IMSS_SET_DEFAULT_SUB()
        Try
            _IMSS_AutoUpdateCheckBox.Checked = True
            _IMSS_UpdateNotfiyCheckBox.Text = "Every 14 days"
            My.Settings._IMSS_UPDATE_INTEGER = 14
        Catch : End Try
    End Sub
    Private Sub _IMSS_AutoUpdateCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AutoUpdateCheckBox.CheckedChanged
        Try
            If _IMSS_AutoUpdateCheckBox.CheckState = CheckState.Checked Then
                _IMSS_UpdateNotfiyCheckBox.Enabled = True
                My.Settings._IMSS_UPDATEAUTOORNOT = True
            Else
                My.Settings._IMSS_UPDATEAUTOORNOT = False
                _IMSS_UpdateNotfiyCheckBox.Enabled = False
            End If
        Catch : End Try
    End Sub

    Private Sub _IMSS_CheckForUpdateNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CheckForUpdateNow.Click
        Try
            My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)

            If Not _IMSS_UpdateCheckBackGroundWorker.IsBusy = True Then
                MainMain.PictureBox29.Visible = True
                MainMain.PictureBox29.Enabled = True
                _IMSS_UpdateCheckBackGroundWorker.RunWorkerAsync()
            End If
        Catch : End Try
    End Sub

    Private Sub _IMSS_UpdateCheckBackGroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_UpdateCheckBackGroundWorker.DoWork

        Dim _IMSS_UPDATE_CHECK As New UpdateSystems.MainCall()
        _IMSS_UPDATE_CHECK._IMSS_UPDATE_CONFIG_URL = ConfigurationResureses.LinkVar._IMSS_URL_CONFIG_VERSION
        _IMSS_UPDATE_CHECK._IMSS_CURRENT_VERSION = ConfigurationResureses.LinkVar._IMSS_LOCAL_CONFIG_VERSION

        If _IMSS_UPDATE_CHECK._IMSS_QuickCheckForUpdates() = True Then
            _IMSS_STATUSCHECK = True
        Else
            _IMSS_STATUSCHECK = False
        End If

    End Sub

    Private Sub _IMSS_UpdateCheckBackGroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSS_UpdateCheckBackGroundWorker.RunWorkerCompleted
        If _IMSS_STATUSCHECK = True Then
            _IMSS_UpdateCheckResult.Visible = False
            _IMSS_CheckUpdateResultpicInfo.Visible = False
            MainMain._IMSS_Main_Window_Settings_Sliding_Timer.Enabled = True
            MainMain._IMSS_UpdateButtonClick()
        Else
            _IMSS_UpdateCheckResult.Text = "You already have the latest version (" & Application.ProductVersion.ToString & ")"
            _IMSS_UpdateCheckResult.Visible = True
            _IMSS_CheckUpdateResultpicInfo.Visible = True
            MainMain.PictureBox29.Visible = False
            MainMain.PictureBox29.Enabled = False
        End If
    End Sub

End Class
