Imports CapaNegocio
Imports CapaEntidad
Public Class frmMarcas
    Dim capaNegocio As New NegociosMarcas
    Private Sub frmMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgMarcas.DataSource = capaNegocio.mostrarMarca.Tables("CONS_MARCA")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Enabled = True
        txtDescripcion.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        capaNegocio.registrarMarca(txtNombre.Text, txtDescripcion.Text)
        dgMarcas.DataSource = capaNegocio.mostrarMarca.Tables("CONS_MARCA")

        txtNombre.Clear()
        txtDescripcion.Clear()
        txtNombre.Enabled = False
        txtDescripcion.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        frmConsMarcas.Show()
    End Sub

End Class