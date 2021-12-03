Public Class MenuPrincipal
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnFacturacion.Click

        FormFacturacion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click

        Clientes.Show()



    End Sub


    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        InventarioOG.Show()
    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LblHora.Text = DateTime.Now.ToLongTimeString()
        LblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnGestion_Click(sender As Object, e As EventArgs) Handles BtnGestion.Click
        Gestion.Show()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CAdmin = True Then
            BtnGestion.Enabled = True
        End If

        If CAdmin = False Then
            BtnGestion.Enabled = False
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class