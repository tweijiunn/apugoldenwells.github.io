<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLSCI
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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblTPNumCI = New System.Windows.Forms.Label()
        Me.lblStaffTPNum = New System.Windows.Forms.Label()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblTimeCheckIn = New System.Windows.Forms.Label()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblDuty = New System.Windows.Forms.Label()
        Me.cmbDuty = New System.Windows.Forms.ComboBox()
        Me.chkTrainee = New System.Windows.Forms.CheckBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblTodaysWorkTime = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmrLSCI = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblYourDuty = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(8, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(87, 9)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(54, 13)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Full Name"
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Location = New System.Drawing.Point(41, 283)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckIn.TabIndex = 3
        Me.btnCheckIn.Text = "Check-In"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(93, 415)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'lblTPNumCI
        '
        Me.lblTPNumCI.AutoSize = True
        Me.lblTPNumCI.Location = New System.Drawing.Point(8, 36)
        Me.lblTPNumCI.Name = "lblTPNumCI"
        Me.lblTPNumCI.Size = New System.Drawing.Size(64, 13)
        Me.lblTPNumCI.TabIndex = 5
        Me.lblTPNumCI.Text = "TP Number:"
        '
        'lblStaffTPNum
        '
        Me.lblStaffTPNum.AutoSize = True
        Me.lblStaffTPNum.Location = New System.Drawing.Point(87, 36)
        Me.lblStaffTPNum.Name = "lblStaffTPNum"
        Me.lblStaffTPNum.Size = New System.Drawing.Size(86, 13)
        Me.lblStaffTPNum.TabIndex = 6
        Me.lblStaffTPNum.Text = "Staff TP Number"
        '
        'lblProfile
        '
        Me.lblProfile.AutoSize = True
        Me.lblProfile.Location = New System.Drawing.Point(109, 19)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(36, 13)
        Me.lblProfile.TabIndex = 7
        Me.lblProfile.Text = "Profile"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(41, 331)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckOut.TabIndex = 9
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'lblCheckIn
        '
        Me.lblCheckIn.Location = New System.Drawing.Point(122, 277)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(124, 35)
        Me.lblCheckIn.TabIndex = 10
        Me.lblCheckIn.Text = "Day, (00:00)"
        Me.lblCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeCheckIn
        '
        Me.lblTimeCheckIn.AutoSize = True
        Me.lblTimeCheckIn.Location = New System.Drawing.Point(60, 218)
        Me.lblTimeCheckIn.Name = "lblTimeCheckIn"
        Me.lblTimeCheckIn.Size = New System.Drawing.Size(79, 13)
        Me.lblTimeCheckIn.TabIndex = 11
        Me.lblTimeCheckIn.Text = "Time Check-In:"
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cmbDay.Location = New System.Drawing.Point(102, 248)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(121, 21)
        Me.cmbDay.TabIndex = 16
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(44, 251)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 17
        Me.lblDay.Text = "Day:"
        '
        'lblDuty
        '
        Me.lblDuty.AutoSize = True
        Me.lblDuty.Location = New System.Drawing.Point(23, 158)
        Me.lblDuty.Name = "lblDuty"
        Me.lblDuty.Size = New System.Drawing.Size(29, 13)
        Me.lblDuty.TabIndex = 18
        Me.lblDuty.Text = "Duty"
        '
        'cmbDuty
        '
        Me.cmbDuty.FormattingEnabled = True
        Me.cmbDuty.Items.AddRange(New Object() {"Counter Duty", "Shelving", "Book Processing", "Stock Check", "Extra Duty", "Replacement"})
        Me.cmbDuty.Location = New System.Drawing.Point(63, 155)
        Me.cmbDuty.Name = "cmbDuty"
        Me.cmbDuty.Size = New System.Drawing.Size(96, 21)
        Me.cmbDuty.TabIndex = 19
        '
        'chkTrainee
        '
        Me.chkTrainee.AutoSize = True
        Me.chkTrainee.Location = New System.Drawing.Point(182, 157)
        Me.chkTrainee.Name = "chkTrainee"
        Me.chkTrainee.Size = New System.Drawing.Size(62, 17)
        Me.chkTrainee.TabIndex = 21
        Me.chkTrainee.Text = "Trainee"
        Me.chkTrainee.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(168, 218)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(10, 13)
        Me.lblTime.TabIndex = 22
        Me.lblTime.Text = ":"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(145, 215)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(25, 20)
        Me.txtHours.TabIndex = 23
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(176, 215)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(25, 20)
        Me.txtMinutes.TabIndex = 24
        '
        'lblCheckOut
        '
        Me.lblCheckOut.Location = New System.Drawing.Point(122, 325)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(124, 35)
        Me.lblCheckOut.TabIndex = 25
        Me.lblCheckOut.Text = "Day, (00:00)"
        Me.lblCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTodaysWorkTime
        '
        Me.lblTodaysWorkTime.Location = New System.Drawing.Point(4, 371)
        Me.lblTodaysWorkTime.Name = "lblTodaysWorkTime"
        Me.lblTodaysWorkTime.Size = New System.Drawing.Size(250, 25)
        Me.lblTodaysWorkTime.TabIndex = 26
        Me.lblTodaysWorkTime.Text = "Today's Work Time"
        Me.lblTodaysWorkTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblTPNumCI)
        Me.Panel1.Controls.Add(Me.lblFullName)
        Me.Panel1.Controls.Add(Me.lblStaffTPNum)
        Me.Panel1.Location = New System.Drawing.Point(33, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 60)
        Me.Panel1.TabIndex = 27
        '
        'tmrLSCI
        '
        '
        'lblTimer
        '
        Me.lblTimer.Location = New System.Drawing.Point(51, 43)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(150, 37)
        Me.lblTimer.TabIndex = 28
        Me.lblTimer.Text = "Timer"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYourDuty
        '
        Me.lblYourDuty.Location = New System.Drawing.Point(76, 184)
        Me.lblYourDuty.Name = "lblYourDuty"
        Me.lblYourDuty.Size = New System.Drawing.Size(112, 20)
        Me.lblYourDuty.TabIndex = 29
        Me.lblYourDuty.Text = "Your Duty"
        Me.lblYourDuty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLSCI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 450)
        Me.Controls.Add(Me.lblYourDuty)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTodaysWorkTime)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.chkTrainee)
        Me.Controls.Add(Me.cmbDuty)
        Me.Controls.Add(Me.lblDuty)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.lblTimeCheckIn)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.lblProfile)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnCheckIn)
        Me.Name = "frmLSCI"
        Me.Text = "Library Staff Check-In"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents lblTPNumCI As Label
    Friend WithEvents lblStaffTPNum As Label
    Friend WithEvents lblProfile As Label
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblTimeCheckIn As Label
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblDuty As Label
    Friend WithEvents cmbDuty As ComboBox
    Friend WithEvents chkTrainee As CheckBox
    Friend WithEvents lblTime As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtMinutes As TextBox
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents lblTodaysWorkTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tmrLSCI As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblYourDuty As Label
End Class
