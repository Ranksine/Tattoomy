Imports CapaDatos
Imports CapaEntidad
Public Class NegociosClientes
    Dim Cliente As New MetodosClientes

    Public Function mostrarClientes() As DataSet
        Return Cliente.consultarClientes
    End Function

    Public Function mostrarNombreClientes() As DataSet
        Return Cliente.consultarNombreClientes
    End Function

    Public Function buscarIdCliente(ByVal Nombre As String) As DataSet
        Return Cliente.buscarIdPorNombreClientes(Nombre)
    End Function

    Public Sub registrarClientes(ByVal Nombre As String, ByVal Apellidos As String, ByVal Domicilio As String,
                                 ByVal Colonia As String, ByVal Ciudad As String, ByVal CP As String,
                                 ByVal Telefono As String, ByVal Celular As String, ByVal Email As String,
                                 ByVal Strikes As Integer)
        Cliente.registrarClientes(Nombre, Apellidos, Domicilio, Colonia, Ciudad, CP, Telefono, Celular, Email, Strikes)
    End Sub
End Class
