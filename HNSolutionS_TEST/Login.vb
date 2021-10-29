Public Class IMPORTADORA
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnlog_Click(sender As Object, e As EventArgs) Handles Btnlog.Click
        If txtbUsuario.Text = "Administrador" And txtbContra.Text = "1234" Or
            txtbUsuario.Text = "Empleado" And txtbContra.Text = "5678" Then
            MenuPrincipal.Show()
            Me.Hide()
        Else
            MsgBox("Error, contraseña incorrecta", vbCancel)
        End If
        txtbUsuario.Text = ""
        txtbContra.Text = ""

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea salir del sistema", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
