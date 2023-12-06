Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmRespRest
    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub brnAbrir_Click(sender As Object, e As EventArgs) Handles brnAbrir.Click
        '---------------configuracion de algunos parametros del openFileDialog------------------------
        'directorio inicial donde se abrira
        OpenFileDialog1.InitialDirectory = "C:\\"
        'filtro de archivos.
        OpenFileDialog1.Filter = "All files  (*.bak)|*.bak"
        'codigo para abrir el cuadro de dialogo
        Dim str_RutaArchivo As String
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            str_RutaArchivo = OpenFileDialog1.FileName
            txtAbrir.Text = str_RutaArchivo

            conexion.ConnectionString = "Data Source=.; Initial Catalog=master; Integrated Security=True"
            conexion.Open()

            Try
                Dim r = "Restore database TattoomyDB from disk= '" & str_RutaArchivo & "' with replace"
                MsgBox(r)
                comando.CommandText = r
                comando.ExecuteNonQuery()
                MessageBox.Show("Datos guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Errorsini" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            conexion.Close()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'configuracion de algunos parametros del openFileDialog
        'directorio inicial donde se abrira
        SaveFileDialog1.InitialDirectory = "C:\\"
        'filtro de archivos.
        SaveFileDialog1.Filter = "sql server database files|*.bak"
        'codigo para abrir el cuadro de dialogo
        Dim str_RutaArchivo As String
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            str_RutaArchivo = SaveFileDialog1.FileName
            txtGuardar.Text = str_RutaArchivo
            conexion.ConnectionString = "Data Source=.;Initial Catalog=TattoomyDB;Integrated Security=True"
            conexion.Open()

            Try
                Dim r = "Backup database TattoomyDB to Disk='" & str_RutaArchivo & "'"
                MsgBox(r)
                comando.CommandText = r
                comando.ExecuteNonQuery()
                MessageBox.Show("Datos guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Errorsini: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            conexion.Close()
        End If
    End Sub

End Class