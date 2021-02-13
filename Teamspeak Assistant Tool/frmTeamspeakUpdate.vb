Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO

Public Class frmTeamspeakUpdate
    Private strLink, strRawData, strVersion As String
    Private intStart, intExit As Integer
    Private procErrorRun As ProcessStartInfo

    Private Sub frmTeamspeakUpdate_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            blnDragged = True
            intDownX = e.X
            intDownY = e.Y
        End If
    End Sub

    Private Sub frmTeamspeakUpdate_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            blnDragged = False
        End If
    End Sub

    Private Sub frmTeamspeakUpdate_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If blnDragged Then
            Location = New Point() With {.X = Location.X + (e.X - intDownX), .Y = Location.Y + (e.Y - intDownY)}
        End If
    End Sub

    Private Sub bgwTeamspeak_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwTeamspeak.DoWork
        Try
            strLink = "https://download.xkillerclan.com/teamspeak/windows/tsddns-latest.zip"
            Dim num As Integer = CInt(WebRequest.Create(strLink).GetResponse().ContentLength)
            num = CInt(Math.Round(CDbl(num) / 1024.0))
            prbTeamspeak.Maximum = num
            Dim webDownload As New WebClient()
            webDownload.DownloadFile(strLink, Path.Combine(Application.StartupPath, "tsddns-latest.zip"))
            btnUpdate.Text = "Download Complete"
            intExit = 1
        Catch exBackgroundTeamspeak As Exception
            Dim exErrorData As Exception = exBackgroundTeamspeak
            TeamspeakEngine.strDiagnostics18 = exErrorData.Message
            TeamspeakEngine.DiagnosticsLoad()
            btnUpdate.Text = "Try again"
            picStatus.Image = My.Resources.offline
            lblStatus.Text = "An error has occurred"
        End Try
    End Sub

    Private Sub frmTeamspeakUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        lblStatus.Text = "Check for updates"
        picStatus.Image = My.Resources.info_flat
    End Sub

    Private Sub tmrTeamspeak_Tick(sender As Object, e As EventArgs) Handles tmrTeamspeak.Tick
        If File.Exists(Path.Combine(Application.StartupPath, "tsddns-latest.zip")) Then
            Dim num As Integer = CInt(New FileInfo(Path.Combine(Application.StartupPath, "tsddns-latest.zip")).Length)
            num = CInt(Math.Round(CDbl(num) / 1024.0))
            prbTeamspeak.Value = num
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        lblStatus.Text = "Attempting to check for updates"
        If intExit = 0 Then
            If File.Exists(Path.Combine(Application.StartupPath, "tsddns-latest.zip")) Then
                Try
                    My.Computer.FileSystem.DeleteFile(Path.Combine(Application.StartupPath, "tsddns-latest.zip"), UIOption.AllDialogs, RecycleOption.SendToRecycleBin)
                Catch exUpdate As Exception
                    Dim exErrorData As Exception = exUpdate
                    TeamspeakEngine.strDiagnostics17 = exErrorData.Message
                    TeamspeakEngine.DiagnosticsLoad()
                End Try
            End If
            Try
                strRawData = New WebClient().DownloadString("https://engine.xkillerclan.com/tsddns.html")
                strRawData = New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").Matches(strRawData)(0).ToString()
            Catch exUpdate As Exception
                Dim exErrorData As Exception = exUpdate
                picStatus.Image = My.Resources.status
                lblStatus.Text = "Can't connect online"
                TeamspeakEngine.strDiagnostics16 = exErrorData.Message
                TeamspeakEngine.DiagnosticsLoad()
            End Try
            strVersion = TeamspeakEngine.strVersion
            If Operators.CompareString(strRawData, String.Empty, False) = 0 Then
                picStatus.Image = My.Resources.offline
                lblStatus.Text = "Unable to check for updates"
                Return
            End If
            If strRawData.Contains(strVersion) Then
                picStatus.Image = My.Resources.online
                lblStatus.Text = "Up to date"
            Else
                btnUpdate.Text = "Downloading..."
                lblStatus.Text = "Currently Downloading"
                picStatus.Image = My.Resources.downloading
                intStart = 1
            End If
            If intStart = 1 Then
                tmrTeamspeak.Enabled = True
                bgwTeamspeak.RunWorkerAsync()
                Return
            End If
        Else
            btnClose.PerformClick()
        End If
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        If txtInput.Text = "Diagnostics S117" Then
            frmTeamspeakDiagnostic.ShowDialog()
        End If
        If txtInput.Text = "Settings Editor S117" Then
            frmTeamspeakSettingEditor.ShowDialog()
        End If
        If txtInput.Text = "About S117" Then
            FrmTeamspeakAbout.ShowDialog()
        End If
        If txtInput.Text = "Contact S117" Then
            frmTeamspeakContact.ShowDialog()
        End If
        If txtInput.Text = "Easter Egg #2 S117" Then
            frmTeamspeakDrama.ShowDialog()
        End If
        If txtInput.Text = "Easter Egg #3 S117" Then
            frmTeamspeakHalo.ShowDialog()
        End If
        If txtInput.Text = "Service S117" Then
            frmTeamspeakService.ShowDialog()
        End If
        If txtInput.Text = "Time S117" Then
            frmTeamspeakTime.ShowDialog()
        End If
        If txtInput.Text = "Easter Egg #1 S117" Then
            frmTeamspeakVideo.ShowDialog()
        End If
    End Sub

    Private Sub bgwTeamspeak_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwTeamspeak.RunWorkerCompleted
        picStatus.Image = My.Resources.online
        lblStatus.Text = "Download Completed"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        lblStatus.Text = "Closing Updater..."
        Close()
    End Sub

    Private Sub frmTeamspeakUpdate_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If bgwTeamspeak.IsBusy Then
            e.Cancel = True
            If intExit = 0 Then
                MessageBox.Show("We are unable to fix this error and we will have to try to restart this application", "Error Restart Attempt", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                procErrorRun = New ProcessStartInfo()
                procErrorRun.UseShellExecute = False
                procErrorRun.WorkingDirectory = Environment.CurrentDirectory
                procErrorRun.FileName = Application.ExecutablePath
                procErrorRun.Verb = ""
                Try
                    Process.Start(procErrorRun)
                Catch exClosing As Exception
                    Dim exErrorData As Exception = exClosing
                    TeamspeakEngine.strDiagnostics19 = exErrorData.Message
                    TeamspeakEngine.DiagnosticsLoad()
                    Return
                End Try
                Application.[Exit]()
                Return
            End If
            MessageBox.Show("You can't close the updater until the download has completed", "Updater Still Running", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        ElseIf intExit = 1 AndAlso File.Exists(Path.Combine(Application.StartupPath, "tsddns-latest.zip")) Then
            MessageBox.Show("We will exit so you may manually update Teamspeak Assistant Tool", "Update Downloaded", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Process.Start(Path.Combine(Application.StartupPath, "tsddns-latest.zip"))
            Application.[Exit]()
        End If
    End Sub
End Class