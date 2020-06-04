Public Class Form1



    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

            Dim cadena As String
            cadena = txtCadena.Text

            'Length, retorna las posiciones de una cadena incluye los espacios
            txtLongitud.Text = cadena.Length

            'Abdiel Length = 6 comienza a contar desde 1, Substring comienza 0,
            txtUltimoCaracter.Text = cadena.Substring(cadena.Length - 1, 1)
            txtPrimerCaracter.Text = cadena.Substring(0, 1)
            txtPosicionFIja.Text = cadena.Substring(2, 7)
            txtPosicionB.Text = cadena.IndexOf("B", 0) + 1
            txtMayusculas.Text = cadena.ToUpper
            txtMinusculas.Text = cadena.ToLower
            txtEspacios.Text = cadena.Replace(" ", "")

        End Sub

    End Class
