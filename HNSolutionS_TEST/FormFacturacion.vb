Imports System.Data.SqlClient
Public Class FormFacturacion
    Private Sub FormFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DaTable As DataTable = New DataTable
        Using Sql As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
            Sql.Open()
            Dim da As New SqlDataAdapter("exec LlamarFacturas", Sql)
            DaTable = New DataTable
            da.Fill(DaTable)
            MostrarFacturasDGV.DataSource = DaTable
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class