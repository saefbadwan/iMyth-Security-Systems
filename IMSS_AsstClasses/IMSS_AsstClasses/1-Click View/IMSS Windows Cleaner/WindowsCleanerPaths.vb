Imports System.IO
Friend Class WindowsCleanerPaths

#Region " Base Path Methods "

#Region "IMSS Dynamic Functions Paths"
    Private Shared Function _IMSS_GetRecycleBin() As String
        On Error Resume Next
        Dim SH As New Shell32.Shell
        Dim RecycleBin As Shell32.Folder = SH.NameSpace(Shell32.ShellSpecialFolderConstants.ssfBITBUCKET)
        Dim _IMSS_RecycleBin As String = String.Empty
        For Each Item As Shell32.FolderItem In RecycleBin.Items
            _IMSS_RecycleBin = Path.GetDirectoryName(Item.Path).ToString()
            Exit For
        Next Item
        Return _IMSS_RecycleBin
    End Function
    Private Shared Function _IMSS_DETECTEOSSYSTEM() As Boolean
        On Error Resume Next
        Dim osInfo As System.OperatingSystem = System.Environment.OSVersion
        Select Case osInfo.Version.Major
            Case 5
                Return False
            Case Else
                Return True
        End Select
    End Function

    Private Shared Function _IMSS_GETUSERNAME() As String
        Return Environment.UserName.ToString()
    End Function
#End Region

    Private Shared ReadOnly Property _IMSS_WindowsDefenderDefinitionUpdatesBackup As String
        Get
            Return programData() & "\Microsoft\Windows Defender\Definition Updates\Backup"
        End Get
    End Property
    Private Shared ReadOnly Property programData As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
        End Get
    End Property
    Private Shared ReadOnly Property _IMSS_WindowsErrorReportingReportQueue As String
        Get
            Return profileAppDataLocal() & "\Microsoft\Windows\WER\ReportQueue"
        End Get
    End Property
    Private Shared ReadOnly Property profileAppDataRoaming As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        End Get
    End Property
    Private Shared ReadOnly Property profileAppDataLocal As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        End Get
    End Property
    Private Shared ReadOnly Property profileAppDataLocalLow As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Low"
        End Get
    End Property
    Private Shared ReadOnly Property AllUserAppDataLocalLow As String
        Get
            Return Environment.ExpandEnvironmentVariables("%AllUsersProfile%") & "\AppData\Local"
        End Get
    End Property
    Private Shared ReadOnly Property system32Path As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.System)
        End Get
    End Property

    Private Shared ReadOnly Property osDrive As String
        Get
            Return system32Path.Substring(0, 3)
        End Get
    End Property
#End Region



    Private Shared ReadOnly Property osDriveWindows As String
        Get
            Return Environment.GetEnvironmentVariable("WINDIR", EnvironmentVariableTarget.Machine)
        End Get
    End Property

