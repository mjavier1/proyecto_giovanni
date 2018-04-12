Imports System.IO
Public Class est_notas
    Private Sub est_notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cod_semestre As String = "2018-30"
        Dim cod_curso As String = "COMP2150"
        Dim n_curso As String = "Computacion Visual"
        Dim cr_curso As String = "3"

        codigo_semestre.Text = cod_semestre
        codigo_curso.Text = cod_curso
        nombre_curso.Text = n_curso
        creditos_curso.Text = cr_curso

        nota1.Text = 60
        nota2.Text = 60
        nota3.Text = 60
        nota4.Text = 60
        nota5.Text = 60
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cod_semestre As String = codigo_semestre.Text
        Dim cod_curso As String = codigo_curso.Text
        Dim n_curso As String = nombre_curso.Text
        Dim cr_curso As String = creditos_curso.Text
        Dim notas_est(5) As String
        Dim prom As Integer 'Promedio del estudiante
        Dim nota_final As Integer 'Nota final del estudiante

        notas_est(0) = nota1.Text
        notas_est(1) = nota2.Text
        notas_est(2) = nota3.Text
        notas_est(3) = nota4.Text
        notas_est(4) = nota5.Text
        'Como Marcos todavia no tiene el codigo de la base de datos
        'lista, decidi hacer codigo para escribirlo localmente (archivos)

        'Cuando Marco tenga el codigo listo,
        'este codigo se puede borrar

        For n As Integer = 0 To 4
            prom = prom + notas_est(n)
        Next
        prom = prom / (notas_est.Length - 1)
        TextBox1.Text = prom
        nota_final = Val(nota5.Text)
        TextBox2.Text = prom
        Using sw As StreamWriter = New StreamWriter("informacion_estudiante.txt")
            sw.WriteLine(cod_semestre)
            sw.WriteLine(cod_curso)
            sw.WriteLine(n_curso)
            sw.WriteLine(cr_curso & " creditos")
            sw.WriteLine(Environment.NewLine)
            sw.WriteLine("--NOTAS ESTUDIANTE--")
            For n As Integer = 0 To 3
                sw.WriteLine(notas_est(n))
            Next
            sw.WriteLine("--Promedio--")
            sw.WriteLine(Environment.NewLine)
            sw.WriteLine(prom)
        End Using
        MsgBox("Informacion guardada")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Visible = False
        est_Actividades_Universitarias.Show()
    End Sub
End Class