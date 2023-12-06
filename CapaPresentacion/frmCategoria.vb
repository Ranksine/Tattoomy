Imports CapaNegocio
Imports CapaEntidad
Public Class frmCategoria
    Dim CapaNegocio As New InsertarCategoria

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DgCategorias.DataSource = CapaNegocio.mostrarCategorias.Tables("SUBE")

    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        'CapaNegocio.AgregarCategoria(txtConcepto.Text, txtDescripcion.Text)
        'DgCategorias.DataSource = CapaNegocio.mostrarCategorias.Tables("SUBE")
        txtConcepto.Clear()
        txtDescripcion.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        frmConsCategoria.Show()
    End Sub
End Class