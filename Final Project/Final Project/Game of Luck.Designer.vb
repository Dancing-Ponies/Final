<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game_of_Luck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game_of_Luck))
        Me.picPig = New System.Windows.Forms.PictureBox()
        Me.picElephant = New System.Windows.Forms.PictureBox()
        Me.picFox = New System.Windows.Forms.PictureBox()
        Me.picOwl = New System.Windows.Forms.PictureBox()
        Me.picBunny = New System.Windows.Forms.PictureBox()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSpinAgain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picPig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picElephant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOwl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBunny, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPig
        '
        Me.picPig.Image = CType(resources.GetObject("picPig.Image"), System.Drawing.Image)
        Me.picPig.Location = New System.Drawing.Point(31, 114)
        Me.picPig.Name = "picPig"
        Me.picPig.Size = New System.Drawing.Size(145, 86)
        Me.picPig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPig.TabIndex = 0
        Me.picPig.TabStop = False
        '
        'picElephant
        '
        Me.picElephant.Image = CType(resources.GetObject("picElephant.Image"), System.Drawing.Image)
        Me.picElephant.Location = New System.Drawing.Point(194, 114)
        Me.picElephant.Name = "picElephant"
        Me.picElephant.Size = New System.Drawing.Size(145, 86)
        Me.picElephant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picElephant.TabIndex = 1
        Me.picElephant.TabStop = False
        '
        'picFox
        '
        Me.picFox.Image = CType(resources.GetObject("picFox.Image"), System.Drawing.Image)
        Me.picFox.Location = New System.Drawing.Point(356, 114)
        Me.picFox.Name = "picFox"
        Me.picFox.Size = New System.Drawing.Size(145, 86)
        Me.picFox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFox.TabIndex = 2
        Me.picFox.TabStop = False
        '
        'picOwl
        '
        Me.picOwl.Image = CType(resources.GetObject("picOwl.Image"), System.Drawing.Image)
        Me.picOwl.Location = New System.Drawing.Point(291, 242)
        Me.picOwl.Name = "picOwl"
        Me.picOwl.Size = New System.Drawing.Size(145, 86)
        Me.picOwl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOwl.TabIndex = 3
        Me.picOwl.TabStop = False
        '
        'picBunny
        '
        Me.picBunny.Image = CType(resources.GetObject("picBunny.Image"), System.Drawing.Image)
        Me.picBunny.Location = New System.Drawing.Point(108, 242)
        Me.picBunny.Name = "picBunny"
        Me.picBunny.Size = New System.Drawing.Size(145, 86)
        Me.picBunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBunny.TabIndex = 4
        Me.picBunny.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(126, 380)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(75, 23)
        Me.btnSpin.TabIndex = 5
        Me.btnSpin.Text = "Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("SketchFlow Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(105, 442)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(331, 89)
        Me.lblResult.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(308, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSpinAgain
        '
        Me.btnSpinAgain.Location = New System.Drawing.Point(218, 380)
        Me.btnSpinAgain.Name = "btnSpinAgain"
        Me.btnSpinAgain.Size = New System.Drawing.Size(75, 23)
        Me.btnSpinAgain.TabIndex = 8
        Me.btnSpinAgain.Text = "Reset"
        Me.btnSpinAgain.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SketchFlow Print", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(86, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "How lucky are you?"
        '
        'Game_of_Luck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(576, 540)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSpinAgain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.picBunny)
        Me.Controls.Add(Me.picOwl)
        Me.Controls.Add(Me.picFox)
        Me.Controls.Add(Me.picElephant)
        Me.Controls.Add(Me.picPig)
        Me.Name = "Game_of_Luck"
        Me.Text = "Game_of_Luck"
        CType(Me.picPig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picElephant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOwl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBunny, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPig As System.Windows.Forms.PictureBox
    Friend WithEvents picElephant As System.Windows.Forms.PictureBox
    Friend WithEvents picFox As System.Windows.Forms.PictureBox
    Friend WithEvents picOwl As System.Windows.Forms.PictureBox
    Friend WithEvents picBunny As System.Windows.Forms.PictureBox
    Friend WithEvents btnSpin As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSpinAgain As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
