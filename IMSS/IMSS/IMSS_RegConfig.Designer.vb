<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_RegConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_RegConfig))
        Me._TextUserName = New System.Windows.Forms.TextBox()
        Me._Text_Email = New System.Windows.Forms.TextBox()
        Me._IMSS_CountryList = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._IMSS_ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me._IMSS_MainPanel = New System.Windows.Forms.Panel()
        Me.IMSS_SlideInTimer = New System.Windows.Forms.Timer(Me.components)
        Me._IMSS_PanelWorking = New System.Windows.Forms.Panel()
        Me._IMSS_Loading_PictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me._IMSS_Register_BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_PanelWorking.SuspendLayout()
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_TextUserName
        '
        Me._TextUserName.Location = New System.Drawing.Point(103, 18)
        Me._TextUserName.Name = "_TextUserName"
        Me._TextUserName.Size = New System.Drawing.Size(202, 20)
        Me._TextUserName.TabIndex = 0
        Me._IMSS_ToolTip.SetToolTip(Me._TextUserName, "Please insert a full name")
        '
        '_Text_Email
        '
        Me._Text_Email.Location = New System.Drawing.Point(103, 54)
        Me._Text_Email.Name = "_Text_Email"
        Me._Text_Email.Size = New System.Drawing.Size(202, 20)
        Me._Text_Email.TabIndex = 1
        Me._IMSS_ToolTip.SetToolTip(Me._Text_Email, "Please insert a full email address")
        '
        '_IMSS_CountryList
        '
        Me._IMSS_CountryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._IMSS_CountryList.FormattingEnabled = True
        Me._IMSS_CountryList.Items.AddRange(New Object() {"Personal", "Business", "Other"})
        Me._IMSS_CountryList.Location = New System.Drawing.Point(103, 91)
        Me._IMSS_CountryList.Name = "_IMSS_CountryList"
        Me._IMSS_CountryList.Size = New System.Drawing.Size(202, 21)
        Me._IMSS_CountryList.TabIndex = 2
        Me._IMSS_ToolTip.SetToolTip(Me._IMSS_CountryList, "Please select your country")
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.ImageKey = "symbol-check-icon.png"
        Me.Button1.ImageList = Me._IMSS_ImageList
        Me.Button1.Location = New System.Drawing.Point(217, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Actvate"
        Me._IMSS_ToolTip.SetToolTip(Me.Button1, "Actvate iMyth Security Systems")
        Me.Button1.UseVisualStyleBackColor = True
        '
        '_IMSS_ImageList
        '
        Me._IMSS_ImageList.ImageStream = CType(resources.GetObject("_IMSS_ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_ImageList.Images.SetKeyName(0, "symbol-check-icon.png")
        Me._IMSS_ImageList.Images.SetKeyName(1, "symbol-delete-icon.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 7.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(103, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 7.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(103, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 7.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(105, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Type of use"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.ImageKey = "symbol-delete-icon.png"
        Me.Button2.ImageList = Me._IMSS_ImageList
        Me.Button2.Location = New System.Drawing.Point(143, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_ToolTip.SetToolTip(Me.Button2, "Exit the systems")
        Me.Button2.UseVisualStyleBackColor = True
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.Controls.Add(Me.PictureBox1)
        Me._IMSS_MainPanel.Controls.Add(Me.Button2)
        Me._IMSS_MainPanel.Controls.Add(Me._TextUserName)
        Me._IMSS_MainPanel.Controls.Add(Me._Text_Email)
        Me._IMSS_MainPanel.Controls.Add(Me.Label3)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CountryList)
        Me._IMSS_MainPanel.Controls.Add(Me.Label2)
        Me._IMSS_MainPanel.Controls.Add(Me.Button1)
        Me._IMSS_MainPanel.Controls.Add(Me.Label1)
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, -1)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(319, 144)
        Me._IMSS_MainPanel.TabIndex = 9
        '
        'IMSS_SlideInTimer
        '
        Me.IMSS_SlideInTimer.Interval = 10
        '
        '_IMSS_PanelWorking
        '
        Me._IMSS_PanelWorking.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_PanelWorking.Controls.Add(Me._IMSS_Loading_PictureBox)
        Me._IMSS_PanelWorking.Location = New System.Drawing.Point(2, 149)
        Me._IMSS_PanelWorking.Name = "_IMSS_PanelWorking"
        Me._IMSS_PanelWorking.Size = New System.Drawing.Size(317, 113)
        Me._IMSS_PanelWorking.TabIndex = 10
        '
        '_IMSS_Loading_PictureBox
        '
        Me._IMSS_Loading_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_Loading_PictureBox.Enabled = False
        Me._IMSS_Loading_PictureBox.Image = CType(resources.GetObject("_IMSS_Loading_PictureBox.Image"), System.Drawing.Image)
        Me._IMSS_Loading_PictureBox.Location = New System.Drawing.Point(103, 1)
        Me._IMSS_Loading_PictureBox.Name = "_IMSS_Loading_PictureBox"
        Me._IMSS_Loading_PictureBox.Size = New System.Drawing.Size(110, 110)
        Me._IMSS_Loading_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._IMSS_Loading_PictureBox.TabIndex = 0
        Me._IMSS_Loading_PictureBox.TabStop = False
        '
        '_IMSS_Register_BackgroundWorker
        '
        Me._IMSS_Register_BackgroundWorker.WorkerReportsProgress = True
        Me._IMSS_Register_BackgroundWorker.WorkerSupportsCancellation = True
        '
        'IMSS_RegConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 143)
        Me.Controls.Add(Me._IMSS_PanelWorking)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(333, 181)
        Me.MinimumSize = New System.Drawing.Size(333, 140)
        Me.Name = "IMSS_RegConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iMyth Security Systems - Activation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me._IMSS_PanelWorking.ResumeLayout(False)
        Me._IMSS_PanelWorking.PerformLayout()
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _TextUserName As System.Windows.Forms.TextBox
    Friend WithEvents _Text_Email As System.Windows.Forms.TextBox
    Friend WithEvents _IMSS_CountryList As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_ImageList As System.Windows.Forms.ImageList
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents _IMSS_MainPanel As System.Windows.Forms.Panel
    Friend WithEvents IMSS_SlideInTimer As System.Windows.Forms.Timer
    Friend WithEvents _IMSS_PanelWorking As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_Loading_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents _IMSS_Register_BackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
