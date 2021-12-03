<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioOG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
<<<<<<< HEAD
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBReporte = New System.Windows.Forms.GroupBox()
        Me.TxtDirrecion = New System.Windows.Forms.TextBox()
        Me.TxtDatosClientes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbSucursal = New System.Windows.Forms.ComboBox()
        Me.Btn_ProInv = New System.Windows.Forms.Button()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.btn_ReporteInventario = New System.Windows.Forms.Button()
        Me.BtnAjustes = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMBReporte.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(771, 38)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "INVENTARIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMBReporte
        '
        Me.CMBReporte.Controls.Add(Me.TxtDirrecion)
        Me.CMBReporte.Controls.Add(Me.TxtDatosClientes)
        Me.CMBReporte.Controls.Add(Me.Label2)
        Me.CMBReporte.Controls.Add(Me.Label4)
        Me.CMBReporte.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CMBReporte.Location = New System.Drawing.Point(1, 79)
        Me.CMBReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.CMBReporte.Name = "CMBReporte"
        Me.CMBReporte.Padding = New System.Windows.Forms.Padding(2)
        Me.CMBReporte.Size = New System.Drawing.Size(536, 129)
        Me.CMBReporte.TabIndex = 24
        Me.CMBReporte.TabStop = False
        Me.CMBReporte.Text = "REPORTE DE INVENTARIO:"
        '
        'TxtDirrecion
        '
        Me.TxtDirrecion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtDirrecion.Location = New System.Drawing.Point(49, 64)
        Me.TxtDirrecion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDirrecion.Name = "TxtDirrecion"
        Me.TxtDirrecion.Size = New System.Drawing.Size(174, 23)
        Me.TxtDirrecion.TabIndex = 4
        '
        'TxtDatosClientes
        '
        Me.TxtDatosClientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtDatosClientes.Location = New System.Drawing.Point(264, 64)
        Me.TxtDatosClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDatosClientes.Name = "TxtDatosClientes"
        Me.TxtDatosClientes.Size = New System.Drawing.Size(174, 23)
        Me.TxtDatosClientes.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(264, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad de productos en inventario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(49, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Costo de inventario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(50, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Sucursal"
        '
        'CmbSucursal
        '
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(112, 224)
        Me.CmbSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(133, 23)
        Me.CmbSucursal.TabIndex = 26
        '
        'Btn_ProInv
        '
        Me.Btn_ProInv.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Btn_ProInv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_ProInv.Location = New System.Drawing.Point(10, 38)
        Me.Btn_ProInv.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_ProInv.Name = "Btn_ProInv"
        Me.Btn_ProInv.Size = New System.Drawing.Size(234, 28)
        Me.Btn_ProInv.TabIndex = 27
        Me.Btn_ProInv.Text = "Productos bajos en Inventario"
        Me.Btn_ProInv.UseVisualStyleBackColor = False
        '
        'btn_reporte
        '
        Me.btn_reporte.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_reporte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_reporte.Location = New System.Drawing.Point(265, 38)
        Me.btn_reporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(234, 28)
        Me.btn_reporte.TabIndex = 28
        Me.btn_reporte.Text = "Reporte de movimientos"
        Me.btn_reporte.UseVisualStyleBackColor = False
        '
        'btn_ReporteInventario
        '
        Me.btn_ReporteInventario.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_ReporteInventario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_ReporteInventario.Location = New System.Drawing.Point(522, 38)
        Me.btn_ReporteInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ReporteInventario.Name = "btn_ReporteInventario"
        Me.btn_ReporteInventario.Size = New System.Drawing.Size(234, 28)
        Me.btn_ReporteInventario.TabIndex = 29
        Me.btn_ReporteInventario.Text = "Reporte de inventario"
        Me.btn_ReporteInventario.UseVisualStyleBackColor = False
        '
        'BtnAjustes
        '
        Me.BtnAjustes.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnAjustes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAjustes.Location = New System.Drawing.Point(606, 112)
        Me.BtnAjustes.Name = "BtnAjustes"
        Me.BtnAjustes.Size = New System.Drawing.Size(75, 22)
        Me.BtnAjustes.TabIndex = 30
        Me.BtnAjustes.Text = "Ajustes"
        Me.BtnAjustes.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_agregar.Location = New System.Drawing.Point(606, 143)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 22)
        Me.btn_agregar.TabIndex = 31
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_modificar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_modificar.Location = New System.Drawing.Point(606, 178)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 22)
        Me.btn_modificar.TabIndex = 32
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(50, 269)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(675, 81)
        Me.DataGridView1.TabIndex = 33
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripción_Producto"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Costo"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio_Venta"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Existencia"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'InventarioOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(766, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.BtnAjustes)
        Me.Controls.Add(Me.btn_ReporteInventario)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.Btn_ProInv)
        Me.Controls.Add(Me.CmbSucursal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CMBReporte)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "InventarioOG"
        Me.Text = "Inventario"
        Me.CMBReporte.ResumeLayout(False)
        Me.CMBReporte.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
