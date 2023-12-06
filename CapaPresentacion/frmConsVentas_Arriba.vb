Imports CapaNegocio
Imports CapaEntidad
Public Class frmConsVentas_Arriba
    Dim capaNegocios As New NegociosVentas
    Private Sub frmConsVentas_Arriba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgConsVentas.DataSource = capaNegocios.mostrarVentas.Tables("LISTA")
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        dgConsVentas.DataSource = capaNegocios.mostrarVentasArriba(txtCantidad.Text).Tables("ListaArriba")
        dgConsVentas.Sort(dgConsVentas.Columns(2), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub
End Class