﻿Public Class MenuPrincipal
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
End Class