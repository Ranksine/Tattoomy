Public Class Compras
    Private _IdProveedor As Integer
    Private _FechaCompra As String
    Private _Total

    Public Property IdProveedor As Integer
        Get
            Return _IdProveedor
        End Get
        Set(value As Integer)
            _IdProveedor = value
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

    Public Property Total As Object
        Get
            Return _Total
        End Get
        Set(value As Object)
            _Total = value
        End Set
    End Property
End Class
