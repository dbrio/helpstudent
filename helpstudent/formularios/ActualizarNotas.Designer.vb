<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarNotas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxNota1 = New System.Windows.Forms.TextBox()
        Me.TextBoxNota2 = New System.Windows.Forms.TextBox()
        Me.TextBoxNota3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDía = New System.Windows.Forms.TextBox()
        Me.TextBoxHora = New System.Windows.Forms.TextBox()
        Me.TextBoxClase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBoxNota1)
        Me.GroupBox1.Controls.Add(Me.TextBoxNota2)
        Me.GroupBox1.Controls.Add(Me.TextBoxNota3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxDía)
        Me.GroupBox1.Controls.Add(Me.TextBoxHora)
        Me.GroupBox1.Controls.Add(Me.TextBoxClase)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 358)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 46)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Actualizar Notas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxNota1
        '
        Me.TextBoxNota1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNota1.Location = New System.Drawing.Point(127, 118)
        Me.TextBoxNota1.Name = "TextBoxNota1"
        Me.TextBoxNota1.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxNota1.TabIndex = 24
        '
        'TextBoxNota2
        '
        Me.TextBoxNota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNota2.Location = New System.Drawing.Point(127, 159)
        Me.TextBoxNota2.Name = "TextBoxNota2"
        Me.TextBoxNota2.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxNota2.TabIndex = 23
        '
        'TextBoxNota3
        '
        Me.TextBoxNota3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNota3.Location = New System.Drawing.Point(127, 199)
        Me.TextBoxNota3.Name = "TextBoxNota3"
        Me.TextBoxNota3.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxNota3.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Nota2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 24)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Nota3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nota1"
        '
        'TextBoxDía
        '
        Me.TextBoxDía.Enabled = False
        Me.TextBoxDía.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDía.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBoxDía.Location = New System.Drawing.Point(228, 32)
        Me.TextBoxDía.Name = "TextBoxDía"
        Me.TextBoxDía.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxDía.TabIndex = 18
        '
        'TextBoxHora
        '
        Me.TextBoxHora.Enabled = False
        Me.TextBoxHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHora.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBoxHora.Location = New System.Drawing.Point(370, 32)
        Me.TextBoxHora.Name = "TextBoxHora"
        Me.TextBoxHora.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxHora.TabIndex = 17
        '
        'TextBoxClase
        '
        Me.TextBoxClase.Enabled = False
        Me.TextBoxClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxClase.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBoxClase.Location = New System.Drawing.Point(19, 32)
        Me.TextBoxClase.Name = "TextBoxClase"
        Me.TextBoxClase.Size = New System.Drawing.Size(189, 26)
        Me.TextBoxClase.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Día"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(396, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Hora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Clase"
        '
        'ActualizarNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 397)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ActualizarNotas"
        Me.Text = "ActualizarNotas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxNota1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNota2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNota3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDía As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHora As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
