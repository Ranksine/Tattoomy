Public Class frmMnuReporteCompras
    Private Sub cboReportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReportes.SelectedIndexChanged
        If cboReportes.SelectedIndex = 0 Then
            frmReporteCompras_Rango.Show()
        Else
            If cboReportes.SelectedIndex = 1 Then
                frmReporteCompras_Insumos.Show()
            Else
                frmReporteCompras_Proveedor.Show()
            End If
        End If

        Dispose()
    End Sub

End Class