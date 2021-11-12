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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Txt_Codigo = New System.Windows.Forms.TextBox()
		Me.Txt_Usuario = New System.Windows.Forms.TextBox()
		Me.Txt_Contraseña = New System.Windows.Forms.TextBox()
		Me.Txt_Nombre = New System.Windows.Forms.TextBox()
		Me.Txt_Telefono = New System.Windows.Forms.TextBox()
		Me.Txt_Email = New System.Windows.Forms.TextBox()
		Me.BtnRegistrar = New System.Windows.Forms.Button()
		Me.Bt_Limpiar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(-2, -4)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(548, 62)
		Me.Label1.TabIndex = 23
		Me.Label1.Text = "REGUISTAR USUARIOS"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(50, 113)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(71, 25)
		Me.Label2.TabIndex = 24
		Me.Label2.Text = "Codigo"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(50, 187)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(76, 25)
		Me.Label3.TabIndex = 25
		Me.Label3.Text = "Usuario:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(50, 247)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(105, 25)
		Me.Label4.TabIndex = 26
		Me.Label4.Text = "Contraseña:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(50, 312)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(82, 25)
		Me.Label5.TabIndex = 27
		Me.Label5.Text = "Nombre:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(50, 377)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(83, 25)
		Me.Label6.TabIndex = 28
		Me.Label6.Text = "Telefono:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(50, 431)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(58, 25)
		Me.Label7.TabIndex = 29
		Me.Label7.Text = "Email:"
		'
		'Txt_Codigo
		'
		Me.Txt_Codigo.Location = New System.Drawing.Point(175, 107)
		Me.Txt_Codigo.Name = "Txt_Codigo"
		Me.Txt_Codigo.Size = New System.Drawing.Size(230, 31)
		Me.Txt_Codigo.TabIndex = 30
		'
		'Txt_Usuario
		'
		Me.Txt_Usuario.Location = New System.Drawing.Point(175, 181)
		Me.Txt_Usuario.Name = "Txt_Usuario"
		Me.Txt_Usuario.Size = New System.Drawing.Size(230, 31)
		Me.Txt_Usuario.TabIndex = 31
		'
		'Txt_Contraseña
		'
		Me.Txt_Contraseña.Location = New System.Drawing.Point(175, 244)
		Me.Txt_Contraseña.Name = "Txt_Contraseña"
		Me.Txt_Contraseña.Size = New System.Drawing.Size(230, 31)
		Me.Txt_Contraseña.TabIndex = 32
		'
		'Txt_Nombre
		'
		Me.Txt_Nombre.Location = New System.Drawing.Point(175, 306)
		Me.Txt_Nombre.Name = "Txt_Nombre"
		Me.Txt_Nombre.Size = New System.Drawing.Size(230, 31)
		Me.Txt_Nombre.TabIndex = 33
		'
		'Txt_Telefono
		'
		Me.Txt_Telefono.Location = New System.Drawing.Point(175, 374)
		Me.Txt_Telefono.Name = "Txt_Telefono"
		Me.Txt_Telefono.Size = New System.Drawing.Size(230, 31)
		Me.Txt_Telefono.TabIndex = 34
		'
		'Txt_Email
		'
		Me.Txt_Email.Location = New System.Drawing.Point(175, 431)
		Me.Txt_Email.Name = "Txt_Email"
		Me.Txt_Email.Size = New System.Drawing.Size(230, 31)
		Me.Txt_Email.TabIndex = 35
		'
		'BtnRegistrar
		'
		Me.BtnRegistrar.Location = New System.Drawing.Point(134, 516)
		Me.BtnRegistrar.Name = "BtnRegistrar"
		Me.BtnRegistrar.Size = New System.Drawing.Size(112, 34)
		Me.BtnRegistrar.TabIndex = 36
		Me.BtnRegistrar.Text = "Registrar"
		Me.BtnRegistrar.UseVisualStyleBackColor = True
		'
		'Bt_Limpiar
		'
		Me.Bt_Limpiar.Location = New System.Drawing.Point(252, 516)
		Me.Bt_Limpiar.Name = "Bt_Limpiar"
		Me.Bt_Limpiar.Size = New System.Drawing.Size(112, 34)
		Me.Bt_Limpiar.TabIndex = 37
		Me.Bt_Limpiar.Text = "Limpiar"
		Me.Bt_Limpiar.UseVisualStyleBackColor = True
		'
		'Usuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(544, 671)
		Me.Controls.Add(Me.Bt_Limpiar)
		Me.Controls.Add(Me.BtnRegistrar)
		Me.Controls.Add(Me.Txt_Email)
		Me.Controls.Add(Me.Txt_Telefono)
		Me.Controls.Add(Me.Txt_Nombre)
		Me.Controls.Add(Me.Txt_Contraseña)
		Me.Controls.Add(Me.Txt_Usuario)
		Me.Controls.Add(Me.Txt_Codigo)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Usuarios"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Usuarios"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Txt_Codigo As TextBox
	Friend WithEvents Txt_Usuario As TextBox
	Friend WithEvents Txt_Contraseña As TextBox
	Friend WithEvents Txt_Nombre As TextBox
	Friend WithEvents Txt_Telefono As TextBox
	Friend WithEvents Txt_Email As TextBox
	Friend WithEvents BtnRegistrar As Button
	Friend WithEvents Bt_Limpiar As Button
End Class
