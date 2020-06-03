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
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMunicipios = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDepartamentos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(396, 379)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(104, 22)
        Me.txtStock.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEntregar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtMunicipios)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(396, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 270)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Distribucion"
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(86, 70)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(121, 35)
        Me.btnEntregar.TabIndex = 7
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cant. Municipios"
        '
        'txtMunicipios
        '
        Me.txtMunicipios.Location = New System.Drawing.Point(170, 31)
        Me.txtMunicipios.Name = "txtMunicipios"
        Me.txtMunicipios.Size = New System.Drawing.Size(104, 27)
        Me.txtMunicipios.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbDepartamento)
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDepartamentos)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 278)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad por departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cant. por departamento"
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(189, 160)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(104, 27)
        Me.cmbDepartamento.TabIndex = 3
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(90, 78)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(121, 35)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cant. Departamentos"
        '
        'txtDepartamentos
        '
        Me.txtDepartamentos.Location = New System.Drawing.Point(189, 39)
        Me.txtDepartamentos.Name = "txtDepartamentos"
        Me.txtDepartamentos.Size = New System.Drawing.Size(104, 27)
        Me.txtDepartamentos.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(229, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cantidad Disponible"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Entrega de Mascarillas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStock As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEntregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMunicipios As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepartamentos As TextBox
    Friend WithEvents Label4 As Label
End Class
