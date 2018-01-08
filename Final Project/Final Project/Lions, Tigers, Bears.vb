Public Class Lions__Tigers__Bears
    Dim winCount As Integer = 0
    Dim compCount As Integer = 0
    Dim startSoundSystemLion As New System.Media.SoundPlayer("http://www.animal-sounds.org/jungle/Lioness%20growl%20animals109.wav")
    Dim startSoundSysytemTiger As New System.Media.SoundPlayer("C:\Users\cl131301\Desktop\Final\Final Project\Final Project\Resources\Tiger growl animals026.wav")
    Dim startSoundSystemBear As New System.Media.SoundPlayer("C:\Users\cl131301\Desktop\Final\Final Project\Final Project\Resources\bear-roar.wav")

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim num As Integer ' variable to hold random number (computer choice)
        Const LION = 1  'This would be rock
        Const TIGER = 2 'Paper
        Const BEAR = 3 'scissors

        num = CInt((3 * Rnd())) ' generate random numbers 1-3

        If lionRadioButton.Checked And num = LION Then
            lblResult.Text = "The computer chose lion too. Tie!"
        ElseIf lionRadioButton.Checked And num = TIGER Then
            lblResult.Text = "The computer chose tiger. You lose!"
            compCount += 1
        ElseIf lionRadioButton.Checked And num = BEAR Then
            lblResult.Text = "The computer chose bear. You win!"
            winCount += 1
        ElseIf tigerRadioButton.Checked And num = LION Then
            lblResult.Text = "The computer chose lion. You win!"
            winCount += 1
        ElseIf tigerRadioButton.Checked And num = TIGER Then
            lblResult.Text = "The computer chose tiger too. Tie!"
        ElseIf tigerRadioButton.Checked And num = BEAR Then
            lblResult.Text = "The computer chose bear. You lose!"
            compCount += 1
        ElseIf bearRadioButton.Checked And num = LION Then
            lblResult.Text = "The computer chose lion. You lose!"
            compCount += 1
        ElseIf bearRadioButton.Checked And num = TIGER Then
            lblResult.Text = "The computer chose tiger. You win"
            winCount += 1
        ElseIf bearRadioButton.Checked And num = BEAR Then
            lblResult.Text = "The computer chose bear too. Tie"
        End If

        lblPlayerScore.Text = winCount
        lblComputerScore.Text = compCount
        If lionRadioButton.Checked Then startSoundSystemLion.Play()
        If tigerRadioButton.Checked Then startSoundSysytemTiger.Play()
        If bearRadioButton.Checked Then startSoundSystemBear.Play()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class