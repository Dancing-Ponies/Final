<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Favorite_Types_Of_Amimals
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.lstAnimals = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What are your favorite animals?"
        '
        'BtnEnter
        '
        Me.BtnEnter.Location = New System.Drawing.Point(65, 273)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnter.TabIndex = 13
        Me.BtnEnter.Text = "Enter"
        Me.BtnEnter.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(292, 273)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'lstAnimals
        '
        Me.lstAnimals.FormattingEnabled = True
        Me.lstAnimals.Location = New System.Drawing.Point(65, 80)
        Me.lstAnimals.Name = "lstAnimals"
        Me.lstAnimals.Size = New System.Drawing.Size(302, 173)
        Me.lstAnimals.TabIndex = 15
        '
        'Favorite_Types_Of_Amimals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 332)
        Me.Controls.Add(Me.lstAnimals)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Favorite_Types_Of_Amimals"
        Me.Text = "Favorite_Types_of_Animals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnEnter As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents lstAnimals As System.Windows.Forms.ListBox
End Class
