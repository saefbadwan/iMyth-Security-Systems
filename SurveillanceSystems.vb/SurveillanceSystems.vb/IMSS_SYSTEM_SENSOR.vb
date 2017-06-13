'بسم الله الرحمن الرحيم

Imports System.Windows.Forms
Imports System.Drawing
Imports ComponentOwl.BetterListView
Imports System.IO
Imports System.Runtime.InteropServices

Public Class IMSS_SYSTEM_SENSOR

    Private _IMSS_USB_TARGET_HASES As New Dictionary(Of String, String)
    Private _IMSS_LOCAL_EXTENSION As String = ".exe,.bat,.scr,.pif,.com,.cmd,.vbs,.vbe,.shb"
    Private _IMSS_SOUND_STATUS As Boolean = True
    Private _IMSS_ADMIN_DELETER As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
    Public Sub New(ByVal IMSS_SOUND_STATUS As Boolean)

        _IMSS_SOUND_STATUS = IMSS_SOUND_STATUS

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        With _IMSS_SYSTEM_SURV

            .Path = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3)

            .InternalBufferSize = 39000

            .EnableRaisingEvents = True

        End With


    End Sub


    ' Stop the surv systems

    Private Delegate Sub _IMSS_STOP_SURV_DELEGATE()

    Private Sub _IMSS_STOP_SURV()

        If Not (_IMSS_USB_TARGET_HASES.Count() > 1) = True Then

            With _IMSS_SYSTEM_SURV

                If .EnableRaisingEvents = True Then

                    .EnableRaisingEvents = False

                    _IMSS_USB_TARGET_HASES.Clear()

                End If

            End With

        End If

    End Sub

    ' For the user turn on , turn off the systems urv systems.

    Public Property _IMSS_ALLOW_SURV As Boolean = True


    ' Set montoer target.

    Public Sub _IMSS_SET_SURV(ByVal _IMSS_TARGET As String)

        With _IMSS_SYSTEM_SURV

            If .EnableRaisingEvents = False Then

                .EnableRaisingEvents = True

            End If

        End With

        Dim _IMSS_THREAD As New Threading.Thread(Sub()

                                                     Try

                                                         For Each _IMSS_USB_FILE_TARGET As String In IO.Directory.GetFiles(_IMSS_TARGET, "*.*", IO.SearchOption.AllDirectories)

                                                             If _IMSS_CHECK_TARGET_EXTENSION(IO.Path.GetExtension(_IMSS_USB_FILE_TARGET)) Then

                                                                 Dim _IMSS_USB_FILE_TARGET_HASHES As String = ConfigurationResureses._IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_USB_FILE_TARGET)

                                                                 If Not _IMSS_USB_TARGET_HASES.ContainsKey(_IMSS_USB_FILE_TARGET_HASHES) = True Then

                                                                     _IMSS_USB_TARGET_HASES.Add(_IMSS_USB_FILE_TARGET_HASHES, _IMSS_TARGET)

                                                                 End If

                                                             End If

                                                         Next _IMSS_USB_FILE_TARGET

                                                     Catch ' In case the target not avilable.
                                                         Exit Sub
                                                     End Try

                                                 End Sub) : _IMSS_THREAD.Start()

    End Sub

    ' Remove montoer target.

    Public Sub _IMSS_REMOVE_SURV(ByVal _IMSS_TARGET As String)

        Dim _IMSS_THREAD As New Threading.Thread(Sub()

                                                     _IMSS_RemoveByValue(_IMSS_USB_TARGET_HASES, _IMSS_TARGET)

                                                     Invoke(New _IMSS_STOP_SURV_DELEGATE(AddressOf _IMSS_STOP_SURV))

                                                 End Sub) : _IMSS_THREAD.Start()


    End Sub

    Private Sub _IMSS_RemoveByValue(ByRef dictionary As Dictionary(Of String, String), ByVal _IMSS_TARGET As String)
        Dim itemsToRemove As New List(Of KeyValuePair(Of String, String))

        For Each pair As KeyValuePair(Of String, String) In dictionary
            If pair.Value = _IMSS_TARGET Then
                itemsToRemove.Add(pair)
            End If
        Next

        For Each item As KeyValuePair(Of String, String) In itemsToRemove
                dictionary.Remove(item.Key)
        Next
    End Sub

    Private Sub _IMSS_SYSTEM_SURV_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles _IMSS_SYSTEM_SURV.Created

        Application.DoEvents()

        If _IMSS_ALLOW_SURV = True Then

            If _IMSS_CHECK_TARGET_EXTENSION(IO.Path.GetExtension(e.FullPath)) Then

                Dim _IMSS_THREAD As New Threading.Thread(Sub()

                                                             Do Until _IMSS_IsFileLocked(New IO.FileInfo(e.FullPath)) = False
                                                                 System.Threading.Thread.Sleep(400)
                                                             Loop

                                                             If (_IMSS_USB_TARGET_HASES.ContainsKey(ConfigurationResureses._IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(e.FullPath))) = True Then

                                                                 Invoke(New _IMSS_ADD_TARGETS_AND_SHOW_DELEGATE(AddressOf _IMSS_ADD_TARGETS_AND_SHOW), e.FullPath)

                                                             End If

                                                         End Sub) : _IMSS_THREAD.Start()


            End If

        End If

    End Sub

    Private Function _IMSS_IsFileLocked(ByVal file As FileInfo) As Boolean
        Dim stream As FileStream = Nothing

        Try
            stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None)
        Catch generatedExceptionName As IOException
            'the file is unavailable because it is:
            'still being written to
            'or being processed by another thread
            'or does not exist (has already been processed)
            Return True
        Finally
            If stream IsNot Nothing Then
                stream.Close()
            End If
        End Try

        'file is not locked
        Return False
    End Function

    Private Delegate Sub _IMSS_ADD_TARGETS_AND_SHOW_DELEGATE(ByVal _IMSS_TARGET_ITEM As String)
    Private Sub _IMSS_ADD_TARGETS_AND_SHOW(ByVal _IMSS_TARGET_ITEM As String)

        Dim _IMSS_TARGET_EXTENSION As String = IO.Path.GetExtension(_IMSS_TARGET_ITEM)

        With _IMSS_SURV_TARGETS.Items.Add(IO.Path.GetFileName(_IMSS_TARGET_ITEM))

            .ImageIndex = ConfigurationResureses.LinkVar._IMSS_SetSubIconForItems(_IMSS_TARGET_EXTENSION)
            .SubItems.Add(_IMSS_TARGET_EXTENSION)
            .SubItems.Add(_IMSS_TARGET_ITEM)

        End With


        If _IMSS_SOUND_STATUS = True Then
            My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_CLEAR_SCAN, AudioPlayMode.Background)
        End If

        Me.Show()

    End Sub

    Private Sub _IMSS_SYSTEM_SURV_Error(ByVal sender As Object, ByVal e As System.IO.ErrorEventArgs) Handles _IMSS_SYSTEM_SURV.Error

        With _IMSS_SYSTEM_SURV

            .EnableRaisingEvents = False

            .EnableRaisingEvents = True

        End With

    End Sub

    Private Function _IMSS_CHECK_TARGET_EXTENSION(ByVal _IMSS_EXTENSION As String)

        If (_IMSS_EXTENSION = ".exe") Or (_IMSS_EXTENSION.ToUpper() = ".EXE") _
                Or (_IMSS_EXTENSION = ".com") Or (_IMSS_EXTENSION.ToUpper() = ".COM") _
                Or (_IMSS_EXTENSION = ".scr") Or (_IMSS_EXTENSION.ToUpper() = ".SCR") _
                Or (_IMSS_EXTENSION = ".bat") Or (_IMSS_EXTENSION.ToUpper() = ".BAT") _
                Or (_IMSS_EXTENSION = ".cmd") Or (_IMSS_EXTENSION.ToUpper() = ".CMD") _
                Or (_IMSS_EXTENSION = ".vbs") Or (_IMSS_EXTENSION.ToUpper() = ".VBS") _
                Or (_IMSS_EXTENSION = ".vbe") Or (_IMSS_EXTENSION.ToUpper() = ".VBE") _
                Or (_IMSS_EXTENSION = ".shb") Or (_IMSS_EXTENSION.ToUpper() = ".SHB") Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub IMSS_SYSTEM_SENSOR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        Me.ShowInTaskbar = True
    End Sub

    Private Sub _IMSS_ALLOWACTION_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ALLOWACTION_BUTTON.Click

        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)

        Me.Hide()

        ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("System Monitor : " + Date.Now.ToString + " :##:> " + _IMSS_SURV_TARGETS.Items.Count().ToString() & " Files has been Allowed ", 1)

        Me._IMSS_SURV_TARGETS.Items.Clear()

        Me._IMSS_LOADING_PICTUREBOX.Enabled = False

    End Sub

    Private Sub _IMSS_STOPACTION_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_STOPACTION_BUTTON.Click

        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)

        Me.Hide()

        Me.ShowInTaskbar = False

        Dim _IMSS_ARGARRAY As String = String.Empty

        For Each _IMSS_TARGET_FILE As BetterListViewItem In _IMSS_SURV_TARGETS.Items

            _IMSS_ARGARRAY += """" & _IMSS_TARGET_FILE.SubItems(2).Text & """" & " "

        Next _IMSS_TARGET_FILE

        _IMSS_DELETE_AND_WRITETOLOG(_IMSS_ARGARRAY)

        Me._IMSS_SURV_TARGETS.Items.Clear()

        Me._IMSS_LOADING_PICTUREBOX.Enabled = False

    End Sub

    Private Sub _IMSS_DELETE_AND_WRITETOLOG(ByVal _IMSS_TARGETS As String)


        If IO.File.Exists(_IMSS_ADMIN_DELETER + "\_IMSS_CoreSys.exe") Then
            _IMSS_RUNAS_ADMIN_WITH_ARGUMENTS(_IMSS_ADMIN_DELETER + "\_IMSS_CoreSys.exe", _IMSS_TARGETS)
        Else
            IO.File.WriteAllBytes(_IMSS_ADMIN_DELETER + "\_IMSS_CoreSys.exe", My.Resources._IMSS_CoreSys)
            _IMSS_RUNAS_ADMIN_WITH_ARGUMENTS(_IMSS_ADMIN_DELETER + "\_IMSS_CoreSys.exe", _IMSS_TARGETS)
        End If

        ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("System Monitor : " + Date.Now.ToString + " :##:> " + _IMSS_SURV_TARGETS.Items.Count().ToString() & " Files has been Deleted ", 1)

    End Sub

    Private Sub _IMSS_Core_SysLogWirteOpre(ByVal Oper As String)
        Try
            If System.IO.File.Exists(_IMSS_ADMIN_DELETER + "\IMSS_SysCore.txt") = True Then
                Using sw As StreamWriter = File.AppendText(_IMSS_ADMIN_DELETER + "\IMSS_SysCore.txt") : sw.WriteLine(Oper) : End Using
            End If
        Catch : End Try
    End Sub
    Private Sub _IMSS_RUNAS_ADMIN_WITH_ARGUMENTS(ByVal _PluginFile As String, Optional ByVal _IMSS_ARGA As String = "")
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
            processStartInfo.Arguments = _IMSS_ARGA
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            processStartInfo.UseShellExecute = True
            Try
                process = System.Diagnostics.Process.Start(processStartInfo)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Not (process Is Nothing) Then
                    process.Dispose()
                End If
            End Try
        Catch : End Try
    End Sub

    Private Sub _IMSS_AnalyzeBehaviour_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AnalyzeBehaviour_Button.Click

        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)

        Dim _IMSS_LIST_OF_FILES_TARGETS As New List(Of String)

        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\iMyth Security Systems\AnalyzeBehaviour.exe") Then
            If _IMSS_SURV_TARGETS.Items.Count() > 0 Then
                Dim _IMSS_ARGUMENT As String = String.Empty
                Dim _IMSS_EXEC_EXTNSIONS As String = ".exe,.bat,.scr,.pif,.com,.cmd,.vb,.vbs,.vbe,.shb"
                For Each _IMSS_FILE In _IMSS_SURV_TARGETS.Items

                    If _IMSS_EXEC_EXTNSIONS.Contains(IO.Path.GetExtension(_IMSS_FILE.SubItems(2).Text)) Or _IMSS_EXEC_EXTNSIONS.ToUpper().Contains(IO.Path.GetExtension(_IMSS_FILE.SubItems(2).Text)) Then

                        If Not _IMSS_LIST_OF_FILES_TARGETS.Contains(_IMSS_FILE.SubItems(2).Text) Then

                            _IMSS_ARGUMENT += _IMSS_FILE.SubItems(2).Text & "|"

                            _IMSS_LIST_OF_FILES_TARGETS.Add(_IMSS_FILE.SubItems(2).Text)

                        End If

                    End If

                    If (".lnk,.LNK").Contains(IO.Path.GetExtension(_IMSS_FILE.SubItems(2).Text)) = True Then

                        If _IMSS_EXEC_EXTNSIONS.Contains(_IMSS_GET_SHORTCUT_TARGET(_IMSS_FILE.SubItems(2).Text)) Then

                            Dim _IMSS_SHORTCUT_INFO As String = _IMSS_GET_SHORTCUT_TARGET(_IMSS_FILE.SubItems(2).Text)

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

    Private Sub OpenFileLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileLocationToolStripMenuItem.Click
        Try
            Process.Start(Path.GetDirectoryName(_IMSS_SURV_TARGETS.SelectedItems(0).SubItems(2).Text))
        Catch : End Try
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        Try : If IO.File.Exists((Me._IMSS_SURV_TARGETS.SelectedItems(0).SubItems(2).Text)) = True Then IO.File.Delete((Me._IMSS_SURV_TARGETS.SelectedItems(0).SubItems(2).Text))
            Me._IMSS_SURV_TARGETS.SelectedItems(0).Remove()
            If Me._IMSS_SURV_TARGETS.Items.Count = 0 Then
                Try
                    Me.Hide()
                    Me._IMSS_LOADING_PICTUREBOX.Enabled = False
                    _IMSS_SURV_TARGETS.Items.Clear()
                Catch : End Try
            End If
        Catch : End Try
    End Sub

    Private Sub ScanOnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanOnlineToolStripMenuItem.Click
        Dim _IMSS_SCAN_UINT As New IMSS_SCAN_UINT(Me._IMSS_SURV_TARGETS.SelectedItems(0).SubItems(2).Text)
        _IMSS_SCAN_UINT.ShowDialog()
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        _IMSS_Properties((Me._IMSS_SURV_TARGETS.SelectedItems(0).SubItems(2).Text))
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

End Class