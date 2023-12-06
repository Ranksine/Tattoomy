<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsMarcas
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
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.dgConsMarca = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConsMarca = New System.Windows.Forms.TextBox()
        Me.cboConsMarca = New System.Windows.Forms.ComboBox()
        CType(Me.dgConsMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMarca
        '
        Me.cboMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Items.AddRange(New Object() {"Consulta por nombre", "Busqueda manual"})
        Me.cboMarca.Location = New System.Drawing.Point(12, 59)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(207, 33)
        Me.cboMarca.TabIndex = 0
        '
        'dgConsMarca
        '
        Me.dgConsMarca.BackgroundColor = System.Drawing.Color.White
        Me.dgConsMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsMarca.Location = New System.Drawing.Point(12, 123)
        Me.dgConsMarca.Name = "dgConsMarca"
        Me.dgConsMarca.ReadOnly = True
        Me.dgConsMarca.RowHeadersWidth = 51
        Me.dgConsMarca.RowTemplate.Height = 24
        Me.dgConsMarca.Size = New System.Drawing.Size(609, 608)
        Me.dgConsMarca.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(489, 50)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(132, 52)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Black
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Arvo", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(73, 749)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(481, 53)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(143, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selecciona un tipo de consulta"
        '
        'txtConsMarca
        '
        Me.txtConsMarca.Enabled = False
        Me.txtConsMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsMarca.Location = New System.Drawing.Point(242, 58)
        Me.txtConsMarca.Name = "txtConsMarca"
        Me.txtConsMarca.Size = New System.Drawing.Size(229, 34)
        Me.txtConsMarca.TabIndex = 4
        '
        'cboConsMarca
        '
        Me.cboConsMarca.Enabled = False
        Me.cboConsMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConsMarca.FormattingEnabled = True
        Me.cboConsMarca.Location = New System.Drawing.Point(242, 58)
        Me.cboConsMarca.Name = "cboConsMarca"
        Me.cboConsMarca.Size = New System.Drawing.Size(229, 33)
        Me.cboConsMarca.Sorted = True
        Me.cboConsMarca.TabIndex = 0
        Me.cboConsMarca.Visible = False
        '
        'frmConsMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(633, 814)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtConsMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgConsMarca)
        Me.Controls.Add(Me.cboConsMarca)
        Me.Controls.Add(Me.cboMarca)
        Me.Name = "frmConsMarcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Marcas"
        CType(Me.dgConsMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents dgConsMarca As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConsMarca As TextBox
    Friend WithEvents cboConsMarca As ComboBox
End Class
