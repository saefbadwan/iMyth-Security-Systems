Public Class IMSS_ROOT_DECRYPTION
    Private Shared _IMSS_ListOfDIRS As New List(Of String)
    Private Shared _IMSS_ListOfFILES As New List(Of String)
    Private Shared _IMSS_DIR_TOTAL_NUMBER As Integer = 0
#Region "IMSS ROOT ENCRPTION START"
    Public Shared Sub _IMSS_ROOT_ENCRYPT(ByVal _IMSS_DRIVE As String, ByVal _IMSS_DRIVE_DIR As String, ByRef _IMSS_ProgressBar As ProgressBar, ByRef _IMSS_LABEl As Label)
        _IMSS_ChangeLabelText(_IMSS_LABEl, "Calacluting ... ")
        For Each _IMSS_DIR In IO.Directory.GetDirectories(_IMSS_DRIVE, "*.*", IO.SearchOption.TopDirectoryOnly) : _IMSS_ListOfDIRS.Add(_IMSS_DIR) : _IMSS_DIR_TOTAL_NUMBER += 1 : Next
        For Each _IMSS_FILE In IO.Directory.GetFiles(_IMSS_DRIVE, "*.*", IO.SearchOption.TopDirectoryOnly) : _IMSS_ListOfFILES.Add(_IMSS_FILE) : _IMSS_DIR_TOTAL_NUMBER += 1 : Next : _IMSS_SetMaxProgress(_IMSS_ProgressBar, _IMSS_DIR_TOTAL_NUMBER)
        If Not IO.Directory.Exists(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}") Then IO.Directory.CreateDirectory(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
        _IMSS_MOVEALL_DIRS_FILES(_IMSS_DRIVE_DIR, _IMSS_ProgressBar, _IMSS_LABEl)
    End Sub
    Private Shared Sub _IMSS_MOVEALL_DIRS_FILES(ByVal _IMSS_DRIVE_DIR As String, ByRef _IMSS_ProgressBar As ProgressBar, ByRef _IMSS_LABEl As Label)
        _IMSS_RESET_PROGRESS_VALUE(_IMSS_ProgressBar)
        For Each _IMSS_DIR In _IMSS_ListOfDIRS
            _IMSS_ChangeLabelText(_IMSS_LABEl, _IMSS_DIR)
            Dim _IMSS_DIR_INFO As New IO.DirectoryInfo(_IMSS_DIR)
            _IMSS_DIR_INFO.MoveTo(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\" & _IMSS_DIR_INFO.Name) : _IMSS_AdddOneToTheProgressBar(_IMSS_ProgressBar) : Next _IMSS_DIR
        For Each _IMSS_FILE In _IMSS_ListOfFILES
            _IMSS_ChangeLabelText(_IMSS_LABEl, _IMSS_FILE)
            Dim _IMSS_FILE_INFO As New IO.FileInfo(_IMSS_FILE)
            _IMSS_FILE_INFO.MoveTo(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\" & _IMSS_FILE_INFO.Name) : _IMSS_AdddOneToTheProgressBar(_IMSS_ProgressBar) : Next _IMSS_FILE
        _IMSS_ListOfDIRS.Clear() : _IMSS_ListOfFILES.Clear()
    End Sub

#End Region
#Region "IMSS ROOT DECRPTION START"
    Public Shared Sub _IMSS_ROOT_DECRYPT(ByVal _IMSS_DRIVE As String, ByVal _IMSS_DRIVE_DIR As String, ByRef _IMSS_ProgressBar As ProgressBar, ByRef _IMSS_LABEl As Label)
        On Error Resume Next
        If Not IO.Directory.Exists(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}") Then Exit Sub
        If IO.Directory.Exists(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}") Then
            Dim _IMSS_DIR_INFO As New IO.DirectoryInfo(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
            _IMSS_DIR_INFO.Attributes = IO.FileAttributes.Normal
        End If
        _IMSS_ChangeLabelText(_IMSS_LABEl, "Calacluting ... ")
        _IMSS_DIR_TOTAL_NUMBER = 0
        Dim _IMSS_ENCRYPTION_DIR As New IO.DirectoryInfo(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}") : _IMSS_ENCRYPTION_DIR.MoveTo(_IMSS_DRIVE_DIR)
        For Each _IMSS_DIR In IO.Directory.GetDirectories(_IMSS_DRIVE_DIR, "*.*", IO.SearchOption.TopDirectoryOnly) : _IMSS_ListOfDIRS.Add(_IMSS_DIR) : _IMSS_DIR_TOTAL_NUMBER += 1 : Next
        For Each _IMSS_FILE In IO.Directory.GetFiles(_IMSS_DRIVE_DIR, "*.*", IO.SearchOption.TopDirectoryOnly) : _IMSS_ListOfFILES.Add(_IMSS_FILE) : _IMSS_DIR_TOTAL_NUMBER += 1 : Next : _IMSS_SetMaxProgress(_IMSS_ProgressBar, _IMSS_DIR_TOTAL_NUMBER)
        _IMSS_REMOVEALL_DIRS_FILES(_IMSS_DRIVE, _IMSS_ProgressBar, _IMSS_LABEl)
        If IO.File.Exists(_IMSS_DRIVE_DIR & "\IMSS_PASSWD.IMSSDATA") Then IO.File.Delete(_IMSS_DRIVE_DIR & "\IMSS_PASSWD.IMSSDATA")
        If IO.Directory.Exists(_IMSS_DRIVE_DIR) Then IO.Directory.Delete(_IMSS_DRIVE_DIR)
    End Sub
    Private Shared Function _IMSS_CheckIfExsits(ByVal _IMSS_TARGET As String) As Boolean
        If Not IO.File.Exists(_IMSS_TARGET) Then
            Return True
        ElseIf Not IO.Directory.Exists(_IMSS_TARGET) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Shared Sub _IMSS_REMOVEALL_DIRS_FILES(ByVal _IMSS_DRIVE As String, ByVal _IMSS_ProgressBar As ProgressBar, ByRef _IMSS_LABEl As Label)
        On Error Resume Next
        _IMSS_RESET_PROGRESS_VALUE(_IMSS_ProgressBar)
        For Each _IMSS_DIR In _IMSS_ListOfDIRS
            _IMSS_ChangeLabelText(_IMSS_LABEl, _IMSS_DIR)
            Dim _IMSS_DIR_INFO As New IO.DirectoryInfo(_IMSS_DIR)
            If _IMSS_CheckIfExsits(_IMSS_DRIVE & _IMSS_DIR_INFO.Name) = True Then
                _IMSS_DIR_INFO.MoveTo(_IMSS_DRIVE & _IMSS_DIR_INFO.Name)
            Else
                _IMSS_DIR_INFO.MoveTo(_IMSS_DRIVE & "1_" & _IMSS_DIR_INFO.Name)
            End If
            : _IMSS_AdddOneToTheProgressBar(_IMSS_ProgressBar) : Next _IMSS_DIR
        For Each _IMSS_FILE In _IMSS_ListOfFILES
            _IMSS_ChangeLabelText(_IMSS_LABEl, _IMSS_FILE)
            Dim _IMSS_FILE_INFO As New IO.FileInfo(_IMSS_FILE)
            _IMSS_FILE_INFO.MoveTo(_IMSS_DRIVE & _IMSS_FILE_INFO.Name) : _IMSS_AdddOneToTheProgressBar(_IMSS_ProgressBar) : Next _IMSS_FILE

        _IMSS_ListOfDIRS.Clear() : _IMSS_ListOfFILES.Clear()
    End Sub
    Public Shared Sub _IMSS_CREATE_ENCRYPTION_UINT(ByVal _IMSS_DRIVE_DIR As String, ByVal _IMSS_ENCRY_PASSWORD As String)
        If Not IO.File.Exists(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\IMSS_PASSWD.IMSSDATA") Then
            IO.File.Create(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\IMSS_PASSWD.IMSSDATA").Dispose()
            IO.File.WriteAllText(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\IMSS_PASSWD.IMSSDATA", _IMSS_ENCRY_PASSWORD)
            IO.File.SetAttributes(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\IMSS_PASSWD.IMSSDATA", IO.FileAttributes.Hidden)
        End If
        If IO.Directory.Exists(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}") Then
            Dim _IMSS_DIR_INFO As New IO.DirectoryInfo(_IMSS_DRIVE_DIR & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
            _IMSS_DIR_INFO.Attributes = IO.FileAttributes.Hidden + IO.FileAttributes.System
        End If
    End Sub
#End Region

#Region "IMSS INVOKE CONTROLS FUNC"
    Private Delegate Sub _IMSS_AdddOneToTheProgressBarDelegate(ByRef _IMSS_ProgressBar As ProgressBar)
    Private Shared Sub _IMSS_AdddOneToTheProgressBar(ByRef _IMSS_ProgressBar As ProgressBar)
        If _IMSS_ProgressBar.InvokeRequired = True Then
            _IMSS_ProgressBar.Invoke(New _IMSS_AdddOneToTheProgressBarDelegate(AddressOf _IMSS_AdddOneToTheProgressBar), _IMSS_ProgressBar)
        Else
            _IMSS_ProgressBar.Value += 1
        End If
    End Sub
    Private Delegate Sub _IMSS_SetMaxProgressDelegate(ByRef _IMSS_ProgressBar As ProgressBar, ByVal _IMSS_MAX As Integer)
    Private Shared Sub _IMSS_SetMaxProgress(ByRef _IMSS_ProgressBar As ProgressBar, ByVal _IMSS_MAX As Integer)
        If _IMSS_ProgressBar.InvokeRequired = True Then
            _IMSS_ProgressBar.Invoke(New _IMSS_SetMaxProgressDelegate(AddressOf _IMSS_SetMaxProgress), _IMSS_ProgressBar, _IMSS_MAX)
        Else
            _IMSS_ProgressBar.Maximum = _IMSS_MAX
        End If
    End Sub
    Private Shared Sub _IMSS_RESET_PROGRESS_VALUE(ByRef _IMSS_ProgressBar As ProgressBar)
        If _IMSS_ProgressBar.InvokeRequired = True Then
            _IMSS_ProgressBar.Invoke(New _IMSS_AdddOneToTheProgressBarDelegate(AddressOf _IMSS_RESET_PROGRESS_VALUE), _IMSS_ProgressBar)
        Else
            _IMSS_ProgressBar.Value = 0
        End If
    End Sub
    Private Delegate Sub _IMSS_ChangeLabelTextDelegate(ByRef _IMSS_LABEl As Label, ByVal _IMSS_TEXT As String)
    Private Shared Sub _IMSS_ChangeLabelText(ByRef _IMSS_LABEl As Label, ByVal _IMSS_TEXT As String)
        If _IMSS_LABEl.InvokeRequired = True Then
            _IMSS_LABEl.Invoke(New _IMSS_ChangeLabelTextDelegate(AddressOf _IMSS_ChangeLabelText), _IMSS_LABEl, _IMSS_TEXT)
        Else
            _IMSS_LABEl.Text = _IMSS_TEXT
        End If
    End Sub

#End Region

End Class
