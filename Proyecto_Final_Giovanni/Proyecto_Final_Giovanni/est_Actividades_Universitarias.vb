Imports System.IO
Public Class est_Actividades_Universitarias
    Private Sub est_Actividades_Universitarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles someter_inf.Click

        Static x As Integer = 0
        Static act_universidad(10) As String
        Dim s As String

        If x < 10 Then
            act_universidad(x) = actividad.Text
            x = x + 1
            act_value.Text = x
            actividad.Focus()
            Using sw As StreamWriter = New StreamWriter("informacion_estudiante.txt")
                For Each s In act_universidad
                    sw.WriteLine(s)
                Next s
            End Using
            If x = 10 Then
                For n As Integer = 0 To 9
                    MsgBox("i: " & n &
                            Environment.NewLine &
                            "valor: " & act_universidad(n))
                Next
            End If
        End If
        actividad.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Visible = False
        est_Informacion_Financiera.Show()
    End Sub

End Class