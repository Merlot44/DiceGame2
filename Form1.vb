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

    Private Sub BTNInstructions_Click(sender As Object, e As EventArgs) Handles BTNInstructions.Click
        ' Hide the button
        BTNInstructions.Visible = False

        ' Show instructions
        TBXInstructions.Visible = True
    End Sub

    Private Sub BTNContinue_Click(sender As Object, e As EventArgs) Handles BTNContinue.Click
        ' Hide used elements
        BTNInstructions.Visible = False
        BTNContinue.Visible = False
        TBXInstructions.Visible = False

        ' Prompt the player to guess the dice
        LBLMain.Text = "Veuillez deviner la valeure des dés :"

        ' Show next elements
        LBLDice1.Visible = True
        LBLDice2.Visible = True
        TBXDice1.Visible = True
        TBXDice2.Visible = True
        BTNGuess.Visible = True
    End Sub
End Class
