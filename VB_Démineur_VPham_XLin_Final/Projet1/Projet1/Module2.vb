Module Module2
    'Enregistrement du joueur qui vent de démarrer une partie
    'Ecriture de ce joueur dns le fichier txt des anciens joueurs
    'lecture du fichier txt avec les anciens joueurs
    Public Sub myButtonHandler2_Click()
        Form3.Show()
        Form3.ListBox1.Items.Clear()

        For i As Integer = 0 To Form1.ComboBox1.Items.Count - 1
            Form3.ListBox1.Items.Add(Form1.ComboBox1.Items(i))
        Next

        Dim Joueurs(100) As String
        Dim Acteurs(100) As String
        Dim nbJ As Integer = 0

        Dim num As Integer = FreeFile()
        Dim nextLine As String

        FileOpen(num, "joueur.txt", OpenMode.Input)
        Do Until EOF(num)
            nextLine = LineInput(num)
            Joueurs(nbJ) = nextLine
            nbJ += 1
        Loop

        For i = 0 To nbJ - 1
            If Not Form3.ListBox1.Items.Contains(Joueurs(i)) Then
                Form3.ListBox1.Items.Add(Joueurs(i))
            End If
        Next
        FileClose(num)

        FileOpen(num, "joueur.txt", OpenMode.Append)
        For i As Integer = 0 To Form1.ComboBox1.Items.Count - 1
            WriteLine(num, Form1.ComboBox1.Items(i))
        Next
        FileClose(num)

    End Sub
End Module
