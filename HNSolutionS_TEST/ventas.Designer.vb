<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventas
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Btn_Cancelar = New System.Windows.Forms.Button()
		Me.Btn_Imprimir = New System.Windows.Forms.Button()
		Me.Btn_Nuevo = New System.Windows.Forms.Button()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Txt_DireccionCliente = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Btn_Cancelar)
		Me.GroupBox1.Controls.Add(Me.Btn_Imprimir)
		Me.GroupBox1.Controls.Add(Me.Btn_Nuevo)
		Me.GroupBox1.Controls.Add(Me.TextBox3)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Txt_DireccionCliente)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.GroupBox1.Location = New System.Drawing.Point(61, 116)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(588, 509)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Ventas:"
		'
		'Btn_Cancelar
		'
		Me.Btn_Cancelar.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.Btn_Cancelar.Location = New System.Drawing.Point(264, 415)
		Me.Btn_Cancelar.Name = "Btn_Cancelar"
		Me.Btn_Cancelar.Size = New System.Drawing.Size(111, 52)
		Me.Btn_Cancelar.TabIndex = 16
		Me.Btn_Cancelar.Text = "Cancelar"
		Me.Btn_Cancelar.UseVisualStyleBackColor = False
		'
		'Btn_Imprimir
		'
		Me.Btn_Imprimir.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.Btn_Imprimir.Location = New System.Drawing.Point(445, 415)
		Me.Btn_Imprimir.Name = "Btn_Imprimir"
		Me.Btn_Imprimir.Size = New System.Drawing.Size(111, 52)
		Me.Btn_Imprimir.TabIndex = 15
		Me.Btn_Imprimir.Text = "Imprimir"
		Me.Btn_Imprimir.UseVisualStyleBackColor = False
		'
		'Btn_Nuevo
		'
		Me.Btn_Nuevo.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.Btn_Nuevo.Location = New System.Drawing.Point(99, 415)
		Me.Btn_Nuevo.Name = "Btn_Nuevo"
		Me.Btn_Nuevo.Size = New System.Drawing.Size(111, 52)
		Me.Btn_Nuevo.TabIndex = 14
		Me.Btn_Nuevo.Text = "Nuevo"
		Me.Btn_Nuevo.UseVisualStyleBackColor = False
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(228, 350)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(292, 30)
		Me.TextBox3.TabIndex = 13
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(41, 353)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(169, 24)
		Me.Label4.TabIndex = 12
		Me.Label4.Text = "Numero Factura:"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(282, 265)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(197, 30)
		Me.TextBox2.TabIndex = 11
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(185, 265)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(91, 30)
		Me.TextBox1.TabIndex = 10
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(30, 265)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(82, 24)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Cliente:"
		'
		'Txt_DireccionCliente
		'
		Me.Txt_DireccionCliente.Location = New System.Drawing.Point(185, 126)
		Me.Txt_DireccionCliente.Multiline = True
		Me.Txt_DireccionCliente.Name = "Txt_DireccionCliente"
		Me.Txt_DireccionCliente.Size = New System.Drawing.Size(305, 92)
		Me.Txt_DireccionCliente.TabIndex = 8
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(30, 129)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(129, 24)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Descripcion:"
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(185, 50)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(305, 30)
		Me.DateTimePicker1.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(30, 56)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 24)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Fecha:"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.TextBox5)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.TextBox4)
		Me.GroupBox2.Controls.Add(Me.ComboBox1)
		Me.GroupBox2.Controls.Add(Me.DataGridView1)
		Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.GroupBox2.Location = New System.Drawing.Point(718, 119)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(617, 506)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Articulos:"
		'
		'TextBox5
		'
		Me.TextBox5.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.TextBox5.Location = New System.Drawing.Point(441, 423)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(95, 30)
		Me.TextBox5.TabIndex = 4
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(371, 426)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(64, 24)
		Me.Label5.TabIndex = 3
		Me.Label5.Text = "Total:"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(279, 47)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(304, 30)
		Me.TextBox4.TabIndex = 2
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(29, 53)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(182, 32)
		Me.ComboBox1.TabIndex = 1
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(29, 126)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersWidth = 62
		Me.DataGridView1.RowTemplate.Height = 33
		Me.DataGridView1.Size = New System.Drawing.Size(568, 225)
		Me.DataGridView1.TabIndex = 0
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(2, -3)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(1399, 63)
		Me.Label6.TabIndex = 24
		Me.Label6.Text = "Ventas"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label7.Location = New System.Drawing.Point(544, 86)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(276, 27)
		Me.Label7.TabIndex = 25
		Me.Label7.Text = "IMPORTADORA NOELIA"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ventas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1398, 670)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "ventas"
		Me.Text = "ventas"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Txt_DireccionCliente As TextBox
	Friend WithEvents Btn_Cancelar As Button
	Friend WithEvents Btn_Imprimir As Button
	Friend WithEvents Btn_Nuevo As Button
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
End Class
