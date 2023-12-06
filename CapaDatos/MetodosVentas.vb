Imports System.Data.SqlClient
Public Class MetodosVentas
    Dim conexObj As New Conex
    Dim conex As SqlConnection
    Dim adapter As SqlDataAdapter

    Public Function mostrarVentas() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarVentas", conex)
            adapter.Fill(data, "LISTA")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function mostrarVentasFecha(ByVal fecha As String) As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarVentasFecha", conex)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure

            adapter.SelectCommand.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha
            conex.Open()
            adapter.SelectCommand.ExecuteNonQuery()
            adapter.Fill(data, "ListaFecha")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function
    Public Function mostrarVentasRango(ByVal fecha1 As String, ByVal fecha2 As String) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("ListarVentasRango", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                adapter.SelectCommand.Parameters.Add("@fecha1", SqlDbType.Date).Value = fecha1
                adapter.SelectCommand.Parameters.Add("@fecha2", SqlDbType.Date).Value = fecha2
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListaRango")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Errorsini " & ex.Message)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Function

    Public Function mostrarVentasArriba(ByVal cantidad As Double) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("ListarVentasArriba", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                adapter.SelectCommand.Parameters.Add("@Cantidad", SqlDbType.Money).Value = cantidad
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListaArriba")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Errorsini " & ex.Message)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Function

    Public Function mostrarVentasAbajo(ByVal cantidad As Double) As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarVentasAbajo", conex)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure

            adapter.SelectCommand.Parameters.Add("@Cantidad", SqlDbType.Money).Value = cantidad
            conex.Open()
            adapter.SelectCommand.ExecuteNonQuery()
            adapter.Fill(data, "ListaAbajo")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Sub agregarVenta(ByVal fechaVenta As String, ByVal total As Double)
        Try
            conex = conexObj.link
            adapter = New SqlDataAdapter("AgregarVenta", conex)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure

            adapter.SelectCommand.Parameters.Add("@FechaVenta", SqlDbType.Date).Value = fechaVenta
            adapter.SelectCommand.Parameters.Add("@Total", SqlDbType.Money).Value = total

            conex.Open()
            adapter.SelectCommand.ExecuteNonQuery()
            conex.Close()
        Catch ex As Exception
            MsgBox("Errorsini al agregar venta: " & Err.Description)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Sub

    Public Sub agregarDetVenta(ByVal idVenta As Integer, ByVal idInsumos As Integer, ByVal cantidad As Integer, ByVal precio As Double)
        Try
            conex = conexObj.link
            adapter = New SqlDataAdapter("AgregarDetVenta", conex)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure

            adapter.SelectCommand.Parameters.Add("@IdCompra", SqlDbType.Int).Value = idVenta
            adapter.SelectCommand.Parameters.Add("@IdInsumos", SqlDbType.Int).Value = idInsumos
            adapter.SelectCommand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = cantidad
            adapter.SelectCommand.Parameters.Add("@Precio", SqlDbType.Money).Value = precio

            conex.Open()
            adapter.SelectCommand.ExecuteNonQuery()
            conex.Close()
        Catch ex As Exception
            MsgBox("Errorsini" & Err.Description)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Sub
End Class
