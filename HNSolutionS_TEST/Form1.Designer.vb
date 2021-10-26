<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IMPORTADORA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMPORTADORA))
        Me.Btnlog = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtbUsuario = New System.Windows.Forms.TextBox()
        Me.txtbContra = New System.Windows.Forms.TextBox()
        Me.USUARIO = New System.Windows.Forms.Label()
        Me.CONTRASEÑA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkContra = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnlog
        '
        Me.Btnlog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnlog.Location = New System.Drawing.Point(460, 104)
        Me.Btnlog.Name = "Btnlog"
        Me.Btnlog.Size = New System.Drawing.Size(135, 32)
        Me.Btnlog.TabIndex = 0
        Me.Btnlog.Text = "Iniciar sesión"
        Me.Btnlog.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(460, 155)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 32)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtbUsuario
        '
        Me.txtbUsuario.Location = New System.Drawing.Point(271, 114)
        Me.txtbUsuario.Name = "txtbUsuario"
        Me.txtbUsuario.Size = New System.Drawing.Size(100, 22)
        Me.txtbUsuario.TabIndex = 2
        '
        'txtbContra
        '
        Me.txtbContra.Location = New System.Drawing.Point(271, 199)
        Me.txtbContra.Name = "txtbContra"
        Me.txtbContra.Size = New System.Drawing.Size(100, 22)
        Me.txtbContra.TabIndex = 3
        '
        'USUARIO
        '
        Me.USUARIO.AutoSize = True
        Me.USUARIO.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USUARIO.Location = New System.Drawing.Point(278, 90)
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.Size = New System.Drawing.Size(81, 21)
        Me.USUARIO.TabIndex = 4
        Me.USUARIO.Text = "USUARIO"
        '
        'CONTRASEÑA
        '
        Me.CONTRASEÑA.AutoSize = True
        Me.CONTRASEÑA.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTRASEÑA.Location = New System.Drawing.Point(267, 175)
        Me.CONTRASEÑA.Name = "CONTRASEÑA"
        Me.CONTRASEÑA.Size = New System.Drawing.Size(116, 21)
        Me.CONTRASEÑA.TabIndex = 5
        Me.CONTRASEÑA.Text = "CONTRASEÑA"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(607, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "INICIO DE SESIÓN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(210, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(192, 183)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "IMPORTADORA NOELIA"
        '
        'ChkContra
        '
        Me.ChkContra.AutoSize = True
        Me.ChkContra.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkContra.Location = New System.Drawing.Point(271, 227)
        Me.ChkContra.Name = "ChkContra"
        Me.ChkContra.Size = New System.Drawing.Size(148, 21)
        Me.ChkContra.TabIndex = 11
        Me.ChkContra.Text = "Mostrar contraseña"
        Me.ChkContra.UseVisualStyleBackColor = True
        '
        'IMPORTADORA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(607, 322)
        Me.Controls.Add(Me.ChkContra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CONTRASEÑA)
        Me.Controls.Add(Me.USUARIO)
        Me.Controls.Add(Me.txtbContra)
        Me.Controls.Add(Me.txtbUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Btnlog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IMPORTADORA"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMPORTADORA NOELIA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnlog As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtbUsuario As TextBox
    Friend WithEvents txtbContra As TextBox
    Friend WithEvents USUARIO As Label
    Friend WithEvents CONTRASEÑA As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkContra As CheckBox
End Class
