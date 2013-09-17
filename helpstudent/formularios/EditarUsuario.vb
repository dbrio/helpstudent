
Public Class EditarUsuario

    Private Sub EditarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbCarrera.DisplayMember = "Nombre"
        cbCarrera.ValueMember = "IdCarrera"
        cbCarrera.DataSource = db.GetData("SELECT IdCarrera, Nombre FROM Carrera WHERE IdCarrera <>6")
    End Sub
    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click

        Dim actualizar As String = String.Format("UPDATE Alumno SET Telefono = '{0}', IdCarrera = '{1}' WHERE CtaAlum = '{2}'", txtTelefono.Text, cbCarrera.SelectedValue, UsuarioActivo.cuenta)
        db.NotQuery(actualizar)
        Dim actlogin As String = String.Format("UPDATE Login SET Usuario='{0}', Contrasena= '{1}' WHERE IdLogin = '{2}'", TextEditUsuario.Text, TextEditContrasena.Text, UsuarioActivo.IdLogin)
        db.NotQuery(actlogin)
        MsgBox("El usuario ha sido Actualizado")
        Me.Refresh()
    End Sub
End Class