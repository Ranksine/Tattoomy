Imports CapaNegocio
Imports CapaEntidad
Public Class frmConsCompras_Proveedor
    Dim capaNegocio As New NegociosCompras
    Dim capaNegocioProv As New NegociosProveedores
    Private Sub frmConsCompras_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandler cboProv.SelectedIndexChanged, AddressOf cboProv_SelectedIndexChanged

        dgConsCompras.DataSource = capaNegocio.consultaCompras.Tables("ListaNormal")
        cboProv.DataSource = capaNegocioProv.mostrarProveedores.Tables("LISTA")
        cboProv.DisplayMember = "Nombre"
        cboProv.ValueMember = "IdProveedor"
        AddHandler cboProv.SelectedIndexChanged, AddressOf cboProv_SelectedIndexChanged
    End Sub

    Private Sub cboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProv.SelectedIndexChanged
        Dim idP As Integer
        idP = Val(cboProv.SelectedValue)
        'MsgBox("Proveedor: " & cboProv.Text & " ID: " & idP)
        dgConsCompras.DataSource = capaNegocio.consultaComprasProv(idP).Tables("ListaCompraProv")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub
End Class