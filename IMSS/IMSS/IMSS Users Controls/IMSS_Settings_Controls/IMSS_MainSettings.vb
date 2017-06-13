Public Class IMSS_MainSettings
    Private _IMSS_CuruntType As Boolean = True
    Private IMSS_MonitorsCotrolsUint As New IMSS_MonitorsCotrolsUint
    'Private _IMSS_MainMain As New MainMain
    Private Sub IMSS_MainSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If _IMSS_AR = True Then
        '    Label38.Text = "درع النظام:"
        '    Label40.Text = "مراقب النظام:"
        '    Label41.Text = "USB مراقب:"
        '    Label2.Text = "اعدادات"
        '    Label44.Text = "USB درع:"
        '    Label1.Text = "الأصوات"
        '    Label3.Text = "ايقونة:"
        '    CheckBox1.Text = "مفعل"
        '    CheckBox2.Text = "مفعل"
        '    CheckBox3.Text = "مفعل"
        '    CheckBox4.Text = "مفعل"
        '    CheckBox5.Text = "مفعل"
        '    CheckBox6.Text = "نعم"
        'ElseIf _IMSS_FR = True Then

        'ElseIf _IMSS_RS = True Then

        'ElseIf _IMSS_ES = True Then

        'Else
        'End If
    End Sub
    Public WriteOnly Property _IMSS_SET_CONTROLS_STATUS_PROPERTY As Boolean
        Set(ByVal _IMSS_STATUS As Boolean)
            If _IMSS_STATUS = True Then
                _IMSS_SET_CONTROLS_STATUS()
            End If
        End Set
    End Property
    Private Sub _IMSS_SET_CONTROLS_STATUS()
        If My.Settings.SysSheild = True Then CheckBox1.Checked = True
        If My.Settings.SysMontior = True Then CheckBox2.Checked = True
        If My.Settings.USBMonitor = True Then CheckBox3.Checked = True
        If My.Settings.USBShelid = True Then CheckBox4.Checked = True
        If My.Settings.SystemSounds = True Then CheckBox5.Checked = True
    End Sub

    Private Sub _IMSS_Ch_Set(ByVal _IMSS_Status As Boolean)
        CheckBox1.Checked = _IMSS_Status
        CheckBox2.Checked = _IMSS_Status
        CheckBox3.Checked = _IMSS_Status
        CheckBox4.Checked = _IMSS_Status
        CheckBox5.Checked = _IMSS_Status
        CheckBox6.Checked = _IMSS_Status
        _IMSS_CuruntType = _IMSS_Status
    End Sub

    Public Sub _IMSS_CheCkCkeckAll()
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox4.Checked = True And CheckBox5.Checked = True Then
            CheckBox6.Checked = True
        Else
            CheckBox6.Checked = False
        End If
    End Sub

    Private Sub _IMSS_ENABEL_APPLY_BUTTON()
        MainMain._IMSS_ENABEL_APPLY_BUTTON()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        _IMSS_ENABEL_APPLY_BUTTON()
        _IMSS_CheCkCkeckAll()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        _IMSS_ENABEL_APPLY_BUTTON()
        _IMSS_CheCkCkeckAll()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        _IMSS_ENABEL_APPLY_BUTTON()
        _IMSS_CheCkCkeckAll()
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        _IMSS_ENABEL_APPLY_BUTTON()
        _IMSS_CheCkCkeckAll()
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        _IMSS_ENABEL_APPLY_BUTTON()
        _IMSS_CheCkCkeckAll()
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        _IMSS_ENABEL_APPLY_BUTTON()
        _IMSS_CheCkCkeckAll()
    End Sub
    Public WriteOnly Property _IMSS_CHECK_UNCHECK_ALL_PROPERTY As Boolean
        Set(ByVal _IMSS_STATUS As Boolean)
            If _IMSS_STATUS = True Then
                _IMSS_CHECK_UNCHECK_ALL()
            End If
        End Set
    End Property
    Private Sub _IMSS_CHECK_UNCHECK_ALL()
        If _IMSS_CuruntType Then
            _IMSS_Ch_Set(False)
        Else
            _IMSS_Ch_Set(True)
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Height = 60
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Height = 52
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Height = 60
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Height = 52
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Height = 60
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Height = 52
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Try
            Dim FontBold = New Font(MainMain.AutoToolStripMenuItem1.Font, FontStyle.Bold)
            Dim FontNormal = New Font(MainMain.AutoToolStripMenuItem1.Font, FontStyle.Regular)
            MainMain._IMSS_Set_Auto_Mode_Animation()
            MainMain.AutoToolStripMenuItem1.Text = "Automatic"
            MainMain.ManualToolStripMenuItem1.Text = "Manual"
            IMSS_MonitorsCotrolsUint.Label35.Text = "Automatic"
            MainMain.ManualToolStripMenuItem1.Font = FontNormal
            MainMain.AutoToolStripMenuItem1.Font = FontBold
            My.Settings.Mode = True
            My.Settings.Save()
            ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> Automatic mode is activated", 4)
            MessageBox.Show("Automatic Mode is Effective !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Try
            Dim FontBold = New Font(MainMain.AutoToolStripMenuItem1.Font, FontStyle.Bold)
            Dim FontNormal = New Font(MainMain.AutoToolStripMenuItem1.Font, FontStyle.Regular)
            MainMain._IMSS_Set_Manual_Mode_Animation()
            MainMain.AutoToolStripMenuItem1.Text = "Automatic"
            MainMain.ManualToolStripMenuItem1.Text = "Manual"
            IMSS_MonitorsCotrolsUint.Label35.Text = "Manual"
            'End If
            MainMain.ManualToolStripMenuItem1.Font = FontBold
            MainMain.AutoToolStripMenuItem1.Font = FontNormal
            My.Settings.Mode = False
            My.Settings.Save()
            ConfigurationResureses.IMSS_LOGS_OPER._IMSS_SQL_INSERT("IMSS Settings : " + Date.Now.ToString + " :##:> Manual mode is activated ", 4)
            MessageBox.Show("Manual Mode is Effective !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch : End Try
    End Sub

    Private Sub PictureBox37_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.MouseEnter
        PictureBox37.Height = 60
    End Sub

    Private Sub PictureBox37_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.MouseLeave
        PictureBox37.Height = 52
    End Sub

End Class
