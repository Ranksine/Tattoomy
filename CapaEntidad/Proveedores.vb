Public Class Proveedores
    Private _Nombre As String
    Private _Domicilio As String
    Private _Colonia As String
    Private _Ciudad As String
    Private _CP As String
    Private _Telefono As String
    Private _Celular As String
    Private _Representante As String
    Private _Email As String
    Private _Pais As String

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _Domicilio
        End Get
        Set(value As String)
            _Domicilio = value
        End Set
    End Property

    Public Property Colonia As String
        Get
            Return _Colonia
        End Get
        Set(value As String)
            _Colonia = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(value As String)
            _Ciudad = value
        End Set
    End Property

    Public Property CP As String
        Get
            Return _CP
        End Get
        Set(value As String)
            _CP = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Celular As String
        Get
            Return _Celular
        End Get
        Set(value As String)
            _Celular = value
        End Set
    End Property

    Public Property Representante As String
        Get
            Return _Representante
        End Get
        Set(value As String)
            _Representante = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Pais As String
        Get
            Return _Pais
        End Get
        Set(value As String)
            _Pais = value
        End Set
    End Property
End Class
