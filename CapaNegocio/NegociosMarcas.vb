Imports CapaDatos
Imports CapaEntidad
Public Class NegociosMarcas
    Dim marca As New MetodosMarcas
    Public Function mostrarMarca() As DataSet
        Return marca.consultarMarcas
    End Function
    Public Function listarNombresMarcas() As DataSet
        Return marca.listarNombres
    End Function

    Public Function BuscarIdMarca(ByVal Nombre) As DataSet
        Return marca.buscarIdMarcaPorNombre(Nombre)
    End Function

    Public Sub registrarMarca(ByVal Nombre As String, ByVal Descripcion As String)
        marca.registrarMarcas(Nombre, Descripcion)
    End Sub

    Public Function buscarNombreMarca(ByVal Nombre As String)
        Return marca.BuscarNombreMarcas(Nombre)
    End Function
End Class
