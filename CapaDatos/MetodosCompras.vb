Imports System.Data.SqlClient
Imports CapaEntidad
Public Class MetodosCompras
    Dim conexObj As New Conex
    Dim conex As SqlConnection
    Dim adapter As SqlDataAdapter

    Public Function consultaCompras() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarCompras", conex)
            adapter.Fill(data, "ListaNormal")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function
    Public Function listarComprasRango(ByVal fechaIni As String, ByVal fechaFin As String) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("ListarComprasRango", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                adapter.SelectCommand.Parameters.Add("@FechaIni", SqlDbType.Date).Value = fechaIni
                adapter.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.Date).Value = fechaFin
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListaRango")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Errorsini: " & ex.Message)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Function

    Public Function listarComprasProv(ByVal Proovedor As String)
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("ListasComprasProveedor", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                adapter.SelectCommand.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = Proovedor
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListaCompraProv")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Errorsini: " & ex.Message)
        End Try
    End Function
End Class
