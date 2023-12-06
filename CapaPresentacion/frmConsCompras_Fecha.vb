Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmConsCompras_Fecha
    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmConsCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Server=localhost; Database=TattoomyDB; Integrated Security=SSPI"
        conexion.Open()
    End Sub

    Private Sub dtFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtFecha.ValueChanged
        Dim fecha As String
        dgConsCompras.Rows.Clear()
        fecha = dtFecha.Value.Year & "/" & dtFecha.Value.Month & "/" & dtFecha.Value.Day

        comando.CommandText = "SELECT C.IdCompra, P.IdProveedor, P.Nombre, C.FechaCompra, C.Total FROM Compras AS C INNER JOIN Proveedores AS P ON C.IdProveedor=P.IdProveedor WHERE C.FechaCompra= '" & fecha & "'"
        lector = comando.ExecuteReader
        While lector.Read
            dgConsCompras.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

End Class