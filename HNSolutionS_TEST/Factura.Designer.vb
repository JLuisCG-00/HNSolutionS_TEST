<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.Gbx_Datosclientes = New System.Windows.Forms.GroupBox()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.TxtNumeroId = New System.Windows.Forms.TextBox()
        Me.TxtnombreClientes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lbl_Total = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Lbx_Sub_Total = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Lbx_Cantidad = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Lbx_Precio = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Lbx_Producto = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDescriccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbxPago = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbxVendedor = New System.Windows.Forms.ComboBox()
        Me.Btn_LimpiarV = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cbx_productos = New System.Windows.Forms.ComboBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Gbx_Datosclientes.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gbx_Datosclientes
        '
        Me.Gbx_Datosclientes.Controls.Add(Me.Btn_Limpiar)
        Me.Gbx_Datosclientes.Controls.Add(Me.TxtNumeroId)
        Me.Gbx_Datosclientes.Controls.Add(Me.TxtnombreClientes)
        Me.Gbx_Datosclientes.Controls.Add(Me.Label3)
        Me.Gbx_Datosclientes.Controls.Add(Me.Label1)
        Me.Gbx_Datosclientes.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Gbx_Datosclientes.Location = New System.Drawing.Point(84, 52)
        Me.Gbx_Datosclientes.Margin = New System.Windows.Forms.Padding(2)
        Me.Gbx_Datosclientes.Name = "Gbx_Datosclientes"
        Me.Gbx_Datosclientes.Padding = New System.Windows.Forms.Padding(2)
        Me.Gbx_Datosclientes.Size = New System.Drawing.Size(694, 129)
=======
        Me.Gbx_Datosclientes.Location = New System.Drawing.Point(13, 113)
        Me.Gbx_Datosclientes.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Gbx_Datosclientes.Name = "Gbx_Datosclientes"
        Me.Gbx_Datosclientes.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Gbx_Datosclientes.Size = New System.Drawing.Size(791, 140)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Gbx_Datosclientes.TabIndex = 0
        Me.Gbx_Datosclientes.TabStop = False
        Me.Gbx_Datosclientes.Text = "Datos del Cliente:"
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Btn_Limpiar.Location = New System.Drawing.Point(494, 70)
        Me.Btn_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(98, 25)
=======
        Me.Btn_Limpiar.Location = New System.Drawing.Point(551, 66)
        Me.Btn_Limpiar.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(112, 34)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Btn_Limpiar.TabIndex = 6
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'TxtNumeroId
        '
        Me.TxtNumeroId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.TxtNumeroId.Location = New System.Drawing.Point(201, 104)
        Me.TxtNumeroId.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumeroId.Name = "TxtNumeroId"
        Me.TxtNumeroId.Size = New System.Drawing.Size(174, 23)
        Me.TxtNumeroId.TabIndex = 5
        '
        'TxtDirrecion
        '
        Me.TxtDirrecion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtDirrecion.Location = New System.Drawing.Point(201, 70)
        Me.TxtDirrecion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDirrecion.Name = "TxtDirrecion"
        Me.TxtDirrecion.Size = New System.Drawing.Size(174, 23)
        Me.TxtDirrecion.TabIndex = 4
        '
        'TxtDatosClientes
        '
        Me.TxtDatosClientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtDatosClientes.Location = New System.Drawing.Point(201, 36)
        Me.TxtDatosClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDatosClientes.Name = "TxtDatosClientes"
        Me.TxtDatosClientes.Size = New System.Drawing.Size(174, 23)
        Me.TxtDatosClientes.TabIndex = 3
