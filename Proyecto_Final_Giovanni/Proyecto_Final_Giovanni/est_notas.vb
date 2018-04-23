Imports System.IO
Public Class est_notas
    Private Sub est_notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim cod_semestre As String = "2018-30"
        Dim cod_curso As String = "Selecciona"
        Dim n_curso As String = "Computacion Visual"
        Dim cr_curso As String = "3"

        codigo_semestre.Text = "2018-10 (Ago-Dec 2017)"
        codigo_curso.Text = cod_curso
        'nombre_curso.Text = n_curso
        creditos_curso.Text = cr_curso

        nota1.Text = 60
        nota2.Text = 90
        nota3.Text = 75
        nota4.Text = 80
        nota5.Text = 100
    End Sub
    Private Sub Adding_Worksheet_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call AxAcroPDF1.LoadFile("C:\Users\ecos1435\Documents\dev\proyecto_giovanni\Proyecto_Final_Giovanni\Proyecto_Final_Giovanni\2019.pdf")
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        AxAcroPDF1.Location.Equals(AxAcroPDF1.LoadFile("C:\Users\ecos1435\Documents\dev\proyecto_giovanni\Proyecto_Final_Giovanni\Proyecto_Final_Giovanni\2019.pdf"))
        AxAcroPDF1.LoadFile("C:\Users\ecos1435\Documents\dev\proyecto_giovanni\Proyecto_Final_Giovanni\Proyecto_Final_Giovanni\2019.pdf")
        ' Add any initialization after the InitializeComponent() call.

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
            sw.WriteLine("Promedio estudiante: " & prom)
            sw.WriteLine("Nota final: " & nota_final)
        End Using
        MsgBox("Informacion guardada")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Visible = False
        est_Actividades_Universitarias.Show()
    End Sub

    Private Sub codigo_curso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles codigo_curso.SelectedIndexChanged
        Dim cc As ComboBox = codigo_curso 'ComboBox2
        Dim n_clase(5) As String

        '2018-10 (Ago-Dec 2017)
        '2018-30 (Ene-May 2018)
        '2019-10 (Ago-Dec 2018)

        n_clase(0) = "Computacion Visual"
        n_clase(1) = "Organización y Arquitectura de Computadoras"
        n_clase(2) = "Sistemas Operativos"
        n_clase(3) = "Ingenieria de Softwares"
        n_clase(4) = "Ingenieria de Softwares"
        Try
            If (cc.SelectedIndex = 0) Then
                nombre_curso.Text = n_clase(0)
            ElseIf (cc.SelectedIndex = 1) Then
                nombre_curso.Text = n_clase(1)
            ElseIf (cc.SelectedIndex = 2) Then
                nombre_curso.Text = n_clase(2)
            ElseIf (cc.SelectedIndex = 3) Then
                nombre_curso.Text = n_clase(3)
            ElseIf (cc.SelectedIndex = 4) Then
                nombre_curso.Text = n_clase(4)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub codigo_semestre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles codigo_semestre.SelectedIndexChanged
        Dim cs As ComboBox = codigo_semestre 'ComboBox1
        Dim cc As ComboBox = codigo_curso 'ComboBox2
        Try
            If cs.SelectedIndex = 0 Then
                If Not (cc.Items.Contains("COMP3300")) And Not (cc.Items.Contains("COMP3900")) Then
                    cc.Items.Add("COMP3300")
                    cc.Items.Add("COMP3900")
                End If
            ElseIf cs.SelectedIndex = 1 Then
                If Not (cc.Items.Contains("COMP3500")) And Not (cc.Items.Contains("COMP3400")) Then
                    cc.Items.Add("COMP3500")
                    cc.Items.Add("COMP3400")
                End If
            ElseIf cs.SelectedIndex = 2 Then
                If Not (cc.Items.Contains("COMP4200")) Then
                    cc.Items.Add("COMP4200")

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class