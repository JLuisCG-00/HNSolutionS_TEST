Public Class IMPORTADORA
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnlog_Click(sender As Object, e As EventArgs) Handles Btnlog.Click
        If txtbUsuario.Text = "Administrador" And txtbContra.Text = "1234" Or
            txtbUsuario.Text = "Empleado" And txtbContra.Text = "5678" Then

            Form2.Show()

        Else
            MessageBox.Show("Error, ha ingresado un dato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
        txtbUsuario.Text = ""
        txtbContra.Text = ""



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea salir del sistema", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub ChkContra_CheckedChanged(sender As Object, e As EventArgs) Handles ChkContra.CheckedChanged

        If ChkContra.Checked = True Then
            txtbContra.PasswordChar = ""

        ElseIf ChkContra.Checked = False Then
            txtbContra.PasswordChar = "*"

        End If
    End Sub
End Class
