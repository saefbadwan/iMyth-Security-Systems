<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_UpdateSettings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_UpdateSettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me._IMSS_AutoUpdateCheckBox = New System.Windows.Forms.CheckBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._IMSS_UpdateNotfiyCheckBox = New System.Windows.Forms.ComboBox()
        Me._IMSS_CheckForUpdateNow = New System.Windows.Forms.Button()
        Me._IMSS_SettingUpdateButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_UpdateCheckBackGroundWorker = New System.ComponentModel.BackgroundWorker()
        Me._IMSS_UpdateCheckResult = New System.Windows.Forms.Label()
        Me._IMSS_CheckUpdateResultpicInfo = New System.Windows.Forms.PictureBox()
        Me.Panel22.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_CheckUpdateResultpicInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(4, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(539, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Specify when iMyth Security Systems should automatically check for updates and in" & _
            "form you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when they become available."
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel22.Controls.Add(Me.Label54)
        Me.Panel22.Location = New System.Drawing.Point(0, 6)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(173, 26)
        Me.Panel22.TabIndex = 55
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(7, 6)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(159, 14)
        Me.Label54.TabIndex = 48
        Me.Label54.Text = "Configure update check"
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel23.Location = New System.Drawing.Point(0, 22)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(619, 10)
        Me.Panel23.TabIndex = 54
        '
        '_IMSS_AutoUpdateCheckBox
        '
        Me._IMSS_AutoUpdateCheckBox.AutoSize = True
        Me._IMSS_AutoUpdateCheckBox.Checked = True
        Me._IMSS_AutoUpdateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me._IMSS_AutoUpdateCheckBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_AutoUpdateCheckBox.Location = New System.Drawing.Point(24, 110)
        Me._IMSS_AutoUpdateCheckBox.Name = "_IMSS_AutoUpdateCheckBox"
        Me._IMSS_AutoUpdateCheckBox.Size = New System.Drawing.Size(209, 19)
        Me._IMSS_AutoUpdateCheckBox.TabIndex = 56
        Me._IMSS_AutoUpdateCheckBox.Text = "Automatically check for updates"
        Me._IMSS_AutoUpdateCheckBox.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(640, 376)
        Me.ShapeContainer1.TabIndex = 57
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 24
        Me.LineShape2.X2 = 616
        Me.LineShape2.Y1 = 257
        Me.LineShape2.Y2 = 257
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 24
        Me.LineShape1.X2 = 616
        Me.LineShape1.Y1 = 96
        Me.LineShape1.Y2 = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(21, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 15)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Notify me about available updates :"
        '
        '_IMSS_UpdateNotfiyCheckBox
        '
        Me._IMSS_UpdateNotfiyCheckBox.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_UpdateNotfiyCheckBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me._IMSS_UpdateNotfiyCheckBox.FormattingEnabled = True
        Me._IMSS_UpdateNotfiyCheckBox.Items.AddRange(New Object() {"Every 4 days", "Every 6 days", "Every 8 days", "Every 10 days", "Every 14 days"})
        Me._IMSS_UpdateNotfiyCheckBox.Location = New System.Drawing.Point(238, 221)
        Me._IMSS_UpdateNotfiyCheckBox.Name = "_IMSS_UpdateNotfiyCheckBox"
        Me._IMSS_UpdateNotfiyCheckBox.Size = New System.Drawing.Size(123, 21)
        Me._IMSS_UpdateNotfiyCheckBox.TabIndex = 60
        Me._IMSS_UpdateNotfiyCheckBox.Text = "Every 4 days"
        '
        '_IMSS_CheckForUpdateNow
        '
        Me._IMSS_CheckForUpdateNow.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_CheckForUpdateNow.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_CheckForUpdateNow.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me._IMSS_CheckForUpdateNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_CheckForUpdateNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_CheckForUpdateNow.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CheckForUpdateNow.ForeColor = System.Drawing.Color.Black
        Me._IMSS_CheckForUpdateNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_CheckForUpdateNow.ImageKey = "_IMSS_UpdateNoeButtonSettings.png"
        Me._IMSS_CheckForUpdateNow.ImageList = Me._IMSS_SettingUpdateButtonImageList
        Me._IMSS_CheckForUpdateNow.Location = New System.Drawing.Point(189, 298)
        Me._IMSS_CheckForUpdateNow.Name = "_IMSS_CheckForUpdateNow"
        Me._IMSS_CheckForUpdateNow.Size = New System.Drawing.Size(234, 28)
        Me._IMSS_CheckForUpdateNow.TabIndex = 132
        Me._IMSS_CheckForUpdateNow.Tag = ""
        Me._IMSS_CheckForUpdateNow.Text = "Check for updates now ..."
        Me._IMSS_CheckForUpdateNow.UseVisualStyleBackColor = False
        '
        '_IMSS_SettingUpdateButtonImageList
        '
        Me._IMSS_SettingUpdateButtonImageList.ImageStream = CType(resources.GetObject("_IMSS_SettingUpdateButtonImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_SettingUpdateButtonImageList.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_SettingUpdateButtonImageList.Images.SetKeyName(0, "_IMSS_UpdateNoeButtonSettings.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 26)
        Me.Panel1.TabIndex = 134
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 14)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Update notification"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 182)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(619, 10)
        Me.Panel2.TabIndex = 133
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IMSS.My.Resources.Resources._IMSS_UpdatePicSettings
        Me.PictureBox1.Location = New System.Drawing.Point(548, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_UpdateCheckBackGroundWorker
        '
        Me._IMSS_UpdateCheckBackGroundWorker.WorkerReportsProgress = True
        Me._IMSS_UpdateCheckBackGroundWorker.WorkerSupportsCancellation = True
        '
        '_IMSS_UpdateCheckResult
        '
        Me._IMSS_UpdateCheckResult.AutoSize = True
        Me._IMSS_UpdateCheckResult.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_UpdateCheckResult.ForeColor = System.Drawing.SystemColors.HotTrack
        Me._IMSS_UpdateCheckResult.Location = New System.Drawing.Point(182, 340)
        Me._IMSS_UpdateCheckResult.Name = "_IMSS_UpdateCheckResult"
        Me._IMSS_UpdateCheckResult.Size = New System.Drawing.Size(210, 15)
        Me._IMSS_UpdateCheckResult.TabIndex = 136
        Me._IMSS_UpdateCheckResult.Text = "You already have the latest version"
        Me._IMSS_UpdateCheckResult.Visible = False
        '
        '_IMSS_CheckUpdateResultpicInfo
        '
        Me._IMSS_CheckUpdateResultpicInfo.Image = Global.IMSS.My.Resources.Resources._IMSS_Info_ToolTip
        Me._IMSS_CheckUpdateResultpicInfo.Location = New System.Drawing.Point(162, 341)
        Me._IMSS_CheckUpdateResultpicInfo.Name = "_IMSS_CheckUpdateResultpicInfo"
        Me._IMSS_CheckUpdateResultpicInfo.Size = New System.Drawing.Size(18, 15)
        Me._IMSS_CheckUpdateResultpicInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_CheckUpdateResultpicInfo.TabIndex = 137
        Me._IMSS_CheckUpdateResultpicInfo.TabStop = False
        Me._IMSS_CheckUpdateResultpicInfo.Visible = False
        '
        'IMSS_Language
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me._IMSS_CheckUpdateResultpicInfo)
        Me.Controls.Add(Me._IMSS_UpdateCheckResult)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me._IMSS_CheckForUpdateNow)
        Me.Controls.Add(Me._IMSS_UpdateNotfiyCheckBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me._IMSS_AutoUpdateCheckBox)
        Me.Controls.Add(Me.Panel22)
        Me.Controls.Add(Me.Panel23)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "IMSS_Language"
        Me.Size = New System.Drawing.Size(640, 376)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_CheckUpdateResultpicInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_AutoUpdateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_UpdateNotfiyCheckBox As System.Windows.Forms.ComboBox
    Friend WithEvents _IMSS_CheckForUpdateNow As System.Windows.Forms.Button
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_SettingUpdateButtonImageList As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_UpdateCheckBackGroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents _IMSS_UpdateCheckResult As System.Windows.Forms.Label
    Friend WithEvents _IMSS_CheckUpdateResultpicInfo As System.Windows.Forms.PictureBox

End Class
