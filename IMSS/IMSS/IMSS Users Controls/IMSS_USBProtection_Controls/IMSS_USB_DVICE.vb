' بسم الله الرحمن الرحيم
Public Class IMSS_USB_DVICE
    Public Shared _IMSS_SELECT_STATUS As Boolean = False
    Public Property _IMSS_TARGET_DRIVE_TEXT As String
        Set(ByVal _IMSS_STATUS As String)
            _IMSS_USB_TITLE.Text = _IMSS_STATUS
        End Set
        Get
            Return _IMSS_USB_TITLE.Text
        End Get
    End Property
    Public Property _IMSS_TARGET_DRIVE_STATUS As Boolean
        Set(ByVal _IMSS_STATUS As Boolean)
            _IMSS_SECURE_PictureBox.Visible = _IMSS_STATUS
        End Set
        Get
            Return _IMSS_SECURE_PictureBox.Visible
        End Get
    End Property
    Private Sub _IMSS_DRIVER_LOGO_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DRIVER_LOGO.MouseEnter
        _IMSS_MousEnter(True)
    End Sub

    Private Sub _IMSS_DRIVER_LOGO_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_DRIVER_LOGO.MouseLeave
        _IMSS_MousEnter(False)
    End Sub

    Private Sub _IMSS_USB_TITLE_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_USB_TITLE.MouseEnter
        _IMSS_MousEnter(True)
    End Sub

    Private Sub _IMSS_USB_TITLE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_USB_TITLE.MouseLeave
        _IMSS_MousEnter(False)
    End Sub
    Private Sub _IMSS_MousEnter(ByVal _IMSS_STATUS As Boolean)
        If _IMSS_STATUS = True Then Me.Panel1.BorderStyle = Windows.Forms.BorderStyle.FixedSingle Else Me.Panel1.BorderStyle = Windows.Forms.BorderStyle.None
    End Sub
    Private Sub _IMSS_MousClick()
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        MainMain._IMSS_CONTROLS_RESEVENAME(Me._IMSS_USB_TITLE.Text)
    End Sub
    Private Sub _IMSS_DRIVER_LOGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DRIVER_LOGO.Click
        _IMSS_MousClick()
    End Sub

    Private Sub _IMSS_USB_TITLE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_USB_TITLE.Click
        _IMSS_MousClick()
    End Sub

    Public WriteOnly Property _IMSS_SELECTCONTROL As Boolean
        Set(ByVal _IMSS_STATUS As Boolean)
            If _IMSS_STATUS = True Then
                Me.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
            Else
                Me.BorderStyle = Windows.Forms.BorderStyle.None
            End If
        End Set
    End Property
End Class
