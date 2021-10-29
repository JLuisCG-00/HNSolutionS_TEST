<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Eliminar = New System.Windows.Forms.Button()
		Me.BtnAnadir = New System.Windows.Forms.Button()
		Me.BtnBuscar = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(384, 73)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(276, 27)
		Me.Label2.TabIndex = 19
		Me.Label2.Text = "IMPORTADORA NOELIA"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Eliminar
		'
		Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Eliminar.Location = New System.Drawing.Point(808, 174)
		Me.Eliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Eliminar.Name = "Eliminar"
		Me.Eliminar.Size = New System.Drawing.Size(107, 38)
		Me.Eliminar.TabIndex = 17
		Me.Eliminar.Text = "Cancelar"
		Me.Eliminar.UseVisualStyleBackColor = True
		'
		'BtnAnadir
		'
		Me.BtnAnadir.Location = New System.Drawing.Point(692, 174)
		Me.BtnAnadir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnAnadir.Name = "BtnAnadir"
		Me.BtnAnadir.Size = New System.Drawing.Size(107, 38)
		Me.BtnAnadir.TabIndex = 16
		Me.BtnAnadir.Text = "Añadir"
		Me.BtnAnadir.UseVisualStyleBackColor = True
		'
		'BtnBuscar
		'
		Me.BtnBuscar.Location = New System.Drawing.Point(449, 174)
		Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnBuscar.Name = "BtnBuscar"
		Me.BtnBuscar.Size = New System.Drawing.Size(107, 38)
		Me.BtnBuscar.TabIndex = 15
		Me.BtnBuscar.Text = "Buscar"
		Me.BtnBuscar.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(124, 174)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(317, 31)
		Me.TextBox1.TabIndex = 14
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.Location = New System.Drawing.Point(113, 157)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(455, 69)
		Me.Label3.TabIndex = 20
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
		Me.DataGridView1.Location = New System.Drawing.Point(113, 265)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersWidth = 62
		Me.DataGridView1.RowTemplate.Height = 33
		Me.DataGridView1.Size = New System.Drawing.Size(661, 225)
		Me.DataGridView1.TabIndex = 21
		'
		'Column1
		'
		Me.Column1.HeaderText = "Numero De Identidad"
		Me.Column1.MinimumWidth = 8
		Me.Column1.Name = "Column1"
		Me.Column1.Width = 150
		'
		'Column2
		'
		Me.Column2.HeaderText = "Nombre"
		Me.Column2.MinimumWidth = 8
		Me.Column2.Name = "Column2"
		Me.Column2.Width = 150
		'
		'Column3
		'
		Me.Column3.HeaderText = "Telefono"
		Me.Column3.MinimumWidth = 8
		Me.Column3.Name = "Column3"
		Me.Column3.Width = 150
		'
		'Column4
		'
		Me.Column4.HeaderText = "Direccion"
		Me.Column4.MinimumWidth = 8
		Me.Column4.Name = "Column4"
		Me.Column4.Width = 150
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.RoyalBlue
		Me.PictureBox1.Location = New System.Drawing.Point(-67, -7)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(1170, 59)
		Me.PictureBox1.TabIndex = 22
		Me.PictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(342, 128)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 25)
		Me.Label1.TabIndex = 23
		Me.Label1.Text = "Label1"
		'
		'Clientes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1035, 535)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Eliminar)
		Me.Controls.Add(Me.BtnAnadir)
		Me.Controls.Add(Me.BtnBuscar)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label3)
		Me.Name = "Clientes"
		Me.Text = "Clientes"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label2 As Label
	Friend WithEvents Eliminar As Button
	Friend WithEvents BtnAnadir As Button
	Friend WithEvents BtnBuscar As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents Column4 As DataGridViewTextBoxColumn
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
End Class
