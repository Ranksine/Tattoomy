Imports System.Data.SqlClient
Imports System.Configuration
Public Class Conex
    Dim conex As SqlConnection
    Public Function link() As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        Return conex
    End Function
End Class
