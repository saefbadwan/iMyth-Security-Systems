<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_LOGCotrolsUint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_LOGCotrolsUint))
        Me.LOG_Panel = New System.Windows.Forms.Panel()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.ScanIcon = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me._SecurityLog = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me._SystemLog = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me._USBLog = New System.Windows.Forms.TextBox()
        Me._SySUSBIconsFileList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.LOG_Panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.SuspendLayout()
        '
        'LOG_Panel
        '
        Me.LOG_Panel.BackColor = System.Drawing.Color.White
        Me.LOG_Panel.Controls.Add(Me.Button18)
        Me.LOG_Panel.Controls.Add(Me.TabControl1)
        Me.LOG_Panel.Controls.Add(Me.Panel20)
        Me.LOG_Panel.Controls.Add(Me.Panel21)
        Me.LOG_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LOG_Panel.Location = New System.Drawing.Point(0, 0)
        Me.LOG_Panel.Name = "LOG_Panel"
        Me.LOG_Panel.Size = New System.Drawing.Size(640, 376)
        Me.LOG_Panel.TabIndex = 35
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.Black
        Me.Button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.ImageKey = "delete.png"
        Me.Button18.ImageList = Me.ScanIcon
        Me.Button18.Location = New System.Drawing.Point(3, 340)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(634, 33)
        Me.Button18.TabIndex = 53
        Me.Button18.Tag = ""
        Me.Button18.Text = "Clear Log"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'ScanIcon
        '
        Me.ScanIcon.ImageStream = CType(resources.GetObject("ScanIcon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ScanIcon.TransparentColor = System.Drawing.Color.Transparent
        Me.ScanIcon.Images.SetKeyName(0, "delete.png")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ImageList = Me._SySUSBIconsFileList
        Me.TabControl1.Location = New System.Drawing.Point(3, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 306)
        Me.TabControl1.TabIndex = 52
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me._SecurityLog)
        Me.TabPage6.ImageKey = "Blue_Shield_icon.png"
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(627, 279)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Security Log"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        '_SecurityLog
        '
        Me._SecurityLog.BackColor = System.Drawing.Color.White
        Me._SecurityLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SecurityLog.Location = New System.Drawing.Point(1, 5)
        Me._SecurityLog.MaxLength = 100000
        Me._SecurityLog.Multiline = True
        Me._SecurityLog.Name = "_SecurityLog"
        Me._SecurityLog.ReadOnly = True
        Me._SecurityLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._SecurityLog.Size = New System.Drawing.Size(623, 271)
        Me._SecurityLog.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me._SystemLog)
        Me.TabPage1.ImageKey = "System Preferences.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(627, 279)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "System Log"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        '_SystemLog
        '
        Me._SystemLog.BackColor = System.Drawing.Color.White
        Me._SystemLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SystemLog.Location = New System.Drawing.Point(1, 5)
        Me._SystemLog.MaxLength = 100000
        Me._SystemLog.Multiline = True
        Me._SystemLog.Name = "_SystemLog"
        Me._SystemLog.ReadOnly = True
        Me._SystemLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._SystemLog.Size = New System.Drawing.Size(623, 271)
        Me._SystemLog.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me._USBLog)
        Me.TabPage2.ImageKey = "USB-Logo-Icon.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(627, 279)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "USB Log"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        '_USBLog
        '
        Me._USBLog.BackColor = System.Drawing.Color.White
        Me._USBLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._USBLog.Location = New System.Drawing.Point(1, 5)
        Me._USBLog.MaxLength = 100000
        Me._USBLog.Multiline = True
        Me._USBLog.Name = "_USBLog"
        Me._USBLog.ReadOnly = True
        Me._USBLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._USBLog.Size = New System.Drawing.Size(623, 271)
        Me._USBLog.TabIndex = 1
        '
        '_SySUSBIconsFileList
        '
        Me._SySUSBIconsFileList.ImageStream = CType(resources.GetObject("_SySUSBIconsFileList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._SySUSBIconsFileList.TransparentColor = System.Drawing.Color.Transparent
        Me._SySUSBIconsFileList.Images.SetKeyName(0, "System Preferences.png")
        Me._SySUSBIconsFileList.Images.SetKeyName(1, "USB-Logo-Icon.png")
        Me._SySUSBIconsFileList.Images.SetKeyName(2, "Blue_Shield_icon.png")
        Me._SySUSBIconsFileList.Images.SetKeyName(3, "")
        Me._SySUSBIconsFileList.Images.SetKeyName(4, "_IMSS_UpdateIcon.png")
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel20.Controls.Add(Me.Label53)
        Me.Panel20.Location = New System.Drawing.Point(5, 3)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(103, 26)
        Me.Panel20.TabIndex = 51
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(13, 6)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(76, 14)
        Me.Label53.TabIndex = 48
        Me.Label53.Text = "Security Log"
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel21.Location = New System.Drawing.Point(7, 19)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(631, 10)
        Me.Panel21.TabIndex = 50
        '
        'IMSS_LOGCotrolsUint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.LOG_Panel)
        Me.Name = "IMSS_LOGCotrolsUint"
        Me.Size = New System.Drawing.Size(640, 376)
        Me.LOG_Panel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LOG_Panel As System.Windows.Forms.Panel
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents _SecurityLog As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents _SystemLog As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents _USBLog As System.Windows.Forms.TextBox
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents _SySUSBIconsFileList As System.Windows.Forms.ImageList
    Friend WithEvents ScanIcon As System.Windows.Forms.ImageList

End Class
