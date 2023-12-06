Imports CapaDatos
Imports CapaEntidad
Public Class NegociosTatuadores
    Dim Tatuador As New MetodosTatuadores

    Public Function mostrarTatuadores() As DataSet
        Return Tatuador.consultarTatuadores
    End Function

    Public Function mostrarNombreTatuadores() As DataSet
        Return Tatuador.consultarNombreTatuador
    End Function

    Public Function buscarIdTatuador(ByVal Nombre As String) As DataSet
        Return Tatuador.buscarIdPorNombreTatuador(Nombre)
    End Function

    Public Sub registrarTatuador(ByVal Nombre As String, ByVal Apellidos As String,
                                 ByVal Domicilio As String, ByVal Colonia As String,
                                 ByVal Ciudad As String, ByVal CP As String, ByVal Telefono As String,
                                 ByVal Celular As String, ByVal Email As String,
                                 ByVal Instagram As String, ByVal Facebook As String,
                                 ByVal Estilo As String)
        Tatuador.registrarTatuador(Nombre, Apellidos, Domicilio, Colonia, Ciudad, CP, Telefono, Celular, Email, Instagram, Facebook, Estilo)
    End Sub
End Class
