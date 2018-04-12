Public Class est_Actividades_Universitarias
    Private Sub est_Actividades_Universitarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Static x As Integer = 0
        Static act_universidad(10) As String


        act_universidad(x) = actividad.Text
        x = x + 1
        act_value.Text = x
        actividad.Focus()

        If x = 10 Then
            For n As Integer = 0 To 10
                MsgBox("i: " & n &
                       Environment.NewLine &
                       "valor: " & act_universidad(n))

            Next
        End If

    End Sub
End Class