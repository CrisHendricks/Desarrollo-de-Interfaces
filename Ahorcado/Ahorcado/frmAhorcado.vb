Public Class frmAhorcado

    'creacion de variables'

    Dim palabra As String = ""
    Dim letraComp As String = ""
    Dim errores As Integer = 0

    Private Sub frmAhorcado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        palabra = InputBox("Introduce una palabra a adivinar", "Seleccion de palabra")
        txtErrores.Text = errores
    End Sub

    Private Sub btnComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComp.Click
        letraComp = txtComp.Text
        buscaLetra(letraComp)
        txtErrores.Text = CStr(errores)
    End Sub

    Private Sub buscaLetra(ByVal letra As String)
        Dim pos As Integer = palabra.IndexOf(letra, 0, palabra.Length - 1)

        Do While ((pos >= 0) And (pos < palabra.Length))
            

            Select Case (pos)
                Case "0"
                    MsgBox(pos)
                    lbl1.Text = letra.ToUpper

                Case "1"
                    lbl2.Text = letra.ToUpper

                Case "2"
                    lbl3.Text = letra.ToUpper

                Case "3"
                    lbl4.Text = letra.ToUpper

                Case "4"
                    lbl5.Text = letra.ToUpper

                Case "5"
                    lbl6.Text = letra.ToUpper

                Case "6"
                    lbl7.Text = letra.ToUpper

                Case "7"
                    lbl8.Text = letra.ToUpper

            End Select
        Loop
        If (pos = -1) Then
            errores += -1
        End If

    End Sub

End Class