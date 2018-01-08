Public Class Racing_Money
    Dim KonaResult As Integer
    Dim SecertariatResult As Integer
    Dim BarbaroResult As Integer
    Dim CaliforniaResult As Integer
    Dim ZenyettaResult As Integer
    Dim intBetValue As String
    Private Sub btnBet_Click(sender As Object, e As EventArgs) Handles btnBet.Click
        intBetValue = txtBet.Text
        If rbKona.Checked And KonaResult Then
            intBetValue = lblMoney.Text


        End If
    End Sub
End Class