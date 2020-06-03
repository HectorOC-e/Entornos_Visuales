Public Class Form1
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        'For, DoWhile
        Dim departamentos, mascarillas As Long
        If txtDepartamentos.Text = "" Then
            MsgBox("escriba un cantidad de departamentos", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtDepartamentos.Text) Then
            MsgBox("escriba una cantidad de departamentos", vbOK + vbExclamation, "Mensaje especial")
            txtDepartamentos.Text = ""
        ElseIf (val(txtDepartamentos.Text)) > 18 Then
            MsgBox("Hay un maximo de 18 Dep. en Honduras", vbOK + vbExclamation, "Mensaje especial")
            txtDepartamentos.Text = ""
        ElseIf (Val(txtdepartamentos.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtDepartamentos.Text = ""
        ElseIf IsNumeric(txtdepartamentos.text) Then
            departamentos = Val(txtDepartamentos.Text)
        End If


        For i = 1 To departamentos Step 1
            Do
                mascarillas = InputBox("Ingrese la cantidad de mascarillas" & i, ", Ingresar")
            Loop While (mascarillas < 0 Or mascarillas > 10000)
            cmbDepartamento.Items.Add(mascarillas)
        Next
    End Sub

    Private Sub entregaMascarillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios, cantEntrega As Integer
        Dim itemDepartamento As String
        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedItem.ToString

        If txtMunicipios.Text = "" Then
            MsgBox("escriba un cantidad de municipios", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtMunicipios.Text) Then
            MsgBox("escriba una cantidad de municipios", vbOK + vbExclamation, "Mensaje especial")
            txtMunicipios.Text = ""
        ElseIf (Val(txtMunicipios.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtMunicipios.Text = ""
        ElseIf IsNumeric(txtMunicipios.Text) Then
            municipios = Val(txtMunicipios.Text)
        End If


        Select Case idDepartamento
            Case 0
                If municipios > 8 Then
                    MsgBox("Hay un maximo de 8 municipios en atlantida", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Atlantida")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 1
                If municipios > 16 Then
                    MsgBox("Hay un maximo de 16 municipios en choluteca", vbOK + vbExclamation, "Mensaje especial")
                    municipios = 0
                Else
                    municipios = Val(txtMunicipios.Text)
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Choluteca")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 2
                If municipios > 10 Then
                    MsgBox("Hay un maximo de 10 municipios en cólon", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas cólon")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 3
                If municipios > 21 Then
                    MsgBox("Hay un maximo de 21 municipios en Comayagua", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Comayagua")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 4
                If municipios > 23 Then
                    MsgBox("Hay un maximo de 23 municipios en Copán", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Copán")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 5
                If municipios > 12 Then
                    MsgBox("Hay un maximo de 12 municipios en Cortes", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Cortes")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 6
                If municipios > 19 Then
                    MsgBox("Hay un maximo de 19 municipios en El Paraíso", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas El Paraíso")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 7
                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Francisco Morazán", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Francisco Morazán")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 8
                If municipios > 6 Then
                    MsgBox("Hay un maximo de 6 municipios en Gracias a Dios", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Gracias a Dios")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 9
                If municipios > 17 Then
                    MsgBox("Hay un maximo de 17 municipios en Intibuca", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Intibuca")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 10
                If municipios > 4 Then
                    MsgBox("Hay un maximo de 4 municipios en Islas de la Bahía", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Islas de la Bahía")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 11
                If municipios > 19 Then
                    MsgBox("Hay un maximo de 19 municipios en La Paz", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas La Paz")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 12
                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Lempira", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Lempira")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 13
                If municipios > 16 Then
                    MsgBox("Hay un maximo de 16 municipios en Ocotopeque", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Ocotopeque")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 14
                If municipios > 23 Then
                    MsgBox("Hay un maximo de 23 municipios en Olancho", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Olancho")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 15
                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Santa Barbara", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Santa Barbara")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 16
                If municipios > 9 Then
                    MsgBox("Hay un maximo de 9 municipios en Valle", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Valle")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 17
                If municipios > 11 Then
                    MsgBox("Hay un maximo de 11 municipios en Yoro", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas Yoro")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

        End Select





        txtStock.Text = itemDepartamento
    End Sub
End Class