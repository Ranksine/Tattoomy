Imports CapaDatos
Imports CapaEntidad
Public Class InsertarCategoria
    Dim Categoria As New MetodosCategorias

    Public Function mostrarCategorias() As DataSet
        Return Categoria.consultarCategorias
    End Function

    Public Function listarNombreCategorias() As DataSet
        Return Categoria.listarNombreCategorias
    End Function

    Public Function buscarIdCategoriasPorNombre(ByVal Concepto As String) As DataSet
        Return Categoria.buscarIdCategoriasPorNombre(Concepto)
    End Function
    Public Sub AgregarCategoria(ByVal Concepto As String, ByVal Descripcion As String)
        Categoria.registrarCategorias(Concepto, Descripcion)
    End Sub

End Class
