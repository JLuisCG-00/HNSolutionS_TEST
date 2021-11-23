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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class