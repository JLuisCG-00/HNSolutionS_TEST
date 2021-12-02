<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProducto
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Btn_CancelarCliente = New System.Windows.Forms.Button()
		Me.Btn_Limpiar = New System.Windows.Forms.Button()
		Me.Btn_GuardaInventa = New System.Windows.Forms.Button()
		Me.Txt_StockMaximo = New System.Windows.Forms.TextBox()
		Me.Txt_StockMinimo = New System.Windows.Forms.TextBox()
		Me.Txt_Strock = New System.Windows.Forms.TextBox()
		Me.Txt_Nombre = New System.Windows.Forms.TextBox()
		Me.Txt_codigo = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Image = Global.HNSolutionS_TEST.My.Resources.Resources.producto2
		Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label1.Location = New System.Drawing.Point(1, -2)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(894, 62)
		Me.Label1.TabIndex = 24
		Me.Label1.Text = "Agregar Inventario"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Btn_CancelarCliente)
		Me.GroupBox1.Controls.Add(Me.Btn_Limpiar)
		Me.GroupBox1.Controls.Add(Me.Btn_GuardaInventa)
		Me.GroupBox1.Controls.Add(Me.Txt_StockMaximo)
		Me.GroupBox1.Controls.Add(Me.Txt_StockMinimo)
		Me.GroupBox1.Controls.Add(Me.Txt_Strock)
		Me.GroupBox1.Controls.Add(Me.Txt_Nombre)
		Me.GroupBox1.Controls.Add(Me.Txt_codigo)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.GroupBox1.Location = New System.Drawing.Point(71, 142)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
		Me.GroupBox1.Size = New System.Drawing.Size(806, 532)
		Me.GroupBox1.TabIndex = 25
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Agregar Producto:"
		'
		'Btn_CancelarCliente
		'
		Me.Btn_CancelarCliente.BackColor = System.Drawing.Color.Red
		Me.Btn_CancelarCliente.ForeColor = System.Drawing.Color.Black
		Me.Btn_CancelarCliente.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_cancel_48
		Me.Btn_CancelarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Btn_CancelarCliente.Location = New System.Drawing.Point(319, 432)
		Me.Btn_CancelarCliente.Margin = New System.Windows.Forms.Padding(2)
		Me.Btn_CancelarCliente.Name = "Btn_CancelarCliente"
		Me.Btn_CancelarCliente.Size = New System.Drawing.Size(182, 52)
		Me.Btn_CancelarCliente.TabIndex = 13
		Me.Btn_CancelarCliente.Text = "Cancelar"
		Me.Btn_CancelarCliente.UseVisualStyleBackColor = False
		'
		'Btn_Limpiar
		'
		Me.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Btn_Limpiar.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_clear_symbol_48
		Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Btn_Limpiar.Location = New System.Drawing.Point(521, 432)
		Me.Btn_Limpiar.Margin = New System.Windows.Forms.Padding(2)
		Me.Btn_Limpiar.Name = "Btn_Limpiar"
		Me.Btn_Limpiar.Size = New System.Drawing.Size(181, 52)
		Me.Btn_Limpiar.TabIndex = 12
		Me.Btn_Limpiar.Text = "Limpiar"
		Me.Btn_Limpiar.UseVisualStyleBackColor = False
		'
		'Btn_GuardaInventa
		'
		Me.Btn_GuardaInventa.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.Btn_GuardaInventa.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_guardar_40
		Me.Btn_GuardaInventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Btn_GuardaInventa.Location = New System.Drawing.Point(113, 432)
		Me.Btn_GuardaInventa.Margin = New System.Windows.Forms.Padding(2)
		Me.Btn_GuardaInventa.Name = "Btn_GuardaInventa"
		Me.Btn_GuardaInventa.Size = New System.Drawing.Size(192, 52)
		Me.Btn_GuardaInventa.TabIndex = 11
		Me.Btn_GuardaInventa.Text = "Guardar"
		Me.Btn_GuardaInventa.UseVisualStyleBackColor = False
		'
		'Txt_StockMaximo
		'
		Me.Txt_StockMaximo.Location = New System.Drawing.Point(319, 348)
		Me.Txt_StockMaximo.Margin = New System.Windows.Forms.Padding(2)
		Me.Txt_StockMaximo.Name = "Txt_StockMaximo"
		Me.Txt_StockMaximo.Size = New System.Drawing.Size(253, 30)
		Me.Txt_StockMaximo.TabIndex = 10
		'
		'Txt_StockMinimo
		'
		Me.Txt_StockMinimo.Location = New System.Drawing.Point(319, 278)
		Me.Txt_StockMinimo.Margin = New System.Windows.Forms.Padding(2)
		Me.Txt_StockMinimo.Name = "Txt_StockMinimo"
		Me.Txt_StockMinimo.Size = New System.Drawing.Size(253, 30)
		Me.Txt_StockMinimo.TabIndex = 9
		'
		'Txt_Strock
		'
		Me.Txt_Strock.Location = New System.Drawing.Point(319, 202)
		Me.Txt_Strock.Margin = New System.Windows.Forms.Padding(2)
		Me.Txt_Strock.Name = "Txt_Strock"
		Me.Txt_Strock.Size = New System.Drawing.Size(253, 30)
		Me.Txt_Strock.TabIndex = 8
		'
		'Txt_Nombre
		'
		Me.Txt_Nombre.Location = New System.Drawing.Point(319, 122)
		Me.Txt_Nombre.Margin = New System.Windows.Forms.Padding(2)
		Me.Txt_Nombre.Name = "Txt_Nombre"
		Me.Txt_Nombre.Size = New System.Drawing.Size(253, 30)
		Me.Txt_Nombre.TabIndex = 7
		'
		'Txt_codigo
		'
		Me.Txt_codigo.Location = New System.Drawing.Point(319, 52)
		Me.Txt_codigo.Margin = New System.Windows.Forms.Padding(2)
		Me.Txt_codigo.Name = "Txt_codigo"
		Me.Txt_codigo.Size = New System.Drawing.Size(253, 30)
		Me.Txt_codigo.TabIndex = 6
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(81, 278)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(146, 24)
		Me.Label8.TabIndex = 5
		Me.Label8.Text = "Stock mínimo:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(81, 348)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(150, 24)
		Me.Label6.TabIndex = 3
		Me.Label6.Text = "Stock máximo:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(81, 208)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(71, 24)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Stock:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(81, 128)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(91, 24)
		Me.Label4.TabIndex = 1
		Me.Label4.Text = "Nombre:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(81, 58)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(84, 24)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Código:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(390, 88)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(276, 27)
		Me.Label2.TabIndex = 26
		Me.Label2.Text = "IMPORTADORA NOELIA"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AgregarProducto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(896, 685)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "AgregarProducto"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "AgregarProducto"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Txt_StockMaximo As TextBox
	Friend WithEvents Txt_StockMinimo As TextBox
	Friend WithEvents Txt_Strock As TextBox
	Friend WithEvents Txt_Nombre As TextBox
	Friend WithEvents Txt_codigo As TextBox
	Friend WithEvents Btn_GuardaInventa As Button
	Friend WithEvents Btn_Limpiar As Button
	Friend WithEvents Btn_CancelarCliente As Button
End Class
