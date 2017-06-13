'بسم الله ابدأ
'يا رب يا الله يا رحيم يا عظيم يا كريم جل جلالك بأسمائك يا الله وفقني برحمتك

Imports System.Threading
Imports System.Windows.Forms
Imports System.Drawing

Public Class USBScan

#Region "IMSS Private Declration"
    Private _IMSS_USB_TARGET As String = String.Empty
    Private Delegate Sub _IMSS_ON_TARGETSCAN_COMPLETE_DELEGATE(ByVal _IMSS_DETECTION_RESULT As Boolean, ByRef _IMSS_THREAT_RESULT As List(Of ListViewItem))
    Private _IMSS_LOCATION_Y As Integer = 0
    Private _IMSS_SCAN_MODE As Boolean = False
#End Region


    Public Sub New(ByVal IMSS_USB_TARGET As String, ByVal IMSS_SCAN_MODE As Boolean)

        _IMSS_SCAN_MODE = IMSS_SCAN_MODE

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If Not (String.IsNullOrEmpty(IMSS_USB_TARGET)) And IO.Directory.Exists(IMSS_USB_TARGET) And New IO.DriveInfo(IMSS_USB_TARGET).IsReady = True Then
            _IMSS_USB_TARGET = IMSS_USB_TARGET
        Else
            Me.Close()
        End If

        _IMSS_LOAD_FORM(_IMSS_USB_TARGET)

        Dim _IMSS_THREAD As New Thread(AddressOf _IMSS_SCAN_TARGET) : _IMSS_THREAD.Start()

    End Sub

    Private Sub _IMSS_LOAD_FORM(ByVal _IMSS_USB_TARGET As String)
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        _IMSS_LOCATION_Y = Me.Location.Y
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 164)
        Dim margins As SubThems.MARGINS = New SubThems.MARGINS
        With margins
            .cxLeftWidth = -1
            .cxRightWidth = -1
            .cyTopHeight = -1
            .cyButtomheight = -1
        End With
        Dim hwnd As IntPtr = Me.Handle
        Dim result As Integer = SubThems.DwmExtendFrameIntoClientArea(hwnd, margins)
        Label4.Text = _IMSS_USB_TARGET
        Me.Show()
        'My.Computer.Audio.Play(My.Resources.IMSSClear, AudioPlayMode.Background)
        Do Until Me.Location.Y <= _IMSS_LOCATION_Y - 40
            System.Threading.Thread.Sleep(10)
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 10)
            Application.DoEvents()
        Loop
        For i = 0 To 20 Step 1
            System.Threading.Thread.Sleep(4)
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 2)
            Application.DoEvents()
        Next i

        Me.Refresh() : Me.Activate()

    End Sub


    Private Sub _IMSS_SCAN_TARGET()

        ' Create local var.

        Dim _IMSS_DETECTION_RESULT As Boolean = False
        Dim _IMSS_THREAT_RESULT As New List(Of ListViewItem)


        ' Check the target if it's running.

        If Not IO.Directory.Exists(_IMSS_USB_TARGET) = True Then GoTo _IMSS_ON_ERROR



        ' Get all the sub file's.

        For Each _IMSS_TAREGT_FILE As String In IO.Directory.GetFiles(_IMSS_USB_TARGET, "*.*", IO.SearchOption.TopDirectoryOnly)



            Dim _IMSS_IO_TARGET_EXTENSION As String = IO.Path.GetExtension(_IMSS_TAREGT_FILE)


            ' Check Files for threats.

            If ((".inf,.ini").Contains(_IMSS_IO_TARGET_EXTENSION)) = True Or ((".inf,.ini").Contains(_IMSS_IO_TARGET_EXTENSION)) = True Then


                _IMSS_THREAT_RESULT.Add(_IMSS_ADD_TO_LIST_OFTARGETS(_IMSS_TAREGT_FILE, "USB-Autorun.Trojan"))

            ElseIf (".exe,.vb,.vbs,.com,.bat,.scr,.msi,.shb,.ws,.wsf,.pif,.paf,.cmd,.gadget,.bin").Contains(_IMSS_IO_TARGET_EXTENSION) = True _
                Or (".exe,.vb,.vbs,.com,.bat,.scr,.msi,.shb,.ws,.wsf,.pif,.paf,.cmd,.gadget,.bin").ToUpper().Contains(_IMSS_IO_TARGET_EXTENSION) Then

                Dim _IMSS_GET_FILE_INFO As New IO.FileInfo(_IMSS_TAREGT_FILE)

                If _IMSS_GET_FILE_INFO.Length < 2143471 Then

                    _IMSS_THREAT_RESULT.Add(_IMSS_ADD_TO_LIST_OFTARGETS(_IMSS_TAREGT_FILE, "USB-RAT.W0rm"))

                End If

            ElseIf ((".lnk,.LNK").Contains(_IMSS_IO_TARGET_EXTENSION)) Then

                Dim _IMSS_SHORTCUT_INFO As String = _IMSS_GET_SHORTCUT_TARGET(_IMSS_TAREGT_FILE)

                If _IMSS_SHORTCUT_INFO.Contains("cmd.exe") Or _IMSS_SHORTCUT_INFO.Contains("CMD.exe") _
                    Or _IMSS_SHORTCUT_INFO.Contains("&start") Or _IMSS_SHORTCUT_INFO.Contains(("&START")) _
                    Or _IMSS_SHORTCUT_INFO.Contains("& start") Or _IMSS_SHORTCUT_INFO.Contains("& START") _
                    Or _IMSS_SHORTCUT_INFO.Contains(" & start") Or _IMSS_SHORTCUT_INFO.Contains(" & START") _
                    Or _IMSS_SHORTCUT_INFO.Contains("/C START") Then


                    _IMSS_THREAT_RESULT.Add(_IMSS_ADD_TO_LIST_OFTARGETS(_IMSS_TAREGT_FILE, "USB-RATW0rm.Trigger"))

                End If

            End If


            ' Set attrib for the target.

            IO.File.SetAttributes(_IMSS_TAREGT_FILE, IO.FileAttributes.Normal)

        Next _IMSS_TAREGT_FILE


        For Each _IMSS_TAREGT_FILE As String In IO.Directory.GetDirectories(_IMSS_USB_TARGET, "*.*", IO.SearchOption.TopDirectoryOnly)

            ' Set attrib for the target folder.

            Dim _IMSS_DIR_INFO As New IO.DirectoryInfo(_IMSS_TAREGT_FILE)

            If Not _IMSS_DIR_INFO.FullName.Contains("Autorun.inf") And Not _IMSS_DIR_INFO.FullName.Contains("PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}") = True Then

                _IMSS_DIR_INFO.Attributes = IO.FileAttributes.Normal

            End If

        Next _IMSS_TAREGT_FILE


        ' Check the result.

        If _IMSS_THREAT_RESULT.Count() > 0 Then

            _IMSS_DETECTION_RESULT = True

        End If

