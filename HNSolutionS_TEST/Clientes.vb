Imports System.Data.SqlClient
Public Class Clientes
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
End Class