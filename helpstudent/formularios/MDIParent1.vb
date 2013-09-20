Imports System.Net.NetworkInformation
Imports System.Windows.Forms
Public Class MDIParent1
    Dim DS As New DataSet

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        'cargamos el formulario AgregarClase
        Try

            With AgregarClase
                .MdiParent = MdiParent
                .Show()
                .Focus()
            End With
            Me.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Salimos del programa
        Me.Close()
        Inicio.Close()
        PlandeEstudio.Close()
        perfil.Close()
        Matricula.Close()
        Propuesta.Close()
        Historial.Close()
        EditarUsuario.Close()
        ActualizarNotas.Close()


    End Sub


    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim contar As Integer = db.GetCount("CtaAlum", "Alumno") 'Contamos cuantos registros hay en la tabla alumno
        If NetworkInterface.GetIsNetworkAvailable And contar > 0 Then
            Dim agenda As DataTable = db.GetDataTemporal("SELECT * FROM Agenda")
            Dim alumnos As DataTable = db.GetDataTemporal("SELECT * FROM Alumno")
            Dim login As DataTable = db.GetDataTemporal("SELECT * FROM Login")
            Dim matricula As DataTable = db.GetDataTemporal("SELECT * FROM Matricula")
            Dim periodo As DataTable = db.GetDataTemporal("SELECT * FROM Periodo")

            For Each linea As DataRow In alumnos.Rows
                'Insertamos a mysql si hay internet
                Dim insert As String = String.Format("INSERT INTO Alumno (CtaAlum, Nombre, Apellido, Telefono,IdSexo,IdCarrera,Correo,Imagen) VALUES ('{0}','{1}','{2}','{3}','{4}',{5},{6},'{7}')", linea(0), linea(1), linea(2), linea(3), linea(4), linea(5), linea(6), linea(7))
                db.MyNotQuery(insert)

                'Borramos de la base de datos temporarl tabla Alumno
                db.NotQueryTemporal("DELETE FROM Alumno")

            Next

            Inicio.Show()
            Inicio.MdiParent = Me
           
        Else
            Dim star = Inicio
            star.MdiParent = Me
            star.Show()
        End If


    End Sub

    
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Regresamos al inicio
        Inicio.Show()
        Inicio.MdiParent = Me
        perfil.Close()
        Historial.Close()
        Matricula.Close()
        PlandeEstudio.Close()
        Propuesta.Close()
        EditarUsuario.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'abrimos el formulario matricula
            With Matricula
                .MdiParent = MdiParent
                .Show()
                .Focus()
            End With
            Me.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

 
    
   
End Class

