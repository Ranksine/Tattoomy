Imports CapaNegocio
Imports CapaEntidad
Public Class frmProveedores
    Dim CapaNegocio As New NegociosProveedores
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgProveedores.DataSource = CapaNegocio.mostrarProveedores.Tables("LISTA")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtColonia.Enabled = True
        txtCiudad.Enabled = True
        txtCP.Enabled = True
        txtTelefono.Enabled = True
        txtCelular.Enabled = True
        txtRepresentante.Enabled = True
        txtEmail.Enabled = True
        cboPais.Enabled = True
        btnRegistrar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        CapaNegocio.registrarProveedores(txtNombre.Text, txtDomicilio.Text, txtColonia.Text, txtCiudad.Text, txtCP.Text, txtTelefono.Text,
                                         txtCelular.Text, txtRepresentante.Text, txtEmail.Text, cboPais.Text)
        dgProveedores.DataSource = CapaNegocio.mostrarProveedores.Tables("LISTA")

        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtColonia.Enabled = False
        txtCiudad.Enabled = False
        txtCP.Enabled = False
        txtTelefono.Enabled = False
        txtCelular.Enabled = False
        txtRepresentante.Enabled = False
        txtEmail.Enabled = False
        cboPais.Enabled = False
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True

        txtNombre.Clear()
        txtDomicilio.Clear()
        txtColonia.Clear()
        txtCiudad.Clear()
        txtCP.Clear()
        txtTelefono.Clear()
        txtCelular.Clear()
        txtRepresentante.Clear()
        txtEmail.Clear()

    End Sub

    Private Sub btnCosultar_Click(sender As Object, e As EventArgs) Handles btnCosultar.Click
        frmConsProveedores.Show()
    End Sub
End Class