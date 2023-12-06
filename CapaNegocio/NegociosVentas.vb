Imports CapaDatos
Imports CapaEntidad
Public Class NegociosVentas
    Dim ventas As New MetodosVentas

    Public Function mostrarVentas() As DataSet
        Return ventas.mostrarVentas
    End Function

    Public Function mostrarVentasFecha(ByVal fecha As String) As DataSet
        Return ventas.mostrarVentasFecha(fecha)
    End Function

    Public Function mostrarVentasRango(ByVal fecha1 As String, ByVal fecha2 As String) As DataSet
        Return ventas.mostrarVentasRango(fecha1, fecha2)
    End Function

    Public Function mostrarVentasArriba(ByVal cantidad As Double) As DataSet
        Return ventas.mostrarVentasArriba(cantidad)
    End Function

    Public Function mostrarVentasAbajo(ByVal cantidad As Double) As DataSet
        Return ventas.mostrarVentasAbajo(cantidad)
    End Function

    Public Sub agregarVentas(ByVal fechaVenta As String, ByVal total As Double)
        ventas.agregarVenta(fechaVenta, total)
    End Sub

    Public Sub agregarDetVentas(ByVal idVenta As Integer, ByVal idInsumos As Integer, ByVal cantidad As Integer, ByVal precio As Double)
        ventas.agregarDetVenta(idVenta, idInsumos, cantidad, precio)
    End Sub
End Class
