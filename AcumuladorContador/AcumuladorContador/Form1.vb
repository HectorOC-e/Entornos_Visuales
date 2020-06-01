Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPedido.MaskInputRejected

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnsolicitar_Click(sender As Object, e As EventArgs) Handles btnsolicitar.Click
        Try
            Dim precio, total, totalPagar, orden As Integer

            orden = txtPedido.Text

            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platillo No." & i, "Precio del platillo")
                totalPagar += precio

            Next

            total = totalPagar / orden
            txtTotal.Text = totalPagar
            txtIndividual.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPedido.Clear()
        txtTotal.Clear()
        txtIndividual.Clear()
    End Sub
End Class
