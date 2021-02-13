Public Class frmTeamspeakContact

    Private Sub frmTeamspeakContact_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            blnDragged = True
            intDownX = e.X
            intDownY = e.Y
        End If
    End Sub

    Private Sub frmTeamspeakContact_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            blnDragged = False
        End If
    End Sub

    Private Sub frmTeamspeakContact_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If blnDragged Then
            Location = New Point() With {.X = Location.X + (e.X - intDownX), .Y = Location.Y + (e.Y - intDownY)}
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnHalo_Click(sender As Object, e As EventArgs) Handles btnHalo2Online.Click
        Process.Start("http://www.h2v.online/")
    End Sub

    Private Sub lblTeamspeak_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblTeamspeak.Click
        Process.Start("https://discord.gg/FB52jtnZ3b")
    End Sub

    Private Sub lblForums_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForums.Click
        Process.Start("https://forums.xkillerclan.com/")
    End Sub

    Private Sub lblFacebook_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFacebook.Click
        Process.Start("https://www.facebook.com/groups/xKillerClan/")
    End Sub

    Private Sub lblSteam_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSteam.Click
        Process.Start("http://steamcommunity.com/groups/xKillerClan")
    End Sub

    Private Sub btnWaypoint_Click(sender As Object, e As EventArgs) Handles btnWaypoint.Click
        Process.Start("https://www.halowaypoint.com/en-us/spartan-companies/xkiller%20clan")
    End Sub

    Private Sub btnHaloMCC_Click(sender As Object, e As EventArgs) Handles btnHaloMCC.Click
        Process.Start("https://store.steampowered.com/app/976730/Halo_The_Master_Chief_Collection/")
    End Sub
End Class