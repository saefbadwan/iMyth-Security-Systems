' بسم الله الرحمن الرحيم

Module MainBackInstall
    Private _IMSS_ApplicationDataPathFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IMSS"
    Private _IMSS_CommonApplicationData As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\IMSS"
    Private _MainFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\iMyth Security Systems"
    Private _IMSS_exe As String = _MainFolder + "\IMSS.exe"
    Sub Main()
        On Error Resume Next
        If My.Application.CommandLineArgs.Count = 0 Then
            If Not IO.Directory.Exists(_IMSS_ApplicationDataPathFolder) Then IO.Directory.CreateDirectory(_IMSS_ApplicationDataPathFolder)
            If Not IO.Directory.Exists(_IMSS_CommonApplicationData) Then IO.Directory.CreateDirectory(_IMSS_CommonApplicationData)
            If Not IO.File.Exists(_IMSS_CommonApplicationData & "\_IMSS_CoreCommander.exe") Then IO.File.WriteAllBytes(_IMSS_CommonApplicationData & "\_IMSS_CoreCommander.exe", My.Resources._IMSS_CoreCommander)
            _IMSS_CONFIG_Firewall_Exception("iMyth Security Systems", _IMSS_exe, "SET")
            Application.Exit()
        Else
            _IMSS_CONFIG_Firewall_Exception("iMyth Security Systems", _IMSS_exe, "DEL")
            If IO.Directory.Exists(_IMSS_ApplicationDataPathFolder) Then IO.Directory.Delete(_IMSS_ApplicationDataPathFolder)
            If IO.Directory.Exists(_IMSS_CommonApplicationData) Then IO.Directory.Delete(_IMSS_CommonApplicationData)
            Shell("taskkill /F /IM IMSS.exe", AppWinStyle.Hide)
            Application.Exit()
        End If
    End Sub
    Private Sub _IMSS_CONFIG_Firewall_Exception(ByVal ApplicationName As String, ByVal ApplicationPath As String, _
                                             ByVal _IMSS_STATUS As String)
        Dim osInfo As System.OperatingSystem = System.Environment.OSVersion
        Select Case osInfo.Version.Major
            Case 5
                If _IMSS_STATUS = "SET" Then
                    Shell("netsh firewall add allowedprogram " & """" & ApplicationPath & """" & _
                          " " & """" & ApplicationName & """" & _
              " ENABLE", AppWinStyle.Hide, True)
                Else
                    Shell("netsh firewall delete allowedprogram " & """" & ApplicationPath & """", AppWinStyle.Hide)
                End If
            Case 6
                If _IMSS_STATUS = "SET" Then
                    Shell("netsh advfirewall firewall add rule name=" & """" & ApplicationName & """" & _
              " dir=in action=allow program=" & """" & ApplicationPath & """" & _
              " enable=yes", AppWinStyle.Hide, True)
                Else
                    Shell("netsh advfirewall firewall delete rule name=" & """" & "iMyth Security Systems" & """", AppWinStyle.Hide)
                End If
        End Select

    End Sub
End Module
