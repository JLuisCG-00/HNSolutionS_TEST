Imports System.Data
Imports System.Data.SqlClient

Public Class Gestion
	Private Sub Btn_Anadir_Click(sender As Object, e As EventArgs) Handles Btn_Anadir.Click
		Usuarios.Show()
	End Sub

	Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim dt As DataTable = New DataTable
		Using Sql As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
			Sql.Open()
			Dim da As New SqlDataAdapter("exec llamarUsuarios", Sql)
			dt = New DataTable
			da.Fill(dt)
			UsuariosDGV.DataSource = dt
		End Using
	End Sub

	Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Volver.Click
		Me.Hide()
		MenuPrincipal.Show()
	End Sub
End Class