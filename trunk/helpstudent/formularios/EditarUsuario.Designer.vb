<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarUsuario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextEditUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.TextEditContrasena = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.cbCarrera = New System.Windows.Forms.ComboBox()
        CType(Me.TextEditUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditContrasena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(465, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Editar Usuario"
        '
        'TextEditUsuario
        '
        Me.TextEditUsuario.Location = New System.Drawing.Point(423, 187)
        Me.TextEditUsuario.Name = "TextEditUsuario"
        Me.TextEditUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditUsuario.Properties.Appearance.Options.UseFont = True
        Me.TextEditUsuario.Size = New System.Drawing.Size(240, 29)
        Me.TextEditUsuario.TabIndex = 1
        '
        'TextEditContrasena
        '
        Me.TextEditContrasena.Location = New System.Drawing.Point(423, 248)
        Me.TextEditContrasena.Name = "TextEditContrasena"
        Me.TextEditContrasena.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditContrasena.Properties.Appearance.Options.UseFont = True
        Me.TextEditContrasena.Size = New System.Drawing.Size(240, 29)
        Me.TextEditContrasena.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(294, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(294, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Appearance.BackColor = System.Drawing.Color.SlateGray
        Me.BtnRegistrar.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Appearance.Options.UseBackColor = True
        Me.BtnRegistrar.Appearance.Options.UseFont = True
        Me.BtnRegistrar.Appearance.Options.UseForeColor = True
        Me.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRegistrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnRegistrar.Location = New System.Drawing.Point(423, 308)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(240, 45)
        Me.BtnRegistrar.TabIndex = 19
        Me.BtnRegistrar.Text = "CAMBIAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(293, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Carrera"
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LbTelefono.Location = New System.Drawing.Point(293, 73)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(96, 25)
        Me.LbTelefono.TabIndex = 22
        Me.LbTelefono.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(422, 71)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Properties.Appearance.Options.UseFont = True
        Me.txtTelefono.Size = New System.Drawing.Size(240, 29)
        Me.txtTelefono.TabIndex = 20
        '
        'cbCarrera
        '
        Me.cbCarrera.FormattingEnabled = True
        Me.cbCarrera.Location = New System.Drawing.Point(423, 138)
        Me.cbCarrera.Name = "cbCarrera"
        Me.cbCarrera.Size = New System.Drawing.Size(239, 21)
        Me.cbCarrera.TabIndex = 24
        '
        'EditarUsuario
        '
        Me.AcceptButton = Me.BtnRegistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1019, 460)
        Me.Controls.Add(Me.cbCarrera)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LbTelefono)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextEditContrasena)
        Me.Controls.Add(Me.TextEditUsuario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarUsuario"
        CType(Me.TextEditUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditContrasena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextEditUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEditContrasena As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnRegistrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LbTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbCarrera As System.Windows.Forms.ComboBox
End Class
