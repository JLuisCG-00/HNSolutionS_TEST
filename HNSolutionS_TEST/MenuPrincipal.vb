Public Class MenuPrincipal
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnFacturacion.Click
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Clientes.Show()

    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Ventas.Show()
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        Inventario.Show()
    End Sub

    Private Sub BtnGestion_Click(sender As Object, e As EventArgs) Handles BtnGestion.Click

    End Sub
End Class