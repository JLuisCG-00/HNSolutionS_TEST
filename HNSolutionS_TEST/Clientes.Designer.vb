﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.BtnAnadir = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TablaClientesDGV = New System.Windows.Forms.DataGridView()
		Me.Txt_buscar = New System.Windows.Forms.TextBox()
		Me.Btn_Buscar = New System.Windows.Forms.Button()
		CType(Me.TablaClientesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(400, 65)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(276, 27)
		Me.Label2.TabIndex = 19
		Me.Label2.Text = "IMPORTADORA NOELIA"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'BtnAnadir
		'
		Me.BtnAnadir.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.BtnAnadir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnAnadir.Location = New System.Drawing.Point(930, 103)
		Me.BtnAnadir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BtnAnadir.Name = "BtnAnadir"
		Me.BtnAnadir.Size = New System.Drawing.Size(109, 47)
		Me.BtnAnadir.TabIndex = 16
		Me.BtnAnadir.Text = "Nuevo"
		Me.BtnAnadir.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(1, -2)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(1059, 62)
		Me.Label1.TabIndex = 22
		Me.Label1.Text = "CLIENTES"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TablaClientesDGV
		'
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.TablaClientesDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.TablaClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.TablaClientesDGV.DefaultCellStyle = DataGridViewCellStyle2
		Me.TablaClientesDGV.Location = New System.Drawing.Point(17, 163)
		Me.TablaClientesDGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TablaClientesDGV.Name = "TablaClientesDGV"
		Me.TablaClientesDGV.RowHeadersWidth = 62
		Me.TablaClientesDGV.RowTemplate.Height = 25
		Me.TablaClientesDGV.Size = New System.Drawing.Size(1021, 465)
		Me.TablaClientesDGV.TabIndex = 23
		'
		'Txt_buscar
		'
		Me.Txt_buscar.Location = New System.Drawing.Point(301, 113)
		Me.Txt_buscar.Name = "Txt_buscar"
		Me.Txt_buscar.Size = New System.Drawing.Size(337, 31)
		Me.Txt_buscar.TabIndex = 25
		'
		'Btn_Buscar
		'
		Me.Btn_Buscar.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.Btn_Buscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Btn_Buscar.Location = New System.Drawing.Point(646, 103)
		Me.Btn_Buscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Btn_Buscar.Name = "Btn_Buscar"
		Me.Btn_Buscar.Size = New System.Drawing.Size(109, 47)
		Me.Btn_Buscar.TabIndex = 26
		Me.Btn_Buscar.Text = "Buscar"
		Me.Btn_Buscar.UseVisualStyleBackColor = False
		'
		'Clientes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1056, 698)
		Me.Controls.Add(Me.Btn_Buscar)
		Me.Controls.Add(Me.Txt_buscar)
		Me.Controls.Add(Me.TablaClientesDGV)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.BtnAnadir)
		Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
		Me.Name = "Clientes"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Clientes"
		CType(Me.TablaClientesDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label2 As Label
    Friend WithEvents BtnAnadir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TablaClientesDGV As DataGridView
    Friend WithEvents Txt_buscar As TextBox
    Friend WithEvents Btn_Buscar As Button
End Class
