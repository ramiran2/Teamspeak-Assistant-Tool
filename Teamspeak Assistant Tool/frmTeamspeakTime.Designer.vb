<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeamspeakTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTeamspeakTime))
        Me.btnTime = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblInfoTime = New System.Windows.Forms.Label()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.picTime = New System.Windows.Forms.PictureBox()
        CType(Me.picTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTime
        '
        Me.btnTime.Location = New System.Drawing.Point(204, 64)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(111, 23)
        Me.btnTime.TabIndex = 1
        Me.btnTime.Text = "Change Time"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(321, 64)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblInfoTime
        '
        Me.lblInfoTime.AutoSize = True
        Me.lblInfoTime.Location = New System.Drawing.Point(91, 34)
        Me.lblInfoTime.Name = "lblInfoTime"
        Me.lblInfoTime.Size = New System.Drawing.Size(106, 13)
        Me.lblInfoTime.TabIndex = 3
        Me.lblInfoTime.Text = "Input time in minutes:"
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(204, 31)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(213, 20)
        Me.txtMinutes.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(91, 69)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 13)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Not Available"
        '
        'picTime
        '
        Me.picTime.Image = Global.xKiller_Teamspeak_Assistant_Tool.My.Resources.Resources.icon_time
        Me.picTime.Location = New System.Drawing.Point(12, 12)
        Me.picTime.Name = "picTime"
        Me.picTime.Size = New System.Drawing.Size(73, 75)
        Me.picTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTime.TabIndex = 0
        Me.picTime.TabStop = False
        '
        'frmTeamspeakTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 99)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.lblInfoTime)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.picTime)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTeamspeakTime"
        Me.Text = "xKiller Teamspeak Assistant Tool - Change Time Interval"
        CType(Me.picTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTime As PictureBox
	Friend WithEvents btnTime As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents lblInfoTime As Label
	Friend WithEvents txtMinutes As TextBox
	Friend WithEvents lblStatus As Label
End Class
