<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class olvidar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Answers = New System.Windows.Forms.TextBox()
        Me.Question = New System.Windows.Forms.TextBox()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QuestionID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.Controls.Add(Me.Answers)
        Me.GroupBox1.Controls.Add(Me.Question)
        Me.GroupBox1.Controls.Add(Me.UserID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.QuestionID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 252)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar mi contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Contraseña"
        '
        'password
        '
        Me.password.Enabled = False
        Me.password.Location = New System.Drawing.Point(163, 170)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(100, 20)
        Me.password.TabIndex = 9
        '
        'Answers
        '
        Me.Answers.Location = New System.Drawing.Point(163, 132)
        Me.Answers.Name = "Answers"
        Me.Answers.Size = New System.Drawing.Size(100, 20)
        Me.Answers.TabIndex = 8
        '
        'Question
        '
        Me.Question.Location = New System.Drawing.Point(163, 87)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(100, 20)
        Me.Question.TabIndex = 7
        '
        'UserID
        '
        Me.UserID.Location = New System.Drawing.Point(163, 36)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(100, 20)
        Me.UserID.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Respuesta"
        '
        'QuestionID
        '
        Me.QuestionID.AutoSize = True
        Me.QuestionID.Location = New System.Drawing.Point(58, 90)
        Me.QuestionID.Name = "QuestionID"
        Me.QuestionID.Size = New System.Drawing.Size(50, 13)
        Me.QuestionID.TabIndex = 4
        Me.QuestionID.Text = "Pregunta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID usuario"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(265, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(163, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Menu "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(61, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'olvidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 390)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "olvidar"
        Me.Text = "olvidar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Answers As TextBox
    Friend WithEvents Question As TextBox
    Friend WithEvents UserID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents QuestionID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
