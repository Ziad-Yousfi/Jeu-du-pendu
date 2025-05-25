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
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Sans_titre
        PictureBox1.Location = New Point(-7, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1132, 582)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(82, 391)
        Button1.Name = "Button1"
        Button1.Size = New Size(142, 53)
        Button1.TabIndex = 1
        Button1.Text = "Lancer le jeu"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(332, 391)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 53)
        Button2.TabIndex = 2
        Button2.Text = "Quitter"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1122, 571)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
