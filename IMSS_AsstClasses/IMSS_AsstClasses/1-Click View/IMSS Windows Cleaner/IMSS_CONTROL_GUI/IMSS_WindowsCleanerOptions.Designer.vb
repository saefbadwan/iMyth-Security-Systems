﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_WindowsCleanerOptions
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Windows Explorer Temp")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("System Temp")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Advanced System temp")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Media Temp")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_WindowsCleanerOptions))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_SELECTED_TARGETS = New System.Windows.Forms.ListView()
        Me._IMSS_TargetName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._IMSS_DescriptionLabel = New System.Windows.Forms.Label()
        Me._IMSS_ClickControls = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_OK = New System.Windows.Forms.Button()
        Me._IMSS_CANCEL = New System.Windows.Forms.Button()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_ClickControls.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_SELECTED_TARGETS)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_DescriptionLabel)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ClickControls)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(248, 188)
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
        '_IMSS_SELECTED_TARGETS
        '
        Me._IMSS_SELECTED_TARGETS.CheckBoxes = True
        Me._IMSS_SELECTED_TARGETS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._IMSS_TargetName})
        Me._IMSS_SELECTED_TARGETS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        Me._IMSS_SELECTED_TARGETS.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me._IMSS_SELECTED_TARGETS.Location = New System.Drawing.Point(12, 26)
        Me._IMSS_SELECTED_TARGETS.Name = "_IMSS_SELECTED_TARGETS"
        Me._IMSS_SELECTED_TARGETS.Size = New System.Drawing.Size(224, 120)
        Me._IMSS_SELECTED_TARGETS.TabIndex = 4
        Me._IMSS_SELECTED_TARGETS.UseCompatibleStateImageBehavior = False
        Me._IMSS_SELECTED_TARGETS.View = System.Windows.Forms.View.Details
        '
        '_IMSS_TargetName
        '
        Me._IMSS_TargetName.Text = "Temporary Target"
        Me._IMSS_TargetName.Width = 220
        '
        '_IMSS_DescriptionLabel
        '
        Me._IMSS_DescriptionLabel.AutoSize = True
        Me._IMSS_DescriptionLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_DescriptionLabel.Location = New System.Drawing.Point(3, 9)
        Me._IMSS_DescriptionLabel.Name = "_IMSS_DescriptionLabel"
        Me._IMSS_DescriptionLabel.Size = New System.Drawing.Size(210, 14)
        Me._IMSS_DescriptionLabel.TabIndex = 3
        Me._IMSS_DescriptionLabel.Text = "Please select temp files you want to clean"
        '
        '_IMSS_ClickControls
        '
        Me._IMSS_ClickControls.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_ClickControls.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ClickControls.Controls.Add(Me._IMSS_OK)
        Me._IMSS_ClickControls.Controls.Add(Me._IMSS_CANCEL)
        Me._IMSS_ClickControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_ClickControls.Location = New System.Drawing.Point(0, 152)
        Me._IMSS_ClickControls.Name = "_IMSS_ClickControls"
        Me._IMSS_ClickControls.Size = New System.Drawing.Size(248, 36)
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
        Me._IMSS_OK.Location = New System.Drawing.Point(201, 8)
        Me._IMSS_OK.Name = "_IMSS_OK"
        Me._IMSS_OK.Size = New System.Drawing.Size(38, 23)
        Me._IMSS_OK.TabIndex = 1
        Me._IMSS_OK.Text = "&OK"
        Me._IMSS_OK.UseVisualStyleBackColor = True
        '
        '_IMSS_CANCEL
        '
        Me._IMSS_CANCEL.Location = New System.Drawing.Point(138, 8)
        Me._IMSS_CANCEL.Name = "_IMSS_CANCEL"
        Me._IMSS_CANCEL.Size = New System.Drawing.Size(57, 23)
        Me._IMSS_CANCEL.TabIndex = 0
        Me._IMSS_CANCEL.Text = "&Cancel"
        Me._IMSS_CANCEL.UseVisualStyleBackColor = True
        '
        'IMSS_WindowsCleanerOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 188)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IMSS_WindowsCleanerOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me._IMSS_ClickControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_SELECTED_TARGETS As System.Windows.Forms.ListView
    Friend WithEvents _IMSS_TargetName As System.Windows.Forms.ColumnHeader
    Friend WithEvents _IMSS_DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents _IMSS_ClickControls As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_OK As System.Windows.Forms.Button
    Friend WithEvents _IMSS_CANCEL As System.Windows.Forms.Button
End Class
