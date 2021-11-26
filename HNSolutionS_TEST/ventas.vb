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

    Private Sub DGClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGClientes.CellClick
        Dim i As Integer
        i = DGClientes.CurrentRow.Index

        txtCodArt.Text = DGClientes.Item(0, i).Value()
        txtNomArt.Text = DGClientes.Item(1, i).Value()
        txtTotal.Text = DGClientes.Item(2, i).Value()

        txtImpuesto.Text = Format(Val(DGClientes.Item(2, i).Value()) * 0.15, "0,00.0")

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Hide()
        FormFacturacion.Show()
    End Sub
End Class