Public Class frmMnu_ConsVentas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmConsVentas_Fecha.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmConsVentas_Rango.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmConsVentas_Arriba.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmConsVentas_Abajo.Show()
    End Sub
End Class