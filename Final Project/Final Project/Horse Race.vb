Public Class Horse_Race
    Dim KonaResult As Integer
    Dim SecertariatResult As Integer
    Dim BarbaroResult As Integer
    Dim CaliforniaResult As Integer
    Dim ZenyettaResult As Integer
    Dim startSoundSystemRace As New System.Media.SoundPlayer("C:\Users\cl131301\Desktop\Final\Final Project\Final Project\Resources\brasswoodwinds-musical-instruments-trumpet-charge-horse-race-01.wav")
    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim IntWinner As Integer
        Dim intcount, intcount1, intcount2, intcount3, intcount4 As Integer
        Dim rand As New Random

        'horse named kona movement'
        IntWinner = rand.Next(4)
        startSoundSystemRace.Play()
        For intcount = 185 To rand.Next(50) + 693
            PicKonasKannon.Left = intcount
            'KonaResult = KonaResult + 1
        Next
        'horse named secertariat movement'
        For intcount1 = 185 To rand.Next(50) + 693
            PicSecertariat.Left = intcount1
            'SecertariatResult = SecertariatResult + 1
        Next
        'barbaro's movement'
        For intcount2 = 185 To rand.Next(50) + 693
            PicBarbaro.Left = intcount2
            ' BarbaroResult = BarbaroResult + 1
        Next
        For intcount3 = 185 To rand.Next(50) + 693
            PicCaliforniaCrome.Left = intcount3
            'CaliforniaResult = CaliforniaResult + 1
        Next
        'zenyetta's movement'
        For intcount4 = 185 To rand.Next(50) + 693
            PicZenyetta.Left = intcount4
            'ZenyettaResult = ZenyettaResult + 1
        Next
        'keeping score for horse that wins'
        If intcount > intcount1 And intcount2 And intcount3 And intcount4 Then
            KonaResult = KonaResult + 1
        ElseIf intcount1 > intcount And intcount2 And intcount3 And intcount4 Then
            SecertariatResult = SecertariatResult + 1
        ElseIf intcount2 > intcount And intcount1 And intcount3 And intcount4 Then
            BarbaroResult = BarbaroResult + 1
        ElseIf intcount3 > intcount And intcount1 And intcount2 And intcount4 Then
            CaliforniaResult = CaliforniaResult + 1
        ElseIf intcount4 > intcount And intcount1 And intcount2 And intcount3 Then
            ZenyettaResult = ZenyettaResult + 1
        End If
        lblBarbaro.Text = BarbaroResult.ToString
        lblCalifornia.Text = CaliforniaResult.ToString
        lblKona.Text = KonaResult.ToString
        lblSecertariat.Text = SecertariatResult.ToString
        lblZenyetta.Text = ZenyettaResult.ToString
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        startSoundSystemRace.Stop()
    End Sub
End Class