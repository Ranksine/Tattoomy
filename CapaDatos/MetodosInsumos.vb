Imports System.Data.SqlClient
Public Class MetodosInsumos
    Dim conexObj As New Conex
    Dim conex As SqlConnection
    Dim adapter As SqlDataAdapter

    Public Function consultarInsumos() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarInsumos", conex)
            adapter.Fill(data, "LISTA")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Sub registrarInsumo(ByVal Nombre As String, ByVal Descripcion As String, ByVal IdMarca As Integer, ByVal IdCategorias As Integer,
                                   ByVal Costo As String, ByVal Precio As String, ByVal Existencia As Integer, ByVal Max As Integer,
                                   ByVal Min As Integer)
        Try
            conex = conexObj.link
            adapter = New SqlDataAdapter("RegistrarInsumo", conex)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
            adapter.SelectCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion
            adapter.SelectCommand.Parameters.Add("@IdMarca", SqlDbType.Int).Value = IdMarca
            adapter.SelectCommand.Parameters.Add("@IdCategorias", SqlDbType.Int).Value = IdCategorias
            adapter.SelectCommand.Parameters.Add("@Costo", SqlDbType.Money).Value = Costo
            adapter.SelectCommand.Parameters.Add("@Precio", SqlDbType.Money).Value = Precio
            adapter.SelectCommand.Parameters.Add("@Existencia", SqlDbType.Int).Value = Existencia
            adapter.SelectCommand.Parameters.Add("@Max", SqlDbType.Int).Value = Max
            adapter.SelectCommand.Parameters.Add("@Min", SqlDbType.Int).Value = Min
            conex.Open()
            adapter.SelectCommand.ExecuteNonQuery()
            conex.Close()
        Catch
            MsgBox("Ocurrió un error " & Err.Description)
        Finally
            adapter.Dispose()
            conex.Dispose()
        End Try
    End Sub
End Class
