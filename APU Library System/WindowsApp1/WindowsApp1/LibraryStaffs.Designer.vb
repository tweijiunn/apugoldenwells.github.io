<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLibraryStaffs
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAccountRegistration = New System.Windows.Forms.Label()
        Me.lblTPNum = New System.Windows.Forms.Label()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnMinimise = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnNavReport = New System.Windows.Forms.Button()
        Me.btnNavRegister = New System.Windows.Forms.Button()
        Me.pnlCentre = New System.Windows.Forms.Panel()
        Me.pnlName = New System.Windows.Forms.Panel()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.linName = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.pnlTPNum = New System.Windows.Forms.Panel()
        Me.txtTPNum = New System.Windows.Forms.TextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.linTPNum = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlNavRegister = New System.Windows.Forms.Panel()
        Me.pnlTop.SuspendLayout()
        Me.pnlCentre.SuspendLayout()
        Me.pnlName.SuspendLayout()
        Me.pnlTPNum.SuspendLayout()
        Me.pnlNavigation.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(38, 100)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(73, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblAccountRegistration
        '
        Me.lblAccountRegistration.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountRegistration.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountRegistration.Location = New System.Drawing.Point(0, 0)
        Me.lblAccountRegistration.Name = "lblAccountRegistration"
        Me.lblAccountRegistration.Size = New System.Drawing.Size(550, 50)
        Me.lblAccountRegistration.TabIndex = 0
        Me.lblAccountRegistration.Text = "Staff Report Generation"
        Me.lblAccountRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTPNum
        '
        Me.lblTPNum.AutoSize = True
        Me.lblTPNum.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPNum.Location = New System.Drawing.Point(38, 165)
        Me.lblTPNum.Name = "lblTPNum"
        Me.lblTPNum.Size = New System.Drawing.Size(124, 23)
        Me.lblTPNum.TabIndex = 0
        Me.lblTPNum.Text = "TP Number:"
        '
        'cmbName
        '
        Me.cmbName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbName.BackColor = System.Drawing.Color.White
        Me.cmbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(0, 2)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(275, 31)
        Me.cmbName.TabIndex = 4
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGenerate.FlatAppearance.BorderSize = 0
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(347, 383)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(163, 42)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnMinimise)
        Me.pnlTop.Controls.Add(Me.btnExit)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(150, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(550, 40)
        Me.pnlTop.TabIndex = 21
        '
        'btnMinimise
        '
        Me.btnMinimise.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimise.FlatAppearance.BorderSize = 0
        Me.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimise.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimise.Location = New System.Drawing.Point(470, 0)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimise.TabIndex = 9
        Me.btnMinimise.Text = "_"
        Me.btnMinimise.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimise.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(510, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "x"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.DimGray
        Me.btnLogOut.Location = New System.Drawing.Point(0, 460)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(150, 40)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnNavReport
        '
        Me.btnNavReport.FlatAppearance.BorderSize = 0
        Me.btnNavReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavReport.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavReport.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnNavReport.Location = New System.Drawing.Point(0, 100)
        Me.btnNavReport.Name = "btnNavReport"
        Me.btnNavReport.Size = New System.Drawing.Size(150, 40)
        Me.btnNavReport.TabIndex = 7
        Me.btnNavReport.Text = "   Report"
        Me.btnNavReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavReport.UseVisualStyleBackColor = True
        '
        'btnNavRegister
        '
        Me.btnNavRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnNavRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNavRegister.FlatAppearance.BorderSize = 0
        Me.btnNavRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavRegister.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavRegister.ForeColor = System.Drawing.Color.Black
        Me.btnNavRegister.Location = New System.Drawing.Point(0, 150)
        Me.btnNavRegister.Name = "btnNavRegister"
        Me.btnNavRegister.Size = New System.Drawing.Size(150, 40)
        Me.btnNavRegister.TabIndex = 6
        Me.btnNavRegister.Text = "   Register"
        Me.btnNavRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavRegister.UseVisualStyleBackColor = False
        '
        'pnlCentre
        '
        Me.pnlCentre.Controls.Add(Me.pnlName)
        Me.pnlCentre.Controls.Add(Me.pnlTPNum)
        Me.pnlCentre.Controls.Add(Me.lblAccountRegistration)
        Me.pnlCentre.Controls.Add(Me.lblName)
        Me.pnlCentre.Controls.Add(Me.btnGenerate)
        Me.pnlCentre.Controls.Add(Me.lblTPNum)
        Me.pnlCentre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentre.Location = New System.Drawing.Point(150, 40)
        Me.pnlCentre.Name = "pnlCentre"
        Me.pnlCentre.Size = New System.Drawing.Size(550, 460)
        Me.pnlCentre.TabIndex = 1
        '
        'pnlName
        '
        Me.pnlName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlName.BackColor = System.Drawing.Color.Transparent
        Me.pnlName.Controls.Add(Me.cmbName)
        Me.pnlName.Controls.Add(Me.ShapeContainer4)
        Me.pnlName.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlName.Location = New System.Drawing.Point(225, 90)
        Me.pnlName.Name = "pnlName"
        Me.pnlName.Size = New System.Drawing.Size(275, 40)
        Me.pnlName.TabIndex = 24
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.linName})
        Me.ShapeContainer4.Size = New System.Drawing.Size(275, 40)
        Me.ShapeContainer4.TabIndex = 17
        Me.ShapeContainer4.TabStop = False
        '
        'linName
        '
        Me.linName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linName.BorderColor = System.Drawing.Color.LightGray
        Me.linName.BorderWidth = 2
        Me.linName.Name = "linName"
        Me.linName.X1 = 0
        Me.linName.X2 = 275
        Me.linName.Y1 = 35
        Me.linName.Y2 = 35
        '
        'pnlTPNum
        '
        Me.pnlTPNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTPNum.BackColor = System.Drawing.Color.Transparent
        Me.pnlTPNum.Controls.Add(Me.txtTPNum)
        Me.pnlTPNum.Controls.Add(Me.ShapeContainer2)
        Me.pnlTPNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pnlTPNum.Location = New System.Drawing.Point(225, 155)
        Me.pnlTPNum.Name = "pnlTPNum"
        Me.pnlTPNum.Size = New System.Drawing.Size(275, 40)
        Me.pnlTPNum.TabIndex = 22
        '
        'txtTPNum
        '
        Me.txtTPNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTPNum.BackColor = System.Drawing.Color.White
        Me.txtTPNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTPNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTPNum.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTPNum.Location = New System.Drawing.Point(15, 10)
        Me.txtTPNum.Name = "txtTPNum"
        Me.txtTPNum.Size = New System.Drawing.Size(245, 24)
        Me.txtTPNum.TabIndex = 2
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.linTPNum})
        Me.ShapeContainer2.Size = New System.Drawing.Size(275, 40)
        Me.ShapeContainer2.TabIndex = 17
        Me.ShapeContainer2.TabStop = False
        '
        'linTPNum
        '
        Me.linTPNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linTPNum.BorderColor = System.Drawing.Color.LightGray
        Me.linTPNum.BorderWidth = 2
        Me.linTPNum.Name = "linTPNum"
        Me.linTPNum.X1 = 0
        Me.linTPNum.X2 = 275
        Me.linTPNum.Y1 = 35
        Me.linTPNum.Y2 = 35
        '
        'pnlNavigation
        '
        Me.pnlNavigation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlNavigation.Controls.Add(Me.PictureBox1)
        Me.pnlNavigation.Controls.Add(Me.pnlNavRegister)
        Me.pnlNavigation.Controls.Add(Me.btnNavReport)
        Me.pnlNavigation.Controls.Add(Me.btnLogOut)
        Me.pnlNavigation.Controls.Add(Me.btnNavRegister)
        Me.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNavigation.Location = New System.Drawing.Point(0, 0)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(150, 500)
        Me.pnlNavigation.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.APU_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(41, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'pnlNavRegister
        '
        Me.pnlNavRegister.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlNavRegister.ForeColor = System.Drawing.Color.DodgerBlue
        Me.pnlNavRegister.Location = New System.Drawing.Point(0, 100)
        Me.pnlNavRegister.Name = "pnlNavRegister"
        Me.pnlNavRegister.Size = New System.Drawing.Size(5, 40)
        Me.pnlNavRegister.TabIndex = 0
        '
        'frmLibraryStaffs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.pnlCentre)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlNavigation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLibraryStaffs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Staff Account Registration"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlCentre.ResumeLayout(False)
        Me.pnlCentre.PerformLayout()
        Me.pnlName.ResumeLayout(False)
        Me.pnlTPNum.ResumeLayout(False)
        Me.pnlTPNum.PerformLayout()
        Me.pnlNavigation.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents lblAccountRegistration As Label
    Friend WithEvents lblTPNum As Label
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlCentre As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnNavReport As Button
    Friend WithEvents btnNavRegister As Button
    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents pnlNavRegister As Panel
    Friend WithEvents btnMinimise As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlName As Panel
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents linName As PowerPacks.LineShape
    Friend WithEvents pnlTPNum As Panel
    Friend WithEvents txtTPNum As TextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents linTPNum As PowerPacks.LineShape
End Class
