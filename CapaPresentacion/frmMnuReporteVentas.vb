Public Class frmMnuReporteVentas
    Private Sub cboReportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReportes.SelectedIndexChanged
        If cboReportes.SelectedIndex = 0 Then
            frmReporteVentas_Rango.Show()
        Else
            If cboReportes.SelectedIndex = 1 Then
                frmReporteVentas_Insumo.Show()
            Else

            End If
        End If
    End Sub
End Class