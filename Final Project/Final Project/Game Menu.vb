Public Class Game_Menu
    Dim startSoundSystemThemeSong As New System.Media.SoundPlayer("C:\Users\cl131301\Desktop\Final\Final Project\Final Project\Resources\AD-FinalCountdown_pt2.wav")

    Private Sub btnHorseRace_Click(sender As Object, e As EventArgs) Handles btnHorseRace.Click
        Dim box = New Horse_Race
        box.Show()
        startSoundSystemThemeSong.Stop()
    End Sub

    Private Sub btnLionsTigersBears_Click(sender As Object, e As EventArgs) Handles btnLionsTigersBears.Click
        Dim box = New Lions__Tigers__Bears
        box.Show()
        startSoundSystemThemeSong.Stop()
    End Sub

    Private Sub btnGameOfLuck_Click(sender As Object, e As EventArgs) Handles btnGameOfLuck.Click
        Dim box = New Game_of_Luck
        box.Show()
        startSoundSystemThemeSong.Stop()
    End Sub

    Private Sub btnPetsOwned_click(sender As Object, e As EventArgs) Handles btnPetsOwned.Click
        Dim box = New Pets_Owned
        box.Show()
        startSoundSystemThemeSong.Stop()
    End Sub

    Private Sub btnFavorite_Types_Of_Aminals_Click(sender As Object, e As EventArgs) Handles btnFavorite_Types_Of_Aminals.Click
        Dim box = New Favorite_Types_Of_Amimals
        box.Show()
        startSoundSystemThemeSong.Stop()
    End Sub

    Private Sub Game_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startSoundSystemThemeSong.Play()
    End Sub
End Class