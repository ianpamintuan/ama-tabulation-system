<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScorer))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FormSkin1 = New AMA.FormSkin()
        Me.FlatClose1 = New AMA.FlatClose()
        Me.FlatMini1 = New AMA.FlatMini()
        Me.FlatTabControl1 = New AMA.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblScorerName = New System.Windows.Forms.Label()
        Me.grpInfo = New AMA.FlatGroupBox()
        Me.btnAddFoulB = New AMA.FlatButton()
        Me.lblTeamBFouls = New System.Windows.Forms.Label()
        Me.lblFoulB = New System.Windows.Forms.Label()
        Me.btnAddFoulA = New AMA.FlatButton()
        Me.lblTeamAFouls = New System.Windows.Forms.Label()
        Me.lblFoulA = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTeamA = New System.Windows.Forms.Label()
        Me.btnAdd3B = New AMA.FlatButton()
        Me.btnPauseMatch = New AMA.FlatButton()
        Me.btnFinishMatch = New AMA.FlatButton()
        Me.lblAScore = New System.Windows.Forms.Label()
        Me.btnAdd2B = New AMA.FlatButton()
        Me.btnAdd1A = New AMA.FlatButton()
        Me.btnAdd1B = New AMA.FlatButton()
        Me.btnAdd2A = New AMA.FlatButton()
        Me.btnAdd3A = New AMA.FlatButton()
        Me.lblTeamB = New System.Windows.Forms.Label()
        Me.lblBScore = New System.Windows.Forms.Label()
        Me.grpSelection = New AMA.FlatGroupBox()
        Me.btnLoadMatch = New AMA.FlatButton()
        Me.cboMatches = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEvents = New System.Windows.Forms.ComboBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlatGroupBox1 = New AMA.FlatGroupBox()
        Me.lstMatches = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpEventSelection = New AMA.FlatGroupBox()
        Me.cboEventsFilter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnChange = New AMA.FlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogout = New AMA.FlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.grpSelection.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.grpEventSelection.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(793, 650)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Scorer Dashboard"
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(763, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 33
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(739, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 32
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 50)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(793, 600)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblScorerName)
        Me.TabPage1.Controls.Add(Me.grpInfo)
        Me.TabPage1.Controls.Add(Me.grpSelection)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(785, 552)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Scoring"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 515)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Scorer:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScorerName
        '
        Me.lblScorerName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScorerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblScorerName.Location = New System.Drawing.Point(88, 507)
        Me.lblScorerName.Name = "lblScorerName"
        Me.lblScorerName.Size = New System.Drawing.Size(415, 40)
        Me.lblScorerName.TabIndex = 43
        Me.lblScorerName.Text = "Scorer Name"
        Me.lblScorerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpInfo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpInfo.Controls.Add(Me.btnAddFoulB)
        Me.grpInfo.Controls.Add(Me.lblTeamBFouls)
        Me.grpInfo.Controls.Add(Me.lblFoulB)
        Me.grpInfo.Controls.Add(Me.btnAddFoulA)
        Me.grpInfo.Controls.Add(Me.lblTeamAFouls)
        Me.grpInfo.Controls.Add(Me.lblFoulA)
        Me.grpInfo.Controls.Add(Me.lblStatus)
        Me.grpInfo.Controls.Add(Me.Label2)
        Me.grpInfo.Controls.Add(Me.lblTeamA)
        Me.grpInfo.Controls.Add(Me.btnAdd3B)
        Me.grpInfo.Controls.Add(Me.btnPauseMatch)
        Me.grpInfo.Controls.Add(Me.btnFinishMatch)
        Me.grpInfo.Controls.Add(Me.lblAScore)
        Me.grpInfo.Controls.Add(Me.btnAdd2B)
        Me.grpInfo.Controls.Add(Me.btnAdd1A)
        Me.grpInfo.Controls.Add(Me.btnAdd1B)
        Me.grpInfo.Controls.Add(Me.btnAdd2A)
        Me.grpInfo.Controls.Add(Me.btnAdd3A)
        Me.grpInfo.Controls.Add(Me.lblTeamB)
        Me.grpInfo.Controls.Add(Me.lblBScore)
        Me.grpInfo.Enabled = False
        Me.grpInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(0, 159)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.ShowText = True
        Me.grpInfo.Size = New System.Drawing.Size(786, 337)
        Me.grpInfo.TabIndex = 42
        Me.grpInfo.Text = "Match Information"
        '
        'btnAddFoulB
        '
        Me.btnAddFoulB.BackColor = System.Drawing.Color.Transparent
        Me.btnAddFoulB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAddFoulB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFoulB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAddFoulB.Location = New System.Drawing.Point(634, 250)
        Me.btnAddFoulB.Name = "btnAddFoulB"
        Me.btnAddFoulB.Rounded = False
        Me.btnAddFoulB.Size = New System.Drawing.Size(24, 24)
        Me.btnAddFoulB.TabIndex = 49
        Me.btnAddFoulB.Text = "+"
        Me.btnAddFoulB.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblTeamBFouls
        '
        Me.lblTeamBFouls.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTeamBFouls.Location = New System.Drawing.Point(572, 250)
        Me.lblTeamBFouls.Name = "lblTeamBFouls"
        Me.lblTeamBFouls.Size = New System.Drawing.Size(56, 21)
        Me.lblTeamBFouls.TabIndex = 48
        Me.lblTeamBFouls.Text = "0"
        Me.lblTeamBFouls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoulB
        '
        Me.lblFoulB.AutoSize = True
        Me.lblFoulB.ForeColor = System.Drawing.Color.White
        Me.lblFoulB.Location = New System.Drawing.Point(522, 250)
        Me.lblFoulB.Name = "lblFoulB"
        Me.lblFoulB.Size = New System.Drawing.Size(50, 21)
        Me.lblFoulB.TabIndex = 47
        Me.lblFoulB.Text = "Fouls"
        '
        'btnAddFoulA
        '
        Me.btnAddFoulA.BackColor = System.Drawing.Color.Transparent
        Me.btnAddFoulA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAddFoulA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFoulA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAddFoulA.Location = New System.Drawing.Point(232, 250)
        Me.btnAddFoulA.Name = "btnAddFoulA"
        Me.btnAddFoulA.Rounded = False
        Me.btnAddFoulA.Size = New System.Drawing.Size(24, 24)
        Me.btnAddFoulA.TabIndex = 46
        Me.btnAddFoulA.Text = "+"
        Me.btnAddFoulA.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblTeamAFouls
        '
        Me.lblTeamAFouls.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTeamAFouls.Location = New System.Drawing.Point(170, 250)
        Me.lblTeamAFouls.Name = "lblTeamAFouls"
        Me.lblTeamAFouls.Size = New System.Drawing.Size(56, 21)
        Me.lblTeamAFouls.TabIndex = 45
        Me.lblTeamAFouls.Text = "0"
        Me.lblTeamAFouls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoulA
        '
        Me.lblFoulA.AutoSize = True
        Me.lblFoulA.ForeColor = System.Drawing.Color.White
        Me.lblFoulA.Location = New System.Drawing.Point(120, 250)
        Me.lblFoulA.Name = "lblFoulA"
        Me.lblFoulA.Size = New System.Drawing.Size(50, 21)
        Me.lblFoulA.TabIndex = 44
        Me.lblFoulA.Text = "Fouls"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(73, 305)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 21)
        Me.lblStatus.TabIndex = 43
        Me.lblStatus.Text = "_____"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Status:"
        '
        'lblTeamA
        '
        Me.lblTeamA.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamA.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblTeamA.Location = New System.Drawing.Point(37, 43)
        Me.lblTeamA.Name = "lblTeamA"
        Me.lblTeamA.Size = New System.Drawing.Size(305, 61)
        Me.lblTeamA.TabIndex = 29
        Me.lblTeamA.Text = "Team A"
        Me.lblTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd3B
        '
        Me.btnAdd3B.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd3B.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd3B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd3B.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd3B.Location = New System.Drawing.Point(525, 204)
        Me.btnAdd3B.Name = "btnAdd3B"
        Me.btnAdd3B.Rounded = False
        Me.btnAdd3B.Size = New System.Drawing.Size(40, 32)
        Me.btnAdd3B.TabIndex = 41
        Me.btnAdd3B.Text = "+3"
        Me.btnAdd3B.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnPauseMatch
        '
        Me.btnPauseMatch.BackColor = System.Drawing.Color.Transparent
        Me.btnPauseMatch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnPauseMatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPauseMatch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnPauseMatch.Location = New System.Drawing.Point(285, 294)
        Me.btnPauseMatch.Name = "btnPauseMatch"
        Me.btnPauseMatch.Rounded = False
        Me.btnPauseMatch.Size = New System.Drawing.Size(106, 32)
        Me.btnPauseMatch.TabIndex = 30
        Me.btnPauseMatch.Text = "Pause Match"
        Me.btnPauseMatch.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnFinishMatch
        '
        Me.btnFinishMatch.BackColor = System.Drawing.Color.Transparent
        Me.btnFinishMatch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnFinishMatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinishMatch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnFinishMatch.Location = New System.Drawing.Point(397, 294)
        Me.btnFinishMatch.Name = "btnFinishMatch"
        Me.btnFinishMatch.Rounded = False
        Me.btnFinishMatch.Size = New System.Drawing.Size(106, 32)
        Me.btnFinishMatch.TabIndex = 35
        Me.btnFinishMatch.Text = "Finish Match"
        Me.btnFinishMatch.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblAScore
        '
        Me.lblAScore.BackColor = System.Drawing.Color.Transparent
        Me.lblAScore.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblAScore.Location = New System.Drawing.Point(90, 104)
        Me.lblAScore.Name = "lblAScore"
        Me.lblAScore.Size = New System.Drawing.Size(207, 86)
        Me.lblAScore.TabIndex = 33
        Me.lblAScore.Text = "0"
        Me.lblAScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd2B
        '
        Me.btnAdd2B.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd2B.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd2B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd2B.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd2B.Location = New System.Drawing.Point(617, 204)
        Me.btnAdd2B.Name = "btnAdd2B"
        Me.btnAdd2B.Rounded = False
        Me.btnAdd2B.Size = New System.Drawing.Size(40, 32)
        Me.btnAdd2B.TabIndex = 40
        Me.btnAdd2B.Text = "+2"
        Me.btnAdd2B.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAdd1A
        '
        Me.btnAdd1A.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd1A.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd1A.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd1A.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd1A.Location = New System.Drawing.Point(170, 204)
        Me.btnAdd1A.Name = "btnAdd1A"
        Me.btnAdd1A.Rounded = False
        Me.btnAdd1A.Size = New System.Drawing.Size(40, 32)
        Me.btnAdd1A.TabIndex = 36
        Me.btnAdd1A.Text = "+1"
        Me.btnAdd1A.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAdd1B
        '
        Me.btnAdd1B.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd1B.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd1B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd1B.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd1B.Location = New System.Drawing.Point(571, 204)
        Me.btnAdd1B.Name = "btnAdd1B"
        Me.btnAdd1B.Rounded = False
        Me.btnAdd1B.Size = New System.Drawing.Size(40, 32)
        Me.btnAdd1B.TabIndex = 39
        Me.btnAdd1B.Text = "+1"
        Me.btnAdd1B.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAdd2A
        '
        Me.btnAdd2A.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd2A.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd2A.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd2A.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd2A.Location = New System.Drawing.Point(216, 204)
        Me.btnAdd2A.Name = "btnAdd2A"
        Me.btnAdd2A.Rounded = False
        Me.btnAdd2A.Size = New System.Drawing.Size(40, 32)
        Me.btnAdd2A.TabIndex = 37
        Me.btnAdd2A.Text = "+2"
        Me.btnAdd2A.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAdd3A
        '
        Me.btnAdd3A.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd3A.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd3A.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd3A.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd3A.Location = New System.Drawing.Point(124, 204)
        Me.btnAdd3A.Name = "btnAdd3A"
        Me.btnAdd3A.Rounded = False
        Me.btnAdd3A.Size = New System.Drawing.Size(40, 32)
        Me.btnAdd3A.TabIndex = 38
        Me.btnAdd3A.Text = "+3"
        Me.btnAdd3A.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblTeamB
        '
        Me.lblTeamB.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamB.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblTeamB.Location = New System.Drawing.Point(446, 43)
        Me.lblTeamB.Name = "lblTeamB"
        Me.lblTeamB.Size = New System.Drawing.Size(307, 61)
        Me.lblTeamB.TabIndex = 30
        Me.lblTeamB.Text = "Team B"
        Me.lblTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBScore
        '
        Me.lblBScore.BackColor = System.Drawing.Color.Transparent
        Me.lblBScore.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblBScore.Location = New System.Drawing.Point(496, 104)
        Me.lblBScore.Name = "lblBScore"
        Me.lblBScore.Size = New System.Drawing.Size(199, 86)
        Me.lblBScore.TabIndex = 34
        Me.lblBScore.Text = "0"
        Me.lblBScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpSelection
        '
        Me.grpSelection.BackColor = System.Drawing.Color.Transparent
        Me.grpSelection.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpSelection.Controls.Add(Me.btnLoadMatch)
        Me.grpSelection.Controls.Add(Me.cboMatches)
        Me.grpSelection.Controls.Add(Me.Label1)
        Me.grpSelection.Controls.Add(Me.cboEvents)
        Me.grpSelection.Controls.Add(Me.lblFirstName)
        Me.grpSelection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelection.Location = New System.Drawing.Point(0, 0)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.ShowText = True
        Me.grpSelection.Size = New System.Drawing.Size(786, 153)
        Me.grpSelection.TabIndex = 32
        Me.grpSelection.Text = "Match Selection"
        '
        'btnLoadMatch
        '
        Me.btnLoadMatch.BackColor = System.Drawing.Color.Transparent
        Me.btnLoadMatch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnLoadMatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadMatch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnLoadMatch.Location = New System.Drawing.Point(671, 102)
        Me.btnLoadMatch.Name = "btnLoadMatch"
        Me.btnLoadMatch.Rounded = False
        Me.btnLoadMatch.Size = New System.Drawing.Size(106, 32)
        Me.btnLoadMatch.TabIndex = 29
        Me.btnLoadMatch.Text = "Load Match"
        Me.btnLoadMatch.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cboMatches
        '
        Me.cboMatches.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cboMatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMatches.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMatches.ForeColor = System.Drawing.Color.White
        Me.cboMatches.Location = New System.Drawing.Point(210, 101)
        Me.cboMatches.Name = "cboMatches"
        Me.cboMatches.Size = New System.Drawing.Size(267, 33)
        Me.cboMatches.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 30)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Match #"
        '
        'cboEvents
        '
        Me.cboEvents.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cboEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEvents.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEvents.ForeColor = System.Drawing.Color.White
        Me.cboEvents.Location = New System.Drawing.Point(210, 42)
        Me.cboEvents.Name = "cboEvents"
        Me.cboEvents.Size = New System.Drawing.Size(267, 33)
        Me.cboEvents.TabIndex = 26
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(12, 41)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(126, 30)
        Me.lblFirstName.TabIndex = 12
        Me.lblFirstName.Text = "Event Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.FlatGroupBox1)
        Me.TabPage2.Controls.Add(Me.grpEventSelection)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(785, 552)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Match Results"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.lstMatches)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatGroupBox1.Location = New System.Drawing.Point(3, 101)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(783, 341)
        Me.FlatGroupBox1.TabIndex = 1
        Me.FlatGroupBox1.Text = "Matches List"
        '
        'lstMatches
        '
        Me.lstMatches.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lstMatches.FullRowSelect = True
        Me.lstMatches.GridLines = True
        Me.lstMatches.Location = New System.Drawing.Point(5, 38)
        Me.lstMatches.MultiSelect = False
        Me.lstMatches.Name = "lstMatches"
        Me.lstMatches.Size = New System.Drawing.Size(770, 300)
        Me.lstMatches.TabIndex = 0
        Me.lstMatches.UseCompatibleStateImageBehavior = False
        Me.lstMatches.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Match ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Event ID"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Team A"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Team B"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Team A Score"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Team B Score"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "A Fouls"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "B Fouls"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Winner"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Status"
        '
        'grpEventSelection
        '
        Me.grpEventSelection.BackColor = System.Drawing.Color.Transparent
        Me.grpEventSelection.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpEventSelection.Controls.Add(Me.cboEventsFilter)
        Me.grpEventSelection.Controls.Add(Me.Label3)
        Me.grpEventSelection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEventSelection.Location = New System.Drawing.Point(0, 0)
        Me.grpEventSelection.Name = "grpEventSelection"
        Me.grpEventSelection.ShowText = True
        Me.grpEventSelection.Size = New System.Drawing.Size(783, 95)
        Me.grpEventSelection.TabIndex = 0
        Me.grpEventSelection.Text = "Event Selection"
        '
        'cboEventsFilter
        '
        Me.cboEventsFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cboEventsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEventsFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEventsFilter.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEventsFilter.ForeColor = System.Drawing.Color.White
        Me.cboEventsFilter.FormattingEnabled = True
        Me.cboEventsFilter.Location = New System.Drawing.Point(194, 48)
        Me.cboEventsFilter.Name = "cboEventsFilter"
        Me.cboEventsFilter.Size = New System.Drawing.Size(261, 33)
        Me.cboEventsFilter.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select an event"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.btnChange)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.btnLogout)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(785, 552)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Option"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(28, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 30)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Logout"
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.Transparent
        Me.btnChange.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnChange.Location = New System.Drawing.Point(248, 31)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Rounded = False
        Me.btnChange.Size = New System.Drawing.Size(106, 32)
        Me.btnChange.TabIndex = 14
        Me.btnChange.Text = "Change"
        Me.btnChange.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(28, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 30)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Account Settings"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnLogout.Location = New System.Drawing.Point(248, 83)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Rounded = False
        Me.btnLogout.Size = New System.Drawing.Size(106, 34)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'frmScorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 650)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmScorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScorer"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.grpEventSelection.ResumeLayout(False)
        Me.grpEventSelection.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents FlatTabControl1 As AMA.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblTeamB As System.Windows.Forms.Label
    Friend WithEvents lblTeamA As System.Windows.Forms.Label
    Friend WithEvents grpSelection As AMA.FlatGroupBox
    Friend WithEvents btnLoadMatch As AMA.FlatButton
    Friend WithEvents cboMatches As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboEvents As System.Windows.Forms.ComboBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnFinishMatch As AMA.FlatButton
    Friend WithEvents btnPauseMatch As AMA.FlatButton
    Friend WithEvents lblBScore As System.Windows.Forms.Label
    Friend WithEvents lblAScore As System.Windows.Forms.Label
    Friend WithEvents btnLogout As AMA.FlatButton
    Friend WithEvents btnAdd3B As AMA.FlatButton
    Friend WithEvents btnAdd2B As AMA.FlatButton
    Friend WithEvents btnAdd1B As AMA.FlatButton
    Friend WithEvents btnAdd3A As AMA.FlatButton
    Friend WithEvents btnAdd2A As AMA.FlatButton
    Friend WithEvents btnAdd1A As AMA.FlatButton
    Friend WithEvents grpInfo As AMA.FlatGroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents grpEventSelection As AMA.FlatGroupBox
    Friend WithEvents cboEventsFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlatGroupBox1 As AMA.FlatGroupBox
    Friend WithEvents lstMatches As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddFoulB As AMA.FlatButton
    Friend WithEvents lblTeamBFouls As System.Windows.Forms.Label
    Friend WithEvents lblFoulB As System.Windows.Forms.Label
    Friend WithEvents btnAddFoulA As AMA.FlatButton
    Friend WithEvents lblTeamAFouls As System.Windows.Forms.Label
    Friend WithEvents lblFoulA As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents FlatClose1 As AMA.FlatClose
    Friend WithEvents FlatMini1 As AMA.FlatMini
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnChange As AMA.FlatButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblScorerName As System.Windows.Forms.Label
End Class
