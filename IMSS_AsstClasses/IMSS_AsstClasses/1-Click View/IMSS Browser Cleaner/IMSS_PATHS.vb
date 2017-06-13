Imports System.IO

Public Class IMSS_PATHS

#Region " Base Path Methods "
    ''' <summary>
    ''' This method is only declared to make, making changes to all variables that require
    ''' the AppData Roaming path, easier.
    ''' </summary>
    ''' <returns>Returns the user profile AppData Roaming path</returns>
    ''' <remarks>ie: C:\Users\%USERPROFILE%\AppData\Roaming</remarks>
    Private Shared Function profileAppDataRoaming() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    End Function

    ''' <summary>
    ''' User profile application data local path.
    ''' </summary>
    ''' <returns>AppData Local</returns>
    ''' <remarks>N/A</remarks>
    Private Shared Function profileAppDataLocal() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
    End Function

    ''' <summary>
    ''' User profile application data local low path.
    ''' </summary>
    ''' <returns>Returns the user profile LocalLow AppData path</returns>
    ''' <remarks>N/A</remarks>
    Private Shared Function profileAppDataLocalLow() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "Low"
    End Function

    ''' <summary>
    ''' This method is used to identify the FF paths via the unique profile name
    ''' </summary>
    ''' <param name="pathType">Path type of path, ie: cookies, downloads, formhistory, cache</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function mozillaFireFoxPaths(ByVal pathType As String) As String
        Dim rootPath = profileAppDataRoaming() & "\Mozilla\Firefox\Profiles"
        Dim rootPath2 = profileAppDataLocal() & "\Mozilla\Firefox\Profiles"
        If Directory.Exists(rootPath) Then
            Dim defaultProfilePaths = Directory.GetDirectories(rootPath, "*.default")
            For Each subfolderPath In defaultProfilePaths
                Select Case pathType
                    Case "cookies"
                        Return subfolderPath & "\cookies.sqlite"
                    Case "webappsstore"
                        Return subfolderPath & "\webappsstore.sqlite"
                    Case "downloads"
                        Return subfolderPath & "\downloads.sqlite"
                    Case "formhistory"
                        Return subfolderPath & "\formhistory.sqlite"
                    Case "cache"
                        Dim defaultProfilePaths2 = Directory.GetDirectories(rootPath2, "*.default")
                        For Each subfolderPath2 In defaultProfilePaths2
                            Return subfolderPath2 & "\cache"
                        Next
                    Case "sessionstore.js"
                        Return subfolderPath & "\sessionstore.js"
                    Case "sessionstore.bak"
                        Return subfolderPath & "\sessionstore.bak"
                    Case Else
                        Return "ERROR"
                End Select
            Next
        End If : Return "ERROR"
    End Function
#End Region

#Region " Internet Explorer "
    ''' <summary>
    ''' Path to Internet Explorer's cookies
    ''' </summary>
    ''' <remarks>N/A</remarks>
    Public Shared InternetExplorerCookies As String = profileAppDataRoaming() & "\Microsoft\Windows\Cookies"
    ''' <summary>
    ''' Path to IE's cookies via DOM Store
    ''' </summary>
    ''' <remarks>N/A</remarks>
    Public Shared InternetExplorerCookiesDomStore As String = profileAppDataLocalLow() & "\Microsoft\Internet Explorer\DOMStore"
    ''' <summary>
    ''' Path to Internet Explorer's temp files
    ''' </summary>
    ''' <remarks>N/A</remarks>
    Public Shared InternetExplorerTemps As String = profileAppDataLocal() & "\Microsoft\Windows\Temporary Internet Files"
    ''' <summary>
    ''' Path to Internet Explorer's history
    ''' </summary>
    ''' <remarks>N/A</remarks>
    Public Shared InternetExplorerHistory As String = profileAppDataLocal() & "\Microsoft\Windows\History"
    ''' <summary>
    ''' Path to Internet Explorer's recently typed URLs. See remarks.
    ''' </summary>
    ''' <remarks>IE's recently typed URLs are stored in the regstry, under HKCU.</remarks>
    Public Shared InternetExplorerRecentlyTypedUrls As String = "SOFTWARE\Microsoft\Internet Explorer\TypedURLs"
    ''' <summary>
    ''' Path to one of Internet Explorer's index.dat files
    ''' </summary>
    ''' <remarks>File, not directory. Index.dat files are usually locked. So you'll need to unlock it before deleting.</remarks>
    Public Shared InternetExplorerIndexDat_1 As String = profileAppDataRoaming() & "\Microsoft\Windows\PrivacIE\index.dat"
    ''' <summary>
    ''' Path to one of Internet Explorer's index.dat files
    ''' </summary>
    ''' <remarks>File, not directory. Index.dat files are usually locked. So you'll need to unlock it before deleting.</remarks>
    Public Shared InternetExplorerIndexDat_2 As String = profileAppDataRoaming() & "\Microsoft\Windows\PrivacIE\Low\index.dat"
    ''' <summary>
    ''' Path to one of Internet Explorer's index.dat files
    ''' </summary>
    ''' <remarks>File, not directory. Index.dat files are usually locked. So you'll need to unlock it before deleting.</remarks>
    Public Shared InternetExplorerIndexDat_3 As String = profileAppDataRoaming() & "\Microsoft\Windows\IECompactCache\index.dat"
    ''' <summary>
    ''' Path to one of Internet Explorer's index.dat files
    ''' </summary>
    ''' <remarks>File, not directory. Index.dat files are usually locked. So you'll need to unlock it before deleting.</remarks>
    Public Shared InternetExplorerIndexDat_4 As String = profileAppDataRoaming() & "\Microsoft\Windows\IECompactCache\Low\index.dat"
    ''' <summary>
    ''' Path to one of Internet Explorer's index.dat files
    ''' </summary>
    ''' <remarks>File, not directory. Index.dat files are usually locked. So you'll need to unlock it before deleting.</remarks>
    Public Shared InternetExplorerIndexDat_5 As String = profileAppDataRoaming() & "\Microsoft\Windows\IETldCache\index.dat"
    ''' <summary>
    ''' Path to one of Internet Explorer's index.dat files
    ''' </summary>
    ''' <remarks>File, not directory. Index.dat files are usually locked. So you'll need to unlock it before deleting.</remarks>
    Public Shared InternetExplorerIndexDat_6 As String = profileAppDataRoaming() & "\Microsoft\Windows\IETldCache\Low\index.dat"
