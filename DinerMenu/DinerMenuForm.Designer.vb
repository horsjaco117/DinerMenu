<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DinerMenuForm
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
        components = New ComponentModel.Container()
        DinerNameLabel = New Label()
        SoupButton = New Button()
        SaladButton = New Button()
        FishButton = New Button()
        ExitButton = New Button()
        FoodLabel = New Label()
        InfoGroupBox = New GroupBox()
        ToolTip1 = New ToolTip(components)
        InfoGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' DinerNameLabel
        ' 
        DinerNameLabel.Font = New Font("BankGothic Md BT", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DinerNameLabel.Location = New Point(12, 9)
        DinerNameLabel.Name = "DinerNameLabel"
        DinerNameLabel.Size = New Size(615, 54)
        DinerNameLabel.TabIndex = 0
        DinerNameLabel.Text = "The Saltier Spitoon"
        ToolTip1.SetToolTip(DinerNameLabel, "The Most legendary of restaurants this side of the ocean")
        ' 
        ' SoupButton
        ' 
        SoupButton.Location = New Point(34, 372)
        SoupButton.Name = "SoupButton"
        SoupButton.Size = New Size(185, 57)
        SoupButton.TabIndex = 1
        SoupButton.Text = "Soup of the Day"
        SoupButton.UseVisualStyleBackColor = True
        ' 
        ' SaladButton
        ' 
        SaladButton.Location = New Point(225, 372)
        SaladButton.Name = "SaladButton"
        SaladButton.Size = New Size(132, 57)
        SaladButton.TabIndex = 2
        SaladButton.Text = "Chef's Special"
        SaladButton.UseVisualStyleBackColor = True
        ' 
        ' FishButton
        ' 
        FishButton.Location = New Point(363, 372)
        FishButton.Name = "FishButton"
        FishButton.Size = New Size(112, 57)
        FishButton.TabIndex = 3
        FishButton.Text = "Daily Fish"
        FishButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(676, 375)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(112, 54)
        ExitButton.TabIndex = 4
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' FoodLabel
        ' 
        FoodLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FoodLabel.Location = New Point(42, 37)
        FoodLabel.Name = "FoodLabel"
        FoodLabel.Size = New Size(609, 224)
        FoodLabel.TabIndex = 0
        FoodLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' InfoGroupBox
        ' 
        InfoGroupBox.Controls.Add(FoodLabel)
        InfoGroupBox.Location = New Point(34, 84)
        InfoGroupBox.Name = "InfoGroupBox"
        InfoGroupBox.Size = New Size(754, 285)
        InfoGroupBox.TabIndex = 5
        InfoGroupBox.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(InfoGroupBox)
        Controls.Add(ExitButton)
        Controls.Add(FishButton)
        Controls.Add(SaladButton)
        Controls.Add(SoupButton)
        Controls.Add(DinerNameLabel)
        Name = "Form1"
        Text = "Form1"
        InfoGroupBox.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents FoodLabel As Label
    Friend WithEvents InfoGroupBox As GroupBox
    Friend WithEvents ToolTip1 As ToolTip

End Class
