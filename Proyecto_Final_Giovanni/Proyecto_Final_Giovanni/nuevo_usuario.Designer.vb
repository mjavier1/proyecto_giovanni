﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevo_usuario
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Answers = New System.Windows.Forms.TextBox()
        Me.Question = New System.Windows.Forms.TextBox()
        Me.PassRect = New System.Windows.Forms.TextBox()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Pregunta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Respuesta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 26)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Ingresa nuevamente " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tu contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "UserID"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(268, 113)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(100, 20)
        Me.Password.TabIndex = 22
        '
        'Answers
        '
        Me.Answers.Location = New System.Drawing.Point(268, 221)
        Me.Answers.Name = "Answers"
        Me.Answers.Size = New System.Drawing.Size(100, 20)
        Me.Answers.TabIndex = 21
        '
        'Question
        '
        Me.Question.Location = New System.Drawing.Point(268, 185)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(100, 20)
        Me.Question.TabIndex = 20
        '
        'PassRect
        '
        Me.PassRect.Location = New System.Drawing.Point(268, 150)
        Me.PassRect.Name = "PassRect"
        Me.PassRect.Size = New System.Drawing.Size(100, 20)
        Me.PassRect.TabIndex = 19
        '
        'UserID
        '
        Me.UserID.Location = New System.Drawing.Point(268, 87)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(100, 20)
        Me.UserID.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nuevo_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 435)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Answers)
        Me.Controls.Add(Me.Question)
        Me.Controls.Add(Me.PassRect)
        Me.Controls.Add(Me.UserID)
        Me.Controls.Add(Me.Button1)
        Me.Name = "nuevo_usuario"
        Me.Text = "Nuevo usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Answers As TextBox
    Friend WithEvents Question As TextBox
    Friend WithEvents PassRect As TextBox
    Friend WithEvents UserID As TextBox
    Friend WithEvents Button1 As Button
End Class
