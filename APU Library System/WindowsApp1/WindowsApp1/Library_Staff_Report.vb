Public Class frmLSReport
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        frmLSLI.Show()
        Me.Hide()
        frmLSLI.txtTPNumLI.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvLSCIS.Rows.Clear()
    End Sub
End Class