
Public Class EditarUsuario

    Private Sub EditarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbCarrera.DisplayMember = "Nombre"
        cbCarrera.ValueMember = "IdCarrera"
        cbCarrera.DataSource = db.GetData("SELECT IdCarrera, Nombre FROM Carrera WHERE IdCarrera <>6")
    End Sub
End Class