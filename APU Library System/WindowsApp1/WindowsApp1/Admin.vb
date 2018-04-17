Public Class frmAdmin
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        frmLSLI.Show()
        Me.Hide()
        frmLSLI.txtTPNumLI.Clear()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmLibraryStaffs.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmLSAR.Show()
        Me.Hide()
    End Sub
End Class