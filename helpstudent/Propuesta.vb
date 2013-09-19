Public Class Propuesta

    Private Sub Propuesta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim llenar As String = String.Format("SELECT Clase.Nombre, Matricula.Promedio FROM Clase INNER JOIN Matricula ON Clase.CodClase = Matricula.CodClase WHERE Matricula.CtaAlum='{0}' AND Matricula.Promedio > 60", UsuarioActivo.cuenta)
        DataGridView1.DataSource = (db.GetData(llenar))
    End Sub
End Class