Public Class Propuesta
    Public Function DameID() As String
        Try
            Return DataGridViewAprovada.CurrentRow.Cells(0).Value()

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub Propuesta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim llenar As String = String.Format("SELECT Clase.CodClase, Clase.Nombre, Matricula.Promedio FROM Clase INNER JOIN Matricula ON Clase.CodClase = Matricula.CodClase WHERE Matricula.CtaAlum='{0}' AND Matricula.Promedio > 60", UsuarioActivo.cuenta)
        DataGridViewAprovada.DataSource = (db.GetData(llenar))

       
    End Sub

    

    Private Sub DataGridViewAprovada_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewAprovada.CellClick
        Dim IdRequisto As String = DameID()
        Dim llenar2 As String = String.Format("SELECT Clase.Nombre FROM Clase INNER JOIN Requisitos ON Clase.CodClase = Requisitos.CodClase INNER JOIN CarreraClase ON Clase.CodClase = CarreraClase.CodClase WHERE Requisitos.CodRequisito = '{0}' AND  CarreraClase.IdCarrera ='{1}' ", IdRequisto, UsuarioActivo.IdCarrera)
        DataGridViewDisponible.DataSource = db.GetData(llenar2)
    End Sub
End Class