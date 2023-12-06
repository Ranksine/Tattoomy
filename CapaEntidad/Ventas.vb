Public Class Ventas
    Private _FechaVenta As String
    Private _Total As Double

    Public Property FechaVenta As String
        Get
            Return _FechaVenta
        End Get
        Set(value As String)
            _FechaVenta = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _Total
        End Get
        Set(value As Double)
            _Total = value
        End Set
    End Property
End Class
