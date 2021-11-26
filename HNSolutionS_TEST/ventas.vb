Imports System.Data.SqlClient
Public Class ventas
    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable
        Dim dt2 As DataTable = New DataTable
        Using Sql As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
            Sql.Open()
            Dim da As New SqlDataAdapter("exec ListaArticulosFact", Sql)
            dt = New DataTable
            da.Fill(dt)
            DGClientes.DataSource = dt
        End Using


    End Sub

    Private Sub DGClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGClientes.CellClick
        Dim i As Integer
        i = DGClientes.CurrentRow.Index

        txtCodArt.Text = DGClientes.Item(0, i).Value()
        txtNomArt.Text = DGClientes.Item(1, i).Value()
        txtTotal.Text = DGClientes.Item(2, i).Value()

        txtImpuesto.Text = Format(Val(DGClientes.Item(2, i).Value()) * 0.15, "0,00.0")

    End Sub

    Private Sub txtNFactura_TextChanged(sender As Object, e As EventArgs) Handles txtNFactura.TextChanged

    End Sub
End Class