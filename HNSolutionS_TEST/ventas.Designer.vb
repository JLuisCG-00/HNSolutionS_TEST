<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtFecha = New System.Windows.Forms.TextBox()
		Me.txtNFactura = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Txt_Comentario = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Btn_Cancelar = New System.Windows.Forms.Button()
		Me.Btn_Imprimir = New System.Windows.Forms.Button()
		Me.txtNomClient = New System.Windows.Forms.TextBox()
		Me.txtCodClient = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.txtCodArt = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtNomArt = New System.Windows.Forms.TextBox()
		Me.DGClientes = New System.Windows.Forms.DataGridView()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtTelClient = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtxDescuento = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtTotal = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtImpuesto = New System.Windows.Forms.TextBox()
		Me.TextBox9 = New System.Windows.Forms.TextBox()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtFecha)
		Me.GroupBox1.Controls.Add(Me.txtNFactura)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Txt_Comentario)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.GroupBox1.Location = New System.Drawing.Point(24, 87)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(516, 350)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Información de factura"
		'
		'txtFecha
		'
		Me.txtFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.txtFecha.Location = New System.Drawing.Point(210, 95)
		Me.txtFecha.Name = "txtFecha"
		Me.txtFecha.Size = New System.Drawing.Size(277, 30)
		Me.txtFecha.TabIndex = 14
		Me.txtFecha.Text = "Ej: 01/01/2021(mes-dia-año)"
		'
		'txtNFactura
		'
		Me.txtNFactura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.txtNFactura.Location = New System.Drawing.Point(210, 48)
		Me.txtNFactura.Name = "txtNFactura"
		Me.txtNFactura.Size = New System.Drawing.Size(277, 30)
		Me.txtNFactura.TabIndex = 13
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(4, 53)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(193, 24)
		Me.Label4.TabIndex = 12
		Me.Label4.Text = "Número de factura:"
		'
		'Txt_Comentario
		'
		Me.Txt_Comentario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Txt_Comentario.Location = New System.Drawing.Point(210, 142)
		Me.Txt_Comentario.Multiline = True
		Me.Txt_Comentario.Name = "Txt_Comentario"
		Me.Txt_Comentario.Size = New System.Drawing.Size(277, 177)
		Me.Txt_Comentario.TabIndex = 8
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 145)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(137, 24)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Comentarios:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 100)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 24)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Fecha:"
		'
		'Btn_Cancelar
		'
		Me.Btn_Cancelar.BackColor = System.Drawing.Color.Red
		Me.Btn_Cancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_Cancelar.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_cancel_48
		Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Btn_Cancelar.Location = New System.Drawing.Point(727, 610)
		Me.Btn_Cancelar.Name = "Btn_Cancelar"
		Me.Btn_Cancelar.Size = New System.Drawing.Size(171, 52)
		Me.Btn_Cancelar.TabIndex = 16
		Me.Btn_Cancelar.Text = "Cancelar"
		Me.Btn_Cancelar.UseVisualStyleBackColor = False
		'
		'Btn_Imprimir
		'
		Me.Btn_Imprimir.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.Btn_Imprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_Imprimir.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_guardar_40
		Me.Btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Btn_Imprimir.Location = New System.Drawing.Point(727, 540)
		Me.Btn_Imprimir.Name = "Btn_Imprimir"
		Me.Btn_Imprimir.Size = New System.Drawing.Size(171, 52)
		Me.Btn_Imprimir.TabIndex = 15
		Me.Btn_Imprimir.Text = "Guardar"
		Me.Btn_Imprimir.UseVisualStyleBackColor = False
		'
		'txtNomClient
		'
		Me.txtNomClient.Location = New System.Drawing.Point(123, 123)
		Me.txtNomClient.Name = "txtNomClient"
		Me.txtNomClient.Size = New System.Drawing.Size(197, 30)
		Me.txtNomClient.TabIndex = 11
		'
		'txtCodClient
		'
		Me.txtCodClient.Location = New System.Drawing.Point(123, 60)
		Me.txtCodClient.Name = "txtCodClient"
		Me.txtCodClient.Size = New System.Drawing.Size(127, 30)
		Me.txtCodClient.TabIndex = 10
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(29, 68)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(84, 24)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Código:"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.txtCodArt)
		Me.GroupBox2.Controls.Add(Me.Label10)
		Me.GroupBox2.Controls.Add(Me.Label11)
		Me.GroupBox2.Controls.Add(Me.txtNomArt)
		Me.GroupBox2.Controls.Add(Me.DGClientes)
		Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.GroupBox2.Location = New System.Drawing.Point(24, 458)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(617, 467)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Artículos:"
		'
		'txtCodArt
		'
		Me.txtCodArt.Location = New System.Drawing.Point(121, 50)
		Me.txtCodArt.Name = "txtCodArt"
		Me.txtCodArt.Size = New System.Drawing.Size(121, 30)
		Me.txtCodArt.TabIndex = 15
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(20, 107)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(91, 24)
		Me.Label10.TabIndex = 14
		Me.Label10.Text = "Nombre:"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(20, 53)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(84, 24)
		Me.Label11.TabIndex = 13
		Me.Label11.Text = "Código:"
		'
		'txtNomArt
		'
		Me.txtNomArt.Location = New System.Drawing.Point(121, 100)
		Me.txtNomArt.Name = "txtNomArt"
		Me.txtNomArt.Size = New System.Drawing.Size(304, 30)
		Me.txtNomArt.TabIndex = 2
		'
		'DGClientes
		'
		Me.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGClientes.Location = New System.Drawing.Point(6, 168)
		Me.DGClientes.Name = "DGClientes"
		Me.DGClientes.RowHeadersWidth = 62
		Me.DGClientes.RowTemplate.Height = 33
		Me.DGClientes.Size = New System.Drawing.Size(591, 283)
		Me.DGClientes.TabIndex = 0
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Image = Global.HNSolutionS_TEST.My.Resources.Resources.venta
		Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label6.Location = New System.Drawing.Point(1, -3)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(936, 63)
		Me.Label6.TabIndex = 24
		Me.Label6.Text = "Orden de venta"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Label9)
		Me.GroupBox3.Controls.Add(Me.txtTelClient)
		Me.GroupBox3.Controls.Add(Me.Label8)
		Me.GroupBox3.Controls.Add(Me.txtNomClient)
		Me.GroupBox3.Controls.Add(Me.Label3)
		Me.GroupBox3.Controls.Add(Me.txtCodClient)
		Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.GroupBox3.Location = New System.Drawing.Point(547, 87)
		Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox3.Size = New System.Drawing.Size(353, 350)
		Me.GroupBox3.TabIndex = 26
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Información del cliente"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(14, 185)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(99, 24)
		Me.Label9.TabIndex = 14
		Me.Label9.Text = "Teléfono:"
		'
		'txtTelClient
		'
		Me.txtTelClient.Location = New System.Drawing.Point(120, 182)
		Me.txtTelClient.Name = "txtTelClient"
		Me.txtTelClient.Size = New System.Drawing.Size(197, 30)
		Me.txtTelClient.TabIndex = 13
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(21, 127)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(91, 24)
		Me.Label8.TabIndex = 12
		Me.Label8.Text = "Nombre:"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(660, 795)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(92, 25)
		Me.Label13.TabIndex = 29
		Me.Label13.Text = "Impuesto:"
		'
		'txtxDescuento
		'
		Me.txtxDescuento.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.txtxDescuento.Location = New System.Drawing.Point(761, 837)
		Me.txtxDescuento.Name = "txtxDescuento"
		Me.txtxDescuento.Size = New System.Drawing.Size(137, 31)
		Me.txtxDescuento.TabIndex = 28
		Me.txtxDescuento.Text = "0.00"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(650, 840)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(100, 25)
		Me.Label12.TabIndex = 27
		Me.Label12.Text = "Descuento:"
		'
		'txtTotal
		'
		Me.txtTotal.AcceptsReturn = True
		Me.txtTotal.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.txtTotal.Location = New System.Drawing.Point(761, 882)
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.Size = New System.Drawing.Size(137, 31)
		Me.txtTotal.TabIndex = 4
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(667, 750)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(83, 25)
		Me.Label14.TabIndex = 31
		Me.Label14.Text = "Subtotal:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(696, 885)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(53, 25)
		Me.Label5.TabIndex = 3
		Me.Label5.Text = "Total:"
		'
		'txtImpuesto
		'
		Me.txtImpuesto.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.txtImpuesto.Location = New System.Drawing.Point(761, 792)
		Me.txtImpuesto.Name = "txtImpuesto"
		Me.txtImpuesto.Size = New System.Drawing.Size(137, 31)
		Me.txtImpuesto.TabIndex = 30
		'
		'TextBox9
		'
		Me.TextBox9.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.TextBox9.Location = New System.Drawing.Point(761, 747)
		Me.TextBox9.Name = "TextBox9"
		Me.TextBox9.Size = New System.Drawing.Size(137, 31)
		Me.TextBox9.TabIndex = 32
		'
		'ventas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(937, 937)
		Me.Controls.Add(Me.TextBox9)
		Me.Controls.Add(Me.txtImpuesto)
		Me.Controls.Add(Me.Btn_Cancelar)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Btn_Imprimir)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.txtxDescuento)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.Label13)
		Me.Name = "ventas"
		Me.ShowIcon = False
		Me.Text = "ventas"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNFactura As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNomClient As TextBox
    Friend WithEvents txtCodClient As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Comentario As TextBox
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents txtNomArt As TextBox
    Friend WithEvents DGClientes As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTelClient As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtxDescuento As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents txtCodArt As TextBox
    Friend WithEvents txtFecha As TextBox
End Class
