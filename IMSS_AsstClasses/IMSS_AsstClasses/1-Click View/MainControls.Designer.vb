<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainControls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainControls))
        Me._IMSS_MainPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._IMSS_LOW_SETTING_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_ADVANCED_SETTING_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_NORMAL_SETTING_BUTTON = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._IMSS_WArning_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Progress_StepIndicator = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me._IMSS_MINOR_CATGORY_LABEL = New System.Windows.Forms.Label()
        Me._IMSS_OverAllProgress_Label = New System.Windows.Forms.Label()
        Me._IMSS_CurrentProgress_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me._IMSS_CurrentCatgory_Label = New System.Windows.Forms.Label()
        Me._IMSS_CurrentFile = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me._IMSS_CONTROLS_PANEL = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me._IMSS_Info_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_Warning_Icon = New System.Windows.Forms.PictureBox()
        Me._IMSS_CancelAll_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_LoadingGif = New System.Windows.Forms.PictureBox()
        Me._IMSS_Skip_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_StartMaintenanc_Label = New DevComponents.DotNetBar.ButtonX()
        Me.ImsS_RegistryCleannerUserControl1 = New IMSS_AsstClasses.IMSS_RegistryCleannerUserControl()
        Me._IMSS_WindowsCleaner_Control = New IMSS_AsstClasses.IMSS_WindowsCleaner()
        Me._IMSS_BrowserCleaner_Control = New IMSS_AsstClasses.IMSS_CleanupBrowserUserControl()
        Me._IMSS_BrokenShortcut_Control = New IMSS_AsstClasses.IMSS_BrokenShortcutUserControl()
        Me.ImsS_StartupCleanerUserControl1 = New IMSS_AsstClasses.IMSS_StartupCleanerUserControl()
        Me._IMSS_MainPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me._IMSS_CONTROLS_PANEL.SuspendLayout()
        Me.Panel22.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Warning_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_LoadingGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.Controls.Add(Me.PictureBox1)
        Me._IMSS_MainPanel.Controls.Add(Me.Label4)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_LOW_SETTING_BUTTON)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ADVANCED_SETTING_BUTTON)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_NORMAL_SETTING_BUTTON)
        Me._IMSS_MainPanel.Controls.Add(Me.Label3)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Warning_Icon)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_WArning_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Progress_StepIndicator)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_MINOR_CATGORY_LABEL)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CancelAll_Button)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_OverAllProgress_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_LoadingGif)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CurrentProgress_ProgressBar)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CurrentCatgory_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CurrentFile)
        Me._IMSS_MainPanel.Controls.Add(Me.Panel1)
        Me._IMSS_MainPanel.Controls.Add(Me.Panel4)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Skip_Button)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CONTROLS_PANEL)
        Me._IMSS_MainPanel.Controls.Add(Me.Panel22)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_StartMaintenanc_Label)
        Me._IMSS_MainPanel.Controls.Add(Me.Panel23)
        Me._IMSS_MainPanel.Controls.Add(Me.Panel2)
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(834, 786)
        Me._IMSS_MainPanel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(78, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 14)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Maintenanc settings"
        '
        '_IMSS_LOW_SETTING_BUTTON
        '
        Me._IMSS_LOW_SETTING_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_LOW_SETTING_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me._IMSS_LOW_SETTING_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me._IMSS_LOW_SETTING_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_LOW_SETTING_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_LOW_SETTING_BUTTON.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_LOW_SETTING_BUTTON.Location = New System.Drawing.Point(23, 346)
        Me._IMSS_LOW_SETTING_BUTTON.Name = "_IMSS_LOW_SETTING_BUTTON"
        Me._IMSS_LOW_SETTING_BUTTON.Size = New System.Drawing.Size(75, 35)
        Me._IMSS_LOW_SETTING_BUTTON.TabIndex = 72
        Me._IMSS_LOW_SETTING_BUTTON.Text = "Low"
        Me._IMSS_LOW_SETTING_BUTTON.UseVisualStyleBackColor = False
        '
        '_IMSS_ADVANCED_SETTING_BUTTON
        '
        Me._IMSS_ADVANCED_SETTING_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_ADVANCED_SETTING_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me._IMSS_ADVANCED_SETTING_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me._IMSS_ADVANCED_SETTING_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_ADVANCED_SETTING_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_ADVANCED_SETTING_BUTTON.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_ADVANCED_SETTING_BUTTON.Location = New System.Drawing.Point(175, 346)
        Me._IMSS_ADVANCED_SETTING_BUTTON.Name = "_IMSS_ADVANCED_SETTING_BUTTON"
        Me._IMSS_ADVANCED_SETTING_BUTTON.Size = New System.Drawing.Size(75, 35)
        Me._IMSS_ADVANCED_SETTING_BUTTON.TabIndex = 71
        Me._IMSS_ADVANCED_SETTING_BUTTON.Text = "Advanced"
        Me._IMSS_ADVANCED_SETTING_BUTTON.UseVisualStyleBackColor = False
        '
        '_IMSS_NORMAL_SETTING_BUTTON
        '
        Me._IMSS_NORMAL_SETTING_BUTTON.BackColor = System.Drawing.Color.LightGray
        Me._IMSS_NORMAL_SETTING_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me._IMSS_NORMAL_SETTING_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me._IMSS_NORMAL_SETTING_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_NORMAL_SETTING_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_NORMAL_SETTING_BUTTON.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_NORMAL_SETTING_BUTTON.Location = New System.Drawing.Point(91, 346)
        Me._IMSS_NORMAL_SETTING_BUTTON.Name = "_IMSS_NORMAL_SETTING_BUTTON"
        Me._IMSS_NORMAL_SETTING_BUTTON.Size = New System.Drawing.Size(91, 35)
        Me._IMSS_NORMAL_SETTING_BUTTON.TabIndex = 70
        Me._IMSS_NORMAL_SETTING_BUTTON.Text = "Normal"
        Me._IMSS_NORMAL_SETTING_BUTTON.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(101, 537)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 23)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Current Category :"
        '
        '_IMSS_WArning_Label
        '
        Me._IMSS_WArning_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_WArning_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_WArning_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_WArning_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_WArning_Label.Location = New System.Drawing.Point(435, 463)
        Me._IMSS_WArning_Label.Name = "_IMSS_WArning_Label"
        Me._IMSS_WArning_Label.Size = New System.Drawing.Size(379, 16)
        Me._IMSS_WArning_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_WArning_Label.TabIndex = 66
        Me._IMSS_WArning_Label.Text = "During the deletion, the computer may stop responding temporarily"
        '
        '_IMSS_Progress_StepIndicator
        '
        Me._IMSS_Progress_StepIndicator.Location = New System.Drawing.Point(108, 566)
        Me._IMSS_Progress_StepIndicator.Name = "_IMSS_Progress_StepIndicator"
        Me._IMSS_Progress_StepIndicator.Size = New System.Drawing.Size(610, 4)
        Me._IMSS_Progress_StepIndicator.TabIndex = 65
        Me._IMSS_Progress_StepIndicator.Text = "StepIndicator1"
        '
        '_IMSS_MINOR_CATGORY_LABEL
        '
        Me._IMSS_MINOR_CATGORY_LABEL.AutoSize = True
        Me._IMSS_MINOR_CATGORY_LABEL.BackColor = System.Drawing.Color.White
        Me._IMSS_MINOR_CATGORY_LABEL.Location = New System.Drawing.Point(105, 601)
        Me._IMSS_MINOR_CATGORY_LABEL.Name = "_IMSS_MINOR_CATGORY_LABEL"
        Me._IMSS_MINOR_CATGORY_LABEL.Size = New System.Drawing.Size(19, 13)
        Me._IMSS_MINOR_CATGORY_LABEL.TabIndex = 64
        Me._IMSS_MINOR_CATGORY_LABEL.Text = "..."
        '
        '_IMSS_OverAllProgress_Label
        '
        Me._IMSS_OverAllProgress_Label.AutoSize = True
        Me._IMSS_OverAllProgress_Label.BackColor = System.Drawing.Color.White
        Me._IMSS_OverAllProgress_Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_OverAllProgress_Label.ForeColor = System.Drawing.Color.Green
        Me._IMSS_OverAllProgress_Label.Location = New System.Drawing.Point(670, 536)
        Me._IMSS_OverAllProgress_Label.Name = "_IMSS_OverAllProgress_Label"
        Me._IMSS_OverAllProgress_Label.Size = New System.Drawing.Size(48, 25)
        Me._IMSS_OverAllProgress_Label.TabIndex = 62
        Me._IMSS_OverAllProgress_Label.Text = "0/0"
        '
        '_IMSS_CurrentProgress_ProgressBar
        '
        Me._IMSS_CurrentProgress_ProgressBar.BackColor = System.Drawing.Color.White
        Me._IMSS_CurrentProgress_ProgressBar.Location = New System.Drawing.Point(107, 575)
        Me._IMSS_CurrentProgress_ProgressBar.Name = "_IMSS_CurrentProgress_ProgressBar"
        Me._IMSS_CurrentProgress_ProgressBar.Size = New System.Drawing.Size(611, 23)
        Me._IMSS_CurrentProgress_ProgressBar.TabIndex = 60
        '
        '_IMSS_CurrentCatgory_Label
        '
        Me._IMSS_CurrentCatgory_Label.AutoSize = True
        Me._IMSS_CurrentCatgory_Label.BackColor = System.Drawing.Color.White
        Me._IMSS_CurrentCatgory_Label.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CurrentCatgory_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_CurrentCatgory_Label.Location = New System.Drawing.Point(266, 538)
        Me._IMSS_CurrentCatgory_Label.Name = "_IMSS_CurrentCatgory_Label"
        Me._IMSS_CurrentCatgory_Label.Size = New System.Drawing.Size(30, 22)
        Me._IMSS_CurrentCatgory_Label.TabIndex = 59
        Me._IMSS_CurrentCatgory_Label.Text = "...."
        '
        '_IMSS_CurrentFile
        '
        Me._IMSS_CurrentFile.BackColor = System.Drawing.Color.White
        Me._IMSS_CurrentFile.Location = New System.Drawing.Point(127, 620)
        Me._IMSS_CurrentFile.Name = "_IMSS_CurrentFile"
        Me._IMSS_CurrentFile.Size = New System.Drawing.Size(591, 76)
        Me._IMSS_CurrentFile.TabIndex = 58
        Me._IMSS_CurrentFile.Text = "..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(23, 426)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 31)
        Me.Panel1.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Optimization and maintenanc"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Location = New System.Drawing.Point(23, 447)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(791, 10)
        Me.Panel4.TabIndex = 56
        '
        '_IMSS_CONTROLS_PANEL
        '
        Me._IMSS_CONTROLS_PANEL.AutoScroll = True
        Me._IMSS_CONTROLS_PANEL.BackColor = System.Drawing.Color.White
        Me._IMSS_CONTROLS_PANEL.Controls.Add(Me.ImsS_StartupCleanerUserControl1)
        Me._IMSS_CONTROLS_PANEL.Controls.Add(Me.ImsS_RegistryCleannerUserControl1)
        Me._IMSS_CONTROLS_PANEL.Controls.Add(Me._IMSS_WindowsCleaner_Control)
        Me._IMSS_CONTROLS_PANEL.Controls.Add(Me._IMSS_BrowserCleaner_Control)
        Me._IMSS_CONTROLS_PANEL.Controls.Add(Me._IMSS_BrokenShortcut_Control)
        Me._IMSS_CONTROLS_PANEL.Location = New System.Drawing.Point(23, 52)
        Me._IMSS_CONTROLS_PANEL.Name = "_IMSS_CONTROLS_PANEL"
        Me._IMSS_CONTROLS_PANEL.Size = New System.Drawing.Size(791, 264)
        Me._IMSS_CONTROLS_PANEL.TabIndex = 54
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel22.Controls.Add(Me.Label1)
        Me.Panel22.Location = New System.Drawing.Point(23, 15)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(201, 31)
        Me.Panel22.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Optimization and maintenanc"
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel23.Location = New System.Drawing.Point(23, 36)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(791, 10)
        Me.Panel23.TabIndex = 52
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(81, 519)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(651, 191)
        Me.Panel2.TabIndex = 69
        '
        '_IMSS_Info_ToolTip
        '
        Me._IMSS_Info_ToolTip.AutoPopDelay = 20000
        Me._IMSS_Info_ToolTip.InitialDelay = 500
        Me._IMSS_Info_ToolTip.ReshowDelay = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_Info_Icon_16x16
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(252, 356)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        Me._IMSS_Info_ToolTip.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        '
        '_IMSS_Warning_Icon
        '
        Me._IMSS_Warning_Icon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Warning_Icon.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_Warning_Icon.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_ProcessingWarning_Icon_16x16
        Me._IMSS_Warning_Icon.InitialImage = Nothing
        Me._IMSS_Warning_Icon.Location = New System.Drawing.Point(413, 463)
        Me._IMSS_Warning_Icon.Name = "_IMSS_Warning_Icon"
        Me._IMSS_Warning_Icon.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Warning_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me._IMSS_Warning_Icon.TabIndex = 67
        Me._IMSS_Warning_Icon.TabStop = False
        '
        '_IMSS_CancelAll_Button
        '
        Me._IMSS_CancelAll_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_CancelAll_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_CancelAll_Button.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CancelAll_Button.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_CANCEL_Icon_16x16
        Me._IMSS_CancelAll_Button.Location = New System.Drawing.Point(651, 734)
        Me._IMSS_CancelAll_Button.Name = "_IMSS_CancelAll_Button"
        Me._IMSS_CancelAll_Button.Size = New System.Drawing.Size(91, 35)
        Me._IMSS_CancelAll_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_CancelAll_Button.TabIndex = 63
        Me._IMSS_CancelAll_Button.Text = "Cancel all"
        '
        '_IMSS_LoadingGif
        '
        Me._IMSS_LoadingGif.Enabled = False
        Me._IMSS_LoadingGif.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_LoadimgGif_Icon
        Me._IMSS_LoadingGif.Location = New System.Drawing.Point(105, 617)
        Me._IMSS_LoadingGif.Name = "_IMSS_LoadingGif"
        Me._IMSS_LoadingGif.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_LoadingGif.TabIndex = 61
        Me._IMSS_LoadingGif.TabStop = False
        '
        '_IMSS_Skip_Button
        '
        Me._IMSS_Skip_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Skip_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Skip_Button.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Skip_Button.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_SKIP_Icon_16x16
        Me._IMSS_Skip_Button.Location = New System.Drawing.Point(740, 734)
        Me._IMSS_Skip_Button.Name = "_IMSS_Skip_Button"
        Me._IMSS_Skip_Button.Size = New System.Drawing.Size(74, 35)
        Me._IMSS_Skip_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Skip_Button.TabIndex = 55
        Me._IMSS_Skip_Button.Text = "Skip"
        '
        '_IMSS_StartMaintenanc_Label
        '
        Me._IMSS_StartMaintenanc_Label.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_StartMaintenanc_Label.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_StartMaintenanc_Label.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_StartMaintenanc_Label.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_StartMaintenanc_Icon_24x24
        Me._IMSS_StartMaintenanc_Label.Location = New System.Drawing.Point(665, 346)
        Me._IMSS_StartMaintenanc_Label.Name = "_IMSS_StartMaintenanc_Label"
        Me._IMSS_StartMaintenanc_Label.Size = New System.Drawing.Size(149, 35)
        Me._IMSS_StartMaintenanc_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_StartMaintenanc_Label.TabIndex = 8
        Me._IMSS_StartMaintenanc_Label.Text = "Start Maintenanc"
        '
        'ImsS_RegistryCleannerUserControl1
        '
        Me.ImsS_RegistryCleannerUserControl1.Location = New System.Drawing.Point(14, 253)
        Me.ImsS_RegistryCleannerUserControl1.Name = "ImsS_RegistryCleannerUserControl1"
        Me.ImsS_RegistryCleannerUserControl1.Size = New System.Drawing.Size(748, 58)
        Me.ImsS_RegistryCleannerUserControl1.TabIndex = 3
        '
        '_IMSS_WindowsCleaner_Control
        '
        Me._IMSS_WindowsCleaner_Control._IMSS_EXIT_CURRENT_PROCESS = False
        Me._IMSS_WindowsCleaner_Control._IMSS_GET_SELECT_STATUS = True
        Me._IMSS_WindowsCleaner_Control.Location = New System.Drawing.Point(14, 174)
        Me._IMSS_WindowsCleaner_Control.Name = "_IMSS_WindowsCleaner_Control"
        Me._IMSS_WindowsCleaner_Control.Size = New System.Drawing.Size(748, 58)
        Me._IMSS_WindowsCleaner_Control.TabIndex = 2
        '
        '_IMSS_BrowserCleaner_Control
        '
        Me._IMSS_BrowserCleaner_Control._IMSS_EXIT_CURRENT_PROCESS = False
        Me._IMSS_BrowserCleaner_Control._IMSS_GET_SELECT_STATUS = True
        Me._IMSS_BrowserCleaner_Control.Location = New System.Drawing.Point(14, 92)
        Me._IMSS_BrowserCleaner_Control.Name = "_IMSS_BrowserCleaner_Control"
        Me._IMSS_BrowserCleaner_Control.Size = New System.Drawing.Size(748, 58)
        Me._IMSS_BrowserCleaner_Control.TabIndex = 1
        '
        '_IMSS_BrokenShortcut_Control
        '
        Me._IMSS_BrokenShortcut_Control._IMSS_EXIT_CURRENT_PROCESS = False
        Me._IMSS_BrokenShortcut_Control._IMSS_GET_SELECT_STATUS = True
        Me._IMSS_BrokenShortcut_Control.Location = New System.Drawing.Point(14, 16)
        Me._IMSS_BrokenShortcut_Control.Name = "_IMSS_BrokenShortcut_Control"
        Me._IMSS_BrokenShortcut_Control.Size = New System.Drawing.Size(748, 58)
        Me._IMSS_BrokenShortcut_Control.TabIndex = 0
        '
        'ImsS_StartupCleanerUserControl1
        '
        Me.ImsS_StartupCleanerUserControl1.Location = New System.Drawing.Point(14, 334)
        Me.ImsS_StartupCleanerUserControl1.Name = "ImsS_StartupCleanerUserControl1"
        Me.ImsS_StartupCleanerUserControl1.Size = New System.Drawing.Size(748, 58)
        Me.ImsS_StartupCleanerUserControl1.TabIndex = 4
        '
        'MainControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Name = "MainControls"
        Me.Size = New System.Drawing.Size(834, 786)
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me._IMSS_CONTROLS_PANEL.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Warning_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_LoadingGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_Skip_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_CONTROLS_PANEL As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_BrowserCleaner_Control As IMSS_AsstClasses.IMSS_CleanupBrowserUserControl
    Friend WithEvents _IMSS_BrokenShortcut_Control As IMSS_AsstClasses.IMSS_BrokenShortcutUserControl
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_StartMaintenanc_Label As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_LoadingGif As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_CurrentProgress_ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_CurrentCatgory_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_CurrentFile As System.Windows.Forms.Label
    Friend WithEvents _IMSS_OverAllProgress_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_CancelAll_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_WindowsCleaner_Control As IMSS_AsstClasses.IMSS_WindowsCleaner
    Friend WithEvents _IMSS_MINOR_CATGORY_LABEL As System.Windows.Forms.Label
    Friend WithEvents _IMSS_Progress_StepIndicator As DevComponents.DotNetBar.Controls.StepIndicator
    Friend WithEvents _IMSS_Warning_Icon As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_WArning_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_LOW_SETTING_BUTTON As System.Windows.Forms.Button
    Friend WithEvents _IMSS_ADVANCED_SETTING_BUTTON As System.Windows.Forms.Button
    Friend WithEvents _IMSS_NORMAL_SETTING_BUTTON As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Info_ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ImsS_RegistryCleannerUserControl1 As IMSS_AsstClasses.IMSS_RegistryCleannerUserControl
    Friend WithEvents ImsS_StartupCleanerUserControl1 As IMSS_AsstClasses.IMSS_StartupCleanerUserControl

End Class
