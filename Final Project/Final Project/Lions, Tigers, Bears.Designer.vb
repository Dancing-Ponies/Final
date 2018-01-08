<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lions__Tigers__Bears
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lions__Tigers__Bears))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lionRadioButton = New System.Windows.Forms.RadioButton()
        Me.tigerRadioButton = New System.Windows.Forms.RadioButton()
        Me.bearRadioButton = New System.Windows.Forms.RadioButton()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblComputerScore = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(226, 94)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 178)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(436, 94)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(204, 178)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SketchFlow Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pick one:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SketchFlow Print", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 34)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lions Tigers Bears"
        '
        'lionRadioButton
        '
        Me.lionRadioButton.AutoSize = True
        Me.lionRadioButton.Location = New System.Drawing.Point(78, 324)
        Me.lionRadioButton.Name = "lionRadioButton"
        Me.lionRadioButton.Size = New System.Drawing.Size(50, 17)
        Me.lionRadioButton.TabIndex = 5
        Me.lionRadioButton.TabStop = True
        Me.lionRadioButton.Text = "Lions"
        Me.lionRadioButton.UseVisualStyleBackColor = True
        '
        'tigerRadioButton
        '
        Me.tigerRadioButton.AutoSize = True
        Me.tigerRadioButton.Location = New System.Drawing.Point(78, 347)
        Me.tigerRadioButton.Name = "tigerRadioButton"
        Me.tigerRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.tigerRadioButton.TabIndex = 6
        Me.tigerRadioButton.TabStop = True
        Me.tigerRadioButton.Text = "Tigers"
        Me.tigerRadioButton.UseVisualStyleBackColor = True
        '
        'bearRadioButton
        '
        Me.bearRadioButton.AutoSize = True
        Me.bearRadioButton.Location = New System.Drawing.Point(78, 370)
        Me.bearRadioButton.Name = "bearRadioButton"
        Me.bearRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.bearRadioButton.TabIndex = 7
        Me.bearRadioButton.TabStop = True
        Me.bearRadioButton.Text = "Bears"
        Me.bearRadioButton.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(408, 289)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 38)
        Me.btnGo.TabIndex = 8
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(408, 347)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Font = New System.Drawing.Font("SketchFlow Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel1.Location = New System.Drawing.Point(12, 424)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(136, 17)
        Me.lblLabel1.TabIndex = 10
        Me.lblLabel1.Text = "Player Score:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SketchFlow Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 494)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Computer Score:"
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayerScore.Location = New System.Drawing.Point(167, 425)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(100, 23)
        Me.lblPlayerScore.TabIndex = 12
        '
        'lblComputerScore
        '
        Me.lblComputerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComputerScore.Location = New System.Drawing.Point(183, 488)
        Me.lblComputerScore.Name = "lblComputerScore"
        Me.lblComputerScore.Size = New System.Drawing.Size(100, 23)
        Me.lblComputerScore.TabIndex = 13
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("SketchFlow Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(370, 426)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(270, 85)
        Me.lblResult.TabIndex = 14
        '
        'Lions__Tigers__Bears
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 540)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblComputerScore)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.bearRadioButton)
        Me.Controls.Add(Me.tigerRadioButton)
        Me.Controls.Add(Me.lionRadioButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Lions__Tigers__Bears"
        Me.Text = "Lions__Tigers__Bears"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lionRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents tigerRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents bearRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
    Friend WithEvents lblComputerScore As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