=======
        Me.TxtNumeroId.Location = New System.Drawing.Point(231, 90)
        Me.TxtNumeroId.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.TxtNumeroId.Name = "TxtNumeroId"
        Me.TxtNumeroId.Size = New System.Drawing.Size(197, 27)
        Me.TxtNumeroId.TabIndex = 5
        '
        'TxtnombreClientes
        '
        Me.TxtnombreClientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtnombreClientes.Location = New System.Drawing.Point(231, 48)
        Me.TxtnombreClientes.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.TxtnombreClientes.Name = "TxtnombreClientes"
        Me.TxtnombreClientes.Size = New System.Drawing.Size(197, 27)
        Me.TxtnombreClientes.TabIndex = 3
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label3.Location = New System.Drawing.Point(38, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero Identidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dirreccion:"
=======
        Me.Label3.Location = New System.Drawing.Point(41, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero de identidad:"
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label1.Location = New System.Drawing.Point(37, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
=======
        Me.Label1.Location = New System.Drawing.Point(43, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_Nuevo)
        Me.GroupBox3.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox3.Controls.Add(Me.Btn_Guardar)
        Me.GroupBox3.Controls.Add(Me.Lbl_Total)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Lbx_Sub_Total)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Lbx_Cantidad)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Lbx_Precio)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Lbx_Producto)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.GroupBox3.Location = New System.Drawing.Point(84, 418)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(694, 206)
=======
        Me.GroupBox3.Location = New System.Drawing.Point(14, 512)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(791, 274)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Detalle"
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Btn_Nuevo.Location = New System.Drawing.Point(610, 164)
        Me.Btn_Nuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(79, 28)
=======
        Me.Btn_Nuevo.Location = New System.Drawing.Point(697, 218)
        Me.Btn_Nuevo.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(89, 38)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Btn_Nuevo.TabIndex = 12
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Red
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Btn_Cancelar.Location = New System.Drawing.Point(527, 164)
        Me.Btn_Cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(79, 28)
=======
        Me.Btn_Cancelar.Location = New System.Drawing.Point(601, 218)
        Me.Btn_Cancelar.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(89, 38)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Btn_Cancelar.TabIndex = 11
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Btn_Guardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Btn_Guardar.Location = New System.Drawing.Point(444, 164)
        Me.Btn_Guardar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(79, 28)
=======
        Me.Btn_Guardar.Location = New System.Drawing.Point(507, 218)
        Me.Btn_Guardar.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(89, 38)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Btn_Guardar.TabIndex = 10
        Me.Btn_Guardar.Text = "Vender"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Lbl_Total
        '
        Me.Lbl_Total.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Lbl_Total.Location = New System.Drawing.Point(514, 80)
        Me.Lbl_Total.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.Lbl_Total.Location = New System.Drawing.Point(586, 74)
        Me.Lbl_Total.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(106, 32)
        Me.Lbl_Total.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label16.Location = New System.Drawing.Point(536, 49)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label16.Location = New System.Drawing.Point(612, 36)
        Me.Label16.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 25)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Total"
        '
        'Lbx_Sub_Total
        '
        Me.Lbx_Sub_Total.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbx_Sub_Total.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbx_Sub_Total.FormattingEnabled = True
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Lbx_Sub_Total.Location = New System.Drawing.Point(334, 56)
        Me.Lbx_Sub_Total.Margin = New System.Windows.Forms.Padding(2)
        Me.Lbx_Sub_Total.Name = "Lbx_Sub_Total"
        Me.Lbx_Sub_Total.Size = New System.Drawing.Size(89, 108)
=======
        Me.Lbx_Sub_Total.ItemHeight = 17
        Me.Lbx_Sub_Total.Location = New System.Drawing.Point(383, 74)
        Me.Lbx_Sub_Total.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Lbx_Sub_Total.Name = "Lbx_Sub_Total"
        Me.Lbx_Sub_Total.Size = New System.Drawing.Size(101, 123)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Lbx_Sub_Total.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label15.Location = New System.Drawing.Point(341, 34)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label15.Location = New System.Drawing.Point(391, 46)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 16)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Sub_Total:"
        '
        'Lbx_Cantidad
        '
        Me.Lbx_Cantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbx_Cantidad.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbx_Cantidad.FormattingEnabled = True
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Lbx_Cantidad.Location = New System.Drawing.Point(227, 56)
        Me.Lbx_Cantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.Lbx_Cantidad.Name = "Lbx_Cantidad"
        Me.Lbx_Cantidad.Size = New System.Drawing.Size(83, 108)
