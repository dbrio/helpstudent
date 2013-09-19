Imports System.Net.NetworkInformation
Imports System.Windows.Forms
Public Class MDIParent1
    Dim DS As New DataSet

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStripMenuItem.Click

        Try

            With AgregarClase
                .MdiParent = MdiParent
                .Show()
                .Focus()
            End With
            Me.Enabled = False
        Catch ex As Exception

        End Try

       

       
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Inicio.Close()
        PlandeEstudio.Close()
        perfil.Close()
        Matricula.Close()
        Propuesta.Close()
        Historial.Close()
        EditarUsuario.Close()
        ActualizarNotas.Close()


    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

  

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim contar As Integer = db.GetCount("CtaAlum", "Alumno")

        If NetworkInterface.GetIsNetworkAvailable And contar > 0 Then
            Dim agenda As DataTable = db.GetDataTemporal("SELECT * FROM Agenda")
            Dim alumnos As DataTable = db.GetDataTemporal("SELECT * FROM Alumno")
            Dim login As DataTable = db.GetDataTemporal("SELECT * FROM Login")
            Dim matricula As DataTable = db.GetDataTemporal("SELECT * FROM Matricula")
            Dim periodo As DataTable = db.GetDataTemporal("SELECT * FROM Periodo")

            For Each linea As DataRow In alumnos.Rows
                'Insertamos a mysql si hay internet
                Dim insert As String = String.Format("INSERT INTO Alumno (CtaAlum, Nombre, Apellido, Telefono,IdSexo,IdCarrera,Correo,Imagen) VALUES ('{0}','{1}','{2}','{3}','{4}',{5},{6},'{7}')", linea(0), linea(1), linea(2), linea(3), linea(4), linea(5), linea(6), linea(7))
                db.MyNotQuery(insert)

                'Borramos de la base de datos temporarl tabla Alumno
                db.NotQueryTemporal("DELETE FROM Alumno")

            Next

            Dim star = Inicio
            star.MdiParent = Me
            star.Show()
           


        Else
            Dim star = Inicio
            star.MdiParent = Me
            star.Show()
        End If


    End Sub

    
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
       
        With Inicio
            .MdiParent = MdiParent
            .Show()
            .Focus()
        End With
        perfil.Close()
        Historial.Close()
        Matricula.Close()
        PlandeEstudio.Close()
        Propuesta.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try

            With Matricula
                .MdiParent = MdiParent
                .Show()
                .Focus()
            End With
            Me.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles FlowLayoutPanel1.Paint
        Inicio.MdiParent = Me.MdiParent
    End Sub
    
End Class

