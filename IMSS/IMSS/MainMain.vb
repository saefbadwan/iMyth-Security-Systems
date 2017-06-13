Imports System.IO
Imports System.Threading
Imports Microsoft.Win32
Imports System.Security.AccessControl
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.Security.Principal
Imports IMSS_AsstClasses
Imports USBConfig
Imports ConfigurationResureses

Public Class MainMain

#Region "IMSS Dll"
    <DllImport("psapi")> _
    Private Shared Function EmptyWorkingSet(ByVal hProcess As Long) As Boolean
    End Function
#End Region

#Region "IMSS Main Core Declaration"
    Private _IMSS_DriveEncryption As New IMSS_DriveEncryption
    Private IMSS_USBScanCotrolsUint As New IMSS_USBScanCotrolsUint
    Private IMSS_MonitorsCotrolsUint As New IMSS_MonitorsCotrolsUint
    Private IMSS_DeviceImmunizer As New IMSS_DeviceImmunizer
    Private IMSS_LOGCotrolsUint As New IMSS_LOGCotrolsUint
    Private IMSS_Utilities As New IMSS_Utilities
    Private IMSS_MainSettings As New IMSS_MainSettings
    Private IMSS_Language As New IMSS_UpdateSettings
    Private IMSS_LOG As New IMSS_LOG
    Private _PathLogFile As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSS"
    Private _FullPathLogFile As String = _PathLogFile + "\Log"
    Private _IMSS_Startup_Type As String = _PathLogFile + "\IMSS.DATA"
    Public Shared _IMSS_Q As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSS"
    Public Shared IMSS_MainPanel_Settings_Sliding As Boolean = False
    Private _MontorPath As String = String.Empty
    Private _OtherTools As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\iMyth Security Systems\All functions"
    Private _IMSS_FixTools As String = _OtherTools + "\_IMSS_RepairSystems.exe"
    Public Shared ix As Integer = 0
    Private _IMSS_CheckSelectedUint As Short

#End Region

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        Try
            MyBase.OnMouseDown(e)
            If e.Button = MouseButtons.Left Then
                Me.Capture = False
                Me.WndProc(Message.Create(Me.Handle, &HA1, New IntPtr(2), IntPtr.Zero))
            End If
        Catch : End Try
    End Sub

    Private Sub MainMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        _IMSS_SYSTEM_UINT._IMSS_ALLOW_SURV = False
        _IMSS_Main_NotifyIcon.Dispose()
    End Sub

    Private Function _IMSS_CheckIfOSIsWinXP() As Boolean
        Try
            Dim osInfo As System.OperatingSystem = System.Environment.OSVersion
            If osInfo.Version.Major = 5 Then Return True Else Return False
        Catch : Return False : End Try
    End Function

    Private Sub MainMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If _IMSS_CheckIfOSIsWinXP() = True Then 'IMSS Check If Operating System Is Windows Vista Or Higher
            ConfigurationResureses.LinkVar._IMSS_OS_Version = False
            My.Settings._IMSS_OpertingSystem = "WindowsXp"
        Else
            ConfigurationResureses.LinkVar._IMSS_OS_Version = True
            My.Settings._IMSS_OpertingSystem = "Windows7"
        End If

        'If IO.File.Exists(_IMSS_Startup_Type) Then Me.Visible = False

        _IMSS_Set_ControlsStatus() ' Set Controls Status

        'If _IMSS_AR = True Then
        '    _IMSS_Set_ARvar() ' Set ar var
        'End If

        _IMSS_SetFile() ' Set files postions

        _IMSS_Load_CoedRed() ' Load MD5 Codes For The Systems

        _IMSS_CheckForUpdates(False) ' IMSS Check For Updates 

        _IMSS_SetupLayouts()

        _IMSS_Set_Border_LogFiles() ' Set border and log files and check monitors status

        _IMSS_LoadProtectionStatusContextMenu() ' IMSS Check For Protection Status

        _IMSS_FIRST_LOAD() ' IMSS Load all Systems and load MainWindow GUI

        GC.Collect() ' IMSS Cleanup RAM

    End Sub

#Region "IMSS LOAD MAIN GUI"
    Private Sub _IMSS_FIRST_LOAD()
        If Not IO.File.Exists(_IMSS_Startup_Type) Then
            Me.Opacity = 0
            Me.ShowInTaskbar = True
            Me.Visible = True
            Me._IMSS_SlideChecking = True
            Me._IMSS_Main_Button_Starts(False)
            _IMSS_SET_AERO_THEME()
            Application.DoEvents()
            Me.Enabled = True
            fade_in()
            fade_out()
            fade_in()
            Me.Activate()
            IO.File.Create(_IMSS_Startup_Type).Dispose()
        Else
            Me._IMSS_SlideChecking = False
            Me.Opacity = 0
            Me.Visible = False
            Me.ShowInTaskbar = False
            Me.Hide()
        End If
    End Sub
    Private Sub _IMSS_LOAD()
        Me.Opacity = 0
        Me.ShowInTaskbar = True
        Me.Visible = True
        Me._IMSS_SlideChecking = True
        Me._IMSS_Main_Button_Starts(False)
        _IMSS_SET_AERO_THEME()
        Application.DoEvents()
        Me.Activate()
        Me.Enabled = True
        fade_in()
        fade_out()
        fade_in()
    End Sub
#End Region

#Region "Set File Poistions"
    Private Sub _IMSS_SetFile()
        On Error Resume Next
        Dim directory As New IO.DirectoryInfo(_FullPathLogFile)
        For Each _IMSS_File As IO.FileInfo In directory.GetFiles
            If (Now - _IMSS_File.CreationTime).Days > 30 Then _IMSS_File.Delete()
        Next
        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\_IMSS_Cleaner.bat") Then
            IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\_IMSS_Cleaner.bat")
        End If
        If Not IO.Directory.Exists(_IMSS_Q + "\IMSSQ") Then
            IO.Directory.CreateDirectory(_IMSS_Q + "\IMSSQ")
            Dim fs As FileSystemSecurity = File.GetAccessControl(_IMSS_Q + "\IMSSQ")
            fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(_IMSS_Q + "\IMSSQ", fs)
        End If
        If Not IO.Directory.Exists(ConfigurationResureses.LinkVar._IMSS_CommonApplicationData + "\IMSS") Then IO.Directory.CreateDirectory(ConfigurationResureses.LinkVar._IMSS_CommonApplicationData + "\IMSS").Attributes = FileAttributes.Hidden
        If IMSS_RegConfig.Visible = True Then : IMSS_RegConfig.Close() : End If
    End Sub
#End Region

#Region "Set AR Var"
    'Private Sub _IMSS_Set_ARvar()
    '    On Error Resume Next
    '    IMSS_USBScanCotrolsUint.Button8.Text = "رجوع"
    '    IMSS_USBScanCotrolsUint.Button49.Text = "حجر"
    '    IMSS_USBScanCotrolsUint.Button9.Text = "حذف"
    '    IMSS_USBScanCotrolsUint._IMSS_SCANUSB_STATUS.Text = "لا يوجد اجهزة قابلة للأزالة متصلة بهذا الكمبيوتر"
    '    IMSS_USBScanCotrolsUint._IMSS_SCANUSB_STATUS.TextAlign = ContentAlignment.MiddleCenter
    '    IMSS_USBScanCotrolsUint._IMSS_DviceToScan.Text = "أجهزه لتشفير"
    '    _IMSS_DriveEncryption._IMSS_DriveEncryption_Label.Text = "تشفير الاجهزه"
    '    'IMSS_AutorunCotrolsUint.Label10.Text = "البحث عن ملفات التشغيل التلقائي"
    '    'IMSS_AutorunCotrolsUint.Label5.Text = "البحث عن ملفات التشغيل التلقائي في الأقراص المحلية والقابلة للأزالة وحذفها"
    '    'IMSS_AutorunCotrolsUint.Label8.Text = "النتائج:"
    '    'IMSS_AutorunCotrolsUint.Button10.Text = "Autorun بحث عن ملفات "
    '    'IMSS_AutorunCotrolsUint.Button11.Text = "Autorun حذف"
    '    'IMSS_ToolsCotrolsUint.TabControl2.TabPages(0).Text = "أدوات النطام"
    '    'IMSS_ToolsCotrolsUint.TabControl2.TabPages(1).Text = "أدوات العائلة"
    '    'IMSS_ToolsCotrolsUint.TabControl2.TabPages(2).Text = "غير ذالك"
    '    IMSS_LOGCotrolsUint.TabControl1.TabPages(0).Text = "سجل ألأمان"
    '    IMSS_LOGCotrolsUint.TabControl1.TabPages(1).Text = "سجل النظام"
    '    IMSS_LOGCotrolsUint.TabControl1.TabPages(2).Text = "USB سجل"
    '    IMSS_MonitorsCotrolsUint.Label57.Text = "انظمة المراقبة"
    '    IMSS_MonitorsCotrolsUint.Label63.Text = "مراقب النظام:"
    '    IMSS_MonitorsCotrolsUint.Label66.Text = "مسار المراقبة:"
    '    IMSS_MonitorsCotrolsUint.Label62.Text = "فعاليات مراقب النظام:"
    '    IMSS_MonitorsCotrolsUint.Label60.Text = "سجل الأمان:"
    '    IMSS_MonitorsCotrolsUint.Label65.Text = "النظام"
    '    IMSS_MonitorsCotrolsUint.Label61.Text = "مفعل"
    '    IMSS_MonitorsCotrolsUint.Label73.Text = "USB مراقب:"
    '    IMSS_MonitorsCotrolsUint.Label68.Text = "مسار المراقبة:"
    '    IMSS_MonitorsCotrolsUint.Label42.Text = "USB فعاليات مراقب:"
    '    IMSS_MonitorsCotrolsUint.Label71.Text = "مفعل"
    '    IMSS_MonitorsCotrolsUint.Label67.Text = "ينتظر"
    '    IMSS_MonitorsCotrolsUint.Label59.Text = "متوفر"
    '    IMSS_MonitorsCotrolsUint.Button47.Text = "تفعيل المراقبه"
    '    IMSS_MonitorsCotrolsUint.Button48.Text = "تعطيل المراقبه"
    '    IMSS_MonitorsCotrolsUint.Label75.Text = "ملاحظه : لتفعيل او تعطيل اي من الخيارات في هذه اللوحة اذهب الى اعدادات"
    '    IMSS_MonitorsCotrolsUint.Label75.Location = New Point(290, 5)
    '    IMSS_MonitorsCotrolsUint.Label58.Text = "حالة النظام"
    '    IMSS_MonitorsCotrolsUint.Label76.Text = "هذا الخيار يدعك تختار قيل عملية حذف الملفات الضارة اذا وجدت"
    '    IMSS_MonitorsCotrolsUint.Button19.Text = "جعل الحالة تلقائي"
    '    IMSS_MonitorsCotrolsUint.Button22.Text = "جعل الحالة يدوي"
    '    IMSS_MonitorsCotrolsUint.Label4.Text = "الحالة:"
    '    IMSS_MonitorsCotrolsUint.Label35.Text = "يدوي"
    '    'IMSS_ToolsCotrolsUint.Button1.Text = "متصفح الملفات المتقدم"
    '    'IMSS_ToolsCotrolsUint.Button50.Text = "مدير تنظيف الذاكرة"
    '    'IMSS_ToolsCotrolsUint.Button25.Text = "مدير برامج بدء التشغيل"
    '    'IMSS_ToolsCotrolsUint.Label20.Text = "أدوات أخرى"
    '    'IMSS_ToolsCotrolsUint.Button23.Text = "مدير تنظيف الملفات المؤقته ومخلفات المتصفحات وغيرها الكثير"
    '    'IMSS_ToolsCotrolsUint.Button24.Text = "مدير تنظيف الرجستري وتصحيح الأخطاء"
    '    'IMSS_ToolsCotrolsUint.Button26.Text = "مدير ازالة البرامج"
    '    'IMSS_ToolsCotrolsUint.Button30.Text = "مدير العمليات"
    '    'IMSS_ToolsCotrolsUint.Button33.Text = "مدير عرض معلومات النظام والأجهزة"
    '    'IMSS_ToolsCotrolsUint.Button37.Text = "أداة ايقاف التشغيل التلقائية"
    '    'IMSS_ToolsCotrolsUint.Button36.Text = "أداة حظر المواقع"
    '    'IMSS_ToolsCotrolsUint.Button38.Text = "أداة حظر البرامج"
    '    'IMSS_ToolsCotrolsUint.Button39.Text = "أداة قفل المجلدات"
    '    'IMSS_ToolsCotrolsUint.Button40.Text = "مدير خدمات النظام"
    '    'IMSS_ToolsCotrolsUint.Label77.Text = "ملاحظة : ربما تحتاج لتركيب حزمة"
    '    'IMSS_ToolsCotrolsUint.Label77.Location = New Point(472, 6)
    '    'IMSS_ToolsCotrolsUint.LinkLabel1.Location = New Point(384, 6)
    '    IMSS_LOGCotrolsUint.Label53.Text = "سجل الأمان"
    '    IMSS_LOGCotrolsUint.Button18.Text = "افراغ"
    'End Sub
#End Region

#Region "Set Border And Set Log Files"
    Private Sub _IMSS_Set_Border_LogFiles()
        Try
            If Not IO.Directory.Exists(_PathLogFile) Then IO.Directory.CreateDirectory(_PathLogFile)
            If Not IO.Directory.Exists(_FullPathLogFile) Then IO.Directory.CreateDirectory(_FullPathLogFile)
            If My.Settings.ONOFF = True Then
                _OnOff.Text = "UnBlocked"
            Else
                _OnOff.Text = "Blocked"
                _OnOff.ForeColor = Color.Red
            End If
        Catch : End Try
    End Sub
    'Private Sub _IMSS_CheckForTheSelectedLanguage()
    '    If IO.File.Exists(_IMSS_IMSSLang + "\_IMSS_AR.Lang") Then
    '        ArabicToolStripMenuItem.BackColor = Color.LightSkyBlue
    '        EnglishToolStripMenuItem.BackColor = Color.FromKnownColor(KnownColor.Control)
    '    Else
    '        EnglishToolStripMenuItem.BackColor = Color.LightSkyBlue
    '        ArabicToolStripMenuItem.BackColor = Color.FromKnownColor(KnownColor.Control)
    '    End If
    'End Sub
