Public Class Form1
    Dim lSide As Decimal
    Dim nSide As Integer
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lSide = Val(txtLenghtSides.Text)
        nSide = Val(txtnumSides.Text)
        If lSide <= 0 And nSide <= 2 Then
            MessageBox.Show("Please enter a positive numbers in both fields")
        ElseIf lSide <= 0 Then
            MessageBox.Show("Please enter a valid number from 0 and upwards into the length of the side.")
        ElseIf nSide <= 2 Then
            MessageBox.Show("Please enter a valid number from 3 and upwards into the amount of sides.")
        Else
            Dim perimeter As Decimal = Math.Round(nSide * lSide, 3)
            Dim apothem As Decimal = lSide / (2 * Math.Tan(180 / nSide))
            Dim area As Decimal = Math.Round((apothem * perimeter) / 2, 3)
            lstResults.Items.Add("You have " & nSide & " sides and the length of one side is " & lSide & " cm.")
            lstResults.Items.Add("The area is " & area & " cm^2.")
            lstResults.Items.Add("The perimeter is " & perimeter & " cm.")



        End If
        
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtnumSides.Text = ""
        txtLenghtSides.Text = ""
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstResults.Items.Clear()
        txtnumSides.Text = ""
        txtLenghtSides.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
