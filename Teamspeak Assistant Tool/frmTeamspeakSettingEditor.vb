Public Class frmTeamspeakSettingEditor
    Private Sub frmTeamspeakSettingEditor_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            blnDragged = True
            intDownX = e.X
            intDownY = e.Y
        End If
    End Sub

    Private Sub frmTeamspeakSettingEditor_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            blnDragged = False
        End If
    End Sub

    Private Sub frmTeamspeakSettingEditor_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If blnDragged Then
            Location = New Point() With {.X = Location.X + (e.X - intDownX), .Y = Location.Y + (e.Y - intDownY)}
        End If
    End Sub
End Class