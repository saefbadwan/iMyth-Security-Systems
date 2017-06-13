Public Class MainWindow

    Private _IMSS_TARGET_USB_DRIVE As String = String.Empty

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Size = New Size(543, 199)

        _IMSS_ANALYZE_TREEVIEW.BeginUpdate()

        _IMSS_ANALYZE_WORKER.RunWorkerAsync()

    End Sub

    Private Sub _IMSS_ANALYZE_WORKER_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_ANALYZE_WORKER.DoWork

        Dim _IMSS_ARGUMENT_TEXT As String = String.Empty
        For Each _IMSS_ARGUMENT In My.Application.CommandLineArgs
            _IMSS_ARGUMENT_TEXT += _IMSS_ARGUMENT
        Next _IMSS_ARGUMENT

        _IMSS_TARGET_USB_DRIVE = _IMSS_ARGUMENT_TEXT.Substring(0, 2)

        Dim _IMSS_REMOVE_SPECAL_CHARS() As String = _IMSS_ARGUMENT_TEXT.Split("|")

        For i As Integer = 0 To _IMSS_REMOVE_SPECAL_CHARS.Length - 1 Step 1
            _IMSS_REMOVE_SPECAL_CHARS(i) = _IMSS_REMOVE_SPECAL_CHARS(i).Replace("*", " ")
        Next i

        If _IMSS_REMOVE_SPECAL_CHARS.Length() > 0 Then
            IMSS_AnalyzeBehaviour._IMSS_START_BEHAVIOUR_ANALYZER(_IMSS_CURRENT_SANNING_Label, _IMSS_StepIndicator, _IMSS_ANALYZE_TREEVIEW, _IMSS_REMOVE_SPECAL_CHARS)
        End If

    End Sub

    Private Sub _IMSS_ANALYZE_WORKER_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSS_ANALYZE_WORKER.RunWorkerCompleted

        _IMSS_ANALYZE_TREEVIEW.EndUpdate()


        If _IMSS_ANALYZE_TREEVIEW.Nodes.Count() > 0 Then

            _IMSS_ON_COMPLETE_PANEL.Visible = True
            _IMSS_ON_COMPLETE_PANEL.BringToFront()
            _IMSS_CLEANUPALLTHREATS_BUTTON.Visible = True

            For i As Integer = Me.Height To 481 Step 4
                Application.DoEvents()
                Me.Height = i
            Next i

        Else
            Me._IMSS_MainPanel.Controls.Clear()
            Me._IMSS_MainPanel.Controls.Add(New IMSS_SCANCLEAN With {.Dock = DockStyle.Fill})
            Me.MaximumSize = Me.Size()
        End If


    End Sub

    Private Sub _IMSS_CANCEL_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CANCEL_BUTTON.Click
        _IMSS_ANALYZE_WORKER.CancelAsync()
        Application.Exit()
    End Sub

    Private Sub _IMSS_CLEANUPALLTHREATS_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CLEANUPALLTHREATS_BUTTON.Click

        _IMSS_CLEANUP_PROGRESSBAR.Visible = True



        For Each _IMSS_ITEM As TreeNode In _IMSS_ANALYZE_TREEVIEW.Nodes

            For Each _IMSS_SUB_ITEM As TreeNode In _IMSS_ITEM.Nodes
                Application.DoEvents()
                If _IMSS_SUB_ITEM.Text = "PROCESSES" Then
                    For Each _IMSS_SUB_SUB_ITEM As TreeNode In _IMSS_SUB_ITEM.Nodes
                        If _IMSS_SUB_SUB_ITEM.Text.Contains("PROCESS PID") Then
                            If _IMSS_CLEAN_UP_PROCESS(Process.GetProcessById(CType(_IMSS_SUB_SUB_ITEM.Tag(), Integer))) = True Then
                                _IMSS_SUB_ITEM.ImageIndex = 9
                            Else
                                _IMSS_SUB_ITEM.ImageIndex = 10
                            End If
                        End If
                    Next

                ElseIf _IMSS_SUB_ITEM.Text = "REGISTRY" Then
                    For Each _IMSS_SUB_SUB_ITEM As TreeNode In _IMSS_SUB_ITEM.Nodes
                        If _IMSS_CLEAN_UP_REGISTRY(New String() {_IMSS_SUB_SUB_ITEM.Tag().ToString(), _IMSS_SUB_SUB_ITEM.Text.Split(":")(1).ToString()}) = True Then
                            _IMSS_SUB_ITEM.ImageIndex = 9
                        Else
                            _IMSS_SUB_ITEM.ImageIndex = 10
                        End If
                    Next
                ElseIf _IMSS_SUB_ITEM.Text = "FILES SYSTEM" Then
                    For Each _IMSS_SUB_SUB_ITEM As TreeNode In _IMSS_SUB_ITEM.Nodes
                        If _IMSS_CLEAN_UP_SYSTEMFILES(_IMSS_SUB_SUB_ITEM.Tag.ToString()) = True Then
                            _IMSS_SUB_ITEM.ImageIndex = 9
                        Else
                            _IMSS_SUB_ITEM.ImageIndex = 10
                        End If
                    Next

                End If
            Next _IMSS_SUB_ITEM

        Next _IMSS_ITEM

        If IO.Directory.Exists(_IMSS_TARGET_USB_DRIVE) Then
            For Each _IMSS_FILE In My.Computer.FileSystem.GetFiles(_IMSS_TARGET_USB_DRIVE, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
                Try
                    Application.DoEvents()
                    IO.File.SetAttributes(_IMSS_FILE, IO.FileAttributes.Normal)
                Catch : End Try
            Next _IMSS_FILE

            For Each _IMSS_DIR In My.Computer.FileSystem.GetDirectories(_IMSS_TARGET_USB_DRIVE, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
                Try
                    Application.DoEvents()
                    Dim _IMSS_DIR_INFO As New IO.DirectoryInfo(_IMSS_DIR)
                    _IMSS_DIR_INFO.Attributes = IO.FileAttributes.Normal
                Catch : End Try
            Next _IMSS_DIR

        End If

        _IMSS_CLEANUP_PROGRESSBAR.Visible = False
        _IMSS_IS_COMPLETED_Label.Image = My.Resources._IMSS_StatusOn_Icon_16x16
        _IMSS_CLEANUPALLTHREATS_BUTTON.Visible = False
        _IMSS_IS_COMPLETED_Label.Text = "      Clean up process is completed"
        _IMSS_STATUS_DESCRIPTION_LABEL.Text = "The selected files has been cleaned up as it shown below in the list."
        _IMSS_CANCEL_BUTTON.Text = "Finish"

    End Sub


    Private Function _IMSS_CLEAN_UP_PROCESS(ByRef _IMSS_PROCESS As Process) As Boolean
        Try
            _IMSS_PROCESS.Kill()
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Function _IMSS_CLEAN_UP_REGISTRY(ByVal _IMSS_REGISTRY_PATH() As String) As Boolean
        Try
            If _IMSS_REGISTRY_PATH(0).Contains("HKEY_LOCAL_MACHINE") Then
                My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(_IMSS_REGISTRY_PATH(1).Remove(0, 1))
            Else
                My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(_IMSS_REGISTRY_PATH(1).Remove(0, 1))
            End If
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Function _IMSS_CLEAN_UP_SYSTEMFILES(ByVal _IMSS_FILE As String) As Boolean
        Try
            IO.File.Delete(_IMSS_FILE)
            Return True
        Catch
            Return False
        End Try
    End Function

End Class
