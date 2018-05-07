Imports MySql.Data.MySqlClient
Public Class nuevo_usuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UserID.Text = "" Or PassRect.Text = " " Or Question.Text = "" Or Answers.Text = "" Then
            MsgBox("Todos los campos deben entrarse.")

        ElseIf UserID.Text <> Password.Text Then
            MsgBox("F")
        Else
        End If



        Dim ServerMysql As String = "Server=localhost;User Id=mj; Password=datasql; Database=Users"
        Dim conn As New MySqlConnection(ServerMysql)
        Dim comand As New MySqlCommand


        conn.Open()
        comand.Connection = conn
        comand.CommandText = "insert into login(userid,password,pregunta,respueta)values('" & UserID.Text & "','" & PassRect.Text & ",'" & Question.Text & "','" & Answers.Text & "')'"
        comand.ExecuteNonQuery()
        MsgBox("Exitosamente registrado. " &
               Environment.NewLine &
               "Tu nombre de usuario es: " & UserID.Text &
               Environment.NewLine &
               "Tu contraseña es: " & PassRect.Text)
        UserID.Text = ""
        PassRect.Text = ""
        Question.Text = ""
        Answers.Text = ""
        conn.Close()
    End Sub

    Private Sub nuevo_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class