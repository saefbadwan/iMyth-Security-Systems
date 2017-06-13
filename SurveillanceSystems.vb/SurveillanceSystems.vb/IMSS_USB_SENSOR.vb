' بسم الله الرحمن الرحيم

Imports System.IO
Imports System.Diagnostics
Imports System.Security.Permissions
Imports System.Runtime.InteropServices
Imports ComponentOwl.BetterListView
Imports System.Drawing
Imports System.Windows.Forms

Public Class IMSS_USB_SENSOR


    Private _IMSS_SOUND_STATUS As Boolean = True

    Public Sub New(ByVal IMSS_SOUND_STATUS As Boolean)

        _IMSS_SOUND_STATUS = IMSS_SOUND_STATUS

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
            Me.Hide()
            _IMSS_SET_SYSTEMSOUNDS_STATUS = True
            PictureBox29.Enabled = False
            For Each lsvitms As BetterListViewItem In lstFile.Items
                Try
                    _IMSS_CHECK_ITEM_TYPE(lsvitms.SubItems(1).Text)
                Catch
                    System.Threading.Thread.Sleep(400)
                End Try
            Next
            ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("USB Monitor : " + Date.Now.ToString + " :##:> " + lstFile.Items.Count.ToString() + " Files has been Deleted", 2)
            lstFile.Items.Clear()
            PictureBox29.Enabled = False
        Catch : End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
            Me.Hide()
            PictureBox29.Enabled = False
            ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("USB Monitor : " + Date.Now.ToString + " :##:> " + lstFile.Items.Count.ToString() + " Files has been Allowed ", 2)
            lstFile.Items.Clear()
        Catch : End Try
        _IMSS_SET_SYSTEMSOUNDS_STATUS = True
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(ConfigurationResureses.LinkVar._IMSS_USBMonitorHelpPage)
    End Sub
    Private Sub lstFile_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs)
        On Error Resume Next
        e.Cancel = True
        e.NewWidth = lstFile.Columns(e.ColumnIndex).Width
    End Sub
    Private _IMSS_Get_FileInfo As FileInfo
    Private Sub OpenFileLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileLocationToolStripMenuItem.Click
        Try
            Process.Start(Path.GetDirectoryName(lstFile.SelectedItems(0).SubItems(1).Text))
        Catch : End Try
    End Sub

    Private Sub _IMSS_MainLogo_PicitureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _IMSS_MainLogo_PicitureBox.MouseDown
        _IMSS_MainLogo_PicitureBox.Image = My.Resources.IMSS_System_Mointor_Logo_Title
    End Sub

    Private Sub _IMSS_MainLogo_PicitureBox_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MainLogo_PicitureBox.MouseEnter
        _IMSS_MainLogo_PicitureBox.Image = My.Resources.IMSS_Monitors_BackGroundOnMuseOver
    End Sub

    Private Sub _IMSS_MainLogo_PicitureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_MainLogo_PicitureBox.MouseLeave
        _IMSS_MainLogo_PicitureBox.Image = My.Resources.IMSS_System_Mointor_Logo_Title
    End Sub

#Region "IMSS DETECTE USB DOSCONNECT"
    Private Enum WM_DEVICECHANGE_WPPARAMS As Integer
        DBT_DEVICEARRIVAL = &H8000
        DBT_DEVICEREMOVECOMPLETE = &H8004
    End Enum
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        On Error Resume Next
        If m.Msg = WM_DEVICECHANGE Then
            If m.WParam = WM_DEVICECHANGE_WPPARAMS.DBT_DEVICEREMOVECOMPLETE Then
                If IO.Directory.Exists(_IMSS_TARGET_DRIVE_STATUS) = False Then
                    Me.Close()
                End If
            End If
        End If
        MyBase.WndProc(m)
    End Sub
