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
        Dim label_Inf_Est As String() = New String() {
            "Nombre completo del estudiante: ",
            "ID del estudiante: ",
            "Concentración: ",
            "Departamento: ",
            "Nombre de la empresa:",
            "Direccion del trabajo del estudiante: ",
            "Direccion residencial del estudiante: ",
            "Año de inicio: ",
            "Creditos convalidados por la Inter Ponce: ",
            "Institución de provinencia del estudiante: ",
            "Teléfono residencial: ",
            "Teléfono celular: ",
            "Teléfono trabajo: "
        }

        Dim inf_Est() As String = {
            nombre.Text,
            id.Text,
            concentracion.Text,
            departamento.Text,
            ano_ingresado.Text,
            cr_convalidado.Text,
            institucion_origen_traslado.Text,
            telr1.Text,
            telc1.Text,
            telt1.Text,
            nombre_empresa_est.Text,
            dir_empresaT_est.Text,
            dir_res_est.Text
        }

        Using sw As StreamWriter = New StreamWriter("informacion_estudiante_general.txt")
            For n As Integer = 0 To label_Inf_Est.Length - 1
                sw.WriteLine(label_Inf_Est(n) &
                             inf_Est(n) &
                             Environment.NewLine)
            Next
        End Using
        MsgBox("Información ha sido exitosamente escrita.")
    End Sub
    Public Shared Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function

    Private Sub informacion_general_est_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inf_Est() As String = {
            nombre.Text,
            id.Text,
            concentracion.Text,
            departamento.Text,
            ano_ingresado.Text,
            cr_convalidado.Text,
            institucion_origen_traslado.Text,
            telr1.Text,
            telc1.Text,
            telt1.Text,
            nombre_empresa_est.Text,
            dir_empresaT_est.Text,
            dir_res_est.Text
        }
        Dim cblist() As ComboBox = {
            ano_ingresado,
            cr_convalidado,
            institucion_origen_traslado
        }

        Dim n As Integer = 0
        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            txt.Text = "Hola hola" + n.ToString()
            n = n + 1
        Next

        For x As Integer = 0 To cblist.Length - 1
            cblist(x).Text = "Hola ComboBox" + x.ToString()
        Next

    End Sub
End Class