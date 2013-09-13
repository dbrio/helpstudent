<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarClase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxAnio = New System.Windows.Forms.TextBox()
        Me.ComboBoxPeriodo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMaestro = New System.Windows.Forms.ComboBox()
        Me.TextBoxHora = New System.Windows.Forms.TextBox()
        Me.ComboBoxDia = New System.Windows.Forms.ComboBox()
        Me.ComboBoxClases = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnRegistrar)
        Me.GroupBox1.Controls.Add(Me.TextBoxAnio)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPeriodo)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMaestro)
        Me.GroupBox1.Controls.Add(Me.TextBoxHora)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDia)
        Me.GroupBox1.Controls.Add(Me.ComboBoxClases)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(45, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 422)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Clase"
        '
        'TextBoxAnio
        '
        Me.TextBoxAnio.Location = New System.Drawing.Point(197, 296)
        Me.TextBoxAnio.Name = "TextBoxAnio"
        Me.TextBoxAnio.Size = New System.Drawing.Size(276, 26)
        Me.TextBoxAnio.TabIndex = 16
        '
        'ComboBoxPeriodo
        '
        Me.ComboBoxPeriodo.FormattingEnabled = True
        Me.ComboBoxPeriodo.Location = New System.Drawing.Point(197, 247)
        Me.ComboBoxPeriodo.Name = "ComboBoxPeriodo"
        Me.ComboBoxPeriodo.Size = New System.Drawing.Size(276, 28)
        Me.ComboBoxPeriodo.TabIndex = 15
        '
        'ComboBoxMaestro
        '
        Me.ComboBoxMaestro.FormattingEnabled = True
        Me.ComboBoxMaestro.Location = New System.Drawing.Point(197, 198)
        Me.ComboBoxMaestro.Name = "ComboBoxMaestro"
        Me.ComboBoxMaestro.Size = New System.Drawing.Size(276, 28)
        Me.ComboBoxMaestro.TabIndex = 14
        '
        'TextBoxHora
        '
        Me.TextBoxHora.Location = New System.Drawing.Point(197, 146)
        Me.TextBoxHora.Name = "TextBoxHora"
        Me.TextBoxHora.Size = New System.Drawing.Size(276, 26)
        Me.TextBoxHora.TabIndex = 13
        '
        'ComboBoxDia
        '
        Me.ComboBoxDia.FormattingEnabled = True
        Me.ComboBoxDia.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo"})
        Me.ComboBoxDia.Location = New System.Drawing.Point(197, 101)
        Me.ComboBoxDia.Name = "ComboBoxDia"
        Me.ComboBoxDia.Size = New System.Drawing.Size(276, 28)
        Me.ComboBoxDia.TabIndex = 12
        '
        'ComboBoxClases
        '
        Me.ComboBoxClases.FormattingEnabled = True
        Me.ComboBoxClases.Location = New System.Drawing.Point(197, 54)
        Me.ComboBoxClases.Name = "ComboBoxClases"
        Me.ComboBoxClases.Size = New System.Drawing.Size(276, 28)
        Me.ComboBoxClases.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Periodo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Maestro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Dia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hora:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Año:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Clase:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Appearance.BackColor = System.Drawing.Color.SlateGray
        Me.BtnRegistrar.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Appearance.Options.UseBackColor = True
        Me.BtnRegistrar.Appearance.Options.UseFont = True
        Me.BtnRegistrar.Appearance.Options.UseForeColor = True
        Me.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRegistrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnRegistrar.Location = New System.Drawing.Point(197, 357)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(276, 50)
        Me.BtnRegistrar.TabIndex = 19
        Me.BtnRegistrar.Text = "Agregar Clase"
        '
        'AgregarClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 488)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AgregarClase"
        Me.Text = "AgregarClase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAnio As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMaestro As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxHora As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDia As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxClases As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRegistrar As DevExpress.XtraEditors.SimpleButton
End Class
