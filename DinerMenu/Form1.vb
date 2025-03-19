Option Strict On
Option Explicit On

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles DinerNameLabel.Click

    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        FoodLabel.Text = "The Liquid Lunch"
    End Sub
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        FoodLabel.Text = "Sus Salad"
    End Sub
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        FoodLabel.Text = "Chumbalaya"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
