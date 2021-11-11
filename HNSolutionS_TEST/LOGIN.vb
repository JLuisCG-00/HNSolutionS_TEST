Imports System.Data.SqlClient
Public Class LOGIN
    Dim conexion As New SqlConnection
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True"
            conexion.Open()
            MsgBox("Conexion exitosa a la base de datos")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        If txtUsuario.Text = "Administrador" And txtContra.Text = "1234" Or
           txtUsuario.Text = "Empleado" And txtContra.Text = "5678" Then

            MenuPrincipal.Show()

        Else
            MessageBox.Show("Error, ha ingresado un dato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        txtUsuario.Text = ""
        txtContra.Text = ""


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea salir del sistema?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub ChkContra_CheckedChanged(sender As Object, e As EventArgs) Handles ChkContra.CheckedChanged
        If ChkContra.Checked = True Then
            txtContra.PasswordChar = ""

        Else ChkContra.Checked = False
            txtContra.PasswordChar = "*"



        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class