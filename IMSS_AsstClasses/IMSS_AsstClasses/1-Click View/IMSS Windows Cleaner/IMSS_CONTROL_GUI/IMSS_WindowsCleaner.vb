Imports System.Windows.Forms
Imports System.Threading

Public Class IMSS_WindowsCleaner

#Region "Cleaning Options"

    Private _IMSS_CLEAN_WINDOWS_TEMP As Boolean = True

    Private _IMSS_CLEAN_SYSTEM_TEMP As Boolean = True

    Private _IMSS_CLEAN_ADVANCED_SYSTEM_TEMP As Boolean = True

    Private _IMSS_CLEAN_MEDIA_TEMP As Boolean = True

#End Region

#Region "Thread Control Varibales"

    Public Property _IMSS_EXIT_CURRENT_PROCESS As Boolean = False

#End Region



    Public Property _IMSS_GET_SELECT_STATUS As Boolean
        Get
            Return _IMSS_SelectedValue.Checked
        End Get
        Set(ByVal _IMSS_VALUE As Boolean)
            _IMSS_SelectedValue.Checked = _IMSS_VALUE
        End Set
    End Property

    Public Sub _IMSS_START_CLEANNING()

        RaiseEvent _IMSS_DO_MINOR_TEXT(" >> Windows Explorer Temp ...")

        If (_IMSS_CLEAN_WINDOWS_TEMP) = True Then

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsExplorerRecent(), "*.*")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsExplorerThumbnailCache(), "*.*")

        End If

        RaiseEvent _IMSS_DO_MINOR_TEXT(" >> System Temp ... ")

        If (_IMSS_CLEAN_SYSTEM_TEMP) = True Then

            _IMSS_DELETE_FILE(WindowsCleanerPaths._IMSS_IconCashesDb())

            _IMSS_DELETE_FILE(WindowsCleanerPaths._IMSS_GDIPFONTCACHEV1())

            _IMSS_DELETE_FILE(WindowsCleanerPaths._IMSS_FNTCACHEDat())

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsTempFiles(), "*.*")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.UserTemps(), "*.*")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.MiniDumps(), "*.dmp")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_LiveKernelReportsMiniDumps(), "*.dmp")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.ChkDskFileFragments(), "*.chk")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsLogFiles(), "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsErrorReporting_1(), "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsErrorReporting_2(), "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsErrorReporting_2(), "*.hdmp")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsErrorReporting_2(), "*.mdmp")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsErrorReporting_3(), "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsErrorReporting_4(), "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsErrorReporting_4(), "*.cap")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsErrorReporting_4(), "*.mdmp")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_CDDVD(), "*.*")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_NETFREAMORKDIR(), "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_WINDOWSINI(), "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_WINDOWSLOGSCBS(), "*.cab")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_WINDOWSLOGSCBS(), "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_WINDOWSLOGSDPX(), "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_WINDOWSDEBUG(), "*.LOG")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_RecycleBin, "*.*")

        End If

        RaiseEvent _IMSS_DO_MINOR_TEXT(" >> System Advanced Temp ...")

        If (_IMSS_CLEAN_ADVANCED_SYSTEM_TEMP) = True Then

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.PrefetchData(), "*.*")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.ServiceProfiles, "*.*")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_SoftwareDistribution, "*.*")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.IISLogs_1, "*.log")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.IISLogs_1, "*.etl")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths._IMSS_WINDOWSSYSTEMLOGFILESSCM(), "*.*")

        End If

        If (_IMSS_CLEAN_MEDIA_TEMP) = True Then

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.WindowsMediaPlayer(), "*.*")

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.QuickTimePlayerCache(), "*.*")

            _IMSS_DELETE_FILE(WindowsCleanerPaths.QuickTimerPlayer())

            _IMSS_CLEAN_FILES_FORM_PATH(WindowsCleanerPaths.AdobeFlashPlayer, "*.*")

        End If

    End Sub




    Private Sub _IMSS_OptionLinkLabel_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_OptionLinkLabel.LinkClicked

        Dim _IMSS_WindowsCleanerOption As New IMSS_WindowsCleanerOptions(New Boolean() {_IMSS_CLEAN_WINDOWS_TEMP, _IMSS_CLEAN_SYSTEM_TEMP, _IMSS_CLEAN_ADVANCED_SYSTEM_TEMP, _IMSS_CLEAN_MEDIA_TEMP})

        AddHandler _IMSS_WindowsCleanerOption._IMSS_TARGETS_SETTINGS, Sub(ByRef _IMSS_TARGETS_SETTINGS() As Boolean)

                                                                          _IMSS_CLEAN_WINDOWS_TEMP = _IMSS_TARGETS_SETTINGS(0)

                                                                          _IMSS_CLEAN_SYSTEM_TEMP = _IMSS_TARGETS_SETTINGS(1)

                                                                          _IMSS_CLEAN_ADVANCED_SYSTEM_TEMP = _IMSS_TARGETS_SETTINGS(2)

                                                                          _IMSS_CLEAN_MEDIA_TEMP = _IMSS_TARGETS_SETTINGS(3)

                                                                      End Sub

        _IMSS_WindowsCleanerOption.ShowDialog()

    End Sub

    Private Sub _IMSS_DELETE_FILE(ByVal _IMSS_PATH As String)
        Try

            If _IMSS_EXIT_CURRENT_PROCESS = True Then Return

            RaiseEvent _IMSS_SEUPE_MAX_PROGRESS(1)

            RaiseEvent _IMSS_DO_TEXT("Deleteing : " & _IMSS_PATH)

            RaiseEvent _IMSS_DO_PROGRESS(1)

            Try
                If IO.File.Exists(_IMSS_PATH) Then

                    RaiseEvent _IMSS_DO_PROBLEMS()

                    IO.File.Delete(_IMSS_PATH)
                End If
            Catch : End Try

        Catch

            Return

        End Try

    End Sub

    Private Sub _IMSS_CLEAN_FILES_FORM_PATH(ByVal _IMSS_PATH As String, ByVal _IMSS_SEARCH_INFO As String)
        Try

            If _IMSS_EXIT_CURRENT_PROCESS = True Then Return

            If IO.Directory.Exists(_IMSS_PATH) Then

                Dim _IMSS_LIST_OF_TARGETS() As String = IO.Directory.GetFiles(_IMSS_PATH, _IMSS_SEARCH_INFO, System.IO.SearchOption.AllDirectories)

                RaiseEvent _IMSS_SEUPE_MAX_PROGRESS(_IMSS_LIST_OF_TARGETS.Length)

                For Each TargetFile In _IMSS_LIST_OF_TARGETS

                    Try

                        RaiseEvent _IMSS_DO_TEXT("Deleteing : " & TargetFile)

                        RaiseEvent _IMSS_DO_PROGRESS(1)

                        RaiseEvent _IMSS_DO_PROBLEMS()

                        IO.File.Delete(TargetFile)

                    Catch : End Try

                Next TargetFile

            End If

        Catch

            Return

        End Try

    End Sub

#Region "Udpate GUI Events"

    Public Delegate Sub _IMSS_DO_PROGRESS_DELEGATE(ByVal _IMSS_VALUE As Integer)

    Public Delegate Sub _IMSS_DO_TEXT_DELEGATE(ByVal _IMSS_TEXT As String)

    Public Delegate Sub _IMSS_DO_PROBLEMS_DELEGATE()

    Public Event _IMSS_SEUPE_MAX_PROGRESS As _IMSS_DO_PROGRESS_DELEGATE

    Public Event _IMSS_DO_PROGRESS As _IMSS_DO_PROGRESS_DELEGATE

    Public Event _IMSS_DO_TEXT As _IMSS_DO_TEXT_DELEGATE

    Public Event _IMSS_DO_MINOR_TEXT As _IMSS_DO_TEXT_DELEGATE

    Public Event _IMSS_DO_PROBLEMS As _IMSS_DO_PROBLEMS_DELEGATE

#End Region

End Class
