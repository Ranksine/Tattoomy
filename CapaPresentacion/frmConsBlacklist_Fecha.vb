Imports CapaNegocio
Imports CapaEntidad
Public Class frmConsBlacklist_Fecha
    Dim capaNegocios As New NegociosBlacklist
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub frmConsBlacklist_Fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgConsLista.DataSource = capaNegocios.consultarlista.Tables("LISTA")
    End Sub

    Private Sub dtFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtFecha.ValueChanged
        Dim fecha As String
        fecha = dtFecha.Value.Year & "/" & dtFecha.Value.Month & "/" & dtFecha.Value.Day

        dgConsLista.DataSource = capaNegocios.consultaListaFecha(fecha).Tables("ListaFecha")
    End Sub
End Class