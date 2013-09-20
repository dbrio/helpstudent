Imports System.Data.SQLite
Public Class login




    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
    End Sub


    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        Registro.Show()
        Me.Hide()

    End Sub



    Private Sub BtnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEntrar.Click
        db.CNN.Open()
        If db.Login(TxtUsuario.Text, TxtContrasena.Text) = True Then
            MDIParent1.Show()
            Me.Hide()

        Else
            MsgBox("Uusario y/o contraseña incorrectas")
            TxtUsuario.Text = ""
            TxtContrasena.Text = ""
            TxtUsuario.Focus()

        End If
        
        db.CNN.Close()

    End Sub

End Class
