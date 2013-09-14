
Public Class ActualizarNotas
    Dim NotaID As Integer

    Public Property NOtaID1 As Integer
        Get
            Return NotaID
        End Get
        Set(ByVal value As Integer)
            NotaID = value
        End Set
    End Property


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not IsNumeric(TextBoxNota1.Text) Then
            MsgBox("Ingrese cantidad Numerica")
            TextBoxNota1.Clear()
            TextBoxNota1.Focus()
        ElseIf Not IsNumeric(TextBoxNota2.Text) Then
            MsgBox("Ingrese cantidad Numerica")
            TextBoxNota2.Clear()
            TextBoxNota2.Focus()
        ElseIf Not IsNumeric(TextBoxNota3.Text) Then
            MsgBox("Ingrese cantidad Numerica")
            TextBoxNota3.Clear()
            TextBoxNota3.Focus()
        Else
            Dim Promedio = (CInt(TextBoxNota1.Text) + CInt(TextBoxNota2.Text) + CInt(TextBoxNota3.Text)) / 3
            Dim actualizar As String = String.Format("UPDATE Matricula SET Nota1= '{0}', Nota2 = '{1}', Nota3= '{2}', Promedio = '{3}'    WHERE IdMatricula = {4} ", TextBoxNota1.Text, TextBoxNota2.Text, TextBoxNota3.Text, Promedio, NOtaID1)
            db.NotQuery(actualizar)
            MsgBox("Nota Actualizada")
            Me.Close()
        End If

            

    End Sub
End Class