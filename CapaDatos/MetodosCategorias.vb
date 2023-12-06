Imports System.Data.SqlClient
Imports CapaEntidad
Public Class MetodosCategorias
    Dim conexObj As New Conex
    Dim conex As SqlConnection
    Dim adapter As SqlDataAdapter

    Public Function consultarCategorias() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarCategorias", conex)
            adapter.Fill(data, "SUBE")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function listarNombreCategorias() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarNombreCategorias", conex)
            adapter.Fill(data, "ListaNombres")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function buscarIdCategoriasPorNombre(ByVal Concepto As String) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("BuscarCategoriasNombre", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                adapter.SelectCommand.Parameters.Add("@Concepto", SqlDbType.VarChar).Value = Concepto
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListaIdCategorias")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Ocurrio un error" & Err.Description)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Function

    Public Sub registrarCategorias(ByVal Concepto As String, ByVal Descripcion As String)
        Try
            conex = conexObj.link
            adapter = New SqlDataAdapter("RegistrarCategoria", conex)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure

            adapter.SelectCommand.Parameters.Add("@Concepto", SqlDbType.VarChar).Value = Concepto
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

    Public Shared Function listarCategorias() As DataTable
        Using conex As New SqlConnection(My.Settings.Conexion)
            Using Adapter As New SqlDataAdapter("ListarCategorias", conex)
                Using Tabla As New DataTable
                    Adapter.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using
    End Function
End Class
