Imports CapaNegocio
Imports CapaEntidad
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmVentas
    Dim capaNegocio As New NegociosVentas
    Dim com As SqlCommand
    Dim lector As SqlDataReader
    Dim conex As New SqlConnection
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conex.ConnectionString = "Server =.;Database=TattoomyDB; Integrated Security=SSPI"
        conex.Open()
        com = conex.CreateCommand
        cargarInsumos()
    End Sub

    Private Function cargarInsumos()
        If cboProducto.Items.Count() > 0 Then
            cboProducto.Text = ""
            cboProducto.Items.Clear()
        End If
        com.CommandText = "SELECT * FROM Insumos"
        lector = com.ExecuteReader
        While lector.Read
            cboProducto.Items.Add(lector(1))
        End While
        lector.Close()
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        com.CommandText = "SELECT COUNT(*) FROM Ventas"
        lector = com.ExecuteReader
        lector.Read()
        Dim id As Integer
        id = lector(0) + 1
        lector.Close()
        If id = 1 Then
            txtIdVenta.Text = id
        Else
            If id > 1 Then
                com.CommandText = "SELECT IdVenta FROM Ventas"
                lector = com.ExecuteReader
                lector.Read()
                txtIdVenta.Text = lector(0) + 1
                lector.Close()
            End If
        End If

        dtFechaVenta.Enabled = True
        cboProducto.Enabled = True
        txtCantidad.Enabled = True
        btnAgregar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        com.CommandText = "SELECT IdInsumos, Precio FROM Insumos WHERE Nombre = '" & cboProducto.Text & "'"
        lector = com.ExecuteReader
        lector.Read()
        txtIdProd.Text = lector(0)
        txtPrecio.Text = lector(1)
        lector.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim importe, total As Double
        If txtCantidad.Text.Equals("") Then
            MessageBox.Show("Por favor agrega la cantidad que deseas comprar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            importe = CDbl(txtPrecio.Text) * Val(txtCantidad.Text)
            dgVentas.Rows.Add(txtIdProd.Text, cboProducto.Text, txtPrecio.Text, txtCantidad.Text, importe)
            For x = 0 To dgVentas.RowCount() - 2
                total += dgVentas.Item(4, x).Value
            Next
            txtTotal.Text = total

            cargarInsumos()
            txtIdProd.Clear()
            txtCantidad.Clear()
            txtPrecio.Clear()

            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fecha As String
        fecha = dtFechaVenta.Value.Year & "/" & dtFechaVenta.Value.Month & "/" & dtFechaVenta.Value.Day
        If dgVentas.RowCount() - 1 > 0 Then
            MsgBox("Fecha: " & fecha & " Total: " & CDbl(txtTotal.Text))
            capaNegocio.agregarVentas(fecha, CDbl(txtTotal.Text))

            For x = 0 To dgVentas.RowCount() - 2
                capaNegocio.agregarDetVentas(txtIdVenta.Text, dgVentas.Item(0, x).Value, dgVentas.Item(3, x).Value, dgVentas.Item(2, x).Value)
            Next

            MessageBox.Show("Compra registrada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            dgVentas.Rows.Clear()
            cargarInsumos()
            txtIdProd.Clear()
            txtCantidad.Clear()
            txtPrecio.Clear()
            txtTotal.Clear()
            txtIdVenta.Clear()
            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnAgregar.Enabled = False
            dtFechaVenta.Enabled = False
            cboProducto.Enabled = False
            txtCantidad.Enabled = False
        Else
            MsgBox("Agrega articulos para poder realizar la venta")
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        frmMnu_ConsVentas.Show()
    End Sub
End Class