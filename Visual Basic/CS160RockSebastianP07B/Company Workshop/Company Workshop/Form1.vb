' Name: Sebastian Rock
' Class: CS 160 01
' Assignment: Program 7B
' Due Date: May 8
' Description: Calculates the costs of workshops, puts them in a list, and then calculates the total cost

Public Class Workshop

    Function WorkshopPlace() As Integer    ' I used a function since this repeats multiple times in the
        Select Case lstLocation.SelectedItem ' second case statement.
            Case "Austin"
                Return 95  ' Returns the cost of going to Austin
            Case "Chicago"
                Return 125 ' Returns the cost of going to Chicago
            Case "Dallas"
                Return 110 ' Returns the cost of going to Dallas
            Case "Orlando"
                Return 100 ' Returns the cost of going to Orlando
            Case "Phoenix"
                Return 92  ' Returns the cost of going to Phoenix
            Case "Raleigh"
                Return 90  ' Returns the cost of going to Raleigh
            Case Else
                MessageBox.Show("Please select a location.")    ' Returns an error if no location is selected
        End Select
    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()   ' CLoses the program
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim intRegFee As Integer   ' Cost of registration
        Dim intDays As Integer     ' The number of days the workshop takes
        Dim intLodging As Integer  ' The fee per night to stay in the location
        Dim intTotalLodging        ' The total cost for all the nights stayed
        Dim intTotal As Integer    ' The total cost of attending the workshop

        Select Case lstWorkshop.SelectedItem
            Case "Handling Stress"
                intRegFee = 595
                intDays = 3
                intLodging = WorkshopPlace()
            Case "Time Management"
                intRegFee = 695
                intDays = 3
                intLodging = WorkshopPlace()
            Case "Supervision Skills"
                intRegFee = 995
                intDays = 3
                intLodging = WorkshopPlace()
            Case "Negotiation"
                intRegFee = 1295
                intDays = 5
                intLodging = WorkshopPlace()
            Case "How to Interview"
                intRegFee = 395
                intDays = 1
                intLodging = WorkshopPlace()
            Case Else
                MessageBox.Show("Select a workshop.")

        End Select

        intTotalLodging = intDays * intLodging
        intTotal = intRegFee + intTotalLodging

        lstCosts.Items.Add(intTotal)
    End Sub

    Private Sub btnTotal_Click(sender As System.Object, e As System.EventArgs) Handles btnTotal.Click
        Dim intTotal As Integer    ' Holds the total cost
        Dim x As Integer           ' Just used for the for loop

        For x = 0 To lstCosts.Items.Count - 1      ' Since it starts at zero, we subtract 
            intTotal += Val(lstCosts.Items(x))     ' one from the total number in the list.
        Next

        lblTotal.Text = intTotal.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lblTotal.Text = String.Empty    ' Clears the total
        lstCosts.Items.Clear()          ' Clears the cost list
        lstLocation.ClearSelected()     ' Deselects location (if any)
        lstWorkshop.ClearSelected()     ' Deselects workshop (if any)
    End Sub
End Class
