'بسم الله ابدأ
'يا رب يا الله يا رحيم يا عظيم جل جلالك بأسمائك يا الله وفقني برحمتك
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports IMSS_Multiuse.IMSS_Multiuse
Imports System.Threading
Public Class IMSS_MainStarts
    Private _IMSS_MainCore As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\IMSS\IMSS.exe"
    Private strSystemDir As String = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3)
    Private _IMSS_ImageFilePathDeskTop As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\_IMSS_BackGround.bmp"
    Private _IMSS_FCM_Install_Path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSS\IMSS_install.imss"
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private file_name As String
    Private _IMSS_TxT As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSS\IMSS_TxT.reg"
    Private _IMSS_ExE As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSS\IMSS_ExE.reg"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        _IMSS_Ch_Set(True)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _IMSS_Ch_Set(False)
    End Sub

    Private Sub _IMSS_Ch_Set(ByVal _IMSS_Status As Boolean)
        _IMSS_Ch1.Checked = _IMSS_Status
        _IMSS_Ch2.Checked = _IMSS_Status
        _IMSS_Ch3.Checked = _IMSS_Status
        _IMSS_Ch4.Checked = _IMSS_Status
        _IMSS_Ch5.Checked = _IMSS_Status
        _IMSS_Ch6.Checked = _IMSS_Status
        _IMSS_Ch7.Checked = _IMSS_Status
        _IMSS_Ch_24.Checked = _IMSS_Status
    End Sub
    <DllImport("psapi")> _
    Public Shared Function EmptyWorkingSet(ByVal hProcess As Long) As Boolean
    End Function
    Private i As Integer = 0
    Private Sub _IMSS_SlideIn()
        On Error Resume Next
        i = Me.Location.Y
        Me.Location = New Point(Me.Location.X, Me.Location.Y + Me.Location.Y + 286)
        Me.Visible = True
        _IMSS_SlideInTimer.Enabled = True
    End Sub

    Private Sub IMSS_MainStarts_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        _IMSS_MainWorker.Dispose()
        EmptyWorkingSet(Process.GetCurrentProcess.Handle)
    End Sub

    Private Sub IMSS_MainStarts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _IMSS_CheckSystems As New IMSS_Multiuse.IMSS_Multiuse
        If _IMSS_CheckSystems._IMSS_CheckSystems = False Then
            MessageBox.Show("Please install iMyth Security Systems first, and " + Environment.NewLine() + " then try again !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Application.Exit()
        End If
        Control.CheckForIllegalCrossThreadCalls = False
        Me.MaximumSize = New Point(409, 286)
        Me.MinimumSize = New Point(409, 286)
        Me.Height = 286
        _IMSS_SlideIn()
    End Sub

    Private Sub _IMSS_SlideInTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SlideInTimer.Tick
        On Error Resume Next
        Me.Show()
        If Me.Location.Y <= i Then
            _IMSS_SlideInTimer.Enabled = False
            _IMSS_SlideInTimer.Stop()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 40)
        End If
    End Sub
    Private Function _IMSS_CheckIfNoChecked() As Boolean
        If _IMSS_Ch1.Checked = False And _IMSS_Ch2.Checked = False And _IMSS_Ch3.Checked = False And _IMSS_Ch4.Checked = False _
           And _IMSS_Ch5.Checked = False And _IMSS_Ch6.Checked = False And _IMSS_Ch7.Checked = False Then
            Return True
        End If
        Return False
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If _IMSS_CheckIfNoChecked() = True Then
            MessageBox.Show("Please Select an command to run !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                _IMSS_AnmationStarts()
                _IMSS_MainWorker.RunWorkerAsync()
            Catch ex As Exception
                MsgBox("ERROR : " + ex.Message)
            End Try
        End If
    End Sub
    Private Sub _IMSS_MainWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_MainWorker.DoWork
        _IMSS_MainCore_Starts()
    End Sub

    Private Sub _IMSS_MainWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSS_MainWorker.RunWorkerCompleted
        _IMSS_AnmationOut()
        Try
            If IO.File.Exists(_IMSS_ExE) Then IO.File.Delete(_IMSS_ExE)
            If IO.File.Exists(_IMSS_TxT) Then IO.File.Delete(_IMSS_TxT)
        Catch ex As Exception
        End Try
        MessageBox.Show("Specific choices were completed successfully !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub _IMSS_MainCore_Starts()
        If _IMSS_Ch3.Checked = True Then
            Try
                Shell("REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableRegistryTools /t REG_DWORD /d 0 /f")
            Catch ex As Exception
            End Try
        End If
        If _IMSS_Ch5.Checked = True Then
            Try
                Shell("REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System  /v  DisableTaskMgr  /t REG_DWORD  /d /0 /f")
            Catch ex As Exception
            End Try
        End If
        If _IMSS_Ch7.Checked = True Then
            Try
                Dim Proc As Process = New Process
                Dim top As String = "netsh.exe"
                Proc.StartInfo.Arguments = ("firewall set opmode enable")
                Proc.StartInfo.FileName = top
                Proc.StartInfo.UseShellExecute = False
                Proc.StartInfo.RedirectStandardOutput = True
                Proc.StartInfo.CreateNoWindow = True
                Proc.Start()
                Proc.WaitForExit()
            Catch ex As Exception
            End Try
        End If
        If _IMSS_Ch1.Checked = True Then
            Try
                Dim regloc As String = "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies"
                My.Computer.Registry.SetValue(regloc, "NoFolderOptions", "0", Microsoft.Win32.RegistryValueKind.DWord)
            Catch ex As Exception
            End Try
        End If
        If _IMSS_Ch6.Checked = True Then
            Dim regloc As String = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"
            My.Computer.Registry.SetValue(regloc, "Hidden", "2", Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If _IMSS_Ch_24.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", "0", Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If _IMSS_Ch2.Checked = True Then
            If IO.File.Exists(_IMSS_ExE) Then IO.File.Delete(_IMSS_ExE)
            If Not IO.File.Exists(_IMSS_ExE) Then IO.File.WriteAllBytes(_IMSS_ExE, My.Resources.xp_exe_fix)
            Thread.Sleep(400)
            Process.Start(_IMSS_ExE)
            'MessageBox.Show("Repair exe files associated complete successfully", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Thread.Sleep(400)
        End If
        If _IMSS_Ch4.Checked = True Then
            If IO.File.Exists(_IMSS_TxT) Then IO.File.Delete(_IMSS_TxT)
            If Not IO.File.Exists(_IMSS_TxT) Then IO.File.WriteAllBytes(_IMSS_TxT, My.Resources.xp_txt_fix)
            Thread.Sleep(400)
            Process.Start(_IMSS_TxT)
            'MessageBox.Show("Repair txt files associated complete successfully", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Thread.Sleep(400)
        End If
    End Sub
    Private Sub _IMSS_AnmationStarts()
        _IMSS_SetButtonsStatus(False)
        _IMSS_ProgressStaus.Enabled = True
        _IMSS_ProgressStaus.Visible = True
        Me.MaximumSize = New Point(409, 325)
        Me.MinimumSize = New Point(409, 325)
        Do
            Me.Height = Me.Height + 1
            Thread.Sleep(400)
        Loop Until Me.Height = 325
        Me.Height = 325
    End Sub

    Private Sub _IMSS_AnmationOut()
        Me.MaximumSize = New Point(409, 286)
        Me.MinimumSize = New Point(409, 286)
        Do
            Me.Height = Me.Height - 1
            Thread.Sleep(400)
        Loop Until Me.Height = 286
        Me.Height = 286
        _IMSS_ProgressStaus.Enabled = False
        _IMSS_ProgressStaus.Visible = False
        _IMSS_SetButtonsStatus(True)
    End Sub
    Private Sub _IMSS_SetButtonsStatus(ByVal _IMSS_StatusType As Boolean)
        Panel3.Enabled = _IMSS_StatusType
        Button1.Enabled = _IMSS_StatusType
        Button2.Enabled = _IMSS_StatusType
        Button3.Enabled = _IMSS_StatusType
    End Sub
End Class