#End Region

#Region "Set Control Status and locations and size"
    Private Sub _IMSS_SetupLayouts()
        _Genral_Protection.Height = 0
        FlowLayoutPanel1.Height = 384
        FlowLayoutPanel1.Width = 641
        IMSS_Utilities._IMSS_OptimizeClickProperty = True ' IMSS That's Loaded Here Just For Quick Performance At Run Time Starts
    End Sub
    Private Sub _IMSS_Set_ControlsStatus()
        On Error Resume Next
        Control.CheckForIllegalCrossThreadCalls = False
        _IMSS_ControlsUserDisply.Height = 376
        _IMSS_ControlsUserDisply.Width = 640
        _IMSS_ControlsUserDisply.Location = New Point(182, 5)
        _IMSS_Utitilies_Uint.Location = New Point(-1, 66)
        _IMSS_Utitilies_Uint.Height = 393
        _IMSS_Utitilies_Uint.Width = 831
        _IMSS_Main_Window_SettingsPanels.Location = New Point(852, 32)
        _IMSS_Main_Window_SettingsPanels.Height = 427
        _IMSS_Main_Window_SettingsPanels.Width = 840
        _IMSS_MainSettings_Panel.Location = New Point(196, 39)
        _IMSS_MainSettings_Panel.Size = New Point(640, 376)
        _IMSS_MainSettings_Panel.Controls.Add(IMSS_MainSettings)
        _IMSS_MainSettings_Panel.Controls.Add(IMSS_Language)
        _IMSS_MainSettings_Panel.Controls.Add(IMSS_LOG)
        _IMSS_ControlsUserDisply.Controls.Add(_IMSS_DriveEncryption)
        _IMSS_ControlsUserDisply.Controls.Add(IMSS_USBScanCotrolsUint)
        _IMSS_ControlsUserDisply.Controls.Add(IMSS_MonitorsCotrolsUint)
        _IMSS_ControlsUserDisply.Controls.Add(IMSS_DeviceImmunizer)
        _IMSS_ControlsUserDisply.Controls.Add(IMSS_LOGCotrolsUint)
        _IMSS_Utitilies_Uint.Controls.Add(IMSS_Utilities)
        _IMSS_X = Me.Location.X
        _IMSS_Y = Me.Location.Y
        FlowLayoutPanel1.Location = New Point(181, 5)
    End Sub
#End Region

#Region "Load Code Red And Check For Updates"
    Private Delegate Sub _IMSS_Load_CoedRed_Delegate()
    Private Sub _IMSS_Load_CoedRed()

        Dim _IMSS_LOCAL_LIST_HASHES As New List(Of String)

        Dim _IMSS_THREAD As New Thread(Sub()
                                           Try
                                               Dim sr As StreamReader = New StreamReader([Assembly].GetExecutingAssembly().GetManifestResourceStream("IMSS.IMSSREDCODES.txt"))
                                               Dim line As String = String.Empty
                                               Do
                                                   line = sr.ReadLine()
                                                   If Not String.IsNullOrEmpty(line) Then
                                                       _IMSS_LOCAL_LIST_HASHES.Add(line)
                                                   End If
                                               Loop Until line Is Nothing
                                               sr.Close()
                                               Invoke(New _IMSS_Load_CoedRed_Delegate(Sub()
                                                                                          If (_IMSS_LOCAL_LIST_HASHES.Count() > 0) = True Then
                                                                                              IMSS_USBScanCotrolsUint._IMSS_CodesRed.AddRange(_IMSS_LOCAL_LIST_HASHES.ToArray())
                                                                                          End If
                                                                                      End Sub))
                                           Catch : End Try
                                       End Sub) : _IMSS_THREAD.Start()

    End Sub

    Private Sub _IMSS_CheckForUpdates(ByVal _IMSS_CHECK_STATUS As Boolean)
        On Error Resume Next

        Dim _IMSS_UPDATE As New UpdateSystems.MainCall(Me)

        With _IMSS_UPDATE

            ._IMSS_CURRENT_VERSION = ConfigurationResureses.LinkVar._IMSS_LOCAL_CONFIG_VERSION
            ._IMSS_UPDATE_ASMBLE_URL = ConfigurationResureses.LinkVar._IMSS_UPDATE_ASMBLE_URL
            ._IMSS_UPDATE_CONFIG_URL = ConfigurationResureses.LinkVar._IMSS_URL_CONFIG_VERSION
            ._IMSS_UPDATE_CHECK_LENGTH = My.Settings._IMSS_UPDATE_INTEGER ' Days
            ._IMSS_UPDATE_CHECK_TYPE = _IMSS_CHECK_STATUS  ' Check Now or Wate for the update setting check length

        End With

        _IMSS_UPDATE._IMSS_RUN_UPDATE_SYSTEM()

    End Sub

#End Region

#Region " IMSS Load Protection Status"
    Private Sub _IMSS_LoadProtectionStatusContextMenu()
        If My.Settings.SysMontior = True And My.Settings.SysSheild = True And My.Settings.SystemSounds = True And My.Settings.USBMonitor = True And My.Settings.USBShelid = True Then
            ExitToolStripMenuItem.CheckState = CheckState.Checked
        Else
            ExitToolStripMenuItem.CheckState = CheckState.Unchecked
        End If
    End Sub
#End Region

#Region "IMSS MAIN LOAD UINT"



    Private Sub _IMSS_OnLoad()
        Me.Visible = False
        Me.Opacity = 100
        Me.ShowInTaskbar = True
    End Sub



#End Region

#Region "IMSS Drop Shadow On MainWindow"
    <DllImport("dwmapi")> _
    Private Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function
    <DllImport("dwmapi")> _
    Private Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function
    <DllImport("dwmapi.dll")> _
    Private Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer
    End Function

    Private Const CS_DROPSHADOW As Integer = &H20000
    Private AeroEnabled As Boolean

    Public Structure MARGINS
        Public leftWidth As Integer
        Public rightWidth As Integer
        Public topHeight As Integer
        Public bottomHeight As Integer
    End Structure
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            _IMSS_CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not AeroEnabled Then
                cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
                Return cp
            Else
                Return cp
            End If
        End Get
    End Property

    Private Sub _IMSS_CheckAeroEnabled()
        If Environment.OSVersion.Version.Major >= 6 Then
            AeroEnabled = (DwmIsCompositionEnabled(Enabled) = 0)
        Else
            AeroEnabled = False
        End If
    End Sub

    Private Sub _IMSS_SET_AERO_THEME()
        If AeroEnabled Then
            DwmSetWindowAttribute(Handle, 2, 2, 4)
            Dim bla As New MARGINS()
            With bla
                .bottomHeight = 1
                .leftWidth = 0
                .rightWidth = 0
                .topHeight = 0
            End With
            DwmExtendFrameIntoClientArea(Handle, bla)
        End If
    End Sub

#End Region

#Region "IMSS Sliding Main Window Settings"
    Private _IMSS_Y As Integer = 0
    Private _IMSS_X As Integer = 0
#End Region

#Region "IMSS CORE USB DETECTION"

    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARRIVAL As Integer = &H8000
    Private Const DBT_DEVTYP_VOLUME As Integer = &H2
    Private Const DBT_DEVICEREMOVECOMPLETE = &H8004

    'Device information structure
    Public Structure DEV_BROADCAST_HDR
        Public dbch_size As Int32
        Public dbch_devicetype As Int32
        Public dbch_reserved As Int32
    End Structure

    'Volume information Structure
    Private Structure DEV_BROADCAST_VOLUME
        Public dbcv_size As Int32
        Public dbcv_devicetype As Int32
        Public dbcv_reserved As Int32
        Public dbcv_unitmask As Int32
        Public dbcv_flags As Int16
    End Structure

    'Function that gets the drive letter from the unit mask
    Private Function GetDriveLetterFromMask(ByRef Unit As Int32) As Char
        For i As Integer = 0 To 25
            If Unit = (2 ^ i) Then
                Return Chr(Asc("A") + i)
            End If
        Next
        Return Nothing
    End Function

    Private _IMSS_USB_UINT As SurveillanceSystems.IMSS_USB_SENSOR
    Public _IMSS_SYSTEM_UINT As SurveillanceSystems.IMSS_SYSTEM_SENSOR

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        On Error Resume Next
        If m.Msg = WM_DEVICECHANGE Then
            If CInt(m.WParam) = DBT_DEVICEARRIVAL Then
                Dim DeviceInfo As DEV_BROADCAST_HDR
                DeviceInfo = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_HDR)), DEV_BROADCAST_HDR)
                If DeviceInfo.dbch_devicetype = DBT_DEVTYP_VOLUME Then
                    Dim Volume As DEV_BROADCAST_VOLUME
                    Volume = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_VOLUME)), DEV_BROADCAST_VOLUME)
                    Dim _IMSS_USBTARGET As String = (GetDriveLetterFromMask(Volume.dbcv_unitmask) & ":\")
                    _MontorPath = _IMSS_USBTARGET
                    My.Settings.Driver_Founds = _IMSS_USBTARGET
                    If Not New DriveInfo(_IMSS_USBTARGET).DriveType = DriveType.CDRom Then
                        If My.Settings.USBShelid = True Then : Dim _IMSS_Scan As USBDefenses.USBScan = New USBDefenses.USBScan(_IMSS_USBTARGET, My.Settings.Mode) : End If
                        _IMSS_SET_SURV(_IMSS_USBTARGET)
                    End If : End If
            ElseIf CInt(m.WParam) = DBT_DEVICEREMOVECOMPLETE Then
                Dim DeviceInfo As DEV_BROADCAST_HDR
                DeviceInfo = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_HDR)), DEV_BROADCAST_HDR)
                If DeviceInfo.dbch_devicetype = DBT_DEVTYP_VOLUME Then
                    Dim Volume As DEV_BROADCAST_VOLUME
                    Volume = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_VOLUME)), DEV_BROADCAST_VOLUME)
                    Dim _IMSS_USBTARGET As String = (GetDriveLetterFromMask(Volume.dbcv_unitmask) & ":\")
                    If Not New DriveInfo(_IMSS_USBTARGET).DriveType = DriveType.CDRom Then
                        If My.Settings.USBShelid = True Then
                            If Not _IMSS_SYSTEM_UINT Is Nothing Then _IMSS_SYSTEM_UINT._IMSS_REMOVE_SURV(_IMSS_USBTARGET)
                        End If
                    End If : End If
            End If : End If
        'Process all other messages as normal
        MyBase.WndProc(m)
    End Sub

#End Region

#Region " IMSS Monitors Operations Functions"

    Private Sub _IMSS_SET_SURV(ByVal _IMSS_USB_TARGET As String)
        Try
            If My.Settings.USBMonitor = True Then
                _IMSS_USB_UINT = New SurveillanceSystems.IMSS_USB_SENSOR(My.Settings.SystemSounds) : _IMSS_USB_UINT.ShowInTaskbar() = False
                _IMSS_USB_UINT.Show() : _IMSS_USB_UINT._IMSS_START_SENSOR_SYSTEMS(_IMSS_USB_TARGET)
                With IMSS_MonitorsCotrolsUint.ListView2.Items.Add(_MontorPath)
                    .SubItems.Add(Date.Now.ToString())
                End With
                IMSS_MonitorsCotrolsUint.Label67.Text = _MontorPath
            End If
            If My.Settings.SysMontior = True Then
                If _IMSS_SYSTEM_UINT Is Nothing Then
                    _IMSS_SYSTEM_UINT = New SurveillanceSystems.IMSS_SYSTEM_SENSOR(My.Settings.SystemSounds)
                End If : _IMSS_SYSTEM_UINT._IMSS_SET_SURV(_IMSS_USB_TARGET)
                With IMSS_MonitorsCotrolsUint.ListView3.Items.Add(Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3))
                    .SubItems.Add(Date.Now.ToString())
                End With
            End If
        Catch ex As Exception
            IO.File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\error.txt", ex.Message)
        End Try
    End Sub

    Public Sub _IMSS_CONTROLS_RESEVENAME(ByVal _IMSS_CONTROLNAME As String)
        Select Case _IMSS_CheckSelectedUint
            Case 1
                _IMSS_SetControl(_IMSS_CONTROLNAME, _IMSS_DriveEncryption._IMSS_DvicesFound_Panel.Controls) : Exit Select
            Case 0
                _IMSS_SetControl(_IMSS_CONTROLNAME, IMSS_USBScanCotrolsUint._IMSS_USB_CONTROLS_PANEL.Controls) : Exit Select
            Case 2
                _IMSS_SetControl(_IMSS_CONTROLNAME, IMSS_DeviceImmunizer._IMSS_DvicesFound_Panel.Controls) : Exit Select
            Case Else
                Exit Select
        End Select
    End Sub
    Private Sub _IMSS_SetControl(ByRef _IMSS_SETCONTROLNAME As String, ByRef _IMSS_TARGET_CONTROLS As Panel.ControlCollection)
        For Each _IMSS_CONTROLS As IMSS_USB_DVICE In _IMSS_TARGET_CONTROLS
            If _IMSS_CONTROLS._IMSS_TARGET_DRIVE_TEXT = _IMSS_SETCONTROLNAME Then
                _IMSS_CONTROLS._IMSS_SELECTCONTROL = True
            Else
                _IMSS_CONTROLS._IMSS_SELECTCONTROL = False
            End If
        Next _IMSS_CONTROLS
    End Sub