=======
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventarioOG))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btn_agregar = New System.Windows.Forms.Button()
		Me.TablaArticulosDGV = New System.Windows.Forms.DataGridView()
		Me.Btn_Buscar = New System.Windows.Forms.Button()
		Me.Txt_buscar = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.TablaArticulosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Image = Global.HNSolutionS_TEST.My.Resources.Resources.producto2
		Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label1.Location = New System.Drawing.Point(1, -2)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(1101, 62)
		Me.Label1.TabIndex = 23
		Me.Label1.Text = "INVENTARIO"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btn_agregar
		'
		Me.btn_agregar.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.btn_agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.btn_agregar.Location = New System.Drawing.Point(882, 88)
		Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btn_agregar.Name = "btn_agregar"
		Me.btn_agregar.Size = New System.Drawing.Size(157, 48)
		Me.btn_agregar.TabIndex = 31
		Me.btn_agregar.Text = "Agregar"
		Me.btn_agregar.UseVisualStyleBackColor = False
		'
		'TablaArticulosDGV
		'
		Me.TablaArticulosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.TablaArticulosDGV.Location = New System.Drawing.Point(30, 158)
		Me.TablaArticulosDGV.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
		Me.TablaArticulosDGV.Name = "TablaArticulosDGV"
		Me.TablaArticulosDGV.RowHeadersWidth = 51
		Me.TablaArticulosDGV.RowTemplate.Height = 29
		Me.TablaArticulosDGV.Size = New System.Drawing.Size(1031, 415)
		Me.TablaArticulosDGV.TabIndex = 33
		'
		'Btn_Buscar
		'
		Me.Btn_Buscar.BackColor = System.Drawing.Color.Yellow
		Me.Btn_Buscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_Buscar.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_búsqueda_50
		Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Btn_Buscar.Location = New System.Drawing.Point(672, 89)
		Me.Btn_Buscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Btn_Buscar.Name = "Btn_Buscar"
		Me.Btn_Buscar.Size = New System.Drawing.Size(161, 48)
		Me.Btn_Buscar.TabIndex = 35
		Me.Btn_Buscar.Text = "Buscar"
		Me.Btn_Buscar.UseVisualStyleBackColor = False
		'
		'Txt_buscar
		'
		Me.Txt_buscar.Location = New System.Drawing.Point(330, 95)
		Me.Txt_buscar.Margin = New System.Windows.Forms.Padding(2)
		Me.Txt_buscar.Name = "Txt_buscar"
		Me.Txt_buscar.Size = New System.Drawing.Size(336, 31)
		Me.Txt_buscar.TabIndex = 34
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Transparent
		Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(52, 88)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(40, 48)
		Me.Button1.TabIndex = 36
		Me.Button1.UseVisualStyleBackColor = False
		'
		'InventarioOG
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(1094, 618)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Btn_Buscar)
		Me.Controls.Add(Me.Txt_buscar)
		Me.Controls.Add(Me.TablaArticulosDGV)
		Me.Controls.Add(Me.btn_agregar)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
		Me.Name = "InventarioOG"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Inventario"
		CType(Me.TablaArticulosDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
>>>>>>> c930c403da748ea7215210dbab6ea3a7f739301a

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents btn_agregar As Button
	Friend WithEvents TablaArticulosDGV As DataGridView
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents Txt_buscar As TextBox
	Friend WithEvents Button1 As Button
End Class
