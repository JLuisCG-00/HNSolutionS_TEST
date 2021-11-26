Imports System.Data.SqlClient
Public Class ventas
    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable
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

        txtImpuesto.Text = Format(Val(DGClientes.Item(2, i).Value()) / 1.15, "0,00.0")

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Hide()
        FormFacturacion.Show()
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Dim conexion As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
        Dim command As New SqlCommand("LlenarFactura", conexion)

        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@FacturaFecha", txtFecha.Text)
        command.Parameters.AddWithValue("@FacturaComentario", Txt_Comentario.Text)
        command.Parameters.AddWithValue("@ClienteCodigo", Val(txtCodClient.Text))
        command.Parameters.AddWithValue("@ClienteNom", txtNomClient.Text)
        command.Parameters.AddWithValue("@ClienteTel", txtTelClient.Text)
        command.Parameters.AddWithValue("@ArticuloCod", Val(txtCodArt.Text))
        command.Parameters.AddWithValue("@ArticuloNom", txtNomArt.Text)
        command.Parameters.AddWithValue("@ImpuestoFac", Val(txtImpuesto.Text))
        command.Parameters.AddWithValue("@TotalFac", Val(txtTotal.Text))
        command.Parameters.AddWithValue("@DescuentoFac", Val(txtxDescuento.Text))
        Try
            conexion.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
            command.Dispose()
            MsgBox("Factura Registrada Correctamente", vbInformation, "Sistema")
        End Try
    End Sub
End Class