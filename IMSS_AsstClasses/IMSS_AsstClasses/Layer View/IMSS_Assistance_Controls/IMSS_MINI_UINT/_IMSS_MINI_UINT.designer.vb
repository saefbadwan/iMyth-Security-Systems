<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _IMSS_MINI_UINT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_IMSS_MINI_UINT))
        Me._IMSS_SLIDE_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me._IMSS_PictureBox_Logo = New System.Windows.Forms.PictureBox()
        Me._IMSS_Title = New System.Windows.Forms.Label()
        Me._IMSS_TargetText_Label = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me._IMSS_RATING_CONTROL = New DevComponents.DotNetBar.Controls.RatingStar()
        CType(Me._IMSS_PictureBox_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_SLIDE_TIMER
        '
        Me._IMSS_SLIDE_TIMER.Interval = 4
        '
        '_IMSS_PictureBox_Logo
        '
        Me._IMSS_PictureBox_Logo.Image = CType(resources.GetObject("_IMSS_PictureBox_Logo.Image"), System.Drawing.Image)
        Me._IMSS_PictureBox_Logo.Location = New System.Drawing.Point(20, 5)
        Me._IMSS_PictureBox_Logo.Name = "_IMSS_PictureBox_Logo"
        Me._IMSS_PictureBox_Logo.Size = New System.Drawing.Size(48, 48)
        Me._IMSS_PictureBox_Logo.TabIndex = 0
        Me._IMSS_PictureBox_Logo.TabStop = False
        '
        '_IMSS_Title
        '
        Me._IMSS_Title.AutoSize = True
        Me._IMSS_Title.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_Title.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Title.ForeColor = System.Drawing.SystemColors.ControlText
        Me._IMSS_Title.Location = New System.Drawing.Point(76, 7)
        Me._IMSS_Title.Name = "_IMSS_Title"
        Me._IMSS_Title.Size = New System.Drawing.Size(222, 18)
        Me._IMSS_Title.TabIndex = 1
        Me._IMSS_Title.Text = "Startup Programs Manager"
        '
        '_IMSS_TargetText_Label
        '
        Me._IMSS_TargetText_Label.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_TargetText_Label.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_TargetText_Label.Location = New System.Drawing.Point(75, 30)
        Me._IMSS_TargetText_Label.Name = "_IMSS_TargetText_Label"
        Me._IMSS_TargetText_Label.Size = New System.Drawing.Size(332, 48)
        Me._IMSS_TargetText_Label.TabIndex = 4
        Me._IMSS_TargetText_Label.Text = "Lorem ipsum dolor sit amet, wisi nec aliquam, aenean vestibulum, a duis leo in du" & _
            "is urna, diam enim. Nibh eu tempor faucibus vel sit sodales, a blandit lectus ut" & _
            " ante, nulla lectus vivamus, "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Location = New System.Drawing.Point(-4, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(18, 91)
        Me.Panel3.TabIndex = 7
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(446, 57)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(76, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Whats is this ?"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(528, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
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
        Me._IMSS_RATING_CONTROL.Location = New System.Drawing.Point(522, 5)
        Me._IMSS_RATING_CONTROL.Name = "_IMSS_RATING_CONTROL"
        Me._IMSS_RATING_CONTROL.Size = New System.Drawing.Size(90, 15)
        Me._IMSS_RATING_CONTROL.TabIndex = 11
        Me._IMSS_RATING_CONTROL.TextColor = System.Drawing.Color.Empty
        '
        '_IMSS_MINI_UINT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me._IMSS_RATING_CONTROL)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me._IMSS_TargetText_Label)
        Me.Controls.Add(Me._IMSS_Title)
        Me.Controls.Add(Me._IMSS_PictureBox_Logo)
        Me.Name = "_IMSS_MINI_UINT"
        Me.Size = New System.Drawing.Size(615, 84)
        CType(Me._IMSS_PictureBox_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_SLIDE_TIMER As System.Windows.Forms.Timer
    Friend WithEvents _IMSS_PictureBox_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Title As System.Windows.Forms.Label
    Friend WithEvents _IMSS_TargetText_Label As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_RATING_CONTROL As DevComponents.DotNetBar.Controls.RatingStar

End Class
