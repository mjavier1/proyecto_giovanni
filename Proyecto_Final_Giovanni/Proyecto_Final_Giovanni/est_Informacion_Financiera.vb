Public Class est_Informacion_Financiera
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub est_Informacion_Financiera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codigo_semestre.Text = "2018-10 (Ago-Dec 2017)"
        total_beca.Text = 2500
        total_creditos.Text = 15
        total_sub_balance.Text = Val(total_creditos.Text) * 185
        total_balance.Text = Val(total_beca.Text) - Val(total_sub_balance.Text)
    End Sub
End Class