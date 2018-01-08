Public Class Favorite_Types_Of_Amimals

    Private Sub BtnEnter_Click_1(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Const intMax_SUBSCRIPT As Integer = 4 'Max subscripts.'
        Dim StrAnimalTypes(intMax_SUBSCRIPT) As String 'array to hold name of animals.'
        Dim intCount As Integer

        'telling player what they are going to do.'
        MessageBox.Show("I'm going to ask you to enter the types " & "of your five favorite animals.")
        'get names and store them in arrays'
        For intCount = 0 To intMax_SUBSCRIPT
            StrAnimalTypes(intCount) = InputBox("Enter your favorite type of animal.")
        Next
        'Clearing the listbox and its contents.'
        lstAnimals.Items.Clear()
        'display the contents of the array in a list box.'
        For intCount = 0 To intMax_SUBSCRIPT
            lstAnimals.Items.Add("Your favorite animal is: " & StrAnimalTypes(intCount))
        Next
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class