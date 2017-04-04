
' Class: CS 160
' Assignment: Program 04
' Due Date: March 19
' Description: Calculates the number of slices for round and square pizzas

Public Class Form1

    Private Sub Sq_CheckedChanged(sender As Object, e As EventArgs) Handles Sq.CheckedChanged
        ' Sq is checked by default
        If Sq.Checked = True Then ' User chooses to make a square pizza
            txtDiameter.ReadOnly = True
            txtDiameter.Clear() ' Clears any numbers that might have been typed, since the pizza isn't round
            txtLength.ReadOnly = False ' In case the user has selected the radio button for round,
            txtWidth.ReadOnly = False  ' This changes the textbox so it can be used again.
        End If
    End Sub

    Private Sub Rd_CheckedChanged(sender As Object, e As EventArgs) Handles Rd.CheckedChanged
        If Rd.Checked = True Then ' User chooses to make a round pizza
            txtLength.ReadOnly = True ' This textbox can't be used for round pizzas
            txtLength.Clear() ' Clears any numbers that might have been typed, since the pizza is not square
            txtWidth.ReadOnly = True ' This textbox can't be used for round pizzas
            txtWidth.Clear() ' Clears any numbers here, since the pizza is not square
            txtDiameter.ReadOnly = False ' Allows the textbox to be used, in case the user clicks the radio buttons
            ' Multiple times
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblDiameter As Double           ' Diameter of round pizza
        Dim dblRadius As Double             ' Radius of round pizza
        Dim dblLength As Double             ' Length of square pizza
        Dim dblWidth As Double              ' Width of square pizza
        Dim dblArea As Double               ' Area of pizza
        Dim intSliceNum As Integer          ' Number of slices
        Const Pi As Double = 3.14159        ' Constant Pi
        Const dblrSliceArea As Double = 14.125 ' Constant slice area for round pizzas
        Const intsSliceArea As Integer = 12    ' Constant slice area for square pizzas


        Try
            If Rd.Checked = True Then
                dblDiameter = CDbl(txtDiameter.Text)

                dblRadius = dblDiameter / 2
                dblArea = Pi * (dblRadius * dblRadius) ' Multiply radius by itself since the a = Pi*r^2
                intSliceNum = dblArea / dblrSliceArea   ' Divide area by slice area to get number of slices

                lblNumSlices.Text = intSliceNum.ToString() ' Displays number of slices in label
            ElseIf Sq.Checked = True Then
                dblLength = CDbl(txtLength.Text)
                dblWidth = CDbl(txtWidth.Text)

                dblArea = dblLength * dblWidth
                intSliceNum = dblArea / intsSliceArea

                lblNumSlices.Text = intSliceNum.ToString() ' Displays number of slices in label

            End If
        Catch ex As Exception
            MessageBox.Show("Please make sure all values are positive, real numbers.")

        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears all the boxes
        txtLength.Clear()
        txtWidth.Clear()
        txtDiameter.Clear()
        lblNumSlices.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes the program
    End Sub
End Class
