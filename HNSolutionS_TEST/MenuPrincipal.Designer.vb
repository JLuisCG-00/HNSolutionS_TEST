<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnGestion = New System.Windows.Forms.Button()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.BtnFacturacion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.HoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnGestion)
        Me.Panel2.Controls.Add(Me.BtnInventario)
        Me.Panel2.Controls.Add(Me.BtnFacturacion)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtnClientes)
        Me.Panel2.Location = New System.Drawing.Point(1, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 428)
        Me.Panel2.TabIndex = 4
        '
        'BtnGestion
        '
        Me.BtnGestion.BackColor = System.Drawing.Color.White
        Me.BtnGestion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnGestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BtnGestion.Location = New System.Drawing.Point(14, 169)
        Me.BtnGestion.Name = "BtnGestion"
        Me.BtnGestion.Size = New System.Drawing.Size(152, 22)
        Me.BtnGestion.TabIndex = 10
        Me.BtnGestion.Text = "Gestión"
        Me.BtnGestion.UseVisualStyleBackColor = False
        '
        'BtnInventario
        '
        Me.BtnInventario.BackColor = System.Drawing.Color.White
        Me.BtnInventario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BtnInventario.Location = New System.Drawing.Point(14, 131)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(152, 22)
        Me.BtnInventario.TabIndex = 9
        Me.BtnInventario.Text = "Inventario"
        Me.BtnInventario.UseVisualStyleBackColor = False
        '
        'BtnFacturacion
        '
        Me.BtnFacturacion.BackColor = System.Drawing.Color.White
        Me.BtnFacturacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFacturacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BtnFacturacion.Location = New System.Drawing.Point(14, 89)
        Me.BtnFacturacion.Name = "BtnFacturacion"
        Me.BtnFacturacion.Size = New System.Drawing.Size(152, 22)
        Me.BtnFacturacion.TabIndex = 8
        Me.BtnFacturacion.Text = "Facturación"
        Me.BtnFacturacion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Importadora Noelia"
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.White
        Me.BtnClientes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BtnClientes.Location = New System.Drawing.Point(14, 50)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(152, 22)
        Me.BtnClientes.TabIndex = 5
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.White
        Me.LblHora.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblHora.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblHora.Location = New System.Drawing.Point(555, 145)
        Me.LblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(175, 86)
        Me.LblHora.TabIndex = 11
        Me.LblHora.Text = "Hora"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblFecha.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblFecha.Location = New System.Drawing.Point(378, 254)
        Me.LblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(120, 51)
        Me.LblFecha.TabIndex = 12
        Me.LblFecha.Text = "Fecha"
        '
        'HoraFecha
        '
        Me.HoraFecha.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1081, 496)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MenuPrincipal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
	Friend WithEvents BtnGestion As Button
	Friend WithEvents BtnInventario As Button
	Friend WithEvents BtnFacturacion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClientes As Button
	Friend WithEvents LblHora As Label
	Friend WithEvents LblFecha As Label
	Friend WithEvents HoraFecha As Timer
	Friend WithEvents PictureBox1 As PictureBox
End Class
