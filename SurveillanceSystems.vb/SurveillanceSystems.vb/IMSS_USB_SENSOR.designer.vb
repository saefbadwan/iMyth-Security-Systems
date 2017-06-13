<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_USB_SENSOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_USB_SENSOR))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._IMSS_AnalyzeBehaviour_Button = New System.Windows.Forms.Button()
        Me.lstFile = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_FileName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Path = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Get_FileLocation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenFileLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ScanOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_TARGET_DETECTED_ICONS = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me._IMSS_MainLogo_PicitureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox29 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._IMSS_ExitButton = New System.Windows.Forms.ImageList(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me._IMSS_LINESPRETOR = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me._IMSS_USBMonitor_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me._IMSS_USB_SENSOR = New System.IO.FileSystemWatcher()
        Me.Panel1.SuspendLayout()
        CType(Me.lstFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_Get_FileLocation.SuspendLayout()
        CType(Me._IMSS_MainLogo_PicitureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_USB_SENSOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me._IMSS_AnalyzeBehaviour_Button)
        Me.Panel1.Controls.Add(Me.lstFile)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me._IMSS_MainLogo_PicitureBox)
        Me.Panel1.Controls.Add(Me.PictureBox29)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 276)
        Me.Panel1.TabIndex = 0
        '
        '_IMSS_AnalyzeBehaviour_Button
        '
        Me._IMSS_AnalyzeBehaviour_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_AnalyzeBehaviour_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_AnalyzeBehaviour_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_AnalyzeBehaviour_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_AnalyzeBehaviour_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_AnalyzeBehaviour_Button.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_AnalyzeBehaviour_Button.Image = CType(resources.GetObject("_IMSS_AnalyzeBehaviour_Button.Image"), System.Drawing.Image)
        Me._IMSS_AnalyzeBehaviour_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_AnalyzeBehaviour_Button.Location = New System.Drawing.Point(254, 234)
        Me._IMSS_AnalyzeBehaviour_Button.Name = "_IMSS_AnalyzeBehaviour_Button"
        Me._IMSS_AnalyzeBehaviour_Button.Size = New System.Drawing.Size(148, 31)
        Me._IMSS_AnalyzeBehaviour_Button.TabIndex = 61
        Me._IMSS_AnalyzeBehaviour_Button.Text = "Analyze Behaviour"
        Me._IMSS_AnalyzeBehaviour_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_USBMonitor_ToolTip.SetToolTip(Me._IMSS_AnalyzeBehaviour_Button, "Analyze behaviour for files that access your device without your knowledge.")
        Me._IMSS_AnalyzeBehaviour_Button.UseVisualStyleBackColor = False
        '
        'lstFile
        '
        Me.lstFile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstFile.Columns.AddRange(New Object() {Me._IMSS_FileName, Me._IMSS_Path})
        Me.lstFile.ContextMenuStrip = Me._IMSS_Get_FileLocation
        Me.lstFile.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFile.ImageList = Me._IMSS_TARGET_DETECTED_ICONS
        Me.lstFile.Location = New System.Drawing.Point(2, 46)
        Me.lstFile.MultiSelect = False
        Me.lstFile.Name = "lstFile"
        Me.lstFile.Size = New System.Drawing.Size(607, 164)
        Me.lstFile.TabIndex = 60
        '
        '_IMSS_FileName
        '
        Me._IMSS_FileName.Name = "_IMSS_FileName"
        Me._IMSS_FileName.Text = "File Name"
        Me._IMSS_FileName.Width = 249
        '
        '_IMSS_Path
        '
        Me._IMSS_Path.Name = "_IMSS_Path"
        Me._IMSS_Path.Text = "Path"
        Me._IMSS_Path.Width = 342
        '
        '_IMSS_Get_FileLocation
        '
        Me._IMSS_Get_FileLocation.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Get_FileLocation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileLocationToolStripMenuItem, Me.DeleteSelectedToolStripMenuItem, Me.ToolStripSeparator1, Me.ScanOnlineToolStripMenuItem, Me.ToolStripSeparator2, Me.PropertiesToolStripMenuItem})
        Me._IMSS_Get_FileLocation.Name = "_IMSS_Get_FileLocation"
        Me._IMSS_Get_FileLocation.Size = New System.Drawing.Size(175, 104)
        '
        'OpenFileLocationToolStripMenuItem
        '
        Me.OpenFileLocationToolStripMenuItem.Image = CType(resources.GetObject("OpenFileLocationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenFileLocationToolStripMenuItem.Name = "OpenFileLocationToolStripMenuItem"
        Me.OpenFileLocationToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OpenFileLocationToolStripMenuItem.Text = "Open file location"
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.Image = CType(resources.GetObject("DeleteSelectedToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'ScanOnlineToolStripMenuItem
        '
        Me.ScanOnlineToolStripMenuItem.Image = CType(resources.GetObject("ScanOnlineToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ScanOnlineToolStripMenuItem.Name = "ScanOnlineToolStripMenuItem"
        Me.ScanOnlineToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ScanOnlineToolStripMenuItem.Text = "Scan Online"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(171, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Image = Global.SurveillanceSystems.My.Resources.Resources._IMSS_Properties_16x16
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        '_IMSS_TARGET_DETECTED_ICONS
        '
        Me._IMSS_TARGET_DETECTED_ICONS.ImageStream = CType(resources.GetObject("_IMSS_TARGET_DETECTED_ICONS.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_TARGET_DETECTED_ICONS.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(0, "exe-icon.gif")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(1, "original_vista_icons_files_jpg_file.png")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(2, "blue-document-word.png")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(3, "text-icon.gif")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(4, "winrar.png")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(5, "ieframe_dll_10_13.png")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(6, "256px-Microsoft_Powerpoint_Icon.svg.png")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(7, "Benjigarner-Softdimension-Excel.ico")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(8, "FlashVideo.png")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(9, "_IMSS_Shortcut_Icon_16x16.png")
        Me._IMSS_TARGET_DETECTED_ICONS.Images.SetKeyName(10, "_IMSS_ErrorExtracting_Icon_16x16.png")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Location = New System.Drawing.Point(0, -9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 13)
        Me.Panel2.TabIndex = 59
        '
        '_IMSS_MainLogo_PicitureBox
        '
        Me._IMSS_MainLogo_PicitureBox.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_MainLogo_PicitureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._IMSS_MainLogo_PicitureBox.Image = Global.SurveillanceSystems.My.Resources.Resources.IMSS_System_Mointor_Logo_Title
        Me._IMSS_MainLogo_PicitureBox.Location = New System.Drawing.Point(254, 0)
        Me._IMSS_MainLogo_PicitureBox.Name = "_IMSS_MainLogo_PicitureBox"
        Me._IMSS_MainLogo_PicitureBox.Size = New System.Drawing.Size(111, 26)
        Me._IMSS_MainLogo_PicitureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me._IMSS_MainLogo_PicitureBox.TabIndex = 58
        Me._IMSS_MainLogo_PicitureBox.TabStop = False
        '
        'PictureBox29
        '
        Me.PictureBox29.Enabled = False
        Me.PictureBox29.Image = CType(resources.GetObject("PictureBox29.Image"), System.Drawing.Image)
        Me.PictureBox29.Location = New System.Drawing.Point(408, 232)
        Me.PictureBox29.Name = "PictureBox29"
        Me.PictureBox29.Size = New System.Drawing.Size(200, 37)
        Me.PictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox29.TabIndex = 55
        Me.PictureBox29.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel6.Location = New System.Drawing.Point(611, 42)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 234)
        Me.Panel6.TabIndex = 54
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Location = New System.Drawing.Point(-1, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(627, 13)
        Me.Panel4.TabIndex = 52
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Location = New System.Drawing.Point(-24, 270)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(650, 13)
        Me.Panel3.TabIndex = 49
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Silver
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkCyan
        Me.LinkLabel1.Location = New System.Drawing.Point(572, 213)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 13)
        Me.LinkLabel1.TabIndex = 44
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(513, 14)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "These files are trying to write itself on your usb drive  do you want to allow th" & _
            "is actions?"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(123, 234)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 31)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Stop action"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_USBMonitor_ToolTip.SetToolTip(Me.Button5, "Denied action for files thats trying to write itself on USB dvice.")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox8.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox8.TabIndex = 34
        Me.PictureBox8.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(39, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 14)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "USB monitoring"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(516, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 25)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageKey = "arrow-12-512.gif"
        Me.Button1.ImageList = Me._IMSS_ExitButton
        Me.Button1.Location = New System.Drawing.Point(551, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 25)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = False
        '
        '_IMSS_ExitButton
        '
        Me._IMSS_ExitButton.ImageStream = CType(resources.GetObject("_IMSS_ExitButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_ExitButton.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_ExitButton.Images.SetKeyName(0, "arrow-12-512.gif")
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(6, 234)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 31)
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "Allow action"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_USBMonitor_ToolTip.SetToolTip(Me.Button6, "Allow action for files thats trying to write itself on USB dvice.")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me._IMSS_LINESPRETOR})
        Me.ShapeContainer1.Size = New System.Drawing.Size(618, 276)
        Me.ShapeContainer1.TabIndex = 62
        Me.ShapeContainer1.TabStop = False
        '
        '_IMSS_LINESPRETOR
        '
        Me._IMSS_LINESPRETOR.BorderColor = System.Drawing.SystemColors.ControlDark
        Me._IMSS_LINESPRETOR.Name = "_IMSS_LINESPRETOR"
        Me._IMSS_LINESPRETOR.X1 = 242
        Me._IMSS_LINESPRETOR.X2 = 242
        Me._IMSS_LINESPRETOR.Y1 = 239
        Me._IMSS_LINESPRETOR.Y2 = 260
        '
        '_IMSS_USBMonitor_ToolTip
        '
        Me._IMSS_USBMonitor_ToolTip.AutoPopDelay = 5000
        Me._IMSS_USBMonitor_ToolTip.InitialDelay = 400
        Me._IMSS_USBMonitor_ToolTip.ReshowDelay = 100
        Me._IMSS_USBMonitor_ToolTip.ShowAlways = True
        '
        '_IMSS_USB_SENSOR
        '
        Me._IMSS_USB_SENSOR.EnableRaisingEvents = True
        Me._IMSS_USB_SENSOR.IncludeSubdirectories = True
        Me._IMSS_USB_SENSOR.SynchronizingObject = Me
        '
        'IMSS_USB_SENSOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(616, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IMSS_USB_SENSOR"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "IMSS USB Monitor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.lstFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_Get_FileLocation.ResumeLayout(False)
        CType(Me._IMSS_MainLogo_PicitureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_USB_SENSOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_TARGET_DETECTED_ICONS As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_USBMonitor_ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents _IMSS_ExitButton As System.Windows.Forms.ImageList
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox29 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Get_FileLocation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenFileLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_MainLogo_PicitureBox As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_USB_SENSOR As System.IO.FileSystemWatcher
    Friend WithEvents lstFile As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_FileName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Path As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents ScanOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _IMSS_AnalyzeBehaviour_Button As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents _IMSS_LINESPRETOR As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
