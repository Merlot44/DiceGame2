' Dice Game 2
' By Merlot44
' Date: 3/4/2025
' Version: 1.0.0
' Github Repository : www.github.com/Merlot44/DiceGame2/

Imports System.Security.Authentication.ExtendedProtection
Public Class WNDMain
    ' Define a variable for the player's name
    Public PlayerName As String = "joueur"

    ' Define a variable for the guessed sum of the die
    Public DiceGuess As Integer = 12

    ' Define variables fot the die roll
    Public Dice1Roll As Integer = 6
    Public Dice2Roll As Integer = 6

    ' Define a variable for sound control
    Public Sound As Boolean = True

    ' Define variables for statistics
    Public PlayedGames As Integer = 0
    Public WonGames As Integer = 0
    Public WinPercentage As Integer = 0
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        ' Verify sound status
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)

            ' Play the background music
            My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop)
        End If

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
        ' Verify sound status
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)

            ' Play the background music
            My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop)
        End If

        ' Hide the button
        BTNInstructions.Visible = False

        ' Show instructions
        TBXInstructions.Visible = True
    End Sub

    Private Sub BTNContinue_Click(sender As Object, e As EventArgs) Handles BTNContinue.Click
        ' Verify sound status
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)

            ' Play the background music
            My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop)
        End If

        ' Hide used elements
        BTNInstructions.Visible = False
        BTNContinue.Visible = False
        TBXInstructions.Visible = False

        ' Prompt the player to guess the dice
        LBLMain.Text = "Veuillez deviner la somme des dés :"

        ' Show next elements
        LBLGuess.Visible = True
        TBXGuess.Visible = True
        BTNGuess.Visible = True
        LBLPlayedGames.Visible = True
        LBLWonGames.Visible = True
        LBLWinPercentage.Visible = True
    End Sub

    Private Sub BTNGuess_Click(sender As Object, e As EventArgs) Handles BTNGuess.Click
        ' Verify that the player's input is valid
        If TBXGuess.Text = "2" Or TBXGuess.Text = "3" Or TBXGuess.Text = "4" Or TBXGuess.Text = "5" Or TBXGuess.Text = "6" Or TBXGuess.Text = "7" Or TBXGuess.Text = "8" Or TBXGuess.Text = "9" Or TBXGuess.Text = "10" Or TBXGuess.Text = "11" Or TBXGuess.Text = "12" Then
            ' Save the guessed value
            DiceGuess = CInt(TBXGuess.Text)

            ' Save random values from 1 to 6 for the dice roll
            Dice1Roll = (Rnd() * 6) + 1
            Dice2Roll = (Rnd() * 6) + 1

            ' Hide used elements
            LBLGuess.Visible = False
            TBXGuess.Visible = False
            LBLGuessHint.Visible = False
            BTNGuess.Visible = False

            ' Compare the player's guess to the die roll
            If DiceGuess = Dice1Roll + Dice2Roll Then
                ' Announce the player's win
                LBLMain.Text = "Félicitations " + PlayerName + ", vôtre choix (" + CStr(DiceGuess) + ") est correcte!"

                ' Increment the number of won games
                WonGames += 1

                ' Play the win sound
                My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.WaitToComplete)
            Else
                ' Announce the player's loss
                LBLMain.Text = "Désolé " + PlayerName + ", vôtre choix (" + CStr(DiceGuess) + ") est incorrecte!"

                ' Play the loss sound
                My.Computer.Audio.Play(My.Resources.Loss, AudioPlayMode.WaitToComplete)
            End If

            ' Play the background music
            My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop)

            ' Increment the number of played games
            PlayedGames += 1

            ' Calculate win percentage
            WinPercentage = WonGames / PlayedGames * 100

            ' Change the statistics
            LBLPlayedGames.Text = "Parties jouées : " + CStr(PlayedGames)
            LBLWonGames.Text = "Parties gagnées : " + CStr(WonGames)
            LBLWinPercentage.Text = "Pourcentage de victoire : " + CStr(WinPercentage) + "%"

            ' Show the correct image to represent the first dice in the die roll
            If Dice1Roll = 1 Then
                PBXDice1.Image = My.Resources.Dice1
            ElseIf Dice1Roll = 2 Then
                PBXDice1.Image = My.Resources.Dice2
            ElseIf Dice1Roll = 3 Then
                PBXDice1.Image = My.Resources.Dice3
            ElseIf Dice1Roll = 4 Then
                PBXDice1.Image = My.Resources.Dice4
            ElseIf Dice1Roll = 5 Then
                PBXDice1.Image = My.Resources.Dice5
            ElseIf Dice1Roll = 6 Then
                PBXDice1.Image = My.Resources.Dice6
            End If

            ' Show the correct image to represent the second dice in the die roll
            If Dice2Roll = 1 Then
                PBXDice2.Image = My.Resources.Dice1
            ElseIf Dice2Roll = 2 Then
                PBXDice2.Image = My.Resources.Dice2
            ElseIf Dice2Roll = 3 Then
                PBXDice2.Image = My.Resources.Dice3
            ElseIf Dice2Roll = 4 Then
                PBXDice2.Image = My.Resources.Dice4
            ElseIf Dice2Roll = 5 Then
                PBXDice2.Image = My.Resources.Dice5
            ElseIf Dice2Roll = 6 Then
                PBXDice2.Image = My.Resources.Dice6
            End If

            ' Show next elements
            PBXDice1.Visible = True
            PBXDice2.Visible = True
            BTNRetry.Visible = True
        Else
            ' Show the dice guess hint
            LBLGuessHint.Visible = True

            ' Verify sound status
            If Sound = True Then
                ' Play the click sound
                My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)

                ' Play the background music
                My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop)
            End If
        End If
    End Sub

    Private Sub TBXDice_TextChanged(sender As Object, e As EventArgs) Handles TBXGuess.TextChanged
        LBLGuessHint.Visible = False
    End Sub

    Private Sub BTNRetry_Click(sender As Object, e As EventArgs) Handles BTNRetry.Click
        ' Verify sound status
        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)

            ' Play the background music
            My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop)
        End If

        ' Hide used elements
        PBXDice1.Visible = False
        PBXDice2.Visible = False
        BTNRetry.Visible = False

        ' Reset main text
        LBLMain.Text = "Veuillez deviner la somme des dés :"

        ' Reset guessing text box
        TBXGuess.Text = ""

        ' Show next elements
        LBLGuess.Visible = True
        TBXGuess.Visible = True
        BTNGuess.Visible = True

        ' Reset single-use variables
        DiceGuess = 12
        Dice1Roll = 6
        Dice2Roll = 6
    End Sub

    Private Sub PBXSound_Click(sender As Object, e As EventArgs) Handles PBXSound.Click
        ' Change the sound status
        Sound = Not Sound

        If Sound = True Then
            ' Play the click sound
            My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)

            ' Set the image to the green speaker
            PBXSound.Image = My.Resources.Unmute

            ' Play the background music
            My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop)
        Else
            ' Stop all audio
            My.Computer.Audio.Stop()

            ' Set the image to the red speaker
            PBXSound.Image = My.Resources.Mute
        End If
    End Sub

    Private Sub WNDMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Play the background music
        My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
