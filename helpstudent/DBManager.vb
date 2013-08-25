Imports System.Data.SQLite

Public Class DBManager
    Private CNN As New SQLiteConnection

    Public Sub New()
        Dim path1 As String = AppDomain.CurrentDomain.BaseDirectory
        Dim dbpath As String = path1.Replace("\bin\Debug\", "\StudentApp.s3db")
        CNN.ConnectionString = String.Format("Data Source={0}", dbpath)
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


    Public Function NotQuery(ByVal comando As String)
        Using CMD As New SQLiteCommand(comando)
            Try
                CNN.Open()
                CMD.ExecuteNonQuery()
                CNN.Close()
                Return True
            Catch ex As Exception

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
End Class
