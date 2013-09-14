Imports MySql.Data.MySqlClient
Imports System.Data.SQLite

Public Class DBManager
    Private TemporalCNN As New SQLiteConnection
    Private MyCNN As New MySqlConnection
    Public CNN As New SQLiteConnection

    Public Sub New()

        'conexion a sqlite
        Dim path1 As String = AppDomain.CurrentDomain.BaseDirectory
        Dim dbpath As String = path1.Replace("\bin\Debug\", "\StudentApp.s3db")
        CNN.ConnectionString = String.Format("Data Source={0}", dbpath)


        'Conexion a mysql
        Dim host As String = "db4free.net"
        Dim user As String = "studentapp"
        Dim pass As String = "HelpUphCh01"
        Dim db As String = "studentapp"
        MyCNN.ConnectionString = String.Format("server={0}; uid={1}; pwd={2}; database={3}", host, user, pass, db)


        Dim Temp As String = AppDomain.CurrentDomain.BaseDirectory
        Dim dbTempo As String = Temp.Replace("\bin\Debug\", "\temporal.s3db")
        TemporalCNN.ConnectionString = String.Format("Data Source={0}", dbTempo)

    End Sub
   

    Public Function GetData(ByVal cmd As String, Optional ByVal table As String = "Tablex")

        Try
            Using DS As New DataSet
                Using DA As New SQLiteDataAdapter(cmd, CNN)
                    DA.Fill(DS, table)
                End Using
                Return DS.Tables(table)
            End Using
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function MyCargarDatos(ByVal comando As String, ByVal NombreTabla As String)
        Try
            Using DS As New DataSet()
                Using DA As New MySqlDataAdapter(comando, MyCNN)
                    DA.Fill(DS, NombreTabla)
                End Using
                Return DS.Tables(NombreTabla)
            End Using
        Catch ex As MySqlException
            Return Nothing
        End Try
    End Function


    Public Function GetDataTemporal(ByVal cmd As String, Optional ByVal table As String = "Tablex")

        Try
            Using DS As New DataSet
                Using DA As New SQLiteDataAdapter(cmd, TemporalCNN)
                    DA.Fill(DS, table)
                End Using
                Return DS.Tables(table)
            End Using
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function NotQuery(ByVal comando As String)
        Using CMD As New SQLiteCommand(comando, CNN)
            Try
                CNN.Open()
                CMD.ExecuteNonQuery()
                CNN.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function
    Public Function NotQueryTemporal(ByVal comando As String)
        Using CMD As New SQLiteCommand(comando, TemporalCNN)
            Try
                TemporalCNN.Open()
                CMD.ExecuteNonQuery()
                TemporalCNN.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

  


    Public Function MyNotQuery(ByVal mycomando As String)
        Using MyCMD As New MySqlCommand(mycomando, MyCNN)
            Try
                MyCNN.Open()
                MyCMD.ExecuteNonQuery()
                MyCNN.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Function GetLastID(ByVal col As String, ByVal table As String) As Integer
        Try
            Dim sql As String = String.Format("SELECT MAX({0}) FROM {1}", col, table)
            Dim ID As Integer

            Using CMD As New SQLiteCommand(sql, CNN)
                CNN.Open()
                ID = CMD.ExecuteScalar
                CNN.Close()
            End Using
            Return ID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    

    Public Function GetCount(ByVal col As String, ByVal table As String) As Integer
        Try
            Dim sql As String = String.Format("SELECT COUNT({0}) FROM {1}", col, table)
            Dim ID2 As Integer

            Using cuenta As New SQLiteCommand(sql, TemporalCNN)
                TemporalCNN.Open()
                ID2 = cuenta.ExecuteScalar
                TemporalCNN.Close()
            End Using
            Return ID2
        Catch ex As Exception
            Return Nothing
        End Try
    End Function



    Public Function Login(ByVal user As String, ByVal pass As String) As Boolean

        Dim sql As String = String.Format("SELECT Login.Usuario,Login.Contrasena,Alumno.CtaAlum,Alumno.Nombre,Alumno.Apellido,Alumno.Telefono,Sexo.Sexo,Carrera.Nombre,Alumno.Correo,Carrera.IdCarrera, CarreraClase.IdAno FROM Login INNER JOIN Alumno ON Login.CtaAlum = Alumno.CtaAlum INNER JOIN Sexo ON Alumno.IdSexo = Sexo.IdSexo INNER JOIN Carrera ON Alumno.IdCarrera = Carrera.IdCarrera INNER JOIN CarreraClase ON Carrera.IdCarrera = CarreraClase.IdCarrera WHERE Login.Usuario = '{0}' AND Login.Contrasena = '{1}'", user, pass)

        Using validar As New SQLiteCommand(sql, CNN)

            Dim reader As SQLiteDataReader = validar.ExecuteReader

            If reader.HasRows Then 'Indica que hay registros en el reader
                While reader.Read 'Recorre cada registro de la colección
                    UsuarioActivo.usuario = reader.GetValue(0).ToString
                    UsuarioActivo.cuenta = reader.GetValue(2).ToString
                    UsuarioActivo.nombre = reader.GetValue(3).ToString 'Suponiendo que el nombre está en la cuarta columna
                    UsuarioActivo.apellido = reader.GetValue(4).ToString 'Suponiendo que el nombre está en la quinta columna
                    UsuarioActivo.telefono = reader.GetValue(5).ToString
                    UsuarioActivo.sexo = reader.GetValue(6).ToString
                    UsuarioActivo.carrera = reader.GetValue(7).ToString
                    UsuarioActivo.correo = reader.GetValue(8).ToString
                    UsuarioActivo.IdCarrera = reader.GetValue(9).ToString

                End While


                Return True
            Else
                Return False
            End If

        End Using
    End Function




   


    
End Class
