<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _IMSS_USBC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_IMSS_USBC))
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonreadwrite = New System.Windows.Forms.RadioButton()
        Me.RadioButtonreadonly = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtondisable = New System.Windows.Forms.RadioButton()
        Me.RadioButtonenable = New System.Windows.Forms.RadioButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me._Button_Icon = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox8.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox8.TabIndex = 69
        Me.PictureBox8.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "USB Configure"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.label1)
        Me.Panel4.Location = New System.Drawing.Point(12, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(362, 178)
        Me.Panel4.TabIndex = 66
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonreadwrite)
        Me.GroupBox2.Controls.Add(Me.RadioButtonreadonly)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 61)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Read/Write"
        '
        'RadioButtonreadwrite
        '
        Me.RadioButtonreadwrite.AutoSize = True
        Me.RadioButtonreadwrite.Location = New System.Drawing.Point(17, 46)
        Me.RadioButtonreadwrite.Name = "RadioButtonreadwrite"
        Me.RadioButtonreadwrite.Size = New System.Drawing.Size(222, 17)
        Me.RadioButtonreadwrite.TabIndex = 3
        Me.RadioButtonreadwrite.TabStop = True
        Me.RadioButtonreadwrite.Text = "Make a removable drive a read And write"
        Me.RadioButtonreadwrite.UseVisualStyleBackColor = True
        '
        'RadioButtonreadonly
        '
        Me.RadioButtonreadonly.AutoSize = True
        Me.RadioButtonreadonly.Location = New System.Drawing.Point(17, 23)
        Me.RadioButtonreadonly.Name = "RadioButtonreadonly"
        Me.RadioButtonreadonly.Size = New System.Drawing.Size(197, 17)
        Me.RadioButtonreadonly.TabIndex = 2
        Me.RadioButtonreadonly.TabStop = True
        Me.RadioButtonreadonly.Text = "Make a removable drive a read-only"
        Me.RadioButtonreadonly.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtondisable)
        Me.GroupBox1.Controls.Add(Me.RadioButtonenable)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 75)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disable/Enable"
        '
        'RadioButtondisable
        '
        Me.RadioButtondisable.AutoSize = True
        Me.RadioButtondisable.Location = New System.Drawing.Point(25, 48)
        Me.RadioButtondisable.Name = "RadioButtondisable"
        Me.RadioButtondisable.Size = New System.Drawing.Size(136, 17)
        Me.RadioButtondisable.TabIndex = 1
        Me.RadioButtondisable.TabStop = True
        Me.RadioButtondisable.Text = "Disable The Use of USB"
        Me.RadioButtondisable.UseVisualStyleBackColor = True
        '
        'RadioButtonenable
        '
        Me.RadioButtonenable.AutoSize = True
        Me.RadioButtonenable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButtonenable.ImageKey = "(none)"
        Me.RadioButtonenable.Location = New System.Drawing.Point(25, 25)
        Me.RadioButtonenable.Name = "RadioButtonenable"
        Me.RadioButtonenable.Size = New System.Drawing.Size(134, 17)
        Me.RadioButtonenable.TabIndex = 0
        Me.RadioButtonenable.TabStop = True
        Me.RadioButtonenable.Text = "Enable The Use of USB"
        Me.RadioButtonenable.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(3, 1)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(362, 35)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Remove the Usb device and re-insert it after pressing Save."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageKey = "Save.png"
        Me.Button2.ImageList = Me._Button_Icon
        Me.Button2.Location = New System.Drawing.Point(181, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 28)
        Me.Button2.TabIndex = 61
        Me.Button2.Tag = ""
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        '_Button_Icon
        '
        Me._Button_Icon.ImageStream = CType(resources.GetObject("_Button_Icon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._Button_Icon.TransparentColor = System.Drawing.Color.Transparent
        Me._Button_Icon.Images.SetKeyName(0, "delete.png")
        Me._Button_Icon.Images.SetKeyName(1, "Save.png")
        Me._Button_Icon.Images.SetKeyName(2, "arrow-12-512.gif")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Location = New System.Drawing.Point(0, 245)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(317, 10)
        Me.Panel3.TabIndex = 65
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageKey = "arrow-12-512.gif"
        Me.Button1.ImageList = Me._Button_Icon
        Me.Button1.Location = New System.Drawing.Point(317, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 59
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel12.Location = New System.Drawing.Point(0, -6)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(311, 10)
        Me.Panel12.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Location = New System.Drawing.Point(-6, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 203)
        Me.Panel1.TabIndex = 63
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Location = New System.Drawing.Point(388, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 203)
        Me.Panel2.TabIndex = 64
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button27.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.Color.Black
        Me.Button27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button27.ImageKey = "delete.png"
        Me.Button27.ImageList = Me._Button_Icon
        Me.Button27.Location = New System.Drawing.Point(279, 211)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(92, 28)
        Me.Button27.TabIndex = 60
        Me.Button27.Tag = ""
        Me.Button27.Text = "Close"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        '_IMSS_USBC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(376, 249)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button27)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(392, 265)
        Me.MinimizeBox = False
        Me.Name = "_IMSS_USBC"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtondisable As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonenable As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonreadwrite As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonreadonly As System.Windows.Forms.RadioButton
    Friend WithEvents _Button_Icon As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
