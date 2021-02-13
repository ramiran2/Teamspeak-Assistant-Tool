<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTeamspeakAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTeamspeakAbout))
        Me.btnWebsite = New System.Windows.Forms.Button()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnWebsite
        '
        Me.btnWebsite.Location = New System.Drawing.Point(167, 155)
        Me.btnWebsite.Name = "btnWebsite"
        Me.btnWebsite.Size = New System.Drawing.Size(124, 23)
        Me.btnWebsite.TabIndex = 0
        Me.btnWebsite.Text = "Website"
        Me.btnWebsite.UseVisualStyleBackColor = True
        '
        'btnContact
        '
        Me.btnContact.Location = New System.Drawing.Point(297, 155)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(123, 23)
        Me.btnContact.TabIndex = 1
        Me.btnContact.Text = "Contact Us"
        Me.btnContact.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(426, 155)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblAbout
        '
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(167, 12)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(373, 140)
        Me.lblAbout.TabIndex = 3
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
        '
        'picLogo
        '
        Me.picLogo.Image = Global.xKiller_Teamspeak_Assistant_Tool.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(149, 166)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'frmTeamspeakAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 190)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnContact)
        Me.Controls.Add(Me.btnWebsite)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTeamspeakAbout"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "xKiller Teamspeak Assistant Tool - About"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWebsite As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblAbout As Label
    Friend WithEvents picLogo As PictureBox
End Class
