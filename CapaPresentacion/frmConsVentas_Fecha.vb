Imports CapaNegocio
Imports CapaEntidad
Public Class frmConsVentas_Fecha
    Dim capaNegocios As New NegociosVentas
    Private Sub frmConsVentas_Fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgConsVentas.DataSource = capaNegocios.mostrarVentas.Tables("LISTA")
    End Sub

    Private Sub dtFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtFecha.ValueChanged
        Dim fecha As String
        fecha = dtFecha.Value.Year & "/" & dtFecha.Value.Month & "/" & dtFecha.Value.Day
        dgConsVentas.DataSource = capaNegocios.mostrarVentasFecha(fecha).Tables("ListaFecha")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub
End Class