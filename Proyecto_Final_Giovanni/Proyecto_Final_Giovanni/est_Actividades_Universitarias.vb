Public Class est_Actividades_Universitarias
    Private Sub est_Actividades_Universitarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim act As String = act_value.Text
        Static x As Integer = 1
        Dim act_universidad(10) As String


        For n As Integer = 0 To 9
            act_universidad(n) = actividad.Text
            x = x + 1
            act = x.ToString()
            actividad.Text = ""
        Next

    End Sub
End Class