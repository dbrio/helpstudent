Imports System.Net.NetworkInformation
Imports System.Data.SQLite
Public Class Registro
    Dim ex, ey As Integer
    Dim arrastrar As Boolean
    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        

        If NetworkInterface.GetIsNetworkAvailable Then
            Using CNN As New SQLiteConnection(cnnString)
                CNN.Open()

                Dim Q As String = "INSERT INTO Alumno (CtaAlum, Nombre, Apellido, FechNac, Telefono, IdSexo, IdCarrera, Correo) VALUES(@CtaAlum, @Nombre, @Apellido, @FechNac, @Telefono, @IdSexo, @IdCarrera, @Correo)"
                Dim U As String = "INSERT INTO Login ( Usuario, Contrasena, CtaAlum) VALUES ( @Usuario, @Contrasena,@CtaAlum )"

                Dim cmd As New SQLiteCommand(Q, CNN)
                Dim cm As New SQLiteCommand(U, CNN)
                cmd.Parameters.Add("@CtaAlum", SqlDbType.VarChar, 10).Value = CtaAlumTextEdit.EditValue
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = NombreTextEdit.EditValue
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 30).Value = ApellidoTextEdit.EditValue
                cmd.Parameters.Add("@FechNac", SqlDbType.Date).Value = DateEdit1.EditValue
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = TelefonoTextEdit.EditValue
                cmd.Parameters.Add("@IdSexo", SqlDbType.Int).Value = IdSexoTextBox.Text
                cmd.Parameters.Add("@IdCarrera", SqlDbType.Int).Value = IdCarreraTextBox.Text
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = CorreoTextEdit.EditValue
                cm.Parameters.Add("@Usuario", SqlDbType.VarChar, 10).Value = UsuarioTextBox.Text
                cm.Parameters.Add("@Contrasena", SqlDbType.VarChar, 40).Value = ContrasenaTextBox.Text
                cmd.ExecuteNonQuery()
                cm.ExecuteNonQuery()


                MsgBox("El Gallo ya canto")
                CNN.Close()
            End Using
        Else

        End If

        login.Show()
        Me.Close()
    End Sub

    Private Sub Registro_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        arrastrar = True
    End Sub

    Private Sub Registro_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If arrastrar Then
            Location = PointToScreen(New Point(MousePosition.X - Location.X - ex, MousePosition.Y - Location.Y - ex))

        End If

    End Sub

    Private Sub Registro_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        arrastrar = False
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        login.Show()
        Me.Close()
    End Sub
End Class