Imports System.Data
Imports System.Data.SqlClient
Public Class AgregarProducto
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
		Txt_codigo.Clear()
		Txt_Nombre.Clear()
		Txt_StockMaximo.Clear()
		Txt_StockMinimo.Clear()
		Txt_Strock.Clear()
	End Sub

	Private Sub Txt_Strock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Strock.KeyPress
		If Char.IsDigit(e.KeyChar) Then
			e.Handled = False
		ElseIf Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
			MsgBox("Solo se puede ingresar  números", MsgBoxStyle.Exclamation, "Ingreso de Número")
		End If
	End Sub


	Private Sub Txt_StockMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_StockMinimo.KeyPress
		If Char.IsDigit(e.KeyChar) Then
			e.Handled = False
		ElseIf Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
			MsgBox("Solo se puede ingresar  números", MsgBoxStyle.Exclamation, "Ingreso de Número")
		End If
	End Sub

	Private Sub Txt_StockMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_StockMaximo.KeyPress
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
		Txt_codigo.Clear()
		Txt_Nombre.Clear()
		Txt_StockMaximo.Clear()
		Txt_StockMinimo.Clear()
		Txt_Strock.Clear()
	End Sub

	Private Sub Btn_GuardaInventa_Click(sender As Object, e As EventArgs) Handles Btn_GuardaInventa.Click
		Dim conexion As New SqlConnection("Data Source=localhost;Initial Catalog=HNSolutionS2;Integrated Security=True")
		Dim command As New SqlCommand("IngresarArticulos", conexion)
		command.CommandType = CommandType.StoredProcedure
		command.Parameters.AddWithValue("@CodigoI", Txt_codigo.Text)
		command.Parameters.AddWithValue("@NomI", Txt_Nombre.Text)
		command.Parameters.AddWithValue("@Stock", Txt_Strock.Text)
		command.Parameters.AddWithValue("@StockM", Txt_StockMinimo.Text)
		command.Parameters.AddWithValue("@StockMx", Txt_StockMaximo.Text)
		Try
			conexion.Open()
			command.ExecuteNonQuery()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			conexion.Dispose()
			command.Dispose()
			MsgBox("Artículo Registrado Correctamente", vbInformation, "Sistema")
		End Try
	End Sub
End Class