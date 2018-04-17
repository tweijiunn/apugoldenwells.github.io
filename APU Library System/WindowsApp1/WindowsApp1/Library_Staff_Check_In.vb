Public Class frmLSCI
    Dim Time As String
    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        If txtHours.Text.Length = 2 And txtHours.Text >= 0 And txtHours.Text <= 11 And
            txtMinutes.Text.Length = 2 And txtMinutes.Text <= 59 Then
            Time = txtHours.Text + ":" + txtMinutes.Text + " AM"
        ElseIf txtHours.Text.Length = 2 And txtHours.Text <= 23 And txtHours.Text >= 12 And
                txtMinutes.Text.Length = 2 And txtMinutes.Text <= 59 Then
            Time = txtHours.Text + ":" + txtMinutes.Text + " PM"
        End If
        If lblStaffTPNum.Text = "TP046085" Then
            frmLSReport.dgvLSCIS.Rows.Add(cmbDay.SelectedItem.ToString(), lblStaffTPNum.Text, lblFullName.Text, Time, "", DateTime.Now.ToString("hh:mm tt"))
        End If

        If txtHours.Text.Length = 2 And txtHours.Text >= 0 And txtHours.Text <= 11 And
            txtMinutes.Text.Length = 2 And txtMinutes.Text <= 59 Then
            lblCheckIn.Text = "You checked in at " & vbCrLf + cmbDay.SelectedItem.ToString() + ", " + Time
        ElseIf txtHours.Text.Length = 2 And txtHours.Text <= 23 And txtHours.Text >= 12 And
                txtMinutes.Text.Length = 2 And txtMinutes.Text <= 59 Then
            lblCheckIn.Text = "You checked in at " & vbCrLf + cmbDay.SelectedItem.ToString() + ", " + Time
        Else
            MessageBox.Show("Please Try Again")
        End If

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        Me.Hide()
        frmLSLI.Show()
        frmLSLI.txtTPNumLI.Clear()
        txtHours.Clear()
        txtMinutes.Clear()
        lblCheckIn.Text = "Day, (00:00)"
        lblCheckOut.Text = "Day, (00:00)"
        lblTodaysWorkTime.Text = "Today's Work Time"

    End Sub


    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        lblCheckOut.Text = "You checked out at " & vbCrLf + cmbDay.SelectedItem.ToString() + ", " + DateTime.Now.ToString("hh:mm tt")
        lblTodaysWorkTime.Text = cmbDay.SelectedItem.ToString() + ", " + Time + ", " + cmbDay.SelectedItem.ToString() + ", " + DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub chkTrainee_CheckedChanged(sender As Object, e As EventArgs) Handles chkTrainee.CheckedChanged
        If chkTrainee.Checked = True Then
            cmbDuty.Enabled = False
            lblYourDuty.Text = "Trainee"
        ElseIf chkTrainee.Checked = False Then
            cmbDuty.Enabled = True
            lblYourDuty.Text = cmbDuty.SelectedItem.ToString()
        End If

    End Sub

    Private Sub frmLSCI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLSCI.Enabled = True
    End Sub

    Private Sub tmrLSCI_Tick(sender As Object, e As EventArgs) Handles tmrLSCI.Tick
        lblTimer.Text = DateTime.Now.ToString("dd-MM-yyyy" & vbCrLf + "hh:mm:ss:tt")
    End Sub

    Private Sub cmbDuty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDuty.SelectedIndexChanged
        lblYourDuty.Text = cmbDuty.SelectedItem.ToString()
    End Sub

End Class