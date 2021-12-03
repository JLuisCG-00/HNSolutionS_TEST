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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExportarPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClaroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OscuroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ComoUsarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Panel2.Controls.Add(Me.Panel5)
		Me.Panel2.Controls.Add(Me.Panel4)
		Me.Panel2.Controls.Add(Me.Panel3)
		Me.Panel2.Controls.Add(Me.Panel1)
		Me.Panel2.Controls.Add(Me.BtnGestion)
		Me.Panel2.Controls.Add(Me.BtnInventario)
		Me.Panel2.Controls.Add(Me.BtnFacturacion)
		Me.Panel2.Controls.Add(Me.Label1)
		Me.Panel2.Controls.Add(Me.BtnClientes)
		Me.Panel2.Location = New System.Drawing.Point(1, 117)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(325, 832)
		Me.Panel2.TabIndex = 4
		'
		'BtnGestion
		'
		Me.BtnGestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.BtnGestion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnGestion.ForeColor = System.Drawing.Color.White
		Me.BtnGestion.Image = Global.HNSolutionS_TEST.My.Resources.Resources.empleados
		Me.BtnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtnGestion.Location = New System.Drawing.Point(22, 409)
		Me.BtnGestion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnGestion.Name = "BtnGestion"
		Me.BtnGestion.Size = New System.Drawing.Size(244, 58)
		Me.BtnGestion.TabIndex = 10
		Me.BtnGestion.Text = "Gestión"
		Me.BtnGestion.UseVisualStyleBackColor = False
		'
		'BtnInventario
		'
		Me.BtnInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.BtnInventario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnInventario.ForeColor = System.Drawing.Color.White
		Me.BtnInventario.Image = Global.HNSolutionS_TEST.My.Resources.Resources.producto2
		Me.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtnInventario.Location = New System.Drawing.Point(22, 311)
		Me.BtnInventario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnInventario.Name = "BtnInventario"
		Me.BtnInventario.Size = New System.Drawing.Size(244, 58)
		Me.BtnInventario.TabIndex = 9
		Me.BtnInventario.Text = "Inventario"
		Me.BtnInventario.UseVisualStyleBackColor = False
		'
		'BtnFacturacion
		'
		Me.BtnFacturacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnFacturacion.ForeColor = System.Drawing.Color.White
		Me.BtnFacturacion.Image = Global.HNSolutionS_TEST.My.Resources.Resources.pagos
		Me.BtnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtnFacturacion.Location = New System.Drawing.Point(22, 214)
		Me.BtnFacturacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnFacturacion.Name = "BtnFacturacion"
		Me.BtnFacturacion.Size = New System.Drawing.Size(244, 58)
		Me.BtnFacturacion.TabIndex = 8
		Me.BtnFacturacion.Text = "Facturación"
		Me.BtnFacturacion.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(34, 75)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(256, 37)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Importadora Noelia"
		'
		'BtnClientes
		'
		Me.BtnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.BtnClientes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnClientes.ForeColor = System.Drawing.Color.White
		Me.BtnClientes.Image = Global.HNSolutionS_TEST.My.Resources.Resources.clientes
		Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtnClientes.Location = New System.Drawing.Point(22, 120)
		Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnClientes.Name = "BtnClientes"
		Me.BtnClientes.Size = New System.Drawing.Size(244, 58)
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
		Me.LblHora.Location = New System.Drawing.Point(860, 243)
		Me.LblHora.Name = "LblHora"
		Me.LblHora.Size = New System.Drawing.Size(260, 128)
		Me.LblHora.TabIndex = 11
		Me.LblHora.Text = "Hora"
		'
		'LblFecha
		'
		Me.LblFecha.AutoSize = True
		Me.LblFecha.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.LblFecha.ForeColor = System.Drawing.SystemColors.Highlight
		Me.LblFecha.Location = New System.Drawing.Point(644, 428)
		Me.LblFecha.Name = "LblFecha"
		Me.LblFecha.Size = New System.Drawing.Size(174, 74)
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
		Me.PictureBox1.Location = New System.Drawing.Point(1, 47)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(325, 133)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 13
		Me.PictureBox1.TabStop = False
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.TemaToolStripMenuItem, Me.AyudaToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
		Me.MenuStrip1.Size = New System.Drawing.Size(1649, 35)
		Me.MenuStrip1.TabIndex = 14
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'ArchivoToolStripMenuItem
		'
		Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem, Me.ExportarPDFToolStripMenuItem, Me.SalirToolStripMenuItem})
		Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
		Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
		Me.ArchivoToolStripMenuItem.Text = "Archivo"
		'
		'ImprimirToolStripMenuItem
		'
		Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
		Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(217, 34)
		Me.ImprimirToolStripMenuItem.Text = "Imprimir"
		'
		'ExportarPDFToolStripMenuItem
		'
		Me.ExportarPDFToolStripMenuItem.Name = "ExportarPDFToolStripMenuItem"
		Me.ExportarPDFToolStripMenuItem.Size = New System.Drawing.Size(217, 34)
		Me.ExportarPDFToolStripMenuItem.Text = "Exportar PDF"
		'
		'SalirToolStripMenuItem
		'
		Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
		Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(217, 34)
		Me.SalirToolStripMenuItem.Text = "Salir"
		'
		'TemaToolStripMenuItem
		'
		Me.TemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClaroToolStripMenuItem, Me.OscuroToolStripMenuItem})
		Me.TemaToolStripMenuItem.Name = "TemaToolStripMenuItem"
		Me.TemaToolStripMenuItem.Size = New System.Drawing.Size(69, 29)
		Me.TemaToolStripMenuItem.Text = "Tema"
		'
		'ClaroToolStripMenuItem
		'
		Me.ClaroToolStripMenuItem.Name = "ClaroToolStripMenuItem"
		Me.ClaroToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
		Me.ClaroToolStripMenuItem.Text = "Claro"
		'
		'OscuroToolStripMenuItem
		'
		Me.OscuroToolStripMenuItem.Name = "OscuroToolStripMenuItem"
		Me.OscuroToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
		Me.OscuroToolStripMenuItem.Text = "Oscuro"
		'
		'AyudaToolStripMenuItem
		'
		Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem, Me.ComoUsarToolStripMenuItem})
		Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
		Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
		Me.AyudaToolStripMenuItem.Text = "Ayuda"
		'
		'ManualToolStripMenuItem
		'
		Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
		Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(209, 34)
		Me.ManualToolStripMenuItem.Text = "Manual"
		'
		'ComoUsarToolStripMenuItem
		'
		Me.ComoUsarToolStripMenuItem.Name = "ComoUsarToolStripMenuItem"
		Me.ComoUsarToolStripMenuItem.Size = New System.Drawing.Size(209, 34)
		Me.ComoUsarToolStripMenuItem.Text = "Como usar?"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
		Me.Panel1.Location = New System.Drawing.Point(0, 120)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(24, 58)
		Me.Panel1.TabIndex = 15
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
		Me.Panel3.Location = New System.Drawing.Point(0, 214)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(24, 58)
		Me.Panel3.TabIndex = 16
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
		Me.Panel4.Location = New System.Drawing.Point(0, 311)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(24, 58)
		Me.Panel4.TabIndex = 16
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
		Me.Panel5.Location = New System.Drawing.Point(0, 409)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(24, 58)
		Me.Panel5.TabIndex = 17
		'
		'MenuPrincipal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1649, 938)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.LblFecha)
		Me.Controls.Add(Me.LblHora)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "MenuPrincipal"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MenuPrincipal"
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnInventario As Button
    Friend WithEvents BtnFacturacion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClientes As Button
    Friend WithEvents LblHora As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents HoraFecha As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnGestion As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClaroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OscuroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComoUsarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Panel4 As Panel
End Class
