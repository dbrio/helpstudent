Public Class Inicio


    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'coloreamos los cuadros 
        RectangleShapeUsuario.BackColor = Color.FromArgb(&HC1, &H0, &H4F)
        RectangleShape2.BackColor = Color.FromArgb(&H2E, &H8D, &HEF)
        RectangleaPropuesta.BackColor = Color.FromArgb(&HFF, &H98, &H1D)
        RectangleMatricula.BackColor = Color.FromArgb(&H7B, &HAD, &H18)
        RectangleShape5.BackColor = Color.FromArgb(&H46, &H17, &HB4)
        RectangleShape6.BackColor = Color.FromArgb(&H6E, &H7E, &H94)


    End Sub

    Private Sub RectangleShapeUsuario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShapeUsuario.MouseLeave
        'Regresa el color original del cuadro 
        RectangleShapeUsuario.BackColor = Color.FromArgb(&HC1, &H0, &H4F)
    End Sub



    Private Sub RectangleShapeUsuario_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShapeUsuario.MouseMove
        'Cambia de color el cuadro al pasar por encima 
        RectangleShapeUsuario.BackColor = Color.FromArgb(&H7B, &HAD, &H18)
    End Sub

    Private Sub RectangleShapeUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShapeUsuario.Click
        'Mostrar el formulario Perfil
        perfil.Show()
        perfil.MdiParent = MDIParent1
        
    End Sub

    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleMatricula.Click
        'Mostrar el formulario Matricula
        Matricula.Show()
        Matricula.MdiParent = MDIParent1
    End Sub

  

    Private Sub RectangleShape4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleMatricula.MouseLeave
        'Regresa el color original del cuadro 
        RectangleMatricula.BackColor = Color.FromArgb(&H7B, &HAD, &H18)
    End Sub

    Private Sub RectangleMatricula_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleMatricula.MouseMove
        'Cambia de color el cuadro al pasar por encima 
        RectangleMatricula.BackColor = Color.FromArgb(&HFF, &H98, &H1D)
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        'Mostra el formulario Historial
        Historial.Show()
        Historial.MdiParent = MDIParent1

    End Sub

    Private Sub RectangleaPropuesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleaPropuesta.Click
        'Mostrar el formulario Propueta
        Propuesta.Show()
        Propuesta.MdiParent = MDIParent1
    End Sub

    Private Sub RectangleShape2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShape2.MouseMove
        'Cambia de color el cuadro al pasar por encima 
        RectangleShape2.BackColor = Color.FromArgb(&H6E, &H7E, &H94)
    End Sub

    Private Sub RectangleShape2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.MouseLeave
        'Regresa el color original del cuadro 
        RectangleShape2.BackColor = Color.FromArgb(&H2E, &H8D, &HEF)
    End Sub

    Private Sub RectangleaPropuesta_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleaPropuesta.MouseMove
        'Cambia de color el cuadro al pasar por encima 
        RectangleaPropuesta.BackColor = Color.FromArgb(&HCC, &HCC, &H0)
    End Sub

    Private Sub RectangleaPropuesta_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleaPropuesta.MouseLeave
        'Regresa el color original del cuadro 
        RectangleaPropuesta.BackColor = Color.FromArgb(&HFF, &H98, &H1D)

    End Sub
End Class