Imports System.IO
Public Class est_notas
    Private Sub est_notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cod_semestre As String = codigo_semestre.Text
        Using sw As StreamWriter = New StreamWriter("informacion_estudiante.txt")
            sw.WriteLine(cod_semestre)
        End Using
        MsgBox("Informacion guardada")
    End Sub
End Class