Imports CapaNegocio
Imports CapaEntidad
Public Class frmConsVentas_Rango
    Dim capaNegocios As New NegociosVentas
    Private Sub frmConsVentas_Rango_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgConsVentas.DataSource = capaNegocios.mostrarVentas.Tables("LISTA")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim fecha1, fecha2 As String
        fecha1 = dtFechaInicio.Value.Year & "/" & dtFechaInicio.Value.Month & "/" & dtFechaInicio.Value.Day
        fecha2 = dtFechaFin.Value.Year & "/" & dtFechaFin.Value.Month & "/" & dtFechaFin.Value.Day
        MsgBox(fecha1)
        MsgBox(fecha2)
        dgConsVentas.DataSource = capaNegocios.mostrarVentasRango(fecha1, fecha2).Tables("ListaRango")
    End Sub
End Class