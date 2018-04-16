<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class est_Informacion_Financiera
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
        Me.codigo_semestre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.total_creditos = New System.Windows.Forms.TextBox()
        Me.total_beca = New System.Windows.Forms.TextBox()
        Me.total_sub_balance = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.total_balance = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'codigo_semestre
        '
        Me.codigo_semestre.FormattingEnabled = True
        Me.codigo_semestre.Items.AddRange(New Object() {"2018-10 (Ago-Dec 2017)", "2018-30 (Ene-May 2018)", "2019-10 (Ago-Dec 2018)"})
        Me.codigo_semestre.Location = New System.Drawing.Point(253, 63)
        Me.codigo_semestre.Name = "codigo_semestre"
        Me.codigo_semestre.Size = New System.Drawing.Size(121, 21)
        Me.codigo_semestre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo semestre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total creditos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total beca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sub balance"
        '
        'total_creditos
        '
        Me.total_creditos.Location = New System.Drawing.Point(253, 187)
        Me.total_creditos.Name = "total_creditos"
        Me.total_creditos.Size = New System.Drawing.Size(121, 20)
        Me.total_creditos.TabIndex = 5
        '
        'total_beca
        '
        Me.total_beca.Location = New System.Drawing.Point(253, 234)
        Me.total_beca.Name = "total_beca"
        Me.total_beca.Size = New System.Drawing.Size(121, 20)
        Me.total_beca.TabIndex = 6
        '
        'total_sub_balance
        '
        Me.total_sub_balance.Location = New System.Drawing.Point(253, 276)
        Me.total_sub_balance.Name = "total_sub_balance"
        Me.total_sub_balance.Size = New System.Drawing.Size(121, 20)
        Me.total_sub_balance.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(253, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calcular balance"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'total_balance
        '
        Me.total_balance.Location = New System.Drawing.Point(253, 322)
        Me.total_balance.Name = "total_balance"
        Me.total_balance.Size = New System.Drawing.Size(121, 20)
        Me.total_balance.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Balance"
        '
        'est_Informacion_Financiera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 474)
        Me.Controls.Add(Me.total_balance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total_sub_balance)
        Me.Controls.Add(Me.total_beca)
        Me.Controls.Add(Me.total_creditos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.codigo_semestre)
        Me.Name = "est_Informacion_Financiera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "est_Informacion_Financiera"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents codigo_semestre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents total_creditos As TextBox
    Friend WithEvents total_beca As TextBox
    Friend WithEvents total_sub_balance As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents total_balance As TextBox
    Friend WithEvents Label5 As Label
End Class
