Public Class Blacklist
    Private _IdCliente As Integer
    Private _IdTatuador As Integer
    Private _FechaIngreso As String
    Private _Motivo As String

    Public Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
        Set(value As Integer)
            _IdCliente = value
        End Set
    End Property

    Public Property IdTatuador As Integer
        Get
            Return _IdTatuador
        End Get
        Set(value As Integer)
            _IdTatuador = value
        End Set
    End Property

    Public Property FechaIngreso As String
        Get
            Return _FechaIngreso
        End Get
        Set(value As String)
            _FechaIngreso = value
        End Set
    End Property

    Public Property Motivo As String
        Get
            Return _Motivo
        End Get
        Set(value As String)
            _Motivo = value
        End Set
    End Property
End Class
