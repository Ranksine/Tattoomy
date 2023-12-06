Imports CapaDatos
Public Class NegociosBlacklist
    Dim Blacklist As New MetodosBlacklist

    Public Function consultarlista() As DataSet
        Return Blacklist.consultarLista
    End Function

    Public Function consultaListaFecha(ByVal fecha As String) As DataSet
        Return Blacklist.consultaListaFecha(fecha)
    End Function

    Public Function consultaListaRango(ByVal fecha1 As String, ByVal fecha2 As String) As DataSet
        Return Blacklist.consultaListaRango(fecha1, fecha2)
    End Function

    Public Function consultaListaTatuador(ByVal idTat As Integer) As DataSet
        Return Blacklist.consultaListaTatuador(idTat)
    End Function
    Public Sub registrarALista(ByVal IdCliente As Integer, ByVal IdTatuador As Integer, ByVal FechaIngreso As String, ByVal Motivo As String, ByVal Nombre As String)
        Blacklist.agregarALista(IdCliente, IdTatuador, FechaIngreso, Motivo, Nombre)
    End Sub
End Class
