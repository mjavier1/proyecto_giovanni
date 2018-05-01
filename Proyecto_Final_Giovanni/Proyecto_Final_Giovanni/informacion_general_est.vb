Imports System.IO
Public Class informacion_general_est
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Visible = False
        menu_principal.Show()
        'Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Visible = False
        est_notas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using sw As StreamWriter = New StreamWriter("informacion_estudiante_general.txt")
            sw.WriteLine()
        End Using
    End Sub
End Class