'بسم الله الرحمن الرحيم

Imports System.IO
Imports System.Windows.Forms

Public Class _IMSS_USBF
    Private request, strName As String
    Private MyProcess As New Process()
    Private isFormating As Boolean = False
    Private FixedHardDriveName As String
    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        Try
            MyBase.OnMouseDown(e)
            If e.Button = MouseButtons.Left Then
                Me.Capture = False
                Me.WndProc(Message.Create(Me.Handle, &HA1, New IntPtr(2), IntPtr.Zero))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub fade_in()
        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            Threading.Thread.Sleep(20)
        Next : Me.Refresh()
    End Sub
    Private Sub fade_out()
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Threading.Thread.Sleep(20)
        Next : Me.Refresh()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonFormat.Click
        Dim SelectedDrive As New DriveInfo(comboBoxDrives.Text)
        If MessageBox.Show("You want to format really?", "IMSS Info", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If SelectedDrive.DriveType = DriveType.Removable Then
                'check if quick format checkbox is checked
                If checkBoxQuickformat.Checked = False Then
                    strName = textBoxVolumeLabel.Text.Trim()
                    'note the below line can also work on limited/standard user
                    request = "Format /v:" + strName + " /x /backup " + SelectedDrive.Name.Replace("\", " ")
                    MyProcess.StartInfo.RedirectStandardOutput = True
                    MyProcess.StartInfo.RedirectStandardError = True
                    MyProcess.StartInfo.CreateNoWindow = True
                    MyProcess.StartInfo.UseShellExecute = False
                    'this try statement is here to avoid the application to crash,
                    'when the is no enough space, read-only location
                    Try
                        File.WriteAllText("batman.bat", request + Environment.NewLine)
                    Catch m As IOException
                        MessageBox.Show(m.Message.ToString())
                        buttonFormat.Enabled = True
                        Return
                    End Try
                    MyProcess.StartInfo.FileName = "batman.bat"
                    'START the process
                    MyProcess.Start()
                    Timer1.Enabled = True
                Else
                    strName = textBoxVolumeLabel.Text.Trim()
                    'note this line can also work on LIMITED/STANDARD USER
                    request = "Format /v:" + strName + " /x /Q /backup " + SelectedDrive.Name.Replace("\", " ")
                    MyProcess.StartInfo.RedirectStandardOutput = True
                    MyProcess.StartInfo.RedirectStandardError = True
                    MyProcess.StartInfo.CreateNoWindow = True
                    MyProcess.StartInfo.UseShellExecute = False
                    'this try statement is here to avoid the application to crash,
                    'when the is no enough space, read-only location
                    Try
                        File.WriteAllText("batman.bat", request + Environment.NewLine)
                    Catch m As IOException
                        MessageBox.Show(m.Message.ToString())
                        buttonFormat.Enabled = True
                        Return
                    End Try
                    MyProcess.StartInfo.FileName = "batman.bat"
                    'START the process
                    MyProcess.Start()
                    Timer1.Enabled = True
                End If
            End If
        ElseIf SelectedDrive.DriveType = DriveType.Fixed Then
            If checkBoxQuickformat.Checked = False Then
                MyProcess.StartInfo.RedirectStandardOutput = True
                MyProcess.StartInfo.RedirectStandardError = True
                MyProcess.StartInfo.CreateNoWindow = True
                MyProcess.StartInfo.UseShellExecute = False
                Try
                    File.WriteAllText("batman.bat", "Format /x /v:" & textBoxVolumeLabel.Text & " " & comboBoxDrives.SelectedItem.ToString())
                Catch m As IOException
                    MessageBox.Show(m.Message.ToString())
                    buttonFormat.Enabled = True
                    Return
                End Try
                MyProcess.StartInfo.FileName = "batman.bat"
                'START the process
                MyProcess.Start()
                Timer1.Enabled = True
            Else
                MyProcess.StartInfo.RedirectStandardOutput = True
                MyProcess.StartInfo.RedirectStandardError = True
                MyProcess.StartInfo.CreateNoWindow = True
                MyProcess.StartInfo.UseShellExecute = False
                Try
                    File.WriteAllText("batman.bat", "Format /q /x /v:" & textBoxVolumeLabel.Text & " " & comboBoxDrives.SelectedItem.ToString())
                Catch m As IOException
                    MessageBox.Show(m.Message.ToString())
                    buttonFormat.Enabled = True
                    Return
                End Try
                MyProcess.StartInfo.FileName = "batman.bat"
                'START the process
                MyProcess.Start()
                Timer1.Enabled = True
            End If


        End If
    End Sub

    Private Sub USBF_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isFormating = True Then
            e.Cancel = False
        Else
            If (File.Exists("batman.bat") = True) Then
                'delete the batman.bat file
                File.Delete("batman.bat")
            End If
            fade_out()
        End If
        'check if the application is closed by a taskmanager
        If e.CloseReason = CloseReason.TaskManagerClosing Then
            If File.Exists("batman.bat") = True Then
                'delete the batman.bat file
                File.Delete("batman.bat") '
            End If
            fade_out()
        End If
    End Sub

    Private Sub USBF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.Height = 0
        Timer2.Enabled = True
        'get all attached removable drives 
        For Each AttachedDrive In Environment.GetLogicalDrives()
            Dim CompDrive As New DriveInfo(AttachedDrive)
            If Not CompDrive.Name = "A:\" And Not CompDrive.Name = "B:\" Then
                'allow only removable and fixed drives to be added in the combobox
                If (CompDrive.DriveType = DriveType.Removable Or CompDrive.DriveType = DriveType.Fixed) Then
                    'add drive name into the combobox
                    comboBoxDrives.Items.Add(CompDrive.Name)
                End If
            End If
        Next
        isFormating = False
        'select the first item on the combobox
        comboBoxDrives.SelectedIndex = 0
        Dim computerdrive As New DriveInfo(comboBoxDrives.SelectedItem.ToString())
        textBoxVolumeLabel.Text = computerdrive.VolumeLabel
        fade_in()
    End Sub
    Private Sub comboBoxDrives_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxDrives.SelectionChangeCommitted
        Dim SelectedDrive As New DriveInfo(comboBoxDrives.Text)
        If SelectedDrive.IsReady = True Then
            If SelectedDrive.VolumeLabel = String.Empty Then
                textBoxVolumeLabel.Text = "Removable Disc"
                FixedHardDriveName = SelectedDrive.VolumeLabel
            Else
                FixedHardDriveName = SelectedDrive.VolumeLabel
                textBoxVolumeLabel.Text = SelectedDrive.VolumeLabel
            End If

        End If

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Application.DoEvents()
        If labelProgress.Text.Contains("Volume Serial") = False Then

            'check if format was aborted
            If labelProgress.Text.Contains("Format aborted.") = False Then
                labelInfo.Text = "Please wait, formater is busy..."
                Application.DoEvents()
                'get the current progress
                Try : labelProgress.Text = MyProcess.StandardOutput.ReadLine() : Catch : End Try
                'disable the format button
                buttonFormat.Enabled = False
                isFormating = True

            Else
                Timer1.Enabled = False
                labelInfo.Text = "Format aborted."
                MessageBox.Show(labelInfo.Text, "Error")
                'clear labelprogress
                labelProgress.Text = String.Empty
                isFormating = False
                buttonFormat.Enabled = True
            End If

            If labelProgress.Text.Contains("Enter current volume label") = True Then
                Dim stremwriter As StreamWriter
                stremwriter = MyProcess.StandardInput
                stremwriter.Write(FixedHardDriveName)
                stremwriter.Close()
            End If

        Else
            Timer1.Enabled = False
            labelInfo.Text = "Done Formating"
            labelProgress.Text = String.Empty
            MessageBox.Show(labelInfo.Text)
            isFormating = False
            buttonFormat.Enabled = True
        End If

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonClose.Click
        If isFormating = False Then
            If (File.Exists("batman.bat") = True) Then
                'delete the batman.bat file
                File.Delete("batman.bat")
                Me.Close()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If isFormating = False Then
            If (File.Exists("batman.bat") = True) Then
                'delete the batman.bat file
                File.Delete("batman.bat")
                Me.Close()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Height = Me.Height + 10
        Me.Refresh()
        If Me.Height >= 293 Then
            Me.Height = 293
            Timer2.Enabled = False
        End If
    End Sub

End Class