#End Region

#Region " Google Chrome "
    ''' <summary>
    ''' Path to Google Chrome's cookies. See Remarks.
    ''' </summary>
    ''' <remarks>This is NOT a directory and is instead a file with no extension. I think it's a SQLITE database.
    ''' Either way, Chrome must be closed in order to delete this file and clear the cookies.</remarks>
    Public Shared GoogleChromeCookies As String = profileAppDataLocal() & "\Google\Chrome\User Data\Default\Cookies"
    ''' <summary>
    ''' Path to Google Chrome's database cookies.
    ''' </summary>
    ''' <remarks>Search recursively - directory</remarks>
    Public Shared GoogleChromeCookiesDBs As String = profileAppDataLocal() & "\Google\Chrome\User Data\Default\databases"
    ''' <summary>
    ''' Path to Google Chrome's local storage cookies.
    ''' </summary>
    ''' <remarks> Search non-recursively - directory</remarks>
    Public Shared GoogleChromeCookiesLocalStorage As String = profileAppDataLocal() & "\Google\Chrome\User Data\Default\Local Storage"
    ''' <summary>
    ''' Path to Google Chrome's cache.
    ''' </summary>
    ''' <remarks>N/A</remarks>
    Public Shared GoogleChromeCache As String = profileAppDataLocal() & "\Google\Chrome\User Data\Default\Cache"
    ''' <summary>
    ''' Path to Google Chrome's history directory. See Remarks.
    ''' </summary>
    ''' <remarks>The history is contained in four different files that all contain the word "History" and must be deleted
    ''' in order to clear all of chrome's history. They look something like "History Index 2011-00-journal", "History Index 2011-00", 
    ''' "History", "History-journal". It's best to loop through each file in the directory, non-recursively, and filter for "History".</remarks>
    Public Shared GoogleChromeInternetHistory As String = profileAppDataLocal() & "\Google\Chrome\User Data\Default"
#End Region

#Region " Mozilla FireFox "
    ''' <summary>
    ''' Mozilla Firefox cookies path
    ''' </summary>
    ''' <remarks>Path is file not directory</remarks>
    Public Shared MozillaFireFoxCookies As String = mozillaFireFoxPaths("cookies")
    ''' <summary>
    ''' Mozilla Firefox
    ''' </summary>
    ''' <remarks>Path is file, not directory</remarks>
    Public Shared MozillaFireFoxCookiesWebAppsStore As String = mozillaFireFoxPaths("webappsstore")
    ''' <summary>
    ''' Mozilla Firefox Download history path
    ''' </summary>
    ''' <remarks>Path is file not directory</remarks>
    Public Shared MozillaFireFoxDownloads As String = mozillaFireFoxPaths("downloads")
    ''' <summary>
    ''' Mozilla Firefox form history path
    ''' </summary>
    ''' <remarks>Path is file not directory</remarks>
    Public Shared MozillaFireFoxFormHistory As String = mozillaFireFoxPaths("formhistory")
    ''' <summary>
    ''' Mozilla Firefox cache path
    ''' </summary>
    ''' <remarks>Path is directory, not path</remarks>
    Public Shared MozillaFireFoxCache As String = mozillaFireFoxPaths("cache")
    ''' <summary>
    ''' Mozilla Firefox session store path
    ''' </summary>
    ''' <remarks>Path is a file, not a directory</remarks>
    Public Shared MozillaFirefoxSessionStore As String = mozillaFireFoxPaths("sessionstore.js")
    ''' <summary>
    ''' Mozilla Firefox session store backup path
    ''' </summary>
    ''' <remarks>Path is a file, not a directory</remarks>
    Public Shared MozillaFirefoxSessionStoreBackup As String = mozillaFireFoxPaths("sessionstore.bak")
#End Region

#Region " Safari "
    ''' <summary>
    ''' Safari cache path
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared SafariCache As String = profileAppDataRoaming() & "\Apple Computer\Safari\Cache.db"
    ''' <summary>
    ''' Safari History list
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared SafariHistoryPlist As String = profileAppDataRoaming() & "\Apple Computer\Safari\History.plist"
    ''' <summary>
    ''' Safari last session path
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared SafariHistoryLastSessionPlist As String = profileAppDataRoaming() & "\Apple Computer\Safari\LastSession.plist"
    ''' <summary>
    ''' Safari History downloads list
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared SafariHistoryDownloadsPlist As String = profileAppDataRoaming() & "\Apple Computer\Safari\Downloads.plist"
    ''' <summary>
    ''' Safari  History path
    ''' </summary>
    ''' <remarks>Directory</remarks>
    Public Shared SafariHistory As String = profileAppDataLocal() & "\Apple Computer\Safari\History"
    ''' <summary>
    ''' Safari Webpage Previews
    ''' </summary>
    ''' <remarks>Directory</remarks>
    Public Shared SafariWebpagePreviews As String = profileAppDataLocal() & "\Apple Computer\Safari\Webpage Previews"
#End Region

#Region " Opera "
    ''' <summary>
    ''' Opera Cache
    ''' </summary>
    ''' <remarks>Search recursively</remarks>
    Public Shared OperaCache As String = profileAppDataLocal() & "\Opera\Opera\cache"
    ''' <summary>
    ''' Opera OP Cache
    ''' </summary>
    ''' <remarks>N/A</remarks>
    Public Shared OperaOPCache As String = profileAppDataLocal() & "\Opera\Opera\opcache"
    ''' <summary>
    ''' Opera Icon Cache
    ''' </summary>
    ''' <remarks>Search recursively</remarks>
    Public Shared OperaIconCache As String = profileAppDataLocal() & "\Opera\Opera\icons\cache"
    ''' <summary>
    ''' Opera Internet History
    ''' </summary>
    ''' <remarks>Search recursively</remarks>
    Public Shared OperaInternetHistory_1 As String = profileAppDataLocal() & "\Opera\Opera\vps"
    ''' <summary>
    ''' Opera Internet History - DAT Files
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared OperaInternetHistory_2 As String = profileAppDataRoaming() & "\Opera\Opera\global_history.dat"
    ''' <summary>
    ''' Opera Internet History
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared OperaInternetHistory_3 As String = profileAppDataRoaming() & "\Opera\Opera\download.dat"
    ''' <summary>
    ''' Opera Internet History
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared OperaInternetHistory_4 As String = profileAppDataRoaming() & "\Opera\Opera\vlink4.dat"
    ''' <summary>
    ''' Opera Internet History
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared OperaInternetHistory_5 As String = profileAppDataRoaming() & "\Opera\Opera\typed_history.xml"
    ''' <summary>
    ''' Opera Internet History
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared OperaInternetHistory_6 As String = profileAppDataRoaming() & "\Opera\Opera\sessions\autosave.win"
    ''' <summary>
    ''' Opera Cookies
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared OperaCookies As String = profileAppDataRoaming() & "\Opera\Opera\cookies4.dat"
    ''' <summary>
    ''' Opera Website Icons
    ''' </summary>
    ''' <remarks>Do not recurse</remarks>
    Public Shared OperaWebsiteIcon As String = profileAppDataLocal() & "\icons"
    ''' <summary>
    ''' Opera Temporary Downloads - Download History
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared OperaCacheTempDownloads As String = profileAppDataLocal() & "\Opera\Opera\temporary_downloads"
#End Region

#Region " Internet - uTorrent, Java "
    ''' <summary>
    ''' Main uTorrent temp files. Typically "resume.dat.old" and "settings.dat.old"
    ''' </summary>
    ''' <remarks>Filter with *.old</remarks>
    Public Shared uTorrentTempFiles As String = profileAppDataRoaming() & "\uTorrent"
    ''' <summary>
    ''' uTorrent DLL Image Cache
    ''' </summary>
    ''' <remarks>N/A</remarks>
    Public Shared uTorrentDllImageCache As String = profileAppDataRoaming() & "\uTorrent\dllimagecache"
    ''' <summary>
    ''' Sun Java Cache
    ''' </summary>
    ''' <remarks>N/A</remarks>
    Public Shared SunJavaCache As String = profileAppDataLocalLow() & "\Sun\Java\Deployment\cache\6.0"
    ''' <summary>
    ''' Sun Java System Cache
    ''' </summary>
    ''' <remarks>N/A</remarks>
    Public Shared SunJavaSystemCache As String = profileAppDataLocalLow() & "\Sun\Java\Deployment\SystemCache\6.0"
    ''' <summary>
    ''' FileZilla Recent Server List
    ''' </summary>
    ''' <remarks>File, not directory</remarks>
    Public Shared FileZillaRecentServers As String = profileAppDataRoaming() & "\FileZila\recentservers.xml"
#End Region

End Class
