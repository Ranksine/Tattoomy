Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReporteCompras_Insumos
    Dim comando As SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmReporteCompras_Insumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Server=localhost;Database=TattoomyDB; Integrated Security=SSPI"
        conexion.Open()

        comando = conexion.CreateCommand
        comando.CommandText = "SELECT * FROM Insumos"
        lector = comando.ExecuteReader
        While lector.Read
            cboInsumos.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub cboInsumos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInsumos.SelectedIndexChanged
        Dim nombre As String
        nombre = cboInsumos.Text
        Dim conex As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.TattoomyDBConnectionString").ConnectionString)
        conex.Open()

        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = New SqlCommand
        adapter.SelectCommand.Connection = conex
        adapter.SelectCommand.CommandText = "ListarComprasInsumo"
        adapter.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim parametro = New SqlParameter("@Nombre", SqlDbType.VarChar)
        parametro.Direction = ParameterDirection.Input
        parametro.Value = nombre
        adapter.SelectCommand.Parameters.Add(parametro)

        Dim data As New DataSet
        adapter.Fill(data)

        data.DataSetName = "DataSetCompras"
        Dim reportes As New ReportDataSource("DataSetCompras", data.Tables(0))

        reportes.Name = "DataSetCompras"
        reportes.Value = data.Tables(0)

        Dim param1 As New ReportParameter("Nombre", nombre)
        frmReporte_Movimientos.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte_Movimientos.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte_Movimientos.ReportViewer1.LocalReport.ReportPath =
            "C:\Tattoomy\Recursos\ReporteCompras_Insumo.rdlc"
        frmReporte_Movimientos.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param1})
        frmReporte_Movimientos.Show()

        conex.Close()
        adapter.Dispose()

        Dispose()
    End Sub
End Class