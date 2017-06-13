<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Utilities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Utilities))
        Me._IMSS_ControlHoolders = New System.Windows.Forms.Panel()
        Me._IMSS_Utitilies_Icons = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_Control_Assistance_Uint = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._IMSS_MAIN_PANEL = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_OptimizeC = New System.Windows.Forms.Button()
        Me._IMSS_Log = New System.Windows.Forms.Button()
        Me._IMSS_Other = New System.Windows.Forms.Button()
        Me._IMSS_Repair = New System.Windows.Forms.Button()
        Me._IMSS_Family = New System.Windows.Forms.Button()
        Me._IMSS_Internet = New System.Windows.Forms.Button()
        Me._IMSS_CleanUp = New System.Windows.Forms.Button()
        Me.MainControls1 = New IMSS_AsstClasses.MainControls()
        Me._IMSS_ControlHoolders.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me._IMSS_MAIN_PANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_ControlHoolders
        '
        Me._IMSS_ControlHoolders.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_ControlHoolders.Controls.Add(Me._IMSS_OptimizeC)
        Me._IMSS_ControlHoolders.Controls.Add(Me._IMSS_Log)
        Me._IMSS_ControlHoolders.Controls.Add(Me._IMSS_Other)
        Me._IMSS_ControlHoolders.Controls.Add(Me._IMSS_Repair)
        Me._IMSS_ControlHoolders.Controls.Add(Me._IMSS_Family)
        Me._IMSS_ControlHoolders.Controls.Add(Me._IMSS_Internet)
        Me._IMSS_ControlHoolders.Controls.Add(Me._IMSS_CleanUp)
        Me._IMSS_ControlHoolders.Location = New System.Drawing.Point(7, 5)
        Me._IMSS_ControlHoolders.Name = "_IMSS_ControlHoolders"
        Me._IMSS_ControlHoolders.Size = New System.Drawing.Size(171, 382)
        Me._IMSS_ControlHoolders.TabIndex = 28
        '
        '_IMSS_Utitilies_Icons
        '
        Me._IMSS_Utitilies_Icons.ImageStream = CType(resources.GetObject("_IMSS_Utitilies_Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_Utitilies_Icons.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_Utitilies_Icons.Images.SetKeyName(0, "_IMSS_RepairU.png")
        Me._IMSS_Utitilies_Icons.Images.SetKeyName(1, "_IMSS_Log.png")
        Me._IMSS_Utitilies_Icons.Images.SetKeyName(2, "_IMSS_OtherU.png")
        Me._IMSS_Utitilies_Icons.Images.SetKeyName(3, "_IMSS_FamilyU.png")
        Me._IMSS_Utitilies_Icons.Images.SetKeyName(4, "_IMSS_Internet_ToolsU.png")
        Me._IMSS_Utitilies_Icons.Images.SetKeyName(5, "1374978061_smserver.png")
        Me._IMSS_Utitilies_Icons.Images.SetKeyName(6, "-desktop.png")
        '
        '_IMSS_Control_Assistance_Uint
        '
        Me._IMSS_Control_Assistance_Uint.Location = New System.Drawing.Point(178, 5)
        Me._IMSS_Control_Assistance_Uint.Name = "_IMSS_Control_Assistance_Uint"
        Me._IMSS_Control_Assistance_Uint.Size = New System.Drawing.Size(631, 382)
        Me._IMSS_Control_Assistance_Uint.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me._IMSS_MAIN_PANEL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(834, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 393)
        Me.Panel1.TabIndex = 30
        '
        '_IMSS_MAIN_PANEL
        '
        Me._IMSS_MAIN_PANEL.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MAIN_PANEL.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MAIN_PANEL.Controls.Add(Me.MainControls1)
        Me._IMSS_MAIN_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MAIN_PANEL.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MAIN_PANEL.Name = "_IMSS_MAIN_PANEL"
        Me._IMSS_MAIN_PANEL.Size = New System.Drawing.Size(834, 393)
        Me._IMSS_MAIN_PANEL.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MAIN_PANEL.Style.BackColor1.Color = System.Drawing.Color.AliceBlue
        Me._IMSS_MAIN_PANEL.Style.BackColor2.Color = System.Drawing.Color.White
        Me._IMSS_MAIN_PANEL.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MAIN_PANEL.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MAIN_PANEL.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MAIN_PANEL.Style.BorderWidth = 0
        Me._IMSS_MAIN_PANEL.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MAIN_PANEL.Style.GradientAngle = 90
        Me._IMSS_MAIN_PANEL.TabIndex = 2
        Me._IMSS_MAIN_PANEL.Visible = False
        '
        '_IMSS_OptimizeC
        '
        Me._IMSS_OptimizeC.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_OptimizeC.BackgroundImage = CType(resources.GetObject("_IMSS_OptimizeC.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_OptimizeC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._IMSS_OptimizeC.Cursor = System.Windows.Forms.Cursors.Default
        Me._IMSS_OptimizeC.FlatAppearance.BorderSize = 0
        Me._IMSS_OptimizeC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me._IMSS_OptimizeC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_OptimizeC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_OptimizeC.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_OptimizeC.ForeColor = System.Drawing.Color.Black
        Me._IMSS_OptimizeC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_OptimizeC.ImageKey = "-desktop.png"
        Me._IMSS_OptimizeC.ImageList = Me._IMSS_Utitilies_Icons
        Me._IMSS_OptimizeC.Location = New System.Drawing.Point(0, 58)
        Me._IMSS_OptimizeC.Name = "_IMSS_OptimizeC"
        Me._IMSS_OptimizeC.Size = New System.Drawing.Size(173, 41)
        Me._IMSS_OptimizeC.TabIndex = 48
        Me._IMSS_OptimizeC.Tag = ""
        Me._IMSS_OptimizeC.Text = "     Optimize Utilities    "
        Me._IMSS_OptimizeC.UseVisualStyleBackColor = False
        '
        '_IMSS_Log
        '
        Me._IMSS_Log.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_Log.BackgroundImage = CType(resources.GetObject("_IMSS_Log.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_Log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._IMSS_Log.Cursor = System.Windows.Forms.Cursors.Default
        Me._IMSS_Log.FlatAppearance.BorderSize = 0
        Me._IMSS_Log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me._IMSS_Log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_Log.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_Log.ForeColor = System.Drawing.Color.Black
        Me._IMSS_Log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_Log.ImageKey = "_IMSS_Log.png"
        Me._IMSS_Log.ImageList = Me._IMSS_Utitilies_Icons
        Me._IMSS_Log.Location = New System.Drawing.Point(0, 335)
        Me._IMSS_Log.Name = "_IMSS_Log"
        Me._IMSS_Log.Size = New System.Drawing.Size(173, 41)
        Me._IMSS_Log.TabIndex = 5
        Me._IMSS_Log.Text = " LOG Section"
        Me._IMSS_Log.UseVisualStyleBackColor = False
        '
        '_IMSS_Other
        '
        Me._IMSS_Other.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_Other.BackgroundImage = CType(resources.GetObject("_IMSS_Other.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_Other.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._IMSS_Other.Cursor = System.Windows.Forms.Cursors.Default
        Me._IMSS_Other.FlatAppearance.BorderSize = 0
        Me._IMSS_Other.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me._IMSS_Other.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_Other.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_Other.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_Other.ForeColor = System.Drawing.Color.Black
        Me._IMSS_Other.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_Other.ImageKey = "_IMSS_OtherU.png"
        Me._IMSS_Other.ImageList = Me._IMSS_Utitilies_Icons
        Me._IMSS_Other.Location = New System.Drawing.Point(0, 280)
        Me._IMSS_Other.Name = "_IMSS_Other"
        Me._IMSS_Other.Size = New System.Drawing.Size(173, 41)
        Me._IMSS_Other.TabIndex = 4
        Me._IMSS_Other.Text = " Other Utilities"
        Me._IMSS_Other.UseVisualStyleBackColor = False
        '
        '_IMSS_Repair
        '
        Me._IMSS_Repair.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_Repair.BackgroundImage = CType(resources.GetObject("_IMSS_Repair.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_Repair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._IMSS_Repair.Cursor = System.Windows.Forms.Cursors.Default
        Me._IMSS_Repair.FlatAppearance.BorderSize = 0
        Me._IMSS_Repair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me._IMSS_Repair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_Repair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_Repair.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_Repair.ForeColor = System.Drawing.Color.Black
        Me._IMSS_Repair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_Repair.ImageKey = "_IMSS_RepairU.png"
        Me._IMSS_Repair.ImageList = Me._IMSS_Utitilies_Icons
        Me._IMSS_Repair.Location = New System.Drawing.Point(0, 223)
        Me._IMSS_Repair.Name = "_IMSS_Repair"
        Me._IMSS_Repair.Size = New System.Drawing.Size(173, 41)
        Me._IMSS_Repair.TabIndex = 3
        Me._IMSS_Repair.Text = " Repair Utilities"
        Me._IMSS_Repair.UseVisualStyleBackColor = False
        '
        '_IMSS_Family
        '
        Me._IMSS_Family.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_Family.BackgroundImage = CType(resources.GetObject("_IMSS_Family.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_Family.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._IMSS_Family.Cursor = System.Windows.Forms.Cursors.Default
        Me._IMSS_Family.FlatAppearance.BorderSize = 0
        Me._IMSS_Family.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me._IMSS_Family.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_Family.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_Family.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_Family.ForeColor = System.Drawing.Color.Black
        Me._IMSS_Family.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_Family.ImageKey = "_IMSS_FamilyU.png"
        Me._IMSS_Family.ImageList = Me._IMSS_Utitilies_Icons
        Me._IMSS_Family.Location = New System.Drawing.Point(0, 167)
        Me._IMSS_Family.Name = "_IMSS_Family"
        Me._IMSS_Family.Size = New System.Drawing.Size(173, 41)
        Me._IMSS_Family.TabIndex = 2
        Me._IMSS_Family.Text = " Family Utilities"
        Me._IMSS_Family.UseVisualStyleBackColor = False
        '
        '_IMSS_Internet
        '
        Me._IMSS_Internet.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_Internet.BackgroundImage = CType(resources.GetObject("_IMSS_Internet.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_Internet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._IMSS_Internet.Cursor = System.Windows.Forms.Cursors.Default
        Me._IMSS_Internet.FlatAppearance.BorderSize = 0
        Me._IMSS_Internet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me._IMSS_Internet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_Internet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_Internet.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_Internet.ForeColor = System.Drawing.Color.Black
        Me._IMSS_Internet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_Internet.ImageKey = "_IMSS_Internet_ToolsU.png"
        Me._IMSS_Internet.ImageList = Me._IMSS_Utitilies_Icons
        Me._IMSS_Internet.Location = New System.Drawing.Point(0, 110)
        Me._IMSS_Internet.Name = "_IMSS_Internet"
        Me._IMSS_Internet.Size = New System.Drawing.Size(173, 41)
        Me._IMSS_Internet.TabIndex = 1
        Me._IMSS_Internet.Text = "     Internet Utilities    "
        Me._IMSS_Internet.UseVisualStyleBackColor = False
        '
        '_IMSS_CleanUp
        '
        Me._IMSS_CleanUp.BackColor = System.Drawing.Color.AliceBlue
        Me._IMSS_CleanUp.BackgroundImage = CType(resources.GetObject("_IMSS_CleanUp.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_CleanUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._IMSS_CleanUp.Cursor = System.Windows.Forms.Cursors.Default
        Me._IMSS_CleanUp.FlatAppearance.BorderSize = 0
        Me._IMSS_CleanUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me._IMSS_CleanUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_CleanUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_CleanUp.Font = New System.Drawing.Font("Arial", 9.75!)
        Me._IMSS_CleanUp.ForeColor = System.Drawing.Color.Black
        Me._IMSS_CleanUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_CleanUp.ImageKey = "1374978061_smserver.png"
        Me._IMSS_CleanUp.ImageList = Me._IMSS_Utitilies_Icons
        Me._IMSS_CleanUp.Location = New System.Drawing.Point(0, 3)
        Me._IMSS_CleanUp.Name = "_IMSS_CleanUp"
        Me._IMSS_CleanUp.Size = New System.Drawing.Size(173, 41)
        Me._IMSS_CleanUp.TabIndex = 0
        Me._IMSS_CleanUp.Tag = ""
        Me._IMSS_CleanUp.Text = "      Clean Up Utilities   "
        Me._IMSS_CleanUp.UseVisualStyleBackColor = False
        '
        'MainControls1
        '
        Me.MainControls1.Location = New System.Drawing.Point(0, 0)
        Me.MainControls1.Name = "MainControls1"
        Me.MainControls1.Size = New System.Drawing.Size(834, 786)
        Me.MainControls1.TabIndex = 0
        '
        'IMSS_Utilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_Control_Assistance_Uint)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me._IMSS_ControlHoolders)
        Me.Name = "IMSS_Utilities"
        Me.Size = New System.Drawing.Size(1668, 393)
        Me._IMSS_ControlHoolders.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me._IMSS_MAIN_PANEL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_OptimizeC As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Log As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Other As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Repair As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Family As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Internet As System.Windows.Forms.Button
    Friend WithEvents _IMSS_CleanUp As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Utitilies_Icons As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_Control_Assistance_Uint As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents _IMSS_ControlHoolders As System.Windows.Forms.Panel
    Public WithEvents _IMSS_MAIN_PANEL As DevComponents.DotNetBar.PanelEx
    Friend WithEvents MainControls1 As IMSS_AsstClasses.MainControls

End Class
