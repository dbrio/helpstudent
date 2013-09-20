Imports System.Net.NetworkInformation

Public Class AgregarClase

    Private Sub AgregarClase_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIParent1.Enabled = True
    End Sub

    Private Sub AgregarClase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'llenamos todo los texbos con la informacion que correspond
        Dim llenar As String = String.Format("SELECT Clase.CodClase,Clase.Nombre FROM  CarreraClase INNER JOIN Clase ON CarreraClase.CodClase = Clase.CodClase INNER JOIN Carrera ON CarreraClase.IdCarrera = Carrera.IdCarrera WHERE Carrera.IdCarrera = '{0}' ORDER BY CarreraClase.IdAno", UsuarioActivo.IdCarrera)
        ComboBoxClases.DisplayMember = "Nombre"
        ComboBoxClases.ValueMember = "CodClase"
        ComboBoxClases.DataSource = db.GetData(llenar)

        ComboBoxMaestro.DisplayMember = "Nombre"
        ComboBoxMaestro.ValueMember = "IdMaestro"
        ComboBoxMaestro.DataSource = db.GetData("SELECT IdMaestro, Nombre||' '||Apellido AS Nombre FROM Maestro")

        ComboBoxPeriodo.DisplayMember = "Peridodo"
        ComboBoxPeriodo.ValueMember = "IdPeriodoCatalogo"
        ComboBoxPeriodo.DataSource = db.GetData("SELECT IdPeriodoCatalogo,Peridodo FROM PeridoCatalogo")

        TextBoxAnio.Text = Year(Now)

    End Sub




    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        If NetworkInterface.GetIsNetworkAvailable Then
            Try
                'Registramos el Alumno con el usuario db StudentApp
                Dim AddClase As String = String.Format("INSERT INTO Matricula (CodClase, IdPeriodoCatalogo, Hora, Dia, IdMaestro, CtaAlum) VALUES ('{0}',{1},'{2}','{3}','{4}','{5}')", ComboBoxClases.SelectedValue, ComboBoxPeriodo.Text, TextBoxHora.Text, ComboBoxDia.Text, ComboBoxMaestro.SelectedValue, UsuarioActivo.cuenta)

                db.NotQuery(AddClase)

                Dim AddClase2 As String = String.Format("INSERT INTO Matricula (CodClase, IdPeriodo, Hora, Dia, IdMaestro, CtaAlum) VALUES ('{0}',{1},'{2}','{3}','{4}','{5}')", ComboBoxClases.SelectedValue, ComboBoxPeriodo.Text, TextBoxHora.Text, ComboBoxDia.DisplayMember, ComboBoxMaestro.SelectedValue, UsuarioActivo.cuenta)
                db.MyNotQuery(AddClase2)

                MsgBox("Asignatura Agregada correctamente!", MsgBoxStyle.Information, "Registro exitoso")

                With Matricula
                    .MdiParent = MdiParent
                    .Show()
                    .Focus()
                End With
                MDIParent1.Enabled = True
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Class