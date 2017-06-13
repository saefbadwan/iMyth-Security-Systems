'بسم الله الرحمن الرحيم
Imports Microsoft.Win32
Imports System.Windows.Forms

Public Class _IMSS_USBC
    Private rValue, rsvalue As Int32
    Private Regkey, RegKey2 As RegistryKey
    Private Gvalue, tvalue As Int32
    Private Regpath As String = "System\CurrentControlSet\Services\USBSTOR"
    Private ReadAndWriteRegPath2 As String = "System\CurrentControlSet\Control"
    Private ReadAndWriteRegPath As String = "System\CurrentControlSet\Control\StorageDevicePolicies"
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
    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        fade_out()
        Me.Close()
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
    Private Sub USBC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If _IMSS_AR = True Then
        '    Label2.Text = "USB اعدادات "
        '    label1.Text = "ومن ثم أعد ادخاله بعد الضغط على حفظ USB أزل جهاز "
        '    label1.Location = New Point(60, 1)
        '    GroupBox1.Text = "تفعيل/تعطيل"
        '    RadioButtonenable.Text = "USB تفعيل استحدام "
        '    RadioButtondisable.Text = "USB تعطيل استحدام"
        '    GroupBox2.Text = "القراءة/الكتابة"
        '    RadioButtonreadonly.Text = "للقراءة فقط USB جعل جهاز"
        '    RadioButtonreadwrite.Text = "للقراءة والكتابة USB جعل جهاز"
        '    Button2.Text = "حفظ"
        '    Button27.Text = "اغلاق"
        'ElseIf _IMSS_FR = True Then

        'ElseIf _IMSS_RS = True Then

        'ElseIf _IMSS_ES = True Then

        'End If
        Try
            Me.Height = 0
            Timer1.Enabled = True
            fade_in()
            Regkey = Registry.LocalMachine.OpenSubKey(Regpath, True)
            Gvalue = CInt(Regkey.GetValue("Start"))
            'check the current state of the usb/whether is enabled or disabled
            If Gvalue = 3 Then
                RadioButtonenable.Checked = True
            ElseIf Gvalue = 4 Then
                RadioButtondisable.Checked = True
            End If
            RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath, True)
        Catch : End Try
        Try
            tvalue = CInt(RegKey2.GetValue("WriteProtect"))
            If tvalue = 1 Then
                RadioButtonreadonly.Checked = True
            ElseIf tvalue = 0 Then
                RadioButtonreadwrite.Checked = True
            End If
        Catch : End Try
    End Sub
    Private Sub RadioButtondisable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtondisable.CheckedChanged
        GroupBox2.Enabled = False
        rValue = 4
    End Sub

    Private Sub RadioButtonenable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonenable.CheckedChanged
        GroupBox2.Enabled = True
        rValue = 3
    End Sub

    Private Sub RadioButtonreadonly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonreadonly.CheckedChanged
        rsvalue = 1
    End Sub

    Private Sub RadioButtonreadwrite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonreadwrite.CheckedChanged
        rsvalue = 0
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Regkey = Registry.LocalMachine.OpenSubKey(Regpath, True)
            Regkey.SetValue("Start", rValue)
            If GroupBox2.Enabled = True Then
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath2, True)
                RegKey2.CreateSubKey("StorageDevicePolicies")
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath, True)
                RegKey2.SetValue("WriteProtect", rsvalue)
            End If
            If rValue = 3 And rsvalue = 1 Then
                MsgBox("USB Port were enable and Read only is enabled")
            ElseIf rValue = 3 And rsvalue = 0 Then
                MsgBox("USB Port were enable and Read and write is enabled")
            Else
                MsgBox("USB Port were disable")
            End If
        Catch : End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fade_out()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Height = Me.Height + 10
        If Me.Height >= 265 Then
            Me.Height = 265
            Me.Refresh()
            Timer1.Enabled = False
        End If
    End Sub

End Class