���   �   lSystem.Resources.ResourceReader, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089#System.Resources.RuntimeResourceSet           PADPADP�                                                                                                                                                                                                                                                                                                                                               ek.Clear()
        txtMonth.Clear()
        txtDayOfMonth.Clear()
        lblDateString.Text = String.Empty

        ' Give the focus to txtDayOfWeek.
        txtMonth.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
