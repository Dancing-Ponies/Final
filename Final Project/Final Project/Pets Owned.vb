Public Class Pets_Owned

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim intNumAverage As Integer
        Dim dblPetsOwned As Double
        Dim dblTotal As Double = 0
        Dim dblAverage As Double
        Dim strInput As String
        Dim intCount As Integer = 1
        'staring when you choose how many owners you wants to average.'
        strInput = InputBox("How many owners do you want to average?")
        If Integer.TryParse(strInput, intNumAverage) Then
            Do Until intCount > intNumAverage
                'Amount of animals owned by each owner.'
                strInput = InputBox("Enter amount of aniamls owned " & intCount.ToString())
                If Double.TryParse(strInput, dblPetsOwned) Then
                    dblTotal += dblPetsOwned
                    intCount += 1
                Else
                    'Invailid numbers such as decimals or fractions.'
                    MessageBox.Show("Enter a valid number of animals owned.")
                End If
            Loop
            'Calculations
            If intNumAverage > 0 Then
                dblAverage = dblTotal / intNumAverage
                lblPetsAverage.Text = dblAverage.ToString()
            End If

        Else
            MessageBox.Show(" Enter an interger value for the number of pets owned.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
