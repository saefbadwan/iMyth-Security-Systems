

Public Class IMSS_RegConfig

#Region "Private Declration"
    Private _IMSS_Y As Integer = 0
    Private _IMSS_X As Integer = 0
    Private i As Integer = 0
    Private _IMSS_RegisterPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSSRegConfig.IMSS"

#End Region

    Private Sub IMSS_RegConfig_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub IMSS_SlideInTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMSS_SlideInTimer.Tick
        On Error Resume Next
        If Me.Location.Y <= i Then
            Me.Location = New Point(_IMSS_X, _IMSS_Y)
            IMSS_SlideInTimer.Enabled = True
            IMSS_SlideInTimer.Enabled = False
            IMSS_SlideInTimer.Stop()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 40)
        End If
    End Sub

    Private Sub IMSS_RegConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_X = Me.Location.X
        _IMSS_Y = Me.Location.Y
        _IMSS_SlideIn()
    End Sub


    Private Sub _IMSS_SlideIn()
        On Error Resume Next
        i = Me.Location.Y
        Me.Location = New Point(Me.Location.X, Me.Location.Y + Me.Location.Y + 180)
        Me.Visible = True
        IMSS_SlideInTimer.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Not _TextUserName.Text = Nothing And _TextUserName.Text.Length >= 2 Then
                If Not _Text_Email.Text = Nothing Then
                    If IMSS_REGE_SUB_FUNCTIONS._IMSS_EmailAddressChecker(_Text_Email.Text) = True Then
                        If _IMSS_CountryList.SelectedItem.ToString = Nothing Then
                            MessageBox.Show("Please select (Type of use)", "IMSS Actvation", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Else
                            Button1.Enabled = False
                            _IMSS_Loading_PictureBox.Enabled = True
                            _IMSS_PanelWorking.Size = New Point(333, 180)
                            _IMSS_PanelWorking.Location = New Point(0, -1)
                            Me.Height = 154
                            Me.MaximumSize() = Me.Size()
                            _IMSS_Register_BackgroundWorker.RunWorkerAsync()
                        End If
                    Else
                        MessageBox.Show("Please insert valid email address", "IMSS Actvation", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                Else
                    MessageBox.Show("Please insert email address", "IMSS Actvation", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Else
                MessageBox.Show("Please insert valid name", "IMSS Actvation", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select (Type of use)", "IMSS Actvation", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub _IMSS_Register_BackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_Register_BackgroundWorker.DoWork

        Dim _IMSS_UserName As String = Environment.UserName()

        Dim _IMSS_OS_FullName As String = Environment.OSVersion.VersionString()

        'Dim _IMSS_IP_ADDRESS As String = IMSS_REGE_SUB_FUNCTIONS._IMSS_GetExternalIp()

        'Dim _IMSS_COUNTRY As String = IMSS_REGE_SUB_FUNCTIONS._IMSS_GET_COUNTRY(_IMSS_IP_ADDRESS)

        ConfigurationResureses.IMSS_SQLConnect._IMSS_SEND_VIA_PHP(New String() {IMSS_REGE_SUB_FUNCTIONS._IMSS_ReCheckTestBox(_TextUserName.Text), IMSS_REGE_SUB_FUNCTIONS._IMSS_ReCheckTestBox(_Text_Email.Text), _
                                                      IMSS_REGE_SUB_FUNCTIONS._IMSS_ReCheckTestBox(_IMSS_UserName), IMSS_REGE_SUB_FUNCTIONS._IMSS_ReCheckTestBox(_IMSS_OS_FullName)})
    End Sub

    Private Sub _IMSS_Register_BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSS_Register_BackgroundWorker.RunWorkerCompleted
        Try
            IO.File.Create(_IMSS_RegisterPath).Dispose()
            IO.File.SetAttributes(_IMSS_RegisterPath, IO.FileAttributes.Hidden)
            _IMSS_Loading_PictureBox.Enabled = False
            _IMSS_RESTART()
        Catch
            IO.File.Create(_IMSS_RegisterPath).Dispose()
            IO.File.SetAttributes(_IMSS_RegisterPath, IO.FileAttributes.Hidden)
            _IMSS_RESTART()
        End Try
    End Sub

    Private Sub _IMSS_RESTART()
        Dim startInfo As New ProcessStartInfo With {.FileName = IO.Path.Combine(Application.StartupPath.ToString(), "_IMSS_RECE.exe"), .Arguments = "_RESTART"}
        Process.Start(startInfo)
    End Sub

End Class
