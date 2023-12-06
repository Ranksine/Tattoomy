Imports System.Data.SqlClient
Imports CapaEntidad
Public Class MetodosProveedores
    Dim conexObj As New Conex
    Dim conex As SqlConnection
    Dim adapter As SqlDataAdapter

    Public Function consultarProveedores() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarProveedores", conex)
            adapter.Fill(data, "LISTA")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Sub registrarProveedores(ByVal Nombre As String, ByVal Domicilio As String, ByVal Colonia As String, ByVal Ciudad As String,
                                   ByVal CP As String, ByVal Telefono As String, ByVal Celular As String, ByVal Representante As String,
                                   ByVal Email As String, ByVal Pais As String)
        Try
            conex = conexObj.link
            adapter = New SqlDataAdapter("RegistrarProveedores", conex)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
            adapter.SelectCommand.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = Domicilio
            adapter.SelectCommand.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = Colonia
            adapter.SelectCommand.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = Ciudad
            adapter.SelectCommand.Parameters.Add("@CP", SqlDbType.VarChar).Value = CP
            adapter.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Telefono
            adapter.SelectCommand.Parameters.Add("@Celular", SqlDbType.VarChar).Value = Celular
            adapter.SelectCommand.Parameters.Add("@Representante", SqlDbType.VarChar).Value = Representante
            adapter.SelectCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email
            adapter.SelectCommand.Parameters.Add("@Pais", SqlDbType.VarChar).Value = Pais
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

    Public Shared Function listarProveedor() As DataTable
        Using conex As New SqlConnection(My.Settings.Conexion)
            Using Adapter As New SqlDataAdapter("ListarProveedores", conex)
                Using Tabla As New DataTable
                    Adapter.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using
    End Function
End Class
