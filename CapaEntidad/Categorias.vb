Public Class Categorias

    Private _Concepto As String
    Private _Descripcion As String

    'Definir todos los campos
    'Para abreviar, seleccionar con control r y control e
    Public Property Concepto As String
        Get
            Return _Concepto
        End Get
        Set(value As String)
            _Concepto = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
End Class
