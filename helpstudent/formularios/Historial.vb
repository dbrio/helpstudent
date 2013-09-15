
Public Class Historial
    


    Private Sub Historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GenerarPlan2()
    End Sub
    Dim db As New DBManager


    Sub GenerarPlan2()
        Dim x As Integer = 5
        Dim y As Integer = 5
        Dim numeroCuadro As Integer = 0
        Dim i As Integer = 1

        Using cnn As New SQLite.SQLiteConnection(db.CNN)
            Dim cmd As New SQLite.SQLiteCommand("SELECT Clase.Nombre,Clase.CodClase FROM CarreraClase INNER JOIN Clase ON CarreraClase.CodClase = Clase.CodClase INNER JOIN PeridoCatalogo ON CarreraClase.IdPeriodoCatalogo = PeridoCatalogo.IdPeriodoCatalogo INNER JOIN Carrera ON CarreraClase.IdCarrera = Carrera.IdCarrera WHERE Carrera.IdCarrera = 1 ORDER BY CarreraClase.IdAno, CarreraClase.IdPeriodoCatalogo", cnn)
            cnn.Open()
            Dim reader As SQLite.SQLiteDataReader = cmd.ExecuteReader

            If reader.HasRows Then
                While reader.Read
                    Dim label As New Label
                    Dim label2 As New Label

                    AddHandler label.Click, AddressOf LabelEvent 'Se agrega un manejador para el evento click de la etiqueta que es direccionado a sub LabelEvent
                    '(Esto es la definición de eventos a controles de forma dinámica)


                    label.Name = reader.GetValue(0)
                    label.Width = 240 'Ancho de 60px
                    label.Height = 50 'Alto de 30px
                    label2.Width = 70 'Ancho de 60px
                    label2.Height = 15 'Alto de 30px
                    label.BackColor = SystemColors.HotTrack 'Color de fondo
                    label2.BackColor = Color.FromArgb(&H33, &H66, &H99) 'Color de fondo
                    label.TextAlign = ContentAlignment.MiddleCenter
                    label2.TextAlign = ContentAlignment.MiddleCenter
                    label.Text = Font.Bold
                    label.ForeColor = Color.White
                    label2.ForeColor = Color.White
                    label.Text = reader.GetValue(0)
                    label2.Text = reader.GetValue(1)

                    numeroCuadro += 1 'Variable que llevará el conteo de cuantos cuadros hay por línea

                    If numeroCuadro = 5 Then 'Si el numero del siguiente cuadro es 5, entonces se definen nuevas posiciones para x, y
                        y += 60 'Se suman 35px al valor actual de y
                        x = 5 'Se reinicia el valor de x en 5px (o sea al principio de la línea)
                        numeroCuadro = 1 'Se reinicia el conteo de cuadros en 1 para la nueva línea de cuadros
                        label.Location = New Point(x, y) 'Se definen los valores de la posición del cuadro en el eje x, y (primer cuadro)
                        label2.Location = New Point(x, y)
                    Else
                        label.Location = New Point(x, y) 'Se definen los valores de la posición del cuadro en el eje x, y (segundo cuadro en adelante)
                        label2.Location = New Point(x, y)
                    End If

                    Controls.Add(label2)
                    Controls.Add(label) 'Se agrega el cuadro a la colección control del contenedor (el form en este caso)
                    x += 260 ' Se suman 70px al valor actual de x (10px mas del ancho del cuadro para que se note la separación)
                    i += 1
                End While
            End If

        End Using
    End Sub



    Sub GenerarPlan()
        Dim x As Integer = 5
        Dim y As Integer = 5
        Dim numeroCuadro As Integer = 0




        For i As Integer = 1 To 60 'Este for simulará el While reader.Read() suponiendo que el reader tiene 60 registros
            Dim label As New Label

            AddHandler label.Click, AddressOf LabelEvent 'Se agrega un manejador para el evento click de la etiqueta que es direccionado a sub LabelEvent
            '(Esto es la definición de eventos a controles de forma dinámica)


            label.Name = String.Format("Clase{0}", i)
            label.Width = 60 'Ancho de 60px
            label.Height = 30 'Alto de 30px
            label.BackColor = Color.Aqua 'Color de fondo
            label.TextAlign = ContentAlignment.MiddleCenter
            label.Text = String.Format("Clase {0}", i)


            numeroCuadro += 1 'Variable que llevará el conteo de cuantos cuadros hay por línea

            If numeroCuadro = 5 Then 'Si el numero del siguiente cuadro es 5, entonces se definen nuevas posiciones para x, y
                y += 35 'Se suman 35px al valor actual de y
                x = 5 'Se reinicia el valor de x en 5px (o sea al principio de la línea)
                numeroCuadro = 1 'Se reinicia el conteo de cuadros en 1 para la nueva línea de cuadros
                label.Location = New Point(x, y) 'Se definen los valores de la posición del cuadro en el eje x, y (primer cuadro)
            Else
                label.Location = New Point(x, y) 'Se definen los valores de la posición del cuadro en el eje x, y (segundo cuadro en adelante)
            End If

            Controls.Add(label) 'Se agrega el cuadro a la colección control del contenedor (el form en este caso)
            x += 70 ' Se suman 70px al valor actual de x (10px mas del ancho del cuadro para que se note la separación)
        Next
    End Sub


    Private Sub LabelEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cuadro As Label = DirectCast(sender, Label)

        'Aquí puede ir el código de cada cuadro
        'Ejemplo: Mostrar en un MsgBox el nombre de cada cuadro

        MsgBox(cuadro.Name, MsgBoxStyle.Information, "Nombre")

    End Sub

    

End Class