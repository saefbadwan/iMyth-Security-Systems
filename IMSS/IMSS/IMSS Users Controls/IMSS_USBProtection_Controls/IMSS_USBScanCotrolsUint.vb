'بسم الله ابدأ
'يا رب يا الله يا رحيم يا عظيم جل جلالك بأسمائك يا الله وفقني برحمتك

Imports System.IO
Imports System.Security.AccessControl

Public Class IMSS_USBScanCotrolsUint



    Public Shared _IMSS_TARGET_NAME As String = String.Empty
    Private _IMSS_ITEN_DELETE_STATUS As Integer = 0

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        On Error Resume Next
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_SCAN_COMPLETE = True
        MainMain._IMSS_CieckIfScanningRunning = False
        ProgressBar1.Maximum = 100
        If lstFile.Items.Count > 0 Then
            ProgressBar1.Value = 0
            _IMSS_ITEN_DELETE_STATUS = 0
            MainMain.ix = 0
            Dim _IMSS_RandomNames As New Random
            Dim _IMSS_RandomValue As Integer = _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10)
            Dim fs As FileSystemSecurity = File.GetAccessControl(MainMain._IMSS_Q + "\IMSSQ")
            fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(MainMain._IMSS_Q + "\IMSSQ", fs)
            System.Threading.Thread.Sleep(40)
            For i As Integer = 0 To lstFile.Items.Count - 1
                If lstFile.Items(i).Checked = True Then
                    If IO.File.Exists(lstFile.Items(i).Text) Then
                        IO.File.Copy(lstFile.Items(i).Text, MainMain._IMSS_Q + "\IMSSQ" + "\" + "THREAT-ID-" + _IMSS_RandomValue.ToString + ".IMSSQ")
                        System.Threading.Thread.Sleep(40)
                        IO.File.Delete(lstFile.Items(i).Text)
                        lstFile.Items(i).ForeColor = Color.Green
                        lstFile.Items(i).ImageIndex = 1
                        _IMSS_RandomValue = Nothing
                        _IMSS_RandomValue = _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10)
                        MainMain.ix += 1
                        _IMSS_ITEN_DELETE_STATUS += 1
                    End If
                Else
                    MainMain.ix += 1
                    lstFile.Items(i).ImageIndex = 0
                    lstFile.Items(i).ForeColor = Color.Red
                End If
            Next
            Label34.ForeColor = Color.Green
            'If _IMSS_AR = True Then
            '    Label34.Text = MainMain.ix.ToString() & " نقل الى الحجر"
            '    _IMSS_THREAT_FOUNDS_Label.Text = "ملفات ضاره وجدت " & MainMain.ix.ToString()
            '    _IMSS_THREAT_STATS_Label.Text = "نقل الى الحجر " & _IMSS_ITEN_DELETE_STATUS.ToString()
            'ElseIf _IMSS_FR = True Then

            'ElseIf _IMSS_RS = True Then

            'ElseIf _IMSS_ES = True Then
            'Else
            Label34.Text = MainMain.ix.ToString + " Moved"
            _IMSS_THREAT_FOUNDS_Label.Text = MainMain.ix.ToString() & " Threat's was found"
            _IMSS_THREAT_STATS_Label.Text = _IMSS_ITEN_DELETE_STATUS.ToString() + " Moved to quarantine"
            'End If
            ProgressBar1.Value = 100
            System.Threading.Thread.Sleep(40)
            fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(MainMain._IMSS_Q + "\IMSSQ", fs)
            _IMSS_SLIDEOUT_LIST.Enabled = True
            ' MessageBox.Show(MainMain.ix.ToString + " Moved To Quarantine Successfully", "IMSS Scan Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '  lstFile.Items.Clear()
            Label64.Text = ""
            ProgressBar1.Value = 0
        Else
            MessageBox.Show("Scan Manager is empty please scan first", "IMSS Scan Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        _IMSS_SCAN_COMPLETE = True
        MainMain._IMSS_CieckIfScanningRunning = False
        If lstFile.Items.Count > 0 Then
            Try
                ProgressBar1.Maximum = lstFile.Items.Count()
                MainMain._IMSS_Delete_BackgroundWorker.RunWorkerAsync()
            Catch ex As Exception
                Label34.Text = ""
                ProgressBar1.Value = 0
                MessageBox.Show("Please Select a USB Driver !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End Try
        Else
            MessageBox.Show("Scan Manager is empty please scan first", "IMSS Scan Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub IMSS_USBScanCotrolsUint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub _IMSS_USB_CONTROLS_PANEL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_USB_CONTROLS_PANEL.Click
        For Each _IMSS_CONTROLS As IMSS_USB_DVICE In _IMSS_USB_CONTROLS_PANEL.Controls
            _IMSS_CONTROLS._IMSS_SELECTCONTROL = False
        Next _IMSS_CONTROLS
    End Sub
    Private Sub _IMSS_SET_SCAN_LOG(ByVal _IMSS_SCAN_TYPE_STATUS As String)
        _IMSS_SCANSTARTAT_Label.Text = Date.Now.ToString()
        _IMSS_SCAN_TYPE.Text = _IMSS_SCAN_TYPE_STATUS
    End Sub
    Private Sub _IMSS_DEEP_SCAN_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DEEP_SCAN_Button.Click
        _IMSS_SET_SCAN_LOG("DEEP SCAN")
        _IMSS_SCAN(True)
    End Sub

    Private Sub _IMSS_FAST_SCAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_FAST_SCAN.Click
        _IMSS_SET_SCAN_LOG("FAST SCAN")
        _IMSS_SCAN(False)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        _IMSS_BACK()
    End Sub
    Private Sub _IMSS_BACK()
        '   On Error Resume Next
        _IMSS_SCAN_COMPLETE = False
        If _IMSS_SCANER.IsBusy = True Then _IMSS_SCANER.CancelAsync()
        _IMSS_COMPELET_PROCESS_OR_NOT = True
        _IMSS_TARGET_NAME = String.Empty
        For Each _IMSS_CONTROLS As IMSS_USB_DVICE In _IMSS_USB_CONTROLS_PANEL.Controls
            _IMSS_CONTROLS._IMSS_SELECTCONTROL = False
        Next
        _IMSS_LIST_OUT_PUT_Panel.Height = 308
        _IMSS_SLIDEOUT.Enabled = True
    End Sub
    Private Sub _IMSS_SETUP_THE_SCAN()
        MainMain.PictureBox29.Visible = True
        MainMain.PictureBox29.Enabled = True
        MainMain._IMSS_CieckIfScanningRunning = True
        Button49.Enabled = False
        Button9.Enabled = False
        Button8.Enabled = False
        lstFile.ForeColor = Color.Red
        'lstFile.Height = 179
        lstFile.Items.Clear()
        ProgressBar1.Value = 0
        lstFile.CheckBoxes = True
        'If _IMSS_AR = True Then
        '    Label34.Text = "يبحث"
        '    Label64.Text = "تحضير..."
        'ElseIf _IMSS_FR = True Then

        'ElseIf _IMSS_RS = True Then

        'ElseIf _IMSS_ES = True Then
        'Else
        Label34.Text = "Scanning"
        Label64.Text = "Prepering..."
        'End If
    End Sub
    Private _IMSS_NuberOfFilesFounds As Integer = 0
    Private Sub _IMSS_SCAN(ByVal _IMSS_DEEPSCANORNOT As Boolean)
        ConfigurationResureses.LinkVar._IMSS_DEEPSCANORNOT_ = _IMSS_DEEPSCANORNOT
        If Len(_IMSS_TARGET_NAME) > 0 Then _IMSS_TARGET_NAME = String.Empty
        For Each _IMSS_CONTROLS As IMSS_USB_DVICE In _IMSS_USB_CONTROLS_PANEL.Controls
            If _IMSS_CONTROLS.BorderStyle = Windows.Forms.BorderStyle.Fixed3D Then
                _IMSS_TARGET_NAME = _IMSS_CONTROLS._IMSS_TARGET_DRIVE_TEXT
            End If
        Next
        If Not String.IsNullOrEmpty(_IMSS_TARGET_NAME) Then
            My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
            _IMSS_TARGET_Label.Text = _IMSS_TARGET_NAME
            _IMSS_SETUP_THE_SCAN()
            If _IMSS_DEEPSCANORNOT = True Then
                For Each foundFileXX As String In Directory.GetFiles(_IMSS_TARGET_NAME, "*.*", SearchOption.AllDirectories)
                    _IMSS_NuberOfFilesFounds += 1
                Next
                For Each foundFileXX As String In Directory.GetDirectories(_IMSS_TARGET_NAME, "*.*", SearchOption.AllDirectories)
                    _IMSS_NuberOfFilesFounds += 1
                Next
            Else
                For Each foundFileXX As String In Directory.GetFiles(_IMSS_TARGET_NAME, "*.*", SearchOption.TopDirectoryOnly)
                    _IMSS_NuberOfFilesFounds += 1
                Next
                For Each foundFileXX As String In Directory.GetDirectories(_IMSS_TARGET_NAME, "*.*", SearchOption.TopDirectoryOnly)
                    _IMSS_NuberOfFilesFounds += 1
                Next
            End If
            ProgressBar1.Maximum = _IMSS_NuberOfFilesFounds
            _IMSS_NuberOfFilesFounds = 0
            _IMSS_SLIDEIN.Enabled = True
            _IMSS_SCANER.RunWorkerAsync()
            MainMain.PictureBox29.Visible = False
            MainMain.PictureBox29.Enabled = False
        Else
            MessageBox.Show("Please Select a USB Driver !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Public Shared _IMSS_CodesRed As New List(Of String)
    Public Shared _IMSS_COMPELET_PROCESS_OR_NOT As Boolean = True
    Public Shared _IMSS_SCAN_COMPLETE As Boolean = False
    Private Sub _IMSS_SCAN_PROCESS(ByVal _IMSS_TARGET As String)
        On Error Resume Next
        Dim _IMSS_GetFileInfo As FileInfo
        Dim _IMSS_SEARECHER As SearchOption
        Dim _IMSS_TARGET_FOUNDS(3) As String
        Dim _IMSS_HIGHT_TARGET_FOUNDS(3) As String
        Dim itm As ListViewItem
        Dim fi As FileInfo
        _IMSS_SCAN_COMPLETE = True
        Me.lstFile.Items.Clear()
        For Each foundFile As String In Directory.GetFiles(_IMSS_TARGET, "*.*", SearchOption.TopDirectoryOnly)
            If Not _IMSS_COMPELET_PROCESS_OR_NOT = True Then Exit Sub
            Label64.Text = "SCAN:> " + foundFile.ToString()
            fi = New FileInfo(foundFile)
            If fi.Extension = ".exe" Or fi.Extension = ".scr" Or fi.Extension = (".bif") _
               Or fi.Extension = (".com") Or fi.Extension = (".bat") _
               Or fi.Extension = (".cmd") Or fi.Extension = (".shs") Then
                If fi.Length < 1048576 Then
                    lstFile.ForeColor = Color.Red
                    lstFile.Font = New Font(Me.lstFile.Font, FontStyle.Bold)
                    _IMSS_SetInfectionType(_IMSS_TARGET_FOUNDS, fi, "APPL", 0)
                End If
            ElseIf fi.Extension = ".ini" Or fi.Extension = ".inf" Then
                _IMSS_SetInfectionType(_IMSS_TARGET_FOUNDS, fi, "AUTO", 1)
            ElseIf fi.Extension = ".lnk" Then
                _IMSS_SetInfectionType(_IMSS_TARGET_FOUNDS, fi, "LNIK", 3)
            End If
        Next
        If ConfigurationResureses.LinkVar._IMSS_DEEPSCANORNOT_ = True Then _IMSS_SEARECHER = SearchOption.AllDirectories Else _IMSS_SEARECHER = SearchOption.TopDirectoryOnly
        For Each foundFileXX As String In Directory.GetDirectories(_IMSS_TARGET, "*.*", _IMSS_SEARECHER)
            If Not _IMSS_COMPELET_PROCESS_OR_NOT = True Then Exit Sub
            IO.File.SetAttributes(foundFileXX, FileAttributes.Normal)
            Label64.Text = "SCAN:> " + foundFileXX.ToString()
            _IMSS_NuberOfFilesFounds += 1
            _IMSS_SCANER.ReportProgress(_IMSS_NuberOfFilesFounds)
        Next
        For Each foundFile As String In Directory.GetFiles(_IMSS_TARGET, "*.*", _IMSS_SEARECHER)
            If Not _IMSS_COMPELET_PROCESS_OR_NOT = True Then Exit Sub
            _IMSS_GetFileInfo = New FileInfo(foundFile)
            Label64.Text = "SCAN:> " + foundFile.ToString
            If _IMSS_CodesRed.Contains(ConfigurationResureses._IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_GetFileInfo.FullName.ToString)) = True Then
                For _IMSS_Items As Integer = 0 To Me.lstFile.Items.Count - 1
                    If Not Me.lstFile.Items(_IMSS_Items).Text.ToString.Contains(_IMSS_GetFileInfo.FullName) = True Then
                        _IMSS_HIGHT_TARGET_FOUNDS(0) = _IMSS_GetFileInfo.FullName
                        _IMSS_HIGHT_TARGET_FOUNDS(1) = _IMSS_FileSize(_IMSS_GetFileInfo.Length)
                        _IMSS_HIGHT_TARGET_FOUNDS(2) = "Virus"
                        itm = New ListViewItem(_IMSS_HIGHT_TARGET_FOUNDS)
                        itm.ImageIndex = 3
                        Me.lstFile.Items.Add(itm)
                    End If
                Next
            End If
            IO.File.SetAttributes(foundFile, FileAttributes.Normal)
            _IMSS_NuberOfFilesFounds += 1
            _IMSS_SCANER.ReportProgress(_IMSS_NuberOfFilesFounds)
        Next
        Label64.Text = ""
        _IMSS_SCANER.ReportProgress(0)
    End Sub
    Private Sub _IMSS_SetInfectionType(ByVal _IMSS_StatusType() As String, ByVal _IMSS_NewFileInfo As FileInfo, ByVal _IMSS_DefenssesType As String, _
                                            ByVal _IMSS_ItemImageTypeIndex As Integer)
        Dim itm As ListViewItem
        _IMSS_StatusType(0) = _IMSS_NewFileInfo.FullName
        _IMSS_StatusType(1) = _IMSS_FileSize(_IMSS_NewFileInfo.Length)
        If _IMSS_DefenssesType = "APPL" Then
            _IMSS_ItemImageTypeIndex = 0
            'If _IMSS_AR = True Then
            '    _IMSS_StatusType(2) = "خطير جدا"
            'Else
            _IMSS_StatusType(2) = "High Risk"
            'End If
        ElseIf _IMSS_DefenssesType = "AUTO" Then
        _IMSS_ItemImageTypeIndex = 2
            'If _IMSS_AR = True Then
            '    _IMSS_StatusType(2) = "متوسط الخطورة"
            'Else
            _IMSS_StatusType(2) = "Medium Risk"
            'End If
        ElseIf _IMSS_DefenssesType = "LNIK" Then
        _IMSS_ItemImageTypeIndex = 3
            'If _IMSS_AR = True Then
            '    _IMSS_StatusType(2) = "خطير"
            'Else
            _IMSS_StatusType(2) = "Risky"
            'End If
        End If
        itm = New ListViewItem(_IMSS_StatusType)
        itm.ImageIndex = _IMSS_ItemImageTypeIndex
        Me.lstFile.Items.Add(itm)
    End Sub
    Private Function _IMSS_FileSize(ByVal mySize As Single) As String
        Try
            Select Case mySize
                Case 0 To 1023
                    Return mySize & " Bytes"

                Case 1024 To 1048575
                    Return Format(mySize / 1024, "###0.00") & " KB"

                Case 1048576 To 1043741824
                    Return Format(mySize / 1024 ^ 2, "###0.00") & " MB"

                Case Is > 1043741824
                    Return Format(mySize / 1024 ^ 3, "###0.00") & " GB"
            End Select
            Return "0 Bytes"
        Catch ex As Exception
            Return "0 Bytes"
        End Try
    End Function
    Private Sub _IMSS_SCANER_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_SCANER.DoWork
        _IMSS_SCAN_PROCESS(_IMSS_TARGET_NAME)
    End Sub

    Private Sub _IMSS_SCANER_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles _IMSS_SCANER.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub _IMSS_SCANER_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSS_SCANER.RunWorkerCompleted
        On Error Resume Next
        For i = 0 To Me.lstFile.Items.Count - 1
            If Not Me.lstFile.Items(i).Checked = True Then
                Me.lstFile.Items(i).Checked = True
            End If
        Next
        If Me.lstFile.Items.Count > 0 Then
            Label34.ForeColor = Color.Red
            Me.lstFile.ForeColor = Color.Red
            'If _IMSS_AR = True Then
            '    Label34.Text = Me.lstFile.Items.Count.ToString() + " وجد"
            'ElseIf _IMSS_FR = True Then

            'ElseIf _IMSS_RS = True Then

            'ElseIf _IMSS_ES = True Then
            'Else
            Label34.Text = "Found " + Me.lstFile.Items.Count.ToString()
            'End If
            Button49.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            MessageBox.Show("Scan Results : " + Me.lstFile.Items.Count.ToString() + " threat were detected ", "IMSS Scan Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'If _IMSS_AR = True Then
            '    Label34.ForeColor = Color.Green
            '    Label34.Text = "لا يوجد"
            'ElseIf _IMSS_FR = True Then

            'ElseIf _IMSS_RS = True Then

            'ElseIf _IMSS_ES = True Then
            'Else
            Label34.ForeColor = Color.Green
            Label34.Text = "None"
            'End If
            Label64.Text = ""
            ProgressBar1.Value = 0
            'Me.lstFile.Height = 200
            Button8.Enabled = True
            MessageBox.Show("Scan Results : No threats were detected ", "IMSS Scan Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Label64.Text = "Done ...100%"
    End Sub

    Private Sub _IMSS_SLIDE_WIRKER_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        MsgBox(True)
    End Sub

    Private Sub _IMSS_SLIDEOUT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SLIDEOUT.Tick
        If _IMSS_DVICES_FOUND_PANEL.Height >= 352 Then
            _IMSS_SLIDEOUT.Enabled = False
        End If
        _IMSS_DVICES_FOUND_PANEL.Height += 20
    End Sub

    Private Sub _IMSS_SLIDEIN_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SLIDEIN.Tick
        If _IMSS_DVICES_FOUND_PANEL.Height <= 0 Then
            _IMSS_SLIDEIN.Enabled = False
        End If
        _IMSS_DVICES_FOUND_PANEL.Height -= 20
    End Sub

    Private Sub _IMSS_SLIDEOUT_LIST_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SLIDEOUT_LIST.Tick
        If _IMSS_LIST_OUT_PUT_Panel.Height <= 0 Then
            _IMSS_LIST_OUT_PUT_Panel.Height = 0
            _IMSS_SLIDEOUT_LIST.Enabled = False
        End If
        _IMSS_LIST_OUT_PUT_Panel.Height -= 10
    End Sub

    'Private Sub _IMSS_SLIDEIN_LIST_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SLIDEIN_LIST.Tick
    '    If _IMSS_LIST_OUT_PUT_Panel.Height >= 308 Then
    '        _IMSS_LIST_OUT_PUT_Panel.Height = 308
    '        _IMSS_SLIDEIN_LIST.Enabled = False
    '    End If
    '    _IMSS_LIST_OUT_PUT_Panel.Height += 10
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _IMSS_BACK()
    End Sub
End Class
