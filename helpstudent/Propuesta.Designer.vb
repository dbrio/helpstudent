<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Propuesta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewAprovada = New System.Windows.Forms.DataGridView()
        Me.DataGridViewDisponible = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewAprovada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewAprovada
        '
        Me.DataGridViewAprovada.AllowUserToOrderColumns = True
        Me.DataGridViewAprovada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewAprovada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewAprovada.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewAprovada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewAprovada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewAprovada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewAprovada.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewAprovada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAprovada.Location = New System.Drawing.Point(-1, 35)
        Me.DataGridViewAprovada.Name = "DataGridViewAprovada"
        Me.DataGridViewAprovada.ReadOnly = True
        Me.DataGridViewAprovada.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewAprovada.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(5)
        Me.DataGridViewAprovada.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OliveDrab
        Me.DataGridViewAprovada.Size = New System.Drawing.Size(395, 633)
        Me.DataGridViewAprovada.TabIndex = 0
        '
        'DataGridViewDisponible
        '
        Me.DataGridViewDisponible.AllowUserToOrderColumns = True
        Me.DataGridViewDisponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewDisponible.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewDisponible.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewDisponible.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewDisponible.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewDisponible.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDisponible.Location = New System.Drawing.Point(616, 35)
        Me.DataGridViewDisponible.Name = "DataGridViewDisponible"
        Me.DataGridViewDisponible.ReadOnly = True
        Me.DataGridViewDisponible.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewDisponible.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(5)
        Me.DataGridViewDisponible.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OliveDrab
        Me.DataGridViewDisponible.Size = New System.Drawing.Size(395, 633)
        Me.DataGridViewDisponible.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Olive
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clases Aprovadas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Olive
        Me.Label2.Location = New System.Drawing.Point(743, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clases Disponible"
        '
        'Propuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1060, 633)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewDisponible)
        Me.Controls.Add(Me.DataGridViewAprovada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Propuesta"
        Me.Text = "Propuesta"
        CType(Me.DataGridViewAprovada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewAprovada As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewDisponible As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
