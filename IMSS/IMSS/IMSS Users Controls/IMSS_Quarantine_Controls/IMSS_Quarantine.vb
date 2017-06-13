Imports System.Security.AccessControl
Imports System.IO
Imports ComponentOwl.BetterListView
Imports ConfigurationResureses

Public Class IMSS_Quarantine
    Private Shared _IMSS_CONTROL As IMSS_Quarantine
    Private Shared _IMSS_Q As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSS"

    Friend Shared Function _IMSS_CREATE_CONTROL() As IMSS_Quarantine
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_Quarantine
            _IMSS_CONTROL.Dock = DockStyle.Fill
        Else
            _IMSS_CONTROL._IMSS_Quarantine_Log.Visible = False
            _IMSS_CONTROL._IMSS_Q_Systems_Starts(True)
        End If
        Return _IMSS_CONTROL
    End Function


    Private Sub _IMSS_QuarantineRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_QuarantineRoom.Click
        _IMSS_SetMenuButtonBackColor_QuarantineRoom(Color.White, Color.AliceBlue, _IMSS_QuarantineRoom)
        _IMSS_Quarantine_Log.Visible = False
        _IMSS_Q_Systems_Starts(False)
    End Sub

#Region " IMSS Private Functions Uint"
    Private Sub _IMSS_SetMenuButtonBackColor_QuarantineRoom(ByVal _IMSS_Button1_Color As Color, ByVal _IMSS_Button2_Color As Color, ByRef _IMSS_TARGET_BUTTON As Button)
        _IMSS_QuarantineRoom.BackColor = _IMSS_Button1_Color
        _IMSS_Log.BackColor = _IMSS_Button2_Color

        Dim _IMSS_Font As New Font("MS Reference Sans Serif", 9.75, FontStyle.Regular)
        _IMSS_QuarantineRoom.Font = _IMSS_Font
        _IMSS_QuarantineRoom.FlatAppearance.BorderSize = 0
        _IMSS_Log.Font = _IMSS_Font
        _IMSS_Log.FlatAppearance.BorderSize = 0

        _IMSS_TARGET_BUTTON.Font = New Font("MS Reference Sans Serif", 8.0, FontStyle.Bold)

        _IMSS_TARGET_BUTTON.FlatAppearance.BorderSize = 1
        _IMSS_TARGET_BUTTON.FlatAppearance.BorderColor = Color.LightGray

        _IMSS_CONTROL_PANEL.Focus()


    End Sub
    Private Sub _IMSS_Q_Load()
        _QSecurityLog.Clear()
        Try
            Dim _IMSS_LOAD As New IMSS_LOGS_OPER : Application.DoEvents()
            With _IMSS_LOAD
                If ._IMSS_Connect = 1 Then
                    If ._IMSS_LOAD_TARGET_LIST(3, _QSecurityLog) = 1 Then
                    End If ' IMSS Else Catch Error
                End If
                If ._IMSS_Disconnect() = 1 Then .Dispose() Else ._IMSS_FORCE_COLSE() : .Dispose()
            End With
        Catch : End Try
    End Sub

