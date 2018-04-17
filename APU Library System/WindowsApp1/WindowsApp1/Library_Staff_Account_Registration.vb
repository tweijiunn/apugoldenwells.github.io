Public Class frmLSAR

    'For moving window without title bar
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    'Form shadow
    Public CS_DROPSHADOW As Int32 = &H20000

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim parameters As CreateParams = MyBase.CreateParams
            parameters.ClassStyle += CS_DROPSHADOW
            Return parameters
        End Get
    End Property

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        frmLSLI.Show()
        Me.Hide()
        frmLSLI.txtTPNumLI.Clear()
    End Sub
    Private Sub btnNavReport_Click(sender As Object, e As EventArgs) Handles btnNavReport.Click
        frmLibraryStaffs.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click
        'Minimise window
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
    Private Sub pnlTop_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseDown

        'Allows movement of window without title bar
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Private Sub pnlTop_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseMove

        'Allows movement of window without title bar
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Private Sub pnlTop_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseUp

        'Allows movement of window without title bar
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub pnlTPNum_Click(sender As Object, e As EventArgs) Handles pnlTPNum.Click, txtTPNum.Click
        txtTPNum.Select()
        linTPNum.BorderColor = Color.DimGray
        linName.BorderColor = Color.LightGray
        linRole.BorderColor = Color.LightGray
        linContact.BorderColor = Color.LightGray
    End Sub
    Private Sub pnlName_Click(sender As Object, e As EventArgs) Handles pnlName.Click, txtName.Click
        txtName.Select()
        linTPNum.BorderColor = Color.LightGray
        linName.BorderColor = Color.DimGray
        linRole.BorderColor = Color.LightGray
        linContact.BorderColor = Color.LightGray
    End Sub
    Private Sub pnlRole_Click(sender As Object, e As EventArgs) Handles pnlRole.Click, cmbRole.Click
        cmbRole.Select()
        linTPNum.BorderColor = Color.LightGray
        linName.BorderColor = Color.LightGray
        linRole.BorderColor = Color.DimGray
        linContact.BorderColor = Color.LightGray
    End Sub
    Private Sub pnlContact_Click(sender As Object, e As EventArgs) Handles pnlContact.Click, txtContact.Click
        txtContact.Select()
        linTPNum.BorderColor = Color.LightGray
        linName.BorderColor = Color.LightGray
        linRole.BorderColor = Color.LightGray
        linContact.BorderColor = Color.DimGray
    End Sub
End Class