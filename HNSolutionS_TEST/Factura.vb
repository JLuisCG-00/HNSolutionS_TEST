
Imports System.Data.SqlClient
Public Class Factura

	Dim strcomando As String
	Dim conexion As String
	Dim adapter As SqlDataAdapter
	Dim data As DataSet
	Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		conexion = ("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
		strcomando = "select * from categoria"
		adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion)
		data = New DataSet
		adapter.Fill(data)
		CbxCategoria.DataSource = data.Tables(0)
		CbxCategoria.DisplayMember = "nombre"
		CbxCategoria.ValueMember = "idcategoria"

	End Sub

	Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

	End Sub

	Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

	End Sub

	Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

	End Sub

	Private Sub CbxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCategoria.SelectedIndexChanged
		Dim cod As Integer = Val(CbxCategoria.SelectedValue.ToString)
		Dim tabla As New DataTable
		Dim sql As String = "Select nombre FROM articulos WHERE idcategoria =" & cod
		adapter = New System.Data.SqlClient.SqlDataAdapter(sql, conexion)
		data = New DataSet
		adapter.Fill(tabla)
		Cbx_productos.DataSource = tabla
		Cbx_productos.DisplayMember = "nombre"



	End Sub

	Private Sub CbxVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxVendedor.SelectedIndexChanged
		conexion = ("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
		strcomando = "select * from Users"
		adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion)
		data = New DataSet
		adapter.Fill(data)
		CbxVendedor.DataSource = data.Tables(0)
		CbxVendedor.DisplayMember = "Usuario"
	End Sub
End Class