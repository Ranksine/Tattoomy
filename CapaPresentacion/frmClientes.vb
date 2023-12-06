Imports CapaEntidad
Imports CapaNegocio
Public Class frmClientes
    Dim capaNegociosClientes As New NegociosClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TattoomyDBDataSet2.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.TattoomyDBDataSet2.Cliente)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Enabled = True
        txtApellidos.Enabled = True
        txtDomicilio.Enabled = True
        txtColonia.Enabled = True
        txtCiudad.Enabled = True
        txtCiudad.Enabled = True
        txtCP.Enabled = True
        txtTelefono.Enabled = True
        txtCelular.Enabled = True
        txtEmail.Enabled = True
        txtStrikes.Enabled = True

        btnGuardar.Enabled = True
        btnNuevo.Enabled = False

        txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        capaNegociosClientes.registrarClientes(txtNombre.Text, txtApellidos.Text, txtDomicilio.Text, txtColonia.Text, txtCiudad.Text,
                                               txtCP.Text, txtTelefono.Text, txtCelular.Text, txtEmail.Text, txtStrikes.Text)
        dgClientes.DataSource = capaNegociosClientes.mostrarClientes.Tables("LISTA")
        dgClientes.Update()

        txtNombre.Enabled = False
        txtApellidos.Enabled = False
        txtDomicilio.Enabled = False
        txtColonia.Enabled = False
        txtCiudad.Enabled = False
        txtCiudad.Enabled = False
        txtCP.Enabled = False
        txtTelefono.Enabled = False
        txtCelular.Enabled = False
        txtEmail.Enabled = False
        txtStrikes.Enabled = False

        txtNombre.Clear()
        txtApellidos.Clear()
        txtDomicilio.Clear()
        txtColonia.Clear()
        txtCiudad.Clear()
        txtCiudad.Clear()
        txtCP.Clear()
        txtTelefono.Clear()
        txtCelular.Clear()
        txtEmail.Clear()
        txtStrikes.Clear()

        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        btnNuevo.Focus()
    End Sub

    Private Sub btnActivarModif_Click(sender As Object, e As EventArgs) Handles btnActivarModif.Click
        btnActivarModif.Visible = False
        btnModificar.Visible = True

        dgClientes.ReadOnly = False
        MsgBox("Modificación activada")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        SqlDataAdapter1.Update(TattoomyDBDataSet2.Cliente)
        TattoomyDBDataSet2.Clear()
        SqlDataAdapter1.Fill(TattoomyDBDataSet2.Cliente)

        MsgBox("Modificacion realizada")

        btnModificar.Visible = False
        btnActivarModif.Visible = True
        dgClientes.ReadOnly = True
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf & e.Row.Item("Nombre", DataRowVersion.Original) & vbCrLf & e.Row.Item("Nombre", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        ClienteBindingSource.MoveFirst()
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        ClienteBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        ClienteBindingSource.MovePrevious()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ClienteBindingSource.MoveLast()
    End Sub
End Class