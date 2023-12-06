Imports CapaNegocio
Imports CapaEntidad
Public Class frmConsBlacklist_Tatuador
    Dim capaNegocios As New NegociosBlacklist
    Dim negociosTats As New NegociosTatuadores
    Private Sub frmConsBlacklist_Tatuador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgConsCompras.DataSource = capaNegocios.consultarlista.Tables("LISTA")
        RemoveHandler cboTat.SelectedIndexChanged, AddressOf cboTat_SelectedIndexChanged
        cboTat.DataSource = negociosTats.mostrarTatuadores.Tables("LISTA")
        cboTat.DisplayMember = "Nombre"
        cboTat.ValueMember = "IdTatuador"
        AddHandler cboTat.SelectedIndexChanged, AddressOf cboTat_SelectedIndexChanged
    End Sub

    Private Sub cboTat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTat.SelectedIndexChanged
        Dim idT As Integer
        idT = Val(cboTat.SelectedValue)
        'MsgBox("IdTatuador: " & idT)
        dgConsCompras.DataSource = capaNegocios.consultaListaTatuador(idT).Tables("ListaTatuador")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub
End Class