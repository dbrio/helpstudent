
Public Class ActualizarNotas
    Dim NotaID As Integer

    'trae el id de la matricula para actualizar las notas
    Public Property NOtaID1 As Integer
        Get
            Return NOtaID
        End Get
        Set(ByVal value As Integer)
            NotaID = value
        End Set
    End Property


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'valida los texbox de las notas para luego actualizar 

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

            'si valida todo los texbox entonces debe actualizar
        Else
            Dim Promedio = (CInt(TextBoxNota1.Text) + CInt(TextBoxNota2.Text) + CInt(TextBoxNota3.Text)) / 3
            Dim actualizar As String = String.Format("UPDATE Matricula SET Nota1= '{0}', Nota2 = '{1}', Nota3= '{2}', Promedio = '{3}'    WHERE IdMatricula = {4} ", TextBoxNota1.Text, TextBoxNota2.Text, TextBoxNota3.Text, Promedio, NOtaID1)
            db.NotQuery(actualizar)
            MsgBox("Nota Actualizada")
            Me.Close()
        End If



    End Sub

    
    Private Sub ActualizarNotas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'habilita el formulario de matricula
        Matricula.Enabled = True
    End Sub

    Private Sub ActualizarNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'abre el mdiParent
        With Me
            .MdiParent = MdiParent()
            .Show()
            .Focus()
        End With
        'cierra el formulario de la matricula
        Me.Close()
        Matricula.Show()
    End Sub

 
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'valida los texbox de las notas para luego actualizar 
        If TextBoxNota1.Text.Trim > 100 Or TextBoxNota1.Text.Trim < 0 Then
            MsgBox(" Ingrese notas dentro del rango")
            TextBoxNota1.Clear()
            TextBoxNota1.Focus()
            Exit Sub
        End If
        If TextBoxNota2.Text.Trim > 100 Or TextBoxNota2.Text.Trim < 0 Then
            MsgBox(" Ingrese notas dentro del rango")
            TextBoxNota2.Clear()
            TextBoxNota2.Focus()
            Exit Sub
        End If
        If TextBoxNota3.Text.Trim > 100 Or TextBoxNota3.Text.Trim < 0 Then
            MsgBox(" Ingrese notas dentro del rango")
            TextBoxNota3.Clear()
            TextBoxNota3.Focus()
            Exit Sub
        End If

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

            'si valida todo los texbox entonces debe actualizar
        Else
            Dim Promedio = (CInt(TextBoxNota1.Text) + CInt(TextBoxNota2.Text) + CInt(TextBoxNota3.Text)) / 3
            Dim actualizar As String = String.Format("UPDATE Matricula SET Nota1= '{0}', Nota2 = '{1}', Nota3= '{2}', Promedio = '{3}'    WHERE IdMatricula = {4} ", TextBoxNota1.Text, TextBoxNota2.Text, TextBoxNota3.Text, Promedio, NOtaID1)
            db.NotQuery(actualizar)
            MsgBox("Nota Actualizada")
            Me.Close()
        End If
    End Sub
End Class