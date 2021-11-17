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
        Factura.Show()
    End Sub
End Class