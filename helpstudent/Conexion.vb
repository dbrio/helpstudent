Imports System.Data.SQLite

Imports System.Data.SqlClient

Module conexion
    Public path1 As String = AppDomain.CurrentDomain.BaseDirectory
    Public dbpath As String = path1.Replace("\bin\Debug\", "\StudentApp.s3db")
    Public cnnString As String = String.Format("Data Source={0}", dbpath)
End Module

