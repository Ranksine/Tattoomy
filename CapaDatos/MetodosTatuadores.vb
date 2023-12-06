Imports System.Data.SqlClient
Imports CapaEntidad
Public Class MetodosTatuadores
    Dim conexObj As New Conex
    Dim conex As SqlConnection
    Dim adapter As SqlDataAdapter

    Public Function consultarTatuadores() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarTatuadores", conex)
            adapter.Fill(data, "LISTA")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function consultarNombreTatuador() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarNombreTatuadores", conex)
            adapter.Fill(data, "ListaNombres")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function buscarIdPorNombreTatuador(ByVal Nombre As String) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("BuscarIdTatuador", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListarIdTatuador")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Ocurrio un error" & Err.Description)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Function

    Public Sub registrarTatuador(ByVal Nombre As String, ByVal Apellidos As String,
                                 ByVal Domicilio As String, ByVal Colonia As String,
                                 ByVal Ciudad As String, ByVal CP As String, ByVal Telefono As String,
                                 ByVal Celular As String, ByVal Email As String,
                                 ByVal Instagram As String, ByVal Facebook As String,
                                 ByVal Estilo As String)
        Try
            conex = conexObj.link
            adapter = New SqlDataAdapter("RegistrarTatuador", conex)
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
            adapter.SelectCommand.Parameters.Add("@Instagram", SqlDbType.VarChar).Value = Instagram
            adapter.SelectCommand.Parameters.Add("@Facebook", SqlDbType.VarChar).Value = Facebook
            adapter.SelectCommand.Parameters.Add("@Estilo", SqlDbType.VarChar).Value = Estilo

            conex.Open()
            adapter.SelectCommand.ExecuteNonQuery()
            conex.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error" & Err.Description)
        Finally
            adapter.Dispose()
        End Try
    End Sub
End Class
