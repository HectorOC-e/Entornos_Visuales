<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCadena = New System.Windows.Forms.TextBox()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.txtUltimoCaracter = New System.Windows.Forms.TextBox()
        Me.txtPrimerCaracter = New System.Windows.Forms.TextBox()
        Me.txtPosicionFIja = New System.Windows.Forms.TextBox()
        Me.txtEspacios = New System.Windows.Forms.TextBox()
        Me.txtMinusculas = New System.Windows.Forms.TextBox()
        Me.txtMayusculas = New System.Windows.Forms.TextBox()
        Me.txtPosicionB = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadena"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Longitud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ultimo Caracter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Primer Caracter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "3ro al 8vo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Posicion de la letra B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mayusculas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Minusculas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Borrar espacios"
        '
        'txtCadena
        '
        Me.txtCadena.Location = New System.Drawing.Point(205, 52)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(139, 22)
        Me.txtCadena.TabIndex = 9
        '
        'txtLongitud
        '
        Me.txtLongitud.Enabled = False
        Me.txtLongitud.Location = New System.Drawing.Point(205, 102)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(139, 22)
        Me.txtLongitud.TabIndex = 10
        '
        'txtUltimoCaracter
        '
        Me.txtUltimoCaracter.Enabled = False
        Me.txtUltimoCaracter.Location = New System.Drawing.Point(205, 150)
        Me.txtUltimoCaracter.Name = "txtUltimoCaracter"
        Me.txtUltimoCaracter.Size = New System.Drawing.Size(139, 22)
        Me.txtUltimoCaracter.TabIndex = 11
        '
        'txtPrimerCaracter
        '
        Me.txtPrimerCaracter.Enabled = False
        Me.txtPrimerCaracter.Location = New System.Drawing.Point(205, 192)
        Me.txtPrimerCaracter.Name = "txtPrimerCaracter"
        Me.txtPrimerCaracter.Size = New System.Drawing.Size(139, 22)
        Me.txtPrimerCaracter.TabIndex = 12
        '
        'txtPosicionFIja
        '
        Me.txtPosicionFIja.Enabled = False
        Me.txtPosicionFIja.Location = New System.Drawing.Point(205, 236)
        Me.txtPosicionFIja.Name = "txtPosicionFIja"
        Me.txtPosicionFIja.Size = New System.Drawing.Size(139, 22)
        Me.txtPosicionFIja.TabIndex = 13
        '
        'txtEspacios
        '
        Me.txtEspacios.Enabled = False
        Me.txtEspacios.Location = New System.Drawing.Point(205, 405)
        Me.txtEspacios.Name = "txtEspacios"
        Me.txtEspacios.Size = New System.Drawing.Size(139, 22)
        Me.txtEspacios.TabIndex = 14
        '
        'txtMinusculas
        '
        Me.txtMinusculas.Enabled = False
        Me.txtMinusculas.Location = New System.Drawing.Point(205, 364)
        Me.txtMinusculas.Name = "txtMinusculas"
        Me.txtMinusculas.Size = New System.Drawing.Size(139, 22)
        Me.txtMinusculas.TabIndex = 15
        '
        'txtMayusculas
        '
        Me.txtMayusculas.Enabled = False
        Me.txtMayusculas.Location = New System.Drawing.Point(205, 319)
        Me.txtMayusculas.Name = "txtMayusculas"
        Me.txtMayusculas.Size = New System.Drawing.Size(139, 22)
        Me.txtMayusculas.TabIndex = 16
        '
        'txtPosicionB
        '
        Me.txtPosicionB.Enabled = False
        Me.txtPosicionB.Location = New System.Drawing.Point(205, 274)
        Me.txtPosicionB.Name = "txtPosicionB"
        Me.txtPosicionB.Size = New System.Drawing.Size(139, 22)
        Me.txtPosicionB.TabIndex = 17
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(139, 444)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(103, 50)
        Me.btnMostrar.TabIndex = 18
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 506)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtPosicionB)
        Me.Controls.Add(Me.txtMayusculas)
        Me.Controls.Add(Me.txtMinusculas)
        Me.Controls.Add(Me.txtEspacios)
        Me.Controls.Add(Me.txtPosicionFIja)
        Me.Controls.Add(Me.txtPrimerCaracter)
        Me.Controls.Add(Me.txtUltimoCaracter)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.txtCadena)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCadena As TextBox
    Friend WithEvents txtLongitud As TextBox
    Friend WithEvents txtUltimoCaracter As TextBox
    Friend WithEvents txtPrimerCaracter As TextBox
    Friend WithEvents txtPosicionFIja As TextBox
    Friend WithEvents txtEspacios As TextBox
    Friend WithEvents txtMinusculas As TextBox
    Friend WithEvents txtMayusculas As TextBox
    Friend WithEvents txtPosicionB As TextBox
    Friend WithEvents btnMostrar As Button
End Class
