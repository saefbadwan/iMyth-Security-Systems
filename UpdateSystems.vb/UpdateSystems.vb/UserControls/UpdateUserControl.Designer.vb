<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateUserControl))
        Me.Label2 = New System.Windows.Forms.Label()
        Me._IMSS_REMINMELATER_BUTT = New System.Windows.Forms.Button()
        Me._IMSS_UPDATE_BUTT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX = New System.Windows.Forms.PictureBox()
        Me._IMSS_LOADING_PICTUREBOX = New System.Windows.Forms.PictureBox()
        Me._IMSS_UPDATE_SIZE_LABEL = New System.Windows.Forms.Label()
        Me._IMSS_UPDATE_VERSION_LABEL = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._IMSS_CONTROL_HOLDER_PANEL = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me._IMSS_CANCEL = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me._IMSS_DownloadSpeed_Label = New System.Windows.Forms.Label()
        Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL = New System.Windows.Forms.Label()
        Me._IMSS_Stages_Label = New System.Windows.Forms.Label()
        Me._IMSS_PROGRESS = New System.Windows.Forms.ProgressBar()
        Me.Panel2.SuspendLayout()
        CType(Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_LOADING_PICTUREBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_CONTROL_HOLDER_PANEL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Copyright © iMyth Labs"
        '
        '_IMSS_REMINMELATER_BUTT
        '
        Me._IMSS_REMINMELATER_BUTT.Location = New System.Drawing.Point(256, 131)
        Me._IMSS_REMINMELATER_BUTT.Name = "_IMSS_REMINMELATER_BUTT"
        Me._IMSS_REMINMELATER_BUTT.Size = New System.Drawing.Size(117, 23)
        Me._IMSS_REMINMELATER_BUTT.TabIndex = 7
        Me._IMSS_REMINMELATER_BUTT.Text = "Remind me later ..."
        Me._IMSS_REMINMELATER_BUTT.UseVisualStyleBackColor = True
        '
        '_IMSS_UPDATE_BUTT
        '
        Me._IMSS_UPDATE_BUTT.Location = New System.Drawing.Point(379, 131)
        Me._IMSS_UPDATE_BUTT.Name = "_IMSS_UPDATE_BUTT"
        Me._IMSS_UPDATE_BUTT.Size = New System.Drawing.Size(78, 23)
        Me._IMSS_UPDATE_BUTT.TabIndex = 6
        Me._IMSS_UPDATE_BUTT.Text = "Update now"
        Me._IMSS_UPDATE_BUTT.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX)
        Me.Panel2.Controls.Add(Me._IMSS_LOADING_PICTUREBOX)
        Me.Panel2.Controls.Add(Me._IMSS_UPDATE_SIZE_LABEL)
        Me.Panel2.Controls.Add(Me._IMSS_UPDATE_VERSION_LABEL)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(17, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 116)
        Me.Panel2.TabIndex = 5
        '
        '_IMSS_UPDATE_VERSION_LOADING_PICUTERBOX
        '
        Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX.Image = Global.UpdateSystems.My.Resources.Resources._IMSS_LoadimgGif_Icon
        Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX.Location = New System.Drawing.Point(200, 49)
        Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX.Name = "_IMSS_UPDATE_VERSION_LOADING_PICUTERBOX"
        Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX.TabIndex = 5
        Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX.TabStop = False
        '
        '_IMSS_LOADING_PICTUREBOX
        '
        Me._IMSS_LOADING_PICTUREBOX.Image = Global.UpdateSystems.My.Resources.Resources._IMSS_LoadimgGif_Icon
        Me._IMSS_LOADING_PICTUREBOX.Location = New System.Drawing.Point(178, 74)
        Me._IMSS_LOADING_PICTUREBOX.Name = "_IMSS_LOADING_PICTUREBOX"
        Me._IMSS_LOADING_PICTUREBOX.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_LOADING_PICTUREBOX.TabIndex = 4
        Me._IMSS_LOADING_PICTUREBOX.TabStop = False
        '
        '_IMSS_UPDATE_SIZE_LABEL
        '
        Me._IMSS_UPDATE_SIZE_LABEL.AutoSize = True
        Me._IMSS_UPDATE_SIZE_LABEL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_UPDATE_SIZE_LABEL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_UPDATE_SIZE_LABEL.Location = New System.Drawing.Point(91, 74)
        Me._IMSS_UPDATE_SIZE_LABEL.Name = "_IMSS_UPDATE_SIZE_LABEL"
        Me._IMSS_UPDATE_SIZE_LABEL.Size = New System.Drawing.Size(80, 15)
        Me._IMSS_UPDATE_SIZE_LABEL.TabIndex = 3
        Me._IMSS_UPDATE_SIZE_LABEL.Text = "Update Size :"
        '
        '_IMSS_UPDATE_VERSION_LABEL
        '
        Me._IMSS_UPDATE_VERSION_LABEL.AutoSize = True
        Me._IMSS_UPDATE_VERSION_LABEL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_UPDATE_VERSION_LABEL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_UPDATE_VERSION_LABEL.Location = New System.Drawing.Point(92, 49)
        Me._IMSS_UPDATE_VERSION_LABEL.Name = "_IMSS_UPDATE_VERSION_LABEL"
        Me._IMSS_UPDATE_VERSION_LABEL.Size = New System.Drawing.Size(102, 15)
        Me._IMSS_UPDATE_VERSION_LABEL.TabIndex = 2
        Me._IMSS_UPDATE_VERSION_LABEL.Text = "Update Version : "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(428, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dolore" & _
            "mque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis." & _
            ""
        '
        '_IMSS_CONTROL_HOLDER_PANEL
        '
        Me._IMSS_CONTROL_HOLDER_PANEL.Controls.Add(Me.Label5)
        Me._IMSS_CONTROL_HOLDER_PANEL.Controls.Add(Me._IMSS_CANCEL)
        Me._IMSS_CONTROL_HOLDER_PANEL.Controls.Add(Me.Panel1)
        Me._IMSS_CONTROL_HOLDER_PANEL.Controls.Add(Me.Panel2)
        Me._IMSS_CONTROL_HOLDER_PANEL.Controls.Add(Me.Label2)
        Me._IMSS_CONTROL_HOLDER_PANEL.Controls.Add(Me._IMSS_UPDATE_BUTT)
        Me._IMSS_CONTROL_HOLDER_PANEL.Controls.Add(Me._IMSS_REMINMELATER_BUTT)
        Me._IMSS_CONTROL_HOLDER_PANEL.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_CONTROL_HOLDER_PANEL.Name = "_IMSS_CONTROL_HOLDER_PANEL"
        Me._IMSS_CONTROL_HOLDER_PANEL.Size = New System.Drawing.Size(474, 323)
        Me._IMSS_CONTROL_HOLDER_PANEL.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(18, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Copyright © iMyth Labs"
        '
        '_IMSS_CANCEL
        '
        Me._IMSS_CANCEL.Location = New System.Drawing.Point(379, 287)
        Me._IMSS_CANCEL.Name = "_IMSS_CANCEL"
        Me._IMSS_CANCEL.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_CANCEL.TabIndex = 10
        Me._IMSS_CANCEL.Text = "Cancel"
        Me._IMSS_CANCEL.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me._IMSS_DownloadSpeed_Label)
        Me.Panel1.Controls.Add(Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL)
        Me.Panel1.Controls.Add(Me._IMSS_Stages_Label)
        Me.Panel1.Controls.Add(Me._IMSS_PROGRESS)
        Me.Panel1.Location = New System.Drawing.Point(18, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 116)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(400, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        '_IMSS_DownloadSpeed_Label
        '
        Me._IMSS_DownloadSpeed_Label.AutoSize = True
        Me._IMSS_DownloadSpeed_Label.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_DownloadSpeed_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_DownloadSpeed_Label.Location = New System.Drawing.Point(306, 72)
        Me._IMSS_DownloadSpeed_Label.Name = "_IMSS_DownloadSpeed_Label"
        Me._IMSS_DownloadSpeed_Label.Size = New System.Drawing.Size(124, 14)
        Me._IMSS_DownloadSpeed_Label.TabIndex = 5
        Me._IMSS_DownloadSpeed_Label.Text = "Downloaded : 224 k/sec"
        '
        '_IMSS_DOWNLOAD_TOTAL_SIZE_LBL
        '
        Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL.AutoSize = True
        Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL.Location = New System.Drawing.Point(10, 72)
        Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL.Name = "_IMSS_DOWNLOAD_TOTAL_SIZE_LBL"
        Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL.Size = New System.Drawing.Size(134, 14)
        Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL.TabIndex = 4
        Me._IMSS_DOWNLOAD_TOTAL_SIZE_LBL.Text = "Download Size : 10.00 MB"
        '
        '_IMSS_Stages_Label
        '
        Me._IMSS_Stages_Label.AutoSize = True
        Me._IMSS_Stages_Label.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Stages_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_Stages_Label.Location = New System.Drawing.Point(7, 13)
        Me._IMSS_Stages_Label.Name = "_IMSS_Stages_Label"
        Me._IMSS_Stages_Label.Size = New System.Drawing.Size(183, 15)
        Me._IMSS_Stages_Label.TabIndex = 3
        Me._IMSS_Stages_Label.Text = "Stage : Downloading updates ..."
        '
        '_IMSS_PROGRESS
        '
        Me._IMSS_PROGRESS.Location = New System.Drawing.Point(8, 42)
        Me._IMSS_PROGRESS.Name = "_IMSS_PROGRESS"
        Me._IMSS_PROGRESS.Size = New System.Drawing.Size(424, 23)
        Me._IMSS_PROGRESS.TabIndex = 0
        '
        'UpdateUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_CONTROL_HOLDER_PANEL)
        Me.Name = "UpdateUserControl"
        Me.Size = New System.Drawing.Size(477, 326)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me._IMSS_UPDATE_VERSION_LOADING_PICUTERBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_LOADING_PICTUREBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_CONTROL_HOLDER_PANEL.ResumeLayout(False)
        Me._IMSS_CONTROL_HOLDER_PANEL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_REMINMELATER_BUTT As System.Windows.Forms.Button
    Friend WithEvents _IMSS_UPDATE_BUTT As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_CONTROL_HOLDER_PANEL As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_UPDATE_SIZE_LABEL As System.Windows.Forms.Label
    Friend WithEvents _IMSS_UPDATE_VERSION_LABEL As System.Windows.Forms.Label
    Friend WithEvents _IMSS_CANCEL As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_Stages_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_PROGRESS As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_DownloadSpeed_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_DOWNLOAD_TOTAL_SIZE_LBL As System.Windows.Forms.Label
    Friend WithEvents _IMSS_LOADING_PICTUREBOX As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_UPDATE_VERSION_LOADING_PICUTERBOX As System.Windows.Forms.PictureBox

End Class
