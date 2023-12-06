Imports CapaNegocio
Imports CapaEntidad
Public Class frmConsCompras_Rango
    Dim capaNegocio As New NegociosCompras

    Private Sub frmConsCompras_Rango_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgConsFechas.DataSource = capaNegocio.consultaCompras.Tables("ListaNormal")
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim fecha1, fecha2 As String

        fecha1 = dtFechaInicio.Value.Year & "/" & dtFechaInicio.Value.Month & "/" & dtFechaInicio.Value.Day
        fecha2 = dtFechaFin.Value.Year & "/" & dtFechaFin.Value.Month & "/" & dtFechaFin.Value.Day
        dgConsFechas.DataSource = capaNegocio.consultaComprasRango(fecha1, fecha2).Tables("ListaRango")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

End Class