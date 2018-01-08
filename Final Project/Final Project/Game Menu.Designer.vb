<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPetsOwned = New System.Windows.Forms.Button()
        Me.btnHorseRace = New System.Windows.Forms.Button()
        Me.btnLionsTigersBears = New System.Windows.Forms.Button()
        Me.btnGameOfLuck = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFavorite_Types_Of_Aminals = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPetsOwned
        '
        Me.btnPetsOwned.Location = New System.Drawing.Point(180, 121)
        Me.btnPetsOwned.Name = "btnPetsOwned"
        Me.btnPetsOwned.Size = New System.Drawing.Size(82, 37)
        Me.btnPetsOwned.TabIndex = 0
        Me.btnPetsOwned.Text = "Pets Owned "
        Me.btnPetsOwned.UseVisualStyleBackColor = True
        '
        'btnHorseRace
        '
        Me.btnHorseRace.Location = New System.Drawing.Point(180, 180)
        Me.btnHorseRace.Name = "btnHorseRace"
        Me.btnHorseRace.Size = New System.Drawing.Size(82, 41)
        Me.btnHorseRace.TabIndex = 1
        Me.btnHorseRace.Text = "Horse Race"
        Me.btnHorseRace.UseVisualStyleBackColor = True
        '
        'btnLionsTigersBears
        '
        Me.btnLionsTigersBears.Location = New System.Drawing.Point(180, 243)
        Me.btnLionsTigersBears.Name = "btnLionsTigersBears"
        Me.btnLionsTigersBears.Size = New System.Drawing.Size(82, 38)
        Me.btnLionsTigersBears.TabIndex = 2
        Me.btnLionsTigersBears.Text = "Lions, Tigers, Bears"
        Me.btnLionsTigersBears.UseVisualStyleBackColor = True
        '
        'btnGameOfLuck
        '
        Me.btnGameOfLuck.Location = New System.Drawing.Point(180, 304)
        Me.btnGameOfLuck.Name = "btnGameOfLuck"
        Me.btnGameOfLuck.Size = New System.Drawing.Size(82, 41)
        Me.btnGameOfLuck.TabIndex = 3
        Me.btnGameOfLuck.Text = "Game of Luck"
        Me.btnGameOfLuck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 44)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Animal Games"
        '
        'btnFavorite_Types_Of_Aminals
        '
        Me.btnFavorite_Types_Of_Aminals.Location = New System.Drawing.Point(180, 366)
        Me.btnFavorite_Types_Of_Aminals.Name = "btnFavorite_Types_Of_Aminals"
        Me.btnFavorite_Types_Of_Aminals.Size = New System.Drawing.Size(82, 47)
        Me.btnFavorite_Types_Of_Aminals.TabIndex = 5
        Me.btnFavorite_Types_Of_Aminals.Text = "Favorite Types of Animals"
        Me.btnFavorite_Types_Of_Aminals.UseVisualStyleBackColor = True
        '
        'Game_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(444, 425)
        Me.Controls.Add(Me.btnFavorite_Types_Of_Aminals)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGameOfLuck)
        Me.Controls.Add(Me.btnLionsTigersBears)
        Me.Controls.Add(Me.btnHorseRace)
        Me.Controls.Add(Me.btnPetsOwned)
        Me.Name = "Game_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPetsOwned As System.Windows.Forms.Button
    Friend WithEvents btnHorseRace As System.Windows.Forms.Button
    Friend WithEvents btnLionsTigersBears As System.Windows.Forms.Button
    Friend WithEvents btnGameOfLuck As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFavorite_Types_Of_Aminals As System.Windows.Forms.Button
End Class
