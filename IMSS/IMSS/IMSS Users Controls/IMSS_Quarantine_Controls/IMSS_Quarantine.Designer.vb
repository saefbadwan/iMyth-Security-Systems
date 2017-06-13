<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Quarantine
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Quarantine))
        Me._IMSS_MonitorsPanels = New System.Windows.Forms.Panel()
        Me._IMSS_Quarantine_Log = New System.Windows.Forms.Panel()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me._QSecurityLog = New System.Windows.Forms.TextBox()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me._IMSS_QuarantineRoom_Panel = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Button44 = New System.Windows.Forms.Button()
        Me.Button45 = New System.Windows.Forms.Button()
        Me.Button43 = New System.Windows.Forms.Button()
        Me.Button46 = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me._IMSSQ = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_FileName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_CreatedDate = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Stats = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Size = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox35 = New System.Windows.Forms.PictureBox()
        Me._IMSS_CONTROL_PANEL = New System.Windows.Forms.Panel()
        Me._IMSS_QuarantineRoom = New System.Windows.Forms.Button()
        Me._IMSS_Log = New System.Windows.Forms.Button()
        Me._IMSSQ_BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me._IMSS_MonitorsPanels.SuspendLayout()
        Me._IMSS_Quarantine_Log.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me._IMSS_QuarantineRoom_Panel.SuspendLayout()
        CType(Me._IMSSQ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel34.SuspendLayout()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_CONTROL_PANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MonitorsPanels
        '
        Me._IMSS_MonitorsPanels.Controls.Add(Me._IMSS_Quarantine_Log)
        Me._IMSS_MonitorsPanels.Controls.Add(Me._IMSS_QuarantineRoom_Panel)
        Me._IMSS_MonitorsPanels.Controls.Add(Me._IMSS_CONTROL_PANEL)
        Me._IMSS_MonitorsPanels.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MonitorsPanels.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MonitorsPanels.Name = "_IMSS_MonitorsPanels"
        Me._IMSS_MonitorsPanels.Size = New System.Drawing.Size(829, 390)
        Me._IMSS_MonitorsPanels.TabIndex = 1
        '
        '_IMSS_Quarantine_Log
        '
        Me._IMSS_Quarantine_Log.BackColor = System.Drawing.Color.White
        Me._IMSS_Quarantine_Log.Controls.Add(Me.Button18)
        Me._IMSS_Quarantine_Log.Controls.Add(Me.TabControl1)
        Me._IMSS_Quarantine_Log.Controls.Add(Me.Panel26)
        Me._IMSS_Quarantine_Log.Controls.Add(Me.Panel27)
        Me._IMSS_Quarantine_Log.Location = New System.Drawing.Point(815, 6)
        Me._IMSS_Quarantine_Log.Name = "_IMSS_Quarantine_Log"
        Me._IMSS_Quarantine_Log.Size = New System.Drawing.Size(10, 10)
        Me._IMSS_Quarantine_Log.TabIndex = 150
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Button18.ForeColor = System.Drawing.Color.Black
        Me.Button18.Image = Global.IMSS.My.Resources.Resources._IMSS_Q_Clear_Log_Icon_34x34
        Me.Button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.Location = New System.Drawing.Point(3, 346)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(634, 42)
        Me.Button18.TabIndex = 57
        Me.Button18.Tag = ""
        Me.Button18.Text = "Clear Log"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(5, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(631, 312)
        Me.TabControl1.TabIndex = 56
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me._QSecurityLog)
        Me.TabPage6.ImageKey = "_IMSS_Quarantine_ClearLog_Icon.png"
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(623, 286)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Quarantine Log"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        '_QSecurityLog
        '
        Me._QSecurityLog.BackColor = System.Drawing.Color.White
        Me._QSecurityLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me._QSecurityLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._QSecurityLog.Location = New System.Drawing.Point(0, 0)
        Me._QSecurityLog.MaxLength = 100000
        Me._QSecurityLog.Multiline = True
        Me._QSecurityLog.Name = "_QSecurityLog"
        Me._QSecurityLog.ReadOnly = True
        Me._QSecurityLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._QSecurityLog.Size = New System.Drawing.Size(623, 286)
        Me._QSecurityLog.TabIndex = 1
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel26.Controls.Add(Me.Label53)
        Me.Panel26.Location = New System.Drawing.Point(3, 3)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(103, 26)
        Me.Panel26.TabIndex = 55
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(6, 6)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(91, 14)
        Me.Label53.TabIndex = 48
        Me.Label53.Text = "Quarantine Log"
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel27.Location = New System.Drawing.Point(5, 19)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(631, 10)
        Me.Panel27.TabIndex = 54
        '
        '_IMSS_QuarantineRoom_Panel
        '
        Me._IMSS_QuarantineRoom_Panel.BackColor = System.Drawing.Color.White
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.Label36)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.Button44)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.Button45)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.Button43)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.Button46)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.Label39)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me._IMSSQ)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.Panel34)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.Panel35)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.ListBox1)
        Me._IMSS_QuarantineRoom_Panel.Controls.Add(Me.PictureBox35)
        Me._IMSS_QuarantineRoom_Panel.Location = New System.Drawing.Point(799, 6)
        Me._IMSS_QuarantineRoom_Panel.Name = "_IMSS_QuarantineRoom_Panel"
        Me._IMSS_QuarantineRoom_Panel.Size = New System.Drawing.Size(10, 10)
        Me._IMSS_QuarantineRoom_Panel.TabIndex = 147
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Georgia", 15.75!)
        Me.Label36.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label36.Location = New System.Drawing.Point(221, 230)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(201, 25)
        Me.Label36.TabIndex = 150
        Me.Label36.Text = "Quarantine is empty"
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button44.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button44.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Button44.ForeColor = System.Drawing.Color.Black
        Me.Button44.Image = Global.IMSS.My.Resources.Resources._IMSS_RestoreTo_Icon_16x16
        Me.Button44.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button44.Location = New System.Drawing.Point(542, 353)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(96, 29)
        Me.Button44.TabIndex = 134
        Me.Button44.Tag = ""
        Me.Button44.Text = "Restore to"
        Me.Button44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button44.UseVisualStyleBackColor = False
        '
        'Button45
        '
        Me.Button45.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button45.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button45.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Button45.ForeColor = System.Drawing.Color.Black
        Me.Button45.Image = Global.IMSS.My.Resources.Resources._IMSS_ClearQFiles_Icon_16x16
        Me.Button45.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button45.Location = New System.Drawing.Point(468, 353)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(68, 29)
        Me.Button45.TabIndex = 135
        Me.Button45.Tag = ""
        Me.Button45.Text = "Clear"
        Me.Button45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button45.UseVisualStyleBackColor = False
        '
        'Button43
        '
        Me.Button43.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button43.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button43.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Button43.ForeColor = System.Drawing.Color.Black
        Me.Button43.Image = Global.IMSS.My.Resources.Resources._IMSS_DeleteButton_Icon_16x16
        Me.Button43.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button43.Location = New System.Drawing.Point(394, 353)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(68, 29)
        Me.Button43.TabIndex = 133
        Me.Button43.Tag = ""
        Me.Button43.Text = "Delete"
        Me.Button43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button43.UseVisualStyleBackColor = False
        '
        'Button46
        '
        Me.Button46.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button46.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button46.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Button46.ForeColor = System.Drawing.Color.Black
        Me.Button46.Image = Global.IMSS.My.Resources.Resources._IMSS_Refresh_Icon_16x16
        Me.Button46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button46.Location = New System.Drawing.Point(3, 353)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(76, 29)
        Me.Button46.TabIndex = 139
        Me.Button46.Tag = ""
        Me.Button46.Text = "Refresh"
        Me.Button46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button46.UseVisualStyleBackColor = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label39.Location = New System.Drawing.Point(12, 45)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(502, 30)
        Me.Label39.TabIndex = 138
        Me.Label39.Text = "View quarantine threat and informations about it and delete or restore, the threa" & _
    "t are locked" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by IMSS quarantine system , it's totale safe and  it's make threat" & _
    " Ineffective."
        '
        '_IMSSQ
        '
        Me._IMSSQ.Columns.AddRange(New Object() {Me._IMSS_FileName, Me._IMSS_CreatedDate, Me._IMSS_Stats, Me._IMSS_Size})
        Me._IMSSQ.Location = New System.Drawing.Point(3, 94)
        Me._IMSSQ.Name = "_IMSSQ"
        Me._IMSSQ.Size = New System.Drawing.Size(634, 256)
        Me._IMSSQ.TabIndex = 151
        '
        '_IMSS_FileName
        '
        Me._IMSS_FileName.Name = "_IMSS_FileName"
        Me._IMSS_FileName.Text = "File Name"
        '
        '_IMSS_CreatedDate
        '
        Me._IMSS_CreatedDate.Name = "_IMSS_CreatedDate"
        Me._IMSS_CreatedDate.Text = "Created Date"
        '
        '_IMSS_Stats
        '
        Me._IMSS_Stats.Name = "_IMSS_Stats"
        Me._IMSS_Stats.Text = "Stats"
        '
        '_IMSS_Size
        '
        Me._IMSS_Size.Name = "_IMSS_Size"
        Me._IMSS_Size.Text = "Size"
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel34.Controls.Add(Me.Label37)
        Me.Panel34.Location = New System.Drawing.Point(3, 3)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(127, 26)
        Me.Panel34.TabIndex = 126
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(4, 6)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(119, 14)
        Me.Label37.TabIndex = 48
        Me.Label37.Text = "Quarantine Systems"
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel35.Location = New System.Drawing.Point(3, 20)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(634, 10)
        Me.Panel35.TabIndex = 125
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(494, 9)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(10, 4)
        Me.ListBox1.TabIndex = 136
        Me.ListBox1.Visible = False
        '
        'PictureBox35
        '
        Me.PictureBox35.BackgroundImage = CType(resources.GetObject("PictureBox35.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox35.Location = New System.Drawing.Point(572, 32)
        Me.PictureBox35.Name = "PictureBox35"
        Me.PictureBox35.Size = New System.Drawing.Size(66, 56)
        Me.PictureBox35.TabIndex = 123
        Me.PictureBox35.TabStop = False
        '
        '_IMSS_CONTROL_PANEL
        '
        Me._IMSS_CONTROL_PANEL.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_CONTROL_PANEL.Controls.Add(Me._IMSS_QuarantineRoom)
        Me._IMSS_CONTROL_PANEL.Controls.Add(Me._IMSS_Log)
        Me._IMSS_CONTROL_PANEL.Location = New System.Drawing.Point(4, 3)
        Me._IMSS_CONTROL_PANEL.Name = "_IMSS_CONTROL_PANEL"
        Me._IMSS_CONTROL_PANEL.Size = New System.Drawing.Size(186, 390)
        Me._IMSS_CONTROL_PANEL.TabIndex = 146
        '
        '_IMSS_QuarantineRoom
        '
        Me._IMSS_QuarantineRoom.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_QuarantineRoom.BackgroundImage = CType(resources.GetObject("_IMSS_QuarantineRoom.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_QuarantineRoom.Cursor = System.Windows.Forms.Cursors.Default
        Me._IMSS_QuarantineRoom.FlatAppearance.BorderSize = 0
        Me._IMSS_QuarantineRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me._IMSS_QuarantineRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_QuarantineRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_QuarantineRoom.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_QuarantineRoom.ForeColor = System.Drawing.Color.Black
        Me._IMSS_QuarantineRoom.Image = Global.IMSS.My.Resources.Resources._IMSS_QuarantineRoom_Icon_24x32
        Me._IMSS_QuarantineRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_QuarantineRoom.Location = New System.Drawing.Point(2, 7)
        Me._IMSS_QuarantineRoom.Name = "_IMSS_QuarantineRoom"
        Me._IMSS_QuarantineRoom.Size = New System.Drawing.Size(181, 41)
        Me._IMSS_QuarantineRoom.TabIndex = 48
        Me._IMSS_QuarantineRoom.Tag = ""
        Me._IMSS_QuarantineRoom.Text = "    Quarantine Room"
        Me._IMSS_QuarantineRoom.UseVisualStyleBackColor = False
        '
        '_IMSS_Log
        '
        Me._IMSS_Log.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_Log.BackgroundImage = CType(resources.GetObject("_IMSS_Log.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_Log.Cursor = System.Windows.Forms.Cursors.Default
        Me._IMSS_Log.FlatAppearance.BorderSize = 0
        Me._IMSS_Log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me._IMSS_Log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_Log.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_Log.ForeColor = System.Drawing.Color.Black
        Me._IMSS_Log.Image = Global.IMSS.My.Resources.Resources._IMSS_Log_Icon_24x32
        Me._IMSS_Log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_Log.Location = New System.Drawing.Point(3, 62)
        Me._IMSS_Log.Name = "_IMSS_Log"
        Me._IMSS_Log.Size = New System.Drawing.Size(180, 41)
        Me._IMSS_Log.TabIndex = 5
        Me._IMSS_Log.Text = "LOG Section"
        Me._IMSS_Log.UseVisualStyleBackColor = False
        '
        '_IMSSQ_BackgroundWorker
        '
        Me._IMSSQ_BackgroundWorker.WorkerReportsProgress = True
        Me._IMSSQ_BackgroundWorker.WorkerSupportsCancellation = True
        '
        'IMSS_Quarantine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_MonitorsPanels)
        Me.Name = "IMSS_Quarantine"
        Me.Size = New System.Drawing.Size(829, 390)
        Me._IMSS_MonitorsPanels.ResumeLayout(False)
        Me._IMSS_Quarantine_Log.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me._IMSS_QuarantineRoom_Panel.ResumeLayout(False)
        Me._IMSS_QuarantineRoom_Panel.PerformLayout()
        CType(Me._IMSSQ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_CONTROL_PANEL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MonitorsPanels As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_Quarantine_Log As System.Windows.Forms.Panel
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents _QSecurityLog As System.Windows.Forms.TextBox
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_QuarantineRoom_Panel As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents _IMSSQ As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_FileName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_CreatedDate As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Stats As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Size As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents Panel34 As System.Windows.Forms.Panel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Panel35 As System.Windows.Forms.Panel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox35 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_CONTROL_PANEL As System.Windows.Forms.Panel
    Friend WithEvents Button44 As System.Windows.Forms.Button
    Friend WithEvents Button45 As System.Windows.Forms.Button
    Friend WithEvents Button43 As System.Windows.Forms.Button
    Friend WithEvents Button46 As System.Windows.Forms.Button
    Friend WithEvents _IMSS_QuarantineRoom As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Log As System.Windows.Forms.Button
    Friend WithEvents _IMSSQ_BackgroundWorker As System.ComponentModel.BackgroundWorker

End Class
