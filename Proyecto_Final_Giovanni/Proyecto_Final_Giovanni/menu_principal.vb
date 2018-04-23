Imports MySql.Data.MySqlClient
Public Class menu_principal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_usuario.Text = "124"
        tb_contrasena.Text = "data_sql"
    End Sub

    Private Sub btn_acceder_Click(sender As Object, e As EventArgs) Handles btn_acceder.Click
        'Data para establecer la conexion
        'Server = Nombre del servidor
        'User ID = Nombre de usuario que tiene derecho a trabajar en la base de datos
        'Password = Contraseña que puso el usuario 
        'Database = Nombre de la base de datos en "Server"
        Dim ServerMysql As String = "Server=localhost;User Id=mj; Password=datasql; Database=Users"
        Dim conn As New MySqlConnection(ServerMysql) 'Establece la conexion. Abre y termina la comunicacion con el servidor
        Dim c As New MySqlCommand 'Envia consultas (queries) al servidor
        Dim mysql_reader As MySqlDataReader 'Extrae informacion encontrada por la consulta

        Dim usuario = tb_usuario.Text
        Dim contrasena = tb_contrasena.Text
        Dim sql_cmd As String() = New String() {
            "select",
            "insert",
            "delete"
        }

        conn.Open() 'Empezando la conexion
        c.Connection = conn 'Haciendo la union con la conexion

        c.CommandText = sql_cmd(0) & " userid,password from login where userid ='" & usuario &
                                     "'and password ='" & contrasena & "'"
        mysql_reader = c.ExecuteReader
        If mysql_reader.HasRows Then
            MsgBox("Informacion valida" & Environment.NewLine &
                   "Bienvenido '" & usuario & "'")
            informacion_general_est.Show()
        End If

        'If (usuario = "admin" And contrasena = "password_admin") Then
        'MsgBox("Informacion valida" & Environment.NewLine &
        '"Bienvenido '" & usuario & "'")
        'Visible = False 'Hacer que este Form no se vea


        'TAREA PARA HACER 
        'Como Eddie todavia no ha hecho su parte,
        'lo pongo en comentario porque en su Form
        'debe haber un boton al proximo Form: NOTAS DEL ESTUDIANTE
        'Cuando Eddie haga eso, se quita este comentario
        'informacion_general_est.Show() 'Form #1 del trabajo de Giovanni

        'est_notas.Show()

        'End If
    End Sub
End Class
