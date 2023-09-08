Public Class Form1
    Private Sub btnPress_Click(sender As Object, e As EventArgs) Handles btnPress.Click
        Dim number As Integer

        If IsNumeric(txtNumeric.Text) = True Then
            number = txtNumeric.Text
            MsgBox("That is a Numeric")
        Else
            MsgBox("That is not a Numeric!")
            Exit Sub
        End If

    End Sub
End Class