#End Region

    Private Sub Butt3_Start()
        Me.SuspendLayout()
        _IMSS_CheckSelectedUint = 0
        If Not IMSS_USBScanCotrolsUint._IMSS_SCANER.IsBusy = True And IMSS_USBScanCotrolsUint._IMSS_SCAN_COMPLETE = False Then
            IMSS_USBScanCotrolsUint._IMSS_COMPELET_PROCESS_OR_NOT = True
            IMSS_USBScanCotrolsUint._IMSS_USB_CONTROLS_PANEL.Controls.Clear()
            Dim X As Integer = 10
            Dim Y As Integer = 4
            For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
                If d.DriveType = IO.DriveType.Removable And Not d.DriveType = DriveType.CDRom And d.IsReady = True Then
                    IMSS_USBScanCotrolsUint._IMSS_CheckingIfRemovabelDriveInUse.Size = New Size(640, 0)
                    IMSS_USBScanCotrolsUint._IMSS_CheckingIfRemovabelDriveInUse.Visible = False
                    IMSS_USBScanCotrolsUint._IMSS_DVICES_FOUND_PANEL.Size = New Size(640, 373)
                    IMSS_USBScanCotrolsUint._IMSS_DVICES_FOUND_PANEL.Visible = True
                    Dim _IMSS_WINDOW_CONTROLLER As New IMSS_USB_DVICE With {
                            ._IMSS_TARGET_DRIVE_TEXT = d.Name.ToString(),
                            .Location = New Point(X, Y),
                            .Visible = True}
                    IMSS_USBScanCotrolsUint._IMSS_USB_CONTROLS_PANEL.Controls.Add(_IMSS_WINDOW_CONTROLLER)
                    X += 160
                    If X > 640 Then : X = 10 : Y += 134 : End If
                Else
                    IMSS_USBScanCotrolsUint._IMSS_CheckingIfRemovabelDriveInUse.Size = New Size(640, 373)
                    IMSS_USBScanCotrolsUint._IMSS_CheckingIfRemovabelDriveInUse.Visible = True
                    IMSS_USBScanCotrolsUint._IMSS_DVICES_FOUND_PANEL.Size = New Size(640, 0)
                    IMSS_USBScanCotrolsUint._IMSS_DVICES_FOUND_PANEL.Visible = False
                End If
            Next
            Panel40.Visible = True
            _IMSS_ButtonSlidesCheckIfSlides = False
            _IMSS_Q_Holder.Visible = False
            _IMSS_Update_Holder.Visible = False
            FlowLayoutPanel1.Visible = False
            _Genral_Protection.Height = 0
            FlowLayoutPanel1.Height = 384
            FlowLayoutPanel1.Width = 641
            Panel9.Visible = False
            _Genral_Protection.Visible = False
            Button21.BackColor = Color.RoyalBlue
            Button21.ForeColor = Color.White
            _IMSS_USB_PROTECTION_BUTTON.BackColor = Color.AliceBlue
            _IMSS_USB_PROTECTION_BUTTON.ForeColor = Color.RoyalBlue
            Button41.BackColor = Color.RoyalBlue
            Button41.ForeColor = Color.White
            PictureBox17.BackColor = Color.RoyalBlue
            Panel7.Location = New Point(-1, 66)
            Panel7.Height = 390
            Panel7.Width = 829
            Panel7.Visible = True
            _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.White, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, _IMSS_DS_BUTTON)
            If _IMSS_CieckIfScanningRunning = False Then
                IMSS_USBScanCotrolsUint.Label64.Text = ""
                IMSS_USBScanCotrolsUint.Label34.Text = ""
                IMSS_USBScanCotrolsUint.lstFile.Items.Clear()
                IMSS_USBScanCotrolsUint.ProgressBar1.Value = 0
            End If
            _IMSS_ReSetPanelControls(False, True, False, False, False)
            IMSS_USBScanCotrolsUint.Panel3.Refresh()
            IMSS_USBScanCotrolsUint.Panel3.Visible = True
        Else
            _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.LightSkyBlue, Color.AliceBlue, _
     Color.AliceBlue, Color.AliceBlue, _IMSS_DS_BUTTON)
            _IMSS_ReSetPanelControls(False, True, False, False, False)
            IMSS_USBScanCotrolsUint.Panel3.Refresh()
            IMSS_USBScanCotrolsUint.Panel3.Visible = True
            IMSS_USBScanCotrolsUint._IMSS_CheckingIfRemovabelDriveInUse.Size = New Size(0, 0)
            IMSS_USBScanCotrolsUint._IMSS_CheckingIfRemovabelDriveInUse.Visible = False
            IMSS_USBScanCotrolsUint._IMSS_DVICES_FOUND_PANEL.Size = New Size(640, 0)
            IMSS_USBScanCotrolsUint.Panel3.Size = New Size(640, 373)
            IMSS_USBScanCotrolsUint.Panel3.Visible = True
        End If
        Me.ResumeLayout()
    End Sub

    Private Sub _IMSS_ReSetPanelControls(ByVal _IMSS_Panel_1 As Boolean, ByVal _IMSS_Panel_2 As Boolean, ByVal _IMSS_Panel3 As Boolean _
                                                , ByVal _IMSS_Panel4 As Boolean, ByVal _IMSS_Panel5 As Boolean)
        _IMSS_DriveEncryption.Visible = _IMSS_Panel_1
        IMSS_USBScanCotrolsUint.Visible = _IMSS_Panel_2
        IMSS_MonitorsCotrolsUint.Visible = _IMSS_Panel3
        IMSS_DeviceImmunizer.Visible = _IMSS_Panel4
        IMSS_LOGCotrolsUint.Visible = _IMSS_Panel5
        _IMSS_ControlsUserDisply.Visible = True
    End Sub

    Private ixix As Integer = 0

    Private _IMSS_ButtonSlidesCheckIfSlides As Boolean = True
    Private Sub _IMSS_ButtonInClick()
        On Error Resume Next
        If _IMSS_ButtonSlidesCheckIfSlides = True Then
            _IMSS_ButtonSlidesCheckIfSlides = False
            Panel9.Visible = True
            _IMSS_ButtonGenarl_On_Click()
        Else
            FlowLayoutPanel1.Visible = True
            ButtonNiNECliCk(640) ' 640
            _IMSS_SlideIn.Enabled = True
            _IMSS_ButtonSlidesCheckIfSlides = True
        End If
    End Sub
    Private Sub ButtonNiNECliCk(ByVal _Wedit As Integer)
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.White, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, _
                             Color.AliceBlue, Color.AliceBlue, _IMSS_PROTECTION_STATUS_BUTTON)
        Panel9.Height = 376
        Panel9.Width = _Wedit
        Panel9.Location = New Point(3, 3)
        Panel9.Refresh()
        Panel9.Visible = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DP_BUTTON.Click
        On Error Resume Next
        Me.SuspendLayout()
        _IMSS_CheckSelectedUint = 1
        _IMSS_ReSetPanelControls(True, False, False, False, False)
        _IMSS_ButtonSlidesCheckIfSlides = False
        FlowLayoutPanel1.Visible = False
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.White, Color.AliceBlue, Color.AliceBlue, _
                     Color.AliceBlue, Color.AliceBlue, _IMSS_DP_BUTTON)
        Panel9.Visible = False
        _Genral_Protection.Visible = False
        _IMSS_DriveEncryption._IMSS_DvicesFound_Panel.Controls.Clear()
        Dim _IMSS_CheckingVar As Boolean = False
        Dim X As Integer = 10
        Dim Y As Integer = 4
        For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            If d.DriveType = IO.DriveType.Removable And Not d.DriveType = DriveType.CDRom And d.IsReady = True Then
                _IMSS_CheckingVar = True
                If IO.Directory.Exists(Path.Combine(d.Name, "PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")) Then
                    _IMSS_DriveEncryption._IMSS_DvicesFound_Panel.Controls.Add(_IMSS_CREATE_CONTROLS(d.Name, X, Y, True))
                Else
                    _IMSS_DriveEncryption._IMSS_DvicesFound_Panel.Controls.Add(_IMSS_CREATE_CONTROLS(d.Name, X, Y, False))
                End If
                X += 160 : If X > 640 Then : X = 10 : Y += 134 : End If
            End If
        Next
        If _IMSS_CheckingVar = True Then _IMSS_DriveEncryption._IMSS_ENCR_CheckingIfRemovabelDriveInUse.Visible = False _
                     : _IMSS_DriveEncryption._IMSS_ENCR_CheckingIfRemovabelDriveInUse.Dock = DockStyle.None Else _
                     _IMSS_DriveEncryption._IMSS_ENCR_CheckingIfRemovabelDriveInUse.Visible = True _
                     : _IMSS_DriveEncryption._IMSS_ENCR_CheckingIfRemovabelDriveInUse.Dock = DockStyle.Fill : _IMSS_DriveEncryption._IMSS_ENCR_CheckingIfRemovabelDriveInUse.BringToFront()
        Me.ResumeLayout()
    End Sub
    Private Function _IMSS_CREATE_CONTROLS(ByVal _IMSS_DRIVE_NAME As String, ByRef _IMSS_X As Integer, ByRef _IMSS_Y As Integer, ByVal _IMSS_TARGET_SECURE As Boolean) As IMSS_USB_DVICE
        Dim _IMSS_WINDOW_CONTROLLER As New IMSS_USB_DVICE With {
                ._IMSS_TARGET_DRIVE_TEXT = _IMSS_DRIVE_NAME,
                .Location = New Point(_IMSS_X, _IMSS_Y),
                ._IMSS_TARGET_DRIVE_STATUS = _IMSS_TARGET_SECURE,
                .Visible = True}
        Return _IMSS_WINDOW_CONTROLLER
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DS_BUTTON.Click
        On Error Resume Next
        Butt3_Start()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DRIVEMONITORS_BUTTON.Click, Button4.Click
        On Error Resume Next
        'My.Computer.Audio.Play(My.Resources.IMSS_Click, AudioPlayMode.Background)
        Me.SuspendLayout()
        FlowLayoutPanel1.Visible = False
        _Driver_Monitor()
        Me.ResumeLayout()
    End Sub
    Private Sub _Driver_Monitor()
        On Error Resume Next
        _IMSS_ReSetPanelControls(False, False, True, False, False)
        _IMSS_ButtonSlidesCheckIfSlides = False
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.White, _
     Color.AliceBlue, Color.AliceBlue, _IMSS_DRIVEMONITORS_BUTTON)
        Panel9.Visible = False
        _Genral_Protection.Visible = False
        IMSS_MonitorsCotrolsUint.LockUSB_Panel.Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DI_BUTTON.Click
        On Error Resume Next
        Me.SuspendLayout()
        _IMSS_CheckSelectedUint = 2
        IMSS_DeviceImmunizer._IMSS_DvicesFound_Panel.Controls.Clear()
        _IMSS_ButtonSlidesCheckIfSlides = False
        FlowLayoutPanel1.Visible = False
        _IMSS_ReSetPanelControls(False, False, False, True, False)
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, _
Color.White, Color.AliceBlue, _IMSS_DI_BUTTON)
        Panel9.Visible = False
        _Genral_Protection.Visible = False
        Dim _IMSS_CheckingVar As Boolean = False
        Dim X As Integer = 10
        Dim Y As Integer = 4
        For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            If d.DriveType = IO.DriveType.Removable And Not d.DriveType = DriveType.CDRom And d.IsReady = True Then
                _IMSS_CheckingVar = True
                If IO.Directory.Exists(Path.Combine(d.Name, "Autorun.inf")) Then
                    IMSS_DeviceImmunizer._IMSS_DvicesFound_Panel.Controls.Add(_IMSS_CREATE_CONTROLS(d.Name, X, Y, True))
                Else
                    IMSS_DeviceImmunizer._IMSS_DvicesFound_Panel.Controls.Add(_IMSS_CREATE_CONTROLS(d.Name, X, Y, False))
                End If
                X += 160 : If X > 640 Then : X = 10 : Y += 134 : End If
            End If
        Next d
        If _IMSS_CheckingVar = True Then IMSS_DeviceImmunizer._IMSS_CheckingIfRemovabelDriveInUse.Visible = False _
                   : IMSS_DeviceImmunizer._IMSS_CheckingIfRemovabelDriveInUse.Dock = DockStyle.None Else _
             IMSS_DeviceImmunizer._IMSS_CheckingIfRemovabelDriveInUse.Visible = True _
                   : IMSS_DeviceImmunizer._IMSS_CheckingIfRemovabelDriveInUse.Dock = DockStyle.Fill : IMSS_DeviceImmunizer._IMSS_CheckingIfRemovabelDriveInUse.BringToFront()
        Me.ResumeLayout()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_LOG_SECTION_BUTTON.Click
        On Error Resume Next
        Me.SuspendLayout()
        PictureBox29.Enabled = True : PictureBox29.Visible = True
        _IMSS_ButtonSlidesCheckIfSlides = False
        FlowLayoutPanel1.Visible = False
        _ReadLogFilesData()
        Log_Click()
        PictureBox29.Enabled = False : PictureBox29.Visible = False
        Me.ResumeLayout()
    End Sub

    Public Sub Log_Click()
        FlowLayoutPanel1.Visible = False
        _IMSS_ReSetPanelControls(False, False, False, False, True)
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, _
Color.AliceBlue, Color.White, _IMSS_LOG_SECTION_BUTTON)
        Panel9.Visible = False
        _Genral_Protection.Visible = False
        IMSS_LOGCotrolsUint.LOG_Panel.Refresh()
    End Sub

    Public Sub _ReadLogFilesData()
        On Error Resume Next
        IMSS_LOGCotrolsUint._SecurityLog.Clear()
        IMSS_LOGCotrolsUint._SystemLog.Clear()
        IMSS_LOGCotrolsUint._USBLog.Clear()
        Dim _IMSS_LOAD As New IMSS_LOGS_OPER
        With _IMSS_LOAD
            If ._IMSS_Connect = 1 Then
                If ._IMSS_LOAD_TARGET_LIST(0, IMSS_LOGCotrolsUint._SecurityLog) = 1 Then
                End If ' IMSS Else Catch Error
                If ._IMSS_LOAD_TARGET_LIST(1, IMSS_LOGCotrolsUint._SystemLog) = 1 Then
                End If ' IMSS Else Catch Error
                If ._IMSS_LOAD_TARGET_LIST(2, IMSS_LOGCotrolsUint._USBLog) = 1 Then
                End If ' IMSS Else Catch Error
            End If
            If ._IMSS_Disconnect() = 1 Then .Dispose() Else ._IMSS_FORCE_COLSE() : .Dispose()
        End With
    End Sub

    Private _IMSS_CheckingForMinimizedStatus As Boolean = True
    Private _IMSS_FlowPanel1 As Boolean = True
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        '  My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_CheckingForMinimizedStatus = False
        If FlowLayoutPanel1.Visible = True Then
            FlowLayoutPanel1.Visible = False
            _IMSS_FlowPanel1 = False
        End If
        fade_out()
        Me.WindowState = FormWindowState.Minimized
        Me.Opacity = 100
        If _IMSS_FlowPanel1 = False Then
            FlowLayoutPanel1.Visible = True
            _IMSS_FlowPanel1 = False
        End If
        Me.ShowInTaskbar = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        Dim _IMSS_INVOKE_SILDE As New MethodInvoker(Sub()
                                                        Me.Location = New Point(Me.Location.X, Me.Location.Y + 80)
                                                        Application.DoEvents()
                                                    End Sub)

        Dim _IMSS_THREAD As New Threading.Thread(Sub()
                                                     For i As Integer = 0 To 16 Step 1
                                                         System.Threading.Thread.Sleep(4)
                                                         Me.Invoke(_IMSS_INVOKE_SILDE)
                                                     Next i
                                                     Me.Invoke(New MethodInvoker(Sub()
                                                                                     Me.ShowInTaskbar = False
                                                                                     Dim fs As FileSystemSecurity = File.GetAccessControl(_IMSS_Q + "\IMSSQ")
                                                                                     fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
                                                                                     File.SetAccessControl(_IMSS_Q + "\IMSSQ", fs)
                                                                                     Button12.BackColor = Color.WhiteSmoke
                                                                                     Button12.Refresh()
                                                                                     If _IMSS_Main_Window_Slide_Status = False Then
                                                                                         _IMSS_SETTINGCLICK()
                                                                                         IMSS_MainPanel_Settings_Sliding = False
                                                                                     End If
                                                                                     If IMSS_USBScanCotrolsUint._IMSS_SCANER.IsBusy = True Then
                                                                                         _IMSS_Main_NotifyIcon.BalloonTipText = "Scanner is running in background"
                                                                                         _IMSS_Main_NotifyIcon.ShowBalloonTip(600)
                                                                                     End If
                                                                                     Panel9.Height = 374
                                                                                     Panel9.Width = 0
                                                                                     Panel9.Location = New Point(184, 11)
                                                                                     Panel9.Refresh()
                                                                                     _IMSS_SlideChecking = False
                                                                                     Me.Hide()
                                                                                     EmptyWorkingSet(Process.GetCurrentProcess.Handle)
                                                                                     Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
                                                                                     Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
                                                                                     Me.Refresh()
                                                                                 End Sub))
                                                 End Sub) : _IMSS_THREAD.Start()

    End Sub



    Private Sub Button20_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_USB_PROTECTION_BUTTON.MouseEnter
        _IMSS_USB_PROTECTION_BUTTON.FlatAppearance.BorderSize = 1
        PictureBox13.BackColor = _IMSS_USB_PROTECTION_BUTTON.FlatAppearance.MouseOverBackColor
        _IMSS_USB_PROTECTION_BUTTON.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Button20_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_USB_PROTECTION_BUTTON.MouseLeave
        PictureBox13.BackColor = _IMSS_USB_PROTECTION_BUTTON.BackColor
        _IMSS_USB_PROTECTION_BUTTON.FlatAppearance.BorderSize = 0
        If _IMSS_USB_PROTECTION_BUTTON.BackColor = Color.AliceBlue Then
            _IMSS_USB_PROTECTION_BUTTON.ForeColor = Color.RoyalBlue
        Else
            _IMSS_USB_PROTECTION_BUTTON.ForeColor = Color.White
        End If
    End Sub
    Private Sub _IMSS_SetMainMenuButtonBackColor(ByVal _IMSS_Button21_Color As Color, _
                                              ByVal _IMSS_Button21_ForeColor__Color As Color, _
                                              ByVal _IMSS_Button20_Color As Color, _
                                              ByVal _IMSS_Button20_ForeColor__Color As Color, _
                                              ByVal _IMSS_Button41_Color As Color, _
                                              ByVal _IMSS_Button41_ForeColor__Color As Color, _
                                              ByVal _IMSS_PictureBox17_Color As Color, _
                                              ByVal _IMSS_PictureBox13_Color As Color, _
                                              ByVal _IMSS_PictureBox14_Color As Color, _
                                              ByVal _IMSS_PictureBox10_Color As Color, _
                                              ByVal _IMSS_Button7_Color As Color, _
                                              ByVal _IMSS_Button7_ForeColor__Color As Color)
        Button21.BackColor = _IMSS_Button21_Color
        Button21.ForeColor = _IMSS_Button21_ForeColor__Color
        _IMSS_USB_PROTECTION_BUTTON.BackColor = _IMSS_Button20_Color
        _IMSS_USB_PROTECTION_BUTTON.ForeColor = _IMSS_Button20_ForeColor__Color
        Button41.BackColor = _IMSS_Button41_Color
        Button41.ForeColor = _IMSS_Button41_ForeColor__Color
        PictureBox17.BackColor = _IMSS_PictureBox17_Color
        PictureBox13.BackColor = _IMSS_PictureBox13_Color
        PictureBox14.BackColor = _IMSS_PictureBox14_Color
        Button7.BackColor = _IMSS_Button7_Color
        PictureBox10.BackColor = _IMSS_PictureBox10_Color
        Button7.ForeColor = _IMSS_Button7_ForeColor__Color
    End Sub
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_USB_PROTECTION_BUTTON.Click
        On Error Resume Next
        _IMSS_Main_Button_Starts(True)
    End Sub
    Private Sub _IMSS_Main_Button_Starts(ByVal _IMSS_CLICK_TYPE As Boolean)
        On Error Resume Next
        If (_IMSS_CLICK_TYPE = True) Then
            ' My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        End If
        _IMSS_ControlsUserDisply.Visible = False
        Panel40.Visible = True
        _IMSS_OverView_Button.Visible = False
        _IMSS_OneClickView_Button.Visible = False
        _IMSS_SetMainMenuButtonBackColor(Color.RoyalBlue, Color.White, Color.AliceBlue, Color.RoyalBlue, _
        Color.RoyalBlue, Color.White, Color.RoyalBlue, Color.AliceBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.White)
        Panel7.Location = New Point(-1, 66)
        Panel7.Height = 390
        Panel7.Width = 829
        _IMSS_Update_Holder.Refresh()
        _IMSS_Update_Holder.Visible = False
        _IMSS_Q_Holder.Visible = False
        _IMSS_Utitilies_Uint.Visible = False
        ButtonNiNECliCk(640)
        Panel9.Refresh()
        Panel7.Visible = True
        FlowLayoutPanel1.Enabled = True
        FlowLayoutPanel1.Visible = True
        _IMSS_SlideIn.Enabled = True
        _IMSS_RemoveUpdateCommands()
    End Sub

    Private Sub _IMSS_ScanUSB_BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        On Error Resume Next
        For i = 0 To IMSS_USBScanCotrolsUint.lstFile.Items.Count - 1
            If Not IMSS_USBScanCotrolsUint.lstFile.Items(i).Checked = True Then
                IMSS_USBScanCotrolsUint.lstFile.Items(i).Checked = True
            End If
        Next
        If IMSS_USBScanCotrolsUint.lstFile.Items.Count > 0 Then
            IMSS_USBScanCotrolsUint.Label34.ForeColor = Color.Red
            Dim xlColor As System.Drawing.Color
            xlColor = System.Drawing.Color.Red
            IMSS_USBScanCotrolsUint.lstFile.ForeColor = xlColor
            IMSS_USBScanCotrolsUint.Label34.Text = "Found " + IMSS_USBScanCotrolsUint.lstFile.Items.Count.ToString()
            IMSS_USBScanCotrolsUint.Button49.Enabled = True
            IMSS_USBScanCotrolsUint.Button8.Enabled = True
            IMSS_USBScanCotrolsUint.Button9.Enabled = True
            MessageBox.Show("Scan Results : " + IMSS_USBScanCotrolsUint.lstFile.Items.Count.ToString + " threat were detected ", "IMSS Scan Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            IMSS_USBScanCotrolsUint.Label34.ForeColor = Color.Green
            IMSS_USBScanCotrolsUint.Label34.Text = "None"
            _IMSS_FlowPanel1 = False

            IMSS_USBScanCotrolsUint.Label64.Text = ""
            IMSS_USBScanCotrolsUint.ProgressBar1.Value = 0
            IMSS_USBScanCotrolsUint.lstFile.Height = 200
            IMSS_USBScanCotrolsUint.Button8.Enabled = True
            MessageBox.Show("Scan Results : No threats were detected ", "IMSS Scan Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        IMSS_USBScanCotrolsUint.Label64.Text = "Done ...100%"
    End Sub
    Public _IMSS_CieckIfScanningRunning As Boolean = False
    Private Sub _IMSS_Delete_BackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_Delete_BackgroundWorker.DoWork
        ixix = 0
        For i As Integer = 0 To IMSS_USBScanCotrolsUint.lstFile.Items.Count - 1
            If IMSS_USBScanCotrolsUint.lstFile.Items(i).Checked = True Then
                If IO.File.Exists(IMSS_USBScanCotrolsUint.lstFile.Items(i).Text) Then IO.File.Delete(IMSS_USBScanCotrolsUint.lstFile.Items(i).Text)
                IMSS_USBScanCotrolsUint.lstFile.Items(i).ForeColor = Color.Green
                IMSS_USBScanCotrolsUint.lstFile.Items(i).ImageIndex = 1
                ixix = ixix + 1
            Else
                IMSS_USBScanCotrolsUint.lstFile.Items(i).ImageIndex = 0
                IMSS_USBScanCotrolsUint.lstFile.Items(i).ForeColor = Color.Red
            End If
            _IMSS_Delete_BackgroundWorker.ReportProgress(+1)
        Next
    End Sub

    Private Sub _IMSS_Delete_BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles _IMSS_Delete_BackgroundWorker.ProgressChanged
        IMSS_USBScanCotrolsUint.ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub _IMSS_Delete_BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSS_Delete_BackgroundWorker.RunWorkerCompleted
        On Error Resume Next
        IMSS_USBScanCotrolsUint.Label34.ForeColor = Color.Green
        IMSS_USBScanCotrolsUint.Label34.Text = ixix & " Deleted"
        IMSS_USBScanCotrolsUint._IMSS_THREAT_FOUNDS_Label.Text = IMSS_USBScanCotrolsUint.lstFile.Items.Count.ToString() & " Threat's was found"
        IMSS_USBScanCotrolsUint._IMSS_THREAT_STATS_Label.Text = ixix & " Threat's was deleted successfully"
        IMSS_USBScanCotrolsUint.lstFile.Refresh()
        Dim lColor As System.Drawing.Color
        lColor = System.Drawing.Color.Green
        IMSS_USBScanCotrolsUint.lstFile.ForeColor = lColor
        IMSS_USBScanCotrolsUint.lstFile.CheckBoxes = False
        _IMSS_Delete_BackgroundWorker.CancelAsync()
        IMSS_USBScanCotrolsUint.ProgressBar1.Value = 0
        IMSS_USBScanCotrolsUint.lstFile.Height = 200
        IMSS_USBScanCotrolsUint._IMSS_SLIDEOUT_LIST.Enabled = True
    End Sub
    Private _IMSS_CheckIfWebSystemsrunning As Boolean = False
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        _IMSS_UpdateButtonClick()
    End Sub
    Public Sub _IMSS_UpdateButtonClick()
        On Error Resume Next

        _IMSS_SetMainMenuButtonBackColor(Color.AliceBlue, Color.RoyalBlue, Color.RoyalBlue, Color.White, _
                                 Color.RoyalBlue, Color.White, Color.RoyalBlue, Color.RoyalBlue, Color.AliceBlue, Color.RoyalBlue, Color.RoyalBlue, Color.White)
        _IMSS_OverView_Button.Visible = False
        _IMSS_OneClickView_Button.Visible = False
        Panel7.Visible = False
        _IMSS_Q_Holder.Visible = False
        _IMSS_Utitilies_Uint.Visible = False
        _IMSS_UpdateButton.Enabled = True
        _IMSS_Update_Holder.Location = New Point(2, 65)
        _IMSS_Update_Holder.Size = New Size(828, 394)
        _IMSS_Update_Holder.Visible = True
        _IMSS_Update_Holder.BringToFront()
        Me._IMSS_Update_Holder.Controls.Add(IMSS_Update._IMSS_CREATE_CONTROL())
        _IMSS_ButtonGenarl_On_Click()
        '    My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        FlowLayoutPanel1.Visible = False
        _ReadLogFilesData()
        Log_Click()
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        If My.Settings.USBShelid = False Then
            PictureBox4.BackgroundImage.Dispose()
            PictureBox4.BackgroundImage = My.Resources._IMSS_Pr_Off
        Else
            PictureBox4.BackgroundImage.Dispose()
            PictureBox4.BackgroundImage = My.Resources._13592621542332
        End If
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        If My.Settings.USBShelid = False Then
            PictureBox4.BackgroundImage.Dispose()
            PictureBox4.BackgroundImage = My.Resources._IMSS_Pr_Off
        Else
            PictureBox4.BackgroundImage.Dispose()
            PictureBox4.BackgroundImage = My.Resources._1
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If Not My.Settings.USBShelid = False Then
            PictureBox4.BackgroundImage.Dispose()
            PictureBox4.BackgroundImage = My.Resources._1
        Else
            PictureBox4.BackgroundImage = My.Resources._IMSS_Pr_Off
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Butt3_Start()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Button7.PerformClick()
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        _IMSS_SystemsExitMasseages("Are you sure you want to stop all IMSS Systems ?")
    End Sub
    Private Sub _IMSS_SystemsExitMasseages(ByVal _IMSS_Massesage As String)
        On Error Resume Next
        If MessageBox.Show(_IMSS_Massesage, "IMSS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            _IMSS_Dispos()
        Else
            System.Threading.Thread.Sleep(400)
        End If
    End Sub
    Private Sub _IMSS_Dispos()
        On Error Resume Next
        _IMSS_Delete_BackgroundWorker.Dispose()
        _IMSS_SYSTEM_UINT._IMSS_ALLOW_SURV = False
        _IMSS_Main_NotifyIcon.Dispose()
        Application.Exit()
    End Sub
    Private Sub AutoToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoToolStripMenuItem1.Click
        Try
            Dim FontBold = New Font(AutoToolStripMenuItem1.Font, FontStyle.Bold)
            Dim FontNormal = New Font(AutoToolStripMenuItem1.Font, FontStyle.Regular)
            AutoToolStripMenuItem1.Text = "Automatic"
            ManualToolStripMenuItem1.Text = "Manual"
            IMSS_MonitorsCotrolsUint.Label35.Text = "Automatic"
            ManualToolStripMenuItem1.Font = FontNormal
            AutoToolStripMenuItem1.Font = FontBold
            My.Settings.Mode = True
            My.Settings.Save()
            ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> Automatic mode is activated", 4)
            MessageBox.Show("Automatic Mode is Effective !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch : End Try
    End Sub

    Private Sub ManualToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualToolStripMenuItem1.Click
        Try
            Dim FontBold = New Font(AutoToolStripMenuItem1.Font, FontStyle.Bold)
            Dim FontNormal = New Font(AutoToolStripMenuItem1.Font, FontStyle.Regular)
            AutoToolStripMenuItem1.Text = "Automatic"
            ManualToolStripMenuItem1.Text = "Manual"
            IMSS_MonitorsCotrolsUint.Label35.Text = "Manual"
            ManualToolStripMenuItem1.Font = FontBold
            AutoToolStripMenuItem1.Font = FontNormal
            My.Settings.Mode = False
            My.Settings.Save()
            ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> Manual mode is activated ", 4)
            MessageBox.Show("Manual Mode is Effective !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        _IMSS_About.Show()
    End Sub
    Public _IMSS_SlideChecking As Boolean = False
    Private Sub MainWindoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainWindoToolStripMenuItem.Click
        _IMSS_ShowMainWindow()
    End Sub
    Public Sub _IMSS_ShowMainWindow()
        On Error Resume Next
        If _IMSS_CheckIfiSAdmin() = True Then
            _IMSS_RemoveUpdateCommands()
            If _IMSS_SlideChecking = True Then
                Me.Activate()
            Else
                _IMSS_ControlsUserDisply.Visible = False
                _IMSS_SlideChecking = True
                FlowLayoutPanel1.Visible = True
                Me.Refresh()
                _IMSS_LOAD()
            End If
        Else
            If IO.File.Exists(_IMSS_Startup_Type) Then IO.File.Delete(_IMSS_Startup_Type)
            _IMSS_Delete_BackgroundWorker.Dispose()
            _IMSS_SYSTEM_UINT._IMSS_ALLOW_SURV = False
            _IMSS_Main_NotifyIcon.Dispose()
            _IMSS_About.Close()
            System.Threading.Thread.Sleep(400)
            _IMSS_RESTART("_RESTARTAS")
        End If

    End Sub

    Private Function _IMSS_CheckIfiSAdmin() As Boolean
        Dim identity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim principal As New WindowsPrincipal(identity)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function

    Public Sub fade_in()
        Me.Show()
        For FadeIn = 0.0 To 1.1 Step 30 / 100
            Me.Opacity = FadeIn
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
        Me.Opacity = 100%
        If (Me.Enabled = False) Then Me.Enabled = True
    End Sub
    Private Sub fade_out()
        For FadeOut = 90 To 10 Step -4
            Me.Opacity = FadeOut / 100
        Next FadeOut
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        On Error Resume Next
        If ExitToolStripMenuItem.Checked = True Then
            ExitToolStripMenuItem.CheckState = CheckState.Unchecked
            _IMSS_ReSetProtection(False)
            _IMSS_ReloadSettins()
        Else
            ExitToolStripMenuItem.CheckState = CheckState.Checked
            _IMSS_ReSetProtection(True)
            _IMSS_ReloadSettins()
        End If
    End Sub

#Region " IMSS Reload Setting Functions"

    Private Sub _IMSS_ReSetProtection(ByVal _IMSS_STATUS As Boolean)
        My.Settings.SysMontior = _IMSS_STATUS
        My.Settings.USBShelid = _IMSS_STATUS
        My.Settings.USBMonitor = _IMSS_STATUS
        My.Settings.SystemSounds = _IMSS_STATUS
        My.Settings.SysSheild = _IMSS_STATUS
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub _IMSS_ReloadSettins()
        Try
            If My.Settings.SysSheild = False Then
                PictureBox3.Visible = False
                PictureBox20.Visible = False
                PictureBox22.Visible = False
                PictureBox23.Visible = False
                PictureBox24.Visible = False
                Label45.Text = "Disable"
                Label18.Text = "OFF"
                Label45.ForeColor = Color.Red
                Label18.ForeColor = Color.Red
            Else
                Label45.Text = "Enabled"
                Label18.Text = "ON"
                Label45.ForeColor = Color.Green
                Label18.ForeColor = Color.Green
                PictureBox3.Visible = True
                PictureBox20.Visible = True
                PictureBox22.Visible = True
                PictureBox23.Visible = True
                PictureBox24.Visible = True
            End If
            If My.Settings.SysMontior = False Then
                IMSS_MonitorsCotrolsUint.PictureBox28.Visible = False
                IMSS_MonitorsCotrolsUint.PictureBox33.Visible = False
                IMSS_MonitorsCotrolsUint.PictureBox31.Visible = False
                IMSS_MonitorsCotrolsUint.Label61.Text = "Disable"
                Label24.Text = "OFF"
                Label46.Text = "Disable"
                Label19.Text = "OFF"
                IMSS_MonitorsCotrolsUint.Label61.ForeColor = Color.Red
                Label24.ForeColor = Color.Red
                Label46.ForeColor = Color.Red
                Label19.ForeColor = Color.Red
            Else
                IMSS_MonitorsCotrolsUint.PictureBox28.Visible = True
                IMSS_MonitorsCotrolsUint.PictureBox33.Visible = True
                IMSS_MonitorsCotrolsUint.PictureBox31.Visible = True
                IMSS_MonitorsCotrolsUint.Label61.Text = "Enabled"
                Label46.Text = "Enabled"
                Label19.Text = "ON"
                Label24.Text = "Good"
                'End If
                IMSS_MonitorsCotrolsUint.Label61.ForeColor = Color.Green
                Label46.ForeColor = Color.Green
                Label19.ForeColor = Color.Green
                Label24.ForeColor = Color.Blue
            End If
            If My.Settings.USBShelid = False Then
                IMSS_MonitorsCotrolsUint.Label65.Text = "Stoped"
                IMSS_MonitorsCotrolsUint.Label67.Text = "Stoped"
                Label12.Text = "Protection Is Disable"
                Label17.Text = "Protection Is Disable"
                Label48.Text = "Disable"
                Label21.Text = "OFF"
                'End If

                IMSS_MonitorsCotrolsUint.Label65.ForeColor = Color.Red
                IMSS_MonitorsCotrolsUint.Label67.ForeColor = Color.Red
                Label12.ForeColor = Color.Red
                Label48.ForeColor = Color.Red
                If Not My.Settings.USBShelid = False Then
                    PictureBox4.BackgroundImage.Dispose()
                    PictureBox4.BackgroundImage = My.Resources._1
                Else
                    PictureBox4.BackgroundImage = My.Resources._IMSS_Pr_Off
                End If
                Label21.ForeColor = Color.Red
            Else
                IMSS_MonitorsCotrolsUint.Label67.Text = "Waiting"
                IMSS_MonitorsCotrolsUint.Label65.Text = "system"
                Label48.Text = "Enabled"
                Label17.Text = "Your Computer is protected from any viruses or worms or shortcuts infection or autoruns" + vbNewLine & _
                " files - all systems running "
                Label21.Text = "ON"
                Label12.Text = "Removable media protection is available"
                'End If
                IMSS_MonitorsCotrolsUint.Label67.ForeColor = Color.Green
                IMSS_MonitorsCotrolsUint.Label65.ForeColor = Color.Green
                Label48.ForeColor = Color.Green
                If Not My.Settings.USBShelid = False Then
                    PictureBox4.BackgroundImage.Dispose()
                    PictureBox4.BackgroundImage = My.Resources._1
                Else
                    PictureBox4.BackgroundImage = My.Resources._IMSS_Pr_Off
                End If
                Label21.ForeColor = Color.Green
                Label12.ForeColor = Color.Green
            End If
            If My.Settings.USBMonitor = False Then
                IMSS_MonitorsCotrolsUint.Label71.Text = "Disable"
                Label47.Text = "Disable"
                Label22.Text = "OFF"
                IMSS_MonitorsCotrolsUint.Label71.ForeColor = Color.Red
                Label47.ForeColor = Color.Red
                Label22.ForeColor = Color.Red
            Else
                IMSS_MonitorsCotrolsUint.Label71.Text = "Enabled"
                Label47.Text = "Enabled"
                Label22.Text = "ON"
                IMSS_MonitorsCotrolsUint.Label71.ForeColor = Color.Green
                Label47.ForeColor = Color.Green
                Label22.ForeColor = Color.Green
            End If
        Catch : End Try
    End Sub

#End Region

    Private Sub Button27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_G_PROTECTION_BUTTON.Click
        On Error Resume Next
        _IMSS_ControlsUserDisply.Visible = False
        _IMSS_ButtonSlidesCheckIfSlides = False
        Panel9.Visible = True
        _IMSS_ButtonGenarl_On_Click()

    End Sub

    Private Sub _IMSS_SetMenuButtonBackColor(ByVal _IMSS_Button27_Color As Color, _
                                                  ByVal _IMSS_Button1_Color As Color, _
                                                  ByVal _IMSS_Button2_Color As Color, _
                                                  ByVal _IMSS_Button3_Color As Color, _
                                                  ByVal _IMSS_Button4_Color As Color, _
                                                  ByVal _IMSS_Button5_Color As Color, _
                                                  ByVal _IMSS_Button6_Color As Color, _
                                                  ByRef _IMSS_TARGET_BUTTON As Button)
        _IMSS_G_PROTECTION_BUTTON.BackColor = _IMSS_Button27_Color
        _IMSS_PROTECTION_STATUS_BUTTON.BackColor = _IMSS_Button1_Color
        _IMSS_DP_BUTTON.BackColor = _IMSS_Button2_Color
        _IMSS_DS_BUTTON.BackColor = _IMSS_Button3_Color
        _IMSS_DRIVEMONITORS_BUTTON.BackColor = _IMSS_Button4_Color
        _IMSS_DI_BUTTON.BackColor = _IMSS_Button5_Color
        _IMSS_LOG_SECTION_BUTTON.BackColor = _IMSS_Button6_Color

        Dim _IMSS_Font As New Font("MS Reference Sans Serif", 9.75, FontStyle.Regular)

        _IMSS_G_PROTECTION_BUTTON.Font = _IMSS_Font
        _IMSS_G_PROTECTION_BUTTON.FlatAppearance.BorderSize = 0
        _IMSS_PROTECTION_STATUS_BUTTON.Font = _IMSS_Font
        _IMSS_PROTECTION_STATUS_BUTTON.FlatAppearance.BorderSize = 0
        _IMSS_DP_BUTTON.Font = _IMSS_Font
        _IMSS_DP_BUTTON.FlatAppearance.BorderSize = 0
        _IMSS_DS_BUTTON.Font = _IMSS_Font
        _IMSS_DS_BUTTON.FlatAppearance.BorderSize = 0
        _IMSS_DRIVEMONITORS_BUTTON.Font = _IMSS_Font
        _IMSS_DRIVEMONITORS_BUTTON.FlatAppearance.BorderSize = 0
        _IMSS_DI_BUTTON.Font = _IMSS_Font
        _IMSS_DI_BUTTON.FlatAppearance.BorderSize = 0
        _IMSS_LOG_SECTION_BUTTON.Font = _IMSS_Font
        _IMSS_LOG_SECTION_BUTTON.FlatAppearance.BorderSize = 0

        _IMSS_TARGET_BUTTON.Font = New Font("MS Reference Sans Serif", 8.0, FontStyle.Bold)

        _IMSS_TARGET_BUTTON.FlatAppearance.BorderSize = 1
        _IMSS_TARGET_BUTTON.FlatAppearance.BorderColor = Color.LightGray
        _IMSS_USB_PROTECTION_BUTTON.Focus()

    End Sub
    Private Sub _IMSS_ButtonGenarl_On_Click()
        Try
            FlowLayoutPanel1.Location = New Point(181, 5)
            _IMSS_SetMenuButtonBackColor(Color.White, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, _
                                         Color.AliceBlue, Color.AliceBlue, _IMSS_G_PROTECTION_BUTTON)
            _Genral_Protection.Width = 640
            _Genral_Protection.Visible = True
            If My.Settings.SysSheild = False Then Label45.Text = "Disable" Else Label45.Text = "Enabled"
            If My.Settings.SysMontior = False Then Label46.Text = "Disable" Else Label46.Text = "Enabled"
            If My.Settings.USBShelid = False Then Label48.Text = "Disable" Else Label48.Text = "Enabled"
            If My.Settings.USBMonitor = False Then Label47.Text = "Disable" Else Label47.Text = "Enabled"
            FlowLayoutPanel1.Visible = True
            _IMSS_SlideOut.Enabled = True
            Button28.Visible = False
            Button29.Visible = False
            Button34.Visible = False
            Button35.Visible = False
        Catch : End Try
    End Sub

    Private Sub Label49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label49.Click
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
        Log_Click()
    End Sub

    Private Sub Label51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
        Log_Click()
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Width = 80
        PictureBox1.Height = 70
    End Sub
    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Width = 75
        PictureBox1.Height = 65
    End Sub

    Private Sub PictureBox12_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.MouseEnter
        PictureBox12.Width = 80
        PictureBox12.Height = 70
    End Sub

    Private Sub PictureBox12_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.MouseLeave
        PictureBox12.Width = 75
        PictureBox12.Height = 65
    End Sub

    Private Sub PictureBox18_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.MouseEnter
        PictureBox18.Width = 80
        PictureBox18.Height = 54
    End Sub

    Private Sub PictureBox18_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.MouseLeave
        PictureBox18.Width = 75
        PictureBox18.Height = 49
    End Sub

    Private Sub PictureBox19_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.MouseEnter
        PictureBox19.Width = 80
        PictureBox19.Height = 47
    End Sub

    Private Sub PictureBox19_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.MouseLeave
        PictureBox19.Width = 75
        PictureBox19.Height = 42
    End Sub

    Private Sub Label18_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.MouseEnter
        Label18.ForeColor = Color.Red
    End Sub

    Private Sub Label18_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.MouseLeave
        If My.Settings.USBMonitor = False Then
            Label18.ForeColor = Color.Red
        Else
            Label18.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Label22_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.MouseEnter
        Label22.ForeColor = Color.Red
    End Sub

    Private Sub Label22_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.MouseLeave
        If My.Settings.USBMonitor = False Then
            Label22.ForeColor = Color.Red
        Else
            Label22.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Label21_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.MouseEnter
        Label21.ForeColor = Color.Red
    End Sub

    Private Sub Label21_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.MouseLeave
        If My.Settings.USBMonitor = False Then
            Label21.ForeColor = Color.Red
        Else
            Label21.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Label19_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.MouseEnter
        Label19.ForeColor = Color.Red
    End Sub

    Private Sub Label19_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.MouseLeave
        If My.Settings.USBMonitor = False Then
            Label19.ForeColor = Color.Red
        Else
            Label19.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Button21_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.MouseEnter
        Button21.FlatAppearance.BorderSize = 1
        PictureBox14.BackColor = _IMSS_USB_PROTECTION_BUTTON.FlatAppearance.MouseOverBackColor
        Button21.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Button21_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.MouseLeave
        PictureBox14.BackColor = Button21.BackColor
        Button21.FlatAppearance.BorderSize = 0
        If Button21.BackColor = Color.AliceBlue Then
            Button21.ForeColor = Color.RoyalBlue
        Else
            Button21.ForeColor = Color.White
        End If
    End Sub

#Region "IMSS SET SETTING CONTROLS"
    Private Sub _IMSS_SET_SETTINGS_CONTROLS()
        If ConfigurationResureses.LinkVar._IMSS_OS_Version = False Then
            Label4.Location = New Point(4, 150)
            Label4.Text = "iMyth Labs" & Environment.NewLine & "  2013"
        End If
        _MAIN_SettingPanel_Options(Panel32, New Point(16, 225), New Point(158, 154))
        _IMSS_SET_Mini_Panels_Option(True, False, False)
        IMSS_MainSettings._IMSS_SET_CONTROLS_STATUS_PROPERTY = True
    End Sub
#End Region
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        On Error Resume Next
        ' My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_SETTINGCLICK()
    End Sub
    Private Sub _IMSS_SETTINGCLICK()
        _IMSS_Main_Window_SettingsPanels.BringToFront()
        _IMSS_SET_PANEL_STATUS(True, False, False) ' IMSS Set panels status
        _IMSS_Button22_SetButtonBackColor_For_SettingPanelsHolders() ' IMSS Set main button Status
        _IMSS_SET_SETTINGS_CONTROLS() ' IMSS Set CONTROLS Status
        _IMSS_Main_Window_Settings_Sliding_Timer.Enabled = True
    End Sub
    Private Sub _IMSS_SET_PANEL_STATUS(ByVal _IMSS_PANEL_MAIN As Boolean, ByVal _IMSS_Panel_LANG As Boolean, ByVal _IMSS_PANEL_LOG As Boolean)
        IMSS_MainSettings.Visible = _IMSS_PANEL_MAIN
        IMSS_Language.Visible = _IMSS_Panel_LANG
        IMSS_LOG.Visible = _IMSS_PANEL_LOG
    End Sub


    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Try
            '   My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
            Process.Start(ConfigurationResureses.LinkVar._IMSS_HomePage)
        Catch : End Try
    End Sub

    Private Function _StartOther(ByVal _PluginFile As String)
        Try
            Dim process As System.Diagnostics.Process = Nothing
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            processStartInfo = New System.Diagnostics.ProcessStartInfo()
            processStartInfo.FileName = _PluginFile
            If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                processStartInfo.Verb = "runas"
            Else
                ' No need to prompt to run as admin
            End If
            processStartInfo.Arguments = ""
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            processStartInfo.UseShellExecute = True
            Try
                process = System.Diagnostics.Process.Start(processStartInfo)
                Return True
            Catch ex As Exception
                Return False
                MessageBox.Show(ex.Message, "IMSS Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Not (process Is Nothing) Then
                    process.Dispose()
                End If

            End Try
        Catch
            Return False
        End Try
    End Function

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Try
            '  My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
            Process.Start(ConfigurationResureses.LinkVar._IMSS_HelpPage)
        Catch ex As Exception
            MessageBox.Show("ERROR : " + ex.Message, "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        Try
            If _IMSS_CheckForAdminPrivileges() = True Then
                Dim key As RegistryKey = Registry.LocalMachine
                Dim subkey As RegistryKey
                subkey = key.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
                subkey.SetValue("Start", 3)
                key.Close()
                subkey.Close()
                _OnOff.Text = "UnBlocked"
                _OnOff.ForeColor = Color.Green
                My.Settings.ONOFF = True
                My.Settings.Save()
                MessageBox.Show("USB PORTS is UnBlocked", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                _IMSS_RestartWithAdminPrivileges()
            End If
        Catch : End Try
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Try
            If _IMSS_CheckForAdminPrivileges() = True Then
                Dim key As RegistryKey = Registry.LocalMachine
                Dim subkey As RegistryKey
                subkey = key.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
                subkey.SetValue("Start", 4)
                key.Close()
                subkey.Close()
                _OnOff.Text = "Blocked"
                _OnOff.ForeColor = Color.Red
                My.Settings.ONOFF = False
                My.Settings.Save()
                MessageBox.Show("USB PORTS is Blocked", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                _IMSS_RestartWithAdminPrivileges()
            End If
        Catch : End Try
    End Sub

    Private Sub Button12_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.MouseEnter
        Button12.FlatAppearance.BorderColor = Color.DarkGray
        Button12.ForeColor = Color.White
    End Sub

    Private Sub Button12_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.MouseLeave
        Button12.FlatAppearance.BorderColor = Color.Silver
        Button12.ForeColor = Color.Black
    End Sub

    Private Sub Button13_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.MouseEnter
        Button13.FlatAppearance.BorderColor = Color.DarkGray
        Button13.ForeColor = Color.White
    End Sub

    Private Sub Button13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseLeave
        Button13.FlatAppearance.BorderColor = Color.Silver
        Button13.ForeColor = Color.Black
    End Sub
    Private Sub _IMSS_ChangeImages(ByVal _IMSS_Image As Image)
        PictureBox4.BackgroundImage = _IMSS_Image
        PictureBox4.Refresh()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        'USB Configure
        Try
            If _IMSS_CheckForAdminPrivileges() = True Then
                Dim _IMSS_ConfigUint As New _IMSS_USBC
                _IMSS_ConfigUint.ShowDialog() : Else
                _IMSS_RestartWithAdminPrivileges()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR : " + ex.Message, "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        'USB Format
        Try
            If _IMSS_CheckForAdminPrivileges() = True Then
                Dim _IMSS_ConfigUint As New _IMSS_USBF
                _IMSS_ConfigUint.ShowDialog() : Else
                _IMSS_RestartWithAdminPrivileges()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR : " + ex.Message, "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OpenDriverSaftlyToolStripMenuItem_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDriverSaftlyToolStripMenuItem.MouseEnter
        OpenDriverSaftlyToolStripMenuItem.DropDownItems.Clear()
        For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            If d.DriveType = IO.DriveType.Fixed Or d.DriveType = IO.DriveType.Removable Then
                If Not String.IsNullOrEmpty(d.Name) Then
                    Dim _IMSS_DropDiwnItems As New ToolStripMenuItem(d.Name, _
                                 Nothing, AddressOf _IMSS_START_TARGET_DRIVE)
                    OpenDriverSaftlyToolStripMenuItem.DropDownItems.Add(_IMSS_DropDiwnItems)
                End If
            End If
        Next
    End Sub

    Private Sub _IMSS_START_TARGET_DRIVE(ByVal sender As Object, ByVal e As EventArgs)
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        Try : Process.Start(DirectCast(sender, ToolStripMenuItem).Text) : Catch : End Try
    End Sub

    Private Sub _IMSS_SlideOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SlideOut.Tick
        On Error Resume Next
        _IMSS_SlideIn.Enabled = False
        If _Genral_Protection.Height >= 374 Then
            _Genral_Protection.Height = 376
            _Genral_Protection.Location = New Point(3, -3)
            _IMSS_SlideOut.Enabled = False
        Else
            _Genral_Protection.Height = _Genral_Protection.Height + 30
            If _Genral_Protection.Height = 90 Or _Genral_Protection.Height = 200 Or _Genral_Protection.Height = 300 _
                Or _Genral_Protection.Height = 260 Then
                _Genral_Protection.Refresh()
            End If
        End If
    End Sub

    Private Sub _IMSS_SlideIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SlideIn.Tick
        On Error Resume Next
        _IMSS_SlideOut.Enabled = False
        If _Genral_Protection.Height <= 2 Then
            _Genral_Protection.Height = 0
            FlowLayoutPanel1.Location = New Point(181, -2)
            Panel9.Height = 376
            Panel9.Location = New Point(3, 3)
            Button28.Visible = True
            Button29.Visible = True
            Button34.Visible = True
            Button35.Visible = True
            _IMSS_SlideIn.Enabled = False
        Else
            _Genral_Protection.Height = _Genral_Protection.Height - 40
        End If
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        _IMSS_ButtonSlidesCheckIfSlides = False
        Panel9.Visible = True
        _IMSS_ButtonGenarl_On_Click()
    End Sub

    Private Sub PictureBox15_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.MouseEnter
        PictureBox15.Width = 14
        PictureBox15.Height = 16
    End Sub

    Private Sub PictureBox15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox15.MouseLeave
        PictureBox15.Width = 12
        PictureBox15.Height = 14
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        _IMSS_ButtonSlidesCheckIfSlides = False
        _IMSS_ButtonInClick()
    End Sub

    Private Sub PictureBox16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox16.MouseEnter
        PictureBox16.Width = 14
        PictureBox16.Height = 16
    End Sub

    Private Sub PictureBox16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox16.MouseLeave
        PictureBox16.Width = 12
        PictureBox16.Height = 14
    End Sub



    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        Try
            _StartOther(_IMSS_FixTools)
        Catch : End Try
    End Sub
    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Try
            If IO.File.Exists(_IMSS_Startup_Type) Then IO.File.Delete(_IMSS_Startup_Type)
            _IMSS_Delete_BackgroundWorker.Dispose()
            _IMSS_SYSTEM_UINT._IMSS_ALLOW_SURV = False
            _IMSS_Main_NotifyIcon.Dispose()
            _IMSS_About.Close()
            System.Threading.Thread.Sleep(400)
            _IMSS_RESTART("_RESTART")
        Catch : End Try
    End Sub
    Private Sub _IMSS_RESTART(ByVal _IMSS_RESTART As String)
        Dim startInfo As New ProcessStartInfo With {.FileName = Path.Combine(Application.StartupPath.ToString(), "_IMSS_RECE.exe"), .Arguments = _IMSS_RESTART}
        Process.Start(startInfo)
    End Sub
    Private Sub Button41_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.MouseEnter
        Button41.FlatAppearance.BorderSize = 1
        PictureBox17.BackColor = Button41.FlatAppearance.MouseOverBackColor
        Button41.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Button41_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.MouseLeave
        PictureBox17.BackColor = Button41.BackColor
        Button41.FlatAppearance.BorderSize = 0
        If Button41.BackColor = Color.AliceBlue Then
            Button41.ForeColor = Color.RoyalBlue
        Else
            Button41.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button41_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        On Error Resume Next
        _IMSS_Q_Systems_Starts(True)
    End Sub
    Private Sub _IMSS_Q_Systems_Starts(ByVal _IMSS_PlaySiundOrNot As Boolean)
        On Error Resume Next
        _IMSS_SetMainMenuButtonBackColor(Color.RoyalBlue, Color.White, Color.RoyalBlue, Color.White, _
                                                 Color.AliceBlue, Color.RoyalBlue, Color.AliceBlue, Color.RoyalBlue, Color.RoyalBlue, _
                                                                                                         Color.RoyalBlue, Color.RoyalBlue, Color.White)
        _IMSS_OverView_Button.Visible = False
        _IMSS_OneClickView_Button.Visible = False
        Panel7.Visible = False
        _IMSS_Update_Holder.Visible = False
        _IMSS_Utitilies_Uint.Visible = False
        _IMSS_Q_Holder.Location = New Point(-1, 65)
        _IMSS_Q_Holder.Size = New Size(831, 394)
        _IMSS_Q_Holder.Visible = True
        '_IMSS_Q_Holder.BringToFront()
        'Panel13.Visible = True
        Panel9.Visible = True
        _IMSS_ButtonSlidesCheckIfSlides = True
        _IMSS_ButtonGenarl_On_Click()
        If _IMSS_PlaySiundOrNot = True Then
            '      My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        End If
        Me._IMSS_Q_Holder.Controls.Add(IMSS_Quarantine._IMSS_CREATE_CONTROL())
        _IMSS_RemoveUpdateCommands()

    End Sub

    Private Sub _IMSS_UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_UpdateButton.Click
        On Error Resume Next
        _IMSS_UpdateButton.Enabled = False
        Button21.Enabled = False
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_CheckForUpdates(True)
        'If Not _IMSS_OnOut_Worker.IsBusy = True Then _IMSS_OnOut_Worker.RunWorkerAsync()
        _IMSS_Main_NotifyIcon.Visible = False
    End Sub

    Private Sub _IMSS_UpdateButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_UpdateButton.MouseEnter
        On Error Resume Next
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        _IMSS_UpdateClickStarts()
    End Sub

    Public Sub _IMSS_UpdateClickStarts()
        On Error Resume Next
        _IMSS_SlideChecking = True
        _IMSS_OnLoad()
        _IMSS_UpdateButtonClick()
        Me.Refresh()
        fade_in()
        Me.Activate()
    End Sub

    Public Sub _IMSS_RemoveUpdateCommands()
        On Error Resume Next
        _IMSS_Status.Visible = False
        _IMSS_UpdateButton.Visible = False
        _IMSS_Status.Text = Nothing
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        On Error Resume Next
        _IMSS_UpdateButtonClick()
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        On Error Resume Next
        _IMSS_Q_Systems_Starts(True)
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        On Error Resume Next
        _IMSS_Main_Button_Starts(True)
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        On Error Resume Next
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_ShowMainWindow()
        IMSS_MainPanel_Settings_Sliding = True
    End Sub


    Private Sub ManualToolStripMenuItem1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ManualToolStripMenuItem1.MouseDown
        _IMSS_Set_Manual_Mode_Animation()
    End Sub

    Private Sub AutoToolStripMenuItem1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AutoToolStripMenuItem1.MouseDown
        _IMSS_Set_Auto_Mode_Animation()
    End Sub

    Public Sub _IMSS_Set_Manual_Mode_Animation()
        AutoToolStripMenuItem1.BackColor = Color.WhiteSmoke
        AutoToolStripMenuItem1.ForeColor = Color.Black
        ManualToolStripMenuItem1.BackColor = Color.LightSkyBlue
        ManualToolStripMenuItem1.ForeColor = Color.Black
    End Sub
    Public Sub _IMSS_Set_Auto_Mode_Animation()
        AutoToolStripMenuItem1.BackColor = Color.LightSkyBlue
        AutoToolStripMenuItem1.ForeColor = Color.Black
        ManualToolStripMenuItem1.BackColor = Color.WhiteSmoke
        ManualToolStripMenuItem1.ForeColor = Color.Black
    End Sub

    Private Function _IMSS_SendCommands(ByVal _IMSS_TargetCommander As String, ByVal _IMSS_Parameter As String)
        Try
            Dim _IMSS_MainCoreProcess As System.Diagnostics.Process = Nothing
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            processStartInfo = New System.Diagnostics.ProcessStartInfo()
            processStartInfo.FileName = _IMSS_TargetCommander
            If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                processStartInfo.Verb = "runas"
            Else
                ' No need to prompt to run as admin
            End If
            processStartInfo.Arguments = _IMSS_Parameter
            processStartInfo.UseShellExecute = True
            Try
                _IMSS_MainCoreProcess = System.Diagnostics.Process.Start(processStartInfo)
                Return True
            Catch ex As Exception
                Return False
                MessageBox.Show(ex.Message, "IMSS Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Not (_IMSS_MainCoreProcess Is Nothing) Then
                    _IMSS_MainCoreProcess.Dispose()
                End If

            End Try
        Catch
            Return False
        End Try
    End Function

    Private Sub Button7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        Button7.FlatAppearance.BorderSize = 1
        PictureBox10.BackColor = Button41.FlatAppearance.MouseOverBackColor
        Button7.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        PictureBox10.BackColor = Button7.BackColor
        Button7.FlatAppearance.BorderSize = 0
        If Button7.BackColor = Color.AliceBlue Then
            Button7.ForeColor = Color.RoyalBlue
        Else
            Button7.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next
        _IMSS_SetMainMenuButtonBackColor(Color.RoyalBlue, Color.White, Color.RoyalBlue, Color.White, _
        Color.RoyalBlue, Color.White, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.AliceBlue, Color.AliceBlue, Color.RoyalBlue)
        '_IMSS_OverView_Button.Visible = True
        '_IMSS_OneClickView_Button.Visible = True
        Panel7.Visible = False
        _IMSS_Update_Holder.Visible = False
        _IMSS_Q_Holder.Visible = False
        _IMSS_ButtonSlidesCheckIfSlides = True
        _IMSS_ButtonGenarl_On_Click()
        '   My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_RemoveUpdateCommands()
        _IMSS_Utitilies_Uint.Visible = True
        IMSS_Utilities._IMSS_OptimizeClickProperty = True
    End Sub

    Private _IMSS_Main_Window_Slide_Status As Boolean = True ' Here
    Private Sub _IMSS_Main_Window_Settings_Sliding_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Main_Window_Settings_Sliding_Timer.Tick
        If _IMSS_Main_Window_Slide_Status = True Then
            If _IMSS_Main_Window_SettingsPanels.Location.X <= -10 Then
                _IMSS_Main_Window_SettingsPanels.Location = New Point(-10, 32)
                _IMSS_Main_Window_Slide_Status = False
                If _Genral_Protection.Visible = True Then _Genral_Protection.Visible = False
                If Panel9.Visible = True Then Panel9.Visible = False
                _IMSS_SlideType = True
                _IMSS_Main_Window_Settings_Sliding_Timer.Enabled = False
            Else
                Select Case _IMSS_Main_Window_SettingsPanels.Location.X
                    Case Is <= 100
                        _IMSS_Main_Window_SettingsPanels.Location = New Point(_IMSS_Main_Window_SettingsPanels.Location.X - 30, 32) : Exit Select
                    Case Is <= 60
                        _IMSS_Main_Window_SettingsPanels.Location = New Point(_IMSS_Main_Window_SettingsPanels.Location.X - 20, 32) : Exit Select
                    Case Is <= 30
                        _IMSS_Main_Window_SettingsPanels.Location = New Point(_IMSS_Main_Window_SettingsPanels.Location.X - 10, 32) : Exit Select
                    Case Else
                        _IMSS_Main_Window_SettingsPanels.Location = New Point(_IMSS_Main_Window_SettingsPanels.Location.X - 60, 32) : Exit Select
                End Select
            End If
        Else
            If _IMSS_Main_Window_SettingsPanels.Location.X >= 844 Then
                _IMSS_Main_Window_SettingsPanels.Location = New Point(844, 32)
                _IMSS_Main_Window_Slide_Status = True
                If _Genral_Protection.Visible = False Then _Genral_Protection.Visible = True
                If Panel9.Visible = False Then Panel9.Visible = True
                _IMSS_SlideType = False
                _IMSS_SetButtonSetting()
                _IMSS_Main_Window_Settings_Sliding_Timer.Enabled = False
            Else
                _IMSS_Main_Window_SettingsPanels.Location = New Point(_IMSS_Main_Window_SettingsPanels.Location.X + 60, 32)
            End If
        End If
    End Sub
    Private _IMSS_SlideType As Boolean
    Private Sub _IMSS_SetButtonSetting()
        If _IMSS_SlideType = False Then
            Button14.BackColor = Color.WhiteSmoke
        End If
    End Sub
    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_BackPictureBox.Click
        On Error Resume Next
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_Main_Window_Settings_Sliding_Timer.Enabled = True
    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_Button22_SetButtonBackColor_For_SettingPanelsHolders()
        _IMSS_SET_PANEL_STATUS(True, False, False)
    End Sub

    Private Sub _IMSS_BackPictureBox_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_BackPictureBox.MouseEnter
        _IMSS_BackPictureBox.Width = 44

    End Sub

    Private Sub _IMSS_BackPictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_BackPictureBox.MouseLeave
        _IMSS_BackPictureBox.Width = 39
    End Sub
    Private Sub _IMSS_SetButtonBackColor_For_SettingPanelsHolders(ByVal _IMSS_Button27_Color As Color, _
                                                  ByVal _IMSS_Button1_Color As Color, _
                                                  ByVal _IMSS_Button2_Color As Color, _
                                                  ByVal _IMSS_Button27_FlatStyle As FlatStyle, _
                                                  ByVal _IMSS_Button1_FlatStyle As FlatStyle, _
                                                  ByVal _IMSS_Button2_FlatStyle As FlatStyle)
        Button22.BackColor = _IMSS_Button27_Color
        Button22.FlatStyle = _IMSS_Button27_FlatStyle
        Button8.BackColor = _IMSS_Button1_Color
        Button8.FlatStyle = _IMSS_Button1_FlatStyle
        Button23.BackColor = _IMSS_Button2_Color
        Button23.FlatStyle = _IMSS_Button2_FlatStyle
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        _IMSS_Button22_SetButtonBackColor_For_SettingPanelsHolders()
        _MAIN_SettingPanel_Options(Panel32, New Point(16, 225), New Point(158, 154))
        _IMSS_SET_Mini_Panels_Option(True, False, False)
        _IMSS_SET_PANEL_STATUS(True, False, False)
    End Sub
    Private Sub _MAIN_SettingPanel_Options(ByVal _IMSS_TARGETPANEL As Panel, ByVal _IMSS_Location_POINT As Point, ByVal _IMSS_SIZE_POINT As Point)
        _IMSS_TARGETPANEL.Location = New Point(16, 225)
        _IMSS_TARGETPANEL.Size = New Point(158, 154)
    End Sub

    Private Sub _IMSS_SET_Mini_Panels_Option(ByVal _IMSS_PANELMain As Boolean, ByVal _IMSS_PANEL_UpdateSettings As Boolean, _
                                             ByVal _IMSS_LogPanel As Boolean)
        Panel32.Visible = _IMSS_PANELMain
        _IMSS_UpdateSettings_Panels.Visible = _IMSS_PANEL_UpdateSettings
        _IMSS_Log_SettingPanel.Visible = _IMSS_LogPanel

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        On Error Resume Next
        _IMSS_UpdateClick()
    End Sub
    Private Sub _IMSS_UpdateClick()
        _IMSS_SetButtonBackColor_For_SettingPanelsHolders(Color.WhiteSmoke, Color.LightSkyBlue, Color.WhiteSmoke, FlatStyle.Flat, _
                                                  FlatStyle.Popup, FlatStyle.Flat)
        _MAIN_SettingPanel_Options(_IMSS_UpdateSettings_Panels, New Point(16, 225), New Point(158, 154))
        _IMSS_SET_Mini_Panels_Option(False, True, False)
        _IMSS_SET_PANEL_STATUS(False, True, False)
    End Sub
    Private Sub _IMSS_Button22_SetButtonBackColor_For_SettingPanelsHolders()
        _IMSS_SetButtonBackColor_For_SettingPanelsHolders(Color.LightSkyBlue, Color.WhiteSmoke, Color.WhiteSmoke, FlatStyle.Popup, _
                                                  FlatStyle.Flat, FlatStyle.Flat)
    End Sub
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        _IMSS_SetButtonBackColor_For_SettingPanelsHolders(Color.WhiteSmoke, Color.WhiteSmoke, Color.LightSkyBlue, FlatStyle.Flat, _
                                                  FlatStyle.Flat, FlatStyle.Popup)
        _MAIN_SettingPanel_Options(_IMSS_Log_SettingPanel, New Point(16, 225), New Point(158, 154))
        _IMSS_SET_Mini_Panels_Option(False, False, True)
        _IMSS_LoadSettingLogData()
        _IMSS_SET_PANEL_STATUS(False, False, True)
    End Sub

    Private Sub _IMSS_LoadSettingLogData()
        On Error Resume Next
        IMSS_LOG._IMSS_SecuritySettingsLogData_ReadLogDataFiles = True
    End Sub

    Private Sub Button14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.MouseLeave
        If _IMSS_SlideType = True Then
            Button14.BackColor = Color.LightSkyBlue
        End If

    End Sub
    Public Sub _IMSS_ENABEL_APPLY_BUTTON()
        Button19.Enabled = True
    End Sub
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Try
            Me.PictureBox29.Enabled = True
            Me.PictureBox29.Visible = True
            Button19.Enabled = False
            My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
            If IMSS_MainSettings.CheckBox1.Checked = True Then
                My.Settings.SysMontior = True
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> System monitor enabled ", 4)
            Else
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> System monitor disabled", 4)
                My.Settings.SysMontior = False
            End If
            If IMSS_MainSettings.CheckBox2.Checked = True Then
                My.Settings.SysSheild = True
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> System shield enabled ", 4)
            Else
                My.Settings.SysSheild = False
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> System shield disabled", 4)
            End If
            If IMSS_MainSettings.CheckBox3.Checked = True Then
                My.Settings.USBMonitor = True
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> USB monitor enabled ", 4)
            Else
                My.Settings.USBMonitor = False
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> USB monitor disabled", 4)
            End If
            If IMSS_MainSettings.CheckBox4.Checked = True Then
                My.Settings.USBShelid = True
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> USB shield enabled ", 4)
            Else
                My.Settings.USBShelid = False
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> USB shield disabled", 4)
            End If
            If IMSS_MainSettings.CheckBox5.Checked = True Then
                My.Settings.SystemSounds = True
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> System sounds enabled ", 4)
            Else
                My.Settings.SystemSounds = False
                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> System sounds disabled ", 4)
            End If
            If My.Settings.SysSheild = False Then
                PictureBox3.Visible = False
                PictureBox20.Visible = False
                PictureBox22.Visible = False
                PictureBox23.Visible = False
                PictureBox24.Visible = False
                Label45.Text = "Disable"
                Label18.Text = "OFF"
                Label45.ForeColor = Color.Red
                Label18.ForeColor = Color.Red
            Else
                Label45.Text = "Enabled"
                Label18.Text = "ON"
                Label45.ForeColor = Color.Green
                Label18.ForeColor = Color.Green
                PictureBox3.Visible = True
                PictureBox20.Visible = True
                PictureBox22.Visible = True
                PictureBox23.Visible = True
                PictureBox24.Visible = True
            End If
            If My.Settings.SysMontior = False Then
                IMSS_MonitorsCotrolsUint.PictureBox28.Visible = False
                IMSS_MonitorsCotrolsUint.PictureBox33.Visible = False
                IMSS_MonitorsCotrolsUint.PictureBox31.Visible = False
                IMSS_MonitorsCotrolsUint.Label61.Text = "Disable"
                Label24.Text = "OFF"
                Label46.Text = "Disable"
                Label19.Text = "OFF"
                IMSS_MonitorsCotrolsUint.Label61.ForeColor = Color.Red
                Label24.ForeColor = Color.Red
                Label46.ForeColor = Color.Red
                Label19.ForeColor = Color.Red
            Else
                IMSS_MonitorsCotrolsUint.PictureBox28.Visible = True
                IMSS_MonitorsCotrolsUint.PictureBox33.Visible = True
                IMSS_MonitorsCotrolsUint.PictureBox31.Visible = True
                IMSS_MonitorsCotrolsUint.Label61.Text = "Enabled"
                Label46.Text = "Enabled"
                Label19.Text = "ON"
                Label24.Text = "Good"
                IMSS_MonitorsCotrolsUint.Label61.ForeColor = Color.Green
                Label46.ForeColor = Color.Green
                Label19.ForeColor = Color.Green
                Label24.ForeColor = Color.Blue
            End If
            If My.Settings.USBShelid = False Then
                IMSS_MonitorsCotrolsUint.Label65.Text = "Stoped"
                IMSS_MonitorsCotrolsUint.Label67.Text = "Stoped"
                Label12.Text = "Protection Disable"
                Label17.Text = "Protection Is Disable"
                Label48.Text = "Disable"
                Label21.Text = "OFF"
                IMSS_MonitorsCotrolsUint.Label65.ForeColor = Color.Red
                IMSS_MonitorsCotrolsUint.Label67.ForeColor = Color.Red
                Label12.ForeColor = Color.Red
                Label48.ForeColor = Color.Red
                If Not My.Settings.USBShelid = False Then
                    PictureBox4.BackgroundImage.Dispose()
                    PictureBox4.BackgroundImage = My.Resources._1
                Else
                    PictureBox4.BackgroundImage = My.Resources._IMSS_Pr_Off
                End If
                Label21.ForeColor = Color.Red
            Else
                IMSS_MonitorsCotrolsUint.Label67.Text = "Waiting"
                IMSS_MonitorsCotrolsUint.Label65.Text = "system"
                Label48.Text = "Enabled"
                Label17.Text = "Your Computer is protected from any viruses or worms or shortcuts infection or autoruns" + vbNewLine & _
                " files - all systems running "
                Label21.Text = "ON"
                Label12.Text = "Removable media protection is available"
                IMSS_MonitorsCotrolsUint.Label67.ForeColor = Color.Green
                IMSS_MonitorsCotrolsUint.Label65.ForeColor = Color.Green
                Label48.ForeColor = Color.Green
                If Not My.Settings.USBShelid = False Then
                    PictureBox4.BackgroundImage.Dispose()
                    PictureBox4.BackgroundImage = My.Resources._1
                Else
                    PictureBox4.BackgroundImage = My.Resources._IMSS_Pr_Off
                End If
                Label21.ForeColor = Color.Green
                Label12.ForeColor = Color.Green
            End If
            If My.Settings.USBMonitor = False Then
                IMSS_MonitorsCotrolsUint.Label71.Text = "Disable"
                Label47.Text = "Disable"
                Label22.Text = "OFF"
                IMSS_MonitorsCotrolsUint.Label71.ForeColor = Color.Red
                Label47.ForeColor = Color.Red
                Label22.ForeColor = Color.Red
            Else
                IMSS_MonitorsCotrolsUint.Label71.Text = "Enabled"
                Label47.Text = "Enabled"
                Label22.Text = "ON"
                IMSS_MonitorsCotrolsUint.Label71.ForeColor = Color.Green
                Label47.ForeColor = Color.Green
                Label22.ForeColor = Color.Green
            End If
        Catch : End Try
        PictureBox29.Visible = False
        PictureBox29.Enabled = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        IMSS_MainSettings.CheckBox1.Checked = True
        IMSS_MainSettings.CheckBox2.Checked = True
        IMSS_MainSettings.CheckBox3.Checked = True
        IMSS_MainSettings.CheckBox4.Checked = True
        IMSS_MainSettings.CheckBox5.Checked = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        On Error Resume Next
        IMSS_MainSettings._IMSS_CHECK_UNCHECK_ALL_PROPERTY = True
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        IMSS_Language._IMSS_SET_DEFAULT = True
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        IMSS_Language._IMSS_SET_APPLY = True
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        IMSS_LOG._IMSS_SecuritySettingsLogData_ClearLogDataFiles = True
    End Sub

    Private Sub MainMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        _IMSS_ChangeCursors(Cursors.SizeAll)
    End Sub

    Private Sub MainMain_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        _IMSS_ChangeCursors(Cursors.Default)
    End Sub

    Private Sub _IMSS_ChangeCursors(ByVal _IMSS_CURSORSTYPE As Cursor)
        Me.Cursor = _IMSS_CURSORSTYPE
    End Sub

    Private Sub _IMSS_MainLogo_PicitureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _IMSS_MainLogo_PicitureBox.MouseDown
        _IMSS_MainLogo_PicitureBox.Image = My.Resources.IMSS_Main_Logo_Title
    End Sub

    Private Sub _IMSS_MainLogo_PicitureBox_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MainLogo_PicitureBox.MouseEnter
        _IMSS_MainLogo_PicitureBox.Image = My.Resources.IMSS_Main_Logo_Title_OnMouseOver
    End Sub

    Private Sub _IMSS_MainLogo_PicitureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_MainLogo_PicitureBox.MouseLeave
        _IMSS_MainLogo_PicitureBox.Image = My.Resources.IMSS_Main_Logo_Title
    End Sub

    Private Sub _IMSS_MainLogo_PicitureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MainLogo_PicitureBox.Click
        Try
            My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
            Process.Start(ConfigurationResureses.LinkVar._IMSS_HomePage)
        Catch : End Try
    End Sub

    Private Sub _IMSS_LANG_MSG(ByVal _IMSS_MSELANG As String)
        MessageBox.Show("Main language has been set to " & _IMSS_MSELANG & " , the program will restart automatically for the new setting to get effective", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub EnabledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnabledToolStripMenuItem.Click
        Try
            Dim FontBold = New Font(EnabledToolStripMenuItem.Font, FontStyle.Bold)
            Dim FontNormal = New Font(EnabledToolStripMenuItem.Font, FontStyle.Regular)
            EnabledToolStripMenuItem.Font = FontBold
            DisableToolStripMenuItem.Font = FontNormal
            IMSS_MonitorsCotrolsUint.Button47.Enabled = False
            IMSS_MonitorsCotrolsUint.Button48.Enabled = True
            My.Settings.SysMontior = True
            My.Settings.USBMonitor = True
            IMSS_MonitorsCotrolsUint.Label61.Text = "Enabled"
            IMSS_MonitorsCotrolsUint.Label61.ForeColor = Color.Green
            IMSS_MonitorsCotrolsUint.Label71.Text = "Enabled"
            IMSS_MonitorsCotrolsUint.Label71.ForeColor = Color.Green
            IMSS_MonitorsCotrolsUint.Label65.Text = "system"
            IMSS_MonitorsCotrolsUint.Label65.ForeColor = Color.Green
            IMSS_MonitorsCotrolsUint.Label67.Text = "Waiting"
            IMSS_MonitorsCotrolsUint.Label67.ForeColor = Color.Green
            IMSS_MonitorsCotrolsUint.PictureBox28.Visible = True
            IMSS_MonitorsCotrolsUint.PictureBox33.Visible = True
            IMSS_MonitorsCotrolsUint.PictureBox31.Visible = True
            IMSS_MonitorsCotrolsUint.PictureBox36.Visible = True
        Catch : End Try
        Try
            For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
                If d.DriveType = IO.DriveType.Removable And Not d.DriveType = IO.DriveType.CDRom Then
                    If Not d.Name.ToString() = Nothing And d.IsReady = True Then
                        _IMSS_SYSTEM_UINT._IMSS_ALLOW_SURV = True
                    End If
                End If
            Next
        Catch : End Try
        MessageBox.Show("Monitor Started !", "IMSS Monitors", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> System monitor is activated ", 4)
    End Sub

    Private Sub DisableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem.Click
        Try
            Dim FontBold = New Font(DisableToolStripMenuItem.Font, FontStyle.Bold)
            Dim FontNormal = New Font(DisableToolStripMenuItem.Font, FontStyle.Regular)
            DisableToolStripMenuItem.Font = FontBold
            EnabledToolStripMenuItem.Font = FontNormal
            IMSS_MonitorsCotrolsUint.ListView2.Items.Clear()
            IMSS_MonitorsCotrolsUint.ListView3.Items.Clear()
            IMSS_MonitorsCotrolsUint.Button47.Enabled = True
            IMSS_MonitorsCotrolsUint.Button48.Enabled = False
            My.Settings.SysMontior = False
            My.Settings.USBMonitor = True
            IMSS_MonitorsCotrolsUint.Label61.Text = "Disable"
            IMSS_MonitorsCotrolsUint.Label61.ForeColor = Color.Red
            IMSS_MonitorsCotrolsUint.Label71.Text = "Disable"
            IMSS_MonitorsCotrolsUint.Label71.ForeColor = Color.Red
            IMSS_MonitorsCotrolsUint.Label65.Text = "None"
            IMSS_MonitorsCotrolsUint.Label65.ForeColor = Color.Red
            IMSS_MonitorsCotrolsUint.Label67.Text = "None"
            IMSS_MonitorsCotrolsUint.Label67.ForeColor = Color.Red
            'End If
            IMSS_MonitorsCotrolsUint.PictureBox28.Visible = False
            IMSS_MonitorsCotrolsUint.PictureBox33.Visible = False
            IMSS_MonitorsCotrolsUint.PictureBox31.Visible = False
            IMSS_MonitorsCotrolsUint.PictureBox36.Visible = False
            _IMSS_SYSTEM_UINT._IMSS_ALLOW_SURV = False
            MessageBox.Show("Monitor has been terminated !", "IMSS Monitors", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> System monitor is disable ", 4)
        Catch : End Try
    End Sub

    Private Sub _IMSS_OverView_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OverView_Button.Click
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_OverView_Button.Font = New Font("Arial", 9, FontStyle.Bold)
        _IMSS_OverView_Button.BackColor = Color.AliceBlue
        _IMSS_OverView_Button.ForeColor = Color.RoyalBlue
        _IMSS_OneClickView_Button.Font = New Font("Tahoma", 9, FontStyle.Regular)
        _IMSS_OneClickView_Button.BackColor = Color.RoyalBlue
        _IMSS_OneClickView_Button.ForeColor = Color.White
        IMSS_Utilities._IMSS_ButtonCleanupClick(False)
        For i = -834 To 0 Step 60
            Application.DoEvents()
            IMSS_Utilities.Location = New Point(i, 0)
        Next i : IMSS_Utilities.Location = New Point(0, 0)
    End Sub

    Private Sub _IMSS_OneClickView_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OneClickView_Button.Click
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        IMSS_Utilities._IMSS_MAIN_PANEL.Visible = False
        _IMSS_OverView_Button.Font = New Font("Tahoma", 9, FontStyle.Regular)
        _IMSS_OverView_Button.BackColor = Color.RoyalBlue
        _IMSS_OverView_Button.ForeColor = Color.White
        _IMSS_OneClickView_Button.Font = New Font("Arial", 9, FontStyle.Bold)
        _IMSS_OneClickView_Button.BackColor = Color.White
        _IMSS_OneClickView_Button.ForeColor = Color.RoyalBlue
        IMSS_Utilities._IMSS_ButtonCleanupClick(False)
        For i = 0 To -834 Step -4
            Application.DoEvents()
            IMSS_Utilities.Location = New Point(i, 0)
        Next i : IMSS_Utilities.Location = New Point(-834, 0)
        IMSS_Utilities._IMSS_MAIN_PANEL.Visible = True
    End Sub

    Private Sub _IMSS_OverView_Button_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_OverView_Button.MouseEnter
        _IMSS_OverView_Button.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub _IMSS_OverView_Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_OverView_Button.MouseLeave
        If _IMSS_OverView_Button.BackColor = Color.AliceBlue Then
            _IMSS_OverView_Button.ForeColor = Color.RoyalBlue
        Else
            _IMSS_OverView_Button.ForeColor = Color.White
        End If
    End Sub

    Private Sub _IMSS_OneClickView_Button_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OneClickView_Button.MouseEnter
        _IMSS_OneClickView_Button.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub _IMSS_OneClickView_Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_OneClickView_Button.MouseLeave
        If _IMSS_OneClickView_Button.BackColor = Color.White Then
            _IMSS_OneClickView_Button.ForeColor = Color.RoyalBlue
        Else
            _IMSS_OneClickView_Button.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_PROTECTION_STATUS_BUTTON.Click
        On Error Resume Next
        _IMSS_ControlsUserDisply.Visible = False
        _IMSS_ButtonInClick()
    End Sub

    Private Function _IMSS_CheckForAdminPrivileges() As Boolean
        Dim _IMSS_Identity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim _IMSS_Principal As WindowsPrincipal = New WindowsPrincipal(_IMSS_Identity)
        If Not (_IMSS_Principal.IsInRole(WindowsBuiltInRole.Administrator)) Then
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub _IMSS_RestartWithAdminPrivileges()
        Dim startInfo As New ProcessStartInfo With {.FileName = Path.Combine(Application.StartupPath.ToString(), "_IMSS_RECE.exe"), .Arguments = "_RESTARTAS"}
        Process.Start(startInfo)
    End Sub

    Private Sub _IMSS_Main_NotifyIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles _IMSS_Main_NotifyIcon.MouseClick
        If Not (e.Button = MouseButtons.Right) Then
            _IMSS_ShowMainWindow()
        End If
    End Sub

End Class

' الحمد لله و ان فضل ربي علي لعظيمى
