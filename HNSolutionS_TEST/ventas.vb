Imports System.Data.SqlClient
Public Class ventas
    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable
        Using Sql As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
            Sql.Open()
            Dim da As New SqlDataAdapter("exec LlamarInventario2", Sql)
            dt = New DataTable
            da.Fill(dt)
            DGClientes.DataSource = dt
        End Using
    End Sub


End Class