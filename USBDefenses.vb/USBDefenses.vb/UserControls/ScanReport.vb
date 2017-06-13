Imports System.Windows.Forms
Imports System.Security.AccessControl

Public Class ScanReport

    Friend Property _IMSS_USB_TARGET_VAR As String = String.Empty

    Private Sub _IMSS_SLIDE_OUT_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SLIDE_OUT_BUTTON.Click
        For i As Integer = 0 To 194 Step 1 : _IMSS_SLIDE_OUT_PANEL.Location = New System.Drawing.Point(_IMSS_SLIDE_OUT_PANEL.Location.X, _IMSS_SLIDE_OUT_PANEL.Location.Y - 1) : Next i
    End Sub

    Private Sub _IMSS_RESULT_THREAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RESULT_THREAT.Click
        For i As Integer = 0 To 194 Step 1 : _IMSS_SLIDE_OUT_PANEL.Location = New System.Drawing.Point(_IMSS_SLIDE_OUT_PANEL.Location.X, _IMSS_SLIDE_OUT_PANEL.Location.Y + 1) : Next i
    End Sub

    Private Sub _IMSS_EXIT_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_EXIT_BUTTON.Click
        Try : Process.Start(_IMSS_USB_TARGET_VAR) : Catch : End Try
    End Sub

    Private Sub _IMSS_STARTONLINEHELP_LINKLABEL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_STARTONLINEHELP_LINKLABEL.LinkClicked
        _IMSS_ONLINE_HELP_LINKLABEL_LinkClicked(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_ONLINE_HELP_LINKLABEL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_ONLINE_HELP_LINKLABEL.LinkClicked
        Process.Start(ConfigurationResureses.LinkVar._IMSS_RemoteHostURL)
    End Sub

    Private Sub _IMSS_DELETE_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DELETE_BUTTON.Click

        Me._IMSS_LOADING_PICTUREBOX.Enabled = True
        Me._IMSS_LOADING_PICTUREBOX.Visible = True

        Dim _IMSS_SUCSESS_ON_DELETE As Integer = _IMSS_THREAT_LISTVIEW.Items.Count()

        For Each _IMSS_ITEM As ListViewItem In _IMSS_THREAT_LISTVIEW.CheckedItems

            Application.DoEvents()

            _IMSS_ITEM.EnsureVisible()

            If _IMSS_DELETE_FILE(_IMSS_ITEM.Tag.ToString()) = True Then
                _IMSS_ITEM.UseItemStyleForSubItems = False
                _IMSS_ITEM.SubItems(1).ForeColor = Drawing.Color.Green()
                _IMSS_ITEM.ImageIndex = 1
            Else
                _IMSS_ITEM.SubItems(1).ForeColor = Drawing.Color.Red()
                _IMSS_ITEM.ImageIndex = 0
                _IMSS_SUCSESS_ON_DELETE -= 1
            End If

        Next _IMSS_ITEM

        _IMSS_THREAT_LISTVIEW.CheckBoxes = False

        Me._IMSS_NUMBEROFTHREAD.Text = _IMSS_SUCSESS_ON_DELETE & " Threat successfully deleted."
        Me._IMSS_THREAD_STATUS.Text = "Delete command was sent."
        Me._IMSS_THREAD_STATUS.ForeColor = System.Drawing.Color.Green()
        Me._IMSS_DELETE_BUTTON.Enabled = False
        Me._IMSS_QUARANTINE_BUTTON.Enabled = False

        Me._IMSS_LOADING_PICTUREBOX.Enabled = False
        Me._IMSS_LOADING_PICTUREBOX.Visible = False

        Me._IMSS_SLIDE_OUT_BUTTON.PerformClick()

    End Sub

    Private Function _IMSS_DELETE_FILE(ByVal _IMSS_TARGET_FILE As String) As Boolean
        Try
            If IO.File.Exists(_IMSS_TARGET_FILE) Then
                IO.File.Delete(_IMSS_TARGET_FILE)
            End If
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub _IMSS_QUARANTINE_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_QUARANTINE_BUTTON.Click

        Me._IMSS_LOADING_PICTUREBOX.Enabled = True
        Me._IMSS_LOADING_PICTUREBOX.Visible = True

        ' Open the quarantine folder.

        _IMSS_OPEN_QUARANTINE_FOLDER()


        Dim _IMSS_SUCSESS_ON_DELETE As Integer = _IMSS_THREAT_LISTVIEW.Items.Count()


        For Each _IMSS_ITEM As ListViewItem In _IMSS_THREAT_LISTVIEW.CheckedItems

            Application.DoEvents()

            _IMSS_ITEM.EnsureVisible()

            Try : _IMSS_MOVE_TO_QUARANTINE_FOLDER(_IMSS_ITEM.Tag.ToString()) : Catch : End Try

            If _IMSS_DELETE_FILE(_IMSS_ITEM.Tag.ToString()) = True Then
                _IMSS_ITEM.UseItemStyleForSubItems = False
                _IMSS_ITEM.SubItems(1).ForeColor = Drawing.Color.Green()
                _IMSS_ITEM.ImageIndex = 1
            Else
                _IMSS_ITEM.SubItems(1).ForeColor = Drawing.Color.Red()
                _IMSS_ITEM.ImageIndex = 0
                _IMSS_SUCSESS_ON_DELETE -= 1
            End If

        Next _IMSS_ITEM




        ' Close the quarantine folder.

        _IMSS_CLOSE_QUARANTINE_FOLDER()


        _IMSS_THREAT_LISTVIEW.CheckBoxes = False

        Me._IMSS_NUMBEROFTHREAD.Text = _IMSS_SUCSESS_ON_DELETE & " Threat successfully moved to quarantine."
        Me._IMSS_THREAD_STATUS.Text = "Quarantine command was sent."
        Me._IMSS_THREAD_STATUS.ForeColor = System.Drawing.Color.Green()
        Me._IMSS_DELETE_BUTTON.Enabled = False
        Me._IMSS_QUARANTINE_BUTTON.Enabled = False

        Me._IMSS_LOADING_PICTUREBOX.Enabled = False
        Me._IMSS_LOADING_PICTUREBOX.Visible = False

        Me._IMSS_SLIDE_OUT_BUTTON.PerformClick()

    End Sub

    Private Sub _IMSS_OPEN_QUARANTINE_FOLDER()
        Dim fs As FileSystemSecurity = IO.File.GetAccessControl(ConfigurationResureses.LinkVar._IMSS_Q + "\IMSSQ")
        fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        IO.File.SetAccessControl(ConfigurationResureses.LinkVar._IMSS_Q + "\IMSSQ", fs)
    End Sub

    Private Sub _IMSS_MOVE_TO_QUARANTINE_FOLDER(ByVal _IMSS_THREAT_TARGET As String)

        ' Make random number for file name.

        Dim _IMSS_RandomNames As New Random()
        Dim _IMSS_RandomValue As Integer = _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10)

        ' Move file to quarantine folder.

        IO.File.Copy(_IMSS_THREAT_TARGET, ConfigurationResureses.LinkVar._IMSS_Q + "\IMSSQ" + "\" + "THREAT-ID-" + _IMSS_RandomValue.ToString + ".IMSSQ")

        ' Register the file movment in the log section.

        _IMSS_SQL_INSERT("IMSS Quarantine : " + Date.Now.ToString + " :##:> " + _IMSS_THREAT_TARGET + " Has been moved to quarantine ", 3)

        ' Make a new random number.

        _IMSS_RandomValue = 0
        _IMSS_RandomValue = _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10) & _IMSS_RandomNames.Next(0, 10)

    End Sub

    Private Sub _IMSS_CLOSE_QUARANTINE_FOLDER()
        Dim fs As FileSystemSecurity = IO.File.GetAccessControl(ConfigurationResureses.LinkVar._IMSS_Q + "\IMSSQ")
        fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        IO.File.SetAccessControl(ConfigurationResureses.LinkVar._IMSS_Q + "\IMSSQ", fs)
    End Sub

    Private Sub _IMSS_SQL_INSERT(ByVal _IMSS_STATUS As String, ByVal _IMSS_OPER As Integer)
        Try
            Dim _IMSS_SQL_TARGET As New ConfigurationResureses.IMSS_LOGS_OPER
            If _IMSS_SQL_TARGET._IMSS_Connect() = 1 Then
                _IMSS_SQL_TARGET._IMSS_INSERT_INTO(_IMSS_STATUS, _IMSS_OPER)
            End If
            If _IMSS_SQL_TARGET._IMSS_Disconnect() = 1 Then _IMSS_SQL_TARGET.Dispose() Else _IMSS_SQL_TARGET._IMSS_FORCE_COLSE() : _IMSS_SQL_TARGET.Dispose()
        Catch : End Try
    End Sub

End Class
