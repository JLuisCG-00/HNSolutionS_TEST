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
		Me.btn_agregar.Size = New System.Drawing.Size(109, 52)
		Me.btn_agregar.TabIndex = 31
		Me.btn_agregar.Text = "Agregar"
		Me.btn_agregar.UseVisualStyleBackColor = False
		'
		'TablaArticulosDGV
		'
		Me.TablaArticulosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.TablaArticulosDGV.Location = New System.Drawing.Point(30, 158)
		Me.TablaArticulosDGV.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
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
		Me.Btn_Buscar.Location = New System.Drawing.Point(757, 97)
		Me.Btn_Buscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Btn_Buscar.Name = "Btn_Buscar"
		Me.Btn_Buscar.Size = New System.Drawing.Size(109, 47)
		Me.Btn_Buscar.TabIndex = 35
		Me.Btn_Buscar.Text = "Buscar"
		Me.Btn_Buscar.UseVisualStyleBackColor = False
		'
		'Txt_buscar
		'
		Me.Txt_buscar.Location = New System.Drawing.Point(404, 104)
		Me.Txt_buscar.Name = "Txt_buscar"
		Me.Txt_buscar.Size = New System.Drawing.Size(337, 31)
		Me.Txt_buscar.TabIndex = 34
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Transparent
		Me.Button1.BackgroundImage = Global.HNSolutionS_TEST.My.Resources.Resources.Actualizar1
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(53, 87)
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
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Name = "InventarioOG"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Inventario"
		CType(Me.TablaArticulosDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents btn_agregar As Button
	Friend WithEvents TablaArticulosDGV As DataGridView
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents Txt_buscar As TextBox
	Friend WithEvents Button1 As Button
End Class
