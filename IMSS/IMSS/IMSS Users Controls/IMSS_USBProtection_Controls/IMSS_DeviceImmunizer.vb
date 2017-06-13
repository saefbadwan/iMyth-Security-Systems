'بسم الله ابدأ
'يا رب يا الله يا رحيم يا عظيم يا كريم جل جلالك بأسمائك يا الله وفقني برحمتك

Imports System.IO

Public Class IMSS_DeviceImmunizer

    Private Sub _IMSS_ENCR_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ENCR_NEXT.Click
        Dim _IMSS_TARGET_NAME As String = String.Empty
        For Each _IMSS_CONTROLS As IMSS_USB_DVICE In _IMSS_DvicesFound_Panel.Controls
            If _IMSS_CONTROLS.BorderStyle = Windows.Forms.BorderStyle.Fixed3D Then
                _IMSS_TARGET_NAME = _IMSS_CONTROLS._IMSS_TARGET_DRIVE_TEXT
            End If
        Next _IMSS_CONTROLS
        If Not String.IsNullOrEmpty(_IMSS_TARGET_NAME) Then
            For i = 0 To -376 Step -1 : Me.Location = New Point(0, i) : Next
            _IMSS_DriveImmunization(_IMSS_TARGET_NAME)
        Else
            MessageBox.Show("Please select a device to start immunization process on it !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub _IMSS_DriveImmunization(ByVal _IMSS_DriveName As String)
        _IMSS_DriveName_Label.Text = _IMSS_DriveName
        If IO.File.Exists(IO.Path.Combine(_IMSS_DriveName, "Autorun.inf\sig.frz")) Then ' IMSS Unimmunize
            _IMSS_ImmunizationStatus.Text = "Unimmunize drive ..."
            _IMSS_UnimmunizeDrive(IO.Path.Combine(_IMSS_DriveName, "Autorun.inf"))
        Else ' IMSS Immunize
            _IMSS_ImmunizationStatus.Text = "Immunize drive ..."
            _IMSS_ImmunizeDrive(_IMSS_DriveName)
        End If
        _IMSS_ReLoadDriveControls()
        For i = -376 To 0 Step +1 : Me.Location = New Point(0, i) : Next
    End Sub

#Region " Immunize Drive Section declrations "
    Private Sub _IMSS_ImmunizeDrive(ByVal _IMSS_DriveName As String)
        Dim _IMSS_LocalDriveName As String = IO.Path.Combine(_IMSS_DriveName, "Autorun.inf")
        If _IMSS_DataExists(_IMSS_LocalDriveName) = True And _IMSS_IsDir(_IMSS_LocalDriveName) = False Then
            My.Computer.FileSystem.DeleteFile(_IMSS_LocalDriveName)
        End If
        Application.DoEvents()
        'Remove previous error handler and create a new one
        ' On Error GoTo ex:

        MkDir(_IMSS_LocalDriveName)
        Application.DoEvents()
        _IMSS_MakeSequence(_IMSS_LocalDriveName)
        Application.DoEvents()
        MkDir(_IMSS_LocalDriveName & "\DNA_Dir")
        SetAttr(_IMSS_LocalDriveName, vbHidden Or vbReadOnly Or vbSystem)
        Application.DoEvents()

    End Sub
    Private Sub _IMSS_MakeSequence(ByVal _IMSS_DriveDirName As String)

        Dim seq As String

        seq = _IMSS_CreateRandomSequence()

        My.Computer.FileSystem.WriteAllText(_IMSS_DriveDirName & "\SIG.FRZ", seq, False)

        SetAttr(_IMSS_DriveDirName & "\sig.frz", vbHidden Or vbSystem Or vbReadOnly)

    End Sub
    Private Function _IMSS_CreateRandomSequence() As String
        Dim x1, x2, x3, x4, x5, x6, x7, x8 As String
        Dim tmp As String

        Randomize()

        x1 = Hex(Int(Rnd() * 16))
        x2 = Hex(Int(Rnd() * 16))
        x3 = Hex(Int(Rnd() * 16))
        x4 = Hex(Int(Rnd() * 16))
        x5 = Hex(Int(Rnd() * 16))
        x6 = Hex(Int(Rnd() * 16))
        x7 = Hex(Int(Rnd() * 16))
        x8 = Hex(Int(Rnd() * 16))

        tmp = x1 & x2 & x3 & x4 & x5 & x6 & x7 & x8

        Return tmp

    End Function
    Private Function _IMSS_DataExists(ByVal path As String) As Boolean
        Return My.Computer.FileSystem.FileExists(path)
    End Function

    Private Function _IMSS_DirExists(ByVal path As String) As Boolean
        Return My.Computer.FileSystem.DirectoryExists(path)
    End Function

    Private Function _IMSS_IsDir(ByVal path As String) As Boolean
        Return My.Computer.FileSystem.DirectoryExists(path)
    End Function
#End Region

#Region " Unimmunize Drive Section declrations "
    Private Sub _IMSS_UnimmunizeDrive(ByVal _IMSS_DriveName As String)
        If IO.Directory.Exists(_IMSS_DriveName) Then
            For Each _IMSS_FileName As String In My.Computer.FileSystem.GetFiles(_IMSS_DriveName, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                IO.File.SetAttributes(_IMSS_FileName, FileAttributes.Normal)
            Next _IMSS_FileName
            Dim _IMSS_DirInfo As DirectoryInfo
            For Each _IMSS_Dir As String In My.Computer.FileSystem.GetDirectories(_IMSS_DriveName, FileIO.SearchOption.SearchAllSubDirectories)
                Try
                    _IMSS_DirInfo = New System.IO.DirectoryInfo(_IMSS_Dir)
                    _IMSS_DirInfo.Attributes = System.IO.FileAttributes.Normal
                    _IMSS_DirInfo.Delete()
                Catch : End Try
            Next _IMSS_Dir
            Try
                Dim _IMSS_MainDirInfo As New DirectoryInfo(_IMSS_DriveName)
                _IMSS_MainDirInfo.Attributes = FileAttributes.Normal
                IO.Directory.Delete(_IMSS_DriveName, True)
            Catch : End Try
        End If
    End Sub
#End Region

    Private Sub _IMSS_DvicesFound_Panel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DvicesFound_Panel.Click
        For Each _IMSS_CONTROLS As IMSS_USB_DVICE In _IMSS_DvicesFound_Panel.Controls
            _IMSS_CONTROLS._IMSS_SELECTCONTROL = False
        Next _IMSS_CONTROLS
    End Sub
    Private Sub _IMSS_ReLoadDriveControls()
        _IMSS_DvicesFound_Panel.Controls.Clear()
        Dim _IMSS_CheckingVar As Boolean = False
        Dim X As Integer = 10
        Dim Y As Integer = 4
        For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            If d.DriveType = IO.DriveType.Removable And Not d.DriveType = DriveType.CDRom And d.IsReady = True Then
                Application.DoEvents()
                _IMSS_CheckingVar = True
                If IO.Directory.Exists(Path.Combine(d.Name, "Autorun.inf")) Then
                    _IMSS_DvicesFound_Panel.Controls.Add(_IMSS_CREATE_CONTROLS(d.Name, X, Y, True))
                Else
                    _IMSS_DvicesFound_Panel.Controls.Add(_IMSS_CREATE_CONTROLS(d.Name, X, Y, False))
                End If
                X += 160 : If X > 640 Then : X = 10 : Y += 134 : End If
            End If
        Next d
        If _IMSS_CheckingVar = True Then _IMSS_CheckingIfRemovabelDriveInUse.Visible = False _
                     : _IMSS_CheckingIfRemovabelDriveInUse.Dock = DockStyle.None Else _
             _IMSS_CheckingIfRemovabelDriveInUse.Visible = True _
                     : _IMSS_CheckingIfRemovabelDriveInUse.Dock = DockStyle.Fill : _IMSS_CheckingIfRemovabelDriveInUse.BringToFront()
    End Sub
    Private Function _IMSS_CREATE_CONTROLS(ByVal _IMSS_DRIVE_NAME As String, ByRef _IMSS_X As Integer, ByRef _IMSS_Y As Integer, ByVal _IMSS_TARGET_SECURE As Boolean) As IMSS_USB_DVICE
        Dim _IMSS_WINDOW_CONTROLLER As New IMSS_USB_DVICE With {
                ._IMSS_TARGET_DRIVE_TEXT = _IMSS_DRIVE_NAME,
                .Location = New Point(_IMSS_X, _IMSS_Y),
                ._IMSS_TARGET_DRIVE_STATUS = _IMSS_TARGET_SECURE,
                .Visible = True}
        Return _IMSS_WINDOW_CONTROLLER
    End Function
End Class
