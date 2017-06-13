<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_StartupCleanerUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_StartupCleanerUserControl))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_RATING_CONTROL = New DevComponents.DotNetBar.Controls.RatingStar()
        Me._IMSS_STLE_PANEL = New System.Windows.Forms.Panel()
        Me._IMSS_LOGO = New System.Windows.Forms.PictureBox()
        Me._IMSS_SelectedValue = New System.Windows.Forms.CheckBox()
        Me._IMSS_OptionLinkLabel = New System.Windows.Forms.LinkLabel()
        Me._IMSS_MainPanel.SuspendLayout()
        CType(Me._IMSS_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me.Label2)
        Me._IMSS_MainPanel.Controls.Add(Me.Label1)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_RATING_CONTROL)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_STLE_PANEL)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_LOGO)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_SelectedValue)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_OptionLinkLabel)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(748, 58)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me._IMSS_MainPanel.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me._IMSS_MainPanel.Style.BackgroundImage = CType(resources.GetObject("_IMSS_MainPanel.Style.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(45, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Windows startup cleaner, "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(632, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "It's designed to quickly remove as many unnecessary files as possible from a hard" & _
    " drive. It uses a combination of system environment variables and known director" & _
    "y structures."
        '
        '_IMSS_RATING_CONTROL
        '
        Me._IMSS_RATING_CONTROL.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me._IMSS_RATING_CONTROL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_RATING_CONTROL.CustomImages.Rated = CType(resources.GetObject("_IMSS_RATING_CONTROL.CustomImages.Rated"), System.Drawing.Image)
        Me._IMSS_RATING_CONTROL.IsEditable = False
        Me._IMSS_RATING_CONTROL.Location = New System.Drawing.Point(665, 3)
        Me._IMSS_RATING_CONTROL.Name = "_IMSS_RATING_CONTROL"
        Me._IMSS_RATING_CONTROL.Rating = 5
        Me._IMSS_RATING_CONTROL.Size = New System.Drawing.Size(80, 15)
        Me._IMSS_RATING_CONTROL.TabIndex = 13
        Me._IMSS_RATING_CONTROL.TextColor = System.Drawing.Color.Empty
        '
        '_IMSS_STLE_PANEL
        '
        Me._IMSS_STLE_PANEL.BackColor = System.Drawing.Color.RoyalBlue
        Me._IMSS_STLE_PANEL.Dock = System.Windows.Forms.DockStyle.Left
        Me._IMSS_STLE_PANEL.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_STLE_PANEL.Name = "_IMSS_STLE_PANEL"
        Me._IMSS_STLE_PANEL.Size = New System.Drawing.Size(10, 58)
        Me._IMSS_STLE_PANEL.TabIndex = 7
        '
        '_IMSS_LOGO
        '
        Me._IMSS_LOGO.Image = CType(resources.GetObject("_IMSS_LOGO.Image"), System.Drawing.Image)
        Me._IMSS_LOGO.Location = New System.Drawing.Point(16, 2)
        Me._IMSS_LOGO.Name = "_IMSS_LOGO"
        Me._IMSS_LOGO.Size = New System.Drawing.Size(24, 24)
        Me._IMSS_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_LOGO.TabIndex = 1
        Me._IMSS_LOGO.TabStop = False
        '
        '_IMSS_SelectedValue
        '
        Me._IMSS_SelectedValue.AutoSize = True
        Me._IMSS_SelectedValue.Checked = True
        Me._IMSS_SelectedValue.CheckState = System.Windows.Forms.CheckState.Checked
        Me._IMSS_SelectedValue.Dock = System.Windows.Forms.DockStyle.Right
        Me._IMSS_SelectedValue.Location = New System.Drawing.Point(733, 0)
        Me._IMSS_SelectedValue.Name = "_IMSS_SelectedValue"
        Me._IMSS_SelectedValue.Size = New System.Drawing.Size(15, 58)
        Me._IMSS_SelectedValue.TabIndex = 6
        Me._IMSS_SelectedValue.UseVisualStyleBackColor = True
        '
        '_IMSS_OptionLinkLabel
        '
        Me._IMSS_OptionLinkLabel.AutoSize = True
        Me._IMSS_OptionLinkLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_OptionLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me._IMSS_OptionLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me._IMSS_OptionLinkLabel.Location = New System.Drawing.Point(215, 6)
        Me._IMSS_OptionLinkLabel.Name = "_IMSS_OptionLinkLabel"
        Me._IMSS_OptionLinkLabel.Size = New System.Drawing.Size(61, 16)
        Me._IMSS_OptionLinkLabel.TabIndex = 5
        Me._IMSS_OptionLinkLabel.TabStop = True
        Me._IMSS_OptionLinkLabel.Text = "(Options)"
        '
        'IMSS_StartupCleanerUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Name = "IMSS_StartupCleanerUserControl"
        Me.Size = New System.Drawing.Size(748, 58)
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        CType(Me._IMSS_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_RATING_CONTROL As DevComponents.DotNetBar.Controls.RatingStar
    Friend WithEvents _IMSS_STLE_PANEL As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_SelectedValue As System.Windows.Forms.CheckBox
    Friend WithEvents _IMSS_OptionLinkLabel As System.Windows.Forms.LinkLabel

End Class
