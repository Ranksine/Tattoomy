
Imports System.Data.SqlClient
Imports CapaEntidad
Public Class MetodosClientes
    Dim conexObj As New Conex
    Dim conex As SqlConnection
    Dim adapter As SqlDataAdapter

    Public Function consultarClientes() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarClientes", conex)
            adapter.Fill(data, "LISTA")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function consultarNombreClientes() As DataSet
        Using Data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarNombreClientes", conex)
            adapter.Fill(Data, "ListaNombres")
            Return Data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function buscarIdPorNombreClientes(ByVal Nombre As String) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("BuscarIdCliente", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListarIdCliente")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Ocurrio un error" & Err.Description)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Function

    Public Sub registrarClientes(ByVal Nombre As String, ByVal Apellidos As String, ByVal Domicilio As String,
                                 ByVal Colonia As String, ByVal Ciudad As String, ByVal CP As String,
                                 ByVal Telefono As String, ByVal Celular As String, ByVal Email As String,
                                 ByVal Strikes As Integer)
        Try
            conex = conexObj.link
            adapter = New SqlDataAdapter("RegistrarCliente", conex)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
            adapter.SelectCommand.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = Apellidos
            adapter.SelectCommand.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = Domicilio
            adapter.SelectCommand.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = Colonia
            adapter.SelectCommand.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = Ciudad
            adapter.SelectCommand.Parameters.Add("@CP", SqlDbType.VarChar).Value = CP
            adapter.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Telefono
            adapter.SelectCommand.Parameters.Add("@Celular", SqlDbType.VarChar).Value = Celular
            adapter.SelectCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email
            adapter.SelectCommand.Parameters.Add("@Strikes", SqlDbType.Int).Value = Strikes
            conex.Open()
            adapter.SelectCommand.ExecuteNonQuery()
            conex.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un errorsini" & Err.Description)
        Finally
            adapter.Dispose()
            conex.Dispose()
        End Try

    End Sub
End Class
