Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Accueil"
        ComboBox1.Sorted = True

        Dim tv() As String = {"Joueur inconnu"}

        For i As Integer = 0 To tv.Length - 1
            If Not ComboBox1.Items.Contains(tv(i)) Then ComboBox1.Items.Add(tv(i))
        Next

    End Sub

    'Contreinte de 3 caractère au moins avant de commencer la partie
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text.Length > 2 Then
            ComboBox1.Items.Add(ComboBox1.Text)
            Form2.Text = "Partie de Démineur"
            Form2.Show()
            Form2.Timer1.Start()
        End If

    End Sub

    'Evenement quand on veut quitter le jeu, bouton quitter
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String

        a = MsgBox("Voulez-vous quitter le jeu ?", vbYesNo + vbQuestion, "Quitter")

        If a = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
        End
    End Sub

    'Evenement quand on clique sur le bouton "4", de scores
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddHandler Button4.MouseClick, AddressOf Module2.myButtonHandler2_Click
    End Sub
End Class
