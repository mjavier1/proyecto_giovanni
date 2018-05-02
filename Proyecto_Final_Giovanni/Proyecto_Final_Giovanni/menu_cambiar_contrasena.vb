Imports MySql.Data.MySqlClient
Public Class menu_cambiar_contrasena
    Dim ServerMysql As String = "Server=localhost;User Id=mj; Password=datasql; Database=Users"
    Dim conn As New MySqlConnection(ServerMysql)
    Dim comand As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub menu_cambiar_contrasena_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub change()
        Dim conn As New MySqlConnection(ServerMysql)
        Dim comand As New MySqlCommand

        conn.Open()
        comand.Connection = conn
        comand.CommandText = "update login set password='" & Newpass.Text & "'where userid='" & TextBox1.Text & "'"
        comand.ExecuteNonQuery()
        MsgBox("Sucessfully update")
        TextBox1.Text = ""
        Newpass.Text = ""
        Currentpass.Text = ""
        conn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        comand.Connection = conn
        '   comand.CommandText = "select userid,password from login where userid ='" & TextBox1.Text & "'and password ='" & TextBox2.Text & "'"'
        comand.CommandText = "select userid,password from login where userid ='" & TextBox1.Text & "' and password ='" & Currentpass.Text & "'"
        dr = comand.ExecuteReader
        If dr.HasRows Then
            change()
            dr.Read()
        Else
            MsgBox("Userid or password does not matched")
        End If
        conn.Close()
    End Sub
End Class