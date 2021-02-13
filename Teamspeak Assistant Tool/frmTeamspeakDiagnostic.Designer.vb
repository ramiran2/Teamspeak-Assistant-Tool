<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTeamspeakDiagnostic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTeamspeakDiagnostic))
        Me.lstVariables = New System.Windows.Forms.ListBox()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.rtxtDiagnostics = New System.Windows.Forms.RichTextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstVariables
        '
        Me.lstVariables.FormattingEnabled = True
        Me.lstVariables.Location = New System.Drawing.Point(144, 12)
        Me.lstVariables.Name = "lstVariables"
        Me.lstVariables.Size = New System.Drawing.Size(273, 134)
        Me.lstVariables.TabIndex = 0
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Location = New System.Drawing.Point(12, 158)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(74, 13)
        Me.lblInformation.TabIndex = 1
        Me.lblInformation.Text = "Input Change:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(85, 155)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(342, 152)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(191, 157)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 6
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = Global.xKiller_Teamspeak_Assistant_Tool.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(126, 134)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 7
        Me.picLogo.TabStop = False
        '
        'rtxtDiagnostics
        '
        Me.rtxtDiagnostics.BackColor = System.Drawing.Color.Black
        Me.rtxtDiagnostics.ForeColor = System.Drawing.Color.White
        Me.rtxtDiagnostics.Location = New System.Drawing.Point(12, 181)
        Me.rtxtDiagnostics.Name = "rtxtDiagnostics"
        Me.rtxtDiagnostics.Size = New System.Drawing.Size(405, 332)
        Me.rtxtDiagnostics.TabIndex = 8
        Me.rtxtDiagnostics.Text = ""
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(253, 158)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 13)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Not Available"
        '
        'frmTeamspeakDiagnostic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 525)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.rtxtDiagnostics)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.lstVariables)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTeamspeakDiagnostic"
        Me.Text = "xKiller Teamspeak Assistant Tool - Diagnostic Viewer"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstVariables As ListBox
    Friend WithEvents lblInformation As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents rtxtDiagnostics As RichTextBox
    Friend WithEvents lblStatus As Label
End Class
