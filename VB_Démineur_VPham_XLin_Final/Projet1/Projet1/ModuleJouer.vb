Module ModuleJouer
    'Evenement pour jouer et démasqué les buttons (...ne marche pas correctement)
    Dim number As Integer = 0
    Public Sub myButtonHandler2_Click()
        For i = 0 To 8 - 1
            For j = 0 To 8 - 1
                If Not Form2.Panel1.Controls(i * 8 + j).Name = "Bombe" Then
                    For ligne As Integer = i - 1 To i + 1
                        For colonne As Integer = j - 1 To j + 1
                            If ligne >= 0 And ligne < 8 * 8 And colonne >= 0 And colonne < 8 * 8 And Not (8 = ligne And 8 = colonne) Then
                                If Form2.Panel1.Controls(ligne * 8 + colonne).Name = "Bombe" Then
                                    Form2.Panel1.Controls(i * 8 + j).BackColor = Color.Green
                                    Form2.Panel1.Controls(i * 8 + j).Name = 0
                                    number += 1
                                    Form2.Panel1.Controls(i * 8 + j).Name = number
                                    Form2.Panel1.Controls(i * 8 + j).Text = Form2.Panel1.Controls(i * 8 + j).Name
                                End If
                            End If
                        Next
                    Next
                End If
            Next
        Next
    End Sub
End Module
