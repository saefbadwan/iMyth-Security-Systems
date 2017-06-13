<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Update))
        Me._UPdatePanel = New System.Windows.Forms.Panel()
        Me._IMSS_InterNetConnectionErrors = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me._IMSS_UpdateingBrowserWorker = New System.ComponentModel.BackgroundWorker()
        Me._IMSS_InterNetWorker = New System.ComponentModel.BackgroundWorker()
        Me._UPdatePanel.SuspendLayout()
        Me._IMSS_InterNetConnectionErrors.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_UPdatePanel
        '
        Me._UPdatePanel.Controls.Add(Me._IMSS_InterNetConnectionErrors)
        Me._UPdatePanel.Controls.Add(Me.Label31)
        Me._UPdatePanel.Controls.Add(Me.WebBrowser1)
        Me._UPdatePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._UPdatePanel.Location = New System.Drawing.Point(0, 0)
        Me._UPdatePanel.Name = "_UPdatePanel"
        Me._UPdatePanel.Size = New System.Drawing.Size(829, 390)
        Me._UPdatePanel.TabIndex = 47
        '
        '_IMSS_InterNetConnectionErrors
        '
        Me._IMSS_InterNetConnectionErrors.BackColor = System.Drawing.Color.White
        Me._IMSS_InterNetConnectionErrors.Controls.Add(Me.Label1)
        Me._IMSS_InterNetConnectionErrors.Controls.Add(Me.PictureBox2)
        Me._IMSS_InterNetConnectionErrors.Location = New System.Drawing.Point(244, 151)
        Me._IMSS_InterNetConnectionErrors.Name = "_IMSS_InterNetConnectionErrors"
        Me._IMSS_InterNetConnectionErrors.Size = New System.Drawing.Size(326, 54)
        Me._IMSS_InterNetConnectionErrors.TabIndex = 2
        Me._IMSS_InterNetConnectionErrors.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please check your internet connection !"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(134, 178)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(0, 13)
        Me.Label31.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(829, 390)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        '_IMSS_UpdateingBrowserWorker
        '
        Me._IMSS_UpdateingBrowserWorker.WorkerReportsProgress = True
        Me._IMSS_UpdateingBrowserWorker.WorkerSupportsCancellation = True
        '
        '_IMSS_InterNetWorker
        '
        Me._IMSS_InterNetWorker.WorkerReportsProgress = True
        Me._IMSS_InterNetWorker.WorkerSupportsCancellation = True
        '
        'IMSS_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._UPdatePanel)
        Me.Name = "IMSS_Update"
        Me.Size = New System.Drawing.Size(829, 390)
        Me._UPdatePanel.ResumeLayout(False)
        Me._UPdatePanel.PerformLayout()
        Me._IMSS_InterNetConnectionErrors.ResumeLayout(False)
        Me._IMSS_InterNetConnectionErrors.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _UPdatePanel As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_InterNetConnectionErrors As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents _IMSS_UpdateingBrowserWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents _IMSS_InterNetWorker As System.ComponentModel.BackgroundWorker

End Class
