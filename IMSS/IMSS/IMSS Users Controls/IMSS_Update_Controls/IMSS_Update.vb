Public Class IMSS_Update

#Region " IMSS Main Decleration Var"
    Private Shared _IMSS_CONTROL As IMSS_Update
    Private _IMSS_UPDATE_CHECK As New UpdateSystems.MainCall()
    Private _IMSS_UPDATE_staus As Boolean = Nothing
    Private _IMSS_CheckIfWebBroserClicked As Boolean = False
    Private _IMSS_CheckIfWebSystemsrunning As Boolean = False
    Private _IMSS_InterNetResulit As Boolean
#End Region

#Region " IMSS Functions Declration Uint"
    Friend Shared Function _IMSS_CREATE_CONTROL() As IMSS_Update
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_Update
            _IMSS_CONTROL.Dock = DockStyle.Fill
        Else
            _IMSS_CONTROL._IMSS_LoadUpdate()
        End If
        Return _IMSS_CONTROL
    End Function

    Private Sub _IMSS_LoadUpdate()
        _IMSS_CheckIfWebBroserClicked = True
        MainMain._IMSS_Status.Visible = True
        MainMain._IMSS_Status.Text = "Connecting..."
        MainMain.PictureBox29.Visible = True
        MainMain.PictureBox29.Enabled = True
        '_IMSS_UpdateButton.Enabled = True
        _IMSS_InterNetConnectionErrors.Visible = False
        If Not _IMSS_InterNetWorker.IsBusy = True Then
            _IMSS_InterNetWorker.RunWorkerAsync()
        End If
        ' My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
    End Sub

    Private Sub _IMSS_StartsWebSystems()
        _IMSS_CheckIfWebSystemsrunning = True
        WebBrowser1.Navigate(ConfigurationResureses.LinkVar._IMSS_RemoteHostURL & "_IMSS_UPDATA/_IMSSUPDATESYSTEMS.aspx?_IMSS_CURRNT_ID_VERSION=2.0.1.2")
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
#End Region


    Private Sub IMSS_Update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        _IMSS_UPDATE_CHECK._IMSS_UPDATE_CHECK_TYPE = True
        _IMSS_UPDATE_CHECK._IMSS_UPDATE_CONFIG_URL = ConfigurationResureses.LinkVar._IMSS_URL_CONFIG_VERSION
        _IMSS_UPDATE_CHECK._IMSS_CURRENT_VERSION = ConfigurationResureses.LinkVar._IMSS_LOCAL_CONFIG_VERSION

        _IMSS_LoadUpdate()
    End Sub

    Private Sub _IMSS_UpdateingBrowserWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_UpdateingBrowserWorker.DoWork
        If _IMSS_UPDATE_CHECK._IMSS_QuickCheckForUpdates() = True Then
            _IMSS_UPDATE_staus = True
        Else
            _IMSS_UPDATE_staus = False
        End If
        _IMSS_StartsWebSystems()
    End Sub

    Private Sub _IMSS_InterNetWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_InterNetWorker.DoWork
        If _IMSS_IsConnectionAvailable() = True Then
            If Not _IMSS_UpdateingBrowserWorker.IsBusy = True Then
                _IMSS_InterNetResulit = True
                _IMSS_UpdateingBrowserWorker.RunWorkerAsync()
            End If
        Else
            _IMSS_InterNetResulit = False
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        On Error Resume Next
        If _IMSS_CheckIfWebBroserClicked = True Then
            If Me.WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
                If _IMSS_UPDATE_staus = True Then
                    MainMain._IMSS_UpdateButton.Visible = True
                    MainMain._IMSS_Status.Text = "Update Available"
                    MainMain._IMSS_Status.Visible = True
                Else
                    MainMain._IMSS_Status.Text = "You already have latest version."
                    MainMain._IMSS_Status.Visible = True
                    MainMain._IMSS_UpdateButton.Enabled = False
                    MainMain._IMSS_UpdateButton.Visible = False
                End If
                MainMain.PictureBox29.Visible = False
                MainMain.PictureBox29.Enabled = False
            End If
        End If
    End Sub
End Class
