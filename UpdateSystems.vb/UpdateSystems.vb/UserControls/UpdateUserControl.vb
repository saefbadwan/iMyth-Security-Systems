Imports System.Net
Imports System.IO
Imports System.Windows.Forms

Public Class UpdateUserControl

    Public Property _IMSS_UPDATE_ASMBLE_URL As String = String.Empty
    Private Property _IMSS_UPDATE_ASMBLE_SIZE As String = String.Empty
    Public Property _IMSS_UPDATE_VERSION As String = String.Empty

    Private _IMSS_THREADS As New List(Of Threading.Thread)

    Public Delegate Sub _IMSS_EXIT()
    Private Delegate Sub _IMSS_SET_DOWNLOAD_SIZE()

    Public _IMSS_CALL_EXIT As _IMSS_EXIT = Nothing

    Private _IMSS_DownloadClient As New WebClient

    Private _IMSS_DOWNLOAD_TO As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\IMSS\_IMSS_UpdateTemp.exe"


    Private Sub _IMSS_REMINMELATER_BUTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_REMINMELATER_BUTT.Click

        _IMSS_EXIT_ALL_THREAD()

        _IMSS_CALL_EXIT.Invoke()

    End Sub

    Public Sub _IMSS_SET_EXIT_CALL(ByRef _IMSS_EXIT_CALL As _IMSS_EXIT)
        _IMSS_CALL_EXIT = _IMSS_EXIT_CALL
    End Sub

    Private Sub _IMSS_UPDATE_BUTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_UPDATE_BUTT.Click
        _IMSS_START_UPDATE_PROCESS()
    End Sub

    Private Sub _IMSS_CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CANCEL.Click
        _IMSS_DownloadClient.CancelAsync()
        _IMSS_DownloadClient.Dispose()
        _IMSS_CALL_EXIT.Invoke()
    End Sub

    Public Sub _IMSS_EXIT_ALL_THREAD()

        For Each _IMSS_THREAD In _IMSS_THREADS
            Try
                _IMSS_THREAD.Abort()
            Catch : End Try
        Next _IMSS_THREAD
    End Sub

    Public Sub _IMSS_EXIT_DOWNLOAD_CLIENT()

        _IMSS_DownloadClient.CancelAsync()

    End Sub

    Public Sub New()

        ' This call is required by the designer.

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub _IMSS_LOAD_UPDATE_INFO()

        Dim _IMSS_THREAD As New Threading.Thread(Sub()

                                                     Do Until Me._IMSS_UPDATE_ASMBLE_URL.Length > 0
                                                         System.Threading.Thread.Sleep(400)
                                                     Loop
                                                     If SharedMethods._IMSS_CheckIfUrlIsExsits(Me._IMSS_UPDATE_ASMBLE_URL) = True Then
                                                         _IMSS_UPDATE_ASMBLE_SIZE = SharedMethods._IMSS_FormatFileSize(_IMSS_GetRemoteFileSize(Me._IMSS_UPDATE_ASMBLE_URL))
                                                         Invoke(New _IMSS_SET_DOWNLOAD_SIZE(Sub()
                                                                                                Application.DoEvents()
                                                                                                _IMSS_UPDATE_VERSION_LABEL.Text = "Update Version : " & Me._IMSS_UPDATE_VERSION
                                                                                                _IMSS_UPDATE_SIZE_LABEL.Text = "Update Size : " & _IMSS_UPDATE_ASMBLE_SIZE
                                                                                                _IMSS_UPDATE_VERSION_LOADING_PICUTERBOX.Enabled = False
                                                                                                _IMSS_UPDATE_VERSION_LOADING_PICUTERBOX.Visible = False
                                                                                                _IMSS_LOADING_PICTUREBOX.Enabled = False
                                                                                                _IMSS_LOADING_PICTUREBOX.Visible = False
                                                                                            End Sub))


                                                     End If

                                                 End Sub) : _IMSS_THREAD.Start()
        _IMSS_THREADS.Add(_IMSS_THREAD)

    End Sub

    Private Sub _IMSS_START_UPDATE_PROCESS()

        _IMSS_SETUP_CONTROLS()

        _IMSS_DOWNLOAD_ASMBLES()

    End Sub

    Private Sub _IMSS_SETUP_CONTROLS()

        _IMSS_DOWNLOAD_TOTAL_SIZE_LBL.Text = "Download Size : " & _IMSS_UPDATE_ASMBLE_SIZE

        If IO.File.Exists(_IMSS_DOWNLOAD_TO) Then IO.File.Delete(_IMSS_DOWNLOAD_TO)

        For i As Integer = 0 To -154 Step -1
            Me._IMSS_CONTROL_HOLDER_PANEL.Location = New System.Drawing.Point(Me._IMSS_CONTROL_HOLDER_PANEL.Location.X, i)
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(1)
        Next i

    End Sub

    Private Sub _IMSS_DOWNLOAD_ASMBLES()

        AddHandler _IMSS_DownloadClient.DownloadFileCompleted, AddressOf _IMSS_DownloadClient_DownloadFileCompleted
        AddHandler _IMSS_DownloadClient.DownloadProgressChanged, AddressOf _IMSS_DownloadClient_DownloadProgressChanged
        _IMSS_DownloadClient.DownloadFileAsync(New Uri(_IMSS_UPDATE_ASMBLE_URL), _IMSS_DOWNLOAD_TO)

    End Sub

    Private Sub _IMSS_DownloadClient_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        _IMSS_DownloadSpeed_Label.Text = "Downloaded : " & SharedMethods._IMSS_FormatFileSize(e.BytesReceived)
        _IMSS_PROGRESS.Value = e.ProgressPercentage
        _IMSS_UPDATE_SIZE_LABEL.Tag = e.TotalBytesToReceive.ToString()

    End Sub


    Private Sub _IMSS_DownloadClient_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        If e.Cancelled = True Then
            _IMSS_CALL_EXIT.Invoke()
        Else
            _IMSS_SetupUpdates()
        End If

    End Sub

    Private Sub _IMSS_SetupUpdates()

        System.Threading.Thread.Sleep(400)

        If IO.File.Exists(_IMSS_DOWNLOAD_TO) Then

            If (_IMSS_UPDATE_SIZE_LABEL.Tag.ToString() = New IO.FileInfo(_IMSS_DOWNLOAD_TO).Length.ToString()) Then

                _IMSS_START_AS(_IMSS_DOWNLOAD_TO) ' Run the UpdateFile as Admin.

                _IMSS_CALL_EXIT.Invoke() ' Call for Exit Function.

            Else

                System.Threading.Thread.Sleep(1000)

                If (_IMSS_UPDATE_SIZE_LABEL.Tag.ToString() = New IO.FileInfo(_IMSS_DOWNLOAD_TO).Length.ToString()) Then ' Check Agine to make shur it's an error.

                    _IMSS_START_AS(_IMSS_DOWNLOAD_TO) ' Run the UpdateFile as Admin.

                    _IMSS_CALL_EXIT.Invoke() ' Call for Exit Function.

                Else

                    _IMSS_ERROR_MESSAGE()

                End If

            End If

        Else

            _IMSS_ERROR_MESSAGE()

        End If


    End Sub


