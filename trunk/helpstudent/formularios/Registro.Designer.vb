<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CtaAlumLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim FechNacLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim IdSexoLabel As System.Windows.Forms.Label
        Dim IdCarreraLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim IdLoginLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataSetSqlite = New helpstudent.DataSetSqlite()
        Me.AlumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.TableAdapterManager = New helpstudent.DataSetSqliteTableAdapters.TableAdapterManager()
        Me.CtaAlumTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FechNacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TelefonoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdSexoTextBox = New System.Windows.Forms.TextBox()
        Me.IdLoginTextBox = New System.Windows.Forms.TextBox()
        Me.IdCarreraTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnRegistrar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CtaAlumLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        FechNacLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        IdSexoLabel = New System.Windows.Forms.Label()
        IdCarreraLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        IdLoginLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DataSetSqlite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtaAlumTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CtaAlumLabel
        '
        resources.ApplyResources(CtaAlumLabel, "CtaAlumLabel")
        CtaAlumLabel.Name = "CtaAlumLabel"
        '
        'NombreLabel
        '
        resources.ApplyResources(NombreLabel, "NombreLabel")
        NombreLabel.Name = "NombreLabel"
        '
        'ApellidoLabel
        '
        resources.ApplyResources(ApellidoLabel, "ApellidoLabel")
        ApellidoLabel.Name = "ApellidoLabel"
        '
        'FechNacLabel
        '
        resources.ApplyResources(FechNacLabel, "FechNacLabel")
        FechNacLabel.Name = "FechNacLabel"
        '
        'TelefonoLabel
        '
        resources.ApplyResources(TelefonoLabel, "TelefonoLabel")
        TelefonoLabel.Name = "TelefonoLabel"
        '
        'IdSexoLabel
        '
        resources.ApplyResources(IdSexoLabel, "IdSexoLabel")
        IdSexoLabel.Name = "IdSexoLabel"
        '
        'IdCarreraLabel
        '
        resources.ApplyResources(IdCarreraLabel, "IdCarreraLabel")
        IdCarreraLabel.Name = "IdCarreraLabel"
        '
        'CorreoLabel
        '
        resources.ApplyResources(CorreoLabel, "CorreoLabel")
        CorreoLabel.Name = "CorreoLabel"
        '
        'IdLoginLabel
        '
        resources.ApplyResources(IdLoginLabel, "IdLoginLabel")
        IdLoginLabel.Name = "IdLoginLabel"
        '
        'Label1
        '
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.RectangleShape1, "RectangleShape1")
        Me.RectangleShape1.Name = "RectangleShape1"
        '
        'ShapeContainer1
        '
        resources.ApplyResources(Me.ShapeContainer1, "ShapeContainer1")
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Name = "Label4"
        '
        'DataSetSqlite
        '
        Me.DataSetSqlite.DataSetName = "DataSetSqlite"
        Me.DataSetSqlite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnoBindingSource
        '
        Me.AlumnoBindingSource.DataMember = "Alumno"
        Me.AlumnoBindingSource.DataSource = Me.DataSetSqlite
        '
        'AlumnoTableAdapter
        '

        '
        'TableAdapterManager
        '
      
        Me.TableAdapterManager.UpdateOrder = helpstudent.DataSetSqliteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CtaAlumTextEdit
        '
        Me.CtaAlumTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnoBindingSource, "CtaAlum", True))
        resources.ApplyResources(Me.CtaAlumTextEdit, "CtaAlumTextEdit")
        Me.CtaAlumTextEdit.Name = "CtaAlumTextEdit"
        Me.CtaAlumTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtaAlumTextEdit.Properties.Appearance.Options.UseFont = True
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnoBindingSource, "Nombre", True))
        resources.ApplyResources(Me.NombreTextEdit, "NombreTextEdit")
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextEdit.Properties.Appearance.Options.UseFont = True
        '
        'ApellidoTextEdit
        '
        Me.ApellidoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnoBindingSource, "Apellido", True))
        resources.ApplyResources(Me.ApellidoTextEdit, "ApellidoTextEdit")
        Me.ApellidoTextEdit.Name = "ApellidoTextEdit"
        Me.ApellidoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTextEdit.Properties.Appearance.Options.UseFont = True
        '
        'FechNacDateTimePicker
        '
        Me.FechNacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlumnoBindingSource, "FechNac", True))
        resources.ApplyResources(Me.FechNacDateTimePicker, "FechNacDateTimePicker")
        Me.FechNacDateTimePicker.Name = "FechNacDateTimePicker"
        '
        'TelefonoTextEdit
        '
        Me.TelefonoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnoBindingSource, "Telefono", True))
        resources.ApplyResources(Me.TelefonoTextEdit, "TelefonoTextEdit")
        Me.TelefonoTextEdit.Name = "TelefonoTextEdit"
        Me.TelefonoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextEdit.Properties.Appearance.Options.UseFont = True
        '
        'IdSexoTextBox
        '
        Me.IdSexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnoBindingSource, "IdSexo", True))
        resources.ApplyResources(Me.IdSexoTextBox, "IdSexoTextBox")
        Me.IdSexoTextBox.Name = "IdSexoTextBox"
        '
        'IdLoginTextBox
        '
        Me.IdLoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnoBindingSource, "IdLogin", True))
        resources.ApplyResources(Me.IdLoginTextBox, "IdLoginTextBox")
        Me.IdLoginTextBox.Name = "IdLoginTextBox"
        '
        'IdCarreraTextBox
        '
        Me.IdCarreraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnoBindingSource, "IdCarrera", True))
        resources.ApplyResources(Me.IdCarreraTextBox, "IdCarreraTextBox")
        Me.IdCarreraTextBox.Name = "IdCarreraTextBox"
        '
        'CorreoTextEdit
        '
        Me.CorreoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnoBindingSource, "Correo", True))
        resources.ApplyResources(Me.CorreoTextEdit, "CorreoTextEdit")
        Me.CorreoTextEdit.Name = "CorreoTextEdit"
        Me.CorreoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextEdit.Properties.Appearance.Options.UseFont = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnoBindingSource, "IdLogin", True))
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Appearance.BackColor = System.Drawing.Color.SlateGray
        Me.BtnRegistrar.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Appearance.Options.UseBackColor = True
        Me.BtnRegistrar.Appearance.Options.UseFont = True
        Me.BtnRegistrar.Appearance.Options.UseForeColor = True
        resources.ApplyResources(Me.BtnRegistrar, "BtnRegistrar")
        Me.BtnRegistrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnRegistrar.Name = "BtnRegistrar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.AutoWidthInLayoutControl = True
        resources.ApplyResources(Me.SimpleButton1, "SimpleButton1")
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = Global.helpstudent.My.Resources.Resources._1377000670_left_round
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Name = "SimpleButton1"
        '
        'Registro
        '
        Me.AllowDrop = True
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(CtaAlumLabel)
        Me.Controls.Add(Me.CtaAlumTextEdit)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextEdit)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextEdit)
        Me.Controls.Add(FechNacLabel)
        Me.Controls.Add(Me.FechNacDateTimePicker)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextEdit)
        Me.Controls.Add(IdSexoLabel)
        Me.Controls.Add(Me.IdSexoTextBox)
        Me.Controls.Add(IdLoginLabel)
        Me.Controls.Add(Me.IdLoginTextBox)
        Me.Controls.Add(IdCarreraLabel)
        Me.Controls.Add(Me.IdCarreraTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextEdit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registro"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        CType(Me.DataSetSqlite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtaAlumTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataSetSqlite As helpstudent.DataSetSqlite
    Friend WithEvents AlumnoBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents TableAdapterManager As helpstudent.DataSetSqliteTableAdapters.TableAdapterManager
    Friend WithEvents CtaAlumTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FechNacDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TelefonoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdSexoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdLoginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdCarreraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorreoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnRegistrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
