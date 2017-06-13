<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_DeviceImmunizer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_DeviceImmunizer))
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me._IMSS_UintDec_Label = New System.Windows.Forms.Label()
        Me._IMSS_ENCR_NEXT = New System.Windows.Forms.Button()
        Me._IMSS_DvicesFound_Panel = New System.Windows.Forms.Panel()
        Me._IMSS_Info_ToolTip_CUWAP = New System.Windows.Forms.PictureBox()
        Me._IMSS_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_CheckingIfRemovabelDriveInUse = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_USB_Logo = New System.Windows.Forms.PictureBox()
        Me._IMSS_SCANUSB_STATUS = New System.Windows.Forms.Label()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me._IMSS_MainProgressBar = New System.Windows.Forms.ProgressBar()
        Me._IMSS_DriveName_Label = New System.Windows.Forms.Label()
        Me._IMSS_ImmunizationStatus = New System.Windows.Forms.Label()
        Me.Panel14.SuspendLayout()
        Me.Panel24.SuspendLayout()
        CType(Me._IMSS_Info_ToolTip_CUWAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_CheckingIfRemovabelDriveInUse.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me._IMSS_USB_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel14.Controls.Add(Me.Label20)
        Me.Panel14.Location = New System.Drawing.Point(6, 4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(136, 26)
        Me.Panel14.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(6, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 14)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Immunize usb drives"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel11.Location = New System.Drawing.Point(6, 20)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(621, 10)
        Me.Panel11.TabIndex = 46
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel24.Controls.Add(Me.Label14)
        Me.Panel24.Location = New System.Drawing.Point(7, 277)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(86, 26)
        Me.Panel24.TabIndex = 63
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(18, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 16)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Options"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel25.Location = New System.Drawing.Point(7, 293)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(621, 10)
        Me.Panel25.TabIndex = 62
        '
        '_IMSS_UintDec_Label
        '
        Me._IMSS_UintDec_Label.AutoSize = True
        Me._IMSS_UintDec_Label.Location = New System.Drawing.Point(12, 320)
        Me._IMSS_UintDec_Label.Name = "_IMSS_UintDec_Label"
        Me._IMSS_UintDec_Label.Size = New System.Drawing.Size(436, 26)
        Me._IMSS_UintDec_Label.TabIndex = 61
        Me._IMSS_UintDec_Label.Text = "Immunize USB flash drive against Autorun Viruses , It's will make your usb drive " & _
            "protected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from Autorun Viruses  in any computer."
        '
        '_IMSS_ENCR_NEXT
        '
        Me._IMSS_ENCR_NEXT.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_ENCR_NEXT.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me._IMSS_ENCR_NEXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_ENCR_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_ENCR_NEXT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ENCR_NEXT.Image = Global.IMSS.My.Resources.Resources._IMSS_RestoreTo_Icon_16x16
        Me._IMSS_ENCR_NEXT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_ENCR_NEXT.Location = New System.Drawing.Point(487, 326)
        Me._IMSS_ENCR_NEXT.Name = "_IMSS_ENCR_NEXT"
        Me._IMSS_ENCR_NEXT.Size = New System.Drawing.Size(123, 36)
        Me._IMSS_ENCR_NEXT.TabIndex = 60
        Me._IMSS_ENCR_NEXT.Text = "Next >>"
        Me._IMSS_ENCR_NEXT.UseVisualStyleBackColor = False
        '
        '_IMSS_DvicesFound_Panel
        '
        Me._IMSS_DvicesFound_Panel.AutoScroll = True
        Me._IMSS_DvicesFound_Panel.Location = New System.Drawing.Point(5, 35)
        Me._IMSS_DvicesFound_Panel.Name = "_IMSS_DvicesFound_Panel"
        Me._IMSS_DvicesFound_Panel.Size = New System.Drawing.Size(634, 236)
        Me._IMSS_DvicesFound_Panel.TabIndex = 59
        '
        '_IMSS_Info_ToolTip_CUWAP
        '
        Me._IMSS_Info_ToolTip_CUWAP.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_Info_ToolTip_CUWAP.Image = Global.IMSS.My.Resources.Resources._IMSS_Info_ToolTip
        Me._IMSS_Info_ToolTip_CUWAP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me._IMSS_Info_ToolTip_CUWAP.Location = New System.Drawing.Point(204, 333)
        Me._IMSS_Info_ToolTip_CUWAP.Name = "_IMSS_Info_ToolTip_CUWAP"
        Me._IMSS_Info_ToolTip_CUWAP.Size = New System.Drawing.Size(14, 14)
        Me._IMSS_Info_ToolTip_CUWAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_Info_ToolTip_CUWAP.TabIndex = 91
        Me._IMSS_Info_ToolTip_CUWAP.TabStop = False
        Me._IMSS_ToolTip.SetToolTip(Me._IMSS_Info_ToolTip_CUWAP, resources.GetString("_IMSS_Info_ToolTip_CUWAP.ToolTip"))
        '
        '_IMSS_ToolTip
        '
        Me._IMSS_ToolTip.AutoPopDelay = 20000
        Me._IMSS_ToolTip.InitialDelay = 100
        Me._IMSS_ToolTip.ReshowDelay = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.IMSS.My.Resources.Resources._IMSS_Info_ToolTip
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(613, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(14, 14)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        Me._IMSS_ToolTip.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        '
        '_IMSS_CheckingIfRemovabelDriveInUse
        '
        Me._IMSS_CheckingIfRemovabelDriveInUse.BackColor = System.Drawing.Color.White
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me.PictureBox1)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me.Panel1)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me._IMSS_USB_Logo)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me._IMSS_SCANUSB_STATUS)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me.Panel27)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Controls.Add(Me.Label6)
        Me._IMSS_CheckingIfRemovabelDriveInUse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me._IMSS_CheckingIfRemovabelDriveInUse.Location = New System.Drawing.Point(627, 3)
        Me._IMSS_CheckingIfRemovabelDriveInUse.Name = "_IMSS_CheckingIfRemovabelDriveInUse"
        Me._IMSS_CheckingIfRemovabelDriveInUse.Size = New System.Drawing.Size(10, 10)
        Me._IMSS_CheckingIfRemovabelDriveInUse.TabIndex = 92
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 26)
        Me.Panel1.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 14)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Immunize usb drives"
        '
        '_IMSS_USB_Logo
        '
        Me._IMSS_USB_Logo.Image = CType(resources.GetObject("_IMSS_USB_Logo.Image"), System.Drawing.Image)
        Me._IMSS_USB_Logo.Location = New System.Drawing.Point(229, 129)
        Me._IMSS_USB_Logo.Name = "_IMSS_USB_Logo"
        Me._IMSS_USB_Logo.Size = New System.Drawing.Size(182, 64)
        Me._IMSS_USB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_USB_Logo.TabIndex = 74
        Me._IMSS_USB_Logo.TabStop = False
        '
        '_IMSS_SCANUSB_STATUS
        '
        Me._IMSS_SCANUSB_STATUS.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SCANUSB_STATUS.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_SCANUSB_STATUS.Location = New System.Drawing.Point(70, 225)
        Me._IMSS_SCANUSB_STATUS.Name = "_IMSS_SCANUSB_STATUS"
        Me._IMSS_SCANUSB_STATUS.Size = New System.Drawing.Size(500, 23)
        Me._IMSS_SCANUSB_STATUS.TabIndex = 73
        Me._IMSS_SCANUSB_STATUS.Text = "There is no removable devices connected to this computer"
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel27.Location = New System.Drawing.Point(6, 19)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(621, 10)
        Me.Panel27.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(26, -30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Autorun"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(6, 380)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(136, 26)
        Me.Panel2.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 14)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "drive immunization"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Location = New System.Drawing.Point(6, 396)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(621, 10)
        Me.Panel3.TabIndex = 93
        '
        '_IMSS_MainProgressBar
        '
        Me._IMSS_MainProgressBar.Location = New System.Drawing.Point(15, 491)
        Me._IMSS_MainProgressBar.MarqueeAnimationSpeed = 4
        Me._IMSS_MainProgressBar.Name = "_IMSS_MainProgressBar"
        Me._IMSS_MainProgressBar.Size = New System.Drawing.Size(595, 23)
        Me._IMSS_MainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me._IMSS_MainProgressBar.TabIndex = 95
        '
        '_IMSS_DriveName_Label
        '
        Me._IMSS_DriveName_Label.AutoSize = True
        Me._IMSS_DriveName_Label.Location = New System.Drawing.Point(15, 472)
        Me._IMSS_DriveName_Label.Name = "_IMSS_DriveName_Label"
        Me._IMSS_DriveName_Label.Size = New System.Drawing.Size(72, 13)
        Me._IMSS_DriveName_Label.TabIndex = 96
        Me._IMSS_DriveName_Label.Text = "Drive Name : "
        '
        '_IMSS_ImmunizationStatus
        '
        Me._IMSS_ImmunizationStatus.AutoSize = True
        Me._IMSS_ImmunizationStatus.Location = New System.Drawing.Point(15, 517)
        Me._IMSS_ImmunizationStatus.Name = "_IMSS_ImmunizationStatus"
        Me._IMSS_ImmunizationStatus.Size = New System.Drawing.Size(0, 13)
        Me._IMSS_ImmunizationStatus.TabIndex = 97
        '
        'IMSS_DeviceImmunizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me._IMSS_ImmunizationStatus)
        Me.Controls.Add(Me._IMSS_DriveName_Label)
        Me.Controls.Add(Me._IMSS_MainProgressBar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me._IMSS_CheckingIfRemovabelDriveInUse)
        Me.Controls.Add(Me._IMSS_Info_ToolTip_CUWAP)
        Me.Controls.Add(Me.Panel24)
        Me.Controls.Add(Me.Panel25)
        Me.Controls.Add(Me._IMSS_UintDec_Label)
        Me.Controls.Add(Me._IMSS_ENCR_NEXT)
        Me.Controls.Add(Me._IMSS_DvicesFound_Panel)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel11)
        Me.Name = "IMSS_DeviceImmunizer"
        Me.Size = New System.Drawing.Size(640, 752)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        CType(Me._IMSS_Info_ToolTip_CUWAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_CheckingIfRemovabelDriveInUse.ResumeLayout(False)
        Me._IMSS_CheckingIfRemovabelDriveInUse.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._IMSS_USB_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_UintDec_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_ENCR_NEXT As System.Windows.Forms.Button
    Friend WithEvents _IMSS_DvicesFound_Panel As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_Info_ToolTip_CUWAP As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents _IMSS_CheckingIfRemovabelDriveInUse As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_USB_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_SCANUSB_STATUS As System.Windows.Forms.Label
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_MainProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_DriveName_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_ImmunizationStatus As System.Windows.Forms.Label

End Class
