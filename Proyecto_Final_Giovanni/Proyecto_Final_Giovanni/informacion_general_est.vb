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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Informacion guardada")
    End Sub
End Class