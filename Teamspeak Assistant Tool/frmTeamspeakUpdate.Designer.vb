<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeamspeakUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTeamspeakUpdate))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.prbTeamspeak = New System.Windows.Forms.ProgressBar()
        Me.picStatus = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.tmrTeamspeak = New System.Windows.Forms.Timer(Me.components)
        Me.bgwTeamspeak = New System.ComponentModel.BackgroundWorker()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(199, 36)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 13)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Not Available"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(301, 111)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Check for Updates"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(417, 111)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'prbTeamspeak
        '
        Me.prbTeamspeak.Location = New System.Drawing.Point(133, 82)
        Me.prbTeamspeak.Name = "prbTeamspeak"
        Me.prbTeamspeak.Size = New System.Drawing.Size(360, 23)
        Me.prbTeamspeak.TabIndex = 6
        '
        'picStatus
        '
        Me.picStatus.Location = New System.Drawing.Point(133, 12)
        Me.picStatus.Name = "picStatus"
        Me.picStatus.Size = New System.Drawing.Size(60, 64)
        Me.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStatus.TabIndex = 1
        Me.picStatus.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.xKiller_Teamspeak_Assistant_Tool.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(115, 122)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'tmrTeamspeak
        '
        '
        'bgwTeamspeak
        '
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(201, 113)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(94, 20)
        Me.txtInput.TabIndex = 7
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(133, 116)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(62, 13)
        Me.lblInfo.TabIndex = 8
        Me.lblInfo.Text = "Input Code:"
        '
        'frmTeamspeakUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 146)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.prbTeamspeak)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.picStatus)
        Me.Controls.Add(Me.picLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTeamspeakUpdate"
        Me.Text = "xKiller Teamspeak Assistant Tool - Updater"
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
	Friend WithEvents picStatus As PictureBox
	Friend WithEvents lblStatus As Label
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents prbTeamspeak As ProgressBar
	Friend WithEvents tmrTeamspeak As Timer
	Friend WithEvents bgwTeamspeak As System.ComponentModel.BackgroundWorker
	Friend WithEvents txtInput As TextBox
    Friend WithEvents lblInfo As Label
End Class
