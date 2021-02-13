Imports Microsoft.VisualBasic.CompilerServices

Public Class frmTeamspeakLogin
    Private intTrys As Integer
    Private strUsername, strPassword As String
    Public intAccountLogin As Integer

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

    Public Sub Account()
        strUsername = txtUsername.Text
        strPassword = txtPassword.Text
        If Operators.CompareString(strUsername, String.Empty, False) = 0 Or Operators.CompareString(strPassword, String.Empty, False) = 0 Then
            If Operators.CompareString(strUsername, String.Empty, False) = 0 And Operators.CompareString(strPassword, String.Empty, False) = 0 Then
                lblStatus.Text = "You did not enter a username or password :("
            End If
            If Operators.CompareString(strUsername, String.Empty, False) = 0 And Not String.IsNullOrEmpty(strPassword) Then
                lblStatus.Text = "A username is required to login"
            End If
            If Operators.CompareString(strPassword, String.Empty, False) = 0 And Not String.IsNullOrEmpty(strUsername) Then
                lblStatus.Text = "A password is required to login"
                Return
            End If
        Else
            If Operators.CompareString(strUsername, "xKillerAdmin", False) = 0 Then
                If Operators.CompareString(strPassword, "K!w%XJS3N7Xw*7A*A^zDOCiqs", False) = 0 Then
                    intAccountLogin = 1
                    lblStatus.Text = "Login Successful"
                Else
                    intTrys += 1
                    If intTrys = 4 Then
                        lblStatus.Text = "You have tried to many times last chance"
                        If intTrys = 5 Then
                            intTrys = 0
                            Close()
                        End If
                    End If
                    lblStatus.Text = "Wrong password, please try again"
                End If
            End If
            If Operators.CompareString(strUsername, "xKillerMember", False) = 0 Then
                If Operators.CompareString(strPassword, "Ik1rSlnS&xpC5L*UT$Yd1X@UE", False) = 0 Then
                    intAccountLogin = 2
                    lblStatus.Text = "Login Successful"
                Else
                    intTrys += 1
                    If intTrys = 4 Then
                        lblStatus.Text = "You have tried to many times last chance"
                        If intTrys = 5 Then
                            intTrys = 0
                            btnClose.PerformClick()
                        End If
                    End If
                    lblStatus.Text = "Wrong password, please try again"
                End If
            End If
            If Operators.CompareString(strUsername, "Trusted User", False) = 0 Then
                If Operators.CompareString(strPassword, "rPw66vk$@!J#BMIhh9P6FWGj4", False) = 0 Then
                    intAccountLogin = 3
                    lblStatus.Text = "Login Successful"
                    Return
                End If
                intTrys += 1
                If intTrys = 4 Then
                    lblStatus.Text = "You have tried to many times last chance"
                    If intTrys = 5 Then
                        intTrys = 0
                        btnClose.PerformClick()
                    End If
                End If
                lblStatus.Text = "Wrong password, please try again"
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        lblStatus.Text = "Closing login page..."
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblStatus.Text = "Checking your username and password with our database"
        Account()
        TeamspeakEngine.Account()
        TeamspeakEngine.AccountVarable()
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Process.Start("https://engine.xkillerclan.com/teamspeakrequest.html")
    End Sub

    Private Sub frmTeamspeakLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = "Please login up above"
        picStatus.Image = My.Resources.info_flat
    End Sub
End Class