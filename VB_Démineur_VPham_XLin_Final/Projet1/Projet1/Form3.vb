Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Scores"
        Label1.Text = "Liste des joueurs qui ont déjà jouer"
    End Sub

    'retourner sur le formulaire d'accueil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    'trier (... ne marche pas)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Sorted = False
        Form1.ComboBox1.Sorted = False
    End Sub
End Class