Public Class perfil
    Dim UsuarioActivo As Usuario
    Private Sub perfil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelNombre.Text = UsuarioActivo.nombre

    End Sub
End Class