<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_CleanUpUtilities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_CleanUpUtilities))
        Me._IMSS_Sliding_Timer = New System.Windows.Forms.Timer(Me.components)
        Me._IMSS_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_Info_ToolTip_CUWAP = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImsS_StartButton3 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT1 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.ImsS_StartButton2 = New IMSS_AsstClasses.IMSS_StartButton()
        Me.ImsS_StartButton1 = New IMSS_AsstClasses.IMSS_StartButton()
        Me.ImsS_StartButton7 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT6 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.ImsS_StartButton6 = New IMSS_AsstClasses.IMSS_StartButton()
        Me.ImsS_StartButton5 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT2 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me._IMSS_MINI_UINT5 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me._IMSS_MINI_UINT4 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me._IMSS_MINI_UINT3 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.ImsS_StartButton4 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT7 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me._IMSS_MINI_UINT8 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.ImsS_StartButton8 = New IMSS_AsstClasses.IMSS_StartButton()
        Me.ImsS_StartButton9 = New IMSS_AsstClasses.IMSS_StartButton()
        Me._IMSS_MINI_UINT9 = New IMSS_AsstClasses._IMSS_MINI_UINT()
        Me.Panel1.SuspendLayout()
        CType(Me._IMSS_Info_ToolTip_CUWAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_Sliding_Timer
        '
        Me._IMSS_Sliding_Timer.Interval = 20
        '
        '_IMSS_ToolTip
        '
        Me._IMSS_ToolTip.AutomaticDelay = 0
        Me._IMSS_ToolTip.IsBalloon = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me._IMSS_Info_ToolTip_CUWAP)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 58)
        Me.Panel1.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(150, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 18)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Clean up computer and empty unnissary space"
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
        'ImsS_StartButton3
        '
        Me.ImsS_StartButton3._IMSS_StartsPath = "IMSS Duplicate Files Cleaner.exe"
        Me.ImsS_StartButton3.BackgroundImage = CType(resources.GetObject("ImsS_StartButton3.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton3.Location = New System.Drawing.Point(529, 747)
        Me.ImsS_StartButton3.Name = "ImsS_StartButton3"
        Me.ImsS_StartButton3.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton3.TabIndex = 112
        '
        '_IMSS_MINI_UINT1
        '
        Me._IMSS_MINI_UINT1._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT1._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT1._IMSS_Main_Text = "It's a useful program to help you organize the contents of your home hard drive, " & _
    "You'd be surprised just how many duplicate files you could find forgotten in an " & _
    "documents folder."
        Me._IMSS_MINI_UINT1._IMSS_Main_Title = "Duplicate Files Cleaner"
        Me._IMSS_MINI_UINT1._IMSS_SET_RATING_TOTAL = 3
        Me._IMSS_MINI_UINT1.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT1.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT1.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT1.Location = New System.Drawing.Point(0, 695)
        Me._IMSS_MINI_UINT1.Name = "_IMSS_MINI_UINT1"
        Me._IMSS_MINI_UINT1.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT1.TabIndex = 113
        '
        'ImsS_StartButton2
        '
        Me.ImsS_StartButton2._IMSS_StartsPath = "IMSS Browser Cleaner.exe"
        Me.ImsS_StartButton2.BackgroundImage = CType(resources.GetObject("ImsS_StartButton2.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton2.Location = New System.Drawing.Point(529, 114)
        Me.ImsS_StartButton2.Name = "ImsS_StartButton2"
        Me.ImsS_StartButton2.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton2.TabIndex = 111
        '
        'ImsS_StartButton1
        '
        Me.ImsS_StartButton1._IMSS_StartsPath = "IMSS Uninstall Manager.exe"
        Me.ImsS_StartButton1.BackgroundImage = CType(resources.GetObject("ImsS_StartButton1.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton1.Location = New System.Drawing.Point(529, 953)
        Me.ImsS_StartButton1.Name = "ImsS_StartButton1"
        Me.ImsS_StartButton1.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton1.TabIndex = 100
        '
        'ImsS_StartButton7
        '
        Me.ImsS_StartButton7._IMSS_StartsPath = "IMSS Drive Wiper.exe"
        Me.ImsS_StartButton7.BackgroundImage = CType(resources.GetObject("ImsS_StartButton7.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton7.Location = New System.Drawing.Point(529, 853)
        Me.ImsS_StartButton7.Name = "ImsS_StartButton7"
        Me.ImsS_StartButton7.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton7.TabIndex = 110
        '
        '_IMSS_MINI_UINT6
        '
        Me._IMSS_MINI_UINT6._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT6._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT6._IMSS_Main_Text = "When you delete files , only the file directory is changed. The file information " & _
    "itself still resides on the hard disk, and it is easy to recover , by using driv" & _
    "er wipe all data will be deleted."
        Me._IMSS_MINI_UINT6._IMSS_Main_Title = "Drive Wiper"
        Me._IMSS_MINI_UINT6._IMSS_SET_RATING_TOTAL = 2
        Me._IMSS_MINI_UINT6.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT6.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT6.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT6.Location = New System.Drawing.Point(0, 799)
        Me._IMSS_MINI_UINT6.Name = "_IMSS_MINI_UINT6"
        Me._IMSS_MINI_UINT6.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT6.TabIndex = 109
        '
        'ImsS_StartButton6
        '
        Me.ImsS_StartButton6._IMSS_StartsPath = "IMSS Shortcut File Cleaner.exe"
        Me.ImsS_StartButton6.BackgroundImage = CType(resources.GetObject("ImsS_StartButton6.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton6.Location = New System.Drawing.Point(529, 221)
        Me.ImsS_StartButton6.Name = "ImsS_StartButton6"
        Me.ImsS_StartButton6.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton6.TabIndex = 108
        '
        'ImsS_StartButton5
        '
        Me.ImsS_StartButton5._IMSS_StartsPath = "IMSS Complete Files Eraser.exe"
        Me.ImsS_StartButton5.BackgroundImage = CType(resources.GetObject("ImsS_StartButton5.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton5.Location = New System.Drawing.Point(529, 636)
        Me.ImsS_StartButton5.Name = "ImsS_StartButton5"
        Me.ImsS_StartButton5.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton5.TabIndex = 107
        '
        '_IMSS_MINI_UINT2
        '
        Me._IMSS_MINI_UINT2._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT2._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT2._IMSS_Main_Text = "It's handy tool designed to find and remove all broken shortcuts on your computer" & _
    " , the invalid shortcuts may be scattered in the Desktop ...etc , Shortcut Remov" & _
    "er locate and clear them all."
        Me._IMSS_MINI_UINT2._IMSS_Main_Title = "Broken Shortcut Remover"
        Me._IMSS_MINI_UINT2._IMSS_SET_RATING_TOTAL = 4
        Me._IMSS_MINI_UINT2.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT2.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT2.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT2.Location = New System.Drawing.Point(0, 170)
        Me._IMSS_MINI_UINT2.Name = "_IMSS_MINI_UINT2"
        Me._IMSS_MINI_UINT2.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT2.TabIndex = 99
        '
        '_IMSS_MINI_UINT5
        '
        Me._IMSS_MINI_UINT5._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT5._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT5._IMSS_Main_Text = "It's a handy utility designed to securely delete all traces of your online and of" & _
    "fline activity and free up space on your hard drive by removing thousands of unn" & _
    "ecessary files."
        Me._IMSS_MINI_UINT5._IMSS_Main_Title = "Windows Browser Cleaner"
        Me._IMSS_MINI_UINT5._IMSS_SET_RATING_TOTAL = 5
        Me._IMSS_MINI_UINT5.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT5.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT5.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT5.Location = New System.Drawing.Point(0, 64)
        Me._IMSS_MINI_UINT5.Name = "_IMSS_MINI_UINT5"
        Me._IMSS_MINI_UINT5.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT5.TabIndex = 105
        '
        '_IMSS_MINI_UINT4
        '
        Me._IMSS_MINI_UINT4._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT4._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT4._IMSS_Main_Text = "It's an advanced security tool for Windows which allows you to completely remove " & _
    "sensitive data from your hard drive by overwriting it several times with careful" & _
    "ly selected patterns."
        Me._IMSS_MINI_UINT4._IMSS_Main_Title = "Complete Files Eraser"
        Me._IMSS_MINI_UINT4._IMSS_SET_RATING_TOTAL = 2
        Me._IMSS_MINI_UINT4.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT4.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT4.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT4.Location = New System.Drawing.Point(0, 588)
        Me._IMSS_MINI_UINT4.Name = "_IMSS_MINI_UINT4"
        Me._IMSS_MINI_UINT4.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT4.TabIndex = 104
        '
        '_IMSS_MINI_UINT3
        '
        Me._IMSS_MINI_UINT3._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT3._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT3._IMSS_Main_Text = resources.GetString("_IMSS_MINI_UINT3._IMSS_Main_Text")
        Me._IMSS_MINI_UINT3._IMSS_Main_Title = "Software Uninstall Manager"
        Me._IMSS_MINI_UINT3._IMSS_SET_RATING_TOTAL = 4
        Me._IMSS_MINI_UINT3.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT3.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT3.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT3.Location = New System.Drawing.Point(0, 903)
        Me._IMSS_MINI_UINT3.Name = "_IMSS_MINI_UINT3"
        Me._IMSS_MINI_UINT3.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT3.TabIndex = 102
        '
        'ImsS_StartButton4
        '
        Me.ImsS_StartButton4._IMSS_StartsPath = "IMSS Empty Folder Cleaner.exe"
        Me.ImsS_StartButton4.BackgroundImage = CType(resources.GetObject("ImsS_StartButton4.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton4.Location = New System.Drawing.Point(529, 535)
        Me.ImsS_StartButton4.Name = "ImsS_StartButton4"
        Me.ImsS_StartButton4.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton4.TabIndex = 115
        '
        '_IMSS_MINI_UINT7
        '
        Me._IMSS_MINI_UINT7._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT7._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT7._IMSS_Main_Text = "Delete empty folders from your computer and remove the clutter in order to increa" & _
    "se performance. "
        Me._IMSS_MINI_UINT7._IMSS_Main_Title = "Empty Folder Cleaner"
        Me._IMSS_MINI_UINT7._IMSS_SET_RATING_TOTAL = 3
        Me._IMSS_MINI_UINT7.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT7.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT7.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT7.Location = New System.Drawing.Point(0, 484)
        Me._IMSS_MINI_UINT7.Name = "_IMSS_MINI_UINT7"
        Me._IMSS_MINI_UINT7.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT7.TabIndex = 114
        '
        '_IMSS_MINI_UINT8
        '
        Me._IMSS_MINI_UINT8._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT8._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT8._IMSS_Main_Text = "It's designed to quickly remove as many unnecessary files as possible from a hard" & _
    " drive. It uses a combination of system environment variables and known director" & _
    "y structures."
        Me._IMSS_MINI_UINT8._IMSS_Main_Title = "Windows Temporary Files Cleaner"
        Me._IMSS_MINI_UINT8._IMSS_SET_RATING_TOTAL = 4
        Me._IMSS_MINI_UINT8.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT8.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT8.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT8.Location = New System.Drawing.Point(-1, 274)
        Me._IMSS_MINI_UINT8.Name = "_IMSS_MINI_UINT8"
        Me._IMSS_MINI_UINT8.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT8.TabIndex = 116
        '
        'ImsS_StartButton8
        '
        Me.ImsS_StartButton8._IMSS_StartsPath = "IMSS Windows Temporary Files Cleaner.exe"
        Me.ImsS_StartButton8.BackgroundImage = CType(resources.GetObject("ImsS_StartButton8.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton8.Location = New System.Drawing.Point(529, 324)
        Me.ImsS_StartButton8.Name = "ImsS_StartButton8"
        Me.ImsS_StartButton8.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton8.TabIndex = 117
        '
        'ImsS_StartButton9
        '
        Me.ImsS_StartButton9._IMSS_StartsPath = "IMSS Registry Cleaner.exe"
        Me.ImsS_StartButton9.BackgroundImage = CType(resources.GetObject("ImsS_StartButton9.BackgroundImage"), System.Drawing.Image)
        Me.ImsS_StartButton9.Location = New System.Drawing.Point(529, 428)
        Me.ImsS_StartButton9.Name = "ImsS_StartButton9"
        Me.ImsS_StartButton9.Size = New System.Drawing.Size(73, 27)
        Me.ImsS_StartButton9.TabIndex = 119
        '
        '_IMSS_MINI_UINT9
        '
        Me._IMSS_MINI_UINT9._IMSS_Main_Logo = CType(resources.GetObject("_IMSS_MINI_UINT9._IMSS_Main_Logo"), System.Drawing.Image)
        Me._IMSS_MINI_UINT9._IMSS_Main_Text = "It's designed to correct problems in the Windows registry, such as missing refere" & _
    "nces to shared DLLs, unused registration entries for file extensions, and missin" & _
    "g referenced application paths."
        Me._IMSS_MINI_UINT9._IMSS_Main_Title = "Windows Registry Cleaner"
        Me._IMSS_MINI_UINT9._IMSS_SET_RATING_TOTAL = 5
        Me._IMSS_MINI_UINT9.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MINI_UINT9.BackgroundImage = CType(resources.GetObject("_IMSS_MINI_UINT9.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MINI_UINT9.Location = New System.Drawing.Point(-1, 378)
        Me._IMSS_MINI_UINT9.Name = "_IMSS_MINI_UINT9"
        Me._IMSS_MINI_UINT9.Size = New System.Drawing.Size(615, 84)
        Me._IMSS_MINI_UINT9.TabIndex = 118
        '
        'IMSS_CleanUpUtilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ImsS_StartButton9)
        Me.Controls.Add(Me._IMSS_MINI_UINT9)
        Me.Controls.Add(Me.ImsS_StartButton8)
        Me.Controls.Add(Me._IMSS_MINI_UINT8)
        Me.Controls.Add(Me.ImsS_StartButton4)
        Me.Controls.Add(Me._IMSS_MINI_UINT7)
        Me.Controls.Add(Me.ImsS_StartButton3)
        Me.Controls.Add(Me._IMSS_MINI_UINT1)
        Me.Controls.Add(Me.ImsS_StartButton2)
        Me.Controls.Add(Me.ImsS_StartButton1)
        Me.Controls.Add(Me.ImsS_StartButton7)
        Me.Controls.Add(Me._IMSS_MINI_UINT6)
        Me.Controls.Add(Me.ImsS_StartButton6)
        Me.Controls.Add(Me.ImsS_StartButton5)
        Me.Controls.Add(Me._IMSS_MINI_UINT2)
        Me.Controls.Add(Me._IMSS_MINI_UINT5)
        Me.Controls.Add(Me._IMSS_MINI_UINT4)
        Me.Controls.Add(Me._IMSS_MINI_UINT3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "IMSS_CleanUpUtilities"
        Me.Size = New System.Drawing.Size(646, 1000)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._IMSS_Info_ToolTip_CUWAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_Sliding_Timer As System.Windows.Forms.Timer
    Friend WithEvents _IMSS_ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_Info_ToolTip_CUWAP As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_MINI_UINT2 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents _IMSS_MINI_UINT3 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents _IMSS_MINI_UINT4 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents _IMSS_MINI_UINT5 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents ImsS_StartButton5 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents ImsS_StartButton6 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents ImsS_StartButton7 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents _IMSS_MINI_UINT6 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents ImsS_StartButton1 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents ImsS_StartButton2 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents ImsS_StartButton3 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents _IMSS_MINI_UINT1 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents ImsS_StartButton4 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents _IMSS_MINI_UINT7 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents _IMSS_MINI_UINT8 As IMSS_AsstClasses._IMSS_MINI_UINT
    Friend WithEvents ImsS_StartButton8 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents ImsS_StartButton9 As IMSS_AsstClasses.IMSS_StartButton
    Friend WithEvents _IMSS_MINI_UINT9 As IMSS_AsstClasses._IMSS_MINI_UINT

End Class
