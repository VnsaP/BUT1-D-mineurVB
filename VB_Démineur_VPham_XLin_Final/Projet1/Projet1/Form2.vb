Public Class Form2
    'créeation de la grille de bouton
    'attriuer une location à 10 bombes
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.ComboBox1.Text

        Dim Random As New Random
        For n As Integer = 0 To 10 - 1
            Dim posibomb As Integer = Random.Next(0, 63)
            For i = 0 To 8 - 1
                For j = 0 To 8 - 1
                    Dim b As Button = New Button
                    b.Location = New System.Drawing.Point(100, 100)
                    b.Name = (i * 8 + j)
                    b.Size = New Size(40, 40)
                    b.Location = New Point(j * (b.Height + 5) + 50, i * (b.Height + 5) + 50)
                    Panel1.Controls.Add(b)

                    If Panel1.Controls(i * 8 + j).Name = Convert.ToString(posibomb) Then
                        Panel1.Controls(i * 8 + j).Name = "Bombe"
                    End If

                    AddHandler b.MouseClick, AddressOf ModuleJouer.myButtonHandler2_Click
                Next
            Next
        Next
    End Sub

    'Le Chronomètre en seconde
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Label2.Text - 1
        If Int(Label2.Text) = 0 Then
            Timer1.Stop()
        End If
    End Sub

    'arreter la partie 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MsgBox("Tu as arreter. retroune à l'accueil")
    End Sub

    'Evenement pour faire pause, Chrono s'arrete et la grille est cachée 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Panel1.Visible = False
        Button2.Visible = False
        Button3.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label6.Text = "Tu es en pause, tu ne peux pas jouer pour l'instant ^^"
        Label7.Text = "appuies sur 'reprendre'"
    End Sub

    'Evenement pour reprendre, Chrono reprend et la grille est remontrer 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = Label2.Text - 1
        Timer1.Enabled = True
        Button3.Visible = False
        Button2.Visible = True
        Panel1.Visible = True
        Label6.Visible = False
        Label7.Visible = False
    End Sub
End Class
