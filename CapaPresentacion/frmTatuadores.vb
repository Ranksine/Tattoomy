Imports CapaEntidad
Imports CapaNegocio
Public Class frmTatuadores
    Dim capaNegociosTatuadores As New NegociosTatuadores
    Private Sub frmTatuadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TattoomyDBDataSet1.Tatuador' Puede moverla o quitarla según sea necesario.
        Me.TatuadorTableAdapter.Fill(Me.TattoomyDBDataSet1.Tatuador)

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
        txtCP.Enabled = True
        txtTelefono.Enabled = True
        txtCelular.Enabled = True
        txtEmail.Enabled = True
        txtInstagram.Enabled = True
        txtFacebook.Enabled = True
        txtEstilo.Enabled = True

        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        capaNegociosTatuadores.registrarTatuador(txtNombre.Text, txtApellidos.Text, txtDomicilio.Text, txtColonia.Text, txtCiudad.Text, txtCP.Text, txtTelefono.Text, txtCelular.Text, txtEmail.Text, txtInstagram.Text, txtFacebook.Text, txtEstilo.Text)
        dgTatuadores.DataSource = capaNegociosTatuadores.mostrarTatuadores.Tables("LISTA")
        MsgBox("Se ha registrado correctamente a " & txtNombre.Text & " como nuevo tatuador")
        dgTatuadores.Update()

        txtNombre.Enabled = False
        txtApellidos.Enabled = False
        txtDomicilio.Enabled = False
        txtColonia.Enabled = False
        txtCiudad.Enabled = False
        txtCP.Enabled = False
        txtTelefono.Enabled = False
        txtCelular.Enabled = False
        txtEmail.Enabled = False
        txtInstagram.Enabled = False
        txtFacebook.Enabled = False
        txtEstilo.Enabled = False

        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnActivarModif_Click(sender As Object, e As EventArgs) Handles btnActivarModif.Click
        btnActivarModif.Visible = False
        btnModificar.Visible = True
        dgTatuadores.ReadOnly = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        SqlDataAdapter1.Update(TattoomyDBDataSet1.Tatuador)
        TattoomyDBDataSet1.Clear()
        SqlDataAdapter1.Fill(TattoomyDBDataSet1.Tatuador)

        btnModificar.Visible = False
        btnActivarModif.Visible = True
        dgTatuadores.ReadOnly = True
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf & e.Row.Item("Nombre", DataRowVersion.Original) & vbCrLf & e.Row.Item("Nombre", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        TatuadorBindingSource.MoveFirst()
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        TatuadorBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TatuadorBindingSource.MovePrevious()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        TatuadorBindingSource.MoveLast()
    End Sub
End Class