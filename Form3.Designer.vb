<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        ComboBoxCategorie = New ComboBox()
        ListBox1 = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(287, 115)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 64)
        Button1.TabIndex = 0
        Button1.Text = "1 joueur"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(601, 115)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 64)
        Button2.TabIndex = 1
        Button2.Text = "2 joueurs"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxCategorie
        ' 
        ComboBoxCategorie.FormattingEnabled = True
        ComboBoxCategorie.Location = New Point(862, 132)
        ComboBoxCategorie.Name = "ComboBoxCategorie"
        ComboBoxCategorie.Size = New Size(182, 33)
        ComboBoxCategorie.TabIndex = 2
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(228, 356)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(590, 179)
        ListBox1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(401, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 47)
        Label1.TabIndex = 4
        Label1.Text = "Mode de jeu :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(345, 245)
        Label2.Name = "Label2"
        Label2.Size = New Size(358, 63)
        Label2.TabIndex = 5
        Label2.Text = "Hall Of Fame"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1109, 584)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Controls.Add(ComboBoxCategorie)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBoxCategorie As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
