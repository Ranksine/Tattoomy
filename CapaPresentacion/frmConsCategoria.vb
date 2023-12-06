Public Class frmConsCategoria
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub frmConsCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgCategorias.DataSource = CapaDatos.MetodosCategorias.listarCategorias
    End Sub

    Private Sub txtCategorias_TextChanged(sender As Object, e As EventArgs) Handles txtCategorias.TextChanged
        Dim vista As New DataView(CapaDatos.MetodosCategorias.listarCategorias)
        vista.RowFilter = "Concepto LIKE '" & txtCategorias.Text & "%'"
        dgCategorias.DataSource = vista
    End Sub
End Class