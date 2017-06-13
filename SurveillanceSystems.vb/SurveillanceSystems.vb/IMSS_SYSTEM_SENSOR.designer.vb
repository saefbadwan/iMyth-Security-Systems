<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SYSTEM_SENSOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_SYSTEM_SENSOR))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._IMSS_AnalyzeBehaviour_Button = New System.Windows.Forms.Button()
        Me._IMSS_SURV_TARGETS = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_FileName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Extension_Sys = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
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
        Me._IMSS_LOADING_PICTUREBOX = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me._IMSS_ALLOWACTION_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_STOPACTION_BUTTON = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._IMSS_ExitButton = New System.Windows.Forms.ImageList(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me._IMSS_LINESPRETOR = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me._IMSS_SystemMonitorToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me._IMSS_SYSTEM_SURV = New System.IO.FileSystemWatcher()
        Me.Panel1.SuspendLayout()
        CType(Me._IMSS_SURV_TARGETS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_Get_FileLocation.SuspendLayout()
        CType(Me._IMSS_MainLogo_PicitureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_LOADING_PICTUREBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_SYSTEM_SURV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(10, 4)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(60, 0)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(10, 4)
        Me.ListBox2.TabIndex = 1
        Me.ListBox2.Visible = False
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(19, 0)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(26, 4)
        Me.ListBox3.TabIndex = 2
        Me.ListBox3.Visible = False
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(15, 0)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(10, 4)
        Me.ListBox4.TabIndex = 3
        Me.ListBox4.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Location = New System.Drawing.Point(-21, 270)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(655, 13)
        Me.Panel3.TabIndex = 49
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Silver
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkCyan
        Me.LinkLabel1.Location = New System.Drawing.Point(574, 213)
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
        Me.Label1.Location = New System.Drawing.Point(6, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 14)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "These files are trying to write itself on your computer do you want to allow this" & _
            " actions?"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me._IMSS_AnalyzeBehaviour_Button)
        Me.Panel1.Controls.Add(Me._IMSS_SURV_TARGETS)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me._IMSS_MainLogo_PicitureBox)
        Me.Panel1.Controls.Add(Me._IMSS_LOADING_PICTUREBOX)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me._IMSS_ALLOWACTION_BUTTON)
        Me.Panel1.Controls.Add(Me._IMSS_STOPACTION_BUTTON)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 276)
        Me.Panel1.TabIndex = 4
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
        Me._IMSS_AnalyzeBehaviour_Button.TabIndex = 62
        Me._IMSS_AnalyzeBehaviour_Button.Text = "Analyze Behaviour"
        Me._IMSS_AnalyzeBehaviour_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_SystemMonitorToolTip.SetToolTip(Me._IMSS_AnalyzeBehaviour_Button, "Analyze behaviour for files that access your device without your knowledge.")
        Me._IMSS_AnalyzeBehaviour_Button.UseVisualStyleBackColor = False
        '
        '_IMSS_SURV_TARGETS
        '
        Me._IMSS_SURV_TARGETS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._IMSS_SURV_TARGETS.Columns.AddRange(New Object() {Me._IMSS_FileName, Me._IMSS_Extension_Sys, Me._IMSS_Path})
        Me._IMSS_SURV_TARGETS.ContextMenuStrip = Me._IMSS_Get_FileLocation
        Me._IMSS_SURV_TARGETS.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SURV_TARGETS.ImageList = Me._IMSS_TARGET_DETECTED_ICONS
        Me._IMSS_SURV_TARGETS.Location = New System.Drawing.Point(2, 46)
        Me._IMSS_SURV_TARGETS.MultiSelect = False
        Me._IMSS_SURV_TARGETS.Name = "_IMSS_SURV_TARGETS"
        Me._IMSS_SURV_TARGETS.Size = New System.Drawing.Size(607, 164)
        Me._IMSS_SURV_TARGETS.TabIndex = 61
        '
        '_IMSS_FileName
        '
        Me._IMSS_FileName.Name = "_IMSS_FileName"
        Me._IMSS_FileName.Text = "File Name"
        '
        '_IMSS_Extension_Sys
        '
        Me._IMSS_Extension_Sys.Name = "_IMSS_Extension_Sys"
        Me._IMSS_Extension_Sys.Text = "Extension"
        Me._IMSS_Extension_Sys.Width = 76
        '
        '_IMSS_Path
        '
        Me._IMSS_Path.Name = "_IMSS_Path"
        Me._IMSS_Path.Text = "Path"
        Me._IMSS_Path.Width = 397
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
        Me.Panel2.Size = New System.Drawing.Size(650, 13)
        Me.Panel2.TabIndex = 58
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
        Me._IMSS_MainLogo_PicitureBox.TabIndex = 57
        Me._IMSS_MainLogo_PicitureBox.TabStop = False
        '
        '_IMSS_LOADING_PICTUREBOX
        '
        Me._IMSS_LOADING_PICTUREBOX.Enabled = False
        Me._IMSS_LOADING_PICTUREBOX.Image = CType(resources.GetObject("_IMSS_LOADING_PICTUREBOX.Image"), System.Drawing.Image)
        Me._IMSS_LOADING_PICTUREBOX.Location = New System.Drawing.Point(408, 232)
        Me._IMSS_LOADING_PICTUREBOX.Name = "_IMSS_LOADING_PICTUREBOX"
        Me._IMSS_LOADING_PICTUREBOX.Size = New System.Drawing.Size(200, 37)
        Me._IMSS_LOADING_PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_LOADING_PICTUREBOX.TabIndex = 56
        Me._IMSS_LOADING_PICTUREBOX.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel6.Location = New System.Drawing.Point(612, 42)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 234)
        Me.Panel6.TabIndex = 55
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Location = New System.Drawing.Point(-1, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(650, 13)
        Me.Panel4.TabIndex = 53
        '
        '_IMSS_ALLOWACTION_BUTTON
        '
        Me._IMSS_ALLOWACTION_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_ALLOWACTION_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_ALLOWACTION_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_ALLOWACTION_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_ALLOWACTION_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_ALLOWACTION_BUTTON.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_ALLOWACTION_BUTTON.Image = CType(resources.GetObject("_IMSS_ALLOWACTION_BUTTON.Image"), System.Drawing.Image)
        Me._IMSS_ALLOWACTION_BUTTON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_ALLOWACTION_BUTTON.Location = New System.Drawing.Point(8, 234)
        Me._IMSS_ALLOWACTION_BUTTON.Name = "_IMSS_ALLOWACTION_BUTTON"
        Me._IMSS_ALLOWACTION_BUTTON.Size = New System.Drawing.Size(111, 31)
        Me._IMSS_ALLOWACTION_BUTTON.TabIndex = 36
        Me._IMSS_ALLOWACTION_BUTTON.Text = "Allow action"
        Me._IMSS_ALLOWACTION_BUTTON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_SystemMonitorToolTip.SetToolTip(Me._IMSS_ALLOWACTION_BUTTON, "Allow action for files thats trying to write itself on local computer.")
        Me._IMSS_ALLOWACTION_BUTTON.UseVisualStyleBackColor = False
        '
        '_IMSS_STOPACTION_BUTTON
        '
        Me._IMSS_STOPACTION_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_STOPACTION_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_STOPACTION_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_STOPACTION_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_STOPACTION_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_STOPACTION_BUTTON.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_STOPACTION_BUTTON.Image = CType(resources.GetObject("_IMSS_STOPACTION_BUTTON.Image"), System.Drawing.Image)
        Me._IMSS_STOPACTION_BUTTON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_STOPACTION_BUTTON.Location = New System.Drawing.Point(125, 234)
        Me._IMSS_STOPACTION_BUTTON.Name = "_IMSS_STOPACTION_BUTTON"
        Me._IMSS_STOPACTION_BUTTON.Size = New System.Drawing.Size(110, 31)
        Me._IMSS_STOPACTION_BUTTON.TabIndex = 35
        Me._IMSS_STOPACTION_BUTTON.Text = "Stop action"
        Me._IMSS_STOPACTION_BUTTON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_SystemMonitorToolTip.SetToolTip(Me._IMSS_STOPACTION_BUTTON, "Denied action for files thats trying to write itself on local computer.")
        Me._IMSS_STOPACTION_BUTTON.UseVisualStyleBackColor = False
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
        Me.Label2.Location = New System.Drawing.Point(40, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 14)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "System monitoring"
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
        Me.Button1.Cursor = System.Windows.Forms.Cursors.PanNW
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me._IMSS_LINESPRETOR})
        Me.ShapeContainer1.Size = New System.Drawing.Size(618, 276)
        Me.ShapeContainer1.TabIndex = 63
        Me.ShapeContainer1.TabStop = False
        '
        '_IMSS_LINESPRETOR
        '
        Me._IMSS_LINESPRETOR.BorderColor = System.Drawing.SystemColors.ControlDark
        Me._IMSS_LINESPRETOR.Name = "_IMSS_LINESPRETOR"
        Me._IMSS_LINESPRETOR.X1 = 244
        Me._IMSS_LINESPRETOR.X2 = 244
        Me._IMSS_LINESPRETOR.Y1 = 239
        Me._IMSS_LINESPRETOR.Y2 = 260
        '
        '_IMSS_SystemMonitorToolTip
        '
        Me._IMSS_SystemMonitorToolTip.AutoPopDelay = 5000
        Me._IMSS_SystemMonitorToolTip.InitialDelay = 400
        Me._IMSS_SystemMonitorToolTip.ReshowDelay = 100
        Me._IMSS_SystemMonitorToolTip.ShowAlways = True
        '
        '_IMSS_SYSTEM_SURV
        '
        Me._IMSS_SYSTEM_SURV.EnableRaisingEvents = True
        Me._IMSS_SYSTEM_SURV.IncludeSubdirectories = True
        Me._IMSS_SYSTEM_SURV.SynchronizingObject = Me
        '
        'IMSS_SYSTEM_SENSOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(616, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(616, 276)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(616, 276)
        Me.Name = "IMSS_SYSTEM_SENSOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "IMSS System Monitor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._IMSS_SURV_TARGETS, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_Get_FileLocation.ResumeLayout(False)
        CType(Me._IMSS_MainLogo_PicitureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_LOADING_PICTUREBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_SYSTEM_SURV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_STOPACTION_BUTTON As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_ALLOWACTION_BUTTON As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents _IMSS_SystemMonitorToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents _IMSS_ExitButton As System.Windows.Forms.ImageList
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_LOADING_PICTUREBOX As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_MainLogo_PicitureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_SURV_TARGETS As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_FileName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Extension_Sys As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Path As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Get_FileLocation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenFileLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScanOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_TARGET_DETECTED_ICONS As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _IMSS_AnalyzeBehaviour_Button As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents _IMSS_LINESPRETOR As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents _IMSS_SYSTEM_SURV As System.IO.FileSystemWatcher
End Class
