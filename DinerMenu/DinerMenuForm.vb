'Jacob Horsley
'RCET 0265
'Spring 2025
'Diner Menu Program
'URL: 

Option Strict On
Option Explicit On

Public Class DinerMenuForm


    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        FoodLabel.Text = "The Liquid Lunch" & vbCrLf & "The liquid lunch is a true man's way of putting" _
            & vbCrLf & "barnacles on your chest. Specially cured from our oil vats" _
            & vbCrLf & "off the coast of shen zen China. Try it only if you dare..."
    End Sub
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        FoodLabel.Text = "Sus Salad" & vbCrLf & "This salad seperates the men from the Weeny hut juniors'" &
            "Salads include the tentacles from the jellyfish from Jellyfish Fields."

    End Sub
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        FoodLabel.Text = "Chumbalaya" & vbCrLf & "With the aquirement of the Chum Bucket this classic meal" _
            & "is now available here at the Salty Spitoon."

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
