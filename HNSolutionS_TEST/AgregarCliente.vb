Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Public Class AgregarCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Txt_NumeroIdentidad.Clear()
        Txt_NombreAgregarcliente.Clear()
        Txt_DireccionCliente.Clear()
        Txt_TelefonoCliente.Clear()
        txtCorreo.Clear()
    End Sub


    Private Function validar_campos() As Boolean
        If Trim(Txt_DireccionCliente.Text) = "" Then
            validar_campos = False
        ElseIf Trim(Txt_NombreAgregarcliente.Text) = "" Then
            validar_campos = False
        ElseIf Trim(Txt_NumeroIdentidad.Text) = "" Then
            validar_campos = False
        ElseIf Trim(Txt_TelefonoCliente.Text) = "" Then
            validar_campos = False
        ElseIf Trim(txtCorreo.Text) = "" Then
            validar_campos = False
        Else
            validar_campos = True
        End If
    End Function

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

    Private Sub Btn_CancelarCliente_Click(sender As Object, e As EventArgs) Handles Btn_CancelarCliente.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub Btn_GuardaCliente_Click(sender As Object, e As EventArgs) Handles Btn_GuardaCliente.Click
        Dim conexion As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
        Dim command As New SqlCommand("IngresoClientes", conexion)

        If validar_campos() = True Then

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Identidad", Txt_NumeroIdentidad.Text)
            command.Parameters.AddWithValue("@nombreC", Txt_NombreAgregarcliente.Text)
            command.Parameters.AddWithValue("@dirC", Txt_DireccionCliente.Text)
            command.Parameters.AddWithValue("@telC", Txt_TelefonoCliente.Text)
            command.Parameters.AddWithValue("@correoC", txtCorreo.Text)
            Try
                conexion.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conexion.Dispose()
                command.Dispose()
                MsgBox("Usuario Registrado Correctamente", vbInformation, "Sistema")
            End Try

        ElseIf validar_campos() = False Then
            MsgBox("No ha ingresado todo los campos", vbOK)
        End If
    End Sub

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Txt_NumeroIdentidad_TextChanged(sender As Object, e As EventArgs) Handles Txt_NumeroIdentidad.TextChanged

    End Sub

    Private Sub Txt_NumeroIdentidad_Validated(sender As Object, e As EventArgs) Handles Txt_NumeroIdentidad.Validated
        Dim errors As Integer = 0

        Try
            If Txt_NumeroIdentidad.Text < 13 Then
                ErrorProvider1.SetError(Txt_NumeroIdentidad, "Numero de identidad inválido")
                errors += 1
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Txt_TelefonoCliente_Validated(sender As Object, e As EventArgs) Handles Txt_TelefonoCliente.Validated
        Dim errors As Integer = 0

        Try
            If Txt_TelefonoCliente.Text < 8 Then
                ErrorProvider1.SetError(Txt_TelefonoCliente, "Numero de telefono  inválido")
                errors += 1
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class