Public Class menu_principal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario As TextBox = tb_usuario 'Textbox del nombre de usuario
        Dim pwd As TextBox = tb_contrasena 'Textbox de la contraseña

        Me.Size = variables_globales.tamano 'Seteando qué tan grande se verá el programa cuando lo compiles

        usuario.Text = "admin"
        pwd.Text = "password_admin"

    End Sub

    Private Sub btn_acceder_Click(sender As Object, e As EventArgs) Handles btn_acceder.Click
        Dim usuario As String = tb_usuario.Text 'Textbox del nombre de usuario
        Dim pwd As String = tb_contrasena.Text 'Textbox de la contraseña

        'TAREA PARA HACER
        'Añadir codigo de base de datos aqui
        'para que el acceso a la cuenta 
        'funcione con base de datos

        If (usuario = "admin" And pwd = "password_admin") Then
            MsgBox("Informacion valida" & Environment.NewLine &
                   "Bienvenido '" & usuario & "'")
            Visible = False 'Hacer que este Form no se vea
            'TAREA PARA HACER 
            'Como Eddie todavia no ha hecho su parte,
            'lo pongo en comentario porque en su Form
            'debe haber un boton al proximo Form: NOTAS DEL ESTUDIANTE
            'Cuando Eddie haga eso, se quita este comentario
            'informacion_general_est.Show() 'Haciendo que el nuevo Form aparezca
        End If
    End Sub
End Class
