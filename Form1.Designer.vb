<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WNDMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WNDMain))
        LBLMain = New Label()
        LBLName = New Label()
        TBXName = New TextBox()
        LBLNameHint = New Label()
        BTNStart = New Button()
        BTNInstructions = New Button()
        BTNContinue = New Button()
        TBXInstructions = New TextBox()
        LBLDice1 = New Label()
        LBLDice2 = New Label()
        TBXDice1 = New TextBox()
        TBXDice2 = New TextBox()
        LBLDice1Hint = New Label()
        LBLDice2Hint = New Label()
        BTNGuess = New Button()
        LBLPlayedGames = New Label()
        LBLWonGames = New Label()
        LBLWinPercentage = New Label()
        BTNRestart = New Button()
        PBXDice1 = New PictureBox()
        PBXDice2 = New PictureBox()
        CType(PBXDice1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXDice2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LBLMain
        ' 
        LBLMain.AutoSize = True
        LBLMain.BackColor = Color.Transparent
        LBLMain.Font = New Font("Comic Sans MS", 40F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLMain.ForeColor = Color.Beige
        LBLMain.Location = New Point(12, 9)
        LBLMain.Name = "LBLMain"
        LBLMain.Size = New Size(988, 76)
        LBLMain.TabIndex = 0
        LBLMain.Text = "Bienvenue au jeu de simulation de dés!"
        ' 
        ' LBLName
        ' 
        LBLName.AutoSize = True
        LBLName.BackColor = Color.Transparent
        LBLName.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLName.ForeColor = Color.Beige
        LBLName.Location = New Point(338, 171)
        LBLName.Name = "LBLName"
        LBLName.Size = New Size(347, 38)
        LBLName.TabIndex = 1
        LBLName.Text = "Veuillez entrer vôtre nom:"
        ' 
        ' TBXName
        ' 
        TBXName.Location = New Point(338, 226)
        TBXName.Name = "TBXName"
        TBXName.Size = New Size(347, 23)
        TBXName.TabIndex = 2
        ' 
        ' LBLNameHint
        ' 
        LBLNameHint.AutoSize = True
        LBLNameHint.BackColor = Color.Transparent
        LBLNameHint.Font = New Font("Comic Sans MS", 10F)
        LBLNameHint.ForeColor = Color.Beige
        LBLNameHint.Location = New Point(414, 252)
        LBLNameHint.Name = "LBLNameHint"
        LBLNameHint.Size = New Size(180, 19)
        LBLNameHint.TabIndex = 3
        LBLNameHint.Text = "Veuilles entrer votre nom!"
        LBLNameHint.Visible = False
        ' 
        ' BTNStart
        ' 
        BTNStart.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNStart.Location = New Point(372, 376)
        BTNStart.Name = "BTNStart"
        BTNStart.Size = New Size(268, 81)
        BTNStart.TabIndex = 4
        BTNStart.Text = "Commencer!"
        BTNStart.UseVisualStyleBackColor = True
        ' 
        ' BTNInstructions
        ' 
        BTNInstructions.Font = New Font("Comic Sans MS", 25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNInstructions.Location = New Point(94, 226)
        BTNInstructions.Name = "BTNInstructions"
        BTNInstructions.Size = New Size(245, 100)
        BTNInstructions.TabIndex = 5
        BTNInstructions.Text = "Instructions"
        BTNInstructions.UseVisualStyleBackColor = True
        BTNInstructions.Visible = False
        ' 
        ' BTNContinue
        ' 
        BTNContinue.Font = New Font("Comic Sans MS", 25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNContinue.Location = New Point(645, 226)
        BTNContinue.Name = "BTNContinue"
        BTNContinue.Size = New Size(245, 100)
        BTNContinue.TabIndex = 6
        BTNContinue.Text = "Continuer!"
        BTNContinue.UseVisualStyleBackColor = True
        BTNContinue.Visible = False
        ' 
        ' TBXInstructions
        ' 
        TBXInstructions.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBXInstructions.Location = New Point(93, 185)
        TBXInstructions.Multiline = True
        TBXInstructions.Name = "TBXInstructions"
        TBXInstructions.ReadOnly = True
        TBXInstructions.Size = New Size(239, 195)
        TBXInstructions.TabIndex = 7
        TBXInstructions.Text = resources.GetString("TBXInstructions.Text")
        TBXInstructions.Visible = False
        ' 
        ' LBLDice1
        ' 
        LBLDice1.AutoSize = True
        LBLDice1.BackColor = Color.Transparent
        LBLDice1.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLDice1.ForeColor = Color.White
        LBLDice1.Location = New Point(205, 171)
        LBLDice1.Name = "LBLDice1"
        LBLDice1.Size = New Size(87, 38)
        LBLDice1.TabIndex = 8
        LBLDice1.Text = "Dé 1 :"
        LBLDice1.Visible = False
        ' 
        ' LBLDice2
        ' 
        LBLDice2.AutoSize = True
        LBLDice2.BackColor = Color.Transparent
        LBLDice2.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLDice2.ForeColor = Color.White
        LBLDice2.Location = New Point(749, 171)
        LBLDice2.Name = "LBLDice2"
        LBLDice2.Size = New Size(87, 38)
        LBLDice2.TabIndex = 9
        LBLDice2.Text = "Dé 1 :"
        LBLDice2.Visible = False
        ' 
        ' TBXDice1
        ' 
        TBXDice1.Location = New Point(205, 212)
        TBXDice1.Name = "TBXDice1"
        TBXDice1.Size = New Size(87, 23)
        TBXDice1.TabIndex = 10
        TBXDice1.Visible = False
        ' 
        ' TBXDice2
        ' 
        TBXDice2.Location = New Point(749, 212)
        TBXDice2.Name = "TBXDice2"
        TBXDice2.Size = New Size(87, 23)
        TBXDice2.TabIndex = 11
        TBXDice2.Visible = False
        ' 
        ' LBLDice1Hint
        ' 
        LBLDice1Hint.AutoSize = True
        LBLDice1Hint.BackColor = Color.Transparent
        LBLDice1Hint.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLDice1Hint.ForeColor = Color.White
        LBLDice1Hint.Location = New Point(148, 238)
        LBLDice1Hint.Name = "LBLDice1Hint"
        LBLDice1Hint.Size = New Size(201, 17)
        LBLDice1Hint.TabIndex = 12
        LBLDice1Hint.Text = "Veuillez entrer une valeur de 1 à 6!"
        LBLDice1Hint.Visible = False
        ' 
        ' LBLDice2Hint
        ' 
        LBLDice2Hint.AutoSize = True
        LBLDice2Hint.BackColor = Color.Transparent
        LBLDice2Hint.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLDice2Hint.ForeColor = Color.White
        LBLDice2Hint.Location = New Point(689, 238)
        LBLDice2Hint.Name = "LBLDice2Hint"
        LBLDice2Hint.Size = New Size(201, 17)
        LBLDice2Hint.TabIndex = 13
        LBLDice2Hint.Text = "Veuillez entrer une valeur de 1 à 6!"
        LBLDice2Hint.Visible = False
        ' 
        ' BTNGuess
        ' 
        BTNGuess.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNGuess.Location = New Point(372, 376)
        BTNGuess.Name = "BTNGuess"
        BTNGuess.Size = New Size(268, 81)
        BTNGuess.TabIndex = 14
        BTNGuess.Text = "Deviner!"
        BTNGuess.UseVisualStyleBackColor = True
        BTNGuess.Visible = False
        ' 
        ' LBLPlayedGames
        ' 
        LBLPlayedGames.AutoSize = True
        LBLPlayedGames.BackColor = Color.Transparent
        LBLPlayedGames.Font = New Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLPlayedGames.ForeColor = Color.White
        LBLPlayedGames.Location = New Point(12, 500)
        LBLPlayedGames.Name = "LBLPlayedGames"
        LBLPlayedGames.Size = New Size(174, 28)
        LBLPlayedGames.TabIndex = 15
        LBLPlayedGames.Text = "Parties jouées : 0"
        LBLPlayedGames.Visible = False
        ' 
        ' LBLWonGames
        ' 
        LBLWonGames.AutoSize = True
        LBLWonGames.BackColor = Color.Transparent
        LBLWonGames.Font = New Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWonGames.ForeColor = Color.White
        LBLWonGames.Location = New Point(414, 500)
        LBLWonGames.Name = "LBLWonGames"
        LBLWonGames.Size = New Size(187, 28)
        LBLWonGames.TabIndex = 16
        LBLWonGames.Text = "Parties gagnées : 0"
        LBLWonGames.Visible = False
        ' 
        ' LBLWinPercentage
        ' 
        LBLWinPercentage.AutoSize = True
        LBLWinPercentage.BackColor = Color.Transparent
        LBLWinPercentage.Font = New Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWinPercentage.ForeColor = Color.White
        LBLWinPercentage.Location = New Point(719, 500)
        LBLWinPercentage.Name = "LBLWinPercentage"
        LBLWinPercentage.Size = New Size(277, 28)
        LBLWinPercentage.TabIndex = 17
        LBLWinPercentage.Text = "Pourcentage de victoire : 0%"
        LBLWinPercentage.Visible = False
        ' 
        ' BTNRestart
        ' 
        BTNRestart.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNRestart.Location = New Point(338, 376)
        BTNRestart.Name = "BTNRestart"
        BTNRestart.Size = New Size(313, 81)
        BTNRestart.TabIndex = 18
        BTNRestart.Text = "Recommencer!"
        BTNRestart.UseVisualStyleBackColor = True
        BTNRestart.Visible = False
        ' 
        ' PBXDice1
        ' 
        PBXDice1.Location = New Point(107, 100)
        PBXDice1.Name = "PBXDice1"
        PBXDice1.Size = New Size(256, 256)
        PBXDice1.TabIndex = 19
        PBXDice1.TabStop = False
        PBXDice1.Visible = False
        ' 
        ' PBXDice2
        ' 
        PBXDice2.Location = New Point(623, 100)
        PBXDice2.Name = "PBXDice2"
        PBXDice2.Size = New Size(256, 256)
        PBXDice2.TabIndex = 20
        PBXDice2.TabStop = False
        PBXDice2.Visible = False
        ' 
        ' WNDMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Background2
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1008, 537)
        Controls.Add(PBXDice2)
        Controls.Add(PBXDice1)
        Controls.Add(BTNRestart)
        Controls.Add(LBLWinPercentage)
        Controls.Add(LBLWonGames)
        Controls.Add(LBLPlayedGames)
        Controls.Add(BTNGuess)
        Controls.Add(LBLDice2Hint)
        Controls.Add(LBLDice1Hint)
        Controls.Add(TBXDice2)
        Controls.Add(TBXDice1)
        Controls.Add(LBLDice2)
        Controls.Add(LBLDice1)
        Controls.Add(TBXInstructions)
        Controls.Add(BTNContinue)
        Controls.Add(BTNInstructions)
        Controls.Add(BTNStart)
        Controls.Add(LBLNameHint)
        Controls.Add(TBXName)
        Controls.Add(LBLName)
        Controls.Add(LBLMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "WNDMain"
        Text = "Dice Game 2"
        CType(PBXDice1, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXDice2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBLMain As Label
    Friend WithEvents LBLName As Label
    Friend WithEvents TBXName As TextBox
    Friend WithEvents LBLNameHint As Label
    Friend WithEvents BTNStart As Button
    Friend WithEvents BTNInstructions As Button
    Friend WithEvents BTNContinue As Button
    Friend WithEvents TBXInstructions As TextBox
    Friend WithEvents LBLDice1 As Label
    Friend WithEvents LBLDice2 As Label
    Friend WithEvents TBXDice1 As TextBox
    Friend WithEvents TBXDice2 As TextBox
    Friend WithEvents LBLDice1Hint As Label
    Friend WithEvents LBLDice2Hint As Label
    Friend WithEvents BTNGuess As Button
    Friend WithEvents LBLPlayedGames As Label
    Friend WithEvents LBLWonGames As Label
    Friend WithEvents LBLWinPercentage As Label
    Friend WithEvents BTNRestart As Button
    Friend WithEvents PBXDice1 As PictureBox
    Friend WithEvents PBXDice2 As PictureBox

End Class
