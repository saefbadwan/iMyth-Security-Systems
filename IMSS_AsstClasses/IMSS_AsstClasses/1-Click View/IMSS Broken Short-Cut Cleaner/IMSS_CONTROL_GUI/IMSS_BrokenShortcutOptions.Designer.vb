<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_BrokenShortcutOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_BrokenShortcutOptions))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_SELECTED_PATHES = New System.Windows.Forms.ListView()
        Me._IMSS_SearchPaths = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._IMSS_DescriptionLabel = New System.Windows.Forms.Label()
        Me._IMSS_ClickControls = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_OK = New System.Windows.Forms.Button()
        Me._IMSS_CANCEL = New System.Windows.Forms.Button()
        Me._IMSS_Remove = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Add = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_AddFolders = New System.Windows.Forms.FolderBrowserDialog()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_ClickControls.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_SELECTED_PATHES)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_DescriptionLabel)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ClickControls)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(306, 205)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 3
        '
        '_IMSS_SELECTED_PATHES
        '
        Me._IMSS_SELECTED_PATHES.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._IMSS_SearchPaths})
        Me._IMSS_SELECTED_PATHES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SELECTED_PATHES.Location = New System.Drawing.Point(12, 26)
        Me._IMSS_SELECTED_PATHES.MultiSelect = False
        Me._IMSS_SELECTED_PATHES.Name = "_IMSS_SELECTED_PATHES"
        Me._IMSS_SELECTED_PATHES.Size = New System.Drawing.Size(282, 137)
        Me._IMSS_SELECTED_PATHES.TabIndex = 4
        Me._IMSS_SELECTED_PATHES.UseCompatibleStateImageBehavior = False
        Me._IMSS_SELECTED_PATHES.View = System.Windows.Forms.View.Details
        '
        '_IMSS_SearchPaths
        '
        Me._IMSS_SearchPaths.Text = "Search Paths"
        Me._IMSS_SearchPaths.Width = 258
        '
        '_IMSS_DescriptionLabel
        '
        Me._IMSS_DescriptionLabel.AutoSize = True
        Me._IMSS_DescriptionLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_DescriptionLabel.Location = New System.Drawing.Point(4, 7)
        Me._IMSS_DescriptionLabel.Name = "_IMSS_DescriptionLabel"
        Me._IMSS_DescriptionLabel.Size = New System.Drawing.Size(251, 14)
        Me._IMSS_DescriptionLabel.TabIndex = 3
        Me._IMSS_DescriptionLabel.Text = "Please add or remove path/s you want to search it"
        '
        '_IMSS_ClickControls
        '
        Me._IMSS_ClickControls.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_ClickControls.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ClickControls.Controls.Add(Me._IMSS_Remove)
        Me._IMSS_ClickControls.Controls.Add(Me._IMSS_Add)
        Me._IMSS_ClickControls.Controls.Add(Me._IMSS_OK)
        Me._IMSS_ClickControls.Controls.Add(Me._IMSS_CANCEL)
        Me._IMSS_ClickControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_ClickControls.Location = New System.Drawing.Point(0, 169)
        Me._IMSS_ClickControls.Name = "_IMSS_ClickControls"
        Me._IMSS_ClickControls.Size = New System.Drawing.Size(306, 36)
        Me._IMSS_ClickControls.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_ClickControls.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_ClickControls.Style.BackColor2.Color = System.Drawing.Color.LightGray
        Me._IMSS_ClickControls.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_ClickControls.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_ClickControls.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_ClickControls.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_ClickControls.Style.GradientAngle = 90
        Me._IMSS_ClickControls.TabIndex = 2
        '
        '_IMSS_OK
        '
        Me._IMSS_OK.Location = New System.Drawing.Point(265, 8)
        Me._IMSS_OK.Name = "_IMSS_OK"
        Me._IMSS_OK.Size = New System.Drawing.Size(38, 23)
        Me._IMSS_OK.TabIndex = 1
        Me._IMSS_OK.Text = "&OK"
        Me._IMSS_OK.UseVisualStyleBackColor = True
        '
        '_IMSS_CANCEL
        '
        Me._IMSS_CANCEL.Location = New System.Drawing.Point(202, 8)
        Me._IMSS_CANCEL.Name = "_IMSS_CANCEL"
        Me._IMSS_CANCEL.Size = New System.Drawing.Size(57, 23)
        Me._IMSS_CANCEL.TabIndex = 0
        Me._IMSS_CANCEL.Text = "&Cancel"
        Me._IMSS_CANCEL.UseVisualStyleBackColor = True
        '
        '_IMSS_Remove
        '
        Me._IMSS_Remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Remove.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_Minus_Icon_16x16
        Me._IMSS_Remove.Location = New System.Drawing.Point(47, 8)
        Me._IMSS_Remove.Name = "_IMSS_Remove"
        Me._IMSS_Remove.Size = New System.Drawing.Size(36, 23)
        Me._IMSS_Remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Remove.TabIndex = 0
        '
        '_IMSS_Add
        '
        Me._IMSS_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Add.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_RegeditAdd_MainIcon_16x16
        Me._IMSS_Add.Location = New System.Drawing.Point(5, 8)
        Me._IMSS_Add.Name = "_IMSS_Add"
        Me._IMSS_Add.Size = New System.Drawing.Size(36, 23)
        Me._IMSS_Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Add.TabIndex = 2
        '
        '_IMSS_AddFolders
        '
        Me._IMSS_AddFolders.Description = "Please select a folder to scan it for broken short cuts"
        '
        'IMSS_BrokenShortcutOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 205)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(322, 243)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(322, 243)
        Me.Name = "IMSS_BrokenShortcutOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me._IMSS_ClickControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_SELECTED_PATHES As System.Windows.Forms.ListView
    Friend WithEvents _IMSS_SearchPaths As System.Windows.Forms.ColumnHeader
    Friend WithEvents _IMSS_DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents _IMSS_ClickControls As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_OK As System.Windows.Forms.Button
    Friend WithEvents _IMSS_CANCEL As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Remove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_Add As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_AddFolders As System.Windows.Forms.FolderBrowserDialog
End Class
