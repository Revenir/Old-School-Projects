' Name: Sebastian Rock
' Program: 05
' Date: 4/2/2013
' Class: CS 160
' Description: Calculates the tax for a person's monthly income

Public Class Form1

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        ' Declare Variables
        Dim dblMonthlyEarnings As Double
        Dim dblCountyTax As Double
        Dim dblStateTax As Double
        Dim dblCityTax As Double
        Dim dblTotalTax As Double

        ' Declare Constants
        Const decCountyRate As Decimal = 0.02
        Const decStateRate As Decimal = 0.04
        Const decCityRate As Decimal = 0.01

        If chkCity.Checked = True Then
            dblMonthlyEarnings = CDbl(txtMonthlySales.Text)

            dblCountyTax = dblMonthlyEarnings * decCountyRate
            dblStateTax = dblMonthlyEarnings * decStateRate
            dblCityTax = dblMonthlyEarnings * decCityRate
            dblTotalTax = dblStateTax + dblCountyTax + dblCityTax

            lblCountyTax.Text = dblCountyTax.ToString("c")
            lblStateTax.Text = dblStateTax.ToString("c")
            lblCityTax.Text = dblCityTax.ToString("c")
            lblTotalTax.Text = dblTotalTax.ToString("c")
        Else
            dblMonthlyEarnings = CDbl(txtMonthlySales.Text)

            dblCountyTax = dblMonthlyEarnings * decCountyRate
            dblStateTax = dblMonthlyEarnings * decStateRate
            dblCityTax = 0
            dblTotalTax = dblStateTax + dblCountyTax

            lblCountyTax.Text = dblCountyTax.ToString("c")
            lblStateTax.Text = dblStateTax.ToString("c")
            lblCityTax.Text = dblCityTax.ToString("c")
            lblTotalTax.Text = dblTotalTax.ToString("c")
        End If


    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtMonthlySales.Clear()
        lblCountyTax.Text = String.Empty
        lblStateTax.Text = String.Empty
        lblTotalTax.Text = String.Empty
        lblCountyTax.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
