<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim BtnCerrar As DevExpress.XtraEditors.SimpleButton
        Me.BtnEntrar = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.TxtContrasena = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New DevExpress.XtraEditors.SimpleButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label5 = New System.Windows.Forms.Label()
        BtnCerrar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtContrasena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        BtnCerrar.Appearance.BackColor = System.Drawing.Color.Transparent
        BtnCerrar.Appearance.BackColor2 = System.Drawing.Color.Transparent
        BtnCerrar.Appearance.BorderColor = System.Drawing.Color.Transparent
        BtnCerrar.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BtnCerrar.Appearance.ForeColor = System.Drawing.Color.Transparent
        BtnCerrar.Appearance.Options.UseBackColor = True
        BtnCerrar.Appearance.Options.UseBorderColor = True
        BtnCerrar.Appearance.Options.UseFont = True
        BtnCerrar.Appearance.Options.UseForeColor = True
        BtnCerrar.BackgroundImage = Global.helpstudent.My.Resources.Resources.x_01
        BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        BtnCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        BtnCerrar.CausesValidation = False
        BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        BtnCerrar.Image = Global.helpstudent.My.Resources.Resources.x_01
        BtnCerrar.ImeMode = System.Windows.Forms.ImeMode.Off
        BtnCerrar.Location = New System.Drawing.Point(12, 341)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New System.Drawing.Size(46, 44)
        BtnCerrar.TabIndex = 16
        AddHandler BtnCerrar.Click, AddressOf Me.SimpleButton3_Click
        '
        'BtnEntrar
        '
        Me.BtnEntrar.Appearance.BackColor = System.Drawing.Color.SlateGray
        Me.BtnEntrar.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnEntrar.Appearance.Options.UseBackColor = True
        Me.BtnEntrar.Appearance.Options.UseFont = True
        Me.BtnEntrar.Appearance.Options.UseForeColor = True
        Me.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEntrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEntrar.Location = New System.Drawing.Point(160, 248)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(294, 71)
        Me.BtnEntrar.TabIndex = 0
        Me.BtnEntrar.Text = "ENTRAR"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(160, 123)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Properties.Appearance.Options.UseFont = True
        Me.TxtUsuario.Size = New System.Drawing.Size(294, 39)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Location = New System.Drawing.Point(160, 182)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Properties.Appearance.Options.UseFont = True
        Me.TxtContrasena.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContrasena.Size = New System.Drawing.Size(294, 39)
        Me.TxtContrasena.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(156, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Student UPH Choluteca, Honduras"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegistrar.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.BtnRegistrar.Appearance.Options.UseBackColor = True
        Me.BtnRegistrar.Appearance.Options.UseFont = True
        Me.BtnRegistrar.Appearance.Options.UseForeColor = True
        Me.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRegistrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrar.Location = New System.Drawing.Point(414, 356)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(135, 39)
        Me.BtnRegistrar.TabIndex = 16
        Me.BtnRegistrar.Text = "Registrate"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(561, 407)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        Me.ShapeContainer1.UseWaitCursor = True
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 28)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(561, 44)
        Me.RectangleShape1.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(17, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Cerrar"
        '
        'login
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(561, 407)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(BtnCerrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Opacity = 0.98R
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtContrasena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEntrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtContrasena As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnRegistrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
