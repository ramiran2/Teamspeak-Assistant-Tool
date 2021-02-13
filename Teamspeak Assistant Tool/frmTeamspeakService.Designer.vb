<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeamspeakService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTeamspeakService))
        Me.lblCommand0 = New System.Windows.Forms.Label()
        Me.lblCommand1 = New System.Windows.Forms.Label()
        Me.lblCommand2 = New System.Windows.Forms.Label()
        Me.lblCommand3 = New System.Windows.Forms.Label()
        Me.lblFileLocation = New System.Windows.Forms.Label()
        Me.lblServiceName = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lstServices = New System.Windows.Forms.ListBox()
        Me.btnDeamonFile = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnProcessFile = New System.Windows.Forms.Button()
        Me.btnService = New System.Windows.Forms.Button()
        Me.btnUseBuiltInDeamon = New System.Windows.Forms.Button()
        Me.btnCmd = New System.Windows.Forms.Button()
        Me.btnCommands = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnDownloadDeamon = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.txtProcess = New System.Windows.Forms.TextBox()
        Me.txtDeamon = New System.Windows.Forms.TextBox()
        Me.ofdTeamspeak = New System.Windows.Forms.OpenFileDialog()
        Me.svcTeamspeak = New System.ServiceProcess.ServiceController()
        Me.txtCommand3 = New System.Windows.Forms.TextBox()
        Me.txtCommand2 = New System.Windows.Forms.TextBox()
        Me.txtCommand1 = New System.Windows.Forms.TextBox()
        Me.txtCommand0 = New System.Windows.Forms.TextBox()
        Me.rtxtInformation = New System.Windows.Forms.RichTextBox()
        Me.radService = New System.Windows.Forms.RadioButton()
        Me.radProcess = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblCommand0
        '
        Me.lblCommand0.AutoSize = True
        Me.lblCommand0.Location = New System.Drawing.Point(12, 152)
        Me.lblCommand0.Name = "lblCommand0"
        Me.lblCommand0.Size = New System.Drawing.Size(79, 13)
        Me.lblCommand0.TabIndex = 0
        Me.lblCommand0.Text = "First Command:"
        '
        'lblCommand1
        '
        Me.lblCommand1.AutoSize = True
        Me.lblCommand1.Location = New System.Drawing.Point(12, 178)
        Me.lblCommand1.Name = "lblCommand1"
        Me.lblCommand1.Size = New System.Drawing.Size(97, 13)
        Me.lblCommand1.TabIndex = 1
        Me.lblCommand1.Text = "Second Command:"
        '
        'lblCommand2
        '
        Me.lblCommand2.AutoSize = True
        Me.lblCommand2.Location = New System.Drawing.Point(12, 204)
        Me.lblCommand2.Name = "lblCommand2"
        Me.lblCommand2.Size = New System.Drawing.Size(84, 13)
        Me.lblCommand2.TabIndex = 2
        Me.lblCommand2.Text = "Third Command:"
        '
        'lblCommand3
        '
        Me.lblCommand3.AutoSize = True
        Me.lblCommand3.Location = New System.Drawing.Point(12, 230)
        Me.lblCommand3.Name = "lblCommand3"
        Me.lblCommand3.Size = New System.Drawing.Size(130, 13)
        Me.lblCommand3.TabIndex = 6
        Me.lblCommand3.Text = "Delete Service Command:"
        Me.lblCommand3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFileLocation
        '
        Me.lblFileLocation.AutoSize = True
        Me.lblFileLocation.Location = New System.Drawing.Point(12, 257)
        Me.lblFileLocation.Name = "lblFileLocation"
        Me.lblFileLocation.Size = New System.Drawing.Size(133, 13)
        Me.lblFileLocation.TabIndex = 8
        Me.lblFileLocation.Text = "Service Deamon Location:"
        Me.lblFileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServiceName
        '
        Me.lblServiceName.AutoSize = True
        Me.lblServiceName.Location = New System.Drawing.Point(12, 282)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(77, 13)
        Me.lblServiceName.TabIndex = 10
        Me.lblServiceName.Text = "Service Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Process Location:"
        '
        'lstServices
        '
        Me.lstServices.FormattingEnabled = True
        Me.lstServices.Location = New System.Drawing.Point(615, 12)
        Me.lstServices.Name = "lstServices"
        Me.lstServices.Size = New System.Drawing.Size(378, 316)
        Me.lstServices.TabIndex = 13
        '
        'btnDeamonFile
        '
        Me.btnDeamonFile.Location = New System.Drawing.Point(584, 253)
        Me.btnDeamonFile.Name = "btnDeamonFile"
        Me.btnDeamonFile.Size = New System.Drawing.Size(25, 20)
        Me.btnDeamonFile.TabIndex = 14
        Me.btnDeamonFile.Text = "..."
        Me.btnDeamonFile.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(527, 337)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 15
        Me.btnClean.Text = "Clear Data"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnProcessFile
        '
        Me.btnProcessFile.Location = New System.Drawing.Point(448, 305)
        Me.btnProcessFile.Name = "btnProcessFile"
        Me.btnProcessFile.Size = New System.Drawing.Size(25, 20)
        Me.btnProcessFile.TabIndex = 16
        Me.btnProcessFile.Text = "..."
        Me.btnProcessFile.UseVisualStyleBackColor = True
        '
        'btnService
        '
        Me.btnService.Location = New System.Drawing.Point(258, 337)
        Me.btnService.Name = "btnService"
        Me.btnService.Size = New System.Drawing.Size(120, 23)
        Me.btnService.TabIndex = 17
        Me.btnService.Text = "Update Service Name"
        Me.btnService.UseVisualStyleBackColor = True
        '
        'btnUseBuiltInDeamon
        '
        Me.btnUseBuiltInDeamon.Location = New System.Drawing.Point(761, 337)
        Me.btnUseBuiltInDeamon.Name = "btnUseBuiltInDeamon"
        Me.btnUseBuiltInDeamon.Size = New System.Drawing.Size(151, 23)
        Me.btnUseBuiltInDeamon.TabIndex = 18
        Me.btnUseBuiltInDeamon.Text = "Use Built-In Service Deamon"
        Me.btnUseBuiltInDeamon.UseVisualStyleBackColor = True
        '
        'btnCmd
        '
        Me.btnCmd.Location = New System.Drawing.Point(12, 337)
        Me.btnCmd.Name = "btnCmd"
        Me.btnCmd.Size = New System.Drawing.Size(127, 23)
        Me.btnCmd.TabIndex = 19
        Me.btnCmd.Text = "Open Command Prompt"
        Me.btnCmd.UseVisualStyleBackColor = True
        '
        'btnCommands
        '
        Me.btnCommands.Location = New System.Drawing.Point(145, 337)
        Me.btnCommands.Name = "btnCommands"
        Me.btnCommands.Size = New System.Drawing.Size(107, 23)
        Me.btnCommands.TabIndex = 20
        Me.btnCommands.Text = "Update Commands"
        Me.btnCommands.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(384, 337)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(137, 23)
        Me.btnProcess.TabIndex = 21
        Me.btnProcess.Text = "Update Process Location"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnDownloadDeamon
        '
        Me.btnDownloadDeamon.Location = New System.Drawing.Point(608, 337)
        Me.btnDownloadDeamon.Name = "btnDownloadDeamon"
        Me.btnDownloadDeamon.Size = New System.Drawing.Size(147, 23)
        Me.btnDownloadDeamon.TabIndex = 22
        Me.btnDownloadDeamon.Text = "Download Service Deamon"
        Me.btnDownloadDeamon.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(918, 337)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(95, 279)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(393, 20)
        Me.txtService.TabIndex = 24
        Me.txtService.Text = "Note: This is used so you can control your windows service"
        '
        'txtProcess
        '
        Me.txtProcess.Location = New System.Drawing.Point(110, 305)
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.Size = New System.Drawing.Size(332, 20)
        Me.txtProcess.TabIndex = 25
        Me.txtProcess.Text = "Note: This is used so you can control your windows application"
        '
        'txtDeamon
        '
        Me.txtDeamon.Location = New System.Drawing.Point(151, 253)
        Me.txtDeamon.Name = "txtDeamon"
        Me.txtDeamon.Size = New System.Drawing.Size(427, 20)
        Me.txtDeamon.TabIndex = 26
        Me.txtDeamon.Text = "Note: This is used to create your windows service"
        '
        'txtCommand3
        '
        Me.txtCommand3.Location = New System.Drawing.Point(148, 227)
        Me.txtCommand3.Name = "txtCommand3"
        Me.txtCommand3.ReadOnly = True
        Me.txtCommand3.Size = New System.Drawing.Size(461, 20)
        Me.txtCommand3.TabIndex = 30
        Me.txtCommand3.Text = "SC DELETE TeamspeakDDNS"
        '
        'txtCommand2
        '
        Me.txtCommand2.Location = New System.Drawing.Point(102, 201)
        Me.txtCommand2.Name = "txtCommand2"
        Me.txtCommand2.ReadOnly = True
        Me.txtCommand2.Size = New System.Drawing.Size(507, 20)
        Me.txtCommand2.TabIndex = 31
        Me.txtCommand2.Text = "SC CONFIG TeamspeakDDNS depend= Tcpip/Afd"
        '
        'txtCommand1
        '
        Me.txtCommand1.Location = New System.Drawing.Point(115, 175)
        Me.txtCommand1.Name = "txtCommand1"
        Me.txtCommand1.ReadOnly = True
        Me.txtCommand1.Size = New System.Drawing.Size(494, 20)
        Me.txtCommand1.TabIndex = 32
        Me.txtCommand1.Text = "SC DESCRIPTION TeamspeakDDNS ""Tells your teamspeak server what ip address goes to" &
    " what dns address."""
        '
        'txtCommand0
        '
        Me.txtCommand0.Location = New System.Drawing.Point(97, 149)
        Me.txtCommand0.Name = "txtCommand0"
        Me.txtCommand0.ReadOnly = True
        Me.txtCommand0.Size = New System.Drawing.Size(512, 20)
        Me.txtCommand0.TabIndex = 33
        Me.txtCommand0.Text = "Please Click Update Commands to get my Command"
        '
        'rtxtInformation
        '
        Me.rtxtInformation.BackColor = System.Drawing.Color.Black
        Me.rtxtInformation.ForeColor = System.Drawing.Color.White
        Me.rtxtInformation.Location = New System.Drawing.Point(12, 12)
        Me.rtxtInformation.Name = "rtxtInformation"
        Me.rtxtInformation.Size = New System.Drawing.Size(597, 131)
        Me.rtxtInformation.TabIndex = 35
        Me.rtxtInformation.Text = ""
        '
        'radService
        '
        Me.radService.AutoSize = True
        Me.radService.Location = New System.Drawing.Point(494, 280)
        Me.radService.Name = "radService"
        Me.radService.Size = New System.Drawing.Size(114, 17)
        Me.radService.TabIndex = 36
        Me.radService.TabStop = True
        Me.radService.Text = "Use Service Name"
        Me.radService.UseVisualStyleBackColor = True
        '
        'radProcess
        '
        Me.radProcess.AutoSize = True
        Me.radProcess.Location = New System.Drawing.Point(479, 306)
        Me.radProcess.Name = "radProcess"
        Me.radProcess.Size = New System.Drawing.Size(129, 17)
        Me.radProcess.TabIndex = 37
        Me.radProcess.TabStop = True
        Me.radProcess.Text = "Use Process Location"
        Me.radProcess.UseVisualStyleBackColor = True
        '
        'frmTeamspeakService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 372)
        Me.Controls.Add(Me.radProcess)
        Me.Controls.Add(Me.radService)
        Me.Controls.Add(Me.rtxtInformation)
        Me.Controls.Add(Me.txtCommand0)
        Me.Controls.Add(Me.txtCommand1)
        Me.Controls.Add(Me.txtCommand2)
        Me.Controls.Add(Me.txtCommand3)
        Me.Controls.Add(Me.txtDeamon)
        Me.Controls.Add(Me.txtProcess)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDownloadDeamon)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnCommands)
        Me.Controls.Add(Me.btnCmd)
        Me.Controls.Add(Me.btnUseBuiltInDeamon)
        Me.Controls.Add(Me.btnService)
        Me.Controls.Add(Me.btnProcessFile)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnDeamonFile)
        Me.Controls.Add(Me.lstServices)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblServiceName)
        Me.Controls.Add(Me.lblCommand3)
        Me.Controls.Add(Me.lblCommand2)
        Me.Controls.Add(Me.lblCommand0)
        Me.Controls.Add(Me.lblFileLocation)
        Me.Controls.Add(Me.lblCommand1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTeamspeakService"
        Me.Text = "xKiller Teamspeak Assistant Tool - Service/Process"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCommand0 As Label
	Friend WithEvents lblCommand1 As Label
	Friend WithEvents lblCommand2 As Label
	Friend WithEvents lblCommand3 As Label
	Friend WithEvents lblFileLocation As Label
	Friend WithEvents lblServiceName As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents lstServices As ListBox
	Friend WithEvents btnDeamonFile As Button
	Friend WithEvents btnClean As Button
	Friend WithEvents btnProcessFile As Button
	Friend WithEvents btnService As Button
	Friend WithEvents btnUseBuiltInDeamon As Button
	Friend WithEvents btnCmd As Button
	Friend WithEvents btnCommands As Button
	Friend WithEvents btnProcess As Button
	Friend WithEvents btnDownloadDeamon As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents txtService As TextBox
	Friend WithEvents txtProcess As TextBox
	Friend WithEvents txtDeamon As TextBox
    Friend WithEvents ofdTeamspeak As OpenFileDialog
    Friend WithEvents svcTeamspeak As ServiceProcess.ServiceController
    Friend WithEvents txtCommand3 As TextBox
    Friend WithEvents txtCommand2 As TextBox
    Friend WithEvents txtCommand1 As TextBox
    Friend WithEvents txtCommand0 As TextBox
    Friend WithEvents rtxtInformation As RichTextBox
    Friend WithEvents radService As RadioButton
    Friend WithEvents radProcess As RadioButton
End Class
