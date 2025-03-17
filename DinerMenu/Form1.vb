Option Strict On
Option Explicit On

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles DinerNameLabel.Click

    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        Label1.Text = "Fried Patrick"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
