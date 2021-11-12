Imports System.Data.SqlClient
Public Class LOGIN
    Dim conexion As New SqlConnection
    Dim adaptador As New SqlDataAdapter
    Dim datos As New DataSet
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
        Dim consulta As String
        Dim lista As Byte
        Using Sql As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
            Sql.Open()
        End Using
        If txtUsuario.Text <> "" And txtContra.Text <> "" Then
            consulta = "SELECT * FROM Users WHERE Usuario='" & txtUsuario.Text & "' and Contraseña='" & txtContra.Text & "'"
            adaptador = New SqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Users")
            lista = datos.Tables("Users").Rows.Count
        End If
        If lista <> 0 Then
            txtUsuario.Text = datos.Tables("Users").Rows(0).Item("Contraseña")
            txtUsuario.Text = datos.Tables("Users").Rows(0).Item("Usuario")
            MsgBox("Bienvenido")
            Me.Hide()
            MenuPrincipal.Show()
        Else
            MsgBox("Contraseña o usuario incorrecta, intente de nuevo")
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