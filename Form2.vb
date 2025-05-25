Imports System.Reflection.Emit

Public Class Form2
    Dim motSecret As String
    Dim cpt As Integer = 10
    Dim nbLettres As Integer
    Dim cpt1 As Integer = 0
    Dim lettresProposees As New List(Of String) ' <-- Ajout pour stocker les lettres
    Dim tempsRestant As Integer = 120 ' Par exemple, 120 secondes de base
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Affiche la catégorie si elle a été transmise
        If Me.Tag IsNot Nothing AndAlso TypeOf Me.Tag Is String Then
            Label8.Text = "Catégorie : " & Me.Tag.ToString()
        Else
            Label8.Text = "Catégorie : (non définie)"
        End If

        MessageBox.Show("Les régles du jeux : entré un mot de votre choix, et un autre joueur devra le deviner en moins de 6 coups.")
        motSecret = InputBox("Entrez le mot à rechercher :", "Mot Secret").ToUpper()
        nbLettres = motSecret.Length
        Label2.Text = nbLettres.ToString
        Label4.Text = cpt.ToString
        cpt1 = nbLettres
        If String.IsNullOrEmpty(motSecret) Then
            MessageBox.Show("Vous devez entrer un mot valide.")
            Me.Close()
        End If

        ' Affiche les underscores espacés dans Label5 dès le début
        Label5.Text = String.Join(" ", Enumerable.Repeat("_", motSecret.Length))
        Label6.Text = "" ' <-- Initialisation de Label6
        lettresProposees.Clear()

        tempsRestant = 120
        Label7.Text = "Temps restant : " & tempsRestant & " s"
        Timer1.Interval = 1000 ' 1 seconde
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lettreProposee As String = TextBox1.Text.ToUpper()
        Dim positions As New List(Of Integer)
        Dim affichage As Char()

        ' Ajoute la lettre à l'historique si elle n'est pas déjà présente
        If Not String.IsNullOrWhiteSpace(lettreProposee) AndAlso Not lettresProposees.Contains(lettreProposee) Then
            lettresProposees.Add(lettreProposee)
            Label6.Text = String.Join(" ", lettresProposees)
        End If

        ' Initialiser l'affichage si c'est la première fois
        If String.IsNullOrEmpty(Label5.Text) OrElse Label5.Text.Replace(" ", "").Length <> motSecret.Length Then
            affichage = New String("_"c, motSecret.Length).ToCharArray()
        Else
            affichage = Label5.Text.Replace(" ", "").ToCharArray()
        End If

        For i As Integer = 0 To motSecret.Length - 1
            If motSecret(i) = lettreProposee Then
                positions.Add(i)
                affichage(i) = lettreProposee(0)
            End If
        Next

        ' Met à jour l'affichage dans le label
        Label5.Text = String.Join(" ", affichage)

        ' Vérifie si le joueur a gagné
        If Not affichage.Contains("_"c) Then
            Timer1.Stop()
            Dim score As Integer = (tempsRestant + (10 - cpt) * 10) * motSecret.Length
            ' Demande le nom du joueur
            Dim nomJoueur As String = InputBox("Entrez votre nom :", "Nom du joueur")
            If String.IsNullOrWhiteSpace(nomJoueur) Then nomJoueur = "Anonyme"
            Dim ligneScore As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " | " & nomJoueur & " | " & motSecret & " | " & score
            ' Enregistre le score dans un fichier texte
            Dim cheminScore As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "scores.txt")
            System.IO.File.AppendAllText(cheminScore, ligneScore & Environment.NewLine)
            MessageBox.Show("Bravo ! Vous avez trouvé le mot : " & motSecret & vbCrLf & "Score : " & score, "Gagné", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form1.Show()
            Exit Sub
        End If

        If positions.Count > 0 Then
            MessageBox.Show("Lettre trouvée aux positions : " & String.Join(", ", positions))
            cpt1 -= 1
            Label2.Text = cpt1.ToString
        Else
            MessageBox.Show("Lettre non trouvée dans le mot.")
            cpt -= 1
            Label4.Text = cpt.ToString

            ' Affiche l'image correspondante à l'erreur
            Dim imageName As String = $"pendu{9 - cpt}"
            Dim img As Image = CType(My.Resources.ResourceManager.GetObject(imageName), Image)
            PictureBox1.Image = img

            ' Vérifie si le joueur a perdu
            If cpt = 0 Then
                MessageBox.Show("Perdu ! Le mot était : " & motSecret, "Perdu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Hide()
                Form1.Show()
                Exit Sub
            End If
        End If

        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
            e.SuppressKeyPress = True ' Empêche le "ding" sonore
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempsRestant -= 1
        Label7.Text = "Temps restant : " & tempsRestant & " s"
        If tempsRestant <= 0 Then
            Timer1.Stop()
            MessageBox.Show("Temps écoulé ! Score : 0", "Temps écoulé", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class