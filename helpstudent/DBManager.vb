Imports MySql.Data.MySqlClient
Imports System.Data.SQLite



Public Class DBManager
    Private TemporalCNN As New SQLiteConnection
    Private MyCNN As New MySqlConnection
    Private CNN As New SQLiteConnection

    Public Sub New()

        'conexion a sqlite
        Dim path1 As String = AppDomain.CurrentDomain.BaseDirectory
        Dim dbpath As String = path1.Replace("\bin\Debug\", "\StudentApp.s3db")
        CNN.ConnectionString = String.Format("Data Source={0}", dbpath)

        Dim path2 As String = AppDomain.CurrentDomain.BaseDirectory
        Dim dbpath2 As String = path2.Replace("\bin\Debug\", "\temporal.s3db")
        TemporalCNN.ConnectionString = String.Format("Data Source={0}", dbpath2)

        'Conexion a mysql
        Dim host As String = "db4free.net"
        Dim user As String = "studentapp"
        Dim pass As String = "HelpUphCh01"
        Dim db As String = "studentapp"
        MyCNN.ConnectionString = String.Format("server={0}; uid={1}; pwd={2}; database={3}", host, user, pass, db)

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
                Return ex.Message
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
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
