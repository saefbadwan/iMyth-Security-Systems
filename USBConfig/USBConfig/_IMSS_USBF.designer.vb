<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _IMSS_USBF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_IMSS_USBF))
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonFormat = New System.Windows.Forms.Button()
        Me._Button_Icon = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.comboBoxDrives = New System.Windows.Forms.ComboBox()
        Me.textBoxVolumeLabel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelInfo = New System.Windows.Forms.Label()
        Me.labelProgress = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.checkBoxQuickformat = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox8.Location = New System.Drawing.Point(10, 8)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox8.TabIndex = 69
        Me.PictureBox8.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "USB Format"
        '
        'buttonFormat
        '
        Me.buttonFormat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonFormat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonFormat.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.buttonFormat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonFormat.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonFormat.ForeColor = System.Drawing.Color.Black
        Me.buttonFormat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonFormat.ImageKey = "Visualpharm-Must-Have-Refresh.ico"
        Me.buttonFormat.ImageList = Me._Button_Icon
        Me.buttonFormat.Location = New System.Drawing.Point(194, 240)
        Me.buttonFormat.Name = "buttonFormat"
        Me.buttonFormat.Size = New System.Drawing.Size(98, 28)
        Me.buttonFormat.TabIndex = 61
        Me.buttonFormat.Tag = ""
        Me.buttonFormat.Text = "Format"
        Me.buttonFormat.UseVisualStyleBackColor = False
        '
        '_Button_Icon
        '
        Me._Button_Icon.ImageStream = CType(resources.GetObject("_Button_Icon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._Button_Icon.TransparentColor = System.Drawing.Color.Transparent
        Me._Button_Icon.Images.SetKeyName(0, "delete.png")
        Me._Button_Icon.Images.SetKeyName(1, "Visualpharm-Must-Have-Refresh.ico")
        Me._Button_Icon.Images.SetKeyName(2, "arrow-12-512.gif")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageKey = "arrow-12-512.gif"
        Me.Button1.ImageList = Me._Button_Icon
        Me.Button1.Location = New System.Drawing.Point(333, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 59
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.groupBox2)
        Me.Panel4.Controls.Add(Me.groupBox1)
        Me.Panel4.Location = New System.Drawing.Point(10, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(380, 201)
        Me.Panel4.TabIndex = 66
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.comboBoxDrives)
        Me.groupBox2.Controls.Add(Me.textBoxVolumeLabel)
        Me.groupBox2.Controls.Add(Me.Label1)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.ForeColor = System.Drawing.Color.Gray
        Me.groupBox2.Location = New System.Drawing.Point(12, 4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(365, 81)
        Me.groupBox2.TabIndex = 10
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Info"
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(233, 16)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(93, 23)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Drive to format."
        '
        'comboBoxDrives
        '
        Me.comboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxDrives.FormattingEnabled = True
        Me.comboBoxDrives.Location = New System.Drawing.Point(236, 45)
        Me.comboBoxDrives.Name = "comboBoxDrives"
        Me.comboBoxDrives.Size = New System.Drawing.Size(87, 21)
        Me.comboBoxDrives.TabIndex = 1
        '
        'textBoxVolumeLabel
        '
        Me.textBoxVolumeLabel.Location = New System.Drawing.Point(12, 45)
        Me.textBoxVolumeLabel.MaxLength = 20
        Me.textBoxVolumeLabel.Name = "textBoxVolumeLabel"
        Me.textBoxVolumeLabel.Size = New System.Drawing.Size(205, 20)
        Me.textBoxVolumeLabel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the name for the drive."
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.labelInfo)
        Me.groupBox1.Controls.Add(Me.labelProgress)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Gray
        Me.groupBox1.Location = New System.Drawing.Point(12, 91)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(365, 103)
        Me.groupBox1.TabIndex = 11
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Formating"
        '
        'labelInfo
        '
        Me.labelInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInfo.ForeColor = System.Drawing.Color.Black
        Me.labelInfo.Location = New System.Drawing.Point(32, 22)
        Me.labelInfo.Name = "labelInfo"
        Me.labelInfo.Size = New System.Drawing.Size(257, 16)
        Me.labelInfo.TabIndex = 5
        '
        'labelProgress
        '
        Me.labelProgress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelProgress.ForeColor = System.Drawing.Color.White
        Me.labelProgress.Location = New System.Drawing.Point(96, 59)
        Me.labelProgress.Name = "labelProgress"
        Me.labelProgress.Size = New System.Drawing.Size(220, 27)
        Me.labelProgress.TabIndex = 4
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel12.Location = New System.Drawing.Point(-12, -6)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(335, 10)
        Me.Panel12.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Location = New System.Drawing.Point(-6, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 233)
        Me.Panel1.TabIndex = 63
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Location = New System.Drawing.Point(0, 273)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 10)
        Me.Panel3.TabIndex = 65
        '
        'buttonClose
        '
        Me.buttonClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonClose.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClose.ForeColor = System.Drawing.Color.Black
        Me.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonClose.ImageKey = "delete.png"
        Me.buttonClose.ImageList = Me._Button_Icon
        Me.buttonClose.Location = New System.Drawing.Point(298, 240)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(92, 28)
        Me.buttonClose.TabIndex = 60
        Me.buttonClose.Tag = ""
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'checkBoxQuickformat
        '
        Me.checkBoxQuickformat.AutoSize = True
        Me.checkBoxQuickformat.Location = New System.Drawing.Point(12, 247)
        Me.checkBoxQuickformat.Name = "checkBoxQuickformat"
        Me.checkBoxQuickformat.Size = New System.Drawing.Size(94, 17)
        Me.checkBoxQuickformat.TabIndex = 70
        Me.checkBoxQuickformat.Text = "Quick Format?"
        Me.checkBoxQuickformat.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Location = New System.Drawing.Point(396, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 203)
        Me.Panel2.TabIndex = 64
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        '_IMSS_USBF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(400, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.checkBoxQuickformat)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonFormat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.buttonClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(416, 293)
        Me.MinimizeBox = False
        Me.Name = "_IMSS_USBF"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents buttonFormat As System.Windows.Forms.Button
    Friend WithEvents _Button_Icon As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents comboBoxDrives As System.Windows.Forms.ComboBox
    Private WithEvents textBoxVolumeLabel As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents labelInfo As System.Windows.Forms.Label
    Private WithEvents labelProgress As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents checkBoxQuickformat As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
