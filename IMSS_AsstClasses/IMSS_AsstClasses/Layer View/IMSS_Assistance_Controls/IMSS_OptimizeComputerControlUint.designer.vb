<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_OptimizeComputerControlUint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_OptimizeComputerControlUint))
        Me.Label6 = New System.Windows.Forms.Label()
        Me._IMSS_Info_ToolTip_CUWAP = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImsS_StartButton4 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT4 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.ImsS_StartButton1 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT1 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.ImsS_StartButton3 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT3 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.ImsS_StartButton2 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT2 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        CType(Me._IMSS_Info_ToolTip_CUWAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(150, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(359, 18)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Optimize computer and reduce system load"
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
        Me.PictureBox1.Location = New System.Drawing.Point(96, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me._IMSS_Info_ToolTip_CUWAP)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 58)
        Me.Panel1.TabIndex = 96
        '
        'ImsS_StartButton4
        '
        Me.ImsS_StartButton4._IMSS_StartsPath = "IMSS Device Driver Manager.exe"
        Me.ImsS_StartButton4.BackgroundImage = CType(resources.GetObject("ImsS_StartButton4.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton4.Location = New System.Drawing.Point(528, 425)
        Me.ImsS_StartButton4.Name = "ImsS_StartButton4"
        Me.ImsS_StartButton4.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton4.TabIndex = 105
        '
        '_IMSS_MINI_UINT4
        '
        Me._IMSS_MINI_UINT4._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT4._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT4._IMSS_Main_Text = "it's enables easy and fast detection, backup and restore of all hardware device d" & _
            "rivers currently on your system."
        Me._IMSS_MINI_UINT4._IMSS_Main_Title = "Devices Drivers Manager"
        Me._IMSS_MINI_UINT4._IMSS_SET_RATING_TOTAL = 2
        Me._IMSS_MINI_UINT4.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT4.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT4.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT4.Location = New System.Drawing.Point(0, 376)
        Me._IMSS_MINI_UINT4.Name = "_IMSS_MINI_UINT4"
        Me._IMSS_MINI_UINT4.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT4.TabIndex = 104
        '
        'ImsS_StartButton1
        '
        Me.ImsS_StartButton1._IMSS_StartsPath = "IMSS StartUp Manager.exe"
        Me.ImsS_StartButton1.BackgroundImage = CType(resources.GetObject("ImsS_StartButton1.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton1.Location = New System.Drawing.Point(528, 324)
        Me.ImsS_StartButton1.Name = "ImsS_StartButton1"
        Me.ImsS_StartButton1.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton1.TabIndex = 103
        '
        '_IMSS_MINI_UINT1
        '
        Me._IMSS_MINI_UINT1._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT1._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT1._IMSS_Main_Text = "It's a program that provides you the possibility to manage the Windows startup pr" & _
            "ocedure, It offers you the possibility to control which programs automatically s" & _
            "tart up and more."
        Me._IMSS_MINI_UINT1._IMSS_Main_Title = "Windows Startup Manager"
        Me._IMSS_MINI_UINT1._IMSS_SET_RATING_TOTAL = 3
        Me._IMSS_MINI_UINT1.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT1.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT1.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT1.Location = New System.Drawing.Point(0, 275)
        Me._IMSS_MINI_UINT1.Name = "_IMSS_MINI_UINT1"
        Me._IMSS_MINI_UINT1.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT1.TabIndex = 102
        '
        'ImsS_StartButton3
        '
        Me.ImsS_StartButton3._IMSS_StartsPath = "IMSS Task Manager.exe"
        Me.ImsS_StartButton3.BackgroundImage = CType(resources.GetObject("ImsS_StartButton3.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton3.Location = New System.Drawing.Point(528, 224)
        Me.ImsS_StartButton3.Name = "ImsS_StartButton3"
        Me.ImsS_StartButton3.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton3.TabIndex = 101
        '
        '_IMSS_MINI_UINT3
        '
        Me._IMSS_MINI_UINT3._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT3._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT3._IMSS_Main_Text = "Gives you the option of viewing your running processes and open files and ending " & _
            "and/or closing these if there are any problems."
        Me._IMSS_MINI_UINT3._IMSS_Main_Title = "Windows Task Manager"
        Me._IMSS_MINI_UINT3._IMSS_SET_RATING_TOTAL = 3
        Me._IMSS_MINI_UINT3.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT3.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT3.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT3.Location = New System.Drawing.Point(0, 175)
        Me._IMSS_MINI_UINT3.Name = "_IMSS_MINI_UINT3"
        Me._IMSS_MINI_UINT3.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT3.TabIndex = 100
        '
        'ImsS_StartButton2
        '
        Me.ImsS_StartButton2._IMSS_StartsPath = "Disable Windows Functions.exe"
        Me.ImsS_StartButton2.BackgroundImage = CType(resources.GetObject("ImsS_StartButton2.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton2.Location = New System.Drawing.Point(528, 125)
        Me.ImsS_StartButton2.Name = "ImsS_StartButton2"
        Me.ImsS_StartButton2.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton2.TabIndex = 99
        '
        '_IMSS_MINI_UINT2
        '
        Me._IMSS_MINI_UINT2._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT2._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT2._IMSS_Main_Text = "Gives you the option of turning off unwanted Windows features that take up a lot " & _
            "of disk space."
        Me._IMSS_MINI_UINT2._IMSS_Main_Title = "Disable Windows Functions"
        Me._IMSS_MINI_UINT2._IMSS_SET_RATING_TOTAL = 4
        Me._IMSS_MINI_UINT2.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT2.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT2.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT2.Location = New System.Drawing.Point(0, 75)
        Me._IMSS_MINI_UINT2.Name = "_IMSS_MINI_UINT2"
        Me._IMSS_MINI_UINT2.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT2.TabIndex = 98
        '
        'IMSS_OptimizeComputerControlUint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ImsS_StartButton4)
        Me.Controls.Add(Me._IMSS_MINI_UINT4)
        Me.Controls.Add(Me.ImsS_StartButton1)
        Me.Controls.Add(Me._IMSS_MINI_UINT1)
        Me.Controls.Add(Me.ImsS_StartButton3)
        Me.Controls.Add(Me._IMSS_MINI_UINT3)
        Me.Controls.Add(Me.ImsS_StartButton2)
        Me.Controls.Add(Me._IMSS_MINI_UINT2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(640, 379)
        Me.Name = "IMSS_OptimizeComputerControlUint"
        Me.Size = New System.Drawing.Size(640, 514)
        CType(Me._IMSS_Info_ToolTip_CUWAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_Info_ToolTip_CUWAP As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImsS_StartButton2 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents _IMSS_MINI_UINT2 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents ImsS_StartButton3 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents ImsS_StartButton1 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents _IMSS_MINI_UINT1 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents _IMSS_MINI_UINT3 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents ImsS_StartButton4 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents _IMSS_MINI_UINT4 As IMSS_AsstClasses._IMSS_MINI_UINT

End Class
