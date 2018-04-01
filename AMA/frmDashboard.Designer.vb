<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.FormSkin1 = New AMA.FormSkin()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtRole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlatGroupBox1 = New AMA.FlatGroupBox()
        Me.btnMatches = New AMA.FlatButton()
        Me.btnEvents = New AMA.FlatButton()
        Me.btnTeams = New AMA.FlatButton()
        Me.btnLogout = New AMA.FlatButton()
        Me.btnPageant = New AMA.FlatButton()
        Me.btnIntramurals = New AMA.FlatButton()
        Me.btnAccounts = New AMA.FlatButton()
        Me.FlatMini1 = New AMA.FlatMini()
        Me.FlatClose1 = New AMA.FlatClose()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.StatusStrip1)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(993, 663)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Dashboard"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtName, Me.ToolStripStatusLabel2, Me.txtRole, Me.ToolStripStatusLabel3, Me.txtDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 633)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(993, 30)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 25)
        Me.ToolStripStatusLabel1.Text = "User"
        '
        'txtName
        '
        Me.txtName.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(282, 25)
        Me.txtName.Spring = True
        Me.txtName.Text = "txtName"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(43, 25)
        Me.ToolStripStatusLabel2.Text = "Role"
        '
        'txtRole
        '
        Me.txtRole.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.txtRole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(282, 25)
        Me.txtRole.Spring = True
        Me.txtRole.Text = "txtRole"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(44, 25)
        Me.ToolStripStatusLabel3.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(282, 25)
        Me.txtDate.Spring = True
        Me.txtDate.Text = "txtDate"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.AMA.My.Resources.Resources.AMA_logo
        Me.PictureBox1.Location = New System.Drawing.Point(369, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(538, 233)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(411, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(468, 45)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LAN-based Tabulation System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(557, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 45)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Computer College"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(465, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "AMA"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.btnMatches)
        Me.FlatGroupBox1.Controls.Add(Me.btnEvents)
        Me.FlatGroupBox1.Controls.Add(Me.btnTeams)
        Me.FlatGroupBox1.Controls.Add(Me.btnLogout)
        Me.FlatGroupBox1.Controls.Add(Me.btnPageant)
        Me.FlatGroupBox1.Controls.Add(Me.btnIntramurals)
        Me.FlatGroupBox1.Controls.Add(Me.btnAccounts)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatGroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(252, 610)
        Me.FlatGroupBox1.TabIndex = 2
        Me.FlatGroupBox1.Text = "Menu"
        '
        'btnMatches
        '
        Me.btnMatches.BackColor = System.Drawing.Color.Transparent
        Me.btnMatches.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnMatches.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMatches.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnMatches.Location = New System.Drawing.Point(3, 180)
        Me.btnMatches.Name = "btnMatches"
        Me.btnMatches.Rounded = False
        Me.btnMatches.Size = New System.Drawing.Size(246, 63)
        Me.btnMatches.TabIndex = 7
        Me.btnMatches.Text = "Matches"
        Me.btnMatches.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnEvents
        '
        Me.btnEvents.BackColor = System.Drawing.Color.Transparent
        Me.btnEvents.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnEvents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEvents.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnEvents.Location = New System.Drawing.Point(3, 111)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Rounded = False
        Me.btnEvents.Size = New System.Drawing.Size(246, 63)
        Me.btnEvents.TabIndex = 6
        Me.btnEvents.Text = "Events"
        Me.btnEvents.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnTeams
        '
        Me.btnTeams.BackColor = System.Drawing.Color.Transparent
        Me.btnTeams.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnTeams.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTeams.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTeams.Location = New System.Drawing.Point(3, 318)
        Me.btnTeams.Name = "btnTeams"
        Me.btnTeams.Rounded = False
        Me.btnTeams.Size = New System.Drawing.Size(246, 63)
        Me.btnTeams.TabIndex = 5
        Me.btnTeams.Text = "Teams"
        Me.btnTeams.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnLogout.Location = New System.Drawing.Point(3, 456)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Rounded = False
        Me.btnLogout.Size = New System.Drawing.Size(246, 63)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnPageant
        '
        Me.btnPageant.BackColor = System.Drawing.Color.Transparent
        Me.btnPageant.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnPageant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPageant.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnPageant.Location = New System.Drawing.Point(3, 387)
        Me.btnPageant.Name = "btnPageant"
        Me.btnPageant.Rounded = False
        Me.btnPageant.Size = New System.Drawing.Size(246, 63)
        Me.btnPageant.TabIndex = 3
        Me.btnPageant.Text = "Pageant"
        Me.btnPageant.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnIntramurals
        '
        Me.btnIntramurals.BackColor = System.Drawing.Color.Transparent
        Me.btnIntramurals.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnIntramurals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntramurals.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnIntramurals.Location = New System.Drawing.Point(3, 249)
        Me.btnIntramurals.Name = "btnIntramurals"
        Me.btnIntramurals.Rounded = False
        Me.btnIntramurals.Size = New System.Drawing.Size(246, 63)
        Me.btnIntramurals.TabIndex = 1
        Me.btnIntramurals.Text = "Intramurals"
        Me.btnIntramurals.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAccounts
        '
        Me.btnAccounts.BackColor = System.Drawing.Color.Transparent
        Me.btnAccounts.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccounts.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAccounts.Location = New System.Drawing.Point(3, 42)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Rounded = False
        Me.btnAccounts.Size = New System.Drawing.Size(246, 63)
        Me.btnAccounts.TabIndex = 0
        Me.btnAccounts.Text = "User Accounts"
        Me.btnAccounts.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(939, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(963, 13)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 663)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents FlatGroupBox1 As AMA.FlatGroupBox
    Friend WithEvents FlatMini1 As AMA.FlatMini
    Friend WithEvents FlatClose1 As AMA.FlatClose
    Friend WithEvents btnLogout As AMA.FlatButton
    Friend WithEvents btnPageant As AMA.FlatButton
    Friend WithEvents btnIntramurals As AMA.FlatButton
    Friend WithEvents btnAccounts As AMA.FlatButton
    Friend WithEvents btnTeams As AMA.FlatButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtRole As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnEvents As AMA.FlatButton
    Friend WithEvents btnMatches As AMA.FlatButton
End Class
