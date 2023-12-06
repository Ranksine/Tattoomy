Imports CapaDatos
Imports CapaEntidad
Public Class NegociosInsumos
    Dim Insumo As New MetodosInsumos

    Public Function mostrarInsumos() As DataSet
        Return Insumo.consultarInsumos
    End Function

    Public Sub registrarInsumos(ByVal Nombre As String, ByVal Descripcion As String, ByVal IdMarca As Integer,
                                ByVal IdCategorias As Integer, ByVal Costo As String, ByVal Precio As String,
                                ByVal Existencia As Integer, ByVal Max As Integer, ByVal Min As Integer)
        Insumo.registrarInsumo(Nombre, Descripcion, IdMarca, IdCategorias, Costo, Precio, Existencia, Max, Min)
    End Sub
End Class
