Imports CapaNegocio
Imports CapaEntidad
Public Class frmBlacklist
    Dim capaNegocioLista As New NegociosBlacklist
    Dim capaNegocioCliente As New NegociosClientes
    Dim capaNegocioTatuador As New NegociosTatuadores
    Private Sub frmBlacklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgLista.DataSource = capaNegocioLista.consultarlista.Tables("LISTA")

        cboCliente.DataSource = capaNegocioCliente.mostrarNombreClientes.Tables("ListaNombres")
        cboCliente.DisplayMember = "Nombre"

        cboTatuador.DataSource = capaNegocioTatuador.mostrarNombreTatuadores.Tables("ListaNombres")
        cboTatuador.DisplayMember = "Nombre"
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboCliente.Enabled = True
        cboTatuador.Enabled = True
        dtFecha.Enabled = True
        dgLista.Enabled = True
        txtMotivo.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idCliente, idTatuador As Integer
        dgCliente.DataSource = capaNegocioCliente.buscarIdCliente(cboCliente.Text).Tables("ListarIdCliente")
        idCliente = dgCliente.Item(0, 0).Value
        'MsgBox(idCliente)

        dgTatuador.DataSource = capaNegocioTatuador.buscarIdTatuador(cboTatuador.Text).Tables("ListarIdTatuador")
        idTatuador = dgTatuador.Item(0, 0).Value
        'MsgBox(idTatuador)

        Dim fecha As String
        fecha = dtFecha.Value.Year & "/" & dtFecha.Value.Month & "/" & dtFecha.Value.Day
        capaNegocioLista.registrarALista(idCliente, idTatuador, fecha, txtMotivo.Text, cboCliente.Text)
        dgLista.DataSource = capaNegocioLista.consultarlista.Tables("LISTA")

        txtMotivo.Clear()

        cboCliente.Enabled = False
        cboTatuador.Enabled = False
        dtFecha.Enabled = False
        txtMotivo.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        frmMnu_ConsBlacklist.Show()
    End Sub
End Class