=======
        Me.Lbx_Cantidad.ItemHeight = 17
        Me.Lbx_Cantidad.Location = New System.Drawing.Point(271, 74)
        Me.Lbx_Cantidad.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Lbx_Cantidad.Name = "Lbx_Cantidad"
        Me.Lbx_Cantidad.Size = New System.Drawing.Size(93, 123)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Lbx_Cantidad.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label14.Location = New System.Drawing.Point(236, 34)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label14.Location = New System.Drawing.Point(271, 46)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Cantidad:"
        '
        'Lbx_Precio
        '
        Me.Lbx_Precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbx_Precio.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbx_Precio.FormattingEnabled = True
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Lbx_Precio.Location = New System.Drawing.Point(148, 56)
        Me.Lbx_Precio.Margin = New System.Windows.Forms.Padding(2)
        Me.Lbx_Precio.Name = "Lbx_Precio"
        Me.Lbx_Precio.Size = New System.Drawing.Size(68, 108)
=======
        Me.Lbx_Precio.ItemHeight = 17
        Me.Lbx_Precio.Location = New System.Drawing.Point(169, 74)
        Me.Lbx_Precio.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Lbx_Precio.Name = "Lbx_Precio"
        Me.Lbx_Precio.Size = New System.Drawing.Size(77, 123)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Lbx_Precio.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label13.Location = New System.Drawing.Point(158, 34)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label13.Location = New System.Drawing.Point(169, 46)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Precio:"
        '
        'Lbx_Producto
        '
        Me.Lbx_Producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbx_Producto.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbx_Producto.FormattingEnabled = True
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Lbx_Producto.Location = New System.Drawing.Point(30, 56)
        Me.Lbx_Producto.Margin = New System.Windows.Forms.Padding(2)
        Me.Lbx_Producto.Name = "Lbx_Producto"
        Me.Lbx_Producto.Size = New System.Drawing.Size(100, 108)
