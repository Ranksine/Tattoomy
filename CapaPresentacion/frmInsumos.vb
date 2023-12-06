Imports CapaNegocio
Imports CapaEntidad
Public Class frmInsumos
    Dim CapaNegocioInsumo As New NegociosInsumos
    Dim CapaNegocioCat As New InsertarCategoria
    Dim CapaNegocioMar As New NegociosMarcas
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub frmInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TattoomyDBDataSet.Insumos' Puede moverla o quitarla según sea necesario.
        Me.InsumosTableAdapter.Fill(Me.TattoomyDBDataSet.Insumos)
        cboCategoria.DataSource = CapaNegocioCat.listarNombreCategorias.Tables("ListaNombres")
        cboCategoria.DisplayMember = "Concepto"

        cboMarca.DataSource = CapaNegocioMar.listarNombresMarcas.Tables("LIST_NOMBRES")
        cboMarca.DisplayMember = "Nombre"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtNombre.Enabled = True
        txtDescipcion.Enabled = True
        cboCategoria.Enabled = True
        cboMarca.Enabled = True
        txtExistencia.Enabled = True
        txtCosto.Enabled = True
        txtPrecio.Enabled = True
        txtMax.Enabled = True
        txtMin.Enabled = True
        dtFechaCompra.Enabled = True

        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        dgInvisibleCat.DataSource = CapaNegocioCat.buscarIdCategoriasPorNombre(cboCategoria.Text).Tables("ListaIdCategorias")
        Dim idCategoria, IdM As String
        idCategoria = dgInvisibleCat.Item(0, 0).Value
        'MsgBox(idCategoria)

        dgInvisibleMarca.DataSource = CapaNegocioMar.BuscarIdMarca(cboMarca.Text).Tables("ListaIdMarca")
        IdM = dgInvisibleMarca.Item(0, 0).Value
        'MsgBox(IdM)

        CapaNegocioInsumo.registrarInsumos(txtNombre.Text, txtDescipcion.Text, IdM, idCategoria, txtCosto.Text, txtPrecio.Text, txtExistencia.Text, txtMax.Text, txtMin.Text)
        dgInsumos.DataSource = CapaNegocioInsumo.mostrarInsumos.Tables("LISTA")
        MsgBox(txtNombre.Text & "se ha guardado correctamente")
        txtNombre.Clear()
        txtDescipcion.Clear()
        txtCosto.Clear()
        txtPrecio.Clear()
        txtExistencia.Clear()
        txtMax.Clear()
        txtMin.Clear()

        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        txtNombre.Enabled = False
        txtDescipcion.Enabled = False
        txtCosto.Enabled = False
        txtPrecio.Enabled = False
        txtExistencia.Enabled = False
        txtMax.Enabled = False
        txtMin.Enabled = False
        dgInsumos.Update()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        SqlDataAdapter1.Update(TattoomyDBDataSet.Insumos)
        TattoomyDBDataSet.Clear()
        SqlDataAdapter1.Fill(TattoomyDBDataSet.Insumos)

        btnModificar.Visible = False
        btnActivarModif.Visible = True
        dgInsumos.ReadOnly = True
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated

        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf & e.Row.Item("Nombre", DataRowVersion.Original) & vbCrLf & e.Row.Item("Nombre", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub btnActivarModif_Click(sender As Object, e As EventArgs) Handles btnActivarModif.Click
        btnActivarModif.Visible = False
        btnModificar.Visible = True
        dgInsumos.ReadOnly = False

        MsgBox("Ahora puede modificar la tabla :3")
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        InsumosBindingSource.MoveFirst()
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        InsumosBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        InsumosBindingSource.MovePrevious()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        InsumosBindingSource.MoveLast()
    End Sub
End Class