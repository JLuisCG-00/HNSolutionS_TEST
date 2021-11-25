
Imports System.Data.SqlClient
Public Class Factura

	Dim strcomando As String
	Dim conexion As String
	Dim adapter As SqlDataAdapter
	Dim dt As DataTable
	Dim data As DataSet
	Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		conexion = ("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
		strcomando = "select * from categoria"
		adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion)
		dt = New DataTable
		adapter.Fill(dt)
		CbxCategoria.DataSource = data.Tables(0)
		CbxCategoria.DisplayMember = "nombre"
		CbxCategoria.ValueMember = "idcategoria"

	End Sub

	Private Sub CbxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCategoria.SelectedIndexChanged
		Dim cod As Integer = Val(CbxCategoria.SelectedValue.ToString)
		Dim tabla As New DataTable
		Dim sql As String = "Select nombre *FROM articulos WHERE idcategoria =" & cod
		adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion)
		dt = New DataTable
		adapter.Fill(dt)
		Cbx_productos.DataSource = tabla
		Cbx_productos.DisplayMember = "nombre"



	End Sub

	Private Sub CbxVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxVendedor.SelectedIndexChanged
		conexion = ("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
		strcomando = "select *From Users"
		adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion)
		data = New DataSet
		adapter.Fill(data)
		CbxVendedor.DataSource = data.Tables(0)
		CbxVendedor.DisplayMember = "Usuario"
	End Sub

	Private Sub Cbx_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_productos.SelectedIndexChanged
		If Cbx_productos.ValueMember.ToString <> "" Then
			strcomando = "select * from articulos where idarticulo" + Cbx_productos.SelectedValue.ToString + ""
			adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion)
			dt = New DataTable
			adapter.Fill(dt)
			For Each row As DataRow In dt.Rows
				TxtDescriccion.Text = row("descripcion").ToString
				TxtPrecio.Text = row("precio_venta").ToString

			Next
		End If
	End Sub

	Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
		Lbx_Producto.Items.Add(Cbx_productos.Text)
		Lbx_Precio.Items.Add(TxtPrecio.Text)
		Lbx_Cantidad.Items.Add(Txt_cantidad.Text)
		Lbx_Sub_Total.Items.Add(CDbl(TxtPrecio.Text) * Txt_cantidad.Text)
	End Sub
	Private Sub Calcular()
		Dim total As Double
		For i = 0 To Lbx_Sub_Total.Items.Count - 1
			total = total + Lbx_Sub_Total.Items.Item(i)
		Next
		Lbl_Total.Text = "L/." & total
	End Sub

	Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click

	End Sub

	Private Sub TxtDescriccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescriccion.TextChanged

	End Sub

	Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
		TxtnombreClientes.Clear()
		TxtNumeroId.Clear()
		CbxCategoria.Items.Clear()
		Cbx_productos.Items.Clear()
		CbxPago.Items.Clear()
		CbxVendedor.Items.Clear()
		TxtPrecio.Clear()
		TxtDescriccion.Clear()
		Lbx_Producto.Items.Clear()
		Lbx_Precio.Items.Clear()
		Lbx_Sub_Total.Items.Clear()
		Lbx_Cantidad.Items.Clear()
	End Sub

	Private Sub Txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_cantidad.KeyPress
		If Char.IsDigit(e.KeyChar) Then
			e.Handled = False
		ElseIf Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
			MsgBox("Solo se puede ingresar  números", MsgBoxStyle.Exclamation, "Ingreso de Número")
		End If
	End Sub
End Class