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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_ProInv = New System.Windows.Forms.Button()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.btn_ReporteInventario = New System.Windows.Forms.Button()
        Me.BtnAjustes = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.TablaArticulosDGV = New System.Windows.Forms.DataGridView()
        CType(Me.TablaArticulosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(771, 37)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "INVENTARIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_ProInv
        '
        Me.Btn_ProInv.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Btn_ProInv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_ProInv.Location = New System.Drawing.Point(10, 38)
        Me.Btn_ProInv.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Btn_ProInv.Name = "Btn_ProInv"
        Me.Btn_ProInv.Size = New System.Drawing.Size(234, 29)
        Me.Btn_ProInv.TabIndex = 27
        Me.Btn_ProInv.Text = "Productos bajos en Inventario"
        Me.Btn_ProInv.UseVisualStyleBackColor = False
        '
        'btn_reporte
        '
        Me.btn_reporte.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_reporte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_reporte.Location = New System.Drawing.Point(265, 38)
        Me.btn_reporte.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(234, 29)
        Me.btn_reporte.TabIndex = 28
        Me.btn_reporte.Text = "Reporte de movimientos"
        Me.btn_reporte.UseVisualStyleBackColor = False
        '
        'btn_ReporteInventario
        '
        Me.btn_ReporteInventario.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_ReporteInventario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_ReporteInventario.Location = New System.Drawing.Point(522, 38)
        Me.btn_ReporteInventario.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btn_ReporteInventario.Name = "btn_ReporteInventario"
        Me.btn_ReporteInventario.Size = New System.Drawing.Size(234, 29)
        Me.btn_ReporteInventario.TabIndex = 29
        Me.btn_ReporteInventario.Text = "Reporte de inventario"
        Me.btn_ReporteInventario.UseVisualStyleBackColor = False
        '
        'BtnAjustes
        '
        Me.BtnAjustes.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnAjustes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAjustes.Location = New System.Drawing.Point(504, 121)
        Me.BtnAjustes.Name = "BtnAjustes"
        Me.BtnAjustes.Size = New System.Drawing.Size(76, 23)
        Me.BtnAjustes.TabIndex = 30
        Me.BtnAjustes.Text = "Ajustes"
        Me.BtnAjustes.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_agregar.Location = New System.Drawing.Point(586, 121)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(76, 23)
        Me.btn_agregar.TabIndex = 31
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_modificar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_modificar.Location = New System.Drawing.Point(668, 121)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(76, 23)
        Me.btn_modificar.TabIndex = 32
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'TablaArticulosDGV
        '
        Me.TablaArticulosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaArticulosDGV.Location = New System.Drawing.Point(22, 161)
        Me.TablaArticulosDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TablaArticulosDGV.Name = "TablaArticulosDGV"
        Me.TablaArticulosDGV.RowHeadersWidth = 51
        Me.TablaArticulosDGV.RowTemplate.Height = 29
        Me.TablaArticulosDGV.Size = New System.Drawing.Size(722, 249)
        Me.TablaArticulosDGV.TabIndex = 33
        '
        'InventarioOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(766, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.TablaArticulosDGV)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.BtnAjustes)
        Me.Controls.Add(Me.btn_ReporteInventario)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.Btn_ProInv)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "InventarioOG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.TablaArticulosDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Btn_ProInv As Button
	Friend WithEvents btn_reporte As Button
	Friend WithEvents btn_ReporteInventario As Button
	Friend WithEvents BtnAjustes As Button
	Friend WithEvents btn_agregar As Button
	Friend WithEvents btn_modificar As Button
	Friend WithEvents TablaArticulosDGV As DataGridView
End Class
