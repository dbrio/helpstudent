Imports System.Net.NetworkInformation

Public Class Registro
    Dim DS As New DataSet

    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        Dim dia As String = TextEditDia.EditValue
        Dim mes As String = TextEditMes.EditValue
        Dim ano As String = TextEditAno.EditValue

        Dim fecha As String = ano + "/" + mes + "/" + dia
        Dim fecha2 As String = dia + "/" + mes + "/" + ano


        If CtaAlumTextEdit.Text.Trim = "" Or Not IsNumeric(CtaAlumTextEdit.EditValue) Then
            MsgBox("Cuenta no valida ", MsgBoxStyle.Information, "HelStudent")
            CtaAlumTextEdit.Focus()
            CtaAlumTextEdit.BackColor = Color.LemonChiffon


            Exit Sub
        End If

        If NombreTextEdit.Text.Trim = "" Then
            MsgBox("Debe escribir un nombre", MsgBoxStyle.Information, "HelpStudent")
            NombreTextEdit.Focus()
            NombreTextEdit.BackColor = Color.LemonChiffon
            Exit Sub

        End If

        If ApellidoTextEdit.Text.Trim = "" Then
            MsgBox("Debe escribir un Apellido", MsgBoxStyle.Information, "HelpStudent")
            ApellidoTextEdit.Focus()
            ApellidoTextEdit.BackColor = Color.LemonChiffon
            Exit Sub

        End If

        

        If TelefonoTextEdit.Text.Trim = "" Then
            MsgBox("Debe escribir su numero telefonico", MsgBoxStyle.Information, "HelpStudent")
            TelefonoTextEdit.Focus()
            TelefonoTextEdit.BackColor = Color.LemonChiffon
            Exit Sub

        End If


        If ComboBoxSexo.Text.Trim = "" Then
            MsgBox("Debe seleccionar un genero", MsgBoxStyle.Information, "HelpStudent")
            ComboBoxSexo.Focus()
            ComboBoxSexo.BackColor = Color.LemonChiffon
            Exit Sub

        End If

        If ComboBoxCarrera.Text.Trim = "" Then
            MsgBox("Debe seleccionar una carrera", MsgBoxStyle.Information, "HelpStudent")
            ComboBoxCarrera.Focus()
            ComboBoxCarrera.BackColor = Color.LemonChiffon
            Exit Sub

        End If

        If TextEditUsuario.Text.Trim = "" Then
            MsgBox("Debes de escribir tu usuario", MsgBoxStyle.Information, "HelpStudent")
            TextEditUsuario.Focus()
            TextEditUsuario.BackColor = Color.LemonChiffon
            Exit Sub

        End If
        If ContrasenaTextBox.Text.Trim = "" Then
            MsgBox("Debes de escribir una contraseña", MsgBoxStyle.Information, "HelpStudent")
            ContrasenaTextBox.Focus()
            ContrasenaTextBox.BackColor = Color.LemonChiffon
            Exit Sub

        End If


        If NetworkInterface.GetIsNetworkAvailable Then
            Try
                'Registramos el Alumno con el usuario db StudentApp
                Dim InserAlumno As String = String.Format("INSERT INTO Alumno (CtaAlum, Nombre, Apellido, FechNac, Telefono, IdSexo, IdCarrera, Correo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", CtaAlumTextEdit.EditValue, NombreTextEdit.EditValue, ApellidoTextEdit.EditValue, fecha2, TelefonoTextEdit.EditValue, ComboBoxSexo.SelectedValue, ComboBoxCarrera.SelectedValue, CorreoTextEdit.EditValue)
                Dim InsertLogin As String = String.Format("INSERT INTO Login (Usuario, Contrasena, CtaAlum) VALUES ('{0}','{1}','{2}')", TextEditUsuario.EditValue, ContrasenaTextBox.Text, CtaAlumTextEdit.EditValue)
                db.NotQuery(InserAlumno)
                db.NotQuery(InsertLogin)
                Dim InserAlumno2 As String = String.Format("INSERT INTO Alumno (CtaAlum, Nombre, Apellido, FechNac, Telefono, IdSexo, IdCarrera, Correo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", CtaAlumTextEdit.EditValue, NombreTextEdit.EditValue, ApellidoTextEdit.EditValue, fecha, TelefonoTextEdit.EditValue, ComboBoxSexo.SelectedValue, ComboBoxCarrera.SelectedValue, CorreoTextEdit.EditValue)
                db.MyNotQuery(InserAlumno2)
                db.MyNotQuery(InsertLogin)
                MsgBox("Te has registrado Exitosamente !Exitos!", MsgBoxStyle.Information, "Registro exitoso")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else

        End If

        login.Show()
        Me.Close()
    End Sub




    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CtaAlumTextEdit.Focus()


        ComboBoxSexo.DisplayMember = "Sexo"
        ComboBoxSexo.ValueMember = "IdSexo"
        ComboBoxSexo.DataSource = db.GetData("SELECT IdSexo, Sexo FROM Sexo")

        ComboBoxCarrera.DisplayMember = "Nombre"
        ComboBoxCarrera.ValueMember = "IdCarrera"
        ComboBoxCarrera.DataSource = db.GetData("SELECT IdCarrera, Nombre FROM Carrera WHERE IdCarrera <>5")

    End Sub

    
  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
        Dim dia As String = TextEditDia.EditValue
        Dim mes As String = TextEditMes.EditValue
        Dim ano As String = TextEditAno.EditValue

        Dim fecha As String = ano + "/" + mes + "/" + dia
        Dim fecha2 As String = dia + "/" + mes + "/" + ano

        MsgBox(fecha2)
    End Sub
End Class