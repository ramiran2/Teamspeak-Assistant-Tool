Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Public Class frmTeamspeakMain
    Private Sub frmTeamspeakMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateSettings()
        CleanStartUp()
        TimeChange()
        StartTray()
        FileLocation()
        Loadup()
        Startup()
        Message()
        ServiceRun()
        ButtonCheck()
        UpdateMessage()
        ServiceStatus()
    End Sub

    Private Sub frmTeamspeakMain_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            blnDragged = True
            intDownX = e.X
            intDownY = e.Y
        End If
    End Sub

    Private Sub frmTeamspeakMain_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            blnDragged = False
        End If
    End Sub

    Private Sub frmTeamspeakMain_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If blnDragged Then
            Location = New Point() With {.X = Location.X + (e.X - intDownX), .Y = Location.Y + (e.Y - intDownY)}
        End If
    End Sub

    Private Sub frmTeamspeakMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If MyBase.WindowState = FormWindowState.Minimized And intVisable = 2 Then
            nicTeamspeak.BalloonTipIcon = ToolTipIcon.Info
            nicTeamspeak.BalloonTipTitle = "xKiller Teamspeak Assistant Tool is still running in the system tray"
            nicTeamspeak.BalloonTipText = "You can double click the icon to show me or right click the icon to show additional options."
            nicTeamspeak.ShowBalloonTip(50000)
        End If
        intVisable = 0
    End Sub

    Private Sub tmrTeamspeak_Tick(sender As Object, e As EventArgs) Handles tmrTeamspeak.Tick
        If intTime <> intFixTime Then
            intTime += 1
        End If
        If psbTeamspeakProgress.Value = intFixTime Then
            psbTeamspeakProgress.Value = 0
        Else
            psbTeamspeakProgress.Value = psbTeamspeakProgress.Value + 1
        End If
        ServiceStatus()
        If intTime = intFixTime Then
            intTimerFixService = 1
            IPAddress()
            WriteIP()
            intStop = 1
            If My.User.IsInRole(BuiltInRole.Administrator) Then
                ServiceProcess()
            End If
            intStop = 0
            Thread.Sleep(2000)
            intStart = 1
            If My.User.IsInRole(BuiltInRole.Administrator) Then
                ServiceProcess()
            End If
            intStart = 0
            intTime = 0
            psbTeamspeakProgress.Value = 0
            intTimerFixService = 0
            tmrTeamspeak.Enabled = False
            tmrTeamspeak.Enabled = True
        End If
    End Sub

    Private Sub mnuOpenFile_Click(sender As Object, e As EventArgs) Handles mnuOpenFile.Click
        Open()
        If Not TeamspeakEngine.strFile = String.Empty Then
            WriteSettings()
        End If
    End Sub

    Private Sub mnuResources_Click(sender As Object, e As EventArgs) Handles mnuContact.Click
        stbTeamspeak.BackColor = Color.FromArgb(44, 62, 80)
        frmTeamspeakContact.ShowDialog()
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        stbTeamspeak.BackColor = Color.FromArgb(241, 196, 15)
        FrmTeamspeakAbout.ShowDialog()
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        stbTeamspeak.BackColor = Color.FromArgb(241, 196, 15)
        frmTeamspeakUpdate.ShowDialog()
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub mnuAccount_Click(sender As Object, e As EventArgs) Handles mnuAccount.Click
        stbTeamspeak.BackColor = Color.FromArgb(241, 196, 15)
        frmTeamspeakLogin.ShowDialog()
        ButtonCheck()
        If frmTeamspeakLogin.intAccountLogin > 0 Then
            WriteSettings()
        End If
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        If Operators.CompareString(strSettingsUsername, "Username=NULL", False) = 0 And Operators.CompareString(strSettingsPassword, "Password=NULL", False) = 0 And Operators.CompareString(strSettingsTime, "Time=NULL", False) = 0 And Operators.CompareString(strSettingsFileLocation, "DNSSettings=NULL", False) = 0 And Operators.CompareString(strSettingsChecked, "Checked=NULL", False) = 0 And Operators.CompareString(strSettingsAccess, "Access=NULL", False) = 0 And Operators.CompareString(strSettingsService, "Service=NULL", False) = 0 And Operators.CompareString(strSettingsProcess, "Program=NULL", False) = 0 And Operators.CompareString(strSettingsStartInTray, "Start=NULL", False) = 0 Then
            WriteSettings()
        Else
            intErrorMessage = 28
            ErrorMessage()
            intErrorMessage = 0
        End If
    End Sub

    Private Sub mnuServiceData_Click(sender As Object, e As EventArgs) Handles mnuServiceData.Click
        stbTeamspeak.BackColor = Color.FromArgb(241, 196, 15)
        frmTeamspeakService.ShowDialog()
        ButtonCheck()
        If frmTeamspeakService.intSendInfo = 2 Or frmTeamspeakService.intSendInfo = 1 Then
            WriteSettings()
        End If
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    Private Sub mnuTimerAdjustments_Click(sender As Object, e As EventArgs) Handles mnuTimerAdjustments.Click
        If intAccount > 0 Then
            stbTeamspeak.BackColor = Color.FromArgb(241, 196, 15)
            frmTeamspeakTime.ShowDialog()
            WriteSettings()
            stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
            Return
        End If
        intErrorMessage = 32
        ErrorMessage()
        intErrorMessage = 0
    End Sub

    Private Sub mnuReload_Click(sender As Object, e As EventArgs) Handles mnuReload.Click
        Reload()
        MessageInfo()
        intMessageError = 0
    End Sub

    Private Sub mnuAllReset_Click(sender As Object, e As EventArgs) Handles mnuAllReset.Click
        ErrorReset()
        If intRestartErrorCheck = 0 Then
            MessageInfo()
        End If
        intRestartErrorCheck = 0
        intMessageError = 0
    End Sub

    Private Sub mnuServiceStart_Click(sender As Object, e As EventArgs) Handles mnuServiceStart.Click
        intStart = 1
        ServiceProcess()
        MessageInfo()
        intMessageError = 0
        intStart = 0
    End Sub

    Private Sub mnuServiceStop_Click(sender As Object, e As EventArgs) Handles mnuServiceStop.Click
        intStop = 1
        ServiceProcess()
        MessageInfo()
        intMessageError = 0
        intStop = 0
    End Sub

    Private Sub mnuServiceRestart_Click(sender As Object, e As EventArgs) Handles mnuServiceRestart.Click
        intRestart = 1
        ServiceProcess()
        intRestart = 0
        If intCheckSP = 1 Then
            intMessageError = 6
            MessageInfo()
            intMessageError = 0
        End If
        intCheckSP = 0
    End Sub

    Private Sub mnuUpdateDNS_Click(sender As Object, e As EventArgs) Handles mnuUpdateFile.Click
        WriteIP()
        MessageInfo()
        intMessageError = 0
    End Sub

    Private Sub mnuIpDisplay_Click(sender As Object, e As EventArgs) Handles mnuIpDisplay.Click
        IPAddress()
        intGoogle += 1
        intVideo += 1
        If intGoogle <= 1 Then
            stbTeamspeak.BackColor = Color.FromArgb(44, 62, 80)
            Process.Start("https://www.google.com/search?q=whats+my+ip")
            stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
        End If
        If intVideo > 5 Then
            nicTeamspeak.BalloonTipIcon = ToolTipIcon.Info
            nicTeamspeak.BalloonTipTitle = "xKiller Teamspeak Assistant Tool - Easter Eggs #1 Found"
            nicTeamspeak.BalloonTipText = "Well this brings back memories from halo 2 for windows vista."
            stbTeamspeak.BackColor = Color.FromArgb(127, 140, 141)
            frmTeamspeakVideo.ShowDialog()
            stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
        End If
    End Sub

    Private Sub mnuVersion_Click(sender As Object, e As EventArgs) Handles mnuVersion.Click
        intMessageError = 2
        MessageInfo()
        intMessageError = 0
        mnuUpdate.PerformClick()
    End Sub

    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        stbTeamspeak.BackColor = Color.FromArgb(192, 57, 43)
        If MessageBox.Show("This will wipe the the teamspeak dns file?", "Wipe DNS File", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
            If File.Exists(strFile) Then
                File.WriteAllText(strFile, "")
                mnuAllReset.PerformClick()
                Return
            End If
            stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
            intErrorMessage = 33
            ErrorMessage()
            intErrorMessage = 0
        End If
    End Sub

    Private Sub mnuStartInTray_Click(sender As Object, e As EventArgs) Handles mnuStartInTray.Click
        intStartTray += 1
        WriteSettings()
        If intStartTray >= 1 Then
            mnuStartInTray.Enabled = False
        End If
    End Sub

    Private Sub mnuHide_Click(sender As Object, e As EventArgs) Handles mnuHide.Click
        stbTeamspeak.BackColor = Color.FromArgb(211, 84, 0)
        intVisable = 2
        WindowState = FormWindowState.Minimized
        ShowInTaskbar = False
    End Sub

    Private Sub cmnuExit_Click(sender As Object, e As EventArgs) Handles cmnuExit.Click
        mnuExit.PerformClick()
    End Sub

    Private Sub cmnuAbout_Click(sender As Object, e As EventArgs) Handles cmnuAboutTray.Click
        mnuAbout.PerformClick()
    End Sub

    Private Sub cmnuUpdate_Click(sender As Object, e As EventArgs) Handles cmnuUpdate.Click
        mnuUpdate.PerformClick()
    End Sub

    Private Sub cmnuShow_Click(sender As Object, e As EventArgs) Handles cmnuShowFormTray.Click
        If MyBase.WindowState = FormWindowState.Minimized Then
            cmnuShowFormTray.Text = "Hide &Teamspeak Assistant Tool"
            WindowState = FormWindowState.Normal
            ShowInTaskbar = True
            stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
            Return
        End If
        cmnuShowFormTray.Text = "Show &Teamspeak Assistant Tool"
        stbTeamspeak.BackColor = Color.FromArgb(211, 84, 0)
        intVisable = 2
        WindowState = FormWindowState.Minimized
        ShowInTaskbar = False
    End Sub

    Private Sub nicTeamspeak_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nicTeamspeak.MouseDoubleClick
        cmnuShowFormTray.PerformClick()
    End Sub

    Private Sub mnuEnableStartUp_Click(sender As Object, e As EventArgs) Handles mnuEnableStartUp.Click
        stbTeamspeak.BackColor = Color.FromArgb(142, 68, 173)
        My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, """" + Application.ExecutablePath + """")
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
        intErrorMessage = 40
        ErrorMessage()
        intErrorMessage = 0
        mnuEnableStartUp.Enabled = False
        mnuDisableStartUp.Enabled = True
    End Sub

    Private Sub mnuDisableStartUp_Click(sender As Object, e As EventArgs) Handles mnuDisableStartUp.Click
        stbTeamspeak.BackColor = Color.FromArgb(142, 68, 173)
        If RuntimeHelpers.GetObjectValue(My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue(Application.ProductName)) Is Nothing Then
            intErrorMessage = 42
            ErrorMessage()
            intErrorMessage = 0
        Else
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
            intErrorMessage = 41
            ErrorMessage()
            intErrorMessage = 0
        End If
        mnuDisableStartUp.Enabled = False
        mnuEnableStartUp.Enabled = True
    End Sub

    Private Sub cmnuExitTray_Click(sender As Object, e As EventArgs) Handles cmnuExitTray.Click
        mnuExit.PerformClick()
    End Sub

    Private Sub cmnuUpdateTray_Click(sender As Object, e As EventArgs) Handles cmnuUpdateTray.Click
        mnuUpdate.PerformClick()
    End Sub

    Private Sub cmnuSave_Click(sender As Object, e As EventArgs) Handles cmnuSave.Click
        mnuSave.PerformClick()
    End Sub

    Private Sub cmnuReload_Click(sender As Object, e As EventArgs) Handles cmnuReload.Click
        mnuReload.PerformClick()
    End Sub

    Private Sub cmnuUpdateFile_Click(sender As Object, e As EventArgs) Handles cmnuUpdateFile.Click
        mnuUpdateFile.PerformClick()
    End Sub

    Private Sub mnuAdmin_Click(sender As Object, e As EventArgs) Handles mnuAdmin.Click
        RunAdmin()
    End Sub

    Private Sub cmnuAdminTray_Click(sender As Object, e As EventArgs) Handles cmnuAdminTray.Click
        mnuAdmin.PerformClick()
    End Sub

    Private Sub cmnuAdmin_Click(sender As Object, e As EventArgs) Handles cmnuAdmin.Click
        mnuAdmin.PerformClick()
    End Sub

    Private Sub lblEasterEgg2_DoubleClick(sender As Object, e As EventArgs) Handles lblEasterEgg2.DoubleClick
        nicTeamspeak.BalloonTipIcon = ToolTipIcon.Info
        nicTeamspeak.BalloonTipTitle = "xKiller Teamspeak Assistant Tool - Easter Eggs #2 Found"
        nicTeamspeak.BalloonTipText = "Well this brings back memories from halo 2 for windows vista."
        stbTeamspeak.BackColor = Color.FromArgb(127, 140, 141)
        frmTeamspeakDrama.ShowDialog()
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub lblEasterEgg3_DoubleClick(sender As Object, e As EventArgs) Handles lblEasterEgg3.DoubleClick
        nicTeamspeak.BalloonTipIcon = ToolTipIcon.Info
        nicTeamspeak.BalloonTipTitle = "xKiller Teamspeak Assistant Tool - Easter Eggs #3 Found"
        nicTeamspeak.BalloonTipText = "Well this brings back memories from halo 2 for windows vista."
        stbTeamspeak.BackColor = Color.FromArgb(127, 140, 141)
        frmTeamspeakHalo.ShowDialog()
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub mnuFont_Click(sender As Object, e As EventArgs) Handles mnuFont.Click
        If Me.fodTeamspeak.ShowDialog() = DialogResult.OK Then
            chkDomain0.Font = fodTeamspeak.Font
            chkDomain1.Font = fodTeamspeak.Font
            chkDomain2.Font = fodTeamspeak.Font
            chkDomain3.Font = fodTeamspeak.Font
            chkDomain4.Font = fodTeamspeak.Font
            chkDomain5.Font = fodTeamspeak.Font
            chkDomain6.Font = fodTeamspeak.Font
            chkDomain7.Font = fodTeamspeak.Font
            chkDomain8.Font = fodTeamspeak.Font
            chkDomain9.Font = fodTeamspeak.Font
            chkDomain10.Font = fodTeamspeak.Font
            chkDomain11.Font = fodTeamspeak.Font
            chkDomain12.Font = fodTeamspeak.Font
            chkDomain13.Font = fodTeamspeak.Font
            chkDomain14.Font = fodTeamspeak.Font
            chkDomain15.Font = fodTeamspeak.Font
            chkDomain16.Font = fodTeamspeak.Font
            chkDomain17.Font = fodTeamspeak.Font
            chkDomain18.Font = fodTeamspeak.Font
            chkDomain19.Font = fodTeamspeak.Font
        End If
    End Sub

    Private Sub mnuHighlight_Click(sender As Object, e As EventArgs) Handles mnuHighlight.Click
        If Me.cdigTeamspeak.ShowDialog() = DialogResult.OK Then
            chkDomain0.BackColor = cdigTeamspeak.Color
            chkDomain1.BackColor = cdigTeamspeak.Color
            chkDomain2.BackColor = cdigTeamspeak.Color
            chkDomain3.BackColor = cdigTeamspeak.Color
            chkDomain4.BackColor = cdigTeamspeak.Color
            chkDomain5.BackColor = cdigTeamspeak.Color
            chkDomain6.BackColor = cdigTeamspeak.Color
            chkDomain7.BackColor = cdigTeamspeak.Color
            chkDomain8.BackColor = cdigTeamspeak.Color
            chkDomain9.BackColor = cdigTeamspeak.Color
            chkDomain10.BackColor = cdigTeamspeak.Color
            chkDomain11.BackColor = cdigTeamspeak.Color
            chkDomain12.BackColor = cdigTeamspeak.Color
            chkDomain13.BackColor = cdigTeamspeak.Color
            chkDomain14.BackColor = cdigTeamspeak.Color
            chkDomain15.BackColor = cdigTeamspeak.Color
            chkDomain16.BackColor = cdigTeamspeak.Color
            chkDomain17.BackColor = cdigTeamspeak.Color
            chkDomain18.BackColor = cdigTeamspeak.Color
            chkDomain19.BackColor = cdigTeamspeak.Color
        End If
    End Sub

    Private Sub mnuText_Click(sender As Object, e As EventArgs) Handles mnuText.Click
        If Me.cdigTeamspeak.ShowDialog() = DialogResult.OK Then
            chkDomain0.ForeColor = cdigTeamspeak.Color
            chkDomain1.ForeColor = cdigTeamspeak.Color
            chkDomain2.ForeColor = cdigTeamspeak.Color
            chkDomain3.ForeColor = cdigTeamspeak.Color
            chkDomain4.ForeColor = cdigTeamspeak.Color
            chkDomain5.ForeColor = cdigTeamspeak.Color
            chkDomain6.ForeColor = cdigTeamspeak.Color
            chkDomain7.ForeColor = cdigTeamspeak.Color
            chkDomain8.ForeColor = cdigTeamspeak.Color
            chkDomain9.ForeColor = cdigTeamspeak.Color
            chkDomain10.ForeColor = cdigTeamspeak.Color
            chkDomain11.ForeColor = cdigTeamspeak.Color
            chkDomain12.ForeColor = cdigTeamspeak.Color
            chkDomain13.ForeColor = cdigTeamspeak.Color
            chkDomain14.ForeColor = cdigTeamspeak.Color
            chkDomain15.ForeColor = cdigTeamspeak.Color
            chkDomain16.ForeColor = cdigTeamspeak.Color
            chkDomain17.ForeColor = cdigTeamspeak.Color
            chkDomain18.ForeColor = cdigTeamspeak.Color
            chkDomain19.ForeColor = cdigTeamspeak.Color
            mnuFile.ForeColor = cdigTeamspeak.Color
            mnuService.ForeColor = cdigTeamspeak.Color
            mnuSettings.ForeColor = cdigTeamspeak.Color
            mnuStart.ForeColor = cdigTeamspeak.Color
            mnuExtra.ForeColor = cdigTeamspeak.Color
            mnuHelp.ForeColor = cdigTeamspeak.Color
        End If
    End Sub

    Private Sub mnuForm_Click(sender As Object, e As EventArgs) Handles mnuForm.Click
        If Me.cdigTeamspeak.ShowDialog() = DialogResult.OK Then
            BackColor = cdigTeamspeak.Color
            mnuTeamspeak.BackColor = cdigTeamspeak.Color
        End If
    End Sub

    Private Sub mnuErrorMessageControl_Click(sender As Object, e As EventArgs) Handles mnuErrorMessageControl.Click
        intDiagnosticsClick += 1
        DiagnosticsLoad()
    End Sub

    Private Sub frmTeamspeakMain_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If intTime = 0 Then
            Application.Exit()
        Else
            If intTime < intFixTime - 15 Then
                stbTeamspeak.BackColor = Color.FromArgb(211, 84, 0)
                e.Cancel = True
                intErrorMessage = 30
                ErrorMessage()
                intErrorMessage = 0
            End If
        End If
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        Call Message()
    End Sub

    Private Sub cmnuSettingsEditor_Click(sender As Object, e As EventArgs) Handles cmnuSettingsEditor.Click
        mnuSettingEditor.PerformClick()
    End Sub

    Private Sub mnuDiagnosticViewer_Click(sender As Object, e As EventArgs) Handles mnuDiagnosticViewer.Click
        stbTeamspeak.BackColor = Color.FromArgb(44, 62, 80)
        frmTeamspeakDiagnostic.ShowDialog()
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub mnuSettingEditor_Click(sender As Object, e As EventArgs) Handles mnuSettingEditor.Click
        stbTeamspeak.BackColor = Color.FromArgb(241, 196, 15)
        frmTeamspeakSettingEditor.ShowDialog()
        stbTeamspeak.BackColor = Color.FromArgb(39, 174, 96)
    End Sub
End Class
