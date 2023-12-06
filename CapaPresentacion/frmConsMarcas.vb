Imports CapaEntidad
Imports CapaNegocio
Public Class frmConsMarcas
    Dim capaNegocio As New NegociosMarcas
    Private Sub frmConsMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgConsMarca.DataSource = capaNegocio.mostrarMarca.Tables("CONS_MARCA")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub cboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarca.SelectedIndexChanged
        Select Case (cboMarca.SelectedItem)
            Case "Consulta por nombre"
                txtConsMarca.Visible = False
                cboConsMarca.Visible = True
                cboConsMarca.Enabled = True
                txtConsMarca.Enabled = False
                'cboConsMarca.Items.Add(capaNegocio.listarNombresMarcas.Tables("LIST_NOMBRES"))
                For x = 0 To dgConsMarca.RowCount() - 2
                    cboConsMarca.Items.Add(dgConsMarca.Item(1, x).Value)
                Next
            Case "Busqueda manual"
                txtConsMarca.Visible = True
                cboConsMarca.Visible = False
                btnBuscar.Enabled = True
                txtConsMarca.Enabled = True
                cboConsMarca.Enabled = False
        End Select
    End Sub

    Private Sub cboConsMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConsMarca.SelectedIndexChanged
        dgConsMarca.DataSource = capaNegocio.buscarNombreMarca(cboConsMarca.SelectedItem).Tables("CONS_MARCA_NOMBRE")
    End Sub
End Class