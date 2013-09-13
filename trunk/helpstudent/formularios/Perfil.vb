Public Class perfil

    Private Sub perfil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        db.CNN.Open()
        LabelCuenta.Text = UsuarioActivo.cuenta
        LabelNombre.Text = UsuarioActivo.nombre
        LabelApellido.Text = UsuarioActivo.apellido
        LabelTelefono.Text = UsuarioActivo.telefono
        LabelSexo.Text = UsuarioActivo.sexo
        LabelCarrera.Text = UsuarioActivo.carrera
        LabelCorreo.Text = UsuarioActivo.correo
        LabelCuenta.Text = UsuarioActivo.cuenta
        LabelUsuario.Text = UsuarioActivo.usuario

        db.CNN.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            With EditarUsuario
                .MdiParent = MdiParent
                .Show()
                .Focus()
            End With
            Me.Hide()
        Catch ex As Exception
            
        End Try

    End Sub
End Class