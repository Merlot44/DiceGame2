Public Class WNDMain
    ' Define a variable for the player's name
    Public PlayerName As String
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click

        ' Verify that the user entered their name
        If TBXName.Text <> "" Then
            ' Save the player's name
            PlayerName = TBXName.Text

            ' Hide used elements
            LBLName.Visible = False
            TBXName.Visible = False
            LBLNameHint.Visible = False
            BTNStart.Visible = False

            ' Welcome player
            LBLMain.Text = "Bienvenue " + PlayerName + "!"

            ' Show new elements
            BTNInstructions.Visible = True
            BTNContinue.Visible = True
        Else
            ' Show the player name hint
            LBLNameHint.Visible = True
        End If
    End Sub

    Private Sub TBXName_TextChanged(sender As Object, e As EventArgs) Handles TBXName.TextChanged
        ' Hide the player name hint
        LBLNameHint.Visible = False
    End Sub
End Class
