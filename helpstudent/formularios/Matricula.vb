Public Class Matricula 

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        Dim activo As String = db.GetLastID("IdPeriodoCatalogo", "Matricula")
        Dim llenar As String = String.Format("SELECT Clase.Nombre, Matricula.Dia, Matricula.Hora,Maestro.Nombre ||' '||Maestro.Apellido AS Maestro FROM Matricula INNER JOIN Clase ON Matricula.CodClase = Clase.CodClase INNER JOIN PeridoCatalogo ON Matricula.IdPeriodoCatalogo = PeridoCatalogo.IdPeriodoCatalogo INNER JOIN Maestro ON Matricula.IdMaestro = Maestro.IdMaestro WHERE PeridoCatalogo.IdPeriodoCatalogo = '{0}'", activo)
        DataGridClases.DataSource = db.GetData(llenar)
    End Sub

 
End Class