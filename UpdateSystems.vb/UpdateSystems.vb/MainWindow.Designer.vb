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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._IMSS_EXIT_PICTUREBOX = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_UPDATE_USERCONTROL = New UpdateSystems.UpdateUserControl()
        Me.Panel1.SuspendLayout()
        CType(Me._IMSS_EXIT_PICTUREBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me._IMSS_EXIT_PICTUREBOX)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 36)
        Me.Panel1.TabIndex = 0
        '
        '_IMSS_EXIT_PICTUREBOX
        '
        Me._IMSS_EXIT_PICTUREBOX.Image = CType(resources.GetObject("_IMSS_EXIT_PICTUREBOX.Image"), System.Drawing.Image)
        Me._IMSS_EXIT_PICTUREBOX.Location = New System.Drawing.Point(437, 6)
        Me._IMSS_EXIT_PICTUREBOX.Name = "_IMSS_EXIT_PICTUREBOX"
        Me._IMSS_EXIT_PICTUREBOX.Size = New System.Drawing.Size(34, 24)
        Me._IMSS_EXIT_PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_EXIT_PICTUREBOX.TabIndex = 1
        Me._IMSS_EXIT_PICTUREBOX.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A New update available"
        '
        '_IMSS_UPDATE_USERCONTROL
        '
        Me._IMSS_UPDATE_USERCONTROL._IMSS_UPDATE_ASMBLE_URL = ""
        Me._IMSS_UPDATE_USERCONTROL.Location = New System.Drawing.Point(0, 54)
        Me._IMSS_UPDATE_USERCONTROL.Name = "_IMSS_UPDATE_USERCONTROL"
        Me._IMSS_UPDATE_USERCONTROL.Size = New System.Drawing.Size(477, 295)
        Me._IMSS_UPDATE_USERCONTROL.TabIndex = 1
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me._IMSS_UPDATE_USERCONTROL)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "_IMSS_DateConfigFile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._IMSS_EXIT_PICTUREBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_UPDATE_USERCONTROL As UpdateSystems.UpdateUserControl
    Friend WithEvents _IMSS_EXIT_PICTUREBOX As System.Windows.Forms.PictureBox
End Class
