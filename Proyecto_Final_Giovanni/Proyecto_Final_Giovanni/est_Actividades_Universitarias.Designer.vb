<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class est_Actividades_Universitarias
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(est_Actividades_Universitarias))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.actividad = New System.Windows.Forms.TextBox()
        Me.act_value = New System.Windows.Forms.Label()
        Me.someter_inf = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2018-10 (Ago-Dec 2017)", "2018-30 (Ene-May 2018)", "2019-10 (Ago-Dec 2018)"})
        Me.ComboBox1.Location = New System.Drawing.Point(234, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo curso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Actividades"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Actividad #"
        '
        'actividad
        '
        Me.actividad.Location = New System.Drawing.Point(234, 246)
        Me.actividad.Name = "actividad"
        Me.actividad.Size = New System.Drawing.Size(121, 20)
        Me.actividad.TabIndex = 4
        '
        'act_value
        '
        Me.act_value.AutoSize = True
        Me.act_value.Location = New System.Drawing.Point(208, 249)
        Me.act_value.Name = "act_value"
        Me.act_value.Size = New System.Drawing.Size(13, 13)
        Me.act_value.TabIndex = 5
        Me.act_value.Text = "1"
        '
        'someter_inf
        '
        Me.someter_inf.Location = New System.Drawing.Point(234, 306)
        Me.someter_inf.Name = "someter_inf"
        Me.someter_inf.Size = New System.Drawing.Size(75, 39)
        Me.someter_inf.TabIndex = 6
        Me.someter_inf.Text = "Someter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "actividad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.someter_inf.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Balance estudiante"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(150, 114)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(197, 73)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTile1.TabIndex = 8
        Me.MetroTile1.Text = "MetroTile1"
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile1.UseSelectable = True
        '
        'est_Actividades_Universitarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 474)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.someter_inf)
        Me.Controls.Add(Me.act_value)
        Me.Controls.Add(Me.actividad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "est_Actividades_Universitarias"
        Me.Text = "est_Actividades_Universitarias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents actividad As TextBox
    Friend WithEvents act_value As Label
    Friend WithEvents someter_inf As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
End Class
