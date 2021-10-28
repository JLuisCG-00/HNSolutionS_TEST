<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
		Me.TxtDirrecion = New System.Windows.Forms.TextBox()
		Me.TxtDatosClientes = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
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
		Me.TxtProducto = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TxtDescriccion = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
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
		Me.Btn_Agregar = New System.Windows.Forms.Button()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
		Me.Gbx_Datosclientes.Controls.Add(Me.TxtDirrecion)
		Me.Gbx_Datosclientes.Controls.Add(Me.TxtDatosClientes)
		Me.Gbx_Datosclientes.Controls.Add(Me.Label3)
		Me.Gbx_Datosclientes.Controls.Add(Me.Label2)
		Me.Gbx_Datosclientes.Controls.Add(Me.Label1)
		Me.Gbx_Datosclientes.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Gbx_Datosclientes.Location = New System.Drawing.Point(120, 88)
		Me.Gbx_Datosclientes.Name = "Gbx_Datosclientes"
		Me.Gbx_Datosclientes.Size = New System.Drawing.Size(991, 215)
		Me.Gbx_Datosclientes.TabIndex = 0
		Me.Gbx_Datosclientes.TabStop = False
		Me.Gbx_Datosclientes.Text = "Datos del Cliente:"
		'
		'Btn_Limpiar
		'
		Me.Btn_Limpiar.BackColor = System.Drawing.Color.DodgerBlue
		Me.Btn_Limpiar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_Limpiar.Location = New System.Drawing.Point(706, 116)
		Me.Btn_Limpiar.Name = "Btn_Limpiar"
		Me.Btn_Limpiar.Size = New System.Drawing.Size(140, 41)
		Me.Btn_Limpiar.TabIndex = 6
		Me.Btn_Limpiar.Text = "Limpiar"
		Me.Btn_Limpiar.UseVisualStyleBackColor = False
		'
		'TxtNumeroId
		'
		Me.TxtNumeroId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
		Me.TxtNumeroId.Location = New System.Drawing.Point(287, 172)
		Me.TxtNumeroId.Name = "TxtNumeroId"
		Me.TxtNumeroId.Size = New System.Drawing.Size(247, 31)
		Me.TxtNumeroId.TabIndex = 5
		'
		'TxtDirrecion
		'
		Me.TxtDirrecion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TxtDirrecion.Location = New System.Drawing.Point(287, 116)
		Me.TxtDirrecion.Name = "TxtDirrecion"
		Me.TxtDirrecion.Size = New System.Drawing.Size(247, 31)
		Me.TxtDirrecion.TabIndex = 4
		'
		'TxtDatosClientes
		'
		Me.TxtDatosClientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TxtDatosClientes.Location = New System.Drawing.Point(287, 60)
		Me.TxtDatosClientes.Name = "TxtDatosClientes"
		Me.TxtDatosClientes.Size = New System.Drawing.Size(247, 31)
		Me.TxtDatosClientes.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label3.Location = New System.Drawing.Point(54, 172)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(173, 25)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Numero Identidad:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(52, 116)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(104, 25)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Dirreccion:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(52, 60)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(161, 25)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Datos del Cliente:"
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
		Me.GroupBox3.Location = New System.Drawing.Point(120, 696)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(991, 342)
		Me.GroupBox3.TabIndex = 3
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Datos Detalle"
		'
		'Btn_Nuevo
		'
		Me.Btn_Nuevo.BackColor = System.Drawing.Color.DodgerBlue
		Me.Btn_Nuevo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_Nuevo.Location = New System.Drawing.Point(871, 274)
		Me.Btn_Nuevo.Name = "Btn_Nuevo"
		Me.Btn_Nuevo.Size = New System.Drawing.Size(112, 46)
		Me.Btn_Nuevo.TabIndex = 12
		Me.Btn_Nuevo.Text = "Nuevo"
		Me.Btn_Nuevo.UseVisualStyleBackColor = False
		'
		'Btn_Cancelar
		'
		Me.Btn_Cancelar.BackColor = System.Drawing.Color.Red
		Me.Btn_Cancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_Cancelar.Location = New System.Drawing.Point(753, 274)
		Me.Btn_Cancelar.Name = "Btn_Cancelar"
		Me.Btn_Cancelar.Size = New System.Drawing.Size(112, 46)
		Me.Btn_Cancelar.TabIndex = 11
		Me.Btn_Cancelar.Text = "Cancelar"
		Me.Btn_Cancelar.UseVisualStyleBackColor = False
		'
		'Btn_Guardar
		'
		Me.Btn_Guardar.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.Btn_Guardar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_Guardar.Location = New System.Drawing.Point(635, 274)
		Me.Btn_Guardar.Name = "Btn_Guardar"
		Me.Btn_Guardar.Size = New System.Drawing.Size(112, 46)
		Me.Btn_Guardar.TabIndex = 10
		Me.Btn_Guardar.Text = "Guardar"
		Me.Btn_Guardar.UseVisualStyleBackColor = False
		'
		'Lbl_Total
		'
		Me.Lbl_Total.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Lbl_Total.Location = New System.Drawing.Point(734, 133)
		Me.Lbl_Total.Name = "Lbl_Total"
		Me.Lbl_Total.Size = New System.Drawing.Size(150, 45)
		Me.Lbl_Total.TabIndex = 9
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(765, 81)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(81, 38)
		Me.Label16.TabIndex = 8
		Me.Label16.Text = "Total"
		'
		'Lbx_Sub_Total
		'
		Me.Lbx_Sub_Total.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Lbx_Sub_Total.FormattingEnabled = True
		Me.Lbx_Sub_Total.ItemHeight = 21
		Me.Lbx_Sub_Total.Location = New System.Drawing.Point(477, 94)
		Me.Lbx_Sub_Total.Name = "Lbx_Sub_Total"
		Me.Lbx_Sub_Total.Size = New System.Drawing.Size(125, 214)
		Me.Lbx_Sub_Total.TabIndex = 7
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label15.Location = New System.Drawing.Point(488, 56)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(98, 25)
		Me.Label15.TabIndex = 6
		Me.Label15.Text = "Sub_Total:"
		'
		'Lbx_Cantidad
		'
		Me.Lbx_Cantidad.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Lbx_Cantidad.FormattingEnabled = True
		Me.Lbx_Cantidad.ItemHeight = 21
		Me.Lbx_Cantidad.Location = New System.Drawing.Point(324, 94)
		Me.Lbx_Cantidad.Name = "Lbx_Cantidad"
		Me.Lbx_Cantidad.Size = New System.Drawing.Size(117, 214)
		Me.Lbx_Cantidad.TabIndex = 5
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label14.Location = New System.Drawing.Point(337, 56)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(93, 25)
		Me.Label14.TabIndex = 4
		Me.Label14.Text = "Cantidad:"
		'
		'Lbx_Precio
		'
		Me.Lbx_Precio.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Lbx_Precio.FormattingEnabled = True
		Me.Lbx_Precio.ItemHeight = 21
		Me.Lbx_Precio.Location = New System.Drawing.Point(211, 94)
		Me.Lbx_Precio.Name = "Lbx_Precio"
		Me.Lbx_Precio.Size = New System.Drawing.Size(95, 214)
		Me.Lbx_Precio.TabIndex = 3
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label13.Location = New System.Drawing.Point(225, 56)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(70, 25)
		Me.Label13.TabIndex = 2
		Me.Label13.Text = "Precio:"
		'
		'Lbx_Producto
		'
		Me.Lbx_Producto.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Lbx_Producto.FormattingEnabled = True
		Me.Lbx_Producto.ItemHeight = 21
		Me.Lbx_Producto.Location = New System.Drawing.Point(42, 94)
		Me.Lbx_Producto.Name = "Lbx_Producto"
		Me.Lbx_Producto.Size = New System.Drawing.Size(142, 214)
		Me.Lbx_Producto.TabIndex = 1
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label12.Location = New System.Drawing.Point(42, 56)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(103, 25)
		Me.Label12.TabIndex = 0
		Me.Label12.Text = "Productos:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label4.Location = New System.Drawing.Point(52, 83)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(95, 25)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Pruducto:"
		'
		'TxtProducto
		'
		Me.TxtProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TxtProducto.Location = New System.Drawing.Point(181, 83)
		Me.TxtProducto.Name = "TxtProducto"
		Me.TxtProducto.Size = New System.Drawing.Size(235, 31)
		Me.TxtProducto.TabIndex = 1
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label5.Location = New System.Drawing.Point(52, 136)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(114, 25)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Descriccion:"
		'
		'TxtDescriccion
		'
		Me.TxtDescriccion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TxtDescriccion.Location = New System.Drawing.Point(181, 136)
		Me.TxtDescriccion.Name = "TxtDescriccion"
		Me.TxtDescriccion.Size = New System.Drawing.Size(235, 31)
		Me.TxtDescriccion.TabIndex = 3
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label6.Location = New System.Drawing.Point(52, 188)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(93, 25)
		Me.Label6.TabIndex = 4
		Me.Label6.Text = "Cantidad:"
		'
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TextBox1.Location = New System.Drawing.Point(181, 185)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(150, 31)
		Me.TextBox1.TabIndex = 5
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label7.Location = New System.Drawing.Point(601, 83)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(99, 25)
		Me.Label7.TabIndex = 6
		Me.Label7.Text = "Categoria:"
		'
		'CbxCategoria
		'
		Me.CbxCategoria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.CbxCategoria.FormattingEnabled = True
		Me.CbxCategoria.Location = New System.Drawing.Point(775, 80)
		Me.CbxCategoria.Name = "CbxCategoria"
		Me.CbxCategoria.Size = New System.Drawing.Size(182, 33)
		Me.CbxCategoria.TabIndex = 7
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label8.Location = New System.Drawing.Point(601, 133)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(70, 25)
		Me.Label8.TabIndex = 8
		Me.Label8.Text = "Precio:"
		'
		'TxtPrecio
		'
		Me.TxtPrecio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TxtPrecio.Location = New System.Drawing.Point(775, 136)
		Me.TxtPrecio.Name = "TxtPrecio"
		Me.TxtPrecio.Size = New System.Drawing.Size(138, 31)
		Me.TxtPrecio.TabIndex = 9
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label9.Location = New System.Drawing.Point(601, 188)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(146, 25)
		Me.Label9.TabIndex = 10
		Me.Label9.Text = "Forma De Pago:"
		'
		'CbxPago
		'
		Me.CbxPago.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.CbxPago.FormattingEnabled = True
		Me.CbxPago.Location = New System.Drawing.Point(775, 188)
		Me.CbxPago.Name = "CbxPago"
		Me.CbxPago.Size = New System.Drawing.Size(182, 33)
		Me.CbxPago.TabIndex = 11
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label10.Location = New System.Drawing.Point(54, 254)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(66, 25)
		Me.Label10.TabIndex = 12
		Me.Label10.Text = "Fecha:"
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.DateTimePicker1.Location = New System.Drawing.Point(181, 254)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(300, 31)
		Me.DateTimePicker1.TabIndex = 13
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label11.Location = New System.Drawing.Point(601, 247)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(100, 25)
		Me.Label11.TabIndex = 14
		Me.Label11.Text = "Vendedor:"
		'
		'CbxVendedor
		'
		Me.CbxVendedor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.CbxVendedor.FormattingEnabled = True
		Me.CbxVendedor.Location = New System.Drawing.Point(775, 247)
		Me.CbxVendedor.Name = "CbxVendedor"
		Me.CbxVendedor.Size = New System.Drawing.Size(182, 33)
		Me.CbxVendedor.TabIndex = 15
		'
		'Btn_LimpiarV
		'
		Me.Btn_LimpiarV.BackColor = System.Drawing.Color.DodgerBlue
		Me.Btn_LimpiarV.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_LimpiarV.Location = New System.Drawing.Point(372, 308)
		Me.Btn_LimpiarV.Name = "Btn_LimpiarV"
		Me.Btn_LimpiarV.Size = New System.Drawing.Size(127, 47)
		Me.Btn_LimpiarV.TabIndex = 16
		Me.Btn_LimpiarV.Text = "Limpiar"
		Me.Btn_LimpiarV.UseVisualStyleBackColor = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Btn_Agregar)
		Me.GroupBox1.Controls.Add(Me.Btn_LimpiarV)
		Me.GroupBox1.Controls.Add(Me.CbxVendedor)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
		Me.GroupBox1.Controls.Add(Me.Label10)
		Me.GroupBox1.Controls.Add(Me.CbxPago)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.TxtPrecio)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.CbxCategoria)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.TxtDescriccion)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.TxtProducto)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.GroupBox1.Location = New System.Drawing.Point(120, 309)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(991, 369)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Datos de Venta:"
		'
		'Btn_Agregar
		'
		Me.Btn_Agregar.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.Btn_Agregar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_Agregar.Location = New System.Drawing.Point(544, 308)
		Me.Btn_Agregar.Name = "Btn_Agregar"
		Me.Btn_Agregar.Size = New System.Drawing.Size(127, 47)
		Me.Btn_Agregar.TabIndex = 17
		Me.Btn_Agregar.Text = "Agregar"
		Me.Btn_Agregar.UseVisualStyleBackColor = False
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.BackColor = System.Drawing.Color.RoyalBlue
		Me.Label17.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label17.Location = New System.Drawing.Point(508, -1)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(214, 48)
		Me.Label17.TabIndex = 4
		Me.Label17.Text = "Facturacion"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.RoyalBlue
		Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(1170, 59)
		Me.PictureBox1.TabIndex = 5
		Me.PictureBox1.TabStop = False
		'
		'Facturacion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1170, 1050)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Gbx_Datosclientes)
		Me.Name = "Facturacion"
		Me.Text = "Facturacion"
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
	Friend WithEvents TxtDirrecion As TextBox
	Friend WithEvents TxtDatosClientes As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
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
	Friend WithEvents TxtProducto As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents TxtDescriccion As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents TextBox1 As TextBox
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
End Class
