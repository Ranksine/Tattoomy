<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsProveedores))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgProveedores = New System.Windows.Forms.DataGridView()
        Me.txtProveedores = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(85, 640)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(669, 53)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'dgProveedores
        '
        Me.dgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProveedores.BackgroundColor = System.Drawing.Color.White
        Me.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProveedores.Location = New System.Drawing.Point(12, 98)
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.RowHeadersWidth = 51
        Me.dgProveedores.RowTemplate.Height = 24
        Me.dgProveedores.Size = New System.Drawing.Size(830, 514)
        Me.dgProveedores.TabIndex = 1
        '
        'txtProveedores
        '
        Me.txtProveedores.Enabled = False
        Me.txtProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedores.Location = New System.Drawing.Point(199, 36)
        Me.txtProveedores.Name = "txtProveedores"
        Me.txtProveedores.Size = New System.Drawing.Size(419, 34)
        Me.txtProveedores.TabIndex = 2
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Yellow
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.Enabled = False
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.Black
        Me.btnConsultar.Location = New System.Drawing.Point(637, 27)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(205, 48)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'cboProveedores
        '
        Me.cboProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Items.AddRange(New Object() {"IdProveedores", "Nombre"})
        Me.cboProveedores.Location = New System.Drawing.Point(12, 36)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(164, 33)
        Me.cboProveedores.TabIndex = 4
        '
        'frmConsProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(854, 705)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboProveedores)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtProveedores)
        Me.Controls.Add(Me.dgProveedores)
        Me.Controls.Add(Me.btnSalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsProveedores"
        Me.Opacity = 0.92R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Proveedores"
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents dgProveedores As DataGridView
    Friend WithEvents txtProveedores As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents cboProveedores As ComboBox
End Class
