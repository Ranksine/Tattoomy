Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReporteCompras_Rango
    Dim comando As SqlCommand
    Dim lector As SqlDataReader

    Private Sub dtFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaFin.ValueChanged
        Dim fechaIni, fechaFin As String
        fechaIni = dtFechaInicio.Value.Year & "/" & dtFechaInicio.Value.Month & "/" & dtFechaInicio.Value.Day
        fechaFin = dtFechaFin.Value.Year & "/" & dtFechaFin.Value.Month & "/" & dtFechaFin.Value.Day

        Dim conex As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.TattoomyDBConnectionString").ConnectionString)
        conex.Open()

        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = New SqlCommand
        adapter.SelectCommand.Connection = conex
        adapter.SelectCommand.CommandText = "ListarComprasRango"
        adapter.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim parametro = New SqlParameter("@FechaIni", SqlDbType.Date)
        parametro.Direction = ParameterDirection.Input
        parametro.Value = fechaIni
        adapter.SelectCommand.Parameters.Add(parametro)

        parametro = New SqlParameter("@FechaFin", SqlDbType.Date)
        parametro.Direction = ParameterDirection.Input
        parametro.Value = fechaFin
        adapter.SelectCommand.Parameters.Add(parametro)

        Dim data As New DataSet
        adapter.Fill(data)

        data.DataSetName = "DataSetCompras"
        Dim reportes As New ReportDataSource("DataSetCompras", data.Tables(0))

        reportes.Name = "DataSetCompras"
        reportes.Value = data.Tables(0)

        Dim param1 As New ReportParameter("FechaInicio", fechaIni)
        Dim param2 As New ReportParameter("FechaFin", fechaFin)
        frmReporte_Movimientos.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte_Movimientos.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte_Movimientos.ReportViewer1.LocalReport.ReportPath =
            "C:\Tattoomy\Recursos\ReporteCompras_Rango.rdlc"
        frmReporte_Movimientos.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param1, param2})
        frmReporte_Movimientos.Show()

        conex.Close()
        adapter.Dispose()

        Dispose()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class