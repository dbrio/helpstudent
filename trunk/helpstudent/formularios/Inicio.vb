Public Class Inicio


    'With EditarUsuario
    '    .MdiParent = Me
    '    .Show()
    '    .Focus()
    'End With





    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RectangleShapeUsuario.BackColor = Color.FromArgb(&HC1, &H0, &H4F)

        RectangleShape2.BackColor = Color.FromArgb(&H2E, &H8D, &HEF)
        RectangleShape3.BackColor = Color.FromArgb(&HFF, &H98, &H1D)
        RectangleMatricula.BackColor = Color.FromArgb(&H7B, &HAD, &H18)
        RectangleShape5.BackColor = Color.FromArgb(&H46, &H17, &HB4)
        RectangleShape6.BackColor = Color.FromArgb(&H6E, &H7E, &H94)




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With EditarUsuario
            .MdiParent = Me
            .Show()
            .Focus()
        End With
        Me.Hide()
    End Sub


    Private Sub RectangleShapeUsuario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShapeUsuario.MouseLeave
        RectangleShapeUsuario.BackColor = Color.FromArgb(&HC1, &H0, &H4F)
    End Sub



    Private Sub RectangleShapeUsuario_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShapeUsuario.MouseMove
        RectangleShapeUsuario.BackColor = Color.FromArgb(&H7B, &HAD, &H18)
    End Sub

    Private Sub RectangleShapeUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShapeUsuario.Click
        With perfil
            .MdiParent = MdiParent
            .Show()
            .Focus()
        End With
        Me.Close()
    End Sub

    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleMatricula.Click
        With Matricula
            .MdiParent = MdiParent
            .Show()
            .Focus()
        End With
        Me.Hide()
    End Sub

  

    Private Sub RectangleShape4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleMatricula.MouseLeave
        RectangleMatricula.BackColor = Color.FromArgb(&H7B, &HAD, &H18)
    End Sub

    Private Sub RectangleMatricula_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleMatricula.MouseMove
        RectangleMatricula.BackColor = Color.FromArgb(&HFF, &H98, &H1D)
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        With Historial
            .MdiParent = MdiParent
            .Show()
            .Focus()
        End With
        Me.Hide()
    End Sub
End Class