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

	Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class