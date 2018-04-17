<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLSReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvLSCIS = New System.Windows.Forms.DataGridView()
        Me.clmDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTPNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDuty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCheckInTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmWorkHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCheckOutTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        CType(Me.dgvLSCIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLSCIS
        '
        Me.dgvLSCIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLSCIS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmDay, Me.clmTPNumber, Me.clmDuty, Me.clmCheckInTime, Me.clmWorkHours, Me.clmCheckOutTime})
        Me.dgvLSCIS.Location = New System.Drawing.Point(0, 1)
        Me.dgvLSCIS.Name = "dgvLSCIS"
        Me.dgvLSCIS.Size = New System.Drawing.Size(644, 387)
        Me.dgvLSCIS.TabIndex = 0
        '
        'clmDay
        '
        Me.clmDay.HeaderText = "Day"
        Me.clmDay.Name = "clmDay"
        '
        'clmTPNumber
        '
        Me.clmTPNumber.HeaderText = "TP Number"
        Me.clmTPNumber.Name = "clmTPNumber"
        '
        'clmDuty
        '
        Me.clmDuty.HeaderText = "Duty"
        Me.clmDuty.Name = "clmDuty"
        '
        'clmCheckInTime
        '
        Me.clmCheckInTime.HeaderText = "Check-In Time"
        Me.clmCheckInTime.Name = "clmCheckInTime"
        '
        'clmWorkHours
        '
        Me.clmWorkHours.HeaderText = "Work Hours"
        Me.clmWorkHours.Name = "clmWorkHours"
        '
        'clmCheckOutTime
        '
        Me.clmCheckOutTime.HeaderText = "Check-Out Time"
        Me.clmCheckOutTime.Name = "clmCheckOutTime"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(677, 59)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(677, 220)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'frmLSReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 388)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvLSCIS)
        Me.Name = "frmLSReport"
        Me.Text = "Library Staff Report"
        CType(Me.dgvLSCIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLSCIS As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents clmDay As DataGridViewTextBoxColumn
    Friend WithEvents clmTPNumber As DataGridViewTextBoxColumn
    Friend WithEvents clmDuty As DataGridViewTextBoxColumn
    Friend WithEvents clmCheckInTime As DataGridViewTextBoxColumn
    Friend WithEvents clmWorkHours As DataGridViewTextBoxColumn
    Friend WithEvents clmCheckOutTime As DataGridViewTextBoxColumn
End Class
