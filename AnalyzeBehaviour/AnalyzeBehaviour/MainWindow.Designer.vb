<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_ANALYZE_TREEVIEW = New System.Windows.Forms.TreeView()
        Me._IMSS_IMAGELIST = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_ANALYZE_WORKER = New System.ComponentModel.BackgroundWorker()
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_ON_COMPLETE_PANEL = New System.Windows.Forms.Panel()
        Me._IMSS_STATUS_DESCRIPTION_LABEL = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_IS_COMPLETED_Label = New System.Windows.Forms.Label()
        Me._IMSS_StepIndicator = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me._IMSS_CONTROL_HOLDER_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_CLEANUP_PROGRESSBAR = New System.Windows.Forms.ProgressBar()
        Me._IMSS_CLEANUPALLTHREATS_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_CANCEL_BUTTON = New System.Windows.Forms.Button()
        Me._IMSS_CURRENT_SANNING_Label = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_ON_COMPLETE_PANEL.SuspendLayout()
        Me._IMSS_CONTROL_HOLDER_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_ANALYZE_TREEVIEW
        '
        Me._IMSS_ANALYZE_TREEVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_ANALYZE_TREEVIEW.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ANALYZE_TREEVIEW.ImageIndex = 0
        Me._IMSS_ANALYZE_TREEVIEW.ImageList = Me._IMSS_IMAGELIST
        Me._IMSS_ANALYZE_TREEVIEW.Location = New System.Drawing.Point(12, 124)
        Me._IMSS_ANALYZE_TREEVIEW.Name = "_IMSS_ANALYZE_TREEVIEW"
        Me._IMSS_ANALYZE_TREEVIEW.SelectedImageIndex = 0
        Me._IMSS_ANALYZE_TREEVIEW.Size = New System.Drawing.Size(503, 273)
        Me._IMSS_ANALYZE_TREEVIEW.TabIndex = 1
        '
        '_IMSS_IMAGELIST
        '
        Me._IMSS_IMAGELIST.ImageStream = CType(resources.GetObject("_IMSS_IMAGELIST.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_IMAGELIST.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_IMAGELIST.Images.SetKeyName(0, "_IMSS_WARNING_ICON_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(1, "_IMSS_REGISTRY_ICON_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(2, "_IMSS_FOLDER_Icon_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(3, "_IMSS_RightArrow_Icon_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(4, "_IMSS_PROCESS_ICON_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(5, "_IMSS_PID_ICON_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(6, "_IMSS_PROCESSNAME_ICON_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(7, "_IMSS_FILE_ICON_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(8, "_IMSS_FILEPATH_ICON_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(9, "_IMSS_GreenCheckMark_Icon_16x16.png")
        Me._IMSS_IMAGELIST.Images.SetKeyName(10, "_IMSS_Error_Icon_16x16.png")
        '
        '_IMSS_ANALYZE_WORKER
        '
        Me._IMSS_ANALYZE_WORKER.WorkerReportsProgress = True
        Me._IMSS_ANALYZE_WORKER.WorkerSupportsCancellation = True
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ON_COMPLETE_PANEL)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_StepIndicator)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CONTROL_HOLDER_Panel)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CURRENT_SANNING_Label)
        Me._IMSS_MainPanel.Controls.Add(Me.ProgressBar1)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ANALYZE_TREEVIEW)
        Me._IMSS_MainPanel.Controls.Add(Me.Label1)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(527, 441)
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
        '_IMSS_ON_COMPLETE_PANEL
        '
        Me._IMSS_ON_COMPLETE_PANEL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_ON_COMPLETE_PANEL.Controls.Add(Me._IMSS_STATUS_DESCRIPTION_LABEL)
        Me._IMSS_ON_COMPLETE_PANEL.Controls.Add(Me._IMSS_IS_COMPLETED_Label)
        Me._IMSS_ON_COMPLETE_PANEL.Location = New System.Drawing.Point(4, 4)
        Me._IMSS_ON_COMPLETE_PANEL.Name = "_IMSS_ON_COMPLETE_PANEL"
        Me._IMSS_ON_COMPLETE_PANEL.Size = New System.Drawing.Size(511, 114)
        Me._IMSS_ON_COMPLETE_PANEL.TabIndex = 7
        Me._IMSS_ON_COMPLETE_PANEL.Visible = False
        '
        '_IMSS_STATUS_DESCRIPTION_LABEL
        '
        Me._IMSS_STATUS_DESCRIPTION_LABEL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me._IMSS_STATUS_DESCRIPTION_LABEL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_STATUS_DESCRIPTION_LABEL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_STATUS_DESCRIPTION_LABEL.Location = New System.Drawing.Point(11, 37)
        Me._IMSS_STATUS_DESCRIPTION_LABEL.Name = "_IMSS_STATUS_DESCRIPTION_LABEL"
        Me._IMSS_STATUS_DESCRIPTION_LABEL.Size = New System.Drawing.Size(487, 69)
        Me._IMSS_STATUS_DESCRIPTION_LABEL.TabIndex = 1
        Me._IMSS_STATUS_DESCRIPTION_LABEL.Text = resources.GetString("_IMSS_STATUS_DESCRIPTION_LABEL.Text")
        Me._IMSS_STATUS_DESCRIPTION_LABEL.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me._IMSS_STATUS_DESCRIPTION_LABEL.WordWrap = True
        '
        '_IMSS_IS_COMPLETED_Label
        '
        Me._IMSS_IS_COMPLETED_Label.AutoSize = True
        Me._IMSS_IS_COMPLETED_Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_IS_COMPLETED_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_IS_COMPLETED_Label.Image = CType(resources.GetObject("_IMSS_IS_COMPLETED_Label.Image"), System.Drawing.Image)
        Me._IMSS_IS_COMPLETED_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_IS_COMPLETED_Label.Location = New System.Drawing.Point(8, 9)
        Me._IMSS_IS_COMPLETED_Label.Name = "_IMSS_IS_COMPLETED_Label"
        Me._IMSS_IS_COMPLETED_Label.Size = New System.Drawing.Size(248, 18)
        Me._IMSS_IS_COMPLETED_Label.TabIndex = 0
        Me._IMSS_IS_COMPLETED_Label.Text = "      Behavior Analysis is completed"
        '
        '_IMSS_StepIndicator
        '
        Me._IMSS_StepIndicator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_StepIndicator.Location = New System.Drawing.Point(12, 106)
        Me._IMSS_StepIndicator.Name = "_IMSS_StepIndicator"
        Me._IMSS_StepIndicator.Size = New System.Drawing.Size(503, 4)
        Me._IMSS_StepIndicator.TabIndex = 5
        '
        '_IMSS_CONTROL_HOLDER_Panel
        '
        Me._IMSS_CONTROL_HOLDER_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_CONTROL_HOLDER_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CONTROL_HOLDER_Panel.Controls.Add(Me._IMSS_CLEANUP_PROGRESSBAR)
        Me._IMSS_CONTROL_HOLDER_Panel.Controls.Add(Me._IMSS_CLEANUPALLTHREATS_BUTTON)
        Me._IMSS_CONTROL_HOLDER_Panel.Controls.Add(Me._IMSS_CANCEL_BUTTON)
        Me._IMSS_CONTROL_HOLDER_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_CONTROL_HOLDER_Panel.Location = New System.Drawing.Point(0, 402)
        Me._IMSS_CONTROL_HOLDER_Panel.Name = "_IMSS_CONTROL_HOLDER_Panel"
        Me._IMSS_CONTROL_HOLDER_Panel.Size = New System.Drawing.Size(527, 39)
        Me._IMSS_CONTROL_HOLDER_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_CONTROL_HOLDER_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_CONTROL_HOLDER_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_CONTROL_HOLDER_Panel.Style.GradientAngle = 90
        Me._IMSS_CONTROL_HOLDER_Panel.TabIndex = 4
        '
        '_IMSS_CLEANUP_PROGRESSBAR
        '
        Me._IMSS_CLEANUP_PROGRESSBAR.Location = New System.Drawing.Point(132, 9)
        Me._IMSS_CLEANUP_PROGRESSBAR.MarqueeAnimationSpeed = 4
        Me._IMSS_CLEANUP_PROGRESSBAR.Name = "_IMSS_CLEANUP_PROGRESSBAR"
        Me._IMSS_CLEANUP_PROGRESSBAR.Size = New System.Drawing.Size(307, 23)
        Me._IMSS_CLEANUP_PROGRESSBAR.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me._IMSS_CLEANUP_PROGRESSBAR.TabIndex = 2
        Me._IMSS_CLEANUP_PROGRESSBAR.Visible = False
        '
        '_IMSS_CLEANUPALLTHREATS_BUTTON
        '
        Me._IMSS_CLEANUPALLTHREATS_BUTTON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._IMSS_CLEANUPALLTHREATS_BUTTON.Location = New System.Drawing.Point(12, 9)
        Me._IMSS_CLEANUPALLTHREATS_BUTTON.Name = "_IMSS_CLEANUPALLTHREATS_BUTTON"
        Me._IMSS_CLEANUPALLTHREATS_BUTTON.Size = New System.Drawing.Size(114, 23)
        Me._IMSS_CLEANUPALLTHREATS_BUTTON.TabIndex = 1
        Me._IMSS_CLEANUPALLTHREATS_BUTTON.Text = "Clean up all threats"
        Me._IMSS_CLEANUPALLTHREATS_BUTTON.UseVisualStyleBackColor = True
        Me._IMSS_CLEANUPALLTHREATS_BUTTON.Visible = False
        '
        '_IMSS_CANCEL_BUTTON
        '
        Me._IMSS_CANCEL_BUTTON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_CANCEL_BUTTON.Location = New System.Drawing.Point(445, 9)
        Me._IMSS_CANCEL_BUTTON.Name = "_IMSS_CANCEL_BUTTON"
        Me._IMSS_CANCEL_BUTTON.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_CANCEL_BUTTON.TabIndex = 0
        Me._IMSS_CANCEL_BUTTON.Text = "Cancel"
        Me._IMSS_CANCEL_BUTTON.UseVisualStyleBackColor = True
        '
        '_IMSS_CURRENT_SANNING_Label
        '
        Me._IMSS_CURRENT_SANNING_Label.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CURRENT_SANNING_Label.Image = CType(resources.GetObject("_IMSS_CURRENT_SANNING_Label.Image"), System.Drawing.Image)
        Me._IMSS_CURRENT_SANNING_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_CURRENT_SANNING_Label.Location = New System.Drawing.Point(9, 41)
        Me._IMSS_CURRENT_SANNING_Label.Name = "_IMSS_CURRENT_SANNING_Label"
        Me._IMSS_CURRENT_SANNING_Label.Size = New System.Drawing.Size(506, 23)
        Me._IMSS_CURRENT_SANNING_Label.TabIndex = 3
        Me._IMSS_CURRENT_SANNING_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 78)
        Me.ProgressBar1.MarqueeAnimationSpeed = 4
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(503, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Analyzing target behaviour ..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 441)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Analyze Behavior"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_ON_COMPLETE_PANEL.ResumeLayout(False)
        Me._IMSS_ON_COMPLETE_PANEL.PerformLayout()
        Me._IMSS_CONTROL_HOLDER_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_ANALYZE_TREEVIEW As System.Windows.Forms.TreeView
    Friend WithEvents _IMSS_ANALYZE_WORKER As System.ComponentModel.BackgroundWorker
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_CONTROL_HOLDER_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_CANCEL_BUTTON As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_StepIndicator As DevComponents.DotNetBar.Controls.StepIndicator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_CURRENT_SANNING_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_ON_COMPLETE_PANEL As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_IMAGELIST As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_IS_COMPLETED_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_STATUS_DESCRIPTION_LABEL As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CLEANUPALLTHREATS_BUTTON As System.Windows.Forms.Button
    Friend WithEvents _IMSS_CLEANUP_PROGRESSBAR As System.Windows.Forms.ProgressBar

End Class
