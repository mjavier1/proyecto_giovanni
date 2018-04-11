<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class est_notas
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nombre_curso = New System.Windows.Forms.TextBox()
        Me.creditos_curso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nota1 = New System.Windows.Forms.TextBox()
        Me.nota2 = New System.Windows.Forms.TextBox()
        Me.nota3 = New System.Windows.Forms.TextBox()
        Me.nota4 = New System.Windows.Forms.TextBox()
        Me.codigo_curso = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'codigo_semestre
        '
        Me.codigo_semestre.FormattingEnabled = True
        Me.codigo_semestre.Items.AddRange(New Object() {"2018-10 (Ago-Dec 2017)", "2018-30 (Ene-May 2018)", "2019-10 (Ago-Dec 2018)"})
        Me.codigo_semestre.Location = New System.Drawing.Point(145, 23)
        Me.codigo_semestre.Name = "codigo_semestre"
        Me.codigo_semestre.Size = New System.Drawing.Size(121, 21)
        Me.codigo_semestre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo semestre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo curso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre del curso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Creditos del curso"
        '
        'nombre_curso
        '
        Me.nombre_curso.Location = New System.Drawing.Point(145, 157)
        Me.nombre_curso.Name = "nombre_curso"
        Me.nombre_curso.Size = New System.Drawing.Size(121, 20)
        Me.nombre_curso.TabIndex = 7
        '
        'creditos_curso
        '
        Me.creditos_curso.Location = New System.Drawing.Point(145, 219)
        Me.creditos_curso.Name = "creditos_curso"
        Me.creditos_curso.Size = New System.Drawing.Size(121, 20)
        Me.creditos_curso.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(229, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "NOTAS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Someter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nota 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nota 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(334, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nota 3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(446, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Nota 4"
        '
        'nota1
        '
        Me.nota1.Location = New System.Drawing.Point(31, 334)
        Me.nota1.Name = "nota1"
        Me.nota1.Size = New System.Drawing.Size(63, 20)
        Me.nota1.TabIndex = 15
        '
        'nota2
        '
        Me.nota2.Location = New System.Drawing.Point(145, 334)
        Me.nota2.Name = "nota2"
        Me.nota2.Size = New System.Drawing.Size(63, 20)
        Me.nota2.TabIndex = 16
        '
        'nota3
        '
        Me.nota3.Location = New System.Drawing.Point(337, 334)
        Me.nota3.Name = "nota3"
        Me.nota3.Size = New System.Drawing.Size(63, 20)
        Me.nota3.TabIndex = 17
        '
        'nota4
        '
        Me.nota4.Location = New System.Drawing.Point(449, 334)
        Me.nota4.Name = "nota4"
        Me.nota4.Size = New System.Drawing.Size(63, 20)
        Me.nota4.TabIndex = 18
        '
        'codigo_curso
        '
        Me.codigo_curso.Location = New System.Drawing.Point(145, 94)
        Me.codigo_curso.Name = "codigo_curso"
        Me.codigo_curso.Size = New System.Drawing.Size(121, 20)
        Me.codigo_curso.TabIndex = 19
        '
        'est_notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 474)
        Me.Controls.Add(Me.codigo_curso)
        Me.Controls.Add(Me.nota4)
        Me.Controls.Add(Me.nota3)
        Me.Controls.Add(Me.nota2)
        Me.Controls.Add(Me.nota1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.creditos_curso)
        Me.Controls.Add(Me.nombre_curso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.codigo_semestre)
        Me.Name = "est_notas"
        Me.Text = "Estudiante - Notas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents codigo_semestre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nombre_curso As TextBox
    Friend WithEvents creditos_curso As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nota1 As TextBox
    Friend WithEvents nota2 As TextBox
    Friend WithEvents nota3 As TextBox
    Friend WithEvents nota4 As TextBox
    Friend WithEvents codigo_curso As TextBox
End Class
