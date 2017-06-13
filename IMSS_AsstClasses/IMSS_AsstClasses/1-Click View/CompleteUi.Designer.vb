<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompleteUi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompleteUi))
        Me._IMSS_HEADER_PANEL = New System.Windows.Forms.Panel()
        Me._IMSS_EXIT_LOGO = New System.Windows.Forms.PictureBox()
        Me._IMSS_TITLE_LABEL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_RESULT_LABEL = New System.Windows.Forms.Label()
        Me._IMSS_LOGO = New System.Windows.Forms.PictureBox()
        Me._IMSS_HEADER_PANEL.SuspendLayout()
        CType(Me._IMSS_EXIT_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_HEADER_PANEL
        '
        Me._IMSS_HEADER_PANEL.BackColor = System.Drawing.Color.RoyalBlue
        Me._IMSS_HEADER_PANEL.Controls.Add(Me._IMSS_EXIT_LOGO)
        Me._IMSS_HEADER_PANEL.Controls.Add(Me._IMSS_TITLE_LABEL)
        Me._IMSS_HEADER_PANEL.Location = New System.Drawing.Point(-2, 13)
        Me._IMSS_HEADER_PANEL.Name = "_IMSS_HEADER_PANEL"
        Me._IMSS_HEADER_PANEL.Size = New System.Drawing.Size(375, 31)
        Me._IMSS_HEADER_PANEL.TabIndex = 0
        '
        '_IMSS_EXIT_LOGO
        '
        Me._IMSS_EXIT_LOGO.Image = CType(resources.GetObject("_IMSS_EXIT_LOGO.Image"), System.Drawing.Image)
        Me._IMSS_EXIT_LOGO.Location = New System.Drawing.Point(338, 5)
        Me._IMSS_EXIT_LOGO.Name = "_IMSS_EXIT_LOGO"
        Me._IMSS_EXIT_LOGO.Size = New System.Drawing.Size(30, 20)
        Me._IMSS_EXIT_LOGO.TabIndex = 1
        Me._IMSS_EXIT_LOGO.TabStop = False
        '
        '_IMSS_TITLE_LABEL
        '
        Me._IMSS_TITLE_LABEL.AutoSize = True
        Me._IMSS_TITLE_LABEL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TITLE_LABEL.ForeColor = System.Drawing.Color.White
        Me._IMSS_TITLE_LABEL.Location = New System.Drawing.Point(7, 7)
        Me._IMSS_TITLE_LABEL.Name = "_IMSS_TITLE_LABEL"
        Me._IMSS_TITLE_LABEL.Size = New System.Drawing.Size(240, 16)
        Me._IMSS_TITLE_LABEL.TabIndex = 0
        Me._IMSS_TITLE_LABEL.Text = "Maintenance completed successfully"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(78, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "All selected clean processes was completed successfully."
        '
        '_IMSS_RESULT_LABEL
        '
        Me._IMSS_RESULT_LABEL.AutoSize = True
        Me._IMSS_RESULT_LABEL.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_RESULT_LABEL.ForeColor = System.Drawing.Color.Green
        Me._IMSS_RESULT_LABEL.Location = New System.Drawing.Point(80, 86)
        Me._IMSS_RESULT_LABEL.Name = "_IMSS_RESULT_LABEL"
        Me._IMSS_RESULT_LABEL.Size = New System.Drawing.Size(189, 21)
        Me._IMSS_RESULT_LABEL.TabIndex = 3
        Me._IMSS_RESULT_LABEL.Text = "16 - Problem was fixed"
        '
        '_IMSS_LOGO
        '
        Me._IMSS_LOGO.Image = Global.IMSS_AsstClasses.My.Resources.Resources._IMSS_Complete_Icon
        Me._IMSS_LOGO.Location = New System.Drawing.Point(8, 56)
        Me._IMSS_LOGO.Name = "_IMSS_LOGO"
        Me._IMSS_LOGO.Size = New System.Drawing.Size(64, 64)
        Me._IMSS_LOGO.TabIndex = 1
        Me._IMSS_LOGO.TabStop = False
        '
        'CompleteUi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 134)
        Me.ControlBox = False
        Me.Controls.Add(Me._IMSS_RESULT_LABEL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._IMSS_LOGO)
        Me.Controls.Add(Me._IMSS_HEADER_PANEL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CompleteUi"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me._IMSS_HEADER_PANEL.ResumeLayout(False)
        Me._IMSS_HEADER_PANEL.PerformLayout()
        CType(Me._IMSS_EXIT_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_HEADER_PANEL As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_TITLE_LABEL As System.Windows.Forms.Label
    Friend WithEvents _IMSS_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_RESULT_LABEL As System.Windows.Forms.Label
    Friend WithEvents _IMSS_EXIT_LOGO As System.Windows.Forms.PictureBox
End Class
