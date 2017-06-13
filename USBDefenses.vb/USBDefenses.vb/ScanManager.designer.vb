<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim ProgressBar1 As System.Windows.Forms.ProgressBar
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanManager))
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me._ButtonImages = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me._IMSS_MainLogo_PicitureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me._IMSS_EXIT_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_MINI_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_SCANRESULT_HOLDER_PANEL = New System.Windows.Forms.Panel()
        Me._IMSS_MAIN_SCAN_REPORT = New USBDefenses.ScanReport()
        ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me._IMSS_MainLogo_PicitureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_SCANRESULT_HOLDER_PANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        ProgressBar1.Location = New System.Drawing.Point(0, 289)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New System.Drawing.Size(0, 0)
        ProgressBar1.TabIndex = 8
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoToolStripMenuItem, Me.ManualToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'AutoToolStripMenuItem
        '
        Me.AutoToolStripMenuItem.Name = "AutoToolStripMenuItem"
        Me.AutoToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AutoToolStripMenuItem.Text = "Auto*"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Stats"
        Me.ColumnHeader3.Width = 62
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Infection Type"
        Me.ColumnHeader4.Width = 187
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Files"
        Me.ColumnHeader1.Width = 269
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        '_ButtonImages
        '
        Me._ButtonImages.ImageStream = CType(resources.GetObject("_ButtonImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._ButtonImages.TransparentColor = System.Drawing.Color.Transparent
        Me._ButtonImages.Images.SetKeyName(0, "_IMSS_Right_Arrow_Close.gif")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Scan manager"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Location = New System.Drawing.Point(-4, 247)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(532, 13)
        Me.Panel5.TabIndex = 53
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel6.Location = New System.Drawing.Point(-4, -8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(536, 13)
        Me.Panel6.TabIndex = 60
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Location = New System.Drawing.Point(0, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(533, 16)
        Me.Panel4.TabIndex = 62
        '
        '_IMSS_MainLogo_PicitureBox
        '
        Me._IMSS_MainLogo_PicitureBox.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_MainLogo_PicitureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._IMSS_MainLogo_PicitureBox.Image = Global.USBDefenses.My.Resources.Resources.IMSS_System_Mointor_Logo_Title
        Me._IMSS_MainLogo_PicitureBox.Location = New System.Drawing.Point(209, 0)
        Me._IMSS_MainLogo_PicitureBox.Name = "_IMSS_MainLogo_PicitureBox"
        Me._IMSS_MainLogo_PicitureBox.Size = New System.Drawing.Size(100, 28)
        Me._IMSS_MainLogo_PicitureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me._IMSS_MainLogo_PicitureBox.TabIndex = 59
        Me._IMSS_MainLogo_PicitureBox.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox8.Location = New System.Drawing.Point(4, 8)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox8.TabIndex = 32
        Me.PictureBox8.TabStop = False
        '
        '_IMSS_EXIT_BUTTON
        '
        Me._IMSS_EXIT_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_EXIT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_EXIT_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_EXIT_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_EXIT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_EXIT_BUTTON.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_EXIT_BUTTON.ImageKey = "_IMSS_Right_Arrow_Close.gif"
        Me._IMSS_EXIT_BUTTON.ImageList = Me._ButtonImages
        Me._IMSS_EXIT_BUTTON.Location = New System.Drawing.Point(457, 4)
        Me._IMSS_EXIT_BUTTON.Name = "_IMSS_EXIT_BUTTON"
        Me._IMSS_EXIT_BUTTON.Size = New System.Drawing.Size(57, 25)
        Me._IMSS_EXIT_BUTTON.TabIndex = 19
        Me._IMSS_EXIT_BUTTON.UseVisualStyleBackColor = False
        '
        '_IMSS_MINI_BUTTON
        '
        Me._IMSS_MINI_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_MINI_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_MINI_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_MINI_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_MINI_BUTTON.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_MINI_BUTTON.Image = CType(resources.GetObject("_IMSS_MINI_BUTTON.Image"), System.Drawing.Image)
        Me._IMSS_MINI_BUTTON.Location = New System.Drawing.Point(423, 4)
        Me._IMSS_MINI_BUTTON.Name = "_IMSS_MINI_BUTTON"
        Me._IMSS_MINI_BUTTON.Size = New System.Drawing.Size(35, 25)
        Me._IMSS_MINI_BUTTON.TabIndex = 20
        Me._IMSS_MINI_BUTTON.UseVisualStyleBackColor = False
        '
        '_IMSS_SCANRESULT_HOLDER_PANEL
        '
        Me._IMSS_SCANRESULT_HOLDER_PANEL.Controls.Add(Me._IMSS_MAIN_SCAN_REPORT)
        Me._IMSS_SCANRESULT_HOLDER_PANEL.Location = New System.Drawing.Point(0, 49)
        Me._IMSS_SCANRESULT_HOLDER_PANEL.Name = "_IMSS_SCANRESULT_HOLDER_PANEL"
        Me._IMSS_SCANRESULT_HOLDER_PANEL.Size = New System.Drawing.Size(516, 197)
        Me._IMSS_SCANRESULT_HOLDER_PANEL.TabIndex = 63
        '
        '_IMSS_MAIN_SCAN_REPORT
        '
        Me._IMSS_MAIN_SCAN_REPORT.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_MAIN_SCAN_REPORT.Location = New System.Drawing.Point(2, 3)
        Me._IMSS_MAIN_SCAN_REPORT.Name = "_IMSS_MAIN_SCAN_REPORT"
        Me._IMSS_MAIN_SCAN_REPORT.Size = New System.Drawing.Size(511, 434)
        Me._IMSS_MAIN_SCAN_REPORT.TabIndex = 0
        '
        'ScanManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(518, 259)
        Me.ControlBox = False
        Me.Controls.Add(Me._IMSS_SCANRESULT_HOLDER_PANEL)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me._IMSS_MainLogo_PicitureBox)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me._IMSS_EXIT_BUTTON)
        Me.Controls.Add(Me._IMSS_MINI_BUTTON)
        Me.Controls.Add(ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScanManager"
        Me.Opacity = 0.94R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan Manager"
        CType(Me._IMSS_MainLogo_PicitureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_SCANRESULT_HOLDER_PANEL.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_MINI_BUTTON As System.Windows.Forms.Button
    Friend WithEvents _IMSS_EXIT_BUTTON As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_MainLogo_PicitureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents _ButtonImages As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_SCANRESULT_HOLDER_PANEL As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_MAIN_SCAN_REPORT As USBDefenses.ScanReport

End Class
