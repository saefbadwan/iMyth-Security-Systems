

Imports ComponentOwl.BetterListView
Imports System.IO

Public Class IMSS_DriveEncryption

    Private Sub _IMSS_DvicesFound_Panel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DvicesFound_Panel.Click
        For Each _IMSS_CONTROLS As IMSS_USB_DVICE In _IMSS_DvicesFound_Panel.Controls
            _IMSS_CONTROLS._IMSS_SELECTCONTROL = False

        Next _IMSS_CONTROLS
    End Sub
    Private _IMSS_TARGET_NAME As String = String.Empty
    Private _IMSS_TARGET_DRIVE_NAME As String = String.Empty
    Private Sub _IMSS_ENCR_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ENCR_NEXT.Click
        If Len(_IMSS_TARGET_NAME) > 0 Then _IMSS_TARGET_NAME = String.Empty
        For Each _IMSS_CONTROLS As IMSS_USB_DVICE In _IMSS_DvicesFound_Panel.Controls
            If _IMSS_CONTROLS.BorderStyle = Windows.Forms.BorderStyle.Fixed3D Then
                _IMSS_TARGET_NAME = _IMSS_CONTROLS._IMSS_TARGET_DRIVE_TEXT
            End If
        Next
        If Not String.IsNullOrEmpty(_IMSS_TARGET_NAME) Then
            For i = 0 To -376 Step -1 : _IMSS_MainPanel.Location = New Point(0, i) : Next : _IMSS_CollectingData.Enabled = True
            Dim _IMSS_STARt_T As New Threading.Thread(Sub()
                                                          _IMSS_CollectDataFromtarget(_IMSS_TARGET_NAME)
                                                          _IMSS_TARGET_DRIVE_NAME = _IMSS_TARGET_NAME
                                                          _IMSS_TARGET_NAME = String.Empty
                                                      End Sub) : _IMSS_STARt_T.Start()
        Else
            MessageBox.Show("Please select a device to start encryption process on it !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub _IMSS_GetTargetData(ByRef _IMSS_TARGET_NAME As String, ByRef _IMSS_LIST_FOUND As List(Of BetterListViewItem), ByRef _IMSS_ENCR_STATUs As String)
        For Each _IMSS_FILE In My.Computer.FileSystem.GetDirectories(_IMSS_TARGET_NAME, FileIO.SearchOption.SearchAllSubDirectories, _IMSS_ENCR_STATUs)
            Dim _IMSS_ListItem As New BetterListViewItem(IO.Path.GetFileName(_IMSS_FILE))
            With _IMSS_ListItem
                .Checked = True
                .Image = My.Resources._IMSS_ProcessingFile_Icon_16x16
                .SubItems.Add(_IMSS_FILE)
            End With : _IMSS_LIST_FOUND.Add(_IMSS_ListItem) : _IMSS_ListItem.Dispose()
        Next _IMSS_FILE
    End Sub
    Private Sub _IMSS_CollectDataFromtarget(ByVal _IMSS_TARGET_NAME As String)
        Dim _IMSS_LIST_FOUND As New List(Of BetterListViewItem)
        If Not IO.Directory.Exists(IO.Path.Combine(_IMSS_TARGET_NAME, "PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")) Then
            _IMSS_GetTargetData(_IMSS_TARGET_NAME, _IMSS_LIST_FOUND, "*.*")
        Else
            Dim _IMSS_OutPasswordText() As String = IO.File.ReadAllText(IO.Path.Combine(_IMSS_TARGET_NAME, "PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\IMSS_PASSWD.IMSSDATA")).Split("|")
            If _IMSS_OutPasswordText(0) = "RT" Then
                _IMSS_GetTargetData(_IMSS_TARGET_NAME, _IMSS_LIST_FOUND, "*.*")
                'Else
                '    _IMSS_GetTargetData(_IMSS_TARGET_NAME, _IMSS_LIST_FOUND, "*.IMSS")
            End If
        End If
        If _IMSS_For_ENCR_ListView.InvokeRequired = True Then
            Invoke(New MethodInvoker(Sub()
                                         _IMSS_AddTargetToList(_IMSS_LIST_FOUND, _IMSS_TARGET_NAME)
                                     End Sub))
        Else
            _IMSS_AddTargetToList(_IMSS_LIST_FOUND, _IMSS_TARGET_NAME)
        End If
    End Sub
    Private Sub _IMSS_AddTargetToList(ByRef _IMSS_TARGETS As List(Of BetterListViewItem), ByVal _IMSS_TARGET As String)
        _IMSS_For_ENCR_ListView.Items.Clear()
        If IO.Directory.Exists(IO.Path.Combine(_IMSS_TARGET, "PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")) Then _IMSS_For_ENCR_ListView.Tag = "_IMSS_DE" Else _IMSS_For_ENCR_ListView.Tag = "_IMSS_EN"
        _IMSS_For_ENCR_ListView.Groups(0).Items.AddRange(_IMSS_TARGETS) : _IMSS_TARGETS.Clear()
        For i = -376 To -752 Step -1 : _IMSS_MainPanel.Location = New Point(0, i) : Next : _IMSS_CollectingData.Enabled = False
    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _IMSS_For_ENCR_ListView.Items.Count = 0 Then
            If Not _IMSS_For_ENCR_ListView.SelectedItems.Count = 0 Then
                For Each _IMSS_SELECTED_ITEM In _IMSS_For_ENCR_ListView.SelectedItems
                    _IMSS_SELECTED_ITEM.Remove()
                Next
            End If
        End If
    End Sub

    Private Sub _IMSS_Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Back_Button.Click
        For i = -752 To 0 Step +1 : _IMSS_MainPanel.Location = New Point(0, i) : Next
    End Sub
    Private Sub _IMSS_CLEAR_PASSWORD_TEXTBOX()
        _IMSS_Password_TextBox.Clear()
        _IMSS_DecryptePassword_textBox.Clear()
    End Sub
    Private Sub _IMSS_Next_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Next_Button.Click
        _IMSS_CLEAR_PASSWORD_TEXTBOX()
        If _IMSS_For_ENCR_ListView.Tag = "_IMSS_EN" Then
            _IMSS_Encryptiontype_ComboBox.SelectedIndex = 0
            _IMSS_ENCR_Status_Label.Text = "Category : Encrypting Files"
            _IMSS_Password_Panel.BringToFront()
            _IMSS_Password_Panel.Size = New Size(621, 80)
            _IMSS_Password_Panel.Location = New Point(5, 1045)
            _IMSS_Password_Panel.Visible = True
        Else
            _IMSS_ENCR_Status_Label.Text = "Category : Decrypting Files"
            _IMSS_PAsswordDecrypte_Panel.BringToFront()
            _IMSS_PAsswordDecrypte_Panel.Size = New Size(621, 80)
            _IMSS_PAsswordDecrypte_Panel.Location = New Point(5, 1045)
            _IMSS_PAsswordDecrypte_Panel.Visible = True
        End If
    End Sub
    Private Sub _IMSS_Password_Next_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Password_Next_Button.Click
        If Not String.IsNullOrEmpty(_IMSS_Password_TextBox.Text) Then
            _IMSS_ENCR_Loading_PictureBox.Enabled = True
            _IMSS_ENCR_START_Panel.Size = New Size(621, 80)
            _IMSS_ENCR_START_Panel.Location = New Point(5, 1045)
            _IMSS_ENCR_START_Panel.Visible = True
            _IMSS_Password_Panel.Visible = False
            Dim _IMSS_THREAD As New Threading.Thread(Sub()
                                                         IMSS_ROOT_DECRYPTION._IMSS_ROOT_ENCRYPT(_IMSS_TARGET_DRIVE_NAME, _IMSS_TARGET_DRIVE_NAME & "PROTECTED_FILES", _IMSS_ENCR_Status_ProgressBar, _IMSS_ENCR_OUTPUT_Label)
                                                         IMSS_ROOT_DECRYPTION._IMSS_CREATE_ENCRYPTION_UINT(_IMSS_TARGET_DRIVE_NAME & "PROTECTED_FILES", "RT|" & _IMSS_Password_TextBox.Text)
                                                         If Not IO.Directory.Exists(IO.Path.Combine(_IMSS_TARGET_DRIVE_NAME, "IMSS_SERVER")) Then IO.Directory.CreateDirectory(IO.Path.Combine(_IMSS_TARGET_DRIVE_NAME, "IMSS_SERVER"))
                                                         If Not IO.File.Exists(_IMSS_TARGET_DRIVE_NAME & "IMSS_SERVER\IMSS_SERVER.exe") Then IO.File.WriteAllBytes(_IMSS_TARGET_DRIVE_NAME & "IMSS_SERVER\IMSS_SERVER.exe", My.Resources.IMSS_SERVER)
                                                         : _IMSS_OnComplete(True)
                                                     End Sub) : _IMSS_THREAD.Start()
        Else
            MessageBox.Show("Incorrect Password, Check if your inserted password is correct ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub _IMSS_PasswordBack_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_PasswordBack_Button.Click
        _IMSS_Password_Panel.Visible = False
    End Sub
    Private Sub _IMSS_OnComplete(ByVal _IMSS_STATUS As Boolean)
        _IMSS_RESET_LABELOUTPUT_VALUE()
        _IMSS_CLERA_LISTITEM()
        _IMSS_ClearControl()
        _IMSS_RESET_PROGRESSBAR_VALUE()
        _IMSS_ReloadControls()
        _IMSS_ReloadDrivesTarget(_IMSS_STATUS)
        _IMSS_BackOnComplete()
    End Sub

    Private Delegate Sub _IMSS_BackOnCompleteDelegate()
    Private Sub _IMSS_BackOnComplete()
        If _IMSS_MainPanel.InvokeRequired = True Then
            _IMSS_MainPanel.BeginInvoke(New _IMSS_BackOnCompleteDelegate(AddressOf _IMSS_BackOnComplete))
        Else
            For i = -752 To 0 Step +1 : _IMSS_MainPanel.Location = New Point(0, i) : Next
        End If
    End Sub
    Private Sub _IMSS_ReloadDrivesTarget(ByVal _IMSS_DRIVE_STATUS As Boolean)
        Dim X As Integer = 10
        Dim Y As Integer = 4
        For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            If d.DriveType = IO.DriveType.Removable And Not d.DriveType = DriveType.CDRom And d.IsReady = True Then
                Dim _IMSS_WINDOW_CONTROLLER As New IMSS_USB_DVICE With {
                                ._IMSS_TARGET_DRIVE_TEXT = d.Name.ToString(),
                                .Location = New Point(X, Y),
                                .Visible = True,
                                ._IMSS_TARGET_DRIVE_STATUS = _IMSS_DRIVE_STATUS}
                _IMSS_AddControl(_IMSS_WINDOW_CONTROLLER)
                X += 160
                If X > 640 Then : X = 10 : Y += 134 : End If
            End If
        Next
    End Sub
    Private Delegate Sub _IMSS_AddControlDelgate(ByRef _IMSS_CONTROL As IMSS_USB_DVICE)
    Private Sub _IMSS_AddControl(ByRef _IMSS_CONTROL As IMSS_USB_DVICE)
        If _IMSS_DvicesFound_Panel.InvokeRequired = True Then
            _IMSS_DvicesFound_Panel.BeginInvoke(New _IMSS_AddControlDelgate(AddressOf _IMSS_AddControl), _IMSS_CONTROL)
        Else
            _IMSS_DvicesFound_Panel.Controls.Add(_IMSS_CONTROL)
        End If
    End Sub
    Private Delegate Sub _IMSS_ClearControlDelgate()
    Private Sub _IMSS_ClearControl()
        If _IMSS_DvicesFound_Panel.InvokeRequired = True Then
            _IMSS_DvicesFound_Panel.BeginInvoke(New _IMSS_ClearControlDelgate(AddressOf _IMSS_ClearControl))
        Else
            _IMSS_DvicesFound_Panel.Controls.Clear()
        End If
    End Sub
    Private Delegate Sub _IMSS_CLERA_LISTITEMDelgate()
    Private Sub _IMSS_CLERA_LISTITEM()
        If _IMSS_For_ENCR_ListView.InvokeRequired = True Then
            _IMSS_For_ENCR_ListView.BeginInvoke(New _IMSS_CLERA_LISTITEMDelgate(AddressOf _IMSS_CLERA_LISTITEM))
        Else
            _IMSS_For_ENCR_ListView.Controls.Clear()
        End If
    End Sub
    Private Delegate Sub _IMSS_RESET_PROGRESSBAR_VALUEDelgate()
    Private Sub _IMSS_RESET_PROGRESSBAR_VALUE()
        If _IMSS_ENCR_Status_ProgressBar.InvokeRequired = True Then
            _IMSS_ENCR_Status_ProgressBar.BeginInvoke(New _IMSS_RESET_PROGRESSBAR_VALUEDelgate(AddressOf _IMSS_RESET_PROGRESSBAR_VALUE))
        Else
            _IMSS_ENCR_Status_ProgressBar.Value = 0
        End If
    End Sub
    Private Delegate Sub _IMSS_RESET_VALUE_LABELOUTPUT_VALUEDelgate()
    Private Sub _IMSS_RESET_LABELOUTPUT_VALUE()
        If _IMSS_ENCR_OUTPUT_Label.InvokeRequired = True Then
            _IMSS_ENCR_OUTPUT_Label.BeginInvoke(New _IMSS_RESET_VALUE_LABELOUTPUT_VALUEDelgate(AddressOf _IMSS_RESET_LABELOUTPUT_VALUE))
        Else
            _IMSS_ENCR_OUTPUT_Label.Text = "------"
        End If
    End Sub
    Private Delegate Sub _IMSS_ReloadControlsDelegate()
    Private Sub _IMSS_ReloadControls()
        If _IMSS_ENCR_START_Panel.InvokeRequired = True Then
            _IMSS_ENCR_START_Panel.BeginInvoke(New _IMSS_ReloadControlsDelegate(AddressOf _IMSS_ReloadControls))
        Else
            _IMSS_ENCR_START_Panel.Visible = False
        End If
    End Sub
    Private Sub _IMSS_DECRYPTE_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DECRYPTE_Button.Click
        If Not String.IsNullOrEmpty(_IMSS_DecryptePassword_textBox.Text) Then
            If IO.File.Exists(IO.Path.Combine(_IMSS_TARGET_DRIVE_NAME, "PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\IMSS_PASSWD.IMSSDATA")) Then
                Dim _IMSS_OutPasswordText() As String = IO.File.ReadAllText(IO.Path.Combine(_IMSS_TARGET_DRIVE_NAME, "PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\IMSS_PASSWD.IMSSDATA")).Split("|")
                If _IMSS_DecryptePassword_textBox.Text = _IMSS_OutPasswordText(1) Then
                    _IMSS_ENCR_Loading_PictureBox.Enabled = True
                    _IMSS_ENCR_START_Panel.Size = New Size(621, 80)
                    _IMSS_ENCR_START_Panel.Location = New Point(5, 1045)
                    _IMSS_ENCR_START_Panel.Visible = True
                    _IMSS_PAsswordDecrypte_Panel.Visible = False
                    Dim _IMSS_THREAD As New Threading.Thread(Sub()
                                                                 IMSS_ROOT_DECRYPTION._IMSS_ROOT_DECRYPT(_IMSS_TARGET_DRIVE_NAME, _IMSS_TARGET_DRIVE_NAME & "PROTECTED_FILES", _IMSS_ENCR_Status_ProgressBar, _IMSS_ENCR_OUTPUT_Label)
                                                                 If IO.Directory.Exists(IO.Path.Combine(_IMSS_TARGET_DRIVE_NAME, "IMSS_SERVER")) Then IO.Directory.Delete(IO.Path.Combine(_IMSS_TARGET_DRIVE_NAME, "IMSS_SERVER"), True)
                                                                 _IMSS_OnComplete(False)
                                                                 Try : Process.Start(_IMSS_TARGET_DRIVE_NAME) : Catch : End Try
                                                             End Sub) : _IMSS_THREAD.Start()
                Else
                    MessageBox.Show("Incorrect Password, Check if your inserted password is correct ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    _IMSS_DecryptePassword_textBox.Clear()
                End If
            End If
        Else
            MessageBox.Show("Incorrect Password, Check if your inserted password is correct ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            _IMSS_DecryptePassword_textBox.Clear()
        End If
    End Sub

    Private Sub _IMSS_DECRYPTE_BACK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DECRYPTE_BACK_Button.Click
        _IMSS_PAsswordDecrypte_Panel.Visible = False
    End Sub

End Class
