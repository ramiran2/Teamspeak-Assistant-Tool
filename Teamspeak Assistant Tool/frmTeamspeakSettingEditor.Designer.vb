<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeamspeakSettingEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTeamspeakSettingEditor))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDNSSettings = New System.Windows.Forms.Label()
        Me.lblChecked = New System.Windows.Forms.Label()
        Me.lblAccess = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtDNSSettings = New System.Windows.Forms.TextBox()
        Me.txtChecked = New System.Windows.Forms.TextBox()
        Me.txtAccess = New System.Windows.Forms.TextBox()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.btnOpenDiagnostics = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnResetSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(12, 15)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 47)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 77)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time:"
        '
        'lblDNSSettings
        '
        Me.lblDNSSettings.AutoSize = True
        Me.lblDNSSettings.Location = New System.Drawing.Point(12, 110)
        Me.lblDNSSettings.Name = "lblDNSSettings"
        Me.lblDNSSettings.Size = New System.Drawing.Size(71, 13)
        Me.lblDNSSettings.TabIndex = 3
        Me.lblDNSSettings.Text = "DNSSettings:"
        '
        'lblChecked
        '
        Me.lblChecked.AutoSize = True
        Me.lblChecked.Location = New System.Drawing.Point(12, 142)
        Me.lblChecked.Name = "lblChecked"
        Me.lblChecked.Size = New System.Drawing.Size(53, 13)
        Me.lblChecked.TabIndex = 4
        Me.lblChecked.Text = "Checked:"
        '
        'lblAccess
        '
        Me.lblAccess.AutoSize = True
        Me.lblAccess.Location = New System.Drawing.Point(12, 174)
        Me.lblAccess.Name = "lblAccess"
        Me.lblAccess.Size = New System.Drawing.Size(45, 13)
        Me.lblAccess.TabIndex = 5
        Me.lblAccess.Text = "Access:"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(12, 206)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(46, 13)
        Me.lblService.TabIndex = 6
        Me.lblService.Text = "Service:"
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Location = New System.Drawing.Point(12, 237)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(49, 13)
        Me.lblProgram.TabIndex = 7
        Me.lblProgram.Text = "Program:"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(12, 271)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(32, 13)
        Me.lblStart.TabIndex = 8
        Me.lblStart.Text = "Start:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(76, 12)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(327, 20)
        Me.txtUsername.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(74, 44)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(329, 20)
        Me.txtPassword.TabIndex = 10
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(51, 74)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(352, 20)
        Me.txtTime.TabIndex = 11
        '
        'txtDNSSettings
        '
        Me.txtDNSSettings.Location = New System.Drawing.Point(89, 107)
        Me.txtDNSSettings.Name = "txtDNSSettings"
        Me.txtDNSSettings.Size = New System.Drawing.Size(314, 20)
        Me.txtDNSSettings.TabIndex = 12
        '
        'txtChecked
        '
        Me.txtChecked.Location = New System.Drawing.Point(71, 139)
        Me.txtChecked.Name = "txtChecked"
        Me.txtChecked.Size = New System.Drawing.Size(332, 20)
        Me.txtChecked.TabIndex = 13
        '
        'txtAccess
        '
        Me.txtAccess.Location = New System.Drawing.Point(63, 171)
        Me.txtAccess.Name = "txtAccess"
        Me.txtAccess.Size = New System.Drawing.Size(340, 20)
        Me.txtAccess.TabIndex = 14
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(64, 203)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(339, 20)
        Me.txtService.TabIndex = 15
        '
        'txtProgram
        '
        Me.txtProgram.Location = New System.Drawing.Point(67, 234)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(336, 20)
        Me.txtProgram.TabIndex = 16
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(50, 268)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(353, 20)
        Me.txtStart.TabIndex = 17
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(245, 309)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(81, 23)
        Me.btnSaveSettings.TabIndex = 18
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'btnOpenDiagnostics
        '
        Me.btnOpenDiagnostics.Location = New System.Drawing.Point(12, 309)
        Me.btnOpenDiagnostics.Name = "btnOpenDiagnostics"
        Me.btnOpenDiagnostics.Size = New System.Drawing.Size(136, 23)
        Me.btnOpenDiagnostics.TabIndex = 19
        Me.btnOpenDiagnostics.Text = "Open Diagnostics Viewer"
        Me.btnOpenDiagnostics.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(332, 309)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(71, 23)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnResetSettings
        '
        Me.btnResetSettings.Location = New System.Drawing.Point(154, 309)
        Me.btnResetSettings.Name = "btnResetSettings"
        Me.btnResetSettings.Size = New System.Drawing.Size(85, 23)
        Me.btnResetSettings.TabIndex = 21
        Me.btnResetSettings.Text = "Reset Settings"
        Me.btnResetSettings.UseVisualStyleBackColor = True
        '
        'frmTeamspeakSettingEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 344)
        Me.Controls.Add(Me.btnResetSettings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOpenDiagnostics)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.txtProgram)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.txtAccess)
        Me.Controls.Add(Me.txtChecked)
        Me.Controls.Add(Me.txtDNSSettings)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.lblAccess)
        Me.Controls.Add(Me.lblChecked)
        Me.Controls.Add(Me.lblDNSSettings)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTeamspeakSettingEditor"
        Me.Text = "xKiller Teamspeak Assistant Tool - Setting Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDNSSettings As Label
    Friend WithEvents lblChecked As Label
    Friend WithEvents lblAccess As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtDNSSettings As TextBox
    Friend WithEvents txtChecked As TextBox
    Friend WithEvents txtAccess As TextBox
    Friend WithEvents txtService As TextBox
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents txtStart As TextBox
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents btnOpenDiagnostics As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnResetSettings As Button
End Class
