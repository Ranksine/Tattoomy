Imports CapaDatos
Imports CapaEntidad
Public Class NegociosProveedores
    Dim Proveedor As New MetodosProveedores

    Public Function mostrarProveedores() As DataSet
        Return Proveedor.consultarProveedores
    End Function

    Public Sub registrarProveedores(ByVal Nombre As String, ByVal Domicilio As String, ByVal Colonia As String, ByVal Ciudad As String,
                                   ByVal CP As String, ByVal Telefono As String, ByVal Celular As String, ByVal Representante As String,
                                   ByVal Email As String, ByVal Pais As String)
        Proveedor.registrarProveedores(Nombre, Domicilio, Colonia, Ciudad, CP, Telefono, Celular, Representante, Email, Pais)

    End Sub
End Class
