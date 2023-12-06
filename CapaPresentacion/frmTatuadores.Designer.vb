<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTatuadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTatuadores))
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgTatuadores = New System.Windows.Forms.DataGridView()
        Me.IdTatuadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstagramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacebookDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstiloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TatuadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TattoomyDBDataSet1 = New CapaPresentacion.TattoomyDBDataSet1()
        Me.btnActivarModif = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Domicilio = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstilo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFacebook = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtInstagram = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.TatuadorTableAdapter = New CapaPresentacion.TattoomyDBDataSet1TableAdapters.TatuadorTableAdapter()
        CType(Me.dgTatuadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TatuadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TattoomyDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnsiguiente.Location = New System.Drawing.Point(965, 99)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(82, 65)
        Me.btnsiguiente.TabIndex = 35
        Me.btnsiguiente.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Red
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(326, 677)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(395, 65)
        Me.btnModificar.TabIndex = 40
        Me.btnModificar.Text = "Guardar Modificaciones"
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'dgTatuadores
        '
        Me.dgTatuadores.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTatuadores.AutoGenerateColumns = False
        Me.dgTatuadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgTatuadores.BackgroundColor = System.Drawing.Color.White
        Me.dgTatuadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTatuadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTatuadorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.CPDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.InstagramDataGridViewTextBoxColumn, Me.FacebookDataGridViewTextBoxColumn, Me.EstiloDataGridViewTextBoxColumn})
        Me.dgTatuadores.DataSource = Me.TatuadorBindingSource
        Me.dgTatuadores.Location = New System.Drawing.Point(18, 21)
        Me.dgTatuadores.MultiSelect = False
        Me.dgTatuadores.Name = "dgTatuadores"
        Me.dgTatuadores.ReadOnly = True
        Me.dgTatuadores.RowHeadersWidth = 51
        Me.dgTatuadores.RowTemplate.Height = 24
        Me.dgTatuadores.Size = New System.Drawing.Size(927, 293)
        Me.dgTatuadores.TabIndex = 31
        '
        'IdTatuadorDataGridViewTextBoxColumn
        '
        Me.IdTatuadorDataGridViewTextBoxColumn.DataPropertyName = "IdTatuador"
        Me.IdTatuadorDataGridViewTextBoxColumn.HeaderText = "IdTatuador"
        Me.IdTatuadorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdTatuadorDataGridViewTextBoxColumn.Name = "IdTatuadorDataGridViewTextBoxColumn"
        Me.IdTatuadorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTatuadorDataGridViewTextBoxColumn.Width = 102
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 85
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Width = 93
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        Me.DomicilioDataGridViewTextBoxColumn.Width = 92
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColoniaDataGridViewTextBoxColumn.Width = 82
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CiudadDataGridViewTextBoxColumn.Width = 79
        '
        'CPDataGridViewTextBoxColumn
        '
        Me.CPDataGridViewTextBoxColumn.DataPropertyName = "CP"
        Me.CPDataGridViewTextBoxColumn.HeaderText = "CP"
        Me.CPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CPDataGridViewTextBoxColumn.Name = "CPDataGridViewTextBoxColumn"
        Me.CPDataGridViewTextBoxColumn.ReadOnly = True
        Me.CPDataGridViewTextBoxColumn.Width = 54
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 90
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "Celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        Me.CelularDataGridViewTextBoxColumn.Width = 78
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 70
        '
        'InstagramDataGridViewTextBoxColumn
        '
        Me.InstagramDataGridViewTextBoxColumn.DataPropertyName = "Instagram"
        Me.InstagramDataGridViewTextBoxColumn.HeaderText = "Instagram"
        Me.InstagramDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InstagramDataGridViewTextBoxColumn.Name = "InstagramDataGridViewTextBoxColumn"
        Me.InstagramDataGridViewTextBoxColumn.ReadOnly = True
        Me.InstagramDataGridViewTextBoxColumn.Width = 95
        '
        'FacebookDataGridViewTextBoxColumn
        '
        Me.FacebookDataGridViewTextBoxColumn.DataPropertyName = "Facebook"
        Me.FacebookDataGridViewTextBoxColumn.HeaderText = "Facebook"
        Me.FacebookDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FacebookDataGridViewTextBoxColumn.Name = "FacebookDataGridViewTextBoxColumn"
        Me.FacebookDataGridViewTextBoxColumn.ReadOnly = True
        Me.FacebookDataGridViewTextBoxColumn.Width = 98
        '
        'EstiloDataGridViewTextBoxColumn
        '
        Me.EstiloDataGridViewTextBoxColumn.DataPropertyName = "Estilo"
        Me.EstiloDataGridViewTextBoxColumn.HeaderText = "Estilo"
        Me.EstiloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstiloDataGridViewTextBoxColumn.Name = "EstiloDataGridViewTextBoxColumn"
        Me.EstiloDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstiloDataGridViewTextBoxColumn.Width = 69
        '
        'TatuadorBindingSource
        '
        Me.TatuadorBindingSource.DataMember = "Tatuador"
        Me.TatuadorBindingSource.DataSource = Me.TattoomyDBDataSet1
        '
        'TattoomyDBDataSet1
        '
        Me.TattoomyDBDataSet1.DataSetName = "TattoomyDBDataSet1"
        Me.TattoomyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnActivarModif
        '
        Me.btnActivarModif.BackColor = System.Drawing.Color.Red
        Me.btnActivarModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActivarModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivarModif.ForeColor = System.Drawing.Color.White
        Me.btnActivarModif.Location = New System.Drawing.Point(326, 676)
        Me.btnActivarModif.Name = "btnActivarModif"
        Me.btnActivarModif.Size = New System.Drawing.Size(395, 65)
        Me.btnActivarModif.TabIndex = 41
        Me.btnActivarModif.Text = "Modificars"
        Me.btnActivarModif.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUltimo)
        Me.GroupBox2.Controls.Add(Me.btnAnterior)
        Me.GroupBox2.Controls.Add(Me.btnsiguiente)
        Me.GroupBox2.Controls.Add(Me.btnPrimero)
        Me.GroupBox2.Controls.Add(Me.dgTatuadores)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1064, 331)
        Me.GroupBox2.TabIndex = 42
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
        Me.btnUltimo.Location = New System.Drawing.Point(965, 249)
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
        Me.btnAnterior.Location = New System.Drawing.Point(965, 170)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(82, 65)
        Me.btnAnterior.TabIndex = 36
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnPrimero
        '
        Me.btnPrimero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrimero.BackColor = System.Drawing.Color.Transparent
        Me.btnPrimero.BackgroundImage = CType(resources.GetObject("btnPrimero.BackgroundImage"), System.Drawing.Image)
        Me.btnPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrimero.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnPrimero.FlatAppearance.BorderSize = 10
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.ForeColor = System.Drawing.Color.Black
        Me.btnPrimero.Location = New System.Drawing.Point(965, 21)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(82, 65)
        Me.btnPrimero.TabIndex = 34
        Me.btnPrimero.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Red
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(741, 169)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(306, 81)
        Me.btnGuardar.TabIndex = 25
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Black
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(18, 206)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(704, 44)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(421, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 25)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Colonia"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(127, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(157, 30)
        Me.txtNombre.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(663, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(741, 118)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(306, 30)
        Me.txtEmail.TabIndex = 15
        '
        'Domicilio
        '
        Me.Domicilio.AutoSize = True
        Me.Domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Domicilio.ForeColor = System.Drawing.Color.White
        Me.Domicilio.Location = New System.Drawing.Point(13, 77)
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.Size = New System.Drawing.Size(90, 25)
        Me.Domicilio.TabIndex = 22
        Me.Domicilio.Text = "Domicilio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(426, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Celular"
        '
        'txtCelular
        '
        Me.txtCelular.Enabled = False
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(510, 118)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(129, 30)
        Me.txtCelular.TabIndex = 13
        '
        'txtApellidos
        '
        Me.txtApellidos.Enabled = False
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(412, 26)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(273, 30)
        Me.txtApellidos.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 46)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Registro de Tatuadores"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(309, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(195, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(290, 118)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(129, 30)
        Me.txtTelefono.TabIndex = 7
        '
        'txtCiudad
        '
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(799, 74)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(248, 30)
        Me.txtCiudad.TabIndex = 11
        '
        'txtCP
        '
        Me.txtCP.Enabled = False
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(72, 118)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(96, 30)
        Me.txtCP.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(704, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ciudad"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Black
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(27, 677)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(272, 65)
        Me.btnConsultar.TabIndex = 37
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Brown
        Me.GroupBox1.Controls.Add(Me.txtEstilo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtFacebook)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtInstagram)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtColonia)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Domicilio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.txtCP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1064, 259)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'txtEstilo
        '
        Me.txtEstilo.Enabled = False
        Me.txtEstilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstilo.Location = New System.Drawing.Point(799, 26)
        Me.txtEstilo.Name = "txtEstilo"
        Me.txtEstilo.Size = New System.Drawing.Size(248, 30)
        Me.txtEstilo.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(720, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 25)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Estilo"
        '
        'txtFacebook
        '
        Me.txtFacebook.Enabled = False
        Me.txtFacebook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacebook.Location = New System.Drawing.Point(510, 166)
        Me.txtFacebook.Name = "txtFacebook"
        Me.txtFacebook.Size = New System.Drawing.Size(212, 30)
        Me.txtFacebook.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(401, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 25)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Facebook"
        '
        'txtInstagram
        '
        Me.txtInstagram.Enabled = False
        Me.txtInstagram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstagram.Location = New System.Drawing.Point(127, 166)
        Me.txtInstagram.Name = "txtInstagram"
        Me.txtInstagram.Size = New System.Drawing.Size(233, 30)
        Me.txtInstagram.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(13, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 25)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Instagram"
        '
        'txtColonia
        '
        Me.txtColonia.Enabled = False
        Me.txtColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColonia.Location = New System.Drawing.Point(510, 77)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(175, 30)
        Me.txtColonia.TabIndex = 27
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(127, 77)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(258, 30)
        Me.txtDomicilio.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CP"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(752, 677)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(339, 64)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Tatuador.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Tatuador"
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Apellidos", System.Data.SqlDbType.VarChar, 0, "Apellidos"), New System.Data.SqlClient.SqlParameter("@Domicilio", System.Data.SqlDbType.VarChar, 0, "Domicilio"), New System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.VarChar, 0, "Colonia"), New System.Data.SqlClient.SqlParameter("@Ciudad", System.Data.SqlDbType.VarChar, 0, "Ciudad"), New System.Data.SqlClient.SqlParameter("@CP", System.Data.SqlDbType.VarChar, 0, "CP"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 0, "Telefono"), New System.Data.SqlClient.SqlParameter("@Celular", System.Data.SqlDbType.VarChar, 0, "Celular"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Instagram", System.Data.SqlDbType.VarChar, 0, "Instagram"), New System.Data.SqlClient.SqlParameter("@Facebook", System.Data.SqlDbType.VarChar, 0, "Facebook"), New System.Data.SqlClient.SqlParameter("@Estilo", System.Data.SqlDbType.VarChar, 0, "Estilo")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Apellidos", System.Data.SqlDbType.VarChar, 0, "Apellidos"), New System.Data.SqlClient.SqlParameter("@Domicilio", System.Data.SqlDbType.VarChar, 0, "Domicilio"), New System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.VarChar, 0, "Colonia"), New System.Data.SqlClient.SqlParameter("@Ciudad", System.Data.SqlDbType.VarChar, 0, "Ciudad"), New System.Data.SqlClient.SqlParameter("@CP", System.Data.SqlDbType.VarChar, 0, "CP"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 0, "Telefono"), New System.Data.SqlClient.SqlParameter("@Celular", System.Data.SqlDbType.VarChar, 0, "Celular"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Instagram", System.Data.SqlDbType.VarChar, 0, "Instagram"), New System.Data.SqlClient.SqlParameter("@Facebook", System.Data.SqlDbType.VarChar, 0, "Facebook"), New System.Data.SqlClient.SqlParameter("@Estilo", System.Data.SqlDbType.VarChar, 0, "Estilo"), New System.Data.SqlClient.SqlParameter("@Original_IdTatuador", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTatuador", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Apellidos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Apellidos", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Apellidos", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Domicilio", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Ciudad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ciudad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Ciudad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ciudad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CP", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Celular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Celular", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Celular", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Instagram", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Instagram", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Instagram", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Instagram", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Facebook", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Facebook", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Facebook", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Facebook", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Estilo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Estilo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Estilo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estilo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IdTatuador", System.Data.SqlDbType.Int, 4, "IdTatuador")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_IdTatuador", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTatuador", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Apellidos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Apellidos", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Apellidos", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Domicilio", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Ciudad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ciudad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Ciudad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ciudad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CP", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Celular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Celular", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Celular", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Instagram", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Instagram", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Instagram", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Instagram", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Facebook", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Facebook", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Facebook", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Facebook", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Estilo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Estilo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Estilo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estilo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Tatuador", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdTatuador", "IdTatuador"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Apellidos", "Apellidos"), New System.Data.Common.DataColumnMapping("Domicilio", "Domicilio"), New System.Data.Common.DataColumnMapping("Colonia", "Colonia"), New System.Data.Common.DataColumnMapping("Ciudad", "Ciudad"), New System.Data.Common.DataColumnMapping("CP", "CP"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono"), New System.Data.Common.DataColumnMapping("Celular", "Celular"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Instagram", "Instagram"), New System.Data.Common.DataColumnMapping("Facebook", "Facebook"), New System.Data.Common.DataColumnMapping("Estilo", "Estilo")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'TatuadorTableAdapter
        '
        Me.TatuadorTableAdapter.ClearBeforeFill = True
        '
        'frmTatuadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1107, 746)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnActivarModif)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTatuadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTatuadores"
        CType(Me.dgTatuadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TatuadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TattoomyDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsiguiente As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents dgTatuadores As DataGridView
    Friend WithEvents btnActivarModif As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtInstagram As TextBox
    Friend WithEvents txtFacebook As TextBox
    Friend WithEvents txtEstilo As TextBox
    Friend WithEvents Domicilio As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents TattoomyDBDataSet1 As TattoomyDBDataSet1
    Friend WithEvents TatuadorBindingSource As BindingSource
    Friend WithEvents TatuadorTableAdapter As TattoomyDBDataSet1TableAdapters.TatuadorTableAdapter
    Friend WithEvents IdTatuadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstagramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacebookDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstiloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