_IMSS_ON_ERROR:

        ' Invoke the result to UI

        Invoke(New _IMSS_ON_TARGETSCAN_COMPLETE_DELEGATE(AddressOf _IMSS_ON_TARGETSCAN_COMPLETE), _IMSS_DETECTION_RESULT, _IMSS_THREAT_RESULT)

    End Sub

    Private Sub _IMSS_ON_TARGETSCAN_COMPLETE(ByVal _IMSS_DETECTION_RESULT As Boolean, ByRef _IMSS_THREAT_RESULT As List(Of ListViewItem))

        _IMSS_SLIDE_OUT()

        If _IMSS_DETECTION_RESULT = True Then

            ' Create local var ref for the list to pass it in lmbda exprtions

            Dim IMSS_THREAT_RESULT As List(Of ListViewItem) = _IMSS_THREAT_RESULT

            ' Run the scan manager from anthor thrad becuse this thread will exit

            Dim _IMSS_SCANMANGER As New ScanManager(IMSS_THREAT_RESULT, _IMSS_USB_TARGET, _IMSS_SCAN_MODE) : _IMSS_SCANMANGER.Show()

        Else
            Dim _IMSS_RESULT As New CleanResult(_IMSS_USB_TARGET) : _IMSS_RESULT.Show()
        End If

        Me.Close()

    End Sub

    Private Sub _IMSS_SLIDE_OUT()

        For i = 0 To 264 Step 1
            '  System.Threading.Thread.Sleep(1)
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 1)
            Application.DoEvents()
        Next i

        Me.Hide()

    End Sub

#Region "IMSS Sub Function Declration"
    Private Function _IMSS_GET_SHORTCUT_TARGET(ByVal _IMSS_FILE_TAREGT As String) As String
        Dim Obj As Object = CreateObject("WScript.Shell")
        Return Obj.CreateShortcut(_IMSS_FILE_TAREGT).TargetPath().ToString()
    End Function

    Private Function _IMSS_ADD_TO_LIST_OFTARGETS(ByVal _IMSS_TARGET_ITEM As String, ByVal _IMSS_TARGET_STATUS As String) As ListViewItem
        Dim _IMSS_TARGET_THREAT_INFO As New ListViewItem
        With _IMSS_TARGET_THREAT_INFO
            .Text = IO.Path.GetFileName(_IMSS_TARGET_ITEM)
            .Tag = _IMSS_TARGET_ITEM
            .ImageIndex = 0
            .Checked = True
            .UseItemStyleForSubItems = False
            .SubItems.Add(_IMSS_TARGET_STATUS).ForeColor = Color.Red
        End With
        Return _IMSS_TARGET_THREAT_INFO
    End Function
    Private Function _IMSS_CheckFileAndGetLenth(ByVal _IMSS_FILE_PATH As String) As Long
        Try
            If IO.File.Exists(_IMSS_FILE_PATH) Then
                Return New IO.FileInfo(_IMSS_FILE_PATH).Length
            Else
                Return 4000000
            End If
        Catch
            Return 4000000
        End Try
    End Function
#End Region

End Class