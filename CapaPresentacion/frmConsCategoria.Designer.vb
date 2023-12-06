<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsCategoria
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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgCategorias = New System.Windows.Forms.DataGridView()
        Me.cboCategorias = New System.Windows.Forms.ComboBox()
        Me.txtCategorias = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtRegistros = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Red
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.Enabled = False
        Me.btnConsultar.Font = New System.Drawing.Font("Arvo", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(665, 87)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(216, 53)
        Me.btnConsultar.TabIndex = 0
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arvo", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(314, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consultar Categorías"
        '
        'dgCategorias
        '
        Me.dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCategorias.BackgroundColor = System.Drawing.Color.White
        Me.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCategorias.Location = New System.Drawing.Point(12, 169)
        Me.dgCategorias.Name = "dgCategorias"
        Me.dgCategorias.ReadOnly = True
        Me.dgCategorias.RowHeadersWidth = 51
        Me.dgCategorias.RowTemplate.Height = 24
        Me.dgCategorias.Size = New System.Drawing.Size(869, 383)
        Me.dgCategorias.TabIndex = 2
        '
        'cboCategorias
        '
        Me.cboCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategorias.FormattingEnabled = True
        Me.cboCategorias.Items.AddRange(New Object() {"IdCategorias", "Concepto"})
        Me.cboCategorias.Location = New System.Drawing.Point(12, 97)
        Me.cboCategorias.Name = "cboCategorias"
        Me.cboCategorias.Size = New System.Drawing.Size(171, 33)
        Me.cboCategorias.TabIndex = 3
        '
        'txtCategorias
        '
        Me.txtCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategorias.Location = New System.Drawing.Point(212, 97)
        Me.txtCategorias.Name = "txtCategorias"
        Me.txtCategorias.Size = New System.Drawing.Size(432, 30)
        Me.txtCategorias.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Yellow
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Arvo", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(354, 573)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(527, 53)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtRegistros
        '
        Me.txtRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistros.Location = New System.Drawing.Point(236, 573)
        Me.txtRegistros.Name = "txtRegistros"
        Me.txtRegistros.Size = New System.Drawing.Size(89, 30)
        Me.txtRegistros.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arvo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 580)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Registros Encontrados"
        '
        'frmConsCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(893, 638)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtRegistros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtCategorias)
        Me.Controls.Add(Me.cboCategorias)
        Me.Controls.Add(Me.dgCategorias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Name = "frmConsCategoria"
        Me.Opacity = 0.92R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsCategoria"
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConsultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgCategorias As DataGridView
    Friend WithEvents cboCategorias As ComboBox
    Friend WithEvents txtCategorias As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtRegistros As TextBox
    Friend WithEvents Label2 As Label
End Class
