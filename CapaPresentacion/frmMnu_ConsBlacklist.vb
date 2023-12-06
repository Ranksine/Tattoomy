Public Class frmMnu_ConsBlacklist
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmConsBlacklist_Fecha.Show()
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmConsBlacklist_Rango.Show()
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmConsBlacklist_Tatuador.Show()
        Dispose()
    End Sub
End Class