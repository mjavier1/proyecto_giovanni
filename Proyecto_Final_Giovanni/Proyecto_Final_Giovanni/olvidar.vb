Imports MySql.Data.MySqlClient
Public Class olvidar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ServerMysql As String = "Server=localhost;User Id=mj; Password=datasql; Database=Users"
        Dim conn As New MySqlConnection(ServerMysql)
        Dim comand As New MySqlCommand
        Dim dr As MySqlDataReader
        conn.Open()
        comand.Connection = conn
        comand.CommandText = "Select * from login  where userid='" & UserID.Text & "' and pregunta='" & Question.Text & "' and respueta='" & Answers.Text & "'"
        dr = comand.ExecuteReader
        If Not dr Is Nothing Then
            dr.Read()
            password.Text = dr(1)
            dr.Close()
        Else
            MsgBox("Informacion no fue encontrada. ")
        End If
    End Sub
End Class