#End Region

    Private WM_DEVICECHANGE As Integer = &H219
    Private _IMSS_SET_SYSTEMSOUNDS_STATUS As Boolean = True
    Private Function _IMSS_CheckIfItemIsExists(ByVal _IMSS_TARGET As String) As Boolean
        For Each _IMSS_ITEM In Me.lstFile.Items
            If _IMSS_ITEM.Text = _IMSS_TARGET Then
                Return True
            End If
        Next : Return False
    End Function
    Private Sub _IMSS_USB_SENSOR_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles _IMSS_USB_SENSOR.Created
        Try
            Application.DoEvents()
            Dim _info As New FileInfo(e.FullPath)
            Dim _IMSS_FileName As String = IO.Path.GetFileName(e.FullPath)
            If _IMSS_CheckIfItemIsExists(_IMSS_FileName) = False Then
                If Not _info.Extension = ".temp" And Not _info.Extension = ".tmp" Then
                    With Me.lstFile.Items.Add(_IMSS_FileName)
                        .ImageIndex = ConfigurationResureses.LinkVar._IMSS_SetSubIconForItems(IO.Path.GetExtension(e.FullPath))
                        .SubItems.Add(e.FullPath)
                    End With
                    If Me.lstFile.Items.Count > 0 Then : Me.Show() : Me.Activate()
                        If _IMSS_SET_SYSTEMSOUNDS_STATUS = True Then
                            If _IMSS_SOUND_STATUS = True Then
                                My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_CLEAR_SCAN, AudioPlayMode.Background)
                            End If
                            _IMSS_SET_SYSTEMSOUNDS_STATUS = False
                        End If
                    Else : Me.Hide()
                        _IMSS_SET_SYSTEMSOUNDS_STATUS = True
                    End If
                End If
            End If
        Catch : End Try
    End Sub
    Private _IMSS_TARGET_DRIVE_STATUS As String = String.Empty
    Public Sub _IMSS_START_SENSOR_SYSTEMS(ByVal _IMSS_TARGET_DRIVE As String)
        Me.Hide()
        If Not IO.Directory.Exists(_IMSS_TARGET_DRIVE) = True Then
            Me.Dispose()
            Exit Sub
        End If
        ConfigurationResureses.LinkVar._IMSS_PutLocations(Me)
        PictureBox29.Enabled = True
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        Me.ShowInTaskbar = True
        Me.Opacity = 100%
        _IMSS_TARGET_DRIVE_STATUS = _IMSS_TARGET_DRIVE
        With _IMSS_USB_SENSOR
            If .EnableRaisingEvents = True Then .EnableRaisingEvents = False
            .InternalBufferSize = 39000
            .Path = _IMSS_TARGET_DRIVE
            .EnableRaisingEvents = True
        End With
    End Sub
    Private Sub _IMSS_CHECK_ITEM_TYPE(ByVal _IMSS_STATUS_NAME As String)
        On Error Resume Next
        If IO.File.Exists(_IMSS_STATUS_NAME) = True Then : IO.File.Delete(_IMSS_STATUS_NAME)
        ElseIf IO.Directory.Exists(_IMSS_STATUS_NAME) = True Then : IO.Directory.Delete(_IMSS_STATUS_NAME)
        Else ' ERORR
        End If
    End Sub

    Private Sub UsbMointor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        _IMSS_USB_SENSOR.EnableRaisingEvents = False
    End Sub

    Private Sub _IMSS_Get_FileLocation_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _IMSS_Get_FileLocation.Opening
        If Me.lstFile.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub
    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        _IMSS_Properties((Me.lstFile.SelectedItems(0).SubItems(1).Text))
    End Sub
    Private Sub _IMSS_Properties(ByRef _IMSS_TARGET As String)
        On Error GoTo _IMSS_ON_ERROR
        Dim sei As New SHELLEXECUTEINFO
        sei.cbSize = Marshal.SizeOf(sei)
        sei.lpVerb = "properties"
        sei.lpFile = _IMSS_TARGET
        sei.nShow = SW_SHOW
        sei.fMask = SEE_MASK_INVOKEIDLIST
        If Not ShellExecuteEx(sei) Then
            Dim ex As New System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error())
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
_IMSS_ON_ERROR:
        ' MessageBox.Show("Pleas select item to show it's propertis !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub ScanOnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanOnlineToolStripMenuItem.Click
        Dim _IMSS_SCAN_UINT As New IMSS_SCAN_UINT(Me.lstFile.SelectedItems(0).SubItems(1).Text)
        _IMSS_SCAN_UINT.ShowDialog()
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        Try : If IO.File.Exists((Me.lstFile.SelectedItems(0).SubItems(1).Text)) = True Then IO.File.Delete((Me.lstFile.SelectedItems(0).SubItems(1).Text))
            Me.lstFile.SelectedItems(0).Remove()
            If Me.lstFile.Items.Count = 0 Then
                Try
                    Me.Hide()
                    PictureBox29.Enabled = False
                    lstFile.Items.Clear()
                Catch : End Try
                _IMSS_SET_SYSTEMSOUNDS_STATUS = True
            End If
        Catch : End Try
    End Sub



    Private Sub _IMSS_AnalyzeBehaviour_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AnalyzeBehaviour_Button.Click

        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)

        Dim _IMSS_LIST_OF_FILES_TARGETS As New List(Of String)

        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\iMyth Security Systems\AnalyzeBehaviour.exe") Then
            If lstFile.Items.Count() > 0 Then
                Dim _IMSS_ARGUMENT As String = String.Empty
                Dim _IMSS_EXEC_EXTNSIONS As String = ".exe,.bat,.scr,.pif,.com,.cmd,.vb,.vbs,.vbe,.shb"
                For Each _IMSS_FILE In lstFile.Items

                    If _IMSS_EXEC_EXTNSIONS.Contains(IO.Path.GetExtension(_IMSS_FILE.SubItems(1).Text)) Or _IMSS_EXEC_EXTNSIONS.ToUpper().Contains(IO.Path.GetExtension(_IMSS_FILE.SubItems(1).Text)) Then

                        If Not _IMSS_LIST_OF_FILES_TARGETS.Contains(_IMSS_FILE.SubItems(1).Text) Then

                            _IMSS_ARGUMENT += _IMSS_FILE.SubItems(1).Text & "|"

                            _IMSS_LIST_OF_FILES_TARGETS.Add(_IMSS_FILE.SubItems(1).Text)

                        End If

                    End If

                    If (".lnk,.LNK").Contains(IO.Path.GetExtension(_IMSS_FILE.SubItems(1).Text)) = True Then

                        If _IMSS_EXEC_EXTNSIONS.Contains(_IMSS_GET_SHORTCUT_TARGET(_IMSS_FILE.SubItems(1).Text)) Then

                            Dim _IMSS_SHORTCUT_INFO As String = _IMSS_GET_SHORTCUT_TARGET(_IMSS_FILE.SubItems(1).Text)

                            If Not _IMSS_LIST_OF_FILES_TARGETS.Contains(_IMSS_SHORTCUT_INFO) Then

                                _IMSS_ARGUMENT += _IMSS_SHORTCUT_INFO & "|"

                                _IMSS_LIST_OF_FILES_TARGETS.Add(_IMSS_SHORTCUT_INFO)

                            End If

                        End If

                    End If

                Next _IMSS_FILE

                ConfigurationResureses.LinkVar._IMSS_START_AS(New String() {Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\iMyth Security Systems\AnalyzeBehaviour.exe", _IMSS_ARGUMENT.Replace(" ", "*")})

                _IMSS_LIST_OF_FILES_TARGETS.Clear()

            Else
                MessageBox.Show("Please select files that you want to analyze ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Else
            MessageBox.Show("The main ""IMSS Analyze Behaviour Engine"" is not found ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Function _IMSS_GET_SHORTCUT_TARGET(ByVal _IMSS_FILE_TAREGT As String) As String
        Dim Obj As Object = CreateObject("WScript.Shell")
        Return Obj.CreateShortcut(_IMSS_FILE_TAREGT).TargetPath().ToString()
    End Function

End Class