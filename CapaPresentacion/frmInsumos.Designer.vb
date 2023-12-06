<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsumos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsumos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dtFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescipcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dgInvisibleCat = New System.Windows.Forms.DataGridView()
        Me.dgInvisibleMarca = New System.Windows.Forms.DataGridView()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgInsumos = New System.Windows.Forms.DataGridView()
        Me.IdInsumosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescipcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TattoomyDBDataSet = New CapaPresentacion.TattoomyDBDataSet()
        Me.btnActivarModif = New System.Windows.Forms.Button()
        Me.InsumosTableAdapter = New CapaPresentacion.TattoomyDBDataSetTableAdapters.InsumosTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgInvisibleCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgInvisibleMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsumosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TattoomyDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(450, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de insumos"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(127, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(258, 30)
        Me.txtNombre.TabIndex = 1
        '
        'cboCategoria
        '
        Me.cboCategoria.Enabled = False
        Me.cboCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(127, 85)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(258, 33)
        Me.cboCategoria.TabIndex = 2
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Black
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(898, 130)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(269, 44)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'dtFechaCompra
        '
        Me.dtFechaCompra.Enabled = False
        Me.dtFechaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaCompra.Location = New System.Drawing.Point(197, 194)
        Me.dtFechaCompra.Name = "dtFechaCompra"
        Me.dtFechaCompra.Size = New System.Drawing.Size(483, 30)
        Me.dtFechaCompra.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Costo"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(370, 142)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(118, 30)
        Me.txtPrecio.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(288, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Precio"
        '
        'txtCosto
        '
        Me.txtCosto.Enabled = False
        Me.txtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Location = New System.Drawing.Point(127, 144)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(124, 30)
        Me.txtCosto.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(849, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Existencia"
        '
        'txtExistencia
        '
        Me.txtExistencia.Enabled = False
        Me.txtExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistencia.Location = New System.Drawing.Point(956, 85)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(211, 30)
        Me.txtExistencia.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(505, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Max"
        '
        'txtMax
        '
        Me.txtMax.Enabled = False
        Me.txtMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax.Location = New System.Drawing.Point(580, 141)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(100, 30)
        Me.txtMax.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(707, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Min"
        '
        'txtMin
        '
        Me.txtMin.Enabled = False
        Me.txtMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(774, 142)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(100, 30)
        Me.txtMin.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(441, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Descripcion"
        '
        'txtDescipcion
        '
        Me.txtDescipcion.Enabled = False
        Me.txtDescipcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescipcion.Location = New System.Drawing.Point(580, 26)
        Me.txtDescipcion.Name = "txtDescipcion"
        Me.txtDescipcion.Size = New System.Drawing.Size(587, 30)
        Me.txtDescipcion.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(13, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fecha de Compra"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(13, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 25)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Categoria"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(464, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 25)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Marca"
        '
        'cboMarca
        '
        Me.cboMarca.Enabled = False
        Me.cboMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(580, 82)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(232, 33)
        Me.cboMarca.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Brown
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtFechaCompra)
        Me.GroupBox1.Controls.Add(Me.cboMarca)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtMin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMax)
        Me.GroupBox1.Controls.Add(Me.txtDescipcion)
        Me.GroupBox1.Controls.Add(Me.cboCategoria)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtExistencia)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1173, 259)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Red
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(774, 189)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(393, 61)
        Me.btnGuardar.TabIndex = 25
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(835, 702)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(344, 65)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Black
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(12, 702)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(393, 65)
        Me.btnConsultar.TabIndex = 27
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'dgInvisibleCat
        '
        Me.dgInvisibleCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInvisibleCat.Location = New System.Drawing.Point(12, 9)
        Me.dgInvisibleCat.Name = "dgInvisibleCat"
        Me.dgInvisibleCat.RowHeadersWidth = 51
        Me.dgInvisibleCat.RowTemplate.Height = 24
        Me.dgInvisibleCat.Size = New System.Drawing.Size(32, 42)
        Me.dgInvisibleCat.TabIndex = 28
        Me.dgInvisibleCat.Visible = False
        '
        'dgInvisibleMarca
        '
        Me.dgInvisibleMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInvisibleMarca.Location = New System.Drawing.Point(1153, 9)
        Me.dgInvisibleMarca.Name = "dgInvisibleMarca"
        Me.dgInvisibleMarca.RowHeadersWidth = 51
        Me.dgInvisibleMarca.RowTemplate.Height = 24
        Me.dgInvisibleMarca.Size = New System.Drawing.Size(32, 42)
        Me.dgInvisibleMarca.TabIndex = 29
        Me.dgInvisibleMarca.Visible = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Insumos.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Insumos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=TattoomyDB;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Descipcion", System.Data.SqlDbType.VarChar, 0, "Descipcion"), New System.Data.SqlClient.SqlParameter("@IdMarca", System.Data.SqlDbType.Int, 0, "IdMarca"), New System.Data.SqlClient.SqlParameter("@IdCategorias", System.Data.SqlDbType.Int, 0, "IdCategorias"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Money, 0, "Costo"), New System.Data.SqlClient.SqlParameter("@Precio", System.Data.SqlDbType.Money, 0, "Precio"), New System.Data.SqlClient.SqlParameter("@Existencia", System.Data.SqlDbType.Int, 0, "Existencia"), New System.Data.SqlClient.SqlParameter("@Max", System.Data.SqlDbType.Int, 0, "Max"), New System.Data.SqlClient.SqlParameter("@Min", System.Data.SqlDbType.Int, 0, "Min")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Descipcion", System.Data.SqlDbType.VarChar, 0, "Descipcion"), New System.Data.SqlClient.SqlParameter("@IdMarca", System.Data.SqlDbType.Int, 0, "IdMarca"), New System.Data.SqlClient.SqlParameter("@IdCategorias", System.Data.SqlDbType.Int, 0, "IdCategorias"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Money, 0, "Costo"), New System.Data.SqlClient.SqlParameter("@Precio", System.Data.SqlDbType.Money, 0, "Precio"), New System.Data.SqlClient.SqlParameter("@Existencia", System.Data.SqlDbType.Int, 0, "Existencia"), New System.Data.SqlClient.SqlParameter("@Max", System.Data.SqlDbType.Int, 0, "Max"), New System.Data.SqlClient.SqlParameter("@Min", System.Data.SqlDbType.Int, 0, "Min"), New System.Data.SqlClient.SqlParameter("@Original_IdInsumos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdInsumos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Descipcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descipcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Descipcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descipcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IdMarca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IdMarca", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IdMarca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdMarca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IdCategorias", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IdCategorias", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IdCategorias", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCategorias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Costo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Precio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Precio", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Existencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Existencia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Existencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Existencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Max", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Max", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Max", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Min", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Min", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Min", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Min", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IdInsumos", System.Data.SqlDbType.Int, 4, "IdInsumos")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_IdInsumos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdInsumos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Descipcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descipcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Descipcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descipcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IdMarca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IdMarca", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IdMarca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdMarca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IdCategorias", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IdCategorias", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IdCategorias", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCategorias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Costo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Precio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Precio", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Existencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Existencia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Existencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Existencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Max", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Max", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Max", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Min", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Min", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Min", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Min", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Insumos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdInsumos", "IdInsumos"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Descipcion", "Descipcion"), New System.Data.Common.DataColumnMapping("IdMarca", "IdMarca"), New System.Data.Common.DataColumnMapping("IdCategorias", "IdCategorias"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("Precio", "Precio"), New System.Data.Common.DataColumnMapping("Existencia", "Existencia"), New System.Data.Common.DataColumnMapping("Max", "Max"), New System.Data.Common.DataColumnMapping("Min", "Min")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Red
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(424, 702)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(393, 65)
        Me.btnModificar.TabIndex = 30
        Me.btnModificar.Text = "Guardar Modificaciones"
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'dgInsumos
        '
        Me.dgInsumos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgInsumos.AutoGenerateColumns = False
        Me.dgInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgInsumos.BackgroundColor = System.Drawing.Color.White
        Me.dgInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInsumos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInsumosDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescipcionDataGridViewTextBoxColumn, Me.IdMarcaDataGridViewTextBoxColumn, Me.IdCategoriasDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.MaxDataGridViewTextBoxColumn, Me.MinDataGridViewTextBoxColumn})
        Me.dgInsumos.DataSource = Me.InsumosBindingSource
        Me.dgInsumos.Location = New System.Drawing.Point(18, 21)
        Me.dgInsumos.Name = "dgInsumos"
        Me.dgInsumos.ReadOnly = True
        Me.dgInsumos.RowHeadersWidth = 51
        Me.dgInsumos.RowTemplate.Height = 24
        Me.dgInsumos.Size = New System.Drawing.Size(1061, 326)
        Me.dgInsumos.TabIndex = 31
        '
        'IdInsumosDataGridViewTextBoxColumn
        '
        Me.IdInsumosDataGridViewTextBoxColumn.DataPropertyName = "IdInsumos"
        Me.IdInsumosDataGridViewTextBoxColumn.HeaderText = "IdInsumos"
        Me.IdInsumosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdInsumosDataGridViewTextBoxColumn.Name = "IdInsumosDataGridViewTextBoxColumn"
        Me.IdInsumosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescipcionDataGridViewTextBoxColumn
        '
        Me.DescipcionDataGridViewTextBoxColumn.DataPropertyName = "Descipcion"
        Me.DescipcionDataGridViewTextBoxColumn.HeaderText = "Descipcion"
        Me.DescipcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescipcionDataGridViewTextBoxColumn.Name = "DescipcionDataGridViewTextBoxColumn"
        Me.DescipcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdMarcaDataGridViewTextBoxColumn
        '
        Me.IdMarcaDataGridViewTextBoxColumn.DataPropertyName = "IdMarca"
        Me.IdMarcaDataGridViewTextBoxColumn.HeaderText = "IdMarca"
        Me.IdMarcaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdMarcaDataGridViewTextBoxColumn.Name = "IdMarcaDataGridViewTextBoxColumn"
        Me.IdMarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCategoriasDataGridViewTextBoxColumn
        '
        Me.IdCategoriasDataGridViewTextBoxColumn.DataPropertyName = "IdCategorias"
        Me.IdCategoriasDataGridViewTextBoxColumn.HeaderText = "IdCategorias"
        Me.IdCategoriasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCategoriasDataGridViewTextBoxColumn.Name = "IdCategoriasDataGridViewTextBoxColumn"
        Me.IdCategoriasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaxDataGridViewTextBoxColumn
        '
        Me.MaxDataGridViewTextBoxColumn.DataPropertyName = "Max"
        Me.MaxDataGridViewTextBoxColumn.HeaderText = "Max"
        Me.MaxDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaxDataGridViewTextBoxColumn.Name = "MaxDataGridViewTextBoxColumn"
        Me.MaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MinDataGridViewTextBoxColumn
        '
        Me.MinDataGridViewTextBoxColumn.DataPropertyName = "Min"
        Me.MinDataGridViewTextBoxColumn.HeaderText = "Min"
        Me.MinDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MinDataGridViewTextBoxColumn.Name = "MinDataGridViewTextBoxColumn"
        Me.MinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InsumosBindingSource
        '
        Me.InsumosBindingSource.DataMember = "Insumos"
        Me.InsumosBindingSource.DataSource = Me.TattoomyDBDataSet
        '
        'TattoomyDBDataSet
        '
        Me.TattoomyDBDataSet.DataSetName = "TattoomyDBDataSet"
        Me.TattoomyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnActivarModif
        '
        Me.btnActivarModif.BackColor = System.Drawing.Color.Red
        Me.btnActivarModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActivarModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivarModif.ForeColor = System.Drawing.Color.White
        Me.btnActivarModif.Location = New System.Drawing.Point(424, 702)
        Me.btnActivarModif.Name = "btnActivarModif"
        Me.btnActivarModif.Size = New System.Drawing.Size(393, 65)
        Me.btnActivarModif.TabIndex = 32
        Me.btnActivarModif.Text = "Modificars"
        Me.btnActivarModif.UseVisualStyleBackColor = False
        '
        'InsumosTableAdapter
        '
        Me.InsumosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUltimo)
        Me.GroupBox2.Controls.Add(Me.btnAnterior)
        Me.GroupBox2.Controls.Add(Me.btnsiguiente)
        Me.GroupBox2.Controls.Add(Me.btnPrimero)
        Me.GroupBox2.Controls.Add(Me.dgInsumos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1173, 364)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'btnUltimo
        '
        Me.btnUltimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUltimo.BackColor = System.Drawing.Color.White
        Me.btnUltimo.BackgroundImage = CType(resources.GetObject("btnUltimo.BackgroundImage"), System.Drawing.Image)
        Me.btnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUltimo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.ForeColor = System.Drawing.Color.Black
        Me.btnUltimo.Location = New System.Drawing.Point(1085, 282)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(82, 65)
        Me.btnUltimo.TabIndex = 37
        Me.btnUltimo.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnterior.BackColor = System.Drawing.Color.White
        Me.btnAnterior.BackgroundImage = CType(resources.GetObject("btnAnterior.BackgroundImage"), System.Drawing.Image)
        Me.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.Color.Black
        Me.btnAnterior.Location = New System.Drawing.Point(1085, 188)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(82, 65)
        Me.btnAnterior.TabIndex = 36
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsiguiente.BackColor = System.Drawing.Color.White
        Me.btnsiguiente.BackgroundImage = CType(resources.GetObject("btnsiguiente.BackgroundImage"), System.Drawing.Image)
        Me.btnsiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnsiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsiguiente.ForeColor = System.Drawing.Color.Black
        Me.btnsiguiente.Location = New System.Drawing.Point(1085, 117)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(82, 65)
        Me.btnsiguiente.TabIndex = 35
        Me.btnsiguiente.UseVisualStyleBackColor = False
        '
        'btnPrimero
        '
        Me.btnPrimero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrimero.BackColor = System.Drawing.Color.IndianRed
        Me.btnPrimero.BackgroundImage = CType(resources.GetObject("btnPrimero.BackgroundImage"), System.Drawing.Image)
        Me.btnPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrimero.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.ForeColor = System.Drawing.Color.Black
        Me.btnPrimero.Location = New System.Drawing.Point(1085, 21)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(82, 65)
        Me.btnPrimero.TabIndex = 34
        Me.btnPrimero.UseVisualStyleBackColor = False
        '
        'frmInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1197, 779)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnActivarModif)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.dgInvisibleMarca)
        Me.Controls.Add(Me.dgInvisibleCat)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInsumos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insumos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgInvisibleCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgInvisibleMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsumosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TattoomyDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dtFechaCompra As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtExistencia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMax As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescipcion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents dgInvisibleCat As DataGridView
    Friend WithEvents dgInvisibleMarca As DataGridView
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents TattoomyDBDataSet As TattoomyDBDataSet
    Friend WithEvents btnModificar As Button
    Friend WithEvents dgInsumos As DataGridView
    Friend WithEvents InsumosBindingSource As BindingSource
    Friend WithEvents InsumosTableAdapter As TattoomyDBDataSetTableAdapters.InsumosTableAdapter
    Friend WithEvents IdInsumosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescipcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnActivarModif As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnsiguiente As Button
    Friend WithEvents btnPrimero As Button
End Class
