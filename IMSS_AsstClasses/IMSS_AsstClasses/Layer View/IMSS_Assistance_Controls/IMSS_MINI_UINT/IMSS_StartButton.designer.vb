<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_StartButton
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_StartButton))
        Me._IMSS_Start_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_IMSS_Start_Button
        '
        Me._IMSS_Start_Button.BackColor = System.Drawing.SystemColors.Control
        Me._IMSS_Start_Button.BackgroundImage = Global.IMSS_AsstClasses.My.Resources.Resources.IMSS_StartButtonOnMouseStand
        Me._IMSS_Start_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_Start_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_Start_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._IMSS_Start_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._IMSS_Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_Start_Button.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me._IMSS_Start_Button.ForeColor = System.Drawing.Color.DimGray
        Me._IMSS_Start_Button.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_Start_Button.Name = "_IMSS_Start_Button"
        Me._IMSS_Start_Button.Size = New System.Drawing.Size(73, 27)
        Me._IMSS_Start_Button.TabIndex = 0
        Me._IMSS_Start_Button.Text = "Start"
        Me._IMSS_Start_Button.UseVisualStyleBackColor = False
        '
        'IMSS_StartButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me._IMSS_Start_Button)
        Me.Name = "IMSS_StartButton"
        Me.Size = New System.Drawing.Size(73, 27)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_Start_Button As System.Windows.Forms.Button

End Class
