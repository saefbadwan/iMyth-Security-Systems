'بسم الله ابدأ
'يا رب يا الله يا رحيم يا عظيم يا كريم جل جلالك بأسمائك يا الله وفقني برحمتك


Imports System.Windows.Forms
Imports System.Drawing

Public Class ScanManager

#Region "IMSS Private Declration"
    Private _IMSS_USB_TARGET As String = String.Empty
    Private _IMSS_LOCATION_Y As Integer = 0
    Private _IMSS_SCAN_MODE As Boolean = False
    Private Const CS_DROPSHADOW As Integer = &H20000
#End Region

    Public Sub New(ByVal _IMSS_THREAT_RESULT As List(Of ListViewItem), ByVal IMSS_USB_TARGET As String, ByVal IMSS_SCAN_MODE As Boolean)

        _IMSS_USB_TARGET = IMSS_USB_TARGET
        _IMSS_SCAN_MODE = IMSS_SCAN_MODE

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _IMSS_MAIN_SCAN_REPORT._IMSS_THREAT_LISTVIEW.Items.AddRange(_IMSS_THREAT_RESULT.ToArray())

        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_SECURITY_BREACH, AudioPlayMode.Background)

    End Sub

    Private Sub ScanManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Setup scan report var.

        _IMSS_SETUP_TARGET_VAR()

        ' Slide form out.

        _IMSS_LOAD_FORM()

        If _IMSS_SCAN_MODE = True Then
            _IMSS_MAIN_SCAN_REPORT._IMSS_DELETE_BUTTON.PerformClick()
        End If

    End Sub

    Private Sub _IMSS_SETUP_TARGET_VAR()
        _IMSS_MAIN_SCAN_REPORT._IMSS_NUMBEROFTHREAD.Text = _IMSS_MAIN_SCAN_REPORT._IMSS_THREAT_LISTVIEW.Items.Count().ToString() & " Threat found."
        _IMSS_MAIN_SCAN_REPORT._IMSS_THREAD_STATUS.Text = "Waiting for user command."
        _IMSS_MAIN_SCAN_REPORT._IMSS_THREAD_STATUS.ForeColor = Color.Red
        _IMSS_MAIN_SCAN_REPORT._IMSS_USB_TARGET.Text = _IMSS_USB_TARGET
        _IMSS_MAIN_SCAN_REPORT._IMSS_USB_TARGET_VAR = _IMSS_USB_TARGET
        _IMSS_MAIN_SCAN_REPORT._IMSS_SCAN_DATE_LABEL.Text = Now.Date.ToString()
    End Sub

    Private Sub _IMSS_LOAD_FORM()
        _IMSS_LOCATION_Y = Me.Location.Y
        Me.Location = New Point(Me.Location.X, Me.Location.Y + Me.Location.Y + 241)
        _IMSS_CREATE_ROUNDED_FORM_BORDER()
        Me.Show()
        Do Until Me.Location.Y <= _IMSS_LOCATION_Y
            System.Threading.Thread.Sleep(10)
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 40)
            Application.DoEvents()
        Loop

        Me.Refresh() : Me.Activate()

    End Sub

#Region "Form Custum Effects"
    ' Make the shadow around the form

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property
    ' Shape the form border to be rounded border
    Private Sub _IMSS_CREATE_ROUNDED_FORM_BORDER()
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        p.AddLine(20, 0, Me.Width - 20, 0)
        p.AddArc(New Rectangle(Me.Width - 20, 0, 20, 20), -90, 90)
        p.AddLine(Me.Width, 20, Me.Width, Me.Height - 20)
        p.AddArc(New Rectangle(Me.Width - 20, Me.Height - 20, 20, 20), 0, 90)
        p.AddLine(Me.Width - 20, Me.Height, 20, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 20, 20, 20), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
        p.Dispose()
    End Sub

    'Declare the variables
    Private drag As Boolean = False
    Private mousex As Integer = 0
    Private mousey As Integer = 0

    Private Sub ScanManager_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        Me.Cursor = Cursors.SizeAll
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub ScanManager_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.Cursor = Cursors.Default
        drag = False
    End Sub

    Private Sub ScanManager_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

#End Region


#Region "Controls Functions"

    Private Sub _IMSS_MainLogo_PicitureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _IMSS_MainLogo_PicitureBox.MouseDown
        _IMSS_MainLogo_PicitureBox.Image = My.Resources.IMSS_System_Mointor_Logo_Title
    End Sub

    Private Sub _IMSS_MainLogo_PicitureBox_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MainLogo_PicitureBox.MouseEnter
        _IMSS_MainLogo_PicitureBox.Image = My.Resources.IMSS_Monitors_BackGroundOnMuseOver
    End Sub

    Private Sub _IMSS_MainLogo_PicitureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_MainLogo_PicitureBox.MouseLeave
        _IMSS_MainLogo_PicitureBox.Image = My.Resources.IMSS_System_Mointor_Logo_Title
    End Sub

    Private Sub _IMSS_EXIT_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_EXIT_BUTTON.Click
        SubThems._IMSS_FEAD_OUT(Me)
    End Sub

    Private Sub _IMSS_MINI_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MINI_BUTTON.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

End Class
