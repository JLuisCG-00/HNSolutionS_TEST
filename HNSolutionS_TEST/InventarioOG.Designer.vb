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
		Me.btn_agregar = New System.Windows.Forms.Button()
		Me.TablaArticulosDGV = New System.Windows.Forms.DataGridView()
		CType(Me.TablaArticulosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
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
		Me.btn_agregar.Location = New System.Drawing.Point(939, 92)
		Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btn_agregar.Name = "btn_agregar"
		Me.btn_agregar.Size = New System.Drawing.Size(109, 58)
		Me.btn_agregar.TabIndex = 31
		Me.btn_agregar.Text = "Agregar"
		Me.btn_agregar.UseVisualStyleBackColor = False
		'
		'TablaArticulosDGV
		'
		Me.TablaArticulosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.TablaArticulosDGV.Location = New System.Drawing.Point(31, 177)
		Me.TablaArticulosDGV.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.TablaArticulosDGV.Name = "TablaArticulosDGV"
		Me.TablaArticulosDGV.RowHeadersWidth = 51
		Me.TablaArticulosDGV.RowTemplate.Height = 29
		Me.TablaArticulosDGV.Size = New System.Drawing.Size(1031, 415)
		Me.TablaArticulosDGV.TabIndex = 33
		'
		'InventarioOG
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(1094, 618)
		Me.Controls.Add(Me.TablaArticulosDGV)
		Me.Controls.Add(Me.btn_agregar)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Name = "InventarioOG"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Inventario"
		CType(Me.TablaArticulosDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents btn_agregar As Button
	Friend WithEvents TablaArticulosDGV As DataGridView
End Class
