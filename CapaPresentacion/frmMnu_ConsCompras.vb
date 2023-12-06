Public Class frmMnu_ConsCompras
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmConsCompras_Fecha.Show()
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmConsCompras_Rango.Show()
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmConsCompras_Proveedor.Show()
        Dispose()
    End Sub
End Class