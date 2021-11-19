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
    End Sub

<<<<<<< HEAD
=======
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Txt_Usuario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Txt_Usuario.TextChanged
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar  números", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub Txt_Nombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Txt_Nombre.TextChanged
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar letras", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Txt_Nombre_TextChanged(sender As Object, e As EventArgs) Handles Txt_Nombre.TextChanged

    End Sub

    Private Sub Txt_Telefono_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Txt_Telefono.TextChanged
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar letras", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
>>>>>>> e92d7cb2d725bd3eb388d9d466dd87d72076db35
End Class