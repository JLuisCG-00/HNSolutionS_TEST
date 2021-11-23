Imports System.Data.SqlClient
Public Class InventarioOG
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub InventarioOG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable
        Using Sql As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
            Sql.Open()
            Dim da As New SqlDataAdapter("exec LlamarInventario2", Sql)
            dt = New DataTable
            da.Fill(dt)
            TablaArticulosDGV.DataSource = dt
        End Using
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AgregarProducto.Show()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs)

    End Sub
End Class