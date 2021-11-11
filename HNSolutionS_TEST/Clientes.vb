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
	'Private Sub LLenar_DGVClientes()
	'	Dim args As String = "Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True"

	'	Using connection As SqlConnection = New SqlConnection(args)
	'		Dim command As SqlCommand
	'		Dim adapter As SqlDataAdapter
	'		Dim dtTable As DataTable

	'		command = New SqlCommand("LlamarClientes5", connection)
	'		command.CommandType = CommandType.StoredProcedure
	'		adapter = New SqlDataAdapter(command)
	'		dtTable = New DataTable

	'		Try
	'			adapter.Fill(dtTable)
	'			TablaClientesDGV.DataSource = dtTable
	'			TablaClientesDGV.AutoGenerateColumns = False

	'			With TablaClientesDGV
	'				.Columns("idpersona").DataPropertyName = "CodCliente"
	'				.Columns("noumeroiden").DataPropertyName = "IdCliente"
	'				.Columns("nombre").DataPropertyName = "NomClient"
	'				.Columns("direccion").DataPropertyName = "Direccion"
	'				.Columns("telefono").DataPropertyName = "TelCliente"
	'				.Columns("email").DataPropertyName = "Email"
	'			End With
	'		Catch ex As Exception

	'		End Try

	'	End Using
	'End Sub
End Class