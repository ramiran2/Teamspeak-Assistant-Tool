Public Class FrmTeamspeakAbout

    Private Sub FrmTeamspeakAbout_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            blnDragged = True
            intDownX = e.X
            intDownY = e.Y
        End If
    End Sub

    Private Sub FrmTeamspeakAbout_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            blnDragged = False
        End If
    End Sub

    Private Sub FrmTeamspeakAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If blnDragged Then
            Location = New Point() With {.X = Location.X + (e.X - intDownX), .Y = Location.Y + (e.Y - intDownY)}
        End If
    End Sub

    Sub EasterEgg()
        Dim strCurrentTime As String = System.DateTime.Now.ToString("MM/dd")
        Dim strBirthdayTime As String = "05/28"
        If strBirthdayTime = strCurrentTime Then
            lblAbout.Text = "This app was made to address dynamic dns as i change my public ip address and hate have to go change in the teamspeak dns file. We hope you enjoy using the app and don't be afraid to visit our website. xKiller Clan is not just a clan, we are a family :) - Easter Egg #4 - 5/28/1994"
        End If
    End Sub

    Private Sub BtnWebsite_Click(sender As Object, e As EventArgs) Handles btnWebsite.Click
        Process.Start("https://www.xkillerclan.com/")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        My.Forms.frmTeamspeakContact.ShowDialog()
    End Sub

    Private Sub FrmTeamspeakAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call EasterEgg()
    End Sub
End Class