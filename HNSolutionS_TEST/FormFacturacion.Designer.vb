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
        Me.MostrarFacturasDGV = New System.Windows.Forms.DataGridView()
        CType(Me.MostrarFacturasDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MostrarFacturasDGV
        '
        Me.MostrarFacturasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MostrarFacturasDGV.Location = New System.Drawing.Point(21, 162)
        Me.MostrarFacturasDGV.Name = "MostrarFacturasDGV"
        Me.MostrarFacturasDGV.RowTemplate.Height = 25
        Me.MostrarFacturasDGV.Size = New System.Drawing.Size(815, 340)
        Me.MostrarFacturasDGV.TabIndex = 0
        '
        'FormFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 526)
        Me.Controls.Add(Me.MostrarFacturasDGV)
        Me.Name = "FormFacturacion"
        Me.Text = "FormFacturacion"
        CType(Me.MostrarFacturasDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MostrarFacturasDGV As DataGridView
End Class
