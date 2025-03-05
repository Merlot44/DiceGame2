<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WNDMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PBXSound = New PictureBox()
        TBXGuess = New TextBox()
        BTNRetry = New Button()
        LBLWonGames = New Label()
        LBLPlayedGames = New Label()
        BTNGuess = New Button()
        LBLGuessHint = New Label()
        LBLGuess = New Label()
        BTNContinue = New Button()
        BTNInstructions = New Button()
        BTNStart = New Button()
        LBLNameHint = New Label()
        TBXName = New TextBox()
        LBLName = New Label()
        PBXDice1 = New PictureBox()
        PBXDice2 = New PictureBox()
        TBXInstructions = New TextBox()
        LBLMain = New Label()
        LBLWinPercentage = New Label()
        CType(PBXSound, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXDice1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXDice2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PBXSound
        ' 
        PBXSound.BackColor = Color.Transparent
        PBXSound.Image = My.Resources.Resources.Unmute
        PBXSound.Location = New Point(2, 5)
        PBXSound.Name = "PBXSound"
        PBXSound.Size = New Size(32, 32)
        PBXSound.SizeMode = PictureBoxSizeMode.StretchImage
        PBXSound.TabIndex = 41
        PBXSound.TabStop = False
        ' 
        ' TBXGuess
        ' 
        TBXGuess.BackColor = Color.Beige
        TBXGuess.Location = New Point(463, 244)
        TBXGuess.Name = "TBXGuess"
        TBXGuess.Size = New Size(87, 23)
        TBXGuess.TabIndex = 40
        TBXGuess.Visible = False
        ' 
        ' BTNRetry
        ' 
        BTNRetry.BackColor = Color.Beige
        BTNRetry.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNRetry.Location = New Point(346, 270)
        BTNRetry.Name = "BTNRetry"
        BTNRetry.Size = New Size(313, 81)
        BTNRetry.TabIndex = 37
        BTNRetry.Text = "Réessayer!"
        BTNRetry.UseVisualStyleBackColor = False
        BTNRetry.Visible = False
        ' 
        ' LBLWonGames
        ' 
        LBLWonGames.BackColor = Color.Transparent
        LBLWonGames.Font = New Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWonGames.ForeColor = Color.Beige
        LBLWonGames.Location = New Point(372, 504)
        LBLWonGames.Name = "LBLWonGames"
        LBLWonGames.Size = New Size(268, 28)
        LBLWonGames.TabIndex = 35
        LBLWonGames.Text = "Parties gagnées : 0"
        LBLWonGames.TextAlign = ContentAlignment.MiddleCenter
        LBLWonGames.Visible = False
        ' 
        ' LBLPlayedGames
        ' 
        LBLPlayedGames.BackColor = Color.Transparent
        LBLPlayedGames.Font = New Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLPlayedGames.ForeColor = Color.Beige
        LBLPlayedGames.Location = New Point(2, 504)
        LBLPlayedGames.Name = "LBLPlayedGames"
        LBLPlayedGames.Size = New Size(344, 28)
        LBLPlayedGames.TabIndex = 34
        LBLPlayedGames.Text = "Parties jouées : 0"
        LBLPlayedGames.TextAlign = ContentAlignment.MiddleLeft
        LBLPlayedGames.Visible = False
        ' 
        ' BTNGuess
        ' 
        BTNGuess.BackColor = Color.Beige
        BTNGuess.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNGuess.Location = New Point(372, 397)
        BTNGuess.Name = "BTNGuess"
        BTNGuess.Size = New Size(268, 81)
        BTNGuess.TabIndex = 33
        BTNGuess.Text = "Deviner!"
        BTNGuess.UseVisualStyleBackColor = False
        BTNGuess.Visible = False
        ' 
        ' LBLGuessHint
        ' 
        LBLGuessHint.AutoSize = True
        LBLGuessHint.BackColor = Color.Transparent
        LBLGuessHint.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLGuessHint.ForeColor = Color.Beige
        LBLGuessHint.Location = New Point(404, 270)
        LBLGuessHint.Name = "LBLGuessHint"
        LBLGuessHint.Size = New Size(208, 17)
        LBLGuessHint.TabIndex = 32
        LBLGuessHint.Text = "Veuillez entrer une valeur de 2 à 12!"
        LBLGuessHint.Visible = False
        ' 
        ' LBLGuess
        ' 
        LBLGuess.AutoSize = True
        LBLGuess.BackColor = Color.Transparent
        LBLGuess.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLGuess.ForeColor = Color.Beige
        LBLGuess.Location = New Point(447, 203)
        LBLGuess.Name = "LBLGuess"
        LBLGuess.Size = New Size(123, 38)
        LBLGuess.TabIndex = 31
        LBLGuess.Text = "Somme :"
        LBLGuess.Visible = False
        ' 
        ' BTNContinue
        ' 
        BTNContinue.BackColor = Color.Beige
        BTNContinue.Font = New Font("Comic Sans MS", 25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNContinue.Location = New Point(652, 230)
        BTNContinue.Name = "BTNContinue"
        BTNContinue.Size = New Size(245, 100)
        BTNContinue.TabIndex = 29
        BTNContinue.Text = "Continuer!"
        BTNContinue.UseVisualStyleBackColor = False
        BTNContinue.Visible = False
        ' 
        ' BTNInstructions
        ' 
        BTNInstructions.BackColor = Color.Beige
        BTNInstructions.Font = New Font("Comic Sans MS", 25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNInstructions.Location = New Point(101, 230)
        BTNInstructions.Name = "BTNInstructions"
        BTNInstructions.Size = New Size(245, 100)
        BTNInstructions.TabIndex = 28
        BTNInstructions.Text = "Instructions"
        BTNInstructions.UseVisualStyleBackColor = False
        BTNInstructions.Visible = False
        ' 
        ' BTNStart
        ' 
        BTNStart.BackColor = Color.Beige
        BTNStart.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNStart.Location = New Point(372, 397)
        BTNStart.Name = "BTNStart"
        BTNStart.Size = New Size(268, 81)
        BTNStart.TabIndex = 27
        BTNStart.Text = "Commencer!"
        BTNStart.UseVisualStyleBackColor = False
        ' 
        ' LBLNameHint
        ' 
        LBLNameHint.AutoSize = True
        LBLNameHint.BackColor = Color.Transparent
        LBLNameHint.Font = New Font("Comic Sans MS", 10F)
        LBLNameHint.ForeColor = Color.Beige
        LBLNameHint.Location = New Point(422, 270)
        LBLNameHint.Name = "LBLNameHint"
        LBLNameHint.Size = New Size(180, 19)
        LBLNameHint.TabIndex = 26
        LBLNameHint.Text = "Veuilles entrer votre nom!"
        LBLNameHint.Visible = False
        ' 
        ' TBXName
        ' 
        TBXName.BackColor = Color.Beige
        TBXName.Location = New Point(346, 244)
        TBXName.Name = "TBXName"
        TBXName.Size = New Size(347, 23)
        TBXName.TabIndex = 25
        ' 
        ' LBLName
        ' 
        LBLName.AutoSize = True
        LBLName.BackColor = Color.Transparent
        LBLName.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLName.ForeColor = Color.Beige
        LBLName.Location = New Point(346, 189)
        LBLName.Name = "LBLName"
        LBLName.Size = New Size(347, 38)
        LBLName.TabIndex = 24
        LBLName.Text = "Veuillez entrer vôtre nom:"
        ' 
        ' PBXDice1
        ' 
        PBXDice1.Location = New Point(32, 179)
        PBXDice1.Name = "PBXDice1"
        PBXDice1.Size = New Size(256, 256)
        PBXDice1.SizeMode = PictureBoxSizeMode.StretchImage
        PBXDice1.TabIndex = 38
        PBXDice1.TabStop = False
        PBXDice1.Visible = False
        ' 
        ' PBXDice2
        ' 
        PBXDice2.Location = New Point(719, 179)
        PBXDice2.Name = "PBXDice2"
        PBXDice2.Size = New Size(256, 256)
        PBXDice2.SizeMode = PictureBoxSizeMode.StretchImage
        PBXDice2.TabIndex = 39
        PBXDice2.TabStop = False
        PBXDice2.Visible = False
        ' 
        ' TBXInstructions
        ' 
        TBXInstructions.BackColor = Color.Beige
        TBXInstructions.Font = New Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBXInstructions.Location = New Point(32, 115)
        TBXInstructions.Multiline = True
        TBXInstructions.Name = "TBXInstructions"
        TBXInstructions.ReadOnly = True
        TBXInstructions.Size = New Size(538, 373)
        TBXInstructions.TabIndex = 30
        TBXInstructions.Text = resources.GetString("TBXInstructions.Text")
        TBXInstructions.Visible = False
        ' 
        ' LBLMain
        ' 
        LBLMain.BackColor = Color.Transparent
        LBLMain.Font = New Font("Comic Sans MS", 40F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLMain.ForeColor = Color.Beige
        LBLMain.Location = New Point(2, 23)
        LBLMain.Name = "LBLMain"
        LBLMain.Size = New Size(1005, 190)
        LBLMain.TabIndex = 23
        LBLMain.Text = "Bienvenue au jeu de simulation de dés!"
        LBLMain.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LBLWinPercentage
        ' 
        LBLWinPercentage.BackColor = Color.Transparent
        LBLWinPercentage.Font = New Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWinPercentage.ForeColor = Color.Beige
        LBLWinPercentage.Location = New Point(652, 504)
        LBLWinPercentage.Name = "LBLWinPercentage"
        LBLWinPercentage.Size = New Size(355, 28)
        LBLWinPercentage.TabIndex = 36
        LBLWinPercentage.Text = "Pourcentage de réussite : 0%"
        LBLWinPercentage.TextAlign = ContentAlignment.MiddleRight
        LBLWinPercentage.Visible = False
        ' 
        ' WNDMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Background
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1008, 537)
        Controls.Add(TBXInstructions)
        Controls.Add(PBXSound)
        Controls.Add(TBXGuess)
        Controls.Add(BTNRetry)
        Controls.Add(LBLWonGames)
        Controls.Add(LBLPlayedGames)
        Controls.Add(BTNGuess)
        Controls.Add(LBLGuessHint)
        Controls.Add(LBLGuess)
        Controls.Add(BTNContinue)
        Controls.Add(BTNInstructions)
        Controls.Add(BTNStart)
        Controls.Add(LBLNameHint)
        Controls.Add(TBXName)
        Controls.Add(LBLName)
        Controls.Add(PBXDice1)
        Controls.Add(PBXDice2)
        Controls.Add(LBLMain)
        Controls.Add(LBLWinPercentage)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "WNDMain"
        Text = "Dice Game 2"
        CType(PBXSound, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXDice1, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXDice2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PBXSound As PictureBox
    Friend WithEvents TBXGuess As TextBox
    Friend WithEvents BTNRetry As Button
    Friend WithEvents LBLWonGames As Label
    Friend WithEvents LBLPlayedGames As Label
    Friend WithEvents BTNGuess As Button
    Friend WithEvents LBLGuessHint As Label
    Friend WithEvents LBLGuess As Label
    Friend WithEvents BTNContinue As Button
    Friend WithEvents BTNInstructions As Button
    Friend WithEvents BTNStart As Button
    Friend WithEvents LBLNameHint As Label
    Friend WithEvents TBXName As TextBox
    Friend WithEvents LBLName As Label
    Friend WithEvents PBXDice1 As PictureBox
    Friend WithEvents PBXDice2 As PictureBox
    Friend WithEvents TBXInstructions As TextBox
    Friend WithEvents LBLMain As Label
    Friend WithEvents LBLWinPercentage As Label

End Class
