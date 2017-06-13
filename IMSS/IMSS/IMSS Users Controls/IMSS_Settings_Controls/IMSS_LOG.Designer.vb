<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_LOG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_LOG))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me._SecuritySettingsLogData = New System.Windows.Forms.TextBox()
        Me._IMSS_Setting = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.ImageList = Me._IMSS_Setting
        Me.TabControl1.Location = New System.Drawing.Point(1, 35)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 341)
        Me.TabControl1.TabIndex = 55
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me._SecuritySettingsLogData)
        Me.TabPage6.ImageKey = "_IMSS_Settings_SettingsLog_Tap_Icon.png"
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(627, 314)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Setting Log"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        '_SecuritySettingsLogData
        '
        Me._SecuritySettingsLogData.BackColor = System.Drawing.Color.White
        Me._SecuritySettingsLogData.Dock = System.Windows.Forms.DockStyle.Fill
        Me._SecuritySettingsLogData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SecuritySettingsLogData.Location = New System.Drawing.Point(0, 0)
        Me._SecuritySettingsLogData.MaxLength = 100000
        Me._SecuritySettingsLogData.Multiline = True
        Me._SecuritySettingsLogData.Name = "_SecuritySettingsLogData"
        Me._SecuritySettingsLogData.ReadOnly = True
        Me._SecuritySettingsLogData.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._SecuritySettingsLogData.Size = New System.Drawing.Size(627, 314)
        Me._SecuritySettingsLogData.TabIndex = 1
        '
        '_IMSS_Setting
        '
        Me._IMSS_Setting.ImageStream = CType(resources.GetObject("_IMSS_Setting.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_Setting.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_Setting.Images.SetKeyName(0, "_IMSS_Settings_SettingsLog_Tap_Icon.png")
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel22.Controls.Add(Me.Label54)
        Me.Panel22.Location = New System.Drawing.Point(0, 6)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(104, 26)
        Me.Panel22.TabIndex = 57
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(38, 6)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(29, 14)
        Me.Label54.TabIndex = 48
        Me.Label54.Text = "Log"
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel23.Location = New System.Drawing.Point(0, 22)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(619, 10)
        Me.Panel23.TabIndex = 56
        '
        'IMSS_LOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel22)
        Me.Controls.Add(Me.Panel23)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "IMSS_LOG"
        Me.Size = New System.Drawing.Size(640, 376)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents _SecuritySettingsLogData As System.Windows.Forms.TextBox
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_Setting As System.Windows.Forms.ImageList

End Class