#Region " Windows Explorer "
    Friend Shared ReadOnly Property WindowsExplorerRecent As String
        Get
            If _IMSS_DETECTEOSSYSTEM() = True Then Return profileAppDataRoaming() & "\Microsoft\Windows\Recent" Else Return osDrive().Replace("\", "") & "\Documents and Settings\" & _IMSS_GETUSERNAME().Replace("\", "") & "\Recent"
        End Get
    End Property
    Friend Shared ReadOnly Property WindowsExplorerThumbnailCache As String
        Get
            Return profileAppDataLocal() & "\MICROSOFT\Windows\Explorer"
        End Get
    End Property
#End Region

#Region " System "
    Friend Shared ReadOnly Property _IMSS_IconCashesDb As String
        Get
            Return profileAppDataLocal() & "\IconCache.db"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_GDIPFONTCACHEV1 As String
        Get
            Return profileAppDataLocal() & "\GDIPFONTCACHEV1.DAT"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_FNTCACHEDat As String
        Get
            Return system32Path() & "\FNTCACHE.DAT"
        End Get
    End Property
    Friend Shared ReadOnly Property WindowsTempFiles As String
        Get
            Return osDriveWindows() & "\Temp"
        End Get
    End Property
    Friend Shared ReadOnly Property UserTemps As String
        Get
            Return profileAppDataLocal() & "\Temp"
        End Get
    End Property
    Friend Shared ReadOnly Property MiniDumps As String
        Get
            Return osDriveWindows() & "\MiniDump"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_LiveKernelReportsMiniDumps As String
        Get
            Return osDriveWindows() & "\LiveKernelReports\WATCHDOG"
        End Get
    End Property
    Friend Shared ReadOnly Property ChkDskFileFragments As String
        Get
            Return osDriveWindows()
        End Get
    End Property
    Friend Shared ReadOnly Property WindowsLogFiles As String
        Get
            Return osDriveWindows()
        End Get
    End Property
    Friend Shared ReadOnly Property WindowsErrorReporting_1 As String
        Get
            Return profileAppDataLocal() & "\Microsoft\Windows\WER\ReportArchive"
        End Get
    End Property
    Friend Shared ReadOnly Property WindowsErrorReporting_2 As String
        Get
            Return profileAppDataLocal() & "\Microsoft\Windows\WER\ReportQueue"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_CDDVD As String
        Get
            Return profileAppDataLocal() & "\Microsoft\Windows\Burn\"
        End Get
    End Property
    Friend Shared ReadOnly Property WindowsErrorReporting_3 As String
        Get
            Return programData() & "\Microsoft\Windows\WER\ReportArchive"
        End Get
    End Property
    Friend Shared ReadOnly Property WindowsErrorReporting_4 As String
        Get
            Return programData() & "\Microsoft\Windows\WER\ReportQueue"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_NETFREAMORKDIR As String
        Get
            Return osDriveWindows() & "\Microsoft.NET\Framework\v4.0.30319"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_WINDOWSINI As String
        Get
            Return osDriveWindows() & "\inf"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_WINDOWSLOGSCBS As String
        Get
            Return osDriveWindows() & "\Logs\CBS"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_WINDOWSLOGSDPX As String
        Get
            Return osDriveWindows() & "\Logs\DPX"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_WINDOWSDEBUG As String
        Get
            Return osDriveWindows() & "\debug"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_RecycleBin As String
        Get
            If _IMSS_DETECTEOSSYSTEM() = True Then Return _IMSS_GetRecycleBin() Else Return IMSS_WindowsXPRecycleBinPath()
        End Get
    End Property
    Private Shared Function IMSS_WindowsXPRecycleBinPath() As String
        Return osDrive() & "\RECYCLER"
    End Function

#End Region

#Region " Advanced "
    Friend Shared ReadOnly Property PrefetchData As String
        Get
            Return osDriveWindows() & "\Prefetch"
        End Get
    End Property
    Friend Shared ReadOnly Property ServiceProfiles As String
        Get
            Return osDriveWindows() & "\ServiceProfiles\LocalService\AppData\Local"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_SoftwareDistribution As String
        Get
            Return osDrive() & "\Windows\SoftwareDistribution\Download"
        End Get
    End Property
    Friend Shared ReadOnly Property IISLogs_1 As String
        Get
            Return system32Path() & "\LogFiles"
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_WINDOWSSYSTEMLOGFILESSCM As String
        Get
            Return system32Path() & "\LogFiles\Scm"
        End Get
    End Property
    Friend Shared ReadOnly Property IISLogs_2 As String
        Get
            Return osDrive() & "\inetpub\logs\LogFiles"
        End Get
    End Property
#End Region

#Region " Media "

    Friend Shared ReadOnly Property WindowsMediaPlayer As String
        Get
            Return profileAppDataLocal() & "\Microsoft\Media Player"
        End Get
    End Property
    Friend Shared ReadOnly Property QuickTimePlayerCache As String
        Get
            Return profileAppDataLocalLow() & "\Apple Computer\QuickTime\downloads"
        End Get
    End Property
    Friend Shared ReadOnly Property QuickTimerPlayer As String
        Get
            Return profileAppDataLocalLow() & "\Apple Computer\QuickTime\QTPlayerSession.xml"
        End Get
    End Property
    Friend Shared ReadOnly Property AdobeFlashPlayer As String
        Get
            Return profileAppDataRoaming() & "\Macromedia"
        End Get
    End Property

#End Region

End Class