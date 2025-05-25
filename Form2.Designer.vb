<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label1.Location = New Point(26, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nombre de lettre à deviner :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(268, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(689, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 25)
        Label3.TabIndex = 2
        Label3.Text = "Nombre d'essaie restant(s) :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(950, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 25)
        Label4.TabIndex = 3
        Label4.Text = "10"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(402, 304)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 4
        Button1.Text = "Valider"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(69, 306)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(279, 198)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 25)
        Label5.TabIndex = 6
        Label5.Text = "Label5"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.pendu0
        PictureBox1.Location = New Point(559, 63)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(551, 522)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(268, 526)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 25)
        Label6.TabIndex = 8
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(387, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 25)
        Label7.TabIndex = 9
        Label7.Text = "Indice :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(279, 106)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 25)
        Label8.TabIndex = 10
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1111, 584)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
End Class
