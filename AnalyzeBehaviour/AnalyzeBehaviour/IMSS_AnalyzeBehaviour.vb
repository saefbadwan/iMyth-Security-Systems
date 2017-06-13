' بسم الله الرحمن الرحيم

Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports System.Security.AccessControl
Imports System.Management

Public Class IMSS_AnalyzeBehaviour

    Private Shared _IMSS_EXEC_EXTNSIONS As String = ".exe,.bat,.scr,.pif,.com,.cmd,.vb,.vbs,.vbe,.shb"
    Public Shared _IMSS_Q As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSS"

    'Private Shared _IMSS_PROCESSES_INBHAVIOUR As New Dictionary(Of String, String)
    'Private Shared _IMSS_REGISTRY_INBHAVIOUR As New Dictionary(Of String, String)

    Private Shared _IMSS_FILES_INBHAVIOUR As New Dictionary(Of String, String)
    Private Shared _IMSS_LOCAL_TREEVIEW As TreeView = Nothing
    Private Shared _IMSS_LOCAL_LABEL As Label = Nothing
    Private Shared _IMSS_LOCAL_STEP_INDECATOR As StepIndicator = Nothing


    Public Shared Sub _IMSS_START_BEHAVIOUR_ANALYZER(ByRef _IMSS_LABEL As Label, ByRef _IMSS_STEP_INDECATOR As StepIndicator, ByRef _IMSS_TREEVIEW As TreeView, ByRef _IMSS_LIST_OF_TARGETS() As String)

        _IMSS_LOCAL_TREEVIEW = _IMSS_TREEVIEW
        _IMSS_LOCAL_LABEL = _IMSS_LABEL
        _IMSS_LOCAL_STEP_INDECATOR = _IMSS_STEP_INDECATOR

        _IMSS_CHNAGE_LABEL_TEXT("       Searching file system ...")

        Dim _IMSS_LIST_OF_TREEVIEW_ITEMS As New List(Of TreeNode)

        _IMSS_ANALYZE_FILES_BEHAVIOUR()




        _IMSS_CHANGE_STEP_COUNT(1)


        For Each _IMSS_TARGET In _IMSS_LIST_OF_TARGETS

            _IMSS_CHNAGE_LABEL_TEXT("      " & _IMSS_TARGET)

            If _IMSS_EXEC_EXTNSIONS.Contains(IO.Path.GetExtension(_IMSS_TARGET)) Or _IMSS_EXEC_EXTNSIONS.ToUpper().Contains(IO.Path.GetExtension(_IMSS_TARGET)) Then


                Dim _IMSS_TREENODE As New TreeNode
                With _IMSS_TREENODE

                    .Text = (IO.Path.GetFileName(_IMSS_TARGET) & "  (" & _IMSS_TARGET & ")")
                    .Tag = _IMSS_TARGET
                    .ImageIndex = 0
                    .Expand()

                    Dim _IMSS_PROCESSES As List(Of Process) = _IMSS_GET_PROCESS(New String() {_IMSS_TARGET, _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_TARGET, False)})

                    If _IMSS_PROCESSES.Count() > 0 Then
                        With .Nodes.Add("PROCESSES")

                            .ImageIndex = 4
                            .Expand()

                            For Each _IMSS_PROCESS In _IMSS_PROCESSES
                                With .Nodes.Add("PROCESS PID : " & _IMSS_PROCESS.Id)
                                    .Tag = _IMSS_PROCESS.Id
                                    .ImageIndex = 5
                                End With
                                .Nodes.Add("PROCESS NAME : " & _IMSS_PROCESS.ProcessName).ImageIndex = 6
                                .Nodes.Add("PROCESS PATH : " & _IMSS_PROCESS.Modules(0).FileName).ImageIndex = 3
                            Next _IMSS_PROCESS

                        End With
                    End If



                    _IMSS_CHANGE_STEP_COUNT(3)

                    Dim _IMSS_LocalMachine_LIST As List(Of String) = _IMSS_GET_LocalMachine_REGISTRY(_IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_TARGET, False))
                    Dim _IMSS_CurrentUser_LIST As List(Of String) = _IMSS_GET_CurrentUser_REGISTRY(_IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_TARGET, False))

                    _IMSS_CHANGE_STEP_COUNT(4)
                    If _IMSS_LocalMachine_LIST.Count() > 0 Or _IMSS_CurrentUser_LIST.Count() > 0 Then
                        With .Nodes.Add("REGISTRY")

                            .ImageIndex = 1
                            .Expand()

                            If _IMSS_LocalMachine_LIST.Count() > 0 Then
                                For Each _IMSS_ITEM In _IMSS_LocalMachine_LIST
                                    With .Nodes.Add("KEY : " & _IMSS_ITEM)
                                        .Tag = "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run\" & _IMSS_ITEM
                                        .ImageIndex = 2
                                        .Nodes.Add("KEY PATH : HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run").ImageIndex = 3
                                        .Nodes.Add("KEY VALUE : " & My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValue(_IMSS_ITEM).ToString()).ImageIndex = 3
                                    End With

                                Next _IMSS_ITEM
                            End If


                            If _IMSS_CurrentUser_LIST.Count() > 0 Then
                                For Each _IMSS_ITEM In _IMSS_CurrentUser_LIST
                                    .ImageIndex = 2
                                    With .Nodes.Add("KEY : " & _IMSS_ITEM)
                                        .Tag = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run\" & _IMSS_ITEM
                                        .Nodes.Add("KEY PATH : HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run").ImageIndex = 3
                                        .Nodes.Add("KEY VALUE : " & My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValue(_IMSS_ITEM).ToString()).ImageIndex = 3
                                    End With
                                Next _IMSS_ITEM
                            End If
                        End With
                    End If


                    _IMSS_CHANGE_STEP_COUNT(6)

                    If _IMSS_FILES_INBHAVIOUR.ContainsValue(_IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_TARGET, False)) Then
                        With .Nodes.Add("FILES SYSTEM")

                            .ImageIndex = 7
                            .Expand()

                            For Each _IMSS_FILE In _IMSS_FILES_INBHAVIOUR
                                If _IMSS_FILE.Value = _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_TARGET, False) Then
                                    With .Nodes.Add(IO.Path.GetFileName(_IMSS_FILE.Key) & "  -> " & _IMSS_FILE.Key)

                                        .Tag = _IMSS_FILE.Key
                                        .ImageIndex = 8

                                        .Nodes.Add("HASH : " & _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_TARGET, False)).ImageIndex = 3

                                    End With
                                End If
                            Next _IMSS_FILE
                        End With
                    End If

                End With

                If Not _IMSS_TREENODE.Nodes.Count() = 0 And Not _IMSS_TREENODE.Text.Contains("()") Then _IMSS_LIST_OF_TREEVIEW_ITEMS.Add(_IMSS_TREENODE)

            End If

        Next _IMSS_TARGET

        _IMSS_CHANGE_STEP_COUNT(9)

        _IMSS_ADD_TO_TREEVIEW(_IMSS_LIST_OF_TREEVIEW_ITEMS)

        _IMSS_CHANGE_STEP_COUNT(10)

    End Sub

    Private Delegate Sub _IMSS_ADD_TO_TREEVIEWDelegate(ByRef _IMSS_ITEMS As List(Of TreeNode))
    Private Shared Sub _IMSS_ADD_TO_TREEVIEW(ByRef _IMSS_ITEMS As List(Of TreeNode))

        If _IMSS_LOCAL_TREEVIEW.InvokeRequired = True Then
            _IMSS_LOCAL_TREEVIEW.Invoke(New _IMSS_ADD_TO_TREEVIEWDelegate(AddressOf _IMSS_ADD_TO_TREEVIEW), _IMSS_ITEMS)
        Else

            '_IMSS_LOCAL_TREEVIEW.BeginUpdate()
            _IMSS_LOCAL_TREEVIEW.Nodes.AddRange(_IMSS_ITEMS.ToArray())
            '_IMSS_LOCAL_TREEVIEW.EndUpdate()

        End If
    End Sub

    Private Delegate Sub _IMSS_CHNAGE_LABEL_TEXTDelegate(ByVal _IMSS_TEXT As String)
    Private Shared Sub _IMSS_CHNAGE_LABEL_TEXT(ByVal _IMSS_TEXT As String)
        If _IMSS_LOCAL_LABEL.InvokeRequired = True Then
            _IMSS_LOCAL_LABEL.Invoke(New _IMSS_CHNAGE_LABEL_TEXTDelegate(AddressOf _IMSS_CHNAGE_LABEL_TEXT), _IMSS_TEXT)
        Else
            _IMSS_LOCAL_LABEL.Text = _IMSS_TEXT
        End If
    End Sub

    Private Delegate Sub _IMSS_CHNAGE_STEP_COUNTDelegate(ByVal _IMSS_VALUE As Short)
    Private Shared Sub _IMSS_CHANGE_STEP_COUNT(ByVal _IMSS_VALUE As Short)
        If _IMSS_LOCAL_STEP_INDECATOR.InvokeRequired = True Then
            _IMSS_LOCAL_STEP_INDECATOR.Invoke(New _IMSS_CHNAGE_STEP_COUNTDelegate(AddressOf _IMSS_CHANGE_STEP_COUNT), _IMSS_VALUE)
        Else
            _IMSS_LOCAL_STEP_INDECATOR.CurrentStep = _IMSS_VALUE
        End If
    End Sub

    Private Shared Function _IMSS_GET_PROCESS(ByVal _IMSS_PROCESS_INFO() As String) As List(Of Process)
        Dim _IMSS_LIST_OF_PROCESSES As New List(Of Process)
        For Each _IMSS_PROCESS In Process.GetProcesses()
            Try
                If _IMSS_PROCESS.ProcessName.Contains("wscript") Or _IMSS_PROCESS.ProcessName.Contains("cscript") _
                    Or _IMSS_PROCESS.ProcessName.Contains("WScript") Or _IMSS_PROCESS.ProcessName.Contains("CScript") Then
                    For Each _IMSS_TARGET In _IMSS_GET_VBS_PROCESSES_FILES().ToArray()
                        Try
                            If IO.File.Exists(_IMSS_TARGET) Then
                                If _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_TARGET, True) = _IMSS_PROCESS_INFO(1) Then
                                    _IMSS_LIST_OF_PROCESSES.Add(_IMSS_PROCESS)
                                End If
                            End If
                        Catch : End Try
                    Next _IMSS_TARGET
                Else
                    If _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_PROCESS.Modules(0).FileName, False) = _IMSS_PROCESS_INFO(1) Then
                        _IMSS_LIST_OF_PROCESSES.Add(_IMSS_PROCESS)
                    End If
                End If
            Catch : End Try
        Next _IMSS_PROCESS
        Return _IMSS_LIST_OF_PROCESSES
    End Function

    Private Shared Function _IMSS_GET_VBS_PROCESSES_FILES() As List(Of String)
        Dim _IMSS_LIST_OF_TARGETS As New List(Of String)
        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE Name = 'wscript.exe' OR Name = 'cscript.exe'")
        For Each process As ManagementObject In searcher.Get()
            _IMSS_LIST_OF_TARGETS.Add(process("CommandLine").ToString().Split("""")(3))
        Next process
        Return _IMSS_LIST_OF_TARGETS
    End Function

    Private Shared Function _IMSS_GET_LocalMachine_REGISTRY(ByVal _IMSS_PROCESS_INFO As String) As List(Of String)
        Dim _IMSS_LOCAL_LIST_OF_VALUES As New List(Of String)
        For Each _IMSS_KEY In My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValueNames()
            '     Application.DoEvents()
            Dim _IMSS_REGISTRY_VALUE_FILENAME As String = String.Empty
            If _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_ReturnFilePath(My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValue(_IMSS_KEY).ToString()), False) = _IMSS_PROCESS_INFO Then
                _IMSS_LOCAL_LIST_OF_VALUES.Add(_IMSS_KEY)
            End If
        Next _IMSS_KEY
        Return _IMSS_LOCAL_LIST_OF_VALUES
    End Function
    Private Shared Function _IMSS_GET_CurrentUser_REGISTRY(ByVal _IMSS_PROCESS_INFO As String) As List(Of String)
        Dim _IMSS_CURRENT_LIST_OF_VALUES As New List(Of String)
        For Each _IMSS_KEY In My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValueNames()
            '    Application.DoEvents()
            Dim _IMSS_REGISTRY_VALUE_FILENAME As String = String.Empty
            If _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_ReturnFilePath(My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValue(_IMSS_KEY).ToString()), False) = _IMSS_PROCESS_INFO Then
                _IMSS_CURRENT_LIST_OF_VALUES.Add(_IMSS_KEY)
            End If
        Next _IMSS_KEY
        Return _IMSS_CURRENT_LIST_OF_VALUES
    End Function




    'Public Shared Sub _IMSS_ANALYZE_PROCESSES_BEHAVIOUR(ByRef _IMSS_LIST_OF_TARGETS() As String)

    '    Dim _IMSS_PROCESSES As New Dictionary(Of String, String)


    '    ' IMSS GET PROCESSES FILES ANF HASHES

    '    For Each _IMSS_PROCESS In Process.GetProcesses()

    '        Dim _IMSS_PROCESS_FILENAME As String = String.Empty

    '        Try
    '            _IMSS_PROCESS_FILENAME = _IMSS_PROCESS.Modules(0).FileName
    '        Catch
    '            _IMSS_PROCESS_FILENAME = "_IMSS_ERROR"
    '        End Try



    '        If Not _IMSS_PROCESS_FILENAME = "_IMSS_ERROR" Then

    '            If IO.File.Exists(_IMSS_PROCESS_FILENAME) Then

    '                Dim _IMSS_HASH_VALUE As String = _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_PROCESS.Modules(0).FileName)

    '                If Not _IMSS_PROCESSES.ContainsValue(_IMSS_HASH_VALUE) Then
    '                    _IMSS_PROCESSES.Add(_IMSS_PROCESS.Modules(0).FileName, _IMSS_HASH_VALUE)
    '                End If

    '            End If

    '        End If

    '    Next _IMSS_PROCESS

    '    ' IMSS CHECK PROCESSES HASHES

    '    For Each _IMSS_TARGET In _IMSS_LIST_OF_TARGETS

    '        If IO.File.Exists(_IMSS_TARGET) Then

    '            If _IMSS_EXEC_EXTNSIONS.Contains(IO.Path.GetExtension(_IMSS_TARGET)) Then

    '                Dim _IMSS_HASH_VALUE As String = _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_TARGET)

    '                If _IMSS_PROCESSES.ContainsValue(_IMSS_HASH_VALUE) Then
    '                    ' MsgBox(_IMSS_CHECK_KEY_VALUE(_IMSS_PROCESSES, _IMSS_HASH_VALUE) & "     -------------        " & _IMSS_HASH_VALUE & "        ----------------------         " & _IMSS_TARGET)
    '                    _IMSS_PROCESSES_INBHAVIOUR.Add(_IMSS_CHECK_KEY_VALUE(_IMSS_PROCESSES, _IMSS_HASH_VALUE), _IMSS_HASH_VALUE)

    '                End If

    '            End If

    '        End If

    '    Next _IMSS_TARGET


    'End Sub


    'Public Shared Sub _IMSS_ANALYZE_REGISTRY_BEHAVIOUR(ByRef _IMSS_LIST_OF_TARGETS() As String)

    '    Dim _IMSS_REGISTRY_KEYS As New Dictionary(Of String, String)

    '    _IMSS_LOAD_KEY_VALUS(_IMSS_REGISTRY_KEYS, My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValueNames(), True)

    '    _IMSS_LOAD_KEY_VALUS(_IMSS_REGISTRY_KEYS, My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValueNames(), False)

    '    For Each _IMSS_TARGET In _IMSS_LIST_OF_TARGETS

    '        If IO.File.Exists(_IMSS_TARGET) Then

    '            If _IMSS_EXEC_EXTNSIONS.Contains(IO.Path.GetExtension(_IMSS_TARGET)) Then

    '                Dim _IMSS_HASH_VALUE As String = _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_TARGET)

    '                If _IMSS_REGISTRY_KEYS.ContainsValue(_IMSS_HASH_VALUE) Then

    '                    _IMSS_REGISTRY_INBHAVIOUR.Add(_IMSS_CHECK_KEY_VALUE(_IMSS_REGISTRY_KEYS, _IMSS_HASH_VALUE), _IMSS_HASH_VALUE)

    '                End If

    '            End If

    '        End If

    '    Next _IMSS_TARGET

    'End Sub

    'Private Shared Sub _IMSS_LOAD_KEY_VALUS(ByRef _IMSS_REGISTRY_KEYS As Dictionary(Of String, String), ByRef _IMSS_LIST_OF_KEY_VALUES() As String, ByVal _IMSS_REGISTRY_KEY_VALUE As Boolean)
    '    For Each _IMSS_KEY In _IMSS_LIST_OF_KEY_VALUES

    '        Dim _IMSS_REGISTRY_VALUE_FILENAME As String = String.Empty

    '        If _IMSS_REGISTRY_KEY_VALUE = True Then

    '            _IMSS_REGISTRY_VALUE_FILENAME = _IMSS_ReturnFilePath(My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValue(_IMSS_KEY).ToString())

    '        Else

    '            _IMSS_REGISTRY_VALUE_FILENAME = _IMSS_ReturnFilePath(My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValue(_IMSS_KEY).ToString())

    '        End If


    '        If IO.File.Exists(_IMSS_REGISTRY_VALUE_FILENAME) Then

    '            Dim _IMSS_HASH_VALUE As String = _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_REGISTRY_VALUE_FILENAME)

    '            If Not _IMSS_REGISTRY_KEYS.ContainsValue(_IMSS_HASH_VALUE) Then
    '                _IMSS_REGISTRY_KEYS.Add(_IMSS_REGISTRY_VALUE_FILENAME, _IMSS_HASH_VALUE)
    '            End If

    '        End If

    '    Next _IMSS_KEY
    'End Sub


    Public Shared Sub _IMSS_ANALYZE_FILES_BEHAVIOUR()



        _IMSS_OPEN_Q()

        _IMSS_LOAD_TARGET_FILES_HASHES(_IMSS_FILES_INBHAVIOUR, FileIO.SearchOption.SearchTopLevelOnly, Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 2) & "\")

        _IMSS_LOAD_TARGET_FILES_HASHES(_IMSS_FILES_INBHAVIOUR, FileIO.SearchOption.SearchAllSubDirectories, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))

        _IMSS_LOAD_TARGET_FILES_HASHES(_IMSS_FILES_INBHAVIOUR, FileIO.SearchOption.SearchTopLevelOnly, Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles))

        _IMSS_LOAD_TARGET_FILES_HASHES(_IMSS_FILES_INBHAVIOUR, FileIO.SearchOption.SearchTopLevelOnly, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))

        _IMSS_LOAD_TARGET_FILES_HASHES(_IMSS_FILES_INBHAVIOUR, FileIO.SearchOption.SearchTopLevelOnly, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData))

        _IMSS_LOAD_TARGET_FILES_HASHES(_IMSS_FILES_INBHAVIOUR, FileIO.SearchOption.SearchTopLevelOnly, Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("32", ""))

        _IMSS_LOAD_TARGET_FILES_HASHES(_IMSS_FILES_INBHAVIOUR, FileIO.SearchOption.SearchTopLevelOnly, Environment.GetFolderPath(Environment.SpecialFolder.System))

        _IMSS_LOAD_TARGET_FILES_HASHES(_IMSS_FILES_INBHAVIOUR, FileIO.SearchOption.SearchTopLevelOnly, Environment.GetFolderPath(Environment.SpecialFolder.Startup))

        _IMSS_LOAD_TARGET_FILES_HASHES(_IMSS_FILES_INBHAVIOUR, FileIO.SearchOption.SearchTopLevelOnly, Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("\system32", ""))

    End Sub


    Private Shared Sub _IMSS_OPEN_Q()
        Dim fs As FileSystemSecurity = IO.File.GetAccessControl(_IMSS_Q + "\IMSSQ")
        fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        IO.File.SetAccessControl(_IMSS_Q + "\IMSSQ", fs)
    End Sub
    Private Shared Sub _IMSS_LOAD_TARGET_FILES_HASHES(ByRef _IMSS_FILES_HASHES As Dictionary(Of String, String), ByVal _IMSS_SEARCH_TYPE As FileIO.SearchOption, ByVal _IMSS_TARGET_VALUE As String)
        '  On Error Resume Next ' IMSS IF DIR IS ACSSES DENIDE
        Try
            Dim _IMSS_LIST_OF_FILES As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetFiles(_IMSS_TARGET_VALUE, _IMSS_SEARCH_TYPE, "*.*")

            For Each _IMSS_FILE In _IMSS_LIST_OF_FILES
                '  Application.DoEvents()
                If _IMSS_EXEC_EXTNSIONS.Contains(IO.Path.GetExtension(_IMSS_FILE)) Then

                    Dim _IMSS_HASH_VALUE As String = _IMSS_MD5SCANNER._IMSS_Get_MD5_Hashes(_IMSS_FILE, False)

                    If Not _IMSS_FILES_HASHES.ContainsKey(_IMSS_FILE) Then
                        _IMSS_FILES_HASHES.Add(_IMSS_FILE, _IMSS_HASH_VALUE)
                    End If


                End If

            Next _IMSS_FILE

        Catch : End Try

    End Sub



    'Private Shared Function _IMSS_CHECK_KEY_VALUE(ByRef _IMSS_KEYS As Dictionary(Of String, String), ByVal _IMSS_VALUE_HASH As String) As String
    '    Dim _IMSS_VALUE_OF_KEY As String = String.Empty
    '    For Each _IMSS_ITEM As KeyValuePair(Of String, String) In _IMSS_KEYS
    '        If _IMSS_ITEM.Value = _IMSS_VALUE_HASH Then
    '            _IMSS_VALUE_OF_KEY = _IMSS_ITEM.Key
    '        End If
    '    Next _IMSS_ITEM
    '    Return _IMSS_VALUE_OF_KEY
    'End Function

    Private Shared Function _IMSS_ReturnFilePath(ByVal value As String) As String

        Try
            Dim p As Integer

            ' Check for quotes, and if present, remove them.
            If value.Contains(Chr(34)) Then
                value = value.Replace(Chr(34), "")
            End If

            ' Check for hyphens, and if present, return the part before first one,
            ' unless it is before the extension.
            If value.Contains("-") Then
                p = value.IndexOf("-")
                Dim pDot As Integer = value.IndexOf(".")
                If p > pDot Then
                    value = value.Substring(0, p - 1)
                End If
            End If

            ' Check for forward slashes, and if present, return the part before first one.
            If value.Contains("/") Then
                p = value.IndexOf("/")
                value = value.Substring(0, p - 1)
            End If

            ' Check for a space followed by a percent sign, and if present, return the part before the first one.
            If value.Contains(" %") Then
                p = value.IndexOf(" %")
                value = value.Substring(0, p)
            End If

            If value <> "" Then
                Return IO.Path.GetFullPath(value)
            Else
                Return ""
            End If

        Catch
            Return ""
        End Try

    End Function

End Class
