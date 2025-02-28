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
        SuspendLayout()
        ' 
        ' LBLMain
        ' 
        LBLMain.AutoSize = True
        LBLMain.BackColor = Color.Transparent
        LBLMain.Font = New Font("Comic Sans MS", 40F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLMain.ForeColor = Color.White
        LBLMain.Location = New Point(292, 9)
        LBLMain.Name = "LBLMain"
        LBLMain.Size = New Size(191, 76)
        LBLMain.TabIndex = 0
        LBLMain.Text = "Label1"
        ' 
        ' WNDMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Background2
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1008, 537)
        Controls.Add(LBLMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "WNDMain"
        Text = "Dice Game 2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBLMain As Label

End Class
