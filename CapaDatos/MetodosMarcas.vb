Imports System.Data.SqlClient
Imports CapaEntidad
Public Class MetodosMarcas
    Dim conexObj As New Conex
    Dim conex As SqlConnection
    Dim adapter As SqlDataAdapter

    Public Function consultarMarcas() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarMarcas", conex)
            adapter.Fill(data, "CONS_MARCA")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function listarNombres() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarNombresMarcas", conex)
            adapter.Fill(data, "LIST_NOMBRES")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function buscarIdMarcaPorNombre(ByVal Nombre As String) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("BuscarMarcasNombre", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListaIdMarca")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Ocurrio un error" & Err.Description)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Function

    Public Sub registrarMarcas(ByVal Nombre As String, ByVal Descripcion As String)
        Try
            conex = conexObj.link
            adapter = New SqlDataAdapter("RegistrarMarcas", conex)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure

            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
            adapter.SelectCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion
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

    Public Function BuscarNombreMarcas(ByVal Nombre)
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("BuscarNombresMarcas", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "CONS_MARCA_NOMBRE")
                conex.Close()
                Return data
            End Using

        Catch ex As Exception
            MsgBox("Ocurrió un error " & Err.Description)
        Finally
            adapter.Dispose()
            conex.Dispose()
        End Try
        Return 0
    End Function
End Class
