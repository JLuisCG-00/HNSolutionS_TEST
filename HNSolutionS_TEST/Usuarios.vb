Imports System.Data
Imports System.Data.SqlClient
Public Class Usuarios
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Btn_limpiar_Click(sender As Object, e As EventArgs) Handles Btn_limpiar.Click
        Txt_Usuario.Clear()
        Txt_Telefono.Clear()
        Txt_Nombre.Clear()
        Txt_Email.Clear()
        Txt_Contraseña.Clear()
        Txt_estado.Clear()
    End Sub

    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
        Dim conexion As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
        Dim command As New SqlCommand("IngresarUsuarios", conexion)

        If validar_campos() = True Then


            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@UsuarioU", Txt_Usuario.Text)
            command.Parameters.AddWithValue("@ContraseñaU", Txt_Contraseña.Text)
            command.Parameters.AddWithValue("@NomU", Txt_Nombre.Text)
            command.Parameters.AddWithValue("@telU", Txt_Telefono.Text)
            command.Parameters.AddWithValue("@correoU", Txt_Email.Text)
            command.Parameters.AddWithValue("@EstadoU", Txt_estado.Text)
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function validar_campos() As Boolean
        If Trim(Txt_Usuario.Text) = "" Then
            validar_campos = False
        ElseIf Trim(Txt_Nombre.Text) = "" Then
            validar_campos = False
        ElseIf Trim(Txt_Contraseña.Text) = "" Then
            validar_campos = False
        ElseIf Trim(Txt_Telefono.Text) = "" Then
            validar_campos = False
        ElseIf Trim(Txt_estado.Text) = "" Then
            validar_campos = False
        ElseIf Trim(Txt_Email.Text) = "" Then
            validar_campos = False
        Else
            validar_campos = True
        End If
    End Function

    Private Sub Txt_Telefono_TextChanged(sender As Object, e As EventArgs) Handles Txt_Telefono.TextChanged

    End Sub

    Private Sub Txt_Telefono_Validated(sender As Object, e As EventArgs) Handles Txt_Telefono.Validated
        Dim errors As Integer = 0

        Try
            If Txt_Telefono.Text < 8 Then
                ErrorProvider1.SetError(Txt_Telefono, "Numero de telefono  inválido")
                errors += 1
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class