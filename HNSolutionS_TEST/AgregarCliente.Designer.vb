<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Gbx_Agregarclientes = New System.Windows.Forms.GroupBox()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Txt_DireccionCliente = New System.Windows.Forms.TextBox()
		Me.Txt_TelefonoCliente = New System.Windows.Forms.TextBox()
		Me.Txt_NombreAgregarcliente = New System.Windows.Forms.TextBox()
		Me.Txt_NumeroIdentidad = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Btn_CancelarCliente = New System.Windows.Forms.Button()
		Me.Btn_GuardaCliente = New System.Windows.Forms.Button()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.Gbx_Agregarclientes.SuspendLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Image = Global.HNSolutionS_TEST.My.Resources.Resources.clientes1
		Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label1.Location = New System.Drawing.Point(0, -4)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(751, 64)
		Me.Label1.TabIndex = 23
		Me.Label1.Text = "Clientes"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(240, 79)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(276, 27)
		Me.Label2.TabIndex = 24
		Me.Label2.Text = "IMPORTADORA NOELIA"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Gbx_Agregarclientes
		'
		Me.Gbx_Agregarclientes.Controls.Add(Me.txtCorreo)
		Me.Gbx_Agregarclientes.Controls.Add(Me.Label7)
		Me.Gbx_Agregarclientes.Controls.Add(Me.Txt_DireccionCliente)
		Me.Gbx_Agregarclientes.Controls.Add(Me.Txt_TelefonoCliente)
		Me.Gbx_Agregarclientes.Controls.Add(Me.Txt_NombreAgregarcliente)
		Me.Gbx_Agregarclientes.Controls.Add(Me.Txt_NumeroIdentidad)
		Me.Gbx_Agregarclientes.Controls.Add(Me.Label6)
		Me.Gbx_Agregarclientes.Controls.Add(Me.Label5)
		Me.Gbx_Agregarclientes.Controls.Add(Me.Label4)
		Me.Gbx_Agregarclientes.Controls.Add(Me.Label3)
		Me.Gbx_Agregarclientes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Gbx_Agregarclientes.Location = New System.Drawing.Point(11, 146)
		Me.Gbx_Agregarclientes.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Gbx_Agregarclientes.Name = "Gbx_Agregarclientes"
		Me.Gbx_Agregarclientes.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Gbx_Agregarclientes.Size = New System.Drawing.Size(728, 445)
		Me.Gbx_Agregarclientes.TabIndex = 25
		Me.Gbx_Agregarclientes.TabStop = False
		Me.Gbx_Agregarclientes.Text = "Agregar Cliente"
		'
		'txtCorreo
		'
		Me.txtCorreo.Location = New System.Drawing.Point(298, 385)
		Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(266, 30)
		Me.txtCorreo.TabIndex = 9
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(40, 390)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(82, 24)
		Me.Label7.TabIndex = 8
		Me.Label7.Text = "Correo:"
		'
		'Txt_DireccionCliente
		'
		Me.Txt_DireccionCliente.Location = New System.Drawing.Point(298, 261)
		Me.Txt_DireccionCliente.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Txt_DireccionCliente.Multiline = True
		Me.Txt_DireccionCliente.Name = "Txt_DireccionCliente"
		Me.Txt_DireccionCliente.Size = New System.Drawing.Size(266, 93)
		Me.Txt_DireccionCliente.TabIndex = 7
		'
		'Txt_TelefonoCliente
		'
		Me.Txt_TelefonoCliente.Location = New System.Drawing.Point(298, 194)
		Me.Txt_TelefonoCliente.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Txt_TelefonoCliente.MaxLength = 8
		Me.Txt_TelefonoCliente.Name = "Txt_TelefonoCliente"
		Me.Txt_TelefonoCliente.Size = New System.Drawing.Size(266, 30)
		Me.Txt_TelefonoCliente.TabIndex = 6
		'
		'Txt_NombreAgregarcliente
		'
		Me.Txt_NombreAgregarcliente.Location = New System.Drawing.Point(298, 119)
		Me.Txt_NombreAgregarcliente.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Txt_NombreAgregarcliente.Name = "Txt_NombreAgregarcliente"
		Me.Txt_NombreAgregarcliente.Size = New System.Drawing.Size(266, 30)
		Me.Txt_NombreAgregarcliente.TabIndex = 5
		'
		'Txt_NumeroIdentidad
		'
		Me.Txt_NumeroIdentidad.Location = New System.Drawing.Point(298, 49)
		Me.Txt_NumeroIdentidad.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Txt_NumeroIdentidad.MaxLength = 13
		Me.Txt_NumeroIdentidad.Name = "Txt_NumeroIdentidad"
		Me.Txt_NumeroIdentidad.Size = New System.Drawing.Size(274, 30)
		Me.Txt_NumeroIdentidad.TabIndex = 4
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(40, 261)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(106, 24)
		Me.Label6.TabIndex = 3
		Me.Label6.Text = "Dirección:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(40, 194)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(99, 24)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Teléfono:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(40, 119)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(91, 24)
		Me.Label4.TabIndex = 1
		Me.Label4.Text = "Nombre:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(40, 49)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(213, 24)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Numero de Identidad:"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Button1.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_clear_symbol_48
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button1.Location = New System.Drawing.Point(486, 616)
		Me.Button1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(178, 51)
		Me.Button1.TabIndex = 11
		Me.Button1.Text = "Limpiar"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Btn_CancelarCliente
		'
		Me.Btn_CancelarCliente.BackColor = System.Drawing.Color.Red
		Me.Btn_CancelarCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_CancelarCliente.ForeColor = System.Drawing.SystemColors.InfoText
		Me.Btn_CancelarCliente.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_cancel_48
		Me.Btn_CancelarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Btn_CancelarCliente.Location = New System.Drawing.Point(279, 616)
		Me.Btn_CancelarCliente.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Btn_CancelarCliente.Name = "Btn_CancelarCliente"
		Me.Btn_CancelarCliente.Size = New System.Drawing.Size(196, 51)
		Me.Btn_CancelarCliente.TabIndex = 10
		Me.Btn_CancelarCliente.Text = "Cancelar"
		Me.Btn_CancelarCliente.UseVisualStyleBackColor = False
		'
		'Btn_GuardaCliente
		'
		Me.Btn_GuardaCliente.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.Btn_GuardaCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_GuardaCliente.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_guardar_40
		Me.Btn_GuardaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Btn_GuardaCliente.Location = New System.Drawing.Point(100, 616)
		Me.Btn_GuardaCliente.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Btn_GuardaCliente.Name = "Btn_GuardaCliente"
		Me.Btn_GuardaCliente.Size = New System.Drawing.Size(175, 51)
		Me.Btn_GuardaCliente.TabIndex = 9
		Me.Btn_GuardaCliente.Text = "Guardar"
		Me.Btn_GuardaCliente.UseVisualStyleBackColor = False
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'AgregarCliente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(751, 679)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Gbx_Agregarclientes)
		Me.Controls.Add(Me.Btn_CancelarCliente)
		Me.Controls.Add(Me.Btn_GuardaCliente)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
		Me.Name = "AgregarCliente"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "AgregarCliente"
		Me.Gbx_Agregarclientes.ResumeLayout(False)
		Me.Gbx_Agregarclientes.PerformLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Gbx_Agregarclientes As GroupBox
	Friend WithEvents Btn_CancelarCliente As Button
	Friend WithEvents Btn_GuardaCliente As Button
	Friend WithEvents Txt_DireccionCliente As TextBox
	Friend WithEvents Txt_TelefonoCliente As TextBox
	Friend WithEvents Txt_NombreAgregarcliente As TextBox
	Friend WithEvents Txt_NumeroIdentidad As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Button1 As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
