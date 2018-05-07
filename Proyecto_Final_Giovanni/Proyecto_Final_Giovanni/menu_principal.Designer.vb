<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_principal
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_principal))
        Me.tb_usuario = New System.Windows.Forms.TextBox()
        Me.tb_contrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_acceder = New System.Windows.Forms.Button()
<<<<<<< HEAD

=======
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
>>>>>>> master
        Me.SuspendLayout()
        '
        'tb_usuario
        '
        Me.tb_usuario.Location = New System.Drawing.Point(221, 148)
        Me.tb_usuario.Name = "tb_usuario"
        Me.tb_usuario.Size = New System.Drawing.Size(100, 20)
        Me.tb_usuario.TabIndex = 0
        '
        'tb_contrasena
        '
        Me.tb_contrasena.Location = New System.Drawing.Point(221, 235)
        Me.tb_contrasena.Name = "tb_contrasena"
        Me.tb_contrasena.Size = New System.Drawing.Size(100, 20)
        Me.tb_contrasena.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'btn_acceder
        '
        Me.btn_acceder.Location = New System.Drawing.Point(221, 287)
        Me.btn_acceder.Name = "btn_acceder"
        Me.btn_acceder.Size = New System.Drawing.Size(100, 23)
        Me.btn_acceder.TabIndex = 4
        Me.btn_acceder.Text = "Acceder"
        Me.btn_acceder.UseVisualStyleBackColor = True
<<<<<<< HEAD

=======
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Olvidar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(77, 343)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Nuevo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(375, 343)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Cambiar "
        Me.Button4.UseVisualStyleBackColor = True
>>>>>>> master
        '
        'menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 474)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_acceder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_contrasena)
        Me.Controls.Add(Me.tb_usuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menu_principal"
<<<<<<< HEAD

        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen

=======
>>>>>>> master
        Me.Text = "Menu principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_usuario As TextBox
    Friend WithEvents tb_contrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_acceder As Button
<<<<<<< HEAD

    Private WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
=======
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
>>>>>>> master
End Class
