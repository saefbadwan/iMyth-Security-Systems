Public Class IMSS_MonitorsCotrolsUint

    Private Sub Label59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label59.Click
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_ON_MOUSE_CLICK, AudioPlayMode.Background)
        MainMain.FlowLayoutPanel1.Visible = False
        MainMain._ReadLogFilesData()
        MainMain.Log_Click()
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        On Error Resume Next
        Button47.Enabled = False
        Button48.Enabled = True
        My.Settings.SysMontior = True
        My.Settings.USBMonitor = True
        For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            If IO.DriveType.Removable Then
                If d.Name.ToString = Nothing Then
                Else
                    MainMain._IMSS_SYSTEM_UINT._IMSS_ALLOW_SURV = True
                End If
            Else
            End If
        Next
        Label61.Text = "Enabled"
        Label61.ForeColor = Color.Green
        Label71.Text = "Enabled"
        Label71.ForeColor = Color.Green
        Label65.Text = "system"
        Label65.ForeColor = Color.Green
        Label67.Text = "Waiting"
        Label67.ForeColor = Color.Green
        PictureBox28.Visible = True
        PictureBox33.Visible = True
        PictureBox31.Visible = True
        PictureBox36.Visible = True
        Dim FontBold = New Font(MainMain.EnabledToolStripMenuItem.Font, FontStyle.Bold)
        Dim FontNormal = New Font(MainMain.EnabledToolStripMenuItem.Font, FontStyle.Regular)
        MainMain.EnabledToolStripMenuItem.Font = FontBold
        MainMain.DisableToolStripMenuItem.Font = FontNormal
        MainMain.DisableToolStripMenuItem.BackColor = Color.WhiteSmoke
        MainMain.DisableToolStripMenuItem.ForeColor = Color.Black
        MainMain.EnabledToolStripMenuItem.BackColor = Color.LightSkyBlue
        MainMain.EnabledToolStripMenuItem.ForeColor = Color.Black
        MessageBox.Show("Monitor Started !", "IMSS Monitors", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        On Error Resume Next
        ListView2.Items.Clear()
        ListView3.Items.Clear()
        Button47.Enabled = True
        Button48.Enabled = False
        My.Settings.SysMontior = False
        My.Settings.USBMonitor = True
        Label61.Text = "Disable"
        Label61.ForeColor = Color.Red
        Label71.Text = "Disable"
        Label71.ForeColor = Color.Red
        Label65.Text = "None"
        Label65.ForeColor = Color.Red
        Label67.Text = "None"
        Label67.ForeColor = Color.Red
        PictureBox28.Visible = False
        PictureBox33.Visible = False
        PictureBox31.Visible = False
        PictureBox36.Visible = False
        Dim FontBold = New Font(MainMain.DisableToolStripMenuItem.Font, FontStyle.Bold)
        Dim FontNormal = New Font(MainMain.DisableToolStripMenuItem.Font, FontStyle.Regular)
        MainMain.DisableToolStripMenuItem.Font = FontBold
        MainMain.EnabledToolStripMenuItem.Font = FontNormal
        MainMain.DisableToolStripMenuItem.BackColor = Color.LightSkyBlue
        MainMain.DisableToolStripMenuItem.ForeColor = Color.Black
        MainMain.EnabledToolStripMenuItem.BackColor = Color.WhiteSmoke
        MainMain.EnabledToolStripMenuItem.ForeColor = Color.Black
        MainMain._IMSS_SYSTEM_UINT._IMSS_ALLOW_SURV = False
        MessageBox.Show("Monitor has been terminated !", "IMSS Monitors", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Try
            Dim FontBold = New Font(MainMain.AutoToolStripMenuItem1.Font, FontStyle.Bold)
            Dim FontNormal = New Font(MainMain.AutoToolStripMenuItem1.Font, FontStyle.Regular)
            MainMain._IMSS_Set_Auto_Mode_Animation()
            MainMain.AutoToolStripMenuItem1.Text = "Automatic"
            MainMain.ManualToolStripMenuItem1.Text = "Manual"
            Label35.Text = "Automatic"
            MainMain.ManualToolStripMenuItem1.Font = FontNormal
            MainMain.AutoToolStripMenuItem1.Font = FontBold
            My.Settings.Mode = True
            My.Settings.Save()
            MessageBox.Show("Automatic Mode is Effective !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch : End Try
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Try
            Dim FontBold = New Font(MainMain.AutoToolStripMenuItem1.Font, FontStyle.Bold)
            Dim FontNormal = New Font(MainMain.AutoToolStripMenuItem1.Font, FontStyle.Regular)
            MainMain._IMSS_Set_Manual_Mode_Animation()
            MainMain.AutoToolStripMenuItem1.Text = "Automatic"
            MainMain.ManualToolStripMenuItem1.Text = "Manual"
            Label35.Text = "Manual"
            MainMain.ManualToolStripMenuItem1.Font = FontBold
            MainMain.AutoToolStripMenuItem1.Font = FontNormal
            My.Settings.Mode = False
            My.Settings.Save()
            MessageBox.Show("Manual Mode is Effective !", "IMSS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch : End Try
    End Sub

    Private Sub PictureBox10_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseEnter
        PictureBox10.Width = 80
        PictureBox10.Height = 63
    End Sub

    Private Sub PictureBox30_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.MouseEnter
        PictureBox30.Width = 80
        PictureBox30.Height = 63
    End Sub

    Private Sub PictureBox30_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox30.MouseLeave
        PictureBox30.Width = 75
        PictureBox30.Height = 58
    End Sub

    Private Sub PictureBox10_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseLeave
        PictureBox10.Width = 75
        PictureBox10.Height = 58
    End Sub

    Private Sub PictureBox37_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.MouseEnter
        PictureBox37.Width = 80
        PictureBox37.Height = 63
    End Sub

    Private Sub PictureBox37_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.MouseLeave
        PictureBox37.Width = 75
        PictureBox37.Height = 58
    End Sub

End Class
