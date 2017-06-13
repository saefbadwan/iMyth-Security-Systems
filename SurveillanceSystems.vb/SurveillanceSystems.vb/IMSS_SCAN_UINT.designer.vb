<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SCAN_UINT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_SCAN_UINT))
        Me._IMSS_MainWebBrowser = New System.Windows.Forms.WebBrowser()
        Me._IMSS_LoadingPanel = New System.Windows.Forms.Panel()
        Me._IMSS_LoadingLabel = New System.Windows.Forms.Label()
        Me._IMSS_LoadingImage = New System.Windows.Forms.PictureBox()
        Me._IMSS_LoadingPanel.SuspendLayout()
        CType(Me._IMSS_LoadingImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainWebBrowser
        '
        Me._IMSS_MainWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainWebBrowser.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me._IMSS_MainWebBrowser.Name = "_IMSS_MainWebBrowser"
        Me._IMSS_MainWebBrowser.Size = New System.Drawing.Size(1163, 515)
        Me._IMSS_MainWebBrowser.TabIndex = 1
        '
        '_IMSS_LoadingPanel
        '
        Me._IMSS_LoadingPanel.BackColor = System.Drawing.Color.White
        Me._IMSS_LoadingPanel.Controls.Add(Me._IMSS_LoadingLabel)
        Me._IMSS_LoadingPanel.Controls.Add(Me._IMSS_LoadingImage)
        Me._IMSS_LoadingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_LoadingPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_LoadingPanel.Name = "_IMSS_LoadingPanel"
        Me._IMSS_LoadingPanel.Size = New System.Drawing.Size(1163, 515)
        Me._IMSS_LoadingPanel.TabIndex = 2
        '
        '_IMSS_LoadingLabel
        '
        Me._IMSS_LoadingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_LoadingLabel.AutoSize = True
        Me._IMSS_LoadingLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LoadingLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me._IMSS_LoadingLabel.Location = New System.Drawing.Point(521, 278)
        Me._IMSS_LoadingLabel.Name = "_IMSS_LoadingLabel"
        Me._IMSS_LoadingLabel.Size = New System.Drawing.Size(136, 16)
        Me._IMSS_LoadingLabel.TabIndex = 3
        Me._IMSS_LoadingLabel.Text = "Uploading File ..."
        '
        '_IMSS_LoadingImage
        '
        Me._IMSS_LoadingImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_LoadingImage.BackColor = System.Drawing.Color.White
        Me._IMSS_LoadingImage.Image = Global.SurveillanceSystems.My.Resources.Resources._IMSS_ProcessesManager_Loading_Icon_400x50
        Me._IMSS_LoadingImage.Location = New System.Drawing.Point(381, 221)
        Me._IMSS_LoadingImage.Name = "_IMSS_LoadingImage"
        Me._IMSS_LoadingImage.Size = New System.Drawing.Size(400, 50)
        Me._IMSS_LoadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_LoadingImage.TabIndex = 2
        Me._IMSS_LoadingImage.TabStop = False
        '
        'IMSS_SCAN_UINT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 515)
        Me.Controls.Add(Me._IMSS_LoadingPanel)
        Me.Controls.Add(Me._IMSS_MainWebBrowser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IMSS_SCAN_UINT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Online scan"
        Me._IMSS_LoadingPanel.ResumeLayout(False)
        Me._IMSS_LoadingPanel.PerformLayout()
        CType(Me._IMSS_LoadingImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainWebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents _IMSS_LoadingPanel As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_LoadingImage As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_LoadingLabel As System.Windows.Forms.Label
End Class
