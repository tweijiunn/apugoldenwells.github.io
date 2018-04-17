Public Class frmLSLI
    Public Property TP As String

    'For moving window without title bar
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    'Form shadow
    Public CS_DROPSHADOW As Int32 = &H20000

    'Rounded corner form
    Dim p As New Drawing2D.GraphicsPath()

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim parameters As CreateParams = MyBase.CreateParams
            parameters.ClassStyle += CS_DROPSHADOW
            Return parameters
        End Get
    End Property

    Private Sub frmLSLI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TP = CStr(txtTPNumLI.Text)

        'Rounded corner form
        'p.StartFigure()
        'p.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'p.AddLine(20, 0, Me.Width - 20, 0)
        'p.AddArc(New Rectangle(Me.Width - 20, 0, 20, 20), -90, 90)
        'p.AddLine(Me.Width, 20, Me.Width, Me.Height - 20)
        'p.AddArc(New Rectangle(Me.Width - 20, Me.Height - 20, 20, 20), 0, 90)
        'p.AddLine(Me.Width - 20, Me.Height, 20, Me.Height)
        'p.AddArc(New Rectangle(0, Me.Height - 20, 20, 20), 90, 90)
        'p.CloseFigure()
        'Me.Region = New Region(p)

    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        TP = txtTPNumLI.Text


        'Limiting the input for TP numbers only 8 characters
        If TP.Length = 8 And TP = "TP046085" Then
            frmLSCI.Show()
            Me.Hide()
            frmLSCI.lblFullName.Text = "Hoh Kok Young"
            frmLSCI.lblStaffTPNum.Text = "TP046085"


        ElseIf TP = "TP045369" Then
            frmLSCI.Show()
            Me.Hide()
            frmLSCI.lblFullName.Text = "Adib"
            frmLSCI.lblStaffTPNum.Text = "TP045369"


        ElseIf TP.Length = 5 And TP = "ADMIN" Then
            frmLibraryStaffs.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please Try Again.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click

        'Minimise window
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
    Private Sub txtTPNumLI_Click(sender As Object, e As EventArgs) Handles txtTPNumLI.Click

        'Clear label
        lblTPNumLI.Text = ""
        lblTPNumLI.SendToBack()
    End Sub
    Private Sub lblTPNumLI_Click(sender As Object, e As EventArgs) Handles lblTPNumLI.Click

        'Clear label and select textbox
        lblTPNumLI.Text = ""
        lblTPNumLI.SendToBack()
        txtTPNumLI.Select()
    End Sub
    Private Sub txtTPNumLI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTPNumLI.KeyDown

        'Hotkey enter to perform login
        If e.KeyCode = Keys.Enter Then
            btnLogIn.PerformClick()
        End If
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

    Private Sub txtTPNumLI_TextChanged(sender As Object, e As EventArgs) Handles txtTPNumLI.TextChanged
        TP = txtTPNumLI.Text

        If TP.Length >= 5 And TP.Length < 9 Then
            btnLogIn.Enabled = True
            pnlLogin.BackColor = Color.DodgerBlue
        Else
            btnLogIn.Enabled = False
            pnlLogin.BackColor = Color.DimGray
        End If
    End Sub
End Class