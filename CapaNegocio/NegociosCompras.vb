Imports CapaDatos
Imports CapaEntidad
Public Class NegociosCompras
    Dim compra As New MetodosCompras

    Public Function consultaCompras() As DataSet
        Return compra.consultaCompras
    End Function
    Public Function consultaComprasRango(ByVal fechaIni As String, ByVal fechaFin As String) As DataSet
        Return compra.listarComprasRango(fechaIni, fechaFin)
    End Function

    Public Function consultaComprasProv(ByVal prov As String) As DataSet
        Return compra.listarComprasProv(prov)
    End Function
End Class
