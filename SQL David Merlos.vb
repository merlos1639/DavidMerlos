Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New MySqlConnection
        Try
            conexion.ConnectionString = "server=localhost; user=root; password=; database=colegio"
            conexion.Open()
            MsgBox("CONECTADO")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
