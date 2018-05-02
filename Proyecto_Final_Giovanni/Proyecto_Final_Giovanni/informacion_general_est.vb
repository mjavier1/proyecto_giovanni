Imports System.IO
Public Class informacion_general_est
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Visible = False
        menu_principal.Show()
        'Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles continuar.Click
        Visible = False
        est_notas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles someter.Click
        'Los titulos que serán escritos
        'en el archivo están todos puestos en este 
        'arreglo, para usarlos en un For Loop
        Dim txt_labels1 As String() = New String() {
            "Nombre completo del estudiante: ",
            "ID del estudiante: ",
            "Concentración: ",
            "Departamento: ",
            "Teléfono residencial: ",
            "Teléfono celular: ",
            "Teléfono trabajo: ",
            "Direccion del trabajo del estudiante: ",
            "Direccion residencial del estudiante: "
        }

        Dim txt_labels2 As String() = New String() {
            "Año de inicio: ",
            "Creditos convalidados por la Inter Ponce: ",
            "Institución de provinencia del estudiante: "
        }

        Dim obj_textBoxes() As TextBox = {
            nombre,
            id,
            concentracion,
            departamento,
            nombre_empresa_est,
            dir_empresaT_est,
            dir_res_est
        }
        Dim obj_ComboBoxes() As ComboBox = {
            ano_ingresado,
            cr_convalidado,
            institucion_origen_traslado
        }

        Dim tel() As TextBox = {
            telr1,
            telr2,
            telr3,
            telc1,
            telc2,
            telc3,
            telt1,
            telt2,
            telt3
        }

        Using sw As StreamWriter = New StreamWriter("informacion_estudiante_general.txt")
            For n As Integer = 0 To txt_labels1.Length - 1
                sw.WriteLine(txt_labels1(n) &
                             obj_textBoxes(n).Text &
                             Environment.NewLine)
            Next
            sw.WriteLine()
            For x As Integer = 0 To txt_labels2.Length - 1
                sw.WriteLine(txt_labels2(x) &
                             obj_ComboBoxes(x).Text &
                             Environment.NewLine)
            Next
        End Using
        MsgBox("Información ha sido exitosamente escrita.")
    End Sub

    Private Sub informacion_general_est_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class