=======
        Me.Lbx_Producto.ItemHeight = 17
        Me.Lbx_Producto.Location = New System.Drawing.Point(33, 74)
        Me.Lbx_Producto.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Lbx_Producto.Name = "Lbx_Producto"
        Me.Lbx_Producto.Size = New System.Drawing.Size(115, 123)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Lbx_Producto.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label12.Location = New System.Drawing.Point(30, 34)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label12.Location = New System.Drawing.Point(33, 46)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Productos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label4.Location = New System.Drawing.Point(37, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label4.Location = New System.Drawing.Point(41, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Pruducto:"
        '
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        'TxtProducto
        '
        Me.TxtProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtProducto.Location = New System.Drawing.Point(127, 50)
        Me.TxtProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(166, 23)
        Me.TxtProducto.TabIndex = 1
        '
=======
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label5.Location = New System.Drawing.Point(37, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
=======
        Me.Label5.Location = New System.Drawing.Point(41, 178)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Descripción:"
        '
        'TxtDescriccion
        '
        Me.TxtDescriccion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.TxtDescriccion.Location = New System.Drawing.Point(127, 82)
        Me.TxtDescriccion.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.TxtDescriccion.Location = New System.Drawing.Point(154, 174)
        Me.TxtDescriccion.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.TxtDescriccion.Name = "TxtDescriccion"
        Me.TxtDescriccion.Size = New System.Drawing.Size(166, 23)
        Me.TxtDescriccion.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label6.Location = New System.Drawing.Point(37, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label6.Location = New System.Drawing.Point(41, 219)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cantidad:"
        '
        'Txt_cantidad
        '
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(127, 111)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(106, 23)
        Me.TextBox1.TabIndex = 5
=======
        Me.Txt_cantidad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_cantidad.Location = New System.Drawing.Point(154, 215)
        Me.Txt_cantidad.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Txt_cantidad.Name = "Txt_cantidad"
        Me.Txt_cantidad.Size = New System.Drawing.Size(121, 27)
        Me.Txt_cantidad.TabIndex = 5
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label7.Location = New System.Drawing.Point(421, 50)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label7.Location = New System.Drawing.Point(40, 51)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Categoria:"
        '
        'CbxCategoria
        '
        Me.CbxCategoria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CbxCategoria.FormattingEnabled = True
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.CbxCategoria.Location = New System.Drawing.Point(542, 48)
        Me.CbxCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxCategoria.Name = "CbxCategoria"
        Me.CbxCategoria.Size = New System.Drawing.Size(128, 23)
=======
        Me.CbxCategoria.Location = New System.Drawing.Point(153, 47)
        Me.CbxCategoria.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.CbxCategoria.Name = "CbxCategoria"
        Me.CbxCategoria.Size = New System.Drawing.Size(147, 28)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.CbxCategoria.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label8.Location = New System.Drawing.Point(421, 80)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label8.Location = New System.Drawing.Point(41, 142)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Precio:"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.TxtPrecio.Location = New System.Drawing.Point(542, 82)
        Me.TxtPrecio.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.TxtPrecio.Location = New System.Drawing.Point(154, 138)
        Me.TxtPrecio.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(98, 23)
        Me.TxtPrecio.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label9.Location = New System.Drawing.Point(421, 112)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 16)
=======
        Me.Label9.Location = New System.Drawing.Point(481, 56)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 19)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Forma de pago:"
        '
        'CbxPago
        '
        Me.CbxPago.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CbxPago.FormattingEnabled = True
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.CbxPago.Location = New System.Drawing.Point(542, 112)
        Me.CbxPago.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxPago.Name = "CbxPago"
        Me.CbxPago.Size = New System.Drawing.Size(128, 23)
=======
        Me.CbxPago.Items.AddRange(New Object() {"Credito", "Contado"})
        Me.CbxPago.Location = New System.Drawing.Point(629, 50)
        Me.CbxPago.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.CbxPago.Name = "CbxPago"
        Me.CbxPago.Size = New System.Drawing.Size(147, 28)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.CbxPago.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(38, 152)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 16)
=======
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(482, 55)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 19)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Location = New System.Drawing.Point(127, 152)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 23)
=======
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Location = New System.Drawing.Point(564, 50)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(241, 25)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label11.Location = New System.Drawing.Point(421, 148)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.Label11.Location = New System.Drawing.Point(500, 110)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Vendedor:"
        '
        'CbxVendedor
        '
        Me.CbxVendedor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CbxVendedor.FormattingEnabled = True
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.CbxVendedor.Location = New System.Drawing.Point(542, 148)
        Me.CbxVendedor.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxVendedor.Name = "CbxVendedor"
        Me.CbxVendedor.Size = New System.Drawing.Size(128, 23)
=======
        Me.CbxVendedor.Location = New System.Drawing.Point(629, 106)
        Me.CbxVendedor.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.CbxVendedor.Name = "CbxVendedor"
        Me.CbxVendedor.Size = New System.Drawing.Size(147, 28)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.CbxVendedor.TabIndex = 15
        '
        'Btn_LimpiarV
        '
        Me.Btn_LimpiarV.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_LimpiarV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Btn_LimpiarV.Location = New System.Drawing.Point(261, 184)
        Me.Btn_LimpiarV.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_LimpiarV.Name = "Btn_LimpiarV"
        Me.Btn_LimpiarV.Size = New System.Drawing.Size(89, 28)
