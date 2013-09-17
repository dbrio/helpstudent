
Public Class Historial
    Dim x As Integer = 30
    Dim y As Integer = 80
    Dim numeroCuadro As Integer = 0
    Dim i As Integer = 1
    Public Property tag As Object


    Private Sub Historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelCarrera.Text = UsuarioActivo.carrera

        GenerarPlan2()
    End Sub
    Dim db As New DBManager


    Sub GenerarPlan2()
        

        Using cnn As New SQLite.SQLiteConnection(db.CNN)
            Dim consulta As String = String.Format("SELECT Clase.Nombre,Clase.CodClase, Matricula.Promedio,Maestro.IdMaestro,Requisitos.CodRequisito  FROM CarreraClase INNER JOIN Clase ON CarreraClase.CodClase = Clase.CodClase LEFT OUTER JOIN Requisitos ON Clase.CodClase = Requisitos.CodClase LEFT OUTER JOIN Matricula ON Clase.CodClase = Matricula.CodClase LEFT OUTER JOIN Maestro ON Matricula.IdMaestro = Maestro.IdMaestro INNER JOIN PeridoCatalogo ON CarreraClase.IdPeriodoCatalogo = PeridoCatalogo.IdPeriodoCatalogo INNER JOIN Carrera ON CarreraClase.IdCarrera = Carrera.IdCarrera WHERE Carrera.IdCarrera = '{0}' ORDER BY CarreraClase.IdAno, CarreraClase.IdPeriodoCatalogo", UsuarioActivo.IdCarrera)


            Dim cmd As New SQLite.SQLiteCommand(consulta, cnn)
            cnn.Open()
            Dim reader As SQLite.SQLiteDataReader = cmd.ExecuteReader

            If reader.HasRows Then
                While reader.Read
                    Dim label As New Label
                    Dim label2 As New Label


                    AddHandler label.Click, AddressOf LabelEvent 'Se agrega un manejador para el evento click de la etiqueta que es direccionado a sub LabelEvent
                    AddHandler label.MouseHover, AddressOf hover
                    '(Esto es la definición de eventos a controles de forma dinámica)


                    label.Tag = reader.Item(4).ToString

                    label.Width = 220 'Ancho de 60px
                    label.Height = 60 'Alto de 30px
                    label2.Width = 80 'Ancho de 60px
                    label2.Height = 15 'Alto de 30px
                    label.BackColor = SystemColors.HotTrack 'Color de fondo
                    label2.BackColor = Color.FromArgb(&H0, &H8A, &HCF) 'Color de fondo
                    label.TextAlign = ContentAlignment.MiddleCenter
                    label2.TextAlign = ContentAlignment.MiddleCenter
                    label.ForeColor = Color.White
                    label2.ForeColor = Color.White
                    label2.Text = Font.Bold
                    label.Text = reader.GetValue(0)
                    label2.Text = reader.GetValue(1)

                    Dim promedio As Integer

                    If reader.GetValue(2) Is DBNull.Value Then
                        promedio = 0
                    Else
                        promedio = reader.GetValue(2)
                    End If

                    If promedio > 60 Then
                        label.BackColor = Color.FromArgb(&H99, &HCC, &H99) 'Color de fondo
                        label2.BackColor = Color.FromArgb(&H77, &HB0, &H5A) 'Color de fondo
                    Else
                        label.BackColor = Color.FromArgb(&H33, &H99, &HCC) 'Color de fondo
                    End If

                    'If hola < 60 Then
                    '    label.BackColor = SystemColors.HotTrack 'Color de fondo

                    'Else
                    '    label.BackColor = Color.FromArgb(&H0, &H66, &H0) 'Color de fondo
                    'End If



                    numeroCuadro += 1 'Variable que llevará el conteo de cuantos cuadros hay por línea


                    If numeroCuadro = 5 Then 'Si el numero del siguiente cuadro es 5, entonces se definen nuevas posiciones para x, y
                        y += 90 'Se suman 35px al valor actual de y
                        x = 30 'Se reinicia el valor de x en 5px (o sea al principio de la línea)
                        numeroCuadro = 1 'Se reinicia el conteo de cuadros en 1 para la nueva línea de cuadros
                        label.Location = New Point(x, y) 'Se definen los valores de la posición del cuadro en el eje x, y (primer cuadro)
                        label2.Location = New Point(x, y)
                    Else

                        label.Location = New Point(x, y) 'Se definen los valores de la posición del cuadro en el eje x, y (segundo cuadro en adelante)
                        label2.Location = New Point(x, y)
                    End If



                    Controls.Add(label2)
                    Controls.Add(label) 'Se agrega el cuadro a la colección control del contenedor (el form en este caso)
                    x += 235 ' Se suman 70px al valor actual de x (10px mas del ancho del cuadro para que se note la separación)
                    i += 1
                End While
            End If

        End Using


  
    End Sub
  

    Private Sub hover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cuadro As Label = DirectCast(sender, Label)


        Using cnn As New SQLite.SQLiteConnection(db.CNN)

            Dim consulta As String = String.Format("Select clase.Nombre from Clase inner join Requisitos on Clase.CodClase = Requisitos.CodClase WHERE Clase.CodClase ='{0}'", cuadro.Tag)
            Dim cmd As New SQLite.SQLiteCommand(consulta, cnn)
            cnn.Open()
            Dim reader As SQLite.SQLiteDataReader = cmd.ExecuteReader



            If reader.HasRows Then
                While reader.Read

                    cuadro.BackColor = Color.AliceBlue

                    'MsgBox(reader.GetValue(0), MsgBoxStyle.Information, "Requisito")
                End While
            End If

        End Using
        
    End Sub

    
    Private Sub LabelEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cuadro As Label = DirectCast(sender, Label)

        'Aquí puede ir el código de cada cuadro
        'Ejemplo: Mostrar en un MsgBox el nombre de cada cuadro

        Using cnn As New SQLite.SQLiteConnection(db.CNN)

            Dim consulta As String = String.Format("Select clase.Nombre from Clase inner join Requisitos on Clase.CodClase = Requisitos.CodClase WHERE Clase.CodClase ='{0}'", cuadro.Tag)
            Dim cmd As New SQLite.SQLiteCommand(consulta, cnn)
            cnn.Open()
            Dim reader As SQLite.SQLiteDataReader = cmd.ExecuteReader


            If reader.HasRows Then
                While reader.Read
                    MsgBox(reader.GetValue(0), MsgBoxStyle.Information, "Requisito")
                End While
            End If

        End Using


    End Sub

    'Sub Requisitos()


    '    Using cnn As New SQLite.SQLiteConnection(db.CNN)

    '        Dim consulta As String = String.Format("Select clase.Nombre from Clase inner join Requisitos on Clase.CodClase = Requisitos.CodClase WHERE Clase.CodClase ='{0}'", numeroCuadro..tag)
    '        Dim cmd As New SQLite.SQLiteCommand(consulta, cnn)
    '        cnn.Open()
    '        Dim reader As SQLite.SQLiteDataReader = cmd.ExecuteReader


    '        If reader.HasRows Then
    '            While reader.Read

    '                Dim hola As String = reader.GetValue(0)

    '            End While
    '        End If

    '    End Using
    'End Sub

End Class