#Region "IMSS Start the Deleter Process"
    Private Delegate Sub _IMSS_RemoveItemsDelegate(ByRef _IMSS_Target As Object)
    Private Sub _IMSS_RemoveItems(ByRef _IMSS_Target As Object)
        If _IMSSQ.InvokeRequired Then
            _IMSSQ.Invoke(New _IMSS_RemoveItemsDelegate(AddressOf _IMSS_RemoveItems), _IMSS_Target)
        Else
            _IMSSQ.Items.Remove(_IMSS_Target)
        End If
    End Sub
    Private Sub _IMSS_ChangeLabelVisbalty(ByRef _IMSS_Target As Object)
        If Label36.InvokeRequired Then
            Label36.Invoke(New _IMSS_RemoveItemsDelegate(AddressOf _IMSS_ChangeLabelVisbalty), _IMSS_Target)
        Else
            Label36.Visible = _IMSS_Target
        End If
    End Sub
    Private Sub _IMSS_CLEEANUP()
        For Each _IMSSQ_Items In _IMSSQ.CheckedItems
            Try
                For Each _IMSS_Todelete As String In ListBox1.Items
                    If _IMSS_Todelete.Contains(_IMSSQ_Items.Text) Then
                        IO.File.Delete(_IMSS_Todelete.ToString())
                        ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Quarantine : " + Date.Now.ToString + " :##:> " + _IMSS_Todelete.ToString() + " Has been Deleted ", 3)
                        _IMSSQ.Items.Remove(_IMSSQ_Items)
                    End If
                Next _IMSS_Todelete
            Catch ex As Exception
                MessageBox.Show("ERROR: " + ex.Message, "IMSSQ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next _IMSSQ_Items
        ' IMSS On Complete
        If _IMSSQ.Items.Count > 0 Then
            _IMSS_ChangeLabelVisbalty(False)
        Else
            _IMSS_ChangeLabelVisbalty(True)
        End If
        MessageBox.Show("Files was deleted successfully !", "IMSSQ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

    Private Sub _IMSS_Q_Systems_Starts(ByVal _IMSS_PlaySiundOrNot As Boolean)
        On Error Resume Next
        MainMain.PictureBox29.Visible = True
        MainMain.PictureBox29.Enabled = True
        _IMSS_CONTROL_PANEL.Location = New Point(4, 3)
        Label36.Visible = False
        _IMSS_QuarantineRoom_Panel.Location = New Point(184, 3)
        _IMSS_QuarantineRoom_Panel.Size = New Size(640, 391)
        _IMSS_Quarantine_Log.Visible = False
        _IMSS_QuarantineRoom_Panel.Visible = True
        _IMSSQ.Items.Clear()
        ListBox1.Items.Clear()
        If Not _IMSSQ_BackgroundWorker.IsBusy = True Then
            _IMSSQ_BackgroundWorker.RunWorkerAsync()
        End If
        If _IMSS_PlaySiundOrNot = True Then
            '  My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub _IMSS_QuarantineSystemsExitMasseages(ByVal _IMSS_Massesage As String)
        On Error Resume Next
        If MessageBox.Show(_IMSS_Massesage, "IMSS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            _IMSS_Q_Clear_Log()
        Else
            System.Threading.Thread.Sleep(400)
        End If
    End Sub

    Private Sub _IMSS_Q_Clear_Log()
        _QSecurityLog.Clear()
        Dim _IMSS_CLEAR_LOGS As New IMSS_LOGS_OPER
        With _IMSS_CLEAR_LOGS
            If ._IMSS_Connect() = 1 Then
                ._IMSS_DELETE_TARGET(3)
            End If
            If ._IMSS_Disconnect() = 1 Then .Dispose() Else ._IMSS_FORCE_COLSE() : .Dispose()
        End With
    End Sub

#End Region

    Private Sub _IMSSQ_BackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSSQ_BackgroundWorker.DoWork
        On Error Resume Next
        Label36.Visible = False
        Dim fs As FileSystemSecurity = File.GetAccessControl(_IMSS_Q + "\IMSSQ")
        fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        File.SetAccessControl(_IMSS_Q + "\IMSSQ", fs)
        System.Threading.Thread.Sleep(1000)
        Dim arr(4) As String
        Dim fi As FileInfo
        Dim itm As BetterListViewItem
        For Each foundFilex As String In Directory.GetFiles(_IMSS_Q + "\IMSSQ", "*.IMSSQ")
            fi = New FileInfo(foundFilex)
            arr(0) = fi.Name
            arr(1) = fi.CreationTime.ToString
            arr(2) = "Risky"
            arr(3) = fi.Length & " Byte"
            arr(4) = ".IMSSQ"
            itm = New BetterListViewItem(arr)
            itm.ImageIndex = 0
            itm.Checked = True
            _IMSSQ.Items.Add(itm)
            ListBox1.Items.Add(fi.FullName.ToString)
        Next
    End Sub

    Private Sub _IMSSQ_BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSSQ_BackgroundWorker.RunWorkerCompleted
        On Error Resume Next
        MainMain.PictureBox29.Visible = False
        MainMain.PictureBox29.Enabled = False
        If _IMSSQ.Items.Count > 0 Then
            Label36.Visible = False
        Else
            Label36.Visible = True
        End If
    End Sub

    Private Sub IMSS_Quarantine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_SetMenuButtonBackColor_QuarantineRoom(Color.White, Color.AliceBlue, _IMSS_QuarantineRoom)
        _IMSS_Quarantine_Log.Visible = False
        _IMSS_Q_Systems_Starts(True)
    End Sub

#Region " IMSS Button Click Uint"
    Private Sub _IMSS_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Log.Click
        _IMSS_SetMenuButtonBackColor_QuarantineRoom(Color.AliceBlue, Color.White, _IMSS_Log)
        _IMSS_Quarantine_Log.Location = New Point(184, 3)
        _IMSS_Quarantine_Log.Size = New Size(640, 391)
        _IMSS_QuarantineRoom_Panel.Visible = False
        _IMSS_Quarantine_Log.Visible = True
        _IMSS_Q_Load()
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        Try
            If _IMSSQ.Items.Count > 0 Then
                If MessageBox.Show("Are you sure you want to restore selected files ?", "IMSSQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\IMSS Restored Files") Then IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\IMSS Restored Files")
                    For Each _IMSSQ_Items In _IMSSQ.CheckedItems
                        For Each _IMSS_Todelete As String In ListBox1.Items
                            If _IMSS_Todelete.Contains(_IMSSQ_Items.Text) Then
                                IO.File.Copy(_IMSS_Todelete.ToString, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\IMSS Restored Files" + "\" + _IMSSQ_Items.Text + ".exe")
                                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Quarantine : " + Date.Now.ToString + " :##:> " + _IMSS_Todelete.ToString + " Have been restore to > " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\IMSS Restored Files" + "\" + _IMSSQ_Items.Text + ".exe", 3)
                                System.Threading.Thread.Sleep(40)
                                IO.File.Delete(_IMSS_Todelete.ToString)
                                _IMSSQ.Items.Remove(_IMSSQ_Items)
                            End If
                        Next
                    Next
                    If IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\IMSS Restored Files") Then Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\IMSS Restored Files")
                End If
            Else
                MessageBox.Show("Quarantine is empty !", "IMSSQ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " + ex.Message, "IMSSQ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        If _IMSSQ.Items.Count > 0 Then
            If MessageBox.Show("Are you sure you want to clear Quarantine ?", "IMSSQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If IO.Directory.Exists(_IMSS_Q + "\IMSSQ") Then
                    Try
                        For Each foundFilex As String In Directory.GetFiles(_IMSS_Q + "\IMSSQ", "*.IMSSQ")
                            Try
                                IO.File.Delete(foundFilex.ToString())
                                ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Quarantine : " + Date.Now.ToString() + " :##:> " + foundFilex.ToString() + " has been Deleted ", 3)
                            Catch ex As Exception
                                MessageBox.Show("ERROR: " + ex.Message, "IMSSQ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Next
                    Catch ex As Exception
                        MessageBox.Show("ERROR: " + ex.Message, "IMSSQ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        _IMSSQ.Items.Clear()
                        MessageBox.Show("Quarantine cleared successfully !", "IMSSQ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    If _IMSSQ.Items.Count > 0 Then
                        Label36.Visible = False
                    Else
                        Label36.Visible = True
                    End If
                End If
            End If
        Else
            MessageBox.Show("Quarantine is empty !", "IMSSQ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        On Error Resume Next
        If _IMSSQ.Items.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete selected files ?", "IMSSQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim _IMSS_THREAD As New Threading.Thread(AddressOf _IMSS_CLEEANUP) : _IMSS_THREAD.Start()
            End If
        Else
            MessageBox.Show("Quarantine is empty !", "IMSSQ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        On Error Resume Next
        _IMSSQ.Items.Clear()
        ListBox1.Items.Clear()
        _IMSSQ_BackgroundWorker.RunWorkerAsync()
    End Sub

#End Region

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        On Error Resume Next
        _IMSS_QuarantineSystemsExitMasseages("Are you sure you want to clear quarantine systems log data ?")
    End Sub
    Private Sub PictureBox35_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox35.MouseEnter
        PictureBox35.Width = 71
        PictureBox35.Height = 61
    End Sub

    Private Sub PictureBox35_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox35.MouseLeave
        PictureBox35.Width = 66
        PictureBox35.Height = 56
    End Sub
End Class
