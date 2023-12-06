Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmTraspasoHistorico
    Dim conex As New SqlConnection
    Dim comando As SqlCommand = conex.CreateCommand
    Dim auxcomando As SqlCommand = conex.CreateCommand 'Comando auxiliar  para extraer datos y no sobre saturar el primer comando
    Dim lector As SqlDataReader

    Dim hconex As New SqlConnection 'Conexion del data warehouse
    Dim hcomando As SqlCommand = hconex.CreateCommand 'Comando del data warehouse
    Dim hlector As SqlDataReader 'Lector del data warehouse

    Private Sub frmTraspasoHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion a base de datos original
        conex.ConnectionString = "Data Source=localhost;Initial Catalog=TattoomyDB;Integrated Security=True; MultipleActiveResultSets=True;"
        conex.Open()
        'conexion a data warehouse
        hconex.ConnectionString = "Data Source=localhost;Initial Catalog=TattoomyWharehouse;Integrated Security=True; MultipleActiveResultSets=True;"
        hconex.Open()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim R As String
        Dim msgvalue As Integer

        msgvalue = MsgBox("¿Estas seguro de realizar esta operación?", vbOKCancel, "Traspaso a WHAREHOUSE")

        If msgvalue = 1 Then
            '1. Truncar todas las tablas del historico para guardar toda la información de un año específico

            R = "TRUNCATE TABLE Categorias" 'Limpiar tablas
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE Citas"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE Cliente"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE Compras"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE DetCita"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE DetCompra"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE DetVenta"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE Insumos"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE ListaNegra"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE Marcas"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE Proveedores"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE Tatuador"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            R = "TRUNCATE TABLE Ventas"
            hcomando.CommandText = R
            hcomando.ExecuteNonQuery()

            '-----------------------------------------TRANSFERIR LA INFORMACION----------------------------------------------
            R = "SELECT * FROM Categorias" '2. Consultar toda la informacion de la tabla
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read() '------------------------IdCategorias-------Concepto------------Descripcion-----'
                R = "INSERT INTO Categorias VALUES (" & lector(0) & ",'" & lector(1) & "','" & lector(2) & "')"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery() '3. Insertar esa consulta en la tabla del data warehouse
            End While
            lector.Close()

            R = "SELECT * FROM Citas"
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read() '--------------------IdCita-----------IdTatuador-------IdCliente-----------Fecha---------------Hora---------------NumSala---------Precio----------'
                R = "INSERT INTO Citas VALUES (" & lector(0) & "," & lector(1) & "," & lector(2) & ",'" & lector(3) & "','" & lector(4) & "'," & lector(5) & "," & lector(6) & "')"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery()

                R = "SELECT * FROM DetCita WHERE IdCita =" & Val(lector(0))
                auxcomando.CommandText = R
                hlector = auxcomando.ExecuteReader
                While hlector.Read() '--------------------IdCita-------------Detalles--------------Colores--------'
                    R = "INSERT INTO DetCita VALUES (" & hlector(0) & ",'" & hlector(1) & "'," & hlector(2) & ")"
                    hcomando.CommandText = R
                    hcomando.ExecuteNonQuery()
                End While
                hlector.Close()
            End While
            lector.Close()

            R = "SELECT * FROM Cliente"
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read() '-------------------------IdCliente-----------Nombre------------Apellidos-----------Domicilio-----------Colonia--------------Ciudad---------------CP-----------------Telefono------------Celular-------------Email---------------Strikes----------'
                R = "INSERT INTO Cliente VALUES (" & lector(0) & ",'" & lector(1) & "','" & lector(2) & "','" & lector(3) & "','" & lector(4) & "','" & lector(5) & "','" & lector(6) & "','" & lector(7) & "','" & lector(8) & "','" & lector(9) & "'," & lector(10) & ")"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery()
            End While
            lector.Close()

            'Para las compras/ventas solo se pasaran las que el año sea igual al año seleccionado en el combo
            R = "SELECT * FROM Compras WHERE Year(FechaCompra) =" & Val(cboFecha.Text)
            comando.CommandText = R
            lector = comando.ExecuteReader
            Dim fecha As String
            While lector.Read() '--------------------IdCompra----------IdProveedor-------FechaCompra----------Total-----------'

                fecha = Format(lector(2), "yyyy/MM/dd")
                R = "INSERT INTO Compras VALUES (" & lector(0) & "," & lector(1) & ",'" & fecha & "'," & lector(3) & ")"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery()

                R = "SELECT * FROM DetCompra WHERE idCompra =" & Val(lector(0))
                auxcomando.CommandText = R
                hlector = auxcomando.ExecuteReader
                While hlector.Read() '---------------------IdCompra-----------IdInsumos-----------Cantidad------------Costo-----------'
                    R = "INSERT INTO DetCompra VALUES (" & hlector(0) & "," & hlector(1) & "," & hlector(2) & "," & hlector(3) & ")"
                    hcomando.CommandText = R
                    hcomando.ExecuteNonQuery()
                End While
                hlector.Close()
            End While
            lector.Close()

            R = "SELECT * FROM Ventas WHERE Year(FechaVenta) =" & Val(cboFecha.Text)
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                fecha = Format(lector(1), "yyyy/MM/dd")
                '------------------------------------IdVenta------------Fecha--------------Total----------'
                R = "INSERT INTO Ventas VALUES (" & lector(0) & ",'" & fecha & "'," & lector(2) & ")"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery()

                R = "SELECT * FROM DetVenta WHERE IdVenta =" & Val(lector(0))
                auxcomando.CommandText = R
                hlector = auxcomando.ExecuteReader
                While hlector.Read() '----------------------IdVenta-----------IdInsumo----------Cantidad------------Precio---------'
                    R = "INSERT INTO DetVenta VALUES (" & hlector(0) & "," & hlector(1) & "," & hlector(2) & "," & hlector(3) & ")"
                    hcomando.CommandText = R
                    hcomando.ExecuteNonQuery()
                End While
                hlector.Close()
            End While
            lector.Close()

            R = "SELECT * FROM Insumos"
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read() '--------------------IdInsumos-----------Nombre-----------Descripcion----------IdMarca---------IdCategorias---------Costo-------------Precio----------Existencia-----------Max---------------Min-------'
                R = "INSERT INTO Insumos VALUES (" & lector(0) & ",'" & lector(1) & "','" & lector(2) & "'," & lector(3) & "," & lector(4) & "," & lector(5) & "," & lector(6) & "," & lector(7) & "," & lector(8) & "," & lector(9) & ")"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery()
            End While
            lector.Close()

            R = "SELECT * FROM Marcas"
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read() '------------------------IdMarcas------------Nombre------------Descripcion-----'
                R = "INSERT INTO Marcas VALUES (" & lector(0) & ",'" & lector(1) & "','" & lector(2) & "')"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery()
            End While
            lector.Close()

            R = "SELECT * FROM ListaNegra"
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                fecha = Format(lector(3), "yyyy/MM/dd")
                '---------------------------------------IdLista-----------IdCliente--------IdTatuador--------FechaIngreso-------Motivo----------'
                R = "INSERT INTO ListaNegra VALUES (" & lector(0) & "," & lector(1) & "," & lector(2) & ",'" & fecha & "','" & lector(2) & "')"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery() '3. Insertar esa consulta en la tabla del data warehouse
            End While
            lector.Close()

            R = "SELECT * FROM Proveedores"
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read() '-------------------------IdProveedor---------Nombre-------------Domicilio-----------Colonia--------------Ciudad---------------CP-----------------Telefono------------Celular----------Representante----------Email---------------Pais-----------'
                R = "INSERT INTO Proveedores VALUES (" & lector(0) & ",'" & lector(1) & "','" & lector(2) & "','" & lector(3) & "','" & lector(4) & "','" & lector(5) & "','" & lector(6) & "','" & lector(7) & "','" & lector(8) & "','" & lector(9) & "','" & lector(10) & "')"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery()
            End While
            lector.Close()

            R = "SELECT * FROM Tatuador"
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read() '---------------------IdTatuador---------Nombre--------------Apellidos-----------Domicilio-----------Colonia--------------Ciudad---------------CP-----------------Telefono------------Celular-------------Email---------------Instagram------------Facebook-------------Estilo----------'
                R = "INSERT INTO Tatuador VALUES (" & lector(0) & ",'" & lector(1) & "','" & lector(2) & "','" & lector(3) & "','" & lector(4) & "','" & lector(5) & "','" & lector(6) & "','" & lector(7) & "','" & lector(8) & "','" & lector(9) & "','" & lector(10) & "','" & lector(11) & "','" & lector(12) & "')"
                hcomando.CommandText = R
                hcomando.ExecuteNonQuery()
            End While
            lector.Close()

            '4. Borrar la informacion de la base de datos original
            'Primero borrar los datos de los detalles para no perder la informacion necesaria
            R = "SELECT * FROM Compras WHERE Year(FechaCompra) =" & Val(cboFecha.Text) 'falta saldo perroooooooooooooooooooooo
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                R = "DELETE FROM DetCompra WHERE IdCompra=" & Val(lector(0))
                auxcomando.CommandText = R
                auxcomando.ExecuteNonQuery()
                hlector.Close()
            End While
            lector.Close()

            R = "DELETE FROM Compras WHERE Year(FechaCompra) =" & Val(cboFecha.Text)
            comando.CommandText = R
            comando.ExecuteNonQuery()


            R = "SELECT * FROM Ventas WHERE Year(FechaVenta) =" & Val(cboFecha.Text)
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()

                R = "DELETE FROM DetVenta WHERE IdVenta=" & Val(lector(0))
                auxcomando.CommandText = R
                auxcomando.ExecuteNonQuery()

                hlector.Close()
            End While
            lector.Close()

            R = "DELETE FROM Ventas WHERE Year(FechaVenta) =" & Val(cboFecha.Text)
            comando.CommandText = R
            comando.ExecuteNonQuery()


            R = "DELETE FROM ListaNegra WHERE Year(FechaIngreso) =" & Val(cboFecha.Text)
            comando.CommandText = R
            comando.ExecuteNonQuery()

            MsgBox("Traspaso historico se a ejecutado correctamente")

        ElseIf msgvalue <> 1 Then
            MsgBox("Se a cancelado la operación")
        End If

    End Sub
End Class