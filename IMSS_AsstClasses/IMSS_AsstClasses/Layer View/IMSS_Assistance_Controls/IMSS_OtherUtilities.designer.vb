<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_OtherUtilities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_OtherUtilities))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_Info_ToolTip_CUWAP = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_MINI_UINT1 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.ImsS_StartButton1 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT2 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.ImsS_StartButton2 = New IMSS_AsstClasses.IMSS_StartButton()
        Me.Panel1.SuspendLayout()
        CType(Me._IMSS_Info_ToolTip_CUWAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me._IMSS_Info_ToolTip_CUWAP)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 58)
        Me.Panel1.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(173, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 18)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Other tools to manage or organize"
        '
        '_IMSS_Info_ToolTip_CUWAP
        '
        Me._IMSS_Info_ToolTip_CUWAP.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_Info_ToolTip_CUWAP.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_Info_Icon_16x16
        Me._IMSS_Info_ToolTip_CUWAP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me._IMSS_Info_ToolTip_CUWAP.Location = New System.Drawing.Point(600, 19)
        Me._IMSS_Info_ToolTip_CUWAP.Name = "_IMSS_Info_ToolTip_CUWAP"
        Me._IMSS_Info_ToolTip_CUWAP.Size = New System.Drawing.Size(14, 14)
        Me._IMSS_Info_ToolTip_CUWAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_Info_ToolTip_CUWAP.TabIndex = 90
        Me._IMSS_Info_ToolTip_CUWAP.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(119, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_MINI_UINT1
        '
        Me._IMSS_MINI_UINT1._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT1._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT1._IMSS_Main_Text = "It's a tool that allows you to explore file/folder even the hidden or system file" & _
            "/folders and manage or set permissions."
        Me._IMSS_MINI_UINT1._IMSS_Main_Title = "Advanced File Explorer"
        Me._IMSS_MINI_UINT1._IMSS_SET_RATING_TOTAL = 1
        Me._IMSS_MINI_UINT1.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT1.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT1.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT1.Location = New System.Drawing.Point(0, 81)
        Me._IMSS_MINI_UINT1.Name = "_IMSS_MINI_UINT1"
        Me._IMSS_MINI_UINT1.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT1.TabIndex = 100
        '
        'ImsS_StartButton1
        '
        Me.ImsS_StartButton1._IMSS_StartsPath = "IMSS Advanced File Explorer.exe"
        Me.ImsS_StartButton1.BackgroundImage = CType(resources.GetObject("ImsS_StartButton1.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton1.Location = New System.Drawing.Point(527, 130)
        Me.ImsS_StartButton1.Name = "ImsS_StartButton1"
        Me.ImsS_StartButton1.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton1.TabIndex = 101
        '
        '_IMSS_MINI_UINT2
        '
        Me._IMSS_MINI_UINT2._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT2._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT2._IMSS_Main_Text = resources.GetString("_IMSS_MINI_UINT2._IMSS_Main_Text")
        Me._IMSS_MINI_UINT2._IMSS_Main_Title = "File Split Manager"
        Me._IMSS_MINI_UINT2._IMSS_SET_RATING_TOTAL = 4
        Me._IMSS_MINI_UINT2.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT2.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT2.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT2.Location = New System.Drawing.Point(0, 185)
        Me._IMSS_MINI_UINT2.Name = "_IMSS_MINI_UINT2"
        Me._IMSS_MINI_UINT2.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT2.TabIndex = 102
        '
        'ImsS_StartButton2
        '
        Me.ImsS_StartButton2._IMSS_StartsPath = "IMSS File Split Manager.exe"
        Me.ImsS_StartButton2.BackgroundImage = CType(resources.GetObject("ImsS_StartButton2.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton2.Location = New System.Drawing.Point(527, 234)
        Me.ImsS_StartButton2.Name = "ImsS_StartButton2"
        Me.ImsS_StartButton2.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton2.TabIndex = 103
        '
        'IMSS_OtherUtilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ImsS_StartButton2)
        Me.Controls.Add(Me._IMSS_MINI_UINT2)
        Me.Controls.Add(Me.ImsS_StartButton1)
        Me.Controls.Add(Me._IMSS_MINI_UINT1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "IMSS_OtherUtilities"
        Me.Size = New System.Drawing.Size(640, 379)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._IMSS_Info_ToolTip_CUWAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_Info_ToolTip_CUWAP As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_MINI_UINT1 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents ImsS_StartButton1 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents _IMSS_MINI_UINT2 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents ImsS_StartButton2 As IMSS_AsstClasses.IMSS_StartButton

End Class
