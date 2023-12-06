Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReporteCompras_Proveedor
    Dim comando As SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmReporteCompras_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Server=localhost;Database=TattoomyDB; Integrated Security=SSPI"
        conexion.Open()

        comando = conexion.CreateCommand
        comando.CommandText = "SELECT * FROM Proveedores"
        lector = comando.ExecuteReader
        While lector.Read
            cboProveedores.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub cboProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedores.SelectedIndexChanged
        Dim id As Integer
        comando.CommandText = "SELECT IdProveedor FROM Proveedores WHERE Nombre='" & cboProveedores.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        id = lector(0)
        lector.Close()

        Dim conex As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.TattoomyDBConnectionString").ConnectionString)
        conex.Open()

        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = New SqlCommand
        adapter.SelectCommand.Connection = conex
        adapter.SelectCommand.CommandText = "ListasComprasProveedor"
        adapter.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim parametro = New SqlParameter("@IdProveedor", SqlDbType.Int)
        parametro.Direction = ParameterDirection.Input
        parametro.Value = id
        adapter.SelectCommand.Parameters.Add(parametro)

        Dim data As New DataSet
        adapter.Fill(data)

        data.DataSetName = "DataSetCompras"
        Dim reportes As New ReportDataSource("DataSetCompras", data.Tables(0))

        reportes.Name = "DataSetCompras"
        reportes.Value = data.Tables(0)

        Dim param1 As New ReportParameter("IdProveedor", id)
        frmReporte_Movimientos.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte_Movimientos.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte_Movimientos.ReportViewer1.LocalReport.ReportPath =
                "C:\Tattoomy\Recursos\ReporteCompras_Proveedor.rdlc"
        frmReporte_Movimientos.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param1})
        frmReporte_Movimientos.Show()

        conex.Close()
        adapter.Dispose()

        Dispose()
    End Sub
End Class