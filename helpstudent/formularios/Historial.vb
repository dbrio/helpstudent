﻿
Public Class Historial

    Dim DS As New DataSet


    Private Sub Historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarGrid()
    End Sub


    Sub CargarGrid()

        GridControl1.DataSource = db.GetData("SELECT * FROM Clase")
    End Sub

End Class