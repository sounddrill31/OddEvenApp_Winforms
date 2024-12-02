Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Value.TextChanged
        If Value.Text = Nothing Then
            Label1.Text = "Enter Number"
        Else
            Dim ValueNum As Integer = Value.Text
            If (ValueNum Mod 2 = 0) Then
                Label1.Text = "Even - Enter Value"
            Else
                Label1.Text = " Odd - Enter Value"
            End If
        End If
    End Sub

    Private Sub ClrButton_Click(sender As Object, e As EventArgs) Handles ClrButton.Click
        Label1.Text = "Enter Number"
        Value.Text = String.Empty
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class
