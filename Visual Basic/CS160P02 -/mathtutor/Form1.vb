
' Class: CS 160 01
' Program Number: 2
' Due Date: 2/7/2013
' Description: Solves a math problem

Public Class Form1

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        lblQuestionMark.Visible = False
        lblAnswer.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lblMathProb_Click(sender As Object, e As EventArgs) Handles lblMathProb.Click

    End Sub

    Private Sub lblQuestionMark_Click(sender As Object, e As EventArgs) Handles lblQuestionMark.Click

    End Sub

    Private Sub lblAnswer_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub
End Class
