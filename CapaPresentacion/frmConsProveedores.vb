Imports CapaNegocio
Imports CapaEntidad
Public Class frmConsProveedores
    Dim CapaNegocio As New NegociosProveedores
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub frmConsProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgProveedores.DataSource = CapaNegocio.mostrarProveedores.Tables("LISTA")
    End Sub

    Private Sub txtProveedores_TextChanged(sender As Object, e As EventArgs) Handles txtProveedores.TextChanged
        If cboProveedores.SelectedItem.Equals("Nombre") Then
            Dim vista As New DataView(CapaDatos.MetodosProveedores.listarProveedor)
            vista.RowFilter = "Nombre LIKE '" & txtProveedores.Text & "%'"
            dgProveedores.DataSource = vista
        End If
    End Sub

    Private Sub cboProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedores.SelectedIndexChanged
        If cboProveedores.SelectedItem.Equals("IdProveedores") Then
            txtProveedores.Enabled = True
            btnConsultar.Enabled = True
            txtProveedores.Clear()
        Else
            btnConsultar.Enabled = False
            txtProveedores.Enabled = True
            txtProveedores.Clear()
        End If
    End Sub
End Class