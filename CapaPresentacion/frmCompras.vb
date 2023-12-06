Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmCompras
    Dim comando As SqlCommand
    Dim lector As SqlDataReader
    Dim trans As SqlTransaction
    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Server=.;Database=TattoomyDB; Integrated Security=SSPI"
        conexion.Open()

        '---LLENAR COMBO DE PROVEEDORES---'
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT * FROM Proveedores"
        lector = comando.ExecuteReader
        While lector.Read
            cboProveedores.Items.Add(lector(1))
        End While
        lector.Close()

        '---LLENAR COMBO DE CATEGORIAS---'
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT * FROM Categorias"
        lector = comando.ExecuteReader
        While lector.Read
            cboCategoria.Items.Add(lector(1))
        End While
        lector.Close()

        '---LLENAR COMBO DE INSUMOS---'
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT * FROM Insumos"
        lector = comando.ExecuteReader
        While lector.Read
            cboProducto.Items.Add(lector(1))
        End While
        lector.Close()

        '---LLENAR COMBO DE MARCAS---'
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT * FROM Marcas"
        lector = comando.ExecuteReader
        While lector.Read
            cboMarca.Items.Add(lector(1))
        End While
        lector.Close()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Server=.;Database=TattoomyDB; Integrated Security=SSPI"
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT COUNT(*) FROM Compras"
        lector = comando.ExecuteReader
        lector.Read()
        Dim id As Integer
        id = lector(0) + 1
        txtIdCompra.Text = id
        lector.Close()
        '---ACTIVAR CASILLAS---'
        cboProveedores.Enabled = True
        cboCategoria.Enabled = True
        cboProducto.Enabled = True
        cboMarca.Enabled = True
        dtFechaCompra.Enabled = True
        txtCantidad.Enabled = True
        txtCantidad.Enabled = True
        txtPrecio.Enabled = True
        txtCosto.Enabled = True
        btnAgregar.Enabled = True
        txtIdCompra.Enabled = True
        btnNuevo.Enabled = False

        MsgBox("Escribe los datos de la nueva compra")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim total As Double
        Dim importe As Double

        txtIdCompra.Enabled = False

        '---INSERTAR VALORES AL DATAGRID---'
        importe = Val(txtCantidad.Text) * CDbl(txtCosto.Text)
        dgCompras.Rows.Add(txtIdProveedor.Text, cboProveedores.Text, txtIdCat.Text, cboCategoria.Text,
                           txtIdProd.Text, cboProducto.Text, txtIdMarca.Text, cboMarca.Text, txtCantidad.Text, txtPrecio.Text, txtCosto.Text, importe)

        '---CALCULAR TOTAL---'
        For x = 0 To dgCompras.Rows.Count() - 2
            total = total + CDbl(dgCompras.Item(11, x).Value)
        Next

        txtTotal.Text = total

        '---LIMPIAR CASILLAS--'
        btnGuardar.Enabled = True
        txtIdCat.Clear()
        txtIdProd.Clear()
        txtIdMarca.Clear()
        txtCantidad.Clear()
        txtCosto.Clear()
        txtPrecio.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Using conexion As New SqlConnection
            'conexion.ConnectionString = "Data Source=localhost;Initial Catalog=TattoomyDB;User ID=sa; password="
            conexion.ConnectionString = "Server=.;Database=TattoomyDB; Integrated Security=SSPI"
            conexion.Open()
            comando = conexion.CreateCommand

            trans = conexion.BeginTransaction("TransGuardar")

            comando.Connection = conexion
            comando.Transaction = trans

            Dim fecha As String
            fecha = dtFechaCompra.Value.Year & "/" & dtFechaCompra.Value.Month & "/" & dtFechaCompra.Value.Day

            Try
                '-------------INSERTAR REGISTRO EN COMPRAS--------------'
                comando.CommandText = "INSERT INTO Compras(IdCompra,IdProveedor,FechaCompra,Total)
                                    VALUES(" & txtIdCompra.Text & ",'" & txtIdProveedor.Text & "','" & fecha & "'," & txtTotal.Text & ")"
                comando.ExecuteNonQuery()

                '------------INSERTAR REGISTROS EN DETALLE DE COMPRA----'
                For x = 0 To dgCompras.Rows.Count() - 2
                    comando.CommandText = "INSERT INTO DetCompra(IdCompra,IdInsumos,Cantidad,Costo)
                                    VALUES(" & txtIdCompra.Text & "," & dgCompras.Item(4, x).Value & "," & dgCompras.Item(8, x).Value & "," & dgCompras.Item(10, x).Value & ")"
                    comando.ExecuteNonQuery()
                Next

                '------------ACTUALIZAR CANTIDAD Y PRECIO DE LOS PRODUCTOS COMPRADOS-----'
                For x = 0 To dgCompras.Rows.Count() - 2
                    comando.CommandText = "UPDATE Insumos SET Existencia = Existencia + " & dgCompras.Item(8, x).Value & " WHERE IdInsumos = " & dgCompras.Item(4, x).Value
                    comando.ExecuteNonQuery()
                    comando.CommandText = "UPDATE Insumos SET Costo = " & dgCompras.Item(10, x).Value & "WHERE IdInsumos = " & dgCompras.Item(4, x).Value
                    comando.ExecuteNonQuery()
                    'comando.CommandText = "UPDATE Insumos SET Precio = " & dgCompras.Item(9, x).Value & "WHERE IdInsumos = " & dgCompras.Item(4, x).Value
                    'comando.ExecuteNonQuery()
                Next

                '---EJECUTAR TRANSACCION---'
                If MsgBox("¿Seguro que quieres registrar esta compra?", MsgBoxStyle.YesNo, "Registrar") = MsgBoxResult.Yes Then
                    trans.Commit()
                    MsgBox("La compra ha sido registrada correctamente")
                Else
                    trans.Rollback()
                    MsgBox("La compra ha sido cancelada")
                End If
            Catch ex As Exception
                MsgBox("Commint Exception Type: {0} No se pudo insertar por el error: " & ex.Message)
                Try
                    trans.Rollback()
                Catch exx As Exception
                    MsgBox("Error en el rollback: " & exx.Message)
                End Try
            End Try
        End Using

        '---DESACTIVAR CASILLAS---'
        cboProveedores.Enabled = False
        cboCategoria.Enabled = False
        cboProducto.Enabled = False
        cboMarca.Enabled = False
        dtFechaCompra.Enabled = False
        txtCantidad.Enabled = False
        txtCantidad.Enabled = False
        txtPrecio.Enabled = False
        txtCosto.Enabled = False
        txtIdCompra.Enabled = False
        btnGuardar.Enabled = False
        btnAgregar.Enabled = False
        btnNuevo.Enabled = True
        dgCompras.Rows.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub cboProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedores.SelectedIndexChanged
        '---OBTENER ID DE PROVEEDORES--'
        comando.CommandText = "SELECT IdProveedor FROM Proveedores WHERE Nombre='" & cboProveedores.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdProveedor.Text = lector(0)
        lector.Close()
        cboProveedores.Enabled = False
    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged
        '---OBTENER ID DE CATEGORIAS--'
        comando.CommandText = "SELECT IdCategorias FROM Categorias WHERE Concepto='" & cboCategoria.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdCat.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        '---OBTENER ID DE INSUMOS--'
        comando.CommandText = "SELECT IdInsumos FROM Insumos WHERE Nombre='" & cboProducto.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdProd.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub cboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarca.SelectedIndexChanged
        '---OBTENER ID DE MARCAS--'
        comando.CommandText = "SELECT IdMarca FROM Marcas WHERE Nombre='" & cboMarca.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdMarca.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        frmMnu_ConsCompras.Show()
    End Sub
End Class