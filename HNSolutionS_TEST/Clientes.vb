Imports System.Data.SqlClient



Public Class Clientes

	'Dim conexion As String

	Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
		AgregarCliente.Show()


	End Sub
	Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'LLenar_DGVClientes()
		Dim dt As DataTable = New DataTable
		Using Sql As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
			Sql.Open()
			Dim da As New SqlDataAdapter("exec LlamarClientes5", Sql)
			dt = New DataTable
			da.Fill(dt)
			TablaClientesDGV.DataSource = dt
		End Using
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim dt As DataTable = New DataTable
		Using Sql As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
			Sql.Open()
			Dim da As New SqlDataAdapter("exec LlamarClientes5", Sql)
			dt = New DataTable
			da.Fill(dt)
			TablaClientesDGV.DataSource = dt
		End Using
	End Sub

	Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
		'Dim conexion As String
		'conexion = ("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
		'Dim datos As New SqlDataAdapter("select *from clientes where nombre like '%" & Me.Txt_buscar.Text & "%", conexion)
		'Dim ds As New DataSet()
		'datos.Fill(ds, "clientes")

		'Me.TablaClientesDGV.DataSource = ds.Tables(0)

	End Sub
End Class