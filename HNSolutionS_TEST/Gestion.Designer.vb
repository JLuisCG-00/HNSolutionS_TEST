<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.Btn_Consulta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Anadir = New System.Windows.Forms.Button()
        Me.Txt_buscar = New System.Windows.Forms.TextBox()
        Me.UsuariosDGV = New System.Windows.Forms.DataGridView()
        CType(Me.UsuariosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Buscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Buscar.Location = New System.Drawing.Point(432, 73)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(76, 28)
        Me.Btn_Buscar.TabIndex = 31
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.UseVisualStyleBackColor = False
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.BackColor = System.Drawing.Color.DarkCyan
        Me.Btn_Consulta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Consulta.Location = New System.Drawing.Point(514, 73)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(76, 28)
        Me.Btn_Consulta.TabIndex = 30
        Me.Btn_Consulta.Text = "Consultar"
        Me.Btn_Consulta.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(720, 37)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "GESTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(281, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "IMPORTADORA NOELIA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Anadir
        '
        Me.Btn_Anadir.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Btn_Anadir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Anadir.Location = New System.Drawing.Point(603, 73)
        Me.Btn_Anadir.Name = "Btn_Anadir"
        Me.Btn_Anadir.Size = New System.Drawing.Size(76, 28)
        Me.Btn_Anadir.TabIndex = 27
        Me.Btn_Anadir.Text = "Nuevo"
        Me.Btn_Anadir.UseVisualStyleBackColor = False
        '
        'Txt_buscar
        '
        Me.Txt_buscar.Location = New System.Drawing.Point(191, 77)
        Me.Txt_buscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_buscar.Name = "Txt_buscar"
        Me.Txt_buscar.Size = New System.Drawing.Size(237, 23)
        Me.Txt_buscar.TabIndex = 32
        '
        'UsuariosDGV
        '
        Me.UsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDGV.Location = New System.Drawing.Point(45, 130)
        Me.UsuariosDGV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UsuariosDGV.Name = "UsuariosDGV"
        Me.UsuariosDGV.RowHeadersWidth = 62
        Me.UsuariosDGV.RowTemplate.Height = 33
        Me.UsuariosDGV.Size = New System.Drawing.Size(622, 193)
        Me.UsuariosDGV.TabIndex = 33
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 373)
        Me.Controls.Add(Me.UsuariosDGV)
        Me.Controls.Add(Me.Txt_buscar)
        Me.Controls.Add(Me.Btn_Buscar)
        Me.Controls.Add(Me.Btn_Consulta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Anadir)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Gestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion"
        CType(Me.UsuariosDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Buscar As Button
	Friend WithEvents Btn_Consulta As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Btn_Anadir As Button
	Friend WithEvents Txt_buscar As TextBox
	Friend WithEvents UsuariosDGV As DataGridView
End Class
