
Public Class login
    Dim ex, ey As Integer
    Dim arrastrar As Boolean

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
    End Sub


    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        Registro.Show()
        Me.Hide()

    End Sub

  
    Private Sub login_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        arrastrar = True
    End Sub

    Private Sub login_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        If arrastrar Then
            Location = PointToScreen(New Point(MousePosition.X - Location.X - ex, MousePosition.Y - Location.Y - ex))

        End If

    End Sub

    Private Sub login_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        arrastrar = False
    End Sub

    
    Private Sub BtnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEntrar.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

  
End Class
