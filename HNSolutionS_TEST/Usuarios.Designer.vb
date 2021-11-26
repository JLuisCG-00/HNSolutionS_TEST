<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Txt_Usuario = New System.Windows.Forms.TextBox()
		Me.Txt_Contraseña = New System.Windows.Forms.TextBox()
		Me.Txt_Nombre = New System.Windows.Forms.TextBox()
		Me.Txt_Telefono = New System.Windows.Forms.TextBox()
		Me.Txt_Email = New System.Windows.Forms.TextBox()
		Me.BtnAnadir = New System.Windows.Forms.Button()
		Me.Btn_limpiar = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Txt_estado = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Btn_CancelarCliente = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.GroupBox1.SuspendLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(-1, -3)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(739, 62)
		Me.Label1.TabIndex = 23
		Me.Label1.Text = "REGUISTAR USUARIOS"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(104, 75)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(90, 24)
		Me.Label3.TabIndex = 25
		Me.Label3.Text = "Usuario:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(104, 140)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(126, 24)
		Me.Label4.TabIndex = 26
		Me.Label4.Text = "Contraseña:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(104, 200)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(91, 24)
		Me.Label5.TabIndex = 27
		Me.Label5.Text = "Nombre:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(103, 263)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(99, 24)
		Me.Label6.TabIndex = 28
		Me.Label6.Text = "Telefono:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(104, 332)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(68, 24)
		Me.Label7.TabIndex = 29
		Me.Label7.Text = "Email:"
		'
		'Txt_Usuario
		'
		Me.Txt_Usuario.Location = New System.Drawing.Point(323, 75)
		Me.Txt_Usuario.Name = "Txt_Usuario"
		Me.Txt_Usuario.Size = New System.Drawing.Size(230, 30)
		Me.Txt_Usuario.TabIndex = 31
		'
		'Txt_Contraseña
		'
		Me.Txt_Contraseña.Location = New System.Drawing.Point(323, 140)
		Me.Txt_Contraseña.Name = "Txt_Contraseña"
		Me.Txt_Contraseña.Size = New System.Drawing.Size(230, 30)
		Me.Txt_Contraseña.TabIndex = 32
		'
		'Txt_Nombre
		'
		Me.Txt_Nombre.Location = New System.Drawing.Point(323, 200)
		Me.Txt_Nombre.Name = "Txt_Nombre"
		Me.Txt_Nombre.Size = New System.Drawing.Size(230, 30)
		Me.Txt_Nombre.TabIndex = 33
		'
		'Txt_Telefono
		'
		Me.Txt_Telefono.Location = New System.Drawing.Point(323, 263)
		Me.Txt_Telefono.MaxLength = 8
		Me.Txt_Telefono.Name = "Txt_Telefono"
		Me.Txt_Telefono.Size = New System.Drawing.Size(230, 30)
		Me.Txt_Telefono.TabIndex = 34
		'
		'Txt_Email
		'
		Me.Txt_Email.Location = New System.Drawing.Point(323, 332)
		Me.Txt_Email.Name = "Txt_Email"
		Me.Txt_Email.Size = New System.Drawing.Size(230, 30)
		Me.Txt_Email.TabIndex = 35
		'
		'BtnAnadir
		'
		Me.BtnAnadir.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.BtnAnadir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnAnadir.Location = New System.Drawing.Point(167, 625)
		Me.BtnAnadir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnAnadir.Name = "BtnAnadir"
		Me.BtnAnadir.Size = New System.Drawing.Size(109, 38)
		Me.BtnAnadir.TabIndex = 38
		Me.BtnAnadir.Text = "Registrar"
		Me.BtnAnadir.UseVisualStyleBackColor = False
		'
		'Btn_limpiar
		'
		Me.Btn_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Btn_limpiar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_limpiar.Location = New System.Drawing.Point(443, 627)
		Me.Btn_limpiar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Btn_limpiar.Name = "Btn_limpiar"
		Me.Btn_limpiar.Size = New System.Drawing.Size(109, 38)
		Me.Btn_limpiar.TabIndex = 39
		Me.Btn_limpiar.Text = "Limpiar"
		Me.Btn_limpiar.UseVisualStyleBackColor = False
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(106, 393)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(83, 24)
		Me.Label8.TabIndex = 40
		Me.Label8.Text = "Estado:"
		'
		'Txt_estado
		'
		Me.Txt_estado.Location = New System.Drawing.Point(323, 393)
		Me.Txt_estado.Name = "Txt_estado"
		Me.Txt_estado.Size = New System.Drawing.Size(230, 30)
		Me.Txt_estado.TabIndex = 41
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.Txt_estado)
		Me.GroupBox1.Controls.Add(Me.Txt_Usuario)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Txt_Contraseña)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.Txt_Email)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Txt_Telefono)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Txt_Nombre)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.GroupBox1.Location = New System.Drawing.Point(11, 127)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(676, 490)
		Me.GroupBox1.TabIndex = 42
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Agregar Usuario"
		'
		'Btn_CancelarCliente
		'
		Me.Btn_CancelarCliente.BackColor = System.Drawing.Color.Red
		Me.Btn_CancelarCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_CancelarCliente.ForeColor = System.Drawing.Color.White
		Me.Btn_CancelarCliente.Location = New System.Drawing.Point(301, 625)
		Me.Btn_CancelarCliente.Name = "Btn_CancelarCliente"
		Me.Btn_CancelarCliente.Size = New System.Drawing.Size(111, 38)
		Me.Btn_CancelarCliente.TabIndex = 43
		Me.Btn_CancelarCliente.Text = "Cancelar"
		Me.Btn_CancelarCliente.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(211, 88)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(276, 27)
		Me.Label2.TabIndex = 44
		Me.Label2.Text = "IMPORTADORA NOELIA"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'Usuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(736, 687)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Btn_CancelarCliente)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Btn_limpiar)
		Me.Controls.Add(Me.BtnAnadir)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Usuarios"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Usuarios"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Txt_Usuario As TextBox
	Friend WithEvents Txt_Contraseña As TextBox
	Friend WithEvents Txt_Nombre As TextBox
	Friend WithEvents Txt_Telefono As TextBox
	Friend WithEvents Txt_Email As TextBox
	Friend WithEvents BtnAnadir As Button
	Friend WithEvents Btn_limpiar As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents Txt_estado As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Btn_CancelarCliente As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
