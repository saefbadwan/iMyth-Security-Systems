
Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim _IMSS_RegisterPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSSRegConfig.IMSS"
            If _IMSS_IsConnectionAvailable() = True Then
                If Not IO.File.Exists(_IMSS_RegisterPath) Then
                    My.Application.MainForm = IMSS_RegConfig
                Else
                    My.Application.MainForm = MainMain
                End If
            Else
                My.Application.MainForm = MainMain
            End If

        End Sub
        '#Region "IMSS Load Utitilies Unit GUI"
        'Private Sub _IMSS_LOAD_UTITILIESUINT_GUI()
        '    Try
        '        Dim process As System.Diagnostics.Process = Nothing
        '        Dim processStartInfo As System.Diagnostics.ProcessStartInfo
        '        processStartInfo = New System.Diagnostics.ProcessStartInfo()
        '        processStartInfo.FileName = _IMSS_Utilities_Unit_Path
        '        If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
        '            processStartInfo.Verb = "runas"
        '        Else
        '            ' No need to prompt to run as admin
        '        End If
        '        processStartInfo.Arguments = ""
        '        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        '        processStartInfo.UseShellExecute = True
        '        Try
        '            process = System.Diagnostics.Process.Start(processStartInfo)
        '            process.WaitForInputIdle()
        '            If _IMSS_AR = True Then

        '            ElseIf _IMSS_FR = True Then

        '            ElseIf _IMSS_RS = True Then

        '            ElseIf _IMSS_ES = True Then

        '            Else

        '            End If
        '            System.Threading.Thread.Sleep(3000)
        '            SetParent(process.MainWindowHandle, MainMain._IMSS_Utitilies_Uint.Handle)
        '            SendMessage(process.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
        '        Catch ex As Exception
        '            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Finally
        '            If Not (process Is Nothing) Then
        '                process.Dispose()
        '            End If
        '        End Try
        '    Catch ex As Exception
        '    End Try
        'End Sub
        '#End Region
        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            If MainMain.Visible = True Then
                MainMain._IMSS_SlideChecking = True
            Else
                MainMain._IMSS_SlideChecking = False
            End If
            MainMain._IMSS_ShowMainWindow()
        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

            Dim _IMSS_CRASH_REPORT As New OnlineSystems.IMSS_CreashReport
            _IMSS_CRASH_REPORT._IMSS_SET_REPORT_CONRENT = vbNewLine + e.Exception.ToString() + vbNewLine
            _IMSS_CRASH_REPORT.Show()

            Do
                DoEvents()
                System.Threading.Thread.Sleep(400)
            Loop Until _IMSS_CRASH_REPORT._IMSS_WaitEqual

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
        '#Region "IMSS Languages Systems Declaration"
        'Private Sub _IMSS_AR_Lang_Systems()
        '    'MainMain._IMSS_Main_NotifyIcon.BalloonTipText = "جميع انظمة الحماية تعمل بأعلى فعالية"
        '    'MainMain._IMSS_Main_NotifyIcon.Text = "الأنظمة تعمل"
        '    'MainMain.Button14.Text = "اعدادات"
        '    'MainMain.Button16.Text = "مباشر"
        '    'MainMain.Button17.Text = "مساعدة"
        '    'MainMain.Button17.Width = 84 ' 64
        '    'MainMain.Button20.Text = "الحماية"
        '    'MainMain.Button7.Text = "مساعدة"
        '    'MainMain.Button41.Text = "الحجر"
        '    'MainMain.Button21.Text = "تحديث"
        '    'MainMain.Button27.Text = "الحماية العامة"
        '    'MainMain.Button8.Text = "اعدادات التحديث"
        '    'MainMain.Button1.Text = "حالة الحماية"
        '    'MainMain.Button22.Text = "اعدادات الأمان"
        '    'MainMain.Button23.Text = "قسم السجل"
        '    'MainMain.Button26.Text = "استعادة الأفتراضيات"
        '    'MainMain.Button25.Text = "تطبيق"
        '    'MainMain.Button30.Text = "افراغ السجل"
        '    ''MainMain._IMSS_QuarantineRoom.Text = "غرفة الحجر"
        '    ''MainMain._IMSS_QuarantineRoom.TextAlign = ContentAlignment.MiddleCenter
        '    ''MainMain._IMSS_Log.Text = "قسم السجل"
        '    ''MainMain.Label2.Text = "خيارات الحجر"
        '    ''MainMain.Button18.Text = "افراغ السجل"
        '    'MainMain.Button27.TextAlign = ContentAlignment.MiddleCenter ' MiddleRight
        '    'MainMain.Button1.TextAlign = ContentAlignment.MiddleCenter ' MiddleRight
        '    'MainMain.Label54.Location = New Point(14, 5)
        '    'MainMain.Label16.Location = New Point(140, 239) ' 151
        '    'MainMain.Label15.Location = New Point(281, 239) ' 311
        '    'MainMain.Label14.Location = New Point(21, 5) ' 11, 5
        '    'MainMain.Label27.Location = New Point(10, 5) ' 1, 5
        '    'MainMain.Label28.Location = New Point(4, 5)
        '    ''MainMain.Label37.Location = New Point(16, 4)
        '    'MainMain.Button2.Text = "تشفير الأجهزه"
        '    'MainMain.Button3.Text = "USB فحص"
        '    'MainMain.Button4.Text = "المراقبات"
        '    'MainMain.Button5.Text = "قسم الأدوات"
        '    'MainMain.Button6.Text = "قسم السجل"
        '    'MainMain.Label54.Text = "حالة الحماية"
        '    'MainMain.Label12.Text = "النظام محمي"
        '    'MainMain.Label17.Text = " حهاز الكمبيوتر لديك محمي من جميع الفايروسات والديدان والبرامج الضارة وعدوى الاختصارات " + Environment.NewLine +
        '    '"ومن ملفات التشغيل التلقائي - جميع الأنظنة تعمل"
        '    'MainMain.Label23.Text = "حالة الحماية : "
        '    'MainMain.Label26.Text = "سجل الأمان : "
        '    'MainMain.Label24.Text = "ممتاز"
        '    'MainMain.Label25.Text = "متوفر"
        '    'MainMain.Label11.Text = " USB درع:"
        '    'MainMain.Label16.Text = "درع الأختصارات :"
        '    'MainMain.Label15.Text = "درع التشفيل التلقائي:"
        '    'MainMain.Label13.Text = "درع الديدان:"
        '    'MainMain.Label18.Text = "فعال"
        '    'MainMain.Label22.Text = "فعال"
        '    'MainMain.Label21.Text = "فعال"
        '    'MainMain.Label19.Text = "فعال"
        '    'MainMain.Button28.Text = "USB فحص"
        '    'MainMain.Button29.Text = "أدوات"
        '    'MainMain.Button34.Text = "تهيئة USB"
        '    'MainMain.Button35.Text = "اعدادات USB"
        '    'MainMain.Label14.Text = " USB درع"
        '    'MainMain.Label27.Text = "الحماية العامة"
        '    'MainMain.Label38.Text = "درع النظام:"
        '    'MainMain.Label40.Text = "مراقبة النظام:"
        '    'MainMain.Label50.Text = "سجل الأمان"
        '    'MainMain.Label49.Text = "متوفر"
        '    'MainMain.Label45.Text = "مفعل"
        '    'MainMain.Label46.Text = "مفعل"
        '    'MainMain.Label44.Text = " USB درع:"
        '    'MainMain.Label41.Text = "مراقبة USB:"
        '    'MainMain.Label51.Text = "متوفر"
        '    'MainMain.Button32.Text = "USB تحرير منفذ "
        '    'MainMain.Button31.Text = "USB حظر منفذ"
        '    'MainMain.Label30.Text = "الحالة"
        '    'MainMain._OnOff.Text = "غير محظور"
        '    'MainMain.Label29.Text = "أدوات اصلاح"
        '    'MainMain.Label32.Text = "هذه الأدوات تبحث عن خصائص او اعدادات غير افتراضية في نظام" + Environment.NewLine +
        '    '" التشغيل هاذا وتحاول اعادة ضبطها او اصلاحها"
        '    'MainMain.Button42.Text = " مجموعة من أدوات الأصلاح السريعة"
        '    'MainMain.Label28.Text = "USB تحرير/حظر"
        '    'MainMain.ExitToolStripMenuItem.Text = "USB فحص جهاز "
        '    'MainMain.MainWindoToolStripMenuItem.Text = "النافذة الرئيسية"
        '    'MainMain.OpenDriverSaftlyToolStripMenuItem.Text = "فتح الأقراص بأمان"
        '    'MainMain.DriversMonitorToolStripMenuItem.Text = "مراقب الأقراص"
        '    'MainMain.EnabledToolStripMenuItem.Text = "مفعل"
        '    'MainMain.DisableToolStripMenuItem.Text = "معطل"
        '    'MainMain.UpdateToolStripMenuItem.Text = "تحديث"
        '    'MainMain.HomeToolStripMenuItem.Text = "اللغه الرئيسيه"
        '    'MainMain.AboutToolStripMenuItem.Text = "عن البرنامج"
        '    'MainMain.ModeToolStripMenuItem1.Text = "الوضع"
        '    'MainMain.AutoToolStripMenuItem1.Text = "تلقائي"
        '    'MainMain.ManualToolStripMenuItem1.Text = "يدوي"
        '    'MainMain.ExitToolStripMenuItem2.Text = "خروج"
        '    'MainMain.RestartToolStripMenuItem.Text = "اعادة التشغيل"
        '    'MainMain.QuickToolsToolStripMenuItem.Text = "أدوات اصلاح"
        '    'MainMain.OtherToolStripMenuItem1.Text = "غير ذالك"
        '    'MainMain.SystemToolsToolStripMenuItem1.Text = "أدوات النطام"
        '    'MainMain.FamilyToolsToolStripMenuItem1.Text = "أدوات العائلة"
        '    'MainMain.OtherToolStripMenuItem2.Text = "اخرى"
        '    'MainMain.TempCleanerToolStripMenuItem1.Text = "مدير تنظيف الملفات المؤقته ومخلفات المتصفحات"
        '    'MainMain.RegistryCleanerToolStripMenuItem1.Text = "مدير تنظيف الرجستري وتصحيح الأخطاء"
        '    'MainMain.StartupManagerToolStripMenuItem1.Text = "مدير برامج بدء التشغيل"
        '    'MainMain.UninstallManagerToolStripMenuItem1.Text = "مدير ازالة البرامج"
        '    'MainMain.ProcessManagerToolStripMenuItem1.Text = "مدير العمليات"
        '    'MainMain.FamilyComputerInformationViewerToolStripMenuItem.Text = "مدير عرض معلومات النظام والأجهزة"
        '    'MainMain.FamilyAutoShutdownManagerToolStripMenuItem.Text = "أداة ايقاف التشغيل التلقائية"
        '    'MainMain.FamilyWebsitesBlockerToolStripMenuItem.Text = "أداة حظر المواقع"
        '    'MainMain.FamilyProgramBlockerToolStripMenuItem2.Text = "أداة حظر البرامج"
        '    'MainMain.FamilyFolderLockerToolStripMenuItem.Text = "أداة قفل المجلدات"
        '    'MainMain.WindowsServiceMangerToolStripMenuItem1.Text = "مدير خدمات النظام"
        '    'MainMain.MemoryCleanerToolStripMenuItem1.Text = "مدير تنظيف الذاكرة"
        '    'MainMain.IMSSAdvancedFileExplorerToolStripMenuItem.Text = "متصفح الملفات المتقدم"
        '    'MainMain.SettingsToolStripMenuItem.Text = "اعدادات"
        '    'MainMain.RepairDisabledShowingHiddenFilesToolStripMenuItem1.Text = "اصلاح تعطيل اظهار الملفات المخفيه"
        '    'MainMain.RepairDisabledFolderOptionsToolStripMenuItem.Text = "اصلاح تعطيل خيارات المجلد"
        '    'MainMain.RepairCmdToolStripMenuItem1.Text = "اصلاح موجة الأوامر"
        '    'MainMain.RepairExeFileAssociationToolStripMenuItem.Text = "(exe) اصلاح امتداد ملفات"
        '    'MainMain.RepairTxtFileAssociationToolStripMenuItem.Text = "(txt) اصلاح امتداد ملفات"
        '    'MainMain.RepairBatFileAssociationToolStripMenuItem.Text = "(bat) اصلاح امتداد ملفات"
        '    'MainMain.RepairTaskManagerToolStripMenuItem.Text = "اصلاح مدير المهام"
        '    'MainMain.RepairRegistryToolStripMenuItem.Text = "اصلاح محرر التسجيل"
        '    'MainMain.RepairFirewallToolStripMenuItem.Text = "تفعيل جدار الحماية"
        '    'MainMain._IMSS_UpdateButton.Text = "التحديث الأن"
        '    'MainMain.Label37.Text = "نظام الحجر"
        '    'MainMain.Label39.Text = "اظهار الملفات الضارة المحجورة ومعلومات عنها, وامكانية حذفها او استعادتها, الملفات الضارة " + Environment.NewLine +
        '    '"محجورة بطريقة كليا امنة, وتلفي فعالية الملفات  "
        '    'MainMain.Label36.Text = "غرفة الحجر فارغة"
        '    'MainMain.Label43.Text = "كل الملفات :"
        '    'MainMain.Label81.Text = "حالة الحجر :"
        '    'MainMain.Label80.Text = "مقفل"
        '    'MainMain.Button44.Text = "استعادة الى"
        '    'MainMain.Button46.Text = "تحديث"
        '    'MainMain.Button43.Text = "حذف"
        '    'MainMain.Button45.Text = "افراغ"
        'End Sub
        '#End Region

    End Class

End Namespace

