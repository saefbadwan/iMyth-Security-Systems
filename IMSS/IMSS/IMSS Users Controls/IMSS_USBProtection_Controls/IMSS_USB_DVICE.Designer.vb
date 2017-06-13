<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_USB_DVICE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_USB_DVICE))
        Me._IMSS_DRIVER_LOGO = New System.Windows.Forms.PictureBox()
        Me._IMSS_USB_TITLE = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._IMSS_SECURE_PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me._IMSS_DRIVER_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me._IMSS_SECURE_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_DRIVER_LOGO
        '
        Me._IMSS_DRIVER_LOGO.Dock = System.Windows.Forms.DockStyle.Top
        Me._IMSS_DRIVER_LOGO.Image = CType(resources.GetObject("_IMSS_DRIVER_LOGO.Image"), System.Drawing.Image)
        Me._IMSS_DRIVER_LOGO.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_DRIVER_LOGO.Name = "_IMSS_DRIVER_LOGO"
        Me._IMSS_DRIVER_LOGO.Size = New System.Drawing.Size(141, 95)
        Me._IMSS_DRIVER_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me._IMSS_DRIVER_LOGO.TabIndex = 0
        Me._IMSS_DRIVER_LOGO.TabStop = False
        '
        '_IMSS_USB_TITLE
        '
        Me._IMSS_USB_TITLE.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_USB_TITLE.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_USB_TITLE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me._IMSS_USB_TITLE.Location = New System.Drawing.Point(0, 95)
        Me._IMSS_USB_TITLE.Name = "_IMSS_USB_TITLE"
        Me._IMSS_USB_TITLE.Size = New System.Drawing.Size(141, 27)
        Me._IMSS_USB_TITLE.TabIndex = 1
        Me._IMSS_USB_TITLE.Text = "Driver"
        Me._IMSS_USB_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me._IMSS_SECURE_PictureBox)
        Me.Panel1.Controls.Add(Me._IMSS_USB_TITLE)
        Me.Panel1.Controls.Add(Me._IMSS_DRIVER_LOGO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 122)
        Me.Panel1.TabIndex = 2
        '
        '_IMSS_SECURE_PictureBox
        '
        Me._IMSS_SECURE_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_SECURE_PictureBox.Image = CType(resources.GetObject("_IMSS_SECURE_PictureBox.Image"), System.Drawing.Image)
        Me._IMSS_SECURE_PictureBox.Location = New System.Drawing.Point(121, 1)
        Me._IMSS_SECURE_PictureBox.Name = "_IMSS_SECURE_PictureBox"
        Me._IMSS_SECURE_PictureBox.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_SECURE_PictureBox.TabIndex = 2
        Me._IMSS_SECURE_PictureBox.TabStop = False
        Me._IMSS_SECURE_PictureBox.Visible = False
        '
        'IMSS_USB_DVICE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "IMSS_USB_DVICE"
        Me.Size = New System.Drawing.Size(141, 122)
        CType(Me._IMSS_DRIVER_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me._IMSS_SECURE_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_DRIVER_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_USB_TITLE As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_SECURE_PictureBox As System.Windows.Forms.PictureBox

End Class
