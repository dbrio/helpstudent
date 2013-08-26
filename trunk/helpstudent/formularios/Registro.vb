Imports System.Net.NetworkInformation

Public Class Registro

    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
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

        If DateEdit1.Text.Trim = "" Then
            MsgBox("Debe escribir una fecha de nacimiento", MsgBoxStyle.Information, "HelpStudent")
            DateEdit1.Focus()
            DateEdit1.BackColor = Color.LemonChiffon
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
                Dim InserAlumno As String = String.Format("INSERT INTO Alumno (CtaAlum, Nombre, Apellido, FechNac, Telefono, IdSexo, IdCarrera, Correo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", CtaAlumTextEdit.EditValue, NombreTextEdit.EditValue, ApellidoTextEdit.EditValue, DateEdit1.EditValue, TelefonoTextEdit.EditValue, ComboBoxSexo.Text, TelefonoTextEdit.EditValue, CorreoTextEdit.EditValue)
                Dim InsertLogin As String = String.Format("INSERT INTO Login (Usuario, Contrasena, CtaAlum) VALUES ('{0}','{1}','{2}')", TextEditUsuario.EditValue, ContrasenaTextBox.Text, CtaAlumTextEdit.EditValue)
                db.NotQuery(InserAlumno)
                db.NotQuery(InsertLogin)
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

        ComboBoxSexo.Items.Insert("0", "Masculino")
        ComboBoxSexo.Items.Insert("1", "Femenino")

        ComboBoxCarrera.Items.Insert("0", "Ingenería en Sistema")
        ComboBoxCarrera.Items.Insert("1", "Ingenería en Industrial")
        ComboBoxCarrera.Items.Insert("2", "Lic En Gerencia de Negocios")
        ComboBoxCarrera.Items.Insert("3", "Ingenería Electronica")
        ComboBoxCarrera.Items.Insert("4", "Lic. En Gerencia de Turismo")






    End Sub


   
End Class