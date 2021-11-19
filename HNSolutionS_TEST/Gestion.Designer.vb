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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Anadir = New System.Windows.Forms.Button()
        Me.UsuariosDGV = New System.Windows.Forms.DataGridView()
        Me.Btn_Volver = New System.Windows.Forms.Button()
        CType(Me.UsuariosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Btn_Anadir.Location = New System.Drawing.Point(591, 85)
        Me.Btn_Anadir.Name = "Btn_Anadir"
        Me.Btn_Anadir.Size = New System.Drawing.Size(76, 28)
        Me.Btn_Anadir.TabIndex = 27
        Me.Btn_Anadir.Text = "Nuevo"
        Me.Btn_Anadir.UseVisualStyleBackColor = False
        '
        'UsuariosDGV
        '
        Me.UsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDGV.Location = New System.Drawing.Point(45, 130)
        Me.UsuariosDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.UsuariosDGV.Name = "UsuariosDGV"
        Me.UsuariosDGV.RowHeadersWidth = 62
        Me.UsuariosDGV.RowTemplate.Height = 33
        Me.UsuariosDGV.Size = New System.Drawing.Size(622, 193)
        Me.UsuariosDGV.TabIndex = 33
        '
        'Btn_Volver
        '
        Me.Btn_Volver.BackColor = System.Drawing.Color.Yellow
        Me.Btn_Volver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Volver.Location = New System.Drawing.Point(509, 85)
        Me.Btn_Volver.Name = "Btn_Volver"
        Me.Btn_Volver.Size = New System.Drawing.Size(76, 28)
        Me.Btn_Volver.TabIndex = 31
        Me.Btn_Volver.Text = "Volver"
        Me.Btn_Volver.UseVisualStyleBackColor = False
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 373)
        Me.Controls.Add(Me.UsuariosDGV)
        Me.Controls.Add(Me.Btn_Volver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Anadir)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Gestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion"
        CType(Me.UsuariosDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Anadir As Button
    Friend WithEvents UsuariosDGV As DataGridView
    Friend WithEvents Btn_Volver As Button
End Class
