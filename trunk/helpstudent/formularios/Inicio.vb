Public Class Inicio


    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RectangleShapeUsuario.BackColor = Color.FromArgb(&HC1, &H0, &H4F)

        RectangleShape2.BackColor = Color.FromArgb(&H2E, &H8D, &HEF)
        RectangleaPropuesta.BackColor = Color.FromArgb(&HFF, &H98, &H1D)
        RectangleMatricula.BackColor = Color.FromArgb(&H7B, &HAD, &H18)
        RectangleShape5.BackColor = Color.FromArgb(&H46, &H17, &HB4)
        RectangleShape6.BackColor = Color.FromArgb(&H6E, &H7E, &H94)




    End Sub

    

    Private Sub RectangleShapeUsuario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShapeUsuario.MouseLeave
        RectangleShapeUsuario.BackColor = Color.FromArgb(&HC1, &H0, &H4F)
    End Sub



    Private Sub RectangleShapeUsuario_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShapeUsuario.MouseMove
        RectangleShapeUsuario.BackColor = Color.FromArgb(&H7B, &HAD, &H18)
    End Sub

    Private Sub RectangleShapeUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShapeUsuario.Click
        perfil.Show()
        perfil.MdiParent = MDIParent1
        
    End Sub

    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleMatricula.Click
        Matricula.Show()
        Matricula.MdiParent = MDIParent1
    End Sub

  

    Private Sub RectangleShape4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleMatricula.MouseLeave
        RectangleMatricula.BackColor = Color.FromArgb(&H7B, &HAD, &H18)
    End Sub

    Private Sub RectangleMatricula_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleMatricula.MouseMove
        RectangleMatricula.BackColor = Color.FromArgb(&HFF, &H98, &H1D)
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click

        Historial.Show()
        Historial.MdiParent = MDIParent1

    End Sub

    Private Sub RectangleaPropuesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleaPropuesta.Click
        Propuesta.Show()
        Propuesta.MdiParent = MDIParent1
    End Sub

    Private Sub RectangleShape2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShape2.MouseMove
        RectangleShape2.BackColor = Color.FromArgb(&H6E, &H7E, &H94)
    End Sub

    Private Sub RectangleShape2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.MouseLeave
        RectangleShape2.BackColor = Color.FromArgb(&H2E, &H8D, &HEF)
    End Sub

    Private Sub RectangleaPropuesta_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleaPropuesta.MouseMove
        RectangleaPropuesta.BackColor = Color.FromArgb(&HCC, &HCC, &H0)
    End Sub

    Private Sub RectangleaPropuesta_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleaPropuesta.MouseLeave
        RectangleaPropuesta.BackColor = Color.FromArgb(&HFF, &H98, &H1D)

    End Sub
End Class