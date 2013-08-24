Imports System.Data.SQLite


Public Class Historial
    Dim DS As New DataSet

    Private Sub Historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Using CNN As New SQLiteConnection(cnnString)
            CNN.Open()

            Using DA As New SQLiteDataAdapter
                DA.SelectCommand = New SQLiteCommand("SELECT * FROM Clase", CNN)
                DA.Fill(DS, "Clase")
                GridControl1.DataSource = DS.Tables("Clase")
            End Using

            CNN.Close()
        End Using
    End Sub
End Class