#Region "Sub functions var"

    Private Function _IMSS_GetRemoteFileSize(ByVal _IMSS_URL As String) As Long
        Try
            Using obj As New WebClient()
                Using s As Stream = obj.OpenRead(_IMSS_URL)
                    Return Long.Parse(obj.ResponseHeaders("Content-Length").ToString())
                End Using
            End Using
        Catch
            Return 0
        End Try
    End Function

    Private Sub _IMSS_ERROR_MESSAGE()

        System.Windows.Forms.MessageBox.Show("Error : somthing went while downloading the updates we are versory !", "iMyth Security Systems", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error, Windows.Forms.MessageBoxDefaultButton.Button1)

        _IMSS_CANCEL.PerformClick()

    End Sub

    Private Function _IMSS_START_AS(ByVal _IMSS_FILEINFO As String)
        Try
            Dim process As System.Diagnostics.Process = Nothing
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            processStartInfo = New System.Diagnostics.ProcessStartInfo()
            processStartInfo.FileName = _IMSS_FILEINFO
            If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                processStartInfo.Verb = "runas"
                'Else
                ' No need to prompt to run as admin
            End If
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            processStartInfo.UseShellExecute = True
            Try
                process = System.Diagnostics.Process.Start(processStartInfo)
                Return True
            Catch ex As Exception
                Return False
                MessageBox.Show(ex.Message, "iMyth Security Systems", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Finally
                If Not (process Is Nothing) Then
                    process.Dispose()
                End If
            End Try
        Catch : End Try
        Return False
    End Function

#End Region

End Class
