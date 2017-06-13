'بسم الله ابدأ
'يا رب يا الله يا رحيم يا عظيم يا كريم جل جلالك بأسمائك يا الله وفقني برحمتك

Public Class _IMSS_About

    Private Sub _IMSS_AboutButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AboutButtonClose.Click
        On Error Resume Next
        Me.Close()
    End Sub

    Private Sub _IMSS_TITLE_WRITE_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_TITLE_WRITE.Tick
        On Error Resume Next
        Panel1.Width = Panel1.Width + 4
        If Panel1.Width >= 288 Then
            Panel1.Width = 288
            Me.MinimumSize = New Point(352, 362)
            _IMSS_TITLE_WRITE.Enabled = False
        End If
    End Sub

    Private Sub _IMSS_About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        _IMSS_Label_App_Version.Text = Application.ProductVersion.ToString
        _IMSS_Label_VersionTitel.Text = "Ver " & Application.ProductVersion.ToString
        'If _IMSS_AR = True Then
        '    Me.Text = "عن البرنامج"
        '    Label3.Text = "المنتج:"
        '    Label4.Text = "الأصدار:"
        '    Label5.Text = "الشركة:"
        '    Label6.Text = "حقوق النشر:"
        '    Label7.Text = "العلامة التجارية:"
        '    _IMSS_AboutButtonClose.Text = "موافق"
        '    _IMSS_AboutButtonClose.Location = New Point(140, 290)
        'End If
        Panel1.Width = 0
        Me.Activate()
        _IMSS_TITLE_WRITE.Enabled = True
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        Try
            MyBase.OnMouseDown(e)
            If e.Button = MouseButtons.Left Then
                Me.Capture = False
                Me.WndProc(Message.Create(Me.Handle, &HA1, New IntPtr(2), IntPtr.Zero))
            End If
        Catch : End Try
    End Sub

End Class
