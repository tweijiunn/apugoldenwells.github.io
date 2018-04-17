<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLSLI
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
        Me.lblLSLI = New System.Windows.Forms.Label()
        Me.lblTPNumLI = New System.Windows.Forms.Label()
        Me.txtTPNumLI = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.pnlTPNumber = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnMinimise = New System.Windows.Forms.Button()
        Me.pnlCentre = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlLogin.SuspendLayout()
        Me.pnlTPNumber.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlCentre.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLSLI
        '
        Me.lblLSLI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLSLI.AutoSize = True
        Me.lblLSLI.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLSLI.Location = New System.Drawing.Point(46, 257)
        Me.lblLSLI.Name = "lblLSLI"
        Me.lblLSLI.Size = New System.Drawing.Size(242, 29)
        Me.lblLSLI.TabIndex = 0
        Me.lblLSLI.Text = "Library Staff Log In"
        '
        'lblTPNumLI
        '
        Me.lblTPNumLI.AutoSize = True
        Me.lblTPNumLI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblTPNumLI.Font = New System.Drawing.Font("Verdana", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPNumLI.ForeColor = System.Drawing.Color.Gray
        Me.lblTPNumLI.Location = New System.Drawing.Point(99, 17)
        Me.lblTPNumLI.Name = "lblTPNumLI"
        Me.lblTPNumLI.Size = New System.Drawing.Size(134, 26)
        Me.lblTPNumLI.TabIndex = 0
        Me.lblTPNumLI.Text = "TP Number"
        '
        'txtTPNumLI
        '
        Me.txtTPNumLI.BackColor = System.Drawing.Color.LightGray
        Me.txtTPNumLI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTPNumLI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTPNumLI.Font = New System.Drawing.Font("Verdana", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTPNumLI.Location = New System.Drawing.Point(0, 17)
        Me.txtTPNumLI.Name = "txtTPNumLI"
        Me.txtTPNumLI.Size = New System.Drawing.Size(325, 27)
        Me.txtTPNumLI.TabIndex = 1
        Me.txtTPNumLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.Enabled = False
        Me.btnLogIn.FlatAppearance.BorderSize = 0
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Verdana", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Location = New System.Drawing.Point(0, 0)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(325, 60)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "Login"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(285, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "x"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.DimGray
        Me.pnlLogin.Controls.Add(Me.btnLogIn)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlLogin.Location = New System.Drawing.Point(0, 440)
        Me.pnlLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(325, 60)
        Me.pnlLogin.TabIndex = 7
        '
        'pnlTPNumber
        '
        Me.pnlTPNumber.BackColor = System.Drawing.Color.LightGray
        Me.pnlTPNumber.Controls.Add(Me.lblTPNumLI)
        Me.pnlTPNumber.Controls.Add(Me.txtTPNumLI)
        Me.pnlTPNumber.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTPNumber.Location = New System.Drawing.Point(0, 380)
        Me.pnlTPNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTPNumber.Name = "pnlTPNumber"
        Me.pnlTPNumber.Size = New System.Drawing.Size(325, 60)
        Me.pnlTPNumber.TabIndex = 8
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnMinimise)
        Me.pnlTop.Controls.Add(Me.btnExit)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(325, 40)
        Me.pnlTop.TabIndex = 0
        '
        'btnMinimise
        '
        Me.btnMinimise.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimise.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimise.FlatAppearance.BorderSize = 0
        Me.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimise.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimise.Location = New System.Drawing.Point(245, 0)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimise.TabIndex = 3
        Me.btnMinimise.Text = "_"
        Me.btnMinimise.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimise.UseVisualStyleBackColor = False
        '
        'pnlCentre
        '
        Me.pnlCentre.Controls.Add(Me.PictureBox1)
        Me.pnlCentre.Controls.Add(Me.lblLSLI)
        Me.pnlCentre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentre.Location = New System.Drawing.Point(0, 40)
        Me.pnlCentre.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCentre.Name = "pnlCentre"
        Me.pnlCentre.Size = New System.Drawing.Size(325, 340)
        Me.pnlCentre.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.APU_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(75, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmLSLI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(325, 500)
        Me.Controls.Add(Me.pnlCentre)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlTPNumber)
        Me.Controls.Add(Me.pnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLSLI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Staff Log In"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlTPNumber.ResumeLayout(False)
        Me.pnlTPNumber.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlCentre.ResumeLayout(False)
        Me.pnlCentre.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblLSLI As Label
    Friend WithEvents lblTPNumLI As Label
    Friend WithEvents txtTPNumLI As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents pnlTPNumber As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlCentre As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimise As Button
End Class
