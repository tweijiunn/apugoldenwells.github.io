<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(99, 63)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(36, 13)
        Me.lblAdmin.TabIndex = 0
        Me.lblAdmin.Text = "Admin"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(79, 124)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(79, 185)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 2
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(79, 249)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdmin As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnLogOut As Button
End Class
