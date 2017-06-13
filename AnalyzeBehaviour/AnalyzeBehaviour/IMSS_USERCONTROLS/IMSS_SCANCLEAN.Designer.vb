<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SCANCLEAN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_SCANCLEAN))
        Me._IMSS_LOGO = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_CONTROL_HOLDER_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_EXIT_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_IS_COMPLETED_Label = New System.Windows.Forms.Label()
        CType(Me._IMSS_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_CONTROL_HOLDER_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_LOGO
        '
        Me._IMSS_LOGO.Image = CType(resources.GetObject("_IMSS_LOGO.Image"), System.Drawing.Image)
        Me._IMSS_LOGO.Location = New System.Drawing.Point(31, 19)
        Me._IMSS_LOGO.Name = "_IMSS_LOGO"
        Me._IMSS_LOGO.Size = New System.Drawing.Size(98, 95)
        Me._IMSS_LOGO.TabIndex = 0
        Me._IMSS_LOGO.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scan completed there is no suspect behaviour found in the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selected files."
        '
        '_IMSS_CONTROL_HOLDER_Panel
        '
        Me._IMSS_CONTROL_HOLDER_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_CONTROL_HOLDER_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CONTROL_HOLDER_Panel.Controls.Add(Me._IMSS_EXIT_BUTTON)
        Me._IMSS_CONTROL_HOLDER_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_CONTROL_HOLDER_Panel.Location = New System.Drawing.Point(0, 126)
        Me._IMSS_CONTROL_HOLDER_Panel.Name = "_IMSS_CONTROL_HOLDER_Panel"
        Me._IMSS_CONTROL_HOLDER_Panel.Size = New System.Drawing.Size(542, 39)
        Me._IMSS_CONTROL_HOLDER_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_CONTROL_HOLDER_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_CONTROL_HOLDER_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_CONTROL_HOLDER_Panel.Style.GradientAngle = 90
        Me._IMSS_CONTROL_HOLDER_Panel.TabIndex = 5
        '
        '_IMSS_EXIT_BUTTON
        '
        Me._IMSS_EXIT_BUTTON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_EXIT_BUTTON.Location = New System.Drawing.Point(460, 9)
        Me._IMSS_EXIT_BUTTON.Name = "_IMSS_EXIT_BUTTON"
        Me._IMSS_EXIT_BUTTON.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_EXIT_BUTTON.TabIndex = 0
        Me._IMSS_EXIT_BUTTON.Text = "Close"
        Me._IMSS_EXIT_BUTTON.UseVisualStyleBackColor = True
        '
        '_IMSS_IS_COMPLETED_Label
        '
        Me._IMSS_IS_COMPLETED_Label.AutoSize = True
        Me._IMSS_IS_COMPLETED_Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_IS_COMPLETED_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_IS_COMPLETED_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_IS_COMPLETED_Label.Location = New System.Drawing.Point(141, 26)
        Me._IMSS_IS_COMPLETED_Label.Name = "_IMSS_IS_COMPLETED_Label"
        Me._IMSS_IS_COMPLETED_Label.Size = New System.Drawing.Size(224, 18)
        Me._IMSS_IS_COMPLETED_Label.TabIndex = 6
        Me._IMSS_IS_COMPLETED_Label.Text = "Behavior Analysis is completed"
        '
        'IMSS_SCANCLEAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_IS_COMPLETED_Label)
        Me.Controls.Add(Me._IMSS_CONTROL_HOLDER_Panel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._IMSS_LOGO)
        Me.Name = "IMSS_SCANCLEAN"
        Me.Size = New System.Drawing.Size(542, 165)
        CType(Me._IMSS_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_CONTROL_HOLDER_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_CONTROL_HOLDER_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_EXIT_BUTTON As System.Windows.Forms.Button
    Friend WithEvents _IMSS_IS_COMPLETED_Label As System.Windows.Forms.Label

End Class