=======
        Me.Btn_LimpiarV.Location = New System.Drawing.Point(544, 202)
        Me.Btn_LimpiarV.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Btn_LimpiarV.Name = "Btn_LimpiarV"
        Me.Btn_LimpiarV.Size = New System.Drawing.Size(103, 38)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Btn_LimpiarV.TabIndex = 16
        Me.Btn_LimpiarV.Text = "Limpiar"
        Me.Btn_LimpiarV.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cbx_productos)
        Me.GroupBox1.Controls.Add(Me.Btn_Agregar)
        Me.GroupBox1.Controls.Add(Me.Btn_LimpiarV)
        Me.GroupBox1.Controls.Add(Me.CbxVendedor)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CbxPago)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CbxCategoria)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtDescriccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.GroupBox1.Location = New System.Drawing.Point(84, 185)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(694, 221)
=======
        Me.GroupBox1.Location = New System.Drawing.Point(13, 256)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(791, 253)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Venta:"
        '
        'Cbx_productos
        '
        Me.Cbx_productos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Cbx_productos.FormattingEnabled = True
        Me.Cbx_productos.Location = New System.Drawing.Point(153, 98)
        Me.Cbx_productos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cbx_productos.Name = "Cbx_productos"
        Me.Cbx_productos.Size = New System.Drawing.Size(147, 28)
        Me.Cbx_productos.TabIndex = 18
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Btn_Agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Btn_Agregar.Location = New System.Drawing.Point(381, 184)
        Me.Btn_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(89, 28)
=======
        Me.Btn_Agregar.Location = New System.Drawing.Point(656, 202)
        Me.Btn_Agregar.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(103, 38)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Btn_Agregar.TabIndex = 17
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Label17.Location = New System.Drawing.Point(337, 7)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 19)
=======
        Me.Label17.Location = New System.Drawing.Point(385, 10)
        Me.Label17.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 24)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "FACTURA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(819, 35)
=======
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(876, 46)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(482, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Número Factura:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(620, 86)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 25)
        Me.TextBox1.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(14, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(225, 22)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "IMPORTADORA NOELIA"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.ClientSize = New System.Drawing.Size(823, 632)
=======
        Me.ClientSize = New System.Drawing.Size(872, 840)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox1)
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gbx_Datosclientes)
<<<<<<< HEAD:HNSolutionS_TEST/Facturacion.Designer.vb
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Facturacion"
        Me.Text = "Facturacion"
=======
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "Factura"
        Me.ShowIcon = False
        Me.Text = "Facturación"
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a:HNSolutionS_TEST/Factura.Designer.vb
        Me.Gbx_Datosclientes.ResumeLayout(False)
        Me.Gbx_Datosclientes.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gbx_Datosclientes As GroupBox
	Friend WithEvents Btn_Limpiar As Button
	Friend WithEvents TxtNumeroId As TextBox
	Friend WithEvents TxtnombreClientes As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Btn_Nuevo As Button
	Friend WithEvents Btn_Cancelar As Button
	Friend WithEvents Btn_Guardar As Button
	Friend WithEvents Lbl_Total As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents Lbx_Sub_Total As ListBox
	Friend WithEvents Label15 As Label
	Friend WithEvents Lbx_Cantidad As ListBox
	Friend WithEvents Label14 As Label
	Friend WithEvents Lbx_Precio As ListBox
	Friend WithEvents Label13 As Label
	Friend WithEvents Lbx_Producto As ListBox
	Friend WithEvents Label12 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents TxtDescriccion As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Txt_cantidad As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents CbxCategoria As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents TxtPrecio As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents CbxPago As ComboBox
	Friend WithEvents Label10 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label11 As Label
	Friend WithEvents CbxVendedor As ComboBox
	Friend WithEvents Btn_LimpiarV As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Btn_Agregar As Button
	Friend WithEvents Label17 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Cbx_productos As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label18 As Label
End Class
