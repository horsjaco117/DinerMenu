<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DinerNameLabel = New Label()
        SoupButton = New Button()
        SaladButton = New Button()
        FishButton = New Button()
        ExitButton = New Button()
        FoodLabel = New Label()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DinerNameLabel
        ' 
        DinerNameLabel.Font = New Font("BankGothic Md BT", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DinerNameLabel.Location = New Point(12, 9)
        DinerNameLabel.Name = "DinerNameLabel"
        DinerNameLabel.Size = New Size(615, 54)
        DinerNameLabel.TabIndex = 0
        DinerNameLabel.Text = "The Salty Spitoon"
        ' 
        ' SoupButton
        ' 
        SoupButton.Location = New Point(12, 395)
        SoupButton.Name = "SoupButton"
        SoupButton.Size = New Size(112, 34)
        SoupButton.TabIndex = 1
        SoupButton.Text = "Soup"
        SoupButton.UseVisualStyleBackColor = True
        ' 
        ' SaladButton
        ' 
        SaladButton.Location = New Point(192, 399)
        SaladButton.Name = "SaladButton"
        SaladButton.Size = New Size(112, 34)
        SaladButton.TabIndex = 2
        SaladButton.Text = "Salad"
        SaladButton.UseVisualStyleBackColor = True
        ' 
        ' FishButton
        ' 
        FishButton.Location = New Point(340, 395)
        FishButton.Name = "FishButton"
        FishButton.Size = New Size(112, 34)
        FishButton.TabIndex = 3
        FishButton.Text = "FishButton"
        FishButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(573, 411)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(112, 34)
        ExitButton.TabIndex = 4
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' FoodLabel
        ' 
        FoodLabel.Location = New Point(42, 37)
        FoodLabel.Name = "FoodLabel"
        FoodLabel.Size = New Size(609, 224)
        FoodLabel.TabIndex = 0
        FoodLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(FoodLabel)
        GroupBox1.Location = New Point(34, 84)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(675, 285)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(ExitButton)
        Controls.Add(FishButton)
        Controls.Add(SaladButton)
        Controls.Add(SoupButton)
        Controls.Add(DinerNameLabel)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents FoodLabel As Label
    Friend WithEvents GroupBox1 As GroupBox

End Class
