Imports System.IO
Imports System.ServiceProcess
Imports Microsoft.VisualBasic.CompilerServices

Public Class frmTeamspeakService
    Private strCommand0, strFileNotFound, strFileFound, strDeamon As String
    Public procExecuting As Process
    Private procStartInfo As ProcessStartInfo
    Private intIndex, intUserCheck As Integer
    Private svcList As ServiceController()
    Public intSendInfo, intError As Integer
    Public strServiceName, strProcess As String

    Private Sub frmTeamspeakService_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            blnDragged = True
            intDownX = e.X
            intDownY = e.Y
        End If
    End Sub

    Private Sub frmTeamspeakService_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            blnDragged = False
        End If
    End Sub

    Private Sub frmTeamspeakService_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If blnDragged Then
            Location = New Point() With {.X = Location.X + (e.X - intDownX), .Y = Location.Y + (e.Y - intDownY)}
        End If
    End Sub

    Private Sub btnCmd_Click(sender As Object, e As EventArgs) Handles btnCmd.Click
        procStartInfo = New ProcessStartInfo()
        procStartInfo.UseShellExecute = True
        procStartInfo.FileName = "cmd.exe"
        procStartInfo.WindowStyle = ProcessWindowStyle.Normal
        procStartInfo.Verb = "runas"
        Try
            procExecuting = Process.Start(procStartInfo)
        Catch exCMD As Exception
            Dim exErrorData As Exception = exCMD
            strDiagnostics21 = exErrorData.Message
            DiagnosticsLoad()
            Return
        End Try
    End Sub

    Private Sub btnCommands_Click(sender As Object, e As EventArgs) Handles btnCommands.Click
        If File.Exists(strDeamon) Then
            strFileFound = "= """ + strDeamon + """"
            strCommand0 = "SC CREATE TeamspeakDDNS DisplayName= ""Teamspeak DNS"" start= auto binPath" + strFileFound
            txtCommand0.Text = strCommand0
            rtxtInformation.Text = "Microsoft Windows [Version 10.0.17134.48]" & Environment.NewLine + "(c) 2018 Microsoft Corporation. All rights reserved." & Environment.NewLine & Environment.NewLine + "C:\Windows\system32>" + txtCommand0.Text & Environment.NewLine + "C:\Windows\system32>" + txtCommand1.Text & Environment.NewLine + "C:\Windows\system32>" + txtCommand2.Text & Environment.NewLine + "C:\Windows\system32>" + "Note: This is not CMD this just a visual guide, Remember to run CMD as admin due to you changing things with windows services"
            Return
        End If
        strFileNotFound = "= ""File Not Found"""
        strCommand0 = "SC CREATE TeamspeakDDNS DisplayName= ""Teamspeak DNS"" start= auto binPath" + strFileNotFound
        txtCommand0.Text = strCommand0
        rtxtInformation.Text = "Microsoft Windows [Version 10.0.17134.48]" & Environment.NewLine + "(c) 2018 Microsoft Corporation. All rights reserved." & Environment.NewLine & Environment.NewLine + "C:\Windows\system32>" + txtCommand0.Text & Environment.NewLine + "C:\Windows\system32>" + txtCommand1.Text & Environment.NewLine + "C:\Windows\system32>" + txtCommand2.Text & Environment.NewLine + "C:\Windows\system32>" + "Note: This is not CMD this just a visual guide, Remember to run CMD as admin due to you changing things with windows services"
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If Operators.CompareString(strProcess, String.Empty, False) = 0 Then
            MessageBox.Show("Please locate you teamspeak dns file and try again", "Process File Location Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        If Not radProcess.Checked Then
            If MessageBox.Show("You have pressed the wrong button with your current combo would you like to correct it so you may press this button?", "Wrong Button", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
                radProcess.Checked = True
                btnProcess.PerformClick()
            End If
            Return
        End If
        intUserCheck += 1
        If intUserCheck > 6 Then
            MessageBox.Show("You did not need to do that :-(", "Spammer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            btnClean.PerformClick()
            Close()
            Return
        End If
        intSendInfo = 2
        txtProcess.Text = strProcess
        TeamspeakEngine.UserControl()
        MessageBox.Show("We have sent the data to the main form :-)", "Data Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub frmTeamspeakService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        svcList = ServiceController.GetServices()
        lstServices.Items.Clear()
        Dim num As Integer = svcList.Length - 1
        intIndex = 0
        While intIndex <= num
            lstServices.Items.Add(svcList(intIndex).ServiceName)
            intIndex += 1
        End While
        rtxtInformation.Text = "Microsoft Windows [Version 10.0.17134.48]" & Environment.NewLine + "(c) 2018 Microsoft Corporation. All rights reserved." & Environment.NewLine & Environment.NewLine + "C:\Windows\system32>" + txtCommand0.Text & Environment.NewLine + "C:\Windows\system32>" + txtCommand1.Text & Environment.NewLine + "C:\Windows\system32>" + txtCommand2.Text & Environment.NewLine + "C:\Windows\system32>" + "Note: This is not CMD this just a visual guide, Remember to run CMD as admin due to you changing things with windows services"
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        intError = 1
        TeamspeakEngine.UserControl()
        strDeamon = String.Empty
        strFileFound = String.Empty
        strFileNotFound = String.Empty
        strCommand0 = String.Empty
        strDeamon = String.Empty
        strServiceName = String.Empty
        strProcess = String.Empty
        txtCommand0.Text = "Please Click Update Commands to get my Command"
        rtxtInformation.Text = "Microsoft Windows [Version 10.0.17134.48]" & Environment.NewLine + "(c) 2018 Microsoft Corporation. All rights reserved." & Environment.NewLine & Environment.NewLine + "C:\Windows\system32>" + txtCommand0.Text & Environment.NewLine + "C:\Windows\system32>" + txtCommand1.Text & Environment.NewLine + "C:\Windows\system32>" + txtCommand2.Text & Environment.NewLine + "C:\Windows\system32>" + "Note: This is not CMD this just a visual guide, Remember to run CMD as admin due to you changing things with windows services"
    End Sub

    Private Sub btnDeamonFile_Click(sender As Object, e As EventArgs) Handles btnDeamonFile.Click
        If Me.ofdTeamspeak.ShowDialog() = DialogResult.OK Then
            strDeamon = ofdTeamspeak.FileName
            If Not strDeamon.Contains(".exe") Then
                strDeamon = String.Empty
                MessageBox.Show("This is not Teamspeak's DNS Executable File, please try again", "File Extension Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Return
            End If
            txtDeamon.Text = strDeamon
        End If
    End Sub

    Private Sub btnProcessFile_Click(sender As Object, e As EventArgs) Handles btnProcessFile.Click
        If Me.ofdTeamspeak.ShowDialog() = DialogResult.OK Then
            strProcess = ofdTeamspeak.FileName
            If Not strProcess.Contains(".exe") Then
                strProcess = String.Empty
                MessageBox.Show("This is not Teamspeak's DNS Executable File, please try again", "File Extension Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Return
            End If
            txtProcess.Text = strProcess
        End If
    End Sub

    Private Sub btnUseBuiltInDeamon_Click(sender As Object, e As EventArgs) Handles btnUseBuiltInDeamon.Click
        txtDeamon.Text = Environment.CurrentDirectory + Application.ExecutablePath
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        If Operators.CompareString(strServiceName, String.Empty, False) = 0 Then
            MessageBox.Show("Please type or find your teamspeak dns service name and try again", "Service Name Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        If Not radService.Checked Then
            If MessageBox.Show("You have pressed the wrong button with your current combo would you like to correct it so you may press this button?", "Wrong Button", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
                radService.Checked = True
                btnService.PerformClick()
            End If
            Return
        End If
        intUserCheck += 1
        If intUserCheck > 6 Then
            MessageBox.Show("You did not need to do that :-(", "Spammer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            btnClean.PerformClick()
            Close()
            Return
        End If
        intSendInfo = 1
        txtService.Text = strServiceName
        TeamspeakEngine.UserControl()
        MessageBox.Show("We have sent the data to the main form :-)", "Data Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub btnDeamon_Click(sender As Object, e As EventArgs) Handles btnDownloadDeamon.Click
        Process.Start("http://addons.teamspeak.com/directory/addon/miscellaneous-tools/Teamspeak-3-Service-Wrapper.html")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub lstServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstServices.SelectedIndexChanged
        strServiceName = lstServices.SelectedItem.ToString()
        txtService.Text = strServiceName
    End Sub

    Private Sub chkService_CheckedChanged(sender As Object, e As EventArgs) Handles radService.CheckedChanged
        If radService.Checked Then
            radProcess.Checked = False
        End If
    End Sub

    Private Sub chkProcess_CheckedChanged(sender As Object, e As EventArgs) Handles radProcess.CheckedChanged
        If radProcess.Checked Then
            radService.Checked = False
        End If
    End Sub
End Class