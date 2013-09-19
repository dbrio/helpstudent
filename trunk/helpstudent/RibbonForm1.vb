Public Class RibbonForm1 

    Private Sub ClientPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPanel.Paint
        With Inicio
            .Show()
            .Focus()
        End With
    End Sub
    Sub GestionarPanel()
        If XtraTabbedMdiManager1.Pages.Count = 0 Then

            ClientPanel.Visible = True
        Else
            ClientPanel.Visible = False

        End If
    End Sub
    Private Sub XtraTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded
        GestionarPanel()
    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        GestionarPanel()
    End Sub
End Class