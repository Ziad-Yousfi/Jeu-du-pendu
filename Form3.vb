Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxCategorie.Items.Clear()
        ComboBoxCategorie.Items.AddRange(New String() {"Animaux", "Pays", "Fruits", "Métiers", "Sport", "Objet"})
        ComboBoxCategorie.SelectedIndex = 0

        ListBox1.Items.Clear()
        Dim cheminScore As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "scores.txt")
        If System.IO.File.Exists(cheminScore) Then
            Dim lignes = System.IO.File.ReadAllLines(cheminScore)
            ' Trie les scores par ordre décroissant
            Dim scoresTries = lignes.
                Select(Function(l)
                           Dim parts = l.Split("|"c)
                           If parts.Length >= 4 Then
                               Dim score As Integer
                               If Integer.TryParse(parts(3).Trim(), score) Then
                                   Return New With {.Ligne = l, .Score = score}
                               End If
                           End If
                           Return Nothing
                       End Function).
                Where(Function(x) x IsNot Nothing).
                OrderByDescending(Function(x) x.Score).
                Take(10)

            For Each s In scoresTries
                ListBox1.Items.Add(s.Ligne)
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim categorie As String = ComboBoxCategorie.SelectedItem.ToString()
        Dim f2 As New Form2()
        f2.Tag = categorie ' Passe la catégorie à Form2
        f2.Show()
        Me.Close()
    End Sub
End Class