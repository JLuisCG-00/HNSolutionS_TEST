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


    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
        Me.Hide()
        ventas.Show()
    End Sub

    Private Sub MostrarFacturasDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MostrarFacturasDGV.CellContentClick

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim DaTable As DataTable = New DataTable
        Using Sql As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
            Sql.Open()
            Dim da As New SqlDataAdapter("exec LlamarFacturas", Sql)
            DaTable = New DataTable
            da.Fill(DaTable)
            MostrarFacturasDGV.DataSource = DaTable
        End Using
    End Sub
End Class