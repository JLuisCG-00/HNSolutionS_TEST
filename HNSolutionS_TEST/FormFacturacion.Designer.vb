<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFacturacion
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFacturacion))
		Me.MostrarFacturasDGV = New System.Windows.Forms.DataGridView()
		Me.Eliminar = New System.Windows.Forms.Button()
		Me.BtnAnadir = New System.Windows.Forms.Button()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.btnRefresh = New System.Windows.Forms.Button()
		CType(Me.MostrarFacturasDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MostrarFacturasDGV
		'
		Me.MostrarFacturasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.MostrarFacturasDGV.Location = New System.Drawing.Point(27, 137)
		Me.MostrarFacturasDGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MostrarFacturasDGV.Name = "MostrarFacturasDGV"
		Me.MostrarFacturasDGV.RowHeadersWidth = 62
		Me.MostrarFacturasDGV.RowTemplate.Height = 25
		Me.MostrarFacturasDGV.Size = New System.Drawing.Size(886, 385)
		Me.MostrarFacturasDGV.TabIndex = 0
		'
		'Eliminar
		'
		Me.Eliminar.BackColor = System.Drawing.Color.Red
		Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Eliminar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Eliminar.Location = New System.Drawing.Point(746, 80)
		Me.Eliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Eliminar.Name = "Eliminar"
		Me.Eliminar.Size = New System.Drawing.Size(161, 46)
		Me.Eliminar.TabIndex = 24
		Me.Eliminar.Text = "Cancelar"
		Me.Eliminar.UseVisualStyleBackColor = False
		'
		'BtnAnadir
		'
		Me.BtnAnadir.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.BtnAnadir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnAnadir.Location = New System.Drawing.Point(574, 80)
		Me.BtnAnadir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnAnadir.Name = "BtnAnadir"
		Me.BtnAnadir.Size = New System.Drawing.Size(164, 46)
		Me.BtnAnadir.TabIndex = 23
		Me.BtnAnadir.Text = "Añadir"
		Me.BtnAnadir.UseVisualStyleBackColor = False
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Label17.Location = New System.Drawing.Point(370, 15)
		Me.Label17.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(169, 29)
		Me.Label17.TabIndex = 26
		Me.Label17.Text = "FACTURACIÓN"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.PictureBox1.Image = Global.HNSolutionS_TEST.My.Resources.Resources.pagos1
		Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(923, 58)
		Me.PictureBox1.TabIndex = 27
		Me.PictureBox1.TabStop = False
		'
		'btnRefresh
		'
		Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
		Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
		Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnRefresh.Location = New System.Drawing.Point(27, 80)
		Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(40, 47)
		Me.btnRefresh.TabIndex = 37
		Me.btnRefresh.UseVisualStyleBackColor = False
		'
		'FormFacturacion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(924, 567)
		Me.Controls.Add(Me.btnRefresh)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Eliminar)
		Me.Controls.Add(Me.BtnAnadir)
		Me.Controls.Add(Me.MostrarFacturasDGV)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "FormFacturacion"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Facturación"
		CType(Me.MostrarFacturasDGV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MostrarFacturasDGV As DataGridView
    Friend WithEvents Eliminar As Button
    Friend WithEvents BtnAnadir As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRefresh As Button
End Class
