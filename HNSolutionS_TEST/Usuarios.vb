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
        ' Dim conexion As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
        'Dim command As New SqlCommand("IngresoUsuarios", conexion)
        'Command.CommandType = CommandType.StoredProcedure
        'Command.Parameters.AddWithValue("@usuarioU", Txt_Usuario.Text)
        'Command.Parameters.AddWithValue("@nombreU", Txt_Nombre.Text)
        'Command.Parameters.AddWithValue("@contraseñaU", Txt_Contraseña.Text)
        'Command.Parameters.AddWithValue("@telC", Txt_Telefono.Text)
        'Command.Parameters.AddWithValue("@correoC", Txt_Email.Text)
        'Command.Parameters.AddWithValue("@estadoU", Txt_estado.Text)
        'Try
        'conexion.Open()
        'Command.ExecuteNonQuery()
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'Finally
        'conexion.Dispose()
        'Command.Dispose()
        'MsgBox("Usuario Registrado Correctamente", vbInformation, "Sistema")
        'End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class