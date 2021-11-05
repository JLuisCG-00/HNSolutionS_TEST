Public Class AgregarCliente
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Txt_NumeroIdentidad.Clear()
		Txt_NombreAgregarcliente.Clear()
		Txt_DireccionCliente.Clear()
		Txt_TelefonoCliente.Clear()
	End Sub

    Private Sub Txt_NumeroIdentidad_TextChanged(sender As Object, e As EventArgs) Handles Txt_NumeroIdentidad.TextChanged

    End Sub


    Private Sub Txt_NumeroIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NumeroIdentidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar  números", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub Txt_NombreAgregarcliente_TextChanged(sender As Object, e As EventArgs) Handles Txt_NombreAgregarcliente.TextChanged

    End Sub

    Private Sub Txt_NombreAgregarcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NombreAgregarcliente.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar letras", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Txt_TelefonoCliente_TextChanged(sender As Object, e As EventArgs) Handles Txt_TelefonoCliente.TextChanged

    End Sub

    Private Sub Txt_TelefonoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TelefonoCliente.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar  números", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
End Class