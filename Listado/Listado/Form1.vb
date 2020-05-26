Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim itemId As Integer
        Dim itemNombre As String

        itemId = cbbLista.SelectedIndex
        itemNombre = cbbLista.SelectedItem.ToString

        Select Case itemId
            Case 0
                MsgBox(itemNombre)
            Case 1
                MsgBox(itemNombre)
            Case 2
                MsgBox(itemNombre)
            Case 3
                MsgBox(itemNombre)
            Case Else
                MsgBox("Seleccione un valor correcto")

        End Select

    End Sub

End Class
