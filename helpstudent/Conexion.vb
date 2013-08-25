Imports System.Data.SQLite
Imports MySql.Data.MySqlClient

Module conexion
    Public path1 As String = AppDomain.CurrentDomain.BaseDirectory
    Public dbpath As String = path1.Replace("\bin\Debug\", "\StudentApp.s3db")
    Public cnnString As String = String.Format("Data Source={0}", dbpath)


    Public path2 As String = AppDomain.CurrentDomain.BaseDirectory
    Public dbpath2 As String = path1.Replace("\bin\Debug\", "\temporal.s3db")
    Public cnnString2 As String = String.Format("Data Source={0}", dbpath2)

    Public mysqlconexion As New MySqlConnection(My.Settings.mysql)



End Module

