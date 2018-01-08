Public Class Form1

    Dim intPairSelection As Integer
    Dim intPairSelcetion(2) As Integer
    Dim MoveCardBack(20) As Integer 'moves card seleceted to the back
    Dim intGuess As Integer 'keeps score of amount of times guessed
    Dim score As Integer 'score recieved

    Dim PicSelect(9) As PictureBox 'Selected images
    Dim picCardBack(19) As PictureBox 'Background of the cards

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        PicSelect(0) = picSelect1
        PicSelect(1) = PicSelect2
        PicSelect(2) = PicSelect3
        PicSelect(3) = PicSelect4
        PicSelect(4) = PicSelect5
        PicSelect(5) = PicSelect6
        PicSelect(6) = PicSelect7
        PicSelect(7) = PicSelect8
        PicSelect(8) = PicSelect9
        PicSelect(9) = PicSelect10

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
