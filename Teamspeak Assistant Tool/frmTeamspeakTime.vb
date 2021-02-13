Imports Microsoft.VisualBasic.CompilerServices

Public Class frmTeamspeakTime
    Public intUserTime As Integer
    Private strUserTimeCheck As String

    Private Sub frmTeamspeakTime_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            blnDragged = True
            intDownX = e.X
            intDownY = e.Y
        End If
    End Sub

    Private Sub frmTeamspeakTime_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            blnDragged = False
        End If
    End Sub

    Private Sub frmTeamspeakTime_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If blnDragged Then
            Location = New Point() With {.X = Location.X + (e.X - intDownX), .Y = Location.Y + (e.Y - intDownY)}
        End If
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        strUserTimeCheck = Me.txtMinutes.Text
        If Versioned.IsNumeric(strUserTimeCheck) Then
            Integer.TryParse(strUserTimeCheck, intUserTime)
            lblStatus.Text = "Success"
            lblStatus.ForeColor = Color.Green
            Return
        End If
        MessageBox.Show("Please enter a valid number", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Me.txtMinutes.Text = String.Empty
        lblStatus.Text = "Invalid Number"
        lblStatus.ForeColor = Color.Red
        Me.txtMinutes.Focus()
    End Sub

    Private Sub txtMinutes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinutes.KeyPress
        If (Operators.CompareString(Conversions.ToString(e.KeyChar), "1", False) < 0 Or Operators.CompareString(Conversions.ToString(e.KeyChar), "100", False) > 0) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        lblStatus.Text = "Closing timer config page..."
        Close()
    End Sub

    Private Sub frmTeamspeakTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = "Not Available"
        lblStatus.ForeColor = Color.Black
    End Sub
End Class