﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtUsuario = New System.Windows.Forms.TextBox()
		Me.txtContra = New System.Windows.Forms.TextBox()
		Me.ChkContra = New System.Windows.Forms.CheckBox()
		Me.BtnIniciar = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.PictureBox1.Image = Global.HNSolutionS_TEST.My.Resources.Resources.icons8_usuario_501
		Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(466, 77)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Label1.Location = New System.Drawing.Point(121, 23)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(221, 29)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "INICIO DE SESIÓN "
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(139, 83)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(193, 158)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 3
		Me.PictureBox2.TabStop = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(190, 267)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(101, 25)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "USUARIO"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label3.Location = New System.Drawing.Point(173, 363)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(143, 25)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "CONTRASEÑA"
		'
		'txtUsuario
		'
		Me.txtUsuario.Location = New System.Drawing.Point(161, 297)
		Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.txtUsuario.Name = "txtUsuario"
		Me.txtUsuario.Size = New System.Drawing.Size(155, 31)
		Me.txtUsuario.TabIndex = 6
		'
		'txtContra
		'
		Me.txtContra.Location = New System.Drawing.Point(161, 405)
		Me.txtContra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.txtContra.Name = "txtContra"
		Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtContra.Size = New System.Drawing.Size(155, 31)
		Me.txtContra.TabIndex = 7
		'
		'ChkContra
		'
		Me.ChkContra.AutoSize = True
		Me.ChkContra.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
		Me.ChkContra.Location = New System.Drawing.Point(150, 447)
		Me.ChkContra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.ChkContra.Name = "ChkContra"
		Me.ChkContra.Size = New System.Drawing.Size(186, 26)
		Me.ChkContra.TabIndex = 8
		Me.ChkContra.Text = "Mostrar contraseña"
		Me.ChkContra.UseVisualStyleBackColor = True
		'
		'BtnIniciar
		'
		Me.BtnIniciar.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.BtnIniciar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.BtnIniciar.Location = New System.Drawing.Point(57, 503)
		Me.BtnIniciar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.BtnIniciar.Name = "BtnIniciar"
		Me.BtnIniciar.Size = New System.Drawing.Size(160, 37)
		Me.BtnIniciar.TabIndex = 9
		Me.BtnIniciar.Text = "Iniciar sesión"
		Me.BtnIniciar.UseVisualStyleBackColor = False
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.Color.Red
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnSalir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.btnSalir.Location = New System.Drawing.Point(265, 503)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(162, 37)
		Me.btnSalir.TabIndex = 10
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'LOGIN
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(467, 607)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.BtnIniciar)
		Me.Controls.Add(Me.ChkContra)
		Me.Controls.Add(Me.txtContra)
		Me.Controls.Add(Me.txtUsuario)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Name = "LOGIN"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "LOGIN"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents ChkContra As CheckBox
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents btnSalir As Button
End Class
