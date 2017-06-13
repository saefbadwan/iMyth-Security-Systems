<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_USBScanCotrolsUint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_USBScanCotrolsUint))
        Me._IMSS_ITEM_SCAN_TYPE = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_CheckingIfRemovabelDriveInUse = New System.Windows.Forms.Panel()
        Me._IMSS_USB_Logo = New System.Windows.Forms.PictureBox()
        Me._IMSS_SCANUSB_STATUS = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._IMSS_DviceToScan = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me._IMSS_SCAN_SLIDE = New System.Windows.Forms.FlowLayoutPanel()
        Me._IMSS_DVICES_FOUND_PANEL = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me._IMSS_USB_CONTROLS_PANEL = New System.Windows.Forms.Panel()
        Me._IMSS_FAST_SCAN = New System.Windows.Forms.Button()
        Me._IMSS_DEEP_SCAN_Button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me._IMSS_OUT_PUT_Flow = New System.Windows.Forms.FlowLayoutPanel()
        Me._IMSS_LIST_OUT_PUT_Panel = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lstFile = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button49 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me._IMSS_UOT_PUT_Panel = New System.Windows.Forms.Panel()
        Me._IMSS_Report_PicuterBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_SCAN_TYPE = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me._IMSS_SCANSTARTAT_Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me._IMSS_THREAT_STATS_Label = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._IMSS_TARGET_Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._IMSS_THREAT_FOUNDS_Label = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me._IMSS_SCANER = New System.ComponentModel.BackgroundWorker()
        Me._IMSS_SLIDEOUT = New System.Windows.Forms.Timer(Me.components)
        Me._IMSS_SLIDEIN = New System.Windows.Forms.Timer(Me.components)
        Me._IMSS_SLIDEOUT_LIST = New System.Windows.Forms.Timer(Me.components)
        Me._IMSS_CheckingIfRemovabelDriveInUse.SuspendLayout()
        CType(Me._IMSS_USB_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me._IMSS_SCAN_SLIDE.SuspendLayout()
        Me._IMSS_DVICES_FOUND_PANEL.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me._IMSS_OUT_PUT_Flow.SuspendLayout()
        Me._IMSS_LIST_OUT_PUT_Panel.SuspendLayout()
        Me._IMSS_UOT_PUT_Panel.SuspendLayout()
        CType(Me._IMSS_Report_PicuterBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel28.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_ITEM_SCAN_TYPE
        '
        Me._IMSS_ITEM_SCAN_TYPE.ImageStream = CType(resources.GetObject("_IMSS_ITEM_SCAN_TYPE.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_ITEM_SCAN_TYPE.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_ITEM_SCAN_TYPE.Images.SetKeyName(0, "Warning-icon.png")
        Me._IMSS_ITEM_SCAN_TYPE.Images.SetKeyName(1, "12379140591570510706dholler_ok.svg.hi.png")
        Me._IMSS_ITEM_SCAN_TYPE.Images.SetKeyName(2, "Custom-Icon-Design-Pretty-Office-4-Report.ico")
        Me._IMSS_ITEM_SCAN_TYPE.Images.SetKeyName(3, "faq_256.png")
        '
        '_IMSS_CheckingIfRemovabelDriveInUse
        '
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me._IMSS_USB_Logo)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me._IMSS_SCANUSB_STATUS)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me.Panel1)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me.Panel2)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Location = New System.Drawing.Point(3, 3)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Name = "_IMSS_CheckingIfRemovabelDriveInUse"
        Me._IMSS_CheckingIfRemovabelDriveInUse.Size = New System.Drawing.Size(640, 0)
        Me._IMSS_CheckingIfRemovabelDriveInUse.TabIndex = 64
        '
        '_IMSS_USB_Logo
        '
        Me._IMSS_USB_Logo.Image = CType(resources.GetObject("_IMSS_USB_Logo.Image"), System.Drawing.Image)
        Me._IMSS_USB_Logo.Location = New System.Drawing.Point(229, 156)
        Me._IMSS_USB_Logo.Name = "_IMSS_USB_Logo"
        Me._IMSS_USB_Logo.Size = New System.Drawing.Size(182, 64)
        Me._IMSS_USB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_USB_Logo.TabIndex = 72
        Me._IMSS_USB_Logo.TabStop = False
        '
        '_IMSS_SCANUSB_STATUS
        '
        Me._IMSS_SCANUSB_STATUS.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SCANUSB_STATUS.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_SCANUSB_STATUS.Location = New System.Drawing.Point(70, 252)
        Me._IMSS_SCANUSB_STATUS.Name = "_IMSS_SCANUSB_STATUS"
        Me._IMSS_SCANUSB_STATUS.Size = New System.Drawing.Size(500, 23)
        Me._IMSS_SCANUSB_STATUS.TabIndex = 69
        Me._IMSS_SCANUSB_STATUS.Text = "There is no removable devices connected to this computer"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me._IMSS_DviceToScan)
        Me.Panel1.Location = New System.Drawing.Point(5, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(103, 26)
        Me.Panel1.TabIndex = 67
        '
        '_IMSS_DviceToScan
        '
        Me._IMSS_DviceToScan.AutoSize = True
        Me._IMSS_DviceToScan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me._IMSS_DviceToScan.ForeColor = System.Drawing.Color.White
        Me._IMSS_DviceToScan.Location = New System.Drawing.Point(8, 6)
        Me._IMSS_DviceToScan.Name = "_IMSS_DviceToScan"
        Me._IMSS_DviceToScan.Size = New System.Drawing.Size(86, 14)
        Me._IMSS_DviceToScan.TabIndex = 48
        Me._IMSS_DviceToScan.Text = "Device to scan"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Location = New System.Drawing.Point(5, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(623, 10)
        Me.Panel2.TabIndex = 66
        '
        '_IMSS_SCAN_SLIDE
        '
        Me._IMSS_SCAN_SLIDE.Controls.Add(Me._IMSS_CheckingIfRemovabelDriveInUse)
        Me._IMSS_SCAN_SLIDE.Controls.Add(Me._IMSS_DVICES_FOUND_PANEL)
        Me._IMSS_SCAN_SLIDE.Controls.Add(Me.Panel3)
        Me._IMSS_SCAN_SLIDE.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_SCAN_SLIDE.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_SCAN_SLIDE.Name = "_IMSS_SCAN_SLIDE"
        Me._IMSS_SCAN_SLIDE.Size = New System.Drawing.Size(640, 376)
        Me._IMSS_SCAN_SLIDE.TabIndex = 65
        '
        '_IMSS_DVICES_FOUND_PANEL
        '
        Me._IMSS_DVICES_FOUND_PANEL.Controls.Add(Me.Panel5)
        Me._IMSS_DVICES_FOUND_PANEL.Controls.Add(Me.Panel6)
        Me._IMSS_DVICES_FOUND_PANEL.Controls.Add(Me.Panel24)
        Me._IMSS_DVICES_FOUND_PANEL.Controls.Add(Me.Panel25)
        Me._IMSS_DVICES_FOUND_PANEL.Controls.Add(Me._IMSS_USB_CONTROLS_PANEL)
        Me._IMSS_DVICES_FOUND_PANEL.Controls.Add(Me._IMSS_FAST_SCAN)
        Me._IMSS_DVICES_FOUND_PANEL.Controls.Add(Me._IMSS_DEEP_SCAN_Button)
        Me._IMSS_DVICES_FOUND_PANEL.Location = New System.Drawing.Point(3, 9)
        Me._IMSS_DVICES_FOUND_PANEL.Name = "_IMSS_DVICES_FOUND_PANEL"
        Me._IMSS_DVICES_FOUND_PANEL.Size = New System.Drawing.Size(640, 364)
        Me._IMSS_DVICES_FOUND_PANEL.TabIndex = 60
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(148, 26)
        Me.Panel5.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Select Destination Drive"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel6.Location = New System.Drawing.Point(3, 18)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(621, 10)
        Me.Panel6.TabIndex = 56
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel24.Controls.Add(Me.Label14)
        Me.Panel24.Location = New System.Drawing.Point(3, 263)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(86, 26)
        Me.Panel24.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(15, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 14)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Options"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel25.Location = New System.Drawing.Point(3, 279)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(621, 10)
        Me.Panel25.TabIndex = 54
        '
        '_IMSS_USB_CONTROLS_PANEL
        '
        Me._IMSS_USB_CONTROLS_PANEL.AutoScroll = True
        Me._IMSS_USB_CONTROLS_PANEL.Location = New System.Drawing.Point(0, 29)
        Me._IMSS_USB_CONTROLS_PANEL.Name = "_IMSS_USB_CONTROLS_PANEL"
        Me._IMSS_USB_CONTROLS_PANEL.Size = New System.Drawing.Size(640, 228)
        Me._IMSS_USB_CONTROLS_PANEL.TabIndex = 3
        '
        '_IMSS_FAST_SCAN
        '
        Me._IMSS_FAST_SCAN.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_FAST_SCAN.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me._IMSS_FAST_SCAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_FAST_SCAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_FAST_SCAN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_FAST_SCAN.Image = CType(resources.GetObject("_IMSS_FAST_SCAN.Image"), System.Drawing.Image)
        Me._IMSS_FAST_SCAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_FAST_SCAN.Location = New System.Drawing.Point(339, 309)
        Me._IMSS_FAST_SCAN.Name = "_IMSS_FAST_SCAN"
        Me._IMSS_FAST_SCAN.Size = New System.Drawing.Size(241, 36)
        Me._IMSS_FAST_SCAN.TabIndex = 2
        Me._IMSS_FAST_SCAN.Text = "Fast scan"
        Me._IMSS_FAST_SCAN.UseVisualStyleBackColor = False
        '
        '_IMSS_DEEP_SCAN_Button
        '
        Me._IMSS_DEEP_SCAN_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_DEEP_SCAN_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me._IMSS_DEEP_SCAN_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_DEEP_SCAN_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_DEEP_SCAN_Button.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_DEEP_SCAN_Button.Image = CType(resources.GetObject("_IMSS_DEEP_SCAN_Button.Image"), System.Drawing.Image)
        Me._IMSS_DEEP_SCAN_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me._IMSS_DEEP_SCAN_Button.Location = New System.Drawing.Point(62, 309)
        Me._IMSS_DEEP_SCAN_Button.Name = "_IMSS_DEEP_SCAN_Button"
        Me._IMSS_DEEP_SCAN_Button.Size = New System.Drawing.Size(241, 36)
        Me._IMSS_DEEP_SCAN_Button.TabIndex = 1
        Me._IMSS_DEEP_SCAN_Button.Text = "Deep scan"
        Me._IMSS_DEEP_SCAN_Button.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me._IMSS_OUT_PUT_Flow)
        Me.Panel3.Controls.Add(Me.Panel28)
        Me.Panel3.Controls.Add(Me.Panel29)
        Me.Panel3.Location = New System.Drawing.Point(3, 379)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(640, 352)
        Me.Panel3.TabIndex = 28
        '
        '_IMSS_OUT_PUT_Flow
        '
        Me._IMSS_OUT_PUT_Flow.Controls.Add(Me._IMSS_LIST_OUT_PUT_Panel)
        Me._IMSS_OUT_PUT_Flow.Controls.Add(Me._IMSS_UOT_PUT_Panel)
        Me._IMSS_OUT_PUT_Flow.Location = New System.Drawing.Point(16, 37)
        Me._IMSS_OUT_PUT_Flow.Name = "_IMSS_OUT_PUT_Flow"
        Me._IMSS_OUT_PUT_Flow.Size = New System.Drawing.Size(612, 311)
        Me._IMSS_OUT_PUT_Flow.TabIndex = 64
        '
        '_IMSS_LIST_OUT_PUT_Panel
        '
        Me._IMSS_LIST_OUT_PUT_Panel.Controls.Add(Me.ProgressBar1)
        Me._IMSS_LIST_OUT_PUT_Panel.Controls.Add(Me.Label34)
        Me._IMSS_LIST_OUT_PUT_Panel.Controls.Add(Me.lstFile)
        Me._IMSS_LIST_OUT_PUT_Panel.Controls.Add(Me.Panel36)
        Me._IMSS_LIST_OUT_PUT_Panel.Controls.Add(Me.Label64)
        Me._IMSS_LIST_OUT_PUT_Panel.Controls.Add(Me.Button9)
        Me._IMSS_LIST_OUT_PUT_Panel.Controls.Add(Me.Button49)
        Me._IMSS_LIST_OUT_PUT_Panel.Controls.Add(Me.Button8)
        Me._IMSS_LIST_OUT_PUT_Panel.Location = New System.Drawing.Point(3, 3)
        Me._IMSS_LIST_OUT_PUT_Panel.Name = "_IMSS_LIST_OUT_PUT_Panel"
        Me._IMSS_LIST_OUT_PUT_Panel.Size = New System.Drawing.Size(605, 307)
        Me._IMSS_LIST_OUT_PUT_Panel.TabIndex = 13
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 235)
        Me.ProgressBar1.MarqueeAnimationSpeed = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(597, 23)
        Me.ProgressBar1.TabIndex = 17
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Red
        Me.Label34.Location = New System.Drawing.Point(4, 271)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(134, 25)
        Me.Label34.TabIndex = 56
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstFile
        '
        Me.lstFile.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstFile.CheckBoxes = True
        Me.lstFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lstFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstFile.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFile.ForeColor = System.Drawing.Color.Red
        Me.lstFile.GridLines = True
        Me.lstFile.Location = New System.Drawing.Point(0, 0)
        Me.lstFile.Name = "lstFile"
        Me.lstFile.Size = New System.Drawing.Size(605, 213)
        Me.lstFile.SmallImageList = Me._IMSS_ITEM_SCAN_TYPE
        Me.lstFile.TabIndex = 12
        Me.lstFile.UseCompatibleStateImageBehavior = False
        Me.lstFile.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Threat"
        Me.ColumnHeader5.Width = 438
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Size"
        Me.ColumnHeader6.Width = 72
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "State"
        Me.ColumnHeader7.Width = 90
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel36.Location = New System.Drawing.Point(296, 275)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(2, 20)
        Me.Panel36.TabIndex = 58
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.ForeColor = System.Drawing.Color.Gray
        Me.Label64.Location = New System.Drawing.Point(8, 216)
        Me.Label64.MaximumSize = New System.Drawing.Size(545, 14)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(0, 13)
        Me.Label64.TabIndex = 59
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.IMSS.My.Resources.Resources._IMSS_Delete_Icon_32x32
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(457, 267)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(143, 32)
        Me.Button9.TabIndex = 18
        Me.Button9.Text = "Delete"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button49
        '
        Me.Button49.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button49.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button49.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button49.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button49.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button49.Image = CType(resources.GetObject("Button49.Image"), System.Drawing.Image)
        Me.Button49.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button49.Location = New System.Drawing.Point(308, 267)
        Me.Button49.Name = "Button49"
        Me.Button49.Size = New System.Drawing.Size(143, 32)
        Me.Button49.TabIndex = 57
        Me.Button49.Text = "   Quarantine"
        Me.Button49.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.IMSS.My.Resources.Resources._IMSS_Back_Icon_32x32
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(144, 267)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(143, 32)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Back"
        Me.Button8.UseVisualStyleBackColor = False
        '
        '_IMSS_UOT_PUT_Panel
        '
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me._IMSS_Report_PicuterBox)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me._IMSS_SCAN_TYPE)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me.Label11)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me._IMSS_SCANSTARTAT_Label)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me.Label2)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me.Button1)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me.Panel4)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me._IMSS_THREAT_STATS_Label)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me.LinkLabel3)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me.Label7)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me.Label6)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me._IMSS_TARGET_Label)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me.Label4)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me.Label3)
        Me._IMSS_UOT_PUT_Panel.Controls.Add(Me._IMSS_THREAT_FOUNDS_Label)
        Me._IMSS_UOT_PUT_Panel.Location = New System.Drawing.Point(3, 316)
        Me._IMSS_UOT_PUT_Panel.Name = "_IMSS_UOT_PUT_Panel"
        Me._IMSS_UOT_PUT_Panel.Size = New System.Drawing.Size(602, 292)
        Me._IMSS_UOT_PUT_Panel.TabIndex = 14
        '
        '_IMSS_Report_PicuterBox
        '
        Me._IMSS_Report_PicuterBox.Image = CType(resources.GetObject("_IMSS_Report_PicuterBox.Image"), System.Drawing.Image)
        Me._IMSS_Report_PicuterBox.Location = New System.Drawing.Point(512, 6)
        Me._IMSS_Report_PicuterBox.Name = "_IMSS_Report_PicuterBox"
        Me._IMSS_Report_PicuterBox.Size = New System.Drawing.Size(84, 80)
        Me._IMSS_Report_PicuterBox.TabIndex = 59
        Me._IMSS_Report_PicuterBox.TabStop = False
        '
        '_IMSS_SCAN_TYPE
        '
        Me._IMSS_SCAN_TYPE.AutoSize = True
        Me._IMSS_SCAN_TYPE.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SCAN_TYPE.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_SCAN_TYPE.Location = New System.Drawing.Point(388, 22)
        Me._IMSS_SCAN_TYPE.Name = "_IMSS_SCAN_TYPE"
        Me._IMSS_SCAN_TYPE.Size = New System.Drawing.Size(0, 14)
        Me._IMSS_SCAN_TYPE.TabIndex = 58
        Me._IMSS_SCAN_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(320, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 14)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Scan Type :"
        '
        '_IMSS_SCANSTARTAT_Label
        '
        Me._IMSS_SCANSTARTAT_Label.AutoSize = True
        Me._IMSS_SCANSTARTAT_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SCANSTARTAT_Label.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_SCANSTARTAT_Label.Location = New System.Drawing.Point(119, 22)
        Me._IMSS_SCANSTARTAT_Label.Name = "_IMSS_SCANSTARTAT_Label"
        Me._IMSS_SCANSTARTAT_Label.Size = New System.Drawing.Size(0, 15)
        Me._IMSS_SCANSTARTAT_Label.TabIndex = 56
        Me._IMSS_SCANSTARTAT_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(21, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 14)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Scan Start At :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.IMSS.My.Resources.Resources._IMSS_Back_Icon_32x32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(230, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 32)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Location = New System.Drawing.Point(7, 210)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(581, 10)
        Me.Panel4.TabIndex = 53
        '
        '_IMSS_THREAT_STATS_Label
        '
        Me._IMSS_THREAT_STATS_Label.AutoSize = True
        Me._IMSS_THREAT_STATS_Label.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_THREAT_STATS_Label.ForeColor = System.Drawing.Color.Green
        Me._IMSS_THREAT_STATS_Label.Location = New System.Drawing.Point(113, 147)
        Me._IMSS_THREAT_STATS_Label.Name = "_IMSS_THREAT_STATS_Label"
        Me._IMSS_THREAT_STATS_Label.Size = New System.Drawing.Size(54, 14)
        Me._IMSS_THREAT_STATS_Label.TabIndex = 33
        Me._IMSS_THREAT_STATS_Label.Text = "Waiting"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(358, 145)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(57, 14)
        Me.LinkLabel3.TabIndex = 32
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Open log"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(320, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 14)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Log:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(21, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Threats stats:"
        '
        '_IMSS_TARGET_Label
        '
        Me._IMSS_TARGET_Label.AutoSize = True
        Me._IMSS_TARGET_Label.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TARGET_Label.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_TARGET_Label.Location = New System.Drawing.Point(376, 78)
        Me._IMSS_TARGET_Label.Name = "_IMSS_TARGET_Label"
        Me._IMSS_TARGET_Label.Size = New System.Drawing.Size(0, 14)
        Me._IMSS_TARGET_Label.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(320, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 14)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Target:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(21, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 14)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Threats Found:"
        '
        '_IMSS_THREAT_FOUNDS_Label
        '
        Me._IMSS_THREAT_FOUNDS_Label.AutoSize = True
        Me._IMSS_THREAT_FOUNDS_Label.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_THREAT_FOUNDS_Label.ForeColor = System.Drawing.Color.Red
        Me._IMSS_THREAT_FOUNDS_Label.Location = New System.Drawing.Point(122, 78)
        Me._IMSS_THREAT_FOUNDS_Label.Name = "_IMSS_THREAT_FOUNDS_Label"
        Me._IMSS_THREAT_FOUNDS_Label.Size = New System.Drawing.Size(0, 14)
        Me._IMSS_THREAT_FOUNDS_Label.TabIndex = 26
        Me._IMSS_THREAT_FOUNDS_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel28.Controls.Add(Me.Label56)
        Me.Panel28.Location = New System.Drawing.Point(5, 3)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(103, 26)
        Me.Panel28.TabIndex = 53
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.White
        Me.Label56.Location = New System.Drawing.Point(8, 5)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(90, 16)
        Me.Label56.TabIndex = 48
        Me.Label56.Text = "Scan Manager "
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel29.Location = New System.Drawing.Point(5, 19)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(623, 10)
        Me.Panel29.TabIndex = 52
        '
        '_IMSS_SCANER
        '
        Me._IMSS_SCANER.WorkerReportsProgress = True
        Me._IMSS_SCANER.WorkerSupportsCancellation = True
        '
        '_IMSS_SLIDEOUT
        '
        Me._IMSS_SLIDEOUT.Interval = 1
        '
        '_IMSS_SLIDEIN
        '
        Me._IMSS_SLIDEIN.Interval = 1
        '
        '_IMSS_SLIDEOUT_LIST
        '
        Me._IMSS_SLIDEOUT_LIST.Interval = 1
        '
        'IMSS_USBScanCotrolsUint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me._IMSS_SCAN_SLIDE)
        Me.Name = "IMSS_USBScanCotrolsUint"
        Me.Size = New System.Drawing.Size(640, 376)
        Me._IMSS_CheckingIfRemovabelDriveInUse.ResumeLayout(False)
        CType(Me._IMSS_USB_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me._IMSS_SCAN_SLIDE.ResumeLayout(False)
        Me._IMSS_DVICES_FOUND_PANEL.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me._IMSS_OUT_PUT_Flow.ResumeLayout(False)
        Me._IMSS_LIST_OUT_PUT_Panel.ResumeLayout(False)
        Me._IMSS_LIST_OUT_PUT_Panel.PerformLayout()
        Me._IMSS_UOT_PUT_Panel.ResumeLayout(False)
        Me._IMSS_UOT_PUT_Panel.PerformLayout()
        CType(Me._IMSS_Report_PicuterBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_ITEM_SCAN_TYPE As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_CheckingIfRemovabelDriveInUse As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_SCANUSB_STATUS As System.Windows.Forms.Label
    Friend WithEvents _IMSS_DviceToScan As System.Windows.Forms.Label
    Friend WithEvents _IMSS_USB_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_SCAN_SLIDE As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents _IMSS_DVICES_FOUND_PANEL As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_USB_CONTROLS_PANEL As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_FAST_SCAN As System.Windows.Forms.Button
    Friend WithEvents _IMSS_DEEP_SCAN_Button As System.Windows.Forms.Button
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_SCANER As System.ComponentModel.BackgroundWorker
    Friend WithEvents _IMSS_SLIDEOUT As System.Windows.Forms.Timer
    Friend WithEvents _IMSS_SLIDEIN As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_OUT_PUT_Flow As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents _IMSS_LIST_OUT_PUT_Panel As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents lstFile As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel36 As System.Windows.Forms.Panel
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button49 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents _IMSS_UOT_PUT_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_Report_PicuterBox As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_SCAN_TYPE As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_SCANSTARTAT_Label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_THREAT_STATS_Label As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_TARGET_Label As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_THREAT_FOUNDS_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_SLIDEOUT_LIST As System.Windows.Forms.Timer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel

End Class
