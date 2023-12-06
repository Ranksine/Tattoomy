Public Class Insumos
    Private _Nombre As String
    Private _Descripcion As String
    Private _IdMarca As Integer
    Private _IdCategorias As Integer
    Private _Costo As String
    Private _Precio As String
    Private _FechaCompra As String
    Private _Existencia As Integer
    Private _Max As Integer
    Private _Min As Integer

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
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

    Public Property IdMarca As Integer
        Get
            Return _IdMarca
        End Get
        Set(value As Integer)
            _IdMarca = value
        End Set
    End Property

    Public Property IdCategorias As Integer
        Get
            Return _IdCategorias
        End Get
        Set(value As Integer)
            _IdCategorias = value
        End Set
    End Property

    Public Property Costo As String
        Get
            Return _Costo
        End Get
        Set(value As String)
            _Costo = value
        End Set
    End Property

    Public Property Precio As String
        Get
            Return _Precio
        End Get
        Set(value As String)
            _Precio = value
        End Set
    End Property

    Public Property FechaCompra As String
        Get
            Return _FechaCompra
        End Get
        Set(value As String)
            _FechaCompra = value
        End Set
    End Property

    Public Property Existencia As Integer
        Get
            Return _Existencia
        End Get
        Set(value As Integer)
            _Existencia = value
        End Set
    End Property

    Public Property Max As Integer
        Get
            Return _Max
        End Get
        Set(value As Integer)
            _Max = value
        End Set
    End Property

    Public Property Min As Integer
        Get
            Return _Min
        End Get
        Set(value As Integer)
            _Min = value
        End Set
    End Property
End Class
