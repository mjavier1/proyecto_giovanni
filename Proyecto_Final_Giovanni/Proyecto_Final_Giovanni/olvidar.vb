Imports MySql.Data.MySqlClient
Public Class olvidar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Data para establecer la conexion
        'Server = Nombre del servidor
        'User ID = Nombre de usuario que tiene derecho a trabajar en la base de datos
        'Password = Contraseña que puso el usuario 
        'Database = Nombre de la base de datos en "Server"
        Dim ServerMysql As String = "Server=localhost;User Id=mj; Password=datasql; Database=Users"
        Dim conn As New MySqlConnection(ServerMysql) 'Haciendo la conexion con la base de datos
        Dim command As New MySqlCommand 'Envia consultas (queries) al servidor
        Dim mysql_reader As MySqlDataReader 'Extrae informacion encontrada por la consulta
        conn.Open()
        command.Connection = conn
        command.CommandText = "Select * from login  where userid='" & UserID.Text & "' and pregunta='" & Question.Text & "' and respueta='" & Answers.Text & "'"
        mysql_reader = command.ExecuteReader
        If Not mysql_reader Is Nothing Then
            mysql_reader.Read()
            password.Text = mysql_reader(1)
            mysql_reader.Close()
        Else
            MsgBox("Informacion no fue encontrada. ")
        End If
    End Sub


End Class