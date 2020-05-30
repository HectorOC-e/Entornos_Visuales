Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)
        'proceso
        suma = valor1 + valor2

        'salida
        txtSuma.Text = suma

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'salir
        End
    End Sub
End Class
