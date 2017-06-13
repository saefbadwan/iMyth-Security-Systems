'بسم الله ابدأ
'يا رب يا الله يا رحيم يا عظيم يا كريم جل جلالك بأسمائك يا الله وفقني برحمتك

Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class CleanResult
    Private _IMSS_LOCATION_Y As Integer = 0

    Public Sub New(ByVal _IMSS_USB_TARGET As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _IMSS_LOAD_FORM(_IMSS_USB_TARGET)

    End Sub

    Private Sub _IMSS_LOAD_FORM(ByVal _IMSS_USB_TARGET As String)
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        _IMSS_LOCATION_Y = Me.Location.Y
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 164)
        Dim margins As SubThems.MARGINS = New SubThems.MARGINS
        With margins
            .cxLeftWidth = -1
            .cxRightWidth = -1
            .cyTopHeight = -1
            .cyButtomheight = -1
        End With
        Dim hwnd As IntPtr = Me.Handle
        Dim result As Integer = SubThems.DwmExtendFrameIntoClientArea(hwnd, margins)
        Label4.Text = _IMSS_USB_TARGET
        Me.Show()
        Do Until Me.Location.Y <= _IMSS_LOCATION_Y - 40
            System.Threading.Thread.Sleep(10)
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 10)
            Application.DoEvents()
        Loop
        For i = 0 To 20 Step 1
            System.Threading.Thread.Sleep(4)
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 2)
            Application.DoEvents()
        Next i

        Me.Refresh() : Me.Activate()

        Dim _IMSS_THREAD As New Threading.Thread(Sub()
                                                     My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_CLEAR_SCAN, AudioPlayMode.Background)
                                                     System.Threading.Thread.Sleep(3000)
                                                     Invoke(New _IMSS_SLIDE_OUT_AND_CLOSE_DELEGATE(AddressOf _IMSS_SLIDE_OUT_AND_CLOSE))
                                                 End Sub) : _IMSS_THREAD.Start()

    End Sub

#Region "Controls Click"


    Private Sub Sucsses_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        _IMSS_StartDriver()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        _IMSS_StartDriver()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        _IMSS_StartDriver()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        _IMSS_StartDriver()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        _IMSS_StartDriver()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        _IMSS_StartDriver()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        _IMSS_StartDriver()
    End Sub

#End Region

    Private Delegate Sub _IMSS_SLIDE_OUT_AND_CLOSE_DELEGATE()
    Private Sub _IMSS_SLIDE_OUT_AND_CLOSE()
        For i = 0 To 264 Step 1
            '   System.Threading.Thread.Sleep(1)
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 1)
            Application.DoEvents()
        Next i

        Me.Close()

    End Sub

    Private Sub _IMSS_StartDriver()
        Try
            Process.Start(Label4.Text)
        Catch : End Try
    End Sub

End Class