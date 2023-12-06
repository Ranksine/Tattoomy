Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class frmMenu

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        frmProveedores.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        frmConsProveedores.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        frmMarcas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnInsumos.Click
        frmInsumos.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnTatuadores.Click
        frmTatuadores.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        frmClientes.Show()
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        frmCategoria.Show()
    End Sub

    Private Sub btnCatalogos_Click(sender As Object, e As EventArgs) Handles btnCatalogos.Click
        btnCitas.Hide()
        btnCompras.Hide()
        btnVentas.Hide()
        btnBlackList.Hide()

        btnRespRest.Hide()
        btnTraspaso.Hide()

        btnRepBlacklist.Hide()
        btnRepCategoria.Hide()
        btnRepCitas.Hide()
        btnRepClientes.Hide()
        btnRepCompras.Hide()
        btnRepInsumos.Hide()
        btnRepMarcas.Hide()
        btnRepProveedores.Hide()
        btnRepTatuadores.Hide()
        btnRepVentas.Hide()

        btnCategorias.Show()
        btnMarcas.Show()
        btnInsumos.Show()
        btnProveedores.Show()
        btnTatuadores.Show()
        btnClientes.Show()
    End Sub

    Private Sub btnMovimientos_Click(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        btnCategorias.Hide()
        btnMarcas.Hide()
        btnInsumos.Hide()
        btnProveedores.Hide()
        btnTatuadores.Hide()
        btnClientes.Hide()

        btnRespRest.Hide()
        btnTraspaso.Hide()

        btnRepBlacklist.Hide()
        btnRepCategoria.Hide()
        btnRepCitas.Hide()
        btnRepClientes.Hide()
        btnRepCompras.Hide()
        btnRepInsumos.Hide()
        btnRepMarcas.Hide()
        btnRepProveedores.Hide()
        btnRepTatuadores.Hide()
        btnRepVentas.Hide()

        btnCitas.Show()
        btnCompras.Show()
        btnVentas.Show()
        btnBlackList.Show()
    End Sub

    Private Sub btnBlackList_Click(sender As Object, e As EventArgs) Handles btnBlackList.Click
        frmBlacklist.Show()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        frmCompras.Show()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        frmVentas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        btnCitas.Hide()
        btnCompras.Hide()
        btnVentas.Hide()
        btnBlackList.Hide()

        btnCategorias.Hide()
        btnMarcas.Hide()
        btnInsumos.Hide()
        btnProveedores.Hide()
        btnTatuadores.Hide()
        btnClientes.Hide()

        btnRespRest.Hide()
        btnTraspaso.Hide()

        btnRepBlacklist.Show()
        btnRepCategoria.Show()
        btnRepCitas.Show()
        btnRepClientes.Show()
        btnRepCompras.Show()
        btnRepInsumos.Show()
        btnRepMarcas.Show()
        btnRepProveedores.Show()
        btnRepTatuadores.Show()
        btnRepVentas.Show()
    End Sub

    Private Sub btnRepCategoria_Click(sender As Object, e As EventArgs) Handles btnRepCategoria.Click
        Dim conex As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.TattoomyDBConnectionString").ConnectionString)
        conex.Open()
        Dim com As New SqlCommand("ListarCategorias", conex)
        com.CommandType = CommandType.StoredProcedure

        Dim adapter As New SqlDataAdapter(com)
        Dim data As New DataSet

        adapter.Fill(data)
        data.DataSetName = "dataSetCategorias"
        Dim reportes As New ReportDataSource("dataSetCategorias", data.Tables(0))
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Add(reportes)

        frmReporte_Catalogos.ReportViewer1.LocalReport.ReportPath = "C:\Tattoomy\Recursos\ReporteCategorias.rdlc"
        frmReporte_Catalogos.ReportViewer1.RefreshReport()
        frmReporte_Catalogos.Show()
        conex.Close()
    End Sub

    Private Sub btnRepMarcas_Click(sender As Object, e As EventArgs) Handles btnRepMarcas.Click
        Dim conex As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.TattoomyDBConnectionString").ConnectionString)
        conex.Open()
        Dim com As New SqlCommand("ListarMarcas", conex)
        com.CommandType = CommandType.StoredProcedure

        Dim adapter As New SqlDataAdapter(com)
        Dim data As New DataSet

        adapter.Fill(data)
        data.DataSetName = "dataSetMarcas"
        Dim reportes As New ReportDataSource("dataSetMarcas", data.Tables(0))
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Add(reportes)

        frmReporte_Catalogos.ReportViewer1.LocalReport.ReportPath = "C:\Tattoomy\Recursos\ReporteMarcas.rdlc"
        frmReporte_Catalogos.ReportViewer1.RefreshReport()
        frmReporte_Catalogos.Show()
        conex.Close()
    End Sub

    Private Sub btnRepInsumos_Click(sender As Object, e As EventArgs) Handles btnRepInsumos.Click
        Dim conex As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.TattoomyDBConnectionString").ConnectionString)
        conex.Open()
        Dim com As New SqlCommand("ListarInsumos", conex)
        com.CommandType = CommandType.StoredProcedure

        Dim adapter As New SqlDataAdapter(com)
        Dim data As New DataSet

        adapter.Fill(data)
        data.DataSetName = "DataSetInsumos"

        Dim reportes As New ReportDataSource("DataSetInsumos", data.Tables(0))
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte_Catalogos.ReportViewer1.LocalReport.ReportPath = "C:\Tattoomy\Recursos\ReporteInsumos.rdlc"
        frmReporte_Catalogos.ReportViewer1.RefreshReport()
        frmReporte_Catalogos.Show()
        conex.Close()
    End Sub

    Private Sub btnRepProveedores_Click(sender As Object, e As EventArgs) Handles btnRepProveedores.Click
        Dim conex As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.TattoomyDBConnectionString").ConnectionString)
        conex.Open()
        Dim com As New SqlCommand("ListarProveedores", conex)
        com.CommandType = CommandType.StoredProcedure

        Dim adapter As New SqlDataAdapter(com)
        Dim data As New DataSet

        adapter.Fill(data)
        data.DataSetName = "DataSetInsumos"

        Dim reportes As New ReportDataSource("DataSetProveedores", data.Tables(0))
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte_Catalogos.ReportViewer1.LocalReport.ReportPath = "C:\Tattoomy\Recursos\ReporteProveedores.rdlc"
        frmReporte_Catalogos.ReportViewer1.RefreshReport()
        frmReporte_Catalogos.Show()
        conex.Close()
    End Sub

    Private Sub btnRepClientes_Click(sender As Object, e As EventArgs) Handles btnRepClientes.Click
        Dim conex As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.TattoomyDBConnectionString").ConnectionString)
        conex.Open()
        Dim com As New SqlCommand("ListarClientes", conex)
        com.CommandType = CommandType.StoredProcedure

        Dim adapter As New SqlDataAdapter(com)
        Dim data As New DataSet

        adapter.Fill(data)
        data.DataSetName = "DataSetInsumos"

        Dim reportes As New ReportDataSource("DataSetClientes", data.Tables(0))
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte_Catalogos.ReportViewer1.LocalReport.ReportPath = "C:\Tattoomy\Recursos\ReporteClientes.rdlc"
        frmReporte_Catalogos.ReportViewer1.RefreshReport()
        frmReporte_Catalogos.Show()
        conex.Close()
    End Sub

    Private Sub btnRepTatuadores_Click(sender As Object, e As EventArgs) Handles btnRepTatuadores.Click
        Dim conex As SqlConnection
        conex = New SqlConnection(ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.TattoomyDBConnectionString").ConnectionString)
        conex.Open()
        Dim com As New SqlCommand("ListarTatuadores", conex)
        com.CommandType = CommandType.StoredProcedure

        Dim adapter As New SqlDataAdapter(com)
        Dim data As New DataSet

        adapter.Fill(data)
        data.DataSetName = "DataSetInsumos"

        Dim reportes As New ReportDataSource("DataSetTatuadores", data.Tables(0))
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte_Catalogos.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte_Catalogos.ReportViewer1.LocalReport.ReportPath = "C:\Tattoomy\Recursos\ReporteTatuadores.rdlc"
        frmReporte_Catalogos.ReportViewer1.RefreshReport()
        frmReporte_Catalogos.Show()
        conex.Close()
    End Sub

    Private Sub btnRepCompras_Click(sender As Object, e As EventArgs) Handles btnRepCompras.Click
        frmMnuReporteCompras.Show()
    End Sub

    Private Sub btnRepVentas_Click(sender As Object, e As EventArgs) Handles btnRepVentas.Click
        frmMnuReporteVentas.Show()
    End Sub

    Private Sub frmMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.A Then

            System.Diagnostics.Process.Start("C:\Tattoomy\Recursos\Ayuda.chm")
        End If
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        btnRespRest.Show()
        btnTraspaso.Show()

        btnCategorias.Hide()
        btnMarcas.Hide()
        btnInsumos.Hide()
        btnProveedores.Hide()
        btnTatuadores.Hide()
        btnClientes.Hide()

        btnRepBlacklist.Hide()
        btnRepCategoria.Hide()
        btnRepCitas.Hide()
        btnRepClientes.Hide()
        btnRepCompras.Hide()
        btnRepInsumos.Hide()
        btnRepMarcas.Hide()
        btnRepProveedores.Hide()
        btnRepTatuadores.Hide()
        btnRepVentas.Hide()
    End Sub

    Private Sub btnRespRest_Click(sender As Object, e As EventArgs) Handles btnRespRest.Click
        frmRespRest.Show()
    End Sub

    Private Sub btnTraspaso_Click(sender As Object, e As EventArgs) Handles btnTraspaso.Click
        frmTraspasoHistorico.Show()
    End Sub
End Class
