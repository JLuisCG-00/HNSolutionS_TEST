<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.BtnGestion = New System.Windows.Forms.Button()
		Me.BtnInventario = New System.Windows.Forms.Button()
		Me.BtnFacturacion = New System.Windows.Forms.Button()
		Me.BtnVentas = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.BtnClientes = New System.Windows.Forms.Button()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Panel2.Controls.Add(Me.BtnGestion)
		Me.Panel2.Controls.Add(Me.BtnInventario)
		Me.Panel2.Controls.Add(Me.BtnFacturacion)
		Me.Panel2.Controls.Add(Me.BtnVentas)
		Me.Panel2.Controls.Add(Me.Label1)
		Me.Panel2.Controls.Add(Me.BtnClientes)
		Me.Panel2.Location = New System.Drawing.Point(17, 123)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(256, 708)
		Me.Panel2.TabIndex = 4
		'
		'BtnGestion
		'
		Me.BtnGestion.BackColor = System.Drawing.Color.White
		Me.BtnGestion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnGestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.BtnGestion.Location = New System.Drawing.Point(20, 355)
		Me.BtnGestion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnGestion.Name = "BtnGestion"
		Me.BtnGestion.Size = New System.Drawing.Size(217, 38)
		Me.BtnGestion.TabIndex = 10
		Me.BtnGestion.Text = "Gestión"
		Me.BtnGestion.UseVisualStyleBackColor = False
		'
		'BtnInventario
		'
		Me.BtnInventario.BackColor = System.Drawing.Color.White
		Me.BtnInventario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.BtnInventario.Location = New System.Drawing.Point(20, 283)
		Me.BtnInventario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnInventario.Name = "BtnInventario"
		Me.BtnInventario.Size = New System.Drawing.Size(217, 38)
		Me.BtnInventario.TabIndex = 9
		Me.BtnInventario.Text = "Inventario"
		Me.BtnInventario.UseVisualStyleBackColor = False
		'
		'BtnFacturacion
		'
		Me.BtnFacturacion.BackColor = System.Drawing.Color.White
		Me.BtnFacturacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnFacturacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.BtnFacturacion.Location = New System.Drawing.Point(20, 213)
		Me.BtnFacturacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnFacturacion.Name = "BtnFacturacion"
		Me.BtnFacturacion.Size = New System.Drawing.Size(217, 38)
		Me.BtnFacturacion.TabIndex = 8
		Me.BtnFacturacion.Text = "Facturación"
		Me.BtnFacturacion.UseVisualStyleBackColor = False
		'
		'BtnVentas
		'
		Me.BtnVentas.BackColor = System.Drawing.Color.White
		Me.BtnVentas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.BtnVentas.Location = New System.Drawing.Point(20, 147)
		Me.BtnVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnVentas.Name = "BtnVentas"
		Me.BtnVentas.Size = New System.Drawing.Size(217, 38)
		Me.BtnVentas.TabIndex = 7
		Me.BtnVentas.Text = "Ventas"
		Me.BtnVentas.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(34, 25)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(183, 27)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Importadora Noelia"
		'
		'BtnClientes
		'
		Me.BtnClientes.BackColor = System.Drawing.Color.White
		Me.BtnClientes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.BtnClientes.Location = New System.Drawing.Point(20, 82)
		Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnClientes.Name = "BtnClientes"
		Me.BtnClientes.Size = New System.Drawing.Size(217, 38)
		Me.BtnClientes.TabIndex = 5
		Me.BtnClientes.Text = "Clientes"
		Me.BtnClientes.UseVisualStyleBackColor = False
		'
		'MenuPrincipal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1628, 985)
		Me.Controls.Add(Me.Panel2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "MenuPrincipal"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MenuPrincipal"
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel2 As Panel
	Friend WithEvents BtnGestion As Button
	Friend WithEvents BtnInventario As Button
	Friend WithEvents BtnFacturacion As Button
	Friend WithEvents BtnVentas As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents BtnClientes As Button
End Class
