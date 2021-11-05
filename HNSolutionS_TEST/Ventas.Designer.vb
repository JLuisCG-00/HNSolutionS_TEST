<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
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
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Buscar = New System.Windows.Forms.Button()
		Me.agregar = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cocliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cancelar = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(27, 52)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(317, 31)
		Me.TextBox1.TabIndex = 0
		'
		'Buscar
		'
		Me.Buscar.BackColor = System.Drawing.Color.PaleTurquoise
		Me.Buscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Buscar.Location = New System.Drawing.Point(354, 52)
		Me.Buscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Buscar.Name = "Buscar"
		Me.Buscar.Size = New System.Drawing.Size(107, 38)
		Me.Buscar.TabIndex = 1
		Me.Buscar.Text = "Buscar"
		Me.Buscar.UseVisualStyleBackColor = False
		'
		'agregar
		'
		Me.agregar.BackColor = System.Drawing.Color.PaleGreen
		Me.agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.agregar.Location = New System.Drawing.Point(687, 162)
		Me.agregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.agregar.Name = "agregar"
		Me.agregar.Size = New System.Drawing.Size(107, 38)
		Me.agregar.TabIndex = 3
		Me.agregar.Text = "Añadir V."
		Me.agregar.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(0, -2)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(1017, 63)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "VENTAS"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(379, 62)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(276, 27)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "IMPORTADORA NOELIA"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.factura, Me.Cantidad, Me.cocliente, Me.telefono, Me.Direccion, Me.descripcion})
		Me.DataGridView1.Location = New System.Drawing.Point(54, 272)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersWidth = 62
		Me.DataGridView1.RowTemplate.Height = 25
		Me.DataGridView1.Size = New System.Drawing.Size(919, 250)
		Me.DataGridView1.TabIndex = 13
		'
		'factura
		'
		Me.factura.HeaderText = "No. Factura"
		Me.factura.MinimumWidth = 8
		Me.factura.Name = "factura"
		Me.factura.Width = 150
		'
		'Cantidad
		'
		Me.Cantidad.HeaderText = "Cantidad"
		Me.Cantidad.MinimumWidth = 8
		Me.Cantidad.Name = "Cantidad"
		Me.Cantidad.Width = 150
		'
		'cocliente
		'
		Me.cocliente.HeaderText = "Co. Cliente"
		Me.cocliente.MinimumWidth = 8
		Me.cocliente.Name = "cocliente"
		Me.cocliente.Width = 150
		'
		'telefono
		'
		Me.telefono.HeaderText = "No. Telefono"
		Me.telefono.MinimumWidth = 8
		Me.telefono.Name = "telefono"
		Me.telefono.Width = 150
		'
		'Direccion
		'
		Me.Direccion.HeaderText = "Direccion"
		Me.Direccion.MinimumWidth = 8
		Me.Direccion.Name = "Direccion"
		Me.Direccion.Width = 150
		'
		'descripcion
		'
		Me.descripcion.HeaderText = "Descripcion"
		Me.descripcion.MinimumWidth = 8
		Me.descripcion.Name = "descripcion"
		Me.descripcion.Width = 150
		'
		'Cancelar
		'
		Me.Cancelar.BackColor = System.Drawing.Color.Tomato
		Me.Cancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Cancelar.Location = New System.Drawing.Point(837, 162)
		Me.Cancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Cancelar.Name = "Cancelar"
		Me.Cancelar.Size = New System.Drawing.Size(107, 38)
		Me.Cancelar.TabIndex = 14
		Me.Cancelar.Text = "Cancelar"
		Me.Cancelar.UseVisualStyleBackColor = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.Buscar)
		Me.GroupBox1.Location = New System.Drawing.Point(84, 112)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox1.Size = New System.Drawing.Size(491, 125)
		Me.GroupBox1.TabIndex = 15
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Buscar Ventas"
		'
		'Ventas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1016, 645)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Cancelar)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.agregar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "Ventas"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Ventas"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents agregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents factura As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents cocliente As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
