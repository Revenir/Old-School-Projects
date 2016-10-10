' Name: Sebastian Rock
' Class: CS 160
' Assignment: Program 03B
' Due Date: February 28
' Calculates the revenue from movie tickets for children and adults.


Public Class Form1

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Const decTheaterPercent As Decimal = 0.2D    ' Amount Theater takes off its boc office receipts
        Dim intAdultTkts As Integer                  ' Adult Tickets sold
        Dim intChildTkts As Integer                  ' Child Tickets sold
        Dim decAdultPrc As Decimal                   ' Price per adult ticket
        Dim decChildPrc As Decimal                   ' Price per child ticket
        Dim decGrsChild As Decimal                   ' Gross child ticket sales
        Dim decGrsAdult As Decimal                   ' Gross adult ticket sales
        Dim decGrsTotal As Decimal                   ' Gross revenue
        Dim decNetChild As Decimal                   ' Net child ticket sales
        Dim decNetAdult As Decimal                   ' Net adult ticket sales
        Dim decNetTotal As Decimal                   ' Net revenue

        Try
            ' Takes the values from the text boxes
            intAdultTkts = CInt(txtAdultTicket.Text)
            intChildTkts = CInt(txtChildTickets.Text)
            decAdultPrc = CDec(txtAdultPrice.Text)
            decChildPrc = CDec(txtChildPrice.Text)

            ' calculates gross prices
            decGrsAdult = decAdultPrc * intAdultTkts
            decGrsChild = decChildPrc * intChildTkts
            decGrsTotal = decGrsAdult + decGrsChild

            ' calculates net prices
            decNetAdult = decGrsAdult * decTheaterPercent
            decNetChild = decGrsChild * decTheaterPercent
            decNetTotal = decGrsTotal * decTheaterPercent

            ' prints out the values
            txtGrossAdult.Text = decGrsAdult.ToString("c")
            txtGrossChild.Text = decGrsChild.ToString("c")
            txtGrossRev.Text = decGrsTotal.ToString("c")

            txtNetAdult.Text = decNetAdult.ToString("c")
            txtNetChild.Text = decNetChild.ToString("c")
            txtNetRev.Text = decNetTotal.ToString("c")


        Catch
            ' Display an error message if they don't type numeric values
            MessageBox.Show("Error: Be sure to enter nonzero " &
                            "numeric values.")

        End Try

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        ' Exit the program
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ' Clears everything
        txtAdultPrice.Clear()
        txtAdultTicket.Clear()
        txtChildPrice.Clear()
        txtChildTickets.Clear()


        txtGrossAdult.Clear()
        txtGrossChild.Clear()
        txtGrossRev.Clear()

        txtNetAdult.Clear()
        txtNetChild.Clear()
        txtNetRev.Clear()
    End Sub
End Class
