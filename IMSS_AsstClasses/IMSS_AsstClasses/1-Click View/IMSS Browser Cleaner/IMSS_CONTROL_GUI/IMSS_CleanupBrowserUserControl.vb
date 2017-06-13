Imports System.IO
Imports Microsoft.Win32

Public Class IMSS_CleanupBrowserUserControl

#Region "Cleaning Options"

    Private _IMSS_CleanupInternetExplorerVar As Boolean = True

    Private _IMSS_CleanupChromeVar As Boolean = True

    Private _IMSS_CleanupMozillaFirefoxVar As Boolean = True

    Private _IMSS_CleanupSafariVar As Boolean = True

    Private _IMSS_CleanupOperaVar As Boolean = True

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

    Private Sub _IMSS_OptionLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_OptionLinkLabel.LinkClicked


        Dim _IMSS_BrowsersCleanerOption As New IMSS_BrowsersCleanerOptions(New Boolean() {_IMSS_CleanupInternetExplorerVar, _IMSS_CleanupChromeVar, _
                                                                                        _IMSS_CleanupMozillaFirefoxVar, _IMSS_CleanupSafariVar, _
                                                                                        _IMSS_CleanupOperaVar})

        AddHandler _IMSS_BrowsersCleanerOption._IMSS_TARGETS_SETTINGS, Sub(ByRef _IMSS_TARGETS_SETTINGS() As Boolean)

                                                                           _IMSS_CleanupInternetExplorerVar = _IMSS_TARGETS_SETTINGS(0)

                                                                           _IMSS_CleanupChromeVar = _IMSS_TARGETS_SETTINGS(1)

                                                                           _IMSS_CleanupMozillaFirefoxVar = _IMSS_TARGETS_SETTINGS(2)

                                                                           _IMSS_CleanupSafariVar = _IMSS_TARGETS_SETTINGS(3)

                                                                           _IMSS_CleanupOperaVar = _IMSS_TARGETS_SETTINGS(4)

                                                                       End Sub
        _IMSS_BrowsersCleanerOption.ShowDialog()

    End Sub

    Public Sub _IMSS_START_CLEANNING()

        RaiseEvent _IMSS_DO_MINOR_TEXT(" >> Cleaning Internet Explorer ... ")

        If (_IMSS_CleanupInternetExplorerVar = True) Then

            _IMSS_CleanupInternetExplorer()

        End If

        RaiseEvent _IMSS_DO_MINOR_TEXT(" >> Cleaning Google Chrome ... ")

        If (_IMSS_CleanupChromeVar = True) Then

            _IMSS_CleanupChrome()

        End If

        RaiseEvent _IMSS_DO_MINOR_TEXT(" >> Cleaning Mozilla Firefox ... ")

        If (_IMSS_CleanupMozillaFirefoxVar = True) Then

            _IMSS_CleanupMozillaFirefox()

        End If

        RaiseEvent _IMSS_DO_MINOR_TEXT(" >> Cleaning Safari ... ")

        If (_IMSS_CleanupSafariVar = True) Then

            _IMSS_CleanupSafari()

        End If

        RaiseEvent _IMSS_DO_MINOR_TEXT(" >> Cleaningn Opera ... ")

        If (_IMSS_CleanupOperaVar = True) Then

            _IMSS_CleanupOpera()

        End If

    End Sub

    Private Sub _IMSS_CleanupInternetExplorer()

        If Directory.Exists(IMSS_PATHS.InternetExplorerCookies) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.InternetExplorerCookies, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.InternetExplorerCookiesDomStore) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.InternetExplorerCookiesDomStore, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.InternetExplorerTemps) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.InternetExplorerTemps, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.InternetExplorerHistory) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.InternetExplorerHistory, "*.*")
        End If

        If _IMSS_CheckIfRegistryKeyExsits(IMSS_PATHS.InternetExplorerRecentlyTypedUrls) = True Then
            _IMSS_RegistryCleaner(IMSS_PATHS.InternetExplorerRecentlyTypedUrls)
        End If

    End Sub

    Private Sub _IMSS_CleanupChrome()

        If Directory.Exists(IMSS_PATHS.GoogleChromeCookiesLocalStorage) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.GoogleChromeCookiesLocalStorage, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.GoogleChromeCookiesDBs) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.GoogleChromeCookiesDBs, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.GoogleChromeCookies) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.GoogleChromeCookies, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.GoogleChromeCache) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.GoogleChromeCache, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.GoogleChromeInternetHistory) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.GoogleChromeInternetHistory, "*History*")
        End If
    End Sub

    Private Sub _IMSS_CleanupMozillaFirefox()
        If File.Exists(IMSS_PATHS.MozillaFireFoxCookies) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.MozillaFireFoxCookies)
        End If

        If File.Exists(IMSS_PATHS.MozillaFireFoxCookiesWebAppsStore) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.MozillaFireFoxCookiesWebAppsStore)
        End If

        If File.Exists(IMSS_PATHS.MozillaFireFoxDownloads) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.MozillaFireFoxDownloads)
        End If

        If File.Exists(IMSS_PATHS.MozillaFireFoxFormHistory) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.MozillaFireFoxFormHistory)
        End If

        If Directory.Exists(IMSS_PATHS.MozillaFireFoxCache) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.MozillaFireFoxCache, "*History*")
        End If

        If File.Exists(IMSS_PATHS.MozillaFirefoxSessionStore) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.MozillaFirefoxSessionStore)
        End If

        If File.Exists(IMSS_PATHS.MozillaFirefoxSessionStoreBackup) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.MozillaFirefoxSessionStoreBackup)
        End If
    End Sub

    Private Sub _IMSS_CleanupSafari()
        If File.Exists(IMSS_PATHS.SafariCache) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.SafariCache)
        End If

        If File.Exists(IMSS_PATHS.SafariHistory) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.SafariHistory)
        End If

        If Directory.Exists(IMSS_PATHS.SafariWebpagePreviews) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.SafariWebpagePreviews, "*History*")
        End If

        If File.Exists(IMSS_PATHS.SafariHistoryDownloadsPlist) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.SafariHistoryDownloadsPlist)
        End If

        If File.Exists(IMSS_PATHS.SafariHistoryLastSessionPlist) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.SafariHistoryLastSessionPlist)
        End If
    End Sub

    Private Sub _IMSS_CleanupOpera()
        If Directory.Exists(IMSS_PATHS.OperaCache) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.OperaCache, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.OperaOPCache) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.OperaOPCache, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.OperaIconCache) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.OperaIconCache, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.OperaInternetHistory_1) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.OperaInternetHistory_1, "*.*")
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_2) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.OperaInternetHistory_2)
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_3) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.OperaInternetHistory_3)
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_4) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.OperaInternetHistory_4)
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_5) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.OperaInternetHistory_5)
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_6) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.OperaInternetHistory_6)
        End If

        If File.Exists(IMSS_PATHS.OperaCookies) Then
            _IMSS_DELETE_FILE(IMSS_PATHS.OperaCookies)
        End If

        If Directory.Exists(IMSS_PATHS.OperaWebsiteIcon) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.OperaWebsiteIcon, "*.*")
        End If

        If Directory.Exists(IMSS_PATHS.OperaCacheTempDownloads) Then
            _IMSS_CLEAN_FILES_FORM_PATH(IMSS_PATHS.OperaCacheTempDownloads, "*.*")
        End If

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

    Private Shared Sub _IMSS_RegistryCleaner(ByVal _IMSS_Path As String)
        Dim _IMSS_RegeditKey As RegistryKey = Registry.CurrentUser.OpenSubKey(_IMSS_Path)
        For Each _IMSS_VALUE As String In _IMSS_RegeditKey.GetValueNames()
            'Try : _IMSS_ChangeLabelText(_IMSS_VALUE)
            '    If Not _IMSS_ScanType = True Then _IMSS_RegeditKey.DeleteValue(_IMSS_VALUE) Else _IMSS_ErrorFounds += 1
            'Catch : End Try
        Next _IMSS_VALUE
    End Sub

    Private Shared Function _IMSS_CheckIfRegistryKeyExsits(ByVal _IMSS_TARGET As String) As Boolean
        Dim regKey As Object = My.Computer.Registry.CurrentUser.OpenSubKey(_IMSS_TARGET)
        If Not regKey Is Nothing Then
            regKey.close()
            Return True
        Else
            regKey.close()
            Return False
        End If
    End Function

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
