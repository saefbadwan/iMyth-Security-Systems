<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanReport))
        Me._IMSS_THREAT_IMAGES = New System.Windows.Forms.ImageList(Me.components)
        Me._ButtonImages = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_LOADING_PICTUREBOX = New System.Windows.Forms.PictureBox()
        Me._IMSS_QUARANTINE_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_DELETE_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_STARTONLINEHELP_LINKLABEL = New System.Windows.Forms.LinkLabel()
        Me._IMSS_SLIDE_OUT_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_THREAT_LISTVIEW = New System.Windows.Forms.ListView()
        Me._IMSS_THREAT_NAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._IMSS_THREAT_TYPE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._IMSS_ONLINE_HELP_LINKLABEL = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me._IMSS_USB_TARGET = New System.Windows.Forms.Label()
        Me._IMSS_THREAD_STATUS = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._IMSS_NUMBEROFTHREAD = New System.Windows.Forms.Label()
        Me._IMSS_RESULT_THREAT = New System.Windows.Forms.Button()
        Me._IMSS_EXIT_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_SLIDE_OUT_PANEL = New System.Windows.Forms.Panel()
        Me._IMSS_SCAN_DATE_LABEL = New System.Windows.Forms.Label()
        CType(Me._IMSS_LOADING_PICTUREBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me._IMSS_SLIDE_OUT_PANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_THREAT_IMAGES
        '
        Me._IMSS_THREAT_IMAGES.ImageStream = CType(resources.GetObject("_IMSS_THREAT_IMAGES.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_THREAT_IMAGES.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_THREAT_IMAGES.Images.SetKeyName(0, "_IMSS_Warning_Icon_16x16.png")
        Me._IMSS_THREAT_IMAGES.Images.SetKeyName(1, "_IMSS_GreenCheckMark_Icon_16x16.png")
        Me._IMSS_THREAT_IMAGES.Images.SetKeyName(2, "Custom-Icon-Design-Pretty-Office-4-Report.ico")
        '
        '_ButtonImages
        '
        Me._ButtonImages.ImageStream = CType(resources.GetObject("_ButtonImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._ButtonImages.TransparentColor = System.Drawing.Color.Transparent
        Me._ButtonImages.Images.SetKeyName(0, "Custom-Icon-Design-Pretty-Office-4-Report.ico")
        Me._ButtonImages.Images.SetKeyName(1, "Custom-Icon-Design-Office-Forward.ico")
        Me._ButtonImages.Images.SetKeyName(2, "log-2.png")
        Me._ButtonImages.Images.SetKeyName(3, "_IMSS_DeleteButton_Icon_20x20.png")
        Me._ButtonImages.Images.SetKeyName(4, "_IMSS_Q_Button_Icon_20x20.png")
        Me._ButtonImages.Images.SetKeyName(5, "_IMSS_Right_Arrow.png")
        Me._ButtonImages.Images.SetKeyName(6, "_IMSS_Left_Arrow.png")
        '
        '_IMSS_LOADING_PICTUREBOX
        '
        Me._IMSS_LOADING_PICTUREBOX.Image = CType(resources.GetObject("_IMSS_LOADING_PICTUREBOX.Image"), System.Drawing.Image)
        Me._IMSS_LOADING_PICTUREBOX.Location = New System.Drawing.Point(49, 157)
        Me._IMSS_LOADING_PICTUREBOX.Name = "_IMSS_LOADING_PICTUREBOX"
        Me._IMSS_LOADING_PICTUREBOX.Size = New System.Drawing.Size(148, 34)
        Me._IMSS_LOADING_PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_LOADING_PICTUREBOX.TabIndex = 43
        Me._IMSS_LOADING_PICTUREBOX.TabStop = False
        Me._IMSS_LOADING_PICTUREBOX.Visible = False
        '
        '_IMSS_QUARANTINE_BUTTON
        '
        Me._IMSS_QUARANTINE_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_QUARANTINE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_QUARANTINE_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_QUARANTINE_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_QUARANTINE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_QUARANTINE_BUTTON.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_QUARANTINE_BUTTON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_QUARANTINE_BUTTON.ImageKey = "_IMSS_Q_Button_Icon_20x20.png"
        Me._IMSS_QUARANTINE_BUTTON.ImageList = Me._ButtonImages
        Me._IMSS_QUARANTINE_BUTTON.Location = New System.Drawing.Point(316, 158)
        Me._IMSS_QUARANTINE_BUTTON.Name = "_IMSS_QUARANTINE_BUTTON"
        Me._IMSS_QUARANTINE_BUTTON.Size = New System.Drawing.Size(107, 31)
        Me._IMSS_QUARANTINE_BUTTON.TabIndex = 42
        Me._IMSS_QUARANTINE_BUTTON.Text = "  Quarantine"
        Me._IMSS_QUARANTINE_BUTTON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_QUARANTINE_BUTTON.UseVisualStyleBackColor = False
        '
        '_IMSS_DELETE_BUTTON
        '
        Me._IMSS_DELETE_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_DELETE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_DELETE_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_DELETE_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_DELETE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_DELETE_BUTTON.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_DELETE_BUTTON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_DELETE_BUTTON.ImageKey = "_IMSS_DeleteButton_Icon_20x20.png"
        Me._IMSS_DELETE_BUTTON.ImageList = Me._ButtonImages
        Me._IMSS_DELETE_BUTTON.Location = New System.Drawing.Point(203, 158)
        Me._IMSS_DELETE_BUTTON.Name = "_IMSS_DELETE_BUTTON"
        Me._IMSS_DELETE_BUTTON.Size = New System.Drawing.Size(107, 31)
        Me._IMSS_DELETE_BUTTON.TabIndex = 41
        Me._IMSS_DELETE_BUTTON.Text = "Delete"
        Me._IMSS_DELETE_BUTTON.UseVisualStyleBackColor = False
        '
        '_IMSS_STARTONLINEHELP_LINKLABEL
        '
        Me._IMSS_STARTONLINEHELP_LINKLABEL.AutoSize = True
        Me._IMSS_STARTONLINEHELP_LINKLABEL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_STARTONLINEHELP_LINKLABEL.ForeColor = System.Drawing.Color.Silver
        Me._IMSS_STARTONLINEHELP_LINKLABEL.LinkColor = System.Drawing.Color.DarkCyan
        Me._IMSS_STARTONLINEHELP_LINKLABEL.Location = New System.Drawing.Point(11, 167)
        Me._IMSS_STARTONLINEHELP_LINKLABEL.Name = "_IMSS_STARTONLINEHELP_LINKLABEL"
        Me._IMSS_STARTONLINEHELP_LINKLABEL.Size = New System.Drawing.Size(32, 13)
        Me._IMSS_STARTONLINEHELP_LINKLABEL.TabIndex = 40
        Me._IMSS_STARTONLINEHELP_LINKLABEL.TabStop = True
        Me._IMSS_STARTONLINEHELP_LINKLABEL.Text = "Help"
        '
        '_IMSS_SLIDE_OUT_BUTTON
        '
        Me._IMSS_SLIDE_OUT_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_SLIDE_OUT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_SLIDE_OUT_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_SLIDE_OUT_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_SLIDE_OUT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_SLIDE_OUT_BUTTON.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SLIDE_OUT_BUTTON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_SLIDE_OUT_BUTTON.ImageKey = "_IMSS_Left_Arrow.png"
        Me._IMSS_SLIDE_OUT_BUTTON.ImageList = Me._ButtonImages
        Me._IMSS_SLIDE_OUT_BUTTON.Location = New System.Drawing.Point(429, 158)
        Me._IMSS_SLIDE_OUT_BUTTON.Name = "_IMSS_SLIDE_OUT_BUTTON"
        Me._IMSS_SLIDE_OUT_BUTTON.Size = New System.Drawing.Size(75, 31)
        Me._IMSS_SLIDE_OUT_BUTTON.TabIndex = 39
        Me._IMSS_SLIDE_OUT_BUTTON.Text = "Back  "
        Me._IMSS_SLIDE_OUT_BUTTON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_SLIDE_OUT_BUTTON.UseVisualStyleBackColor = False
        '
        '_IMSS_THREAT_LISTVIEW
        '
        Me._IMSS_THREAT_LISTVIEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._IMSS_THREAT_LISTVIEW.CheckBoxes = True
        Me._IMSS_THREAT_LISTVIEW.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._IMSS_THREAT_NAME, Me._IMSS_THREAT_TYPE})
        Me._IMSS_THREAT_LISTVIEW.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_THREAT_LISTVIEW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_THREAT_LISTVIEW.GridLines = True
        Me._IMSS_THREAT_LISTVIEW.Location = New System.Drawing.Point(1, 2)
        Me._IMSS_THREAT_LISTVIEW.Name = "_IMSS_THREAT_LISTVIEW"
        Me._IMSS_THREAT_LISTVIEW.Size = New System.Drawing.Size(510, 151)
        Me._IMSS_THREAT_LISTVIEW.SmallImageList = Me._IMSS_THREAT_IMAGES
        Me._IMSS_THREAT_LISTVIEW.TabIndex = 38
        Me._IMSS_THREAT_LISTVIEW.UseCompatibleStateImageBehavior = False
        Me._IMSS_THREAT_LISTVIEW.View = System.Windows.Forms.View.Details
        '
        '_IMSS_THREAT_NAME
        '
        Me._IMSS_THREAT_NAME.Text = "Threat Name"
        Me._IMSS_THREAT_NAME.Width = 360
        '
        '_IMSS_THREAT_TYPE
        '
        Me._IMSS_THREAT_TYPE.Text = "Threat Type"
        Me._IMSS_THREAT_TYPE.Width = 143
        '
        '_IMSS_ONLINE_HELP_LINKLABEL
        '
        Me._IMSS_ONLINE_HELP_LINKLABEL.AutoSize = True
        Me._IMSS_ONLINE_HELP_LINKLABEL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ONLINE_HELP_LINKLABEL.ForeColor = System.Drawing.Color.Silver
        Me._IMSS_ONLINE_HELP_LINKLABEL.LinkColor = System.Drawing.Color.DarkCyan
        Me._IMSS_ONLINE_HELP_LINKLABEL.Location = New System.Drawing.Point(12, 361)
        Me._IMSS_ONLINE_HELP_LINKLABEL.Name = "_IMSS_ONLINE_HELP_LINKLABEL"
        Me._IMSS_ONLINE_HELP_LINKLABEL.Size = New System.Drawing.Size(32, 13)
        Me._IMSS_ONLINE_HELP_LINKLABEL.TabIndex = 47
        Me._IMSS_ONLINE_HELP_LINKLABEL.TabStop = True
        Me._IMSS_ONLINE_HELP_LINKLABEL.Text = "Help"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me._IMSS_USB_TARGET)
        Me.Panel2.Controls.Add(Me._IMSS_SCAN_DATE_LABEL)
        Me.Panel2.Controls.Add(Me._IMSS_THREAD_STATUS)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me._IMSS_NUMBEROFTHREAD)
        Me.Panel2.Location = New System.Drawing.Point(1, 199)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(516, 146)
        Me.Panel2.TabIndex = 44
        '
        '_IMSS_USB_TARGET
        '
        Me._IMSS_USB_TARGET.AutoSize = True
        Me._IMSS_USB_TARGET.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_USB_TARGET.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_USB_TARGET.Location = New System.Drawing.Point(101, 70)
        Me._IMSS_USB_TARGET.Name = "_IMSS_USB_TARGET"
        Me._IMSS_USB_TARGET.Size = New System.Drawing.Size(0, 14)
        Me._IMSS_USB_TARGET.TabIndex = 21
        '
        '_IMSS_THREAD_STATUS
        '
        Me._IMSS_THREAD_STATUS.AutoSize = True
        Me._IMSS_THREAD_STATUS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_THREAD_STATUS.ForeColor = System.Drawing.Color.Red
        Me._IMSS_THREAD_STATUS.Location = New System.Drawing.Point(114, 43)
        Me._IMSS_THREAD_STATUS.Name = "_IMSS_THREAD_STATUS"
        Me._IMSS_THREAD_STATUS.Size = New System.Drawing.Size(0, 16)
        Me._IMSS_THREAD_STATUS.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(16, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 14)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Scan date :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(16, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 14)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Threats stats :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(16, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 14)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Target drive:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(16, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 14)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Threats Found:"
        '
        '_IMSS_NUMBEROFTHREAD
        '
        Me._IMSS_NUMBEROFTHREAD.AutoSize = True
        Me._IMSS_NUMBEROFTHREAD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_NUMBEROFTHREAD.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_NUMBEROFTHREAD.Location = New System.Drawing.Point(122, 14)
        Me._IMSS_NUMBEROFTHREAD.Name = "_IMSS_NUMBEROFTHREAD"
        Me._IMSS_NUMBEROFTHREAD.Size = New System.Drawing.Size(0, 16)
        Me._IMSS_NUMBEROFTHREAD.TabIndex = 18
        Me._IMSS_NUMBEROFTHREAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_IMSS_RESULT_THREAT
        '
        Me._IMSS_RESULT_THREAT.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_RESULT_THREAT.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_RESULT_THREAT.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_RESULT_THREAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_RESULT_THREAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_RESULT_THREAT.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_RESULT_THREAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_RESULT_THREAT.ImageKey = "Custom-Icon-Design-Pretty-Office-4-Report.ico"
        Me._IMSS_RESULT_THREAT.ImageList = Me._ButtonImages
        Me._IMSS_RESULT_THREAT.Location = New System.Drawing.Point(349, 352)
        Me._IMSS_RESULT_THREAT.Name = "_IMSS_RESULT_THREAT"
        Me._IMSS_RESULT_THREAT.Size = New System.Drawing.Size(75, 31)
        Me._IMSS_RESULT_THREAT.TabIndex = 46
        Me._IMSS_RESULT_THREAT.Text = "Report"
        Me._IMSS_RESULT_THREAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_RESULT_THREAT.UseVisualStyleBackColor = False
        '
        '_IMSS_EXIT_BUTTON
        '
        Me._IMSS_EXIT_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_EXIT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_EXIT_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_EXIT_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_EXIT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_EXIT_BUTTON.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_EXIT_BUTTON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_EXIT_BUTTON.ImageKey = "_IMSS_Right_Arrow.png"
        Me._IMSS_EXIT_BUTTON.ImageList = Me._ButtonImages
        Me._IMSS_EXIT_BUTTON.Location = New System.Drawing.Point(430, 352)
        Me._IMSS_EXIT_BUTTON.Name = "_IMSS_EXIT_BUTTON"
        Me._IMSS_EXIT_BUTTON.Size = New System.Drawing.Size(75, 31)
        Me._IMSS_EXIT_BUTTON.TabIndex = 45
        Me._IMSS_EXIT_BUTTON.Text = "    Open"
        Me._IMSS_EXIT_BUTTON.UseVisualStyleBackColor = False
        '
        '_IMSS_SLIDE_OUT_PANEL
        '
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me._IMSS_ONLINE_HELP_LINKLABEL)
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me._IMSS_QUARANTINE_BUTTON)
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me._IMSS_SLIDE_OUT_BUTTON)
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me.Panel2)
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me._IMSS_RESULT_THREAT)
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me._IMSS_STARTONLINEHELP_LINKLABEL)
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me._IMSS_DELETE_BUTTON)
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me._IMSS_EXIT_BUTTON)
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me._IMSS_LOADING_PICTUREBOX)
        Me._IMSS_SLIDE_OUT_PANEL.Controls.Add(Me._IMSS_THREAT_LISTVIEW)
        Me._IMSS_SLIDE_OUT_PANEL.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_SLIDE_OUT_PANEL.Name = "_IMSS_SLIDE_OUT_PANEL"
        Me._IMSS_SLIDE_OUT_PANEL.Size = New System.Drawing.Size(511, 389)
        Me._IMSS_SLIDE_OUT_PANEL.TabIndex = 49
        '
        '_IMSS_SCAN_DATE_LABEL
        '
        Me._IMSS_SCAN_DATE_LABEL.AutoSize = True
        Me._IMSS_SCAN_DATE_LABEL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SCAN_DATE_LABEL.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_SCAN_DATE_LABEL.Location = New System.Drawing.Point(92, 96)
        Me._IMSS_SCAN_DATE_LABEL.Name = "_IMSS_SCAN_DATE_LABEL"
        Me._IMSS_SCAN_DATE_LABEL.Size = New System.Drawing.Size(0, 15)
        Me._IMSS_SCAN_DATE_LABEL.TabIndex = 26
        '
        'ScanReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.Controls.Add(Me._IMSS_SLIDE_OUT_PANEL)
        Me.Name = "ScanReport"
        Me.Size = New System.Drawing.Size(511, 389)
        CType(Me._IMSS_LOADING_PICTUREBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me._IMSS_SLIDE_OUT_PANEL.ResumeLayout(False)
        Me._IMSS_SLIDE_OUT_PANEL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_THREAT_IMAGES As System.Windows.Forms.ImageList
    Friend WithEvents _ButtonImages As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_LOADING_PICTUREBOX As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_QUARANTINE_BUTTON As System.Windows.Forms.Button
    Friend WithEvents _IMSS_DELETE_BUTTON As System.Windows.Forms.Button
    Friend WithEvents _IMSS_STARTONLINEHELP_LINKLABEL As System.Windows.Forms.LinkLabel
    Friend WithEvents _IMSS_SLIDE_OUT_BUTTON As System.Windows.Forms.Button
    Friend WithEvents _IMSS_THREAT_LISTVIEW As System.Windows.Forms.ListView
    Friend WithEvents _IMSS_THREAT_NAME As System.Windows.Forms.ColumnHeader
    Friend WithEvents _IMSS_THREAT_TYPE As System.Windows.Forms.ColumnHeader
    Friend WithEvents _IMSS_ONLINE_HELP_LINKLABEL As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_USB_TARGET As System.Windows.Forms.Label
    Friend WithEvents _IMSS_THREAD_STATUS As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_NUMBEROFTHREAD As System.Windows.Forms.Label
    Friend WithEvents _IMSS_RESULT_THREAT As System.Windows.Forms.Button
    Friend WithEvents _IMSS_EXIT_BUTTON As System.Windows.Forms.Button
    Friend WithEvents _IMSS_SLIDE_OUT_PANEL As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_SCAN_DATE_LABEL As System.Windows.Forms.Label

End Class
