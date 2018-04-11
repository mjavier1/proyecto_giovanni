<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_principal))
        Me.tb_usuario = New System.Windows.Forms.TextBox()
        Me.tb_contrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_acceder = New System.Windows.Forms.Button()
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
        Me.btn_acceder.Location = New System.Drawing.Point(221, 303)
        Me.btn_acceder.Name = "btn_acceder"
        Me.btn_acceder.Size = New System.Drawing.Size(100, 23)
        Me.btn_acceder.TabIndex = 4
        Me.btn_acceder.Text = "Acceder"
        Me.btn_acceder.UseVisualStyleBackColor = True
        '
        'menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 474)
        Me.Controls.Add(Me.btn_acceder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_contrasena)
        Me.Controls.Add(Me.tb_usuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menu_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_usuario As TextBox
    Friend WithEvents tb_contrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_acceder As Button
End Class
