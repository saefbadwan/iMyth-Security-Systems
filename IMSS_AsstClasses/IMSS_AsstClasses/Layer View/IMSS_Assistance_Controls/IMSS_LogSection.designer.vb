<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_LogSection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_LogSection))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_log = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me._IMSS_ToolsLog_TextBox = New System.Windows.Forms.TextBox()
        Me._IMSS_ClearLog = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_log.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 58)
        Me.Panel1.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(275, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Utilities Log"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(221, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_log
        '
        Me._IMSS_log.Controls.Add(Me.TabPage6)
        Me._IMSS_log.Location = New System.Drawing.Point(3, 57)
        Me._IMSS_log.Name = "_IMSS_log"
        Me._IMSS_log.SelectedIndex = 0
        Me._IMSS_log.Size = New System.Drawing.Size(635, 287)
        Me._IMSS_log.TabIndex = 101
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me._IMSS_ToolsLog_TextBox)
        Me.TabPage6.ImageKey = "_IMSS_Settings_SettingsLog_Tap_Icon.png"
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(627, 261)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Log"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        '_IMSS_ToolsLog_TextBox
        '
        Me._IMSS_ToolsLog_TextBox.BackColor = System.Drawing.Color.White
        Me._IMSS_ToolsLog_TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_ToolsLog_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ToolsLog_TextBox.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_ToolsLog_TextBox.MaxLength = 100000
        Me._IMSS_ToolsLog_TextBox.Multiline = True
        Me._IMSS_ToolsLog_TextBox.Name = "_IMSS_ToolsLog_TextBox"
        Me._IMSS_ToolsLog_TextBox.ReadOnly = True
        Me._IMSS_ToolsLog_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._IMSS_ToolsLog_TextBox.Size = New System.Drawing.Size(627, 261)
        Me._IMSS_ToolsLog_TextBox.TabIndex = 1
        '
        '_IMSS_ClearLog
        '
        Me._IMSS_ClearLog.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_ClearLog.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me._IMSS_ClearLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_ClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_ClearLog.Location = New System.Drawing.Point(559, 350)
        Me._IMSS_ClearLog.Name = "_IMSS_ClearLog"
        Me._IMSS_ClearLog.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_ClearLog.TabIndex = 102
        Me._IMSS_ClearLog.Text = "Clear log"
        Me._IMSS_ClearLog.UseVisualStyleBackColor = False
        '
        'IMSS_LogSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me._IMSS_ClearLog)
        Me.Controls.Add(Me._IMSS_log)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "IMSS_LogSection"
        Me.Size = New System.Drawing.Size(640, 379)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_log.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_log As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_ToolsLog_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _IMSS_ClearLog As System.Windows.Forms.Button

End Class
