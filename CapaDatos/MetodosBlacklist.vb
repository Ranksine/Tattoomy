Imports System.Data.SqlClient
Public Class MetodosBlacklist
    Dim conexObj As New Conex
    Dim conex As SqlConnection
    Dim adapter As SqlDataAdapter

    Public Function consultarLista() As DataSet
        Using data As New DataSet
            conex = conexObj.link
            adapter = New SqlDataAdapter("ListarBlacklist", conex)
            adapter.Fill(data, "LISTA")
            Return data
        End Using
        adapter.Dispose()
        conex.Close()
    End Function

    Public Function consultaListaFecha(ByVal fecha As String) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("ListarBlacklistFecha", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListaFecha")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Errorsini: " & ex.Message)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Function

    Public Function consultaListaRango(ByVal fecha1 As String, ByVal fecha2 As String) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("ListarBlacklistRango", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.Add("@FechaIni", SqlDbType.Date).Value = fecha1
                adapter.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.Date).Value = fecha2

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

    Public Function consultaListaTatuador(ByVal idTat As Integer) As DataSet
        Try
            Using data As New DataSet
                conex = conexObj.link
                adapter = New SqlDataAdapter("ListarBlacklistTatuador", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.Add("@IdTatuador", SqlDbType.Int).Value = idTat

                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                adapter.Fill(data, "ListaTatuador")
                Return data
            End Using
        Catch ex As Exception
            MsgBox("Errorsini: " & ex.Message)
        Finally
            adapter.Dispose()
            conex.Close()
        End Try
    End Function

    Public Sub agregarALista(ByVal IdCliente As Integer, ByVal IdTatuador As Integer, ByVal FechaIngreso As String, ByVal Motivo As String, ByVal Nombre As String)
        Using sqlConex As New SqlConnection("Data Source=localhost;Initial Catalog=TattoomyDB; Integrated Security=SSPI")
            sqlConex.Open()
            Dim com As SqlCommand = sqlConex.CreateCommand()
            Dim transaccion As SqlTransaction
            transaccion = sqlConex.BeginTransaction("ListarBlacklistVB")
            com.Connection = sqlConex
            com.Transaction = transaccion
            Try
                adapter = New SqlDataAdapter("InsertarBlacklist", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.Add("@IdCliente", SqlDbType.Int).Value = IdCliente
                adapter.SelectCommand.Parameters.Add("@IdTatuador", SqlDbType.Int).Value = IdTatuador
                adapter.SelectCommand.Parameters.Add("@FechaIngreso", SqlDbType.VarChar).Value = FechaIngreso
                adapter.SelectCommand.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = Motivo
                conex.Open()
                adapter.SelectCommand.ExecuteNonQuery()
                conex.Close()

                'If MsgBox("¿Seguro que quieres agregar a " & Nombre & " a la lista negra?", MsgBoxStyle.YesNo, "Registrar") = MsgBoxResult.Yes Then
                transaccion.Commit()
                MsgBox(Nombre & " ha sido ingresado correctamente a la lista negra")
                'Else

                'transaccion.Rollback()
                'MsgBox("Transacción cancelada")
                'End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en la transaccion: " & ex.Message)
                Try
                    transaccion.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error en el error: " & ex2.Message)
                End Try
            Finally
                adapter.Dispose()
                conex.Dispose()
            End Try
        End Using
    End Sub
End Class
