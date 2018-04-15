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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New AMA.FormSkin()
        Me.FlatClose1 = New AMA.FlatClose()
        Me.FlatMini1 = New AMA.FlatMini()
        Me.FlatTabControl1 = New AMA.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnLoadMatch = New AMA.FlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblScorerName = New System.Windows.Forms.Label()
        Me.grpInfo = New AMA.FlatGroupBox()
        Me.btnDeductStealB = New AMA.FlatButton()
        Me.btnAddStealB = New AMA.FlatButton()
        Me.lblTeamBSteals = New System.Windows.Forms.Label()
        Me.lblStealsB = New System.Windows.Forms.Label()
        Me.btnDeductAssistB = New AMA.FlatButton()
        Me.btnAddAssistB = New AMA.FlatButton()
        Me.lblTeamBAssists = New System.Windows.Forms.Label()
        Me.lblAssistsB = New System.Windows.Forms.Label()
        Me.btnDeductStealA = New AMA.FlatButton()
        Me.btnAddStealA = New AMA.FlatButton()
        Me.lblTeamASteals = New System.Windows.Forms.Label()
        Me.lblStealsA = New System.Windows.Forms.Label()
        Me.btnDeductAssistA = New AMA.FlatButton()
        Me.btnAddAssistA = New AMA.FlatButton()
        Me.lblTeamAAssists = New System.Windows.Forms.Label()
        Me.lblAssistsA = New System.Windows.Forms.Label()
        Me.btnDeductFoulB = New AMA.FlatButton()
        Me.btnDeductFoulA = New AMA.FlatButton()
        Me.btnDeductB = New AMA.FlatButton()
        Me.btnDeductA = New AMA.FlatButton()
        Me.btnCloseMatch = New AMA.FlatButton()
        Me.lblTeamBPlayerPoints = New System.Windows.Forms.Label()
        Me.lblPointsB = New System.Windows.Forms.Label()
        Me.lblTeamAPlayerPoints = New System.Windows.Forms.Label()
        Me.lblPointsA = New System.Windows.Forms.Label()
        Me.grpTeamBPlayers = New AMA.FlatGroupBox()
        Me.lbTeamBPlayers = New System.Windows.Forms.ListBox()
        Me.grpTeamAPlayers = New AMA.FlatGroupBox()
        Me.lbTeamAPlayers = New System.Windows.Forms.ListBox()
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
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpEventSelection = New AMA.FlatGroupBox()
        Me.cboEventsFilter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnChange = New AMA.FlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogout = New AMA.FlatButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.grpTeamBPlayers.SuspendLayout()
        Me.grpTeamAPlayers.SuspendLayout()
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
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
        Me.FormSkin1.Size = New System.Drawing.Size(1051, 741)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Scorer Dashboard"
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(1021, 12)
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
        Me.FlatMini1.Location = New System.Drawing.Point(997, 12)
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
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 51)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(1051, 690)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnLoadMatch)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblScorerName)
        Me.TabPage1.Controls.Add(Me.grpInfo)
        Me.TabPage1.Controls.Add(Me.grpSelection)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1043, 642)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Scoring"
        '
        'btnLoadMatch
        '
        Me.btnLoadMatch.BackColor = System.Drawing.Color.Transparent
        Me.btnLoadMatch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnLoadMatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadMatch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnLoadMatch.Location = New System.Drawing.Point(919, 43)
        Me.btnLoadMatch.Name = "btnLoadMatch"
        Me.btnLoadMatch.Rounded = False
        Me.btnLoadMatch.Size = New System.Drawing.Size(106, 32)
        Me.btnLoadMatch.TabIndex = 29
        Me.btnLoadMatch.Text = "Load Match"
        Me.btnLoadMatch.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 605)
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
        Me.lblScorerName.Location = New System.Drawing.Point(88, 597)
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
        Me.grpInfo.Controls.Add(Me.btnDeductStealB)
        Me.grpInfo.Controls.Add(Me.btnAddStealB)
        Me.grpInfo.Controls.Add(Me.lblTeamBSteals)
        Me.grpInfo.Controls.Add(Me.lblStealsB)
        Me.grpInfo.Controls.Add(Me.btnDeductAssistB)
        Me.grpInfo.Controls.Add(Me.btnAddAssistB)
        Me.grpInfo.Controls.Add(Me.lblTeamBAssists)
        Me.grpInfo.Controls.Add(Me.lblAssistsB)
        Me.grpInfo.Controls.Add(Me.btnDeductStealA)
        Me.grpInfo.Controls.Add(Me.btnAddStealA)
        Me.grpInfo.Controls.Add(Me.lblTeamASteals)
        Me.grpInfo.Controls.Add(Me.lblStealsA)
        Me.grpInfo.Controls.Add(Me.btnDeductAssistA)
        Me.grpInfo.Controls.Add(Me.btnAddAssistA)
        Me.grpInfo.Controls.Add(Me.lblTeamAAssists)
        Me.grpInfo.Controls.Add(Me.lblAssistsA)
        Me.grpInfo.Controls.Add(Me.btnDeductFoulB)
        Me.grpInfo.Controls.Add(Me.btnDeductFoulA)
        Me.grpInfo.Controls.Add(Me.btnDeductB)
        Me.grpInfo.Controls.Add(Me.btnDeductA)
        Me.grpInfo.Controls.Add(Me.btnCloseMatch)
        Me.grpInfo.Controls.Add(Me.lblTeamBPlayerPoints)
        Me.grpInfo.Controls.Add(Me.lblPointsB)
        Me.grpInfo.Controls.Add(Me.lblTeamAPlayerPoints)
        Me.grpInfo.Controls.Add(Me.lblPointsA)
        Me.grpInfo.Controls.Add(Me.grpTeamBPlayers)
        Me.grpInfo.Controls.Add(Me.grpTeamAPlayers)
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
        Me.grpInfo.Location = New System.Drawing.Point(0, 101)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.ShowText = True
        Me.grpInfo.Size = New System.Drawing.Size(1043, 493)
        Me.grpInfo.TabIndex = 42
        Me.grpInfo.Text = "Match Information"
        '
        'btnDeductStealB
        '
        Me.btnDeductStealB.BackColor = System.Drawing.Color.Transparent
        Me.btnDeductStealB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDeductStealB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeductStealB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDeductStealB.Location = New System.Drawing.Point(726, 349)
        Me.btnDeductStealB.Name = "btnDeductStealB"
        Me.btnDeductStealB.Rounded = False
        Me.btnDeductStealB.Size = New System.Drawing.Size(24, 24)
        Me.btnDeductStealB.TabIndex = 76
        Me.btnDeductStealB.Text = "-"
        Me.btnDeductStealB.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAddStealB
        '
        Me.btnAddStealB.BackColor = System.Drawing.Color.Transparent
        Me.btnAddStealB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAddStealB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStealB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAddStealB.Location = New System.Drawing.Point(696, 349)
        Me.btnAddStealB.Name = "btnAddStealB"
        Me.btnAddStealB.Rounded = False
        Me.btnAddStealB.Size = New System.Drawing.Size(24, 24)
        Me.btnAddStealB.TabIndex = 75
        Me.btnAddStealB.Text = "+"
        Me.btnAddStealB.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblTeamBSteals
        '
        Me.lblTeamBSteals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTeamBSteals.Location = New System.Drawing.Point(634, 349)
        Me.lblTeamBSteals.Name = "lblTeamBSteals"
        Me.lblTeamBSteals.Size = New System.Drawing.Size(56, 21)
        Me.lblTeamBSteals.TabIndex = 74
        Me.lblTeamBSteals.Text = "0"
        Me.lblTeamBSteals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStealsB
        '
        Me.lblStealsB.AutoSize = True
        Me.lblStealsB.ForeColor = System.Drawing.Color.White
        Me.lblStealsB.Location = New System.Drawing.Point(574, 349)
        Me.lblStealsB.Name = "lblStealsB"
        Me.lblStealsB.Size = New System.Drawing.Size(55, 21)
        Me.lblStealsB.TabIndex = 73
        Me.lblStealsB.Text = "Steals"
        '
        'btnDeductAssistB
        '
        Me.btnDeductAssistB.BackColor = System.Drawing.Color.Transparent
        Me.btnDeductAssistB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDeductAssistB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeductAssistB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDeductAssistB.Location = New System.Drawing.Point(726, 314)
        Me.btnDeductAssistB.Name = "btnDeductAssistB"
        Me.btnDeductAssistB.Rounded = False
        Me.btnDeductAssistB.Size = New System.Drawing.Size(24, 24)
        Me.btnDeductAssistB.TabIndex = 72
        Me.btnDeductAssistB.Text = "-"
        Me.btnDeductAssistB.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAddAssistB
        '
        Me.btnAddAssistB.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAssistB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAddAssistB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAssistB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAddAssistB.Location = New System.Drawing.Point(696, 314)
        Me.btnAddAssistB.Name = "btnAddAssistB"
        Me.btnAddAssistB.Rounded = False
        Me.btnAddAssistB.Size = New System.Drawing.Size(24, 24)
        Me.btnAddAssistB.TabIndex = 71
        Me.btnAddAssistB.Text = "+"
        Me.btnAddAssistB.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblTeamBAssists
        '
        Me.lblTeamBAssists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTeamBAssists.Location = New System.Drawing.Point(634, 314)
        Me.lblTeamBAssists.Name = "lblTeamBAssists"
        Me.lblTeamBAssists.Size = New System.Drawing.Size(56, 21)
        Me.lblTeamBAssists.TabIndex = 70
        Me.lblTeamBAssists.Text = "0"
        Me.lblTeamBAssists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAssistsB
        '
        Me.lblAssistsB.AutoSize = True
        Me.lblAssistsB.ForeColor = System.Drawing.Color.White
        Me.lblAssistsB.Location = New System.Drawing.Point(574, 314)
        Me.lblAssistsB.Name = "lblAssistsB"
        Me.lblAssistsB.Size = New System.Drawing.Size(60, 21)
        Me.lblAssistsB.TabIndex = 69
        Me.lblAssistsB.Text = "Assists"
        '
        'btnDeductStealA
        '
        Me.btnDeductStealA.BackColor = System.Drawing.Color.Transparent
        Me.btnDeductStealA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDeductStealA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeductStealA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDeductStealA.Location = New System.Drawing.Point(424, 346)
        Me.btnDeductStealA.Name = "btnDeductStealA"
        Me.btnDeductStealA.Rounded = False
        Me.btnDeductStealA.Size = New System.Drawing.Size(24, 24)
        Me.btnDeductStealA.TabIndex = 68
        Me.btnDeductStealA.Text = "-"
        Me.btnDeductStealA.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAddStealA
        '
        Me.btnAddStealA.BackColor = System.Drawing.Color.Transparent
        Me.btnAddStealA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAddStealA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStealA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAddStealA.Location = New System.Drawing.Point(394, 346)
        Me.btnAddStealA.Name = "btnAddStealA"
        Me.btnAddStealA.Rounded = False
        Me.btnAddStealA.Size = New System.Drawing.Size(24, 24)
        Me.btnAddStealA.TabIndex = 67
        Me.btnAddStealA.Text = "+"
        Me.btnAddStealA.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblTeamASteals
        '
        Me.lblTeamASteals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTeamASteals.Location = New System.Drawing.Point(332, 349)
        Me.lblTeamASteals.Name = "lblTeamASteals"
        Me.lblTeamASteals.Size = New System.Drawing.Size(56, 21)
        Me.lblTeamASteals.TabIndex = 66
        Me.lblTeamASteals.Text = "0"
        Me.lblTeamASteals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStealsA
        '
        Me.lblStealsA.AutoSize = True
        Me.lblStealsA.ForeColor = System.Drawing.Color.White
        Me.lblStealsA.Location = New System.Drawing.Point(272, 349)
        Me.lblStealsA.Name = "lblStealsA"
        Me.lblStealsA.Size = New System.Drawing.Size(55, 21)
        Me.lblStealsA.TabIndex = 65
        Me.lblStealsA.Text = "Steals"
        '
        'btnDeductAssistA
        '
        Me.btnDeductAssistA.BackColor = System.Drawing.Color.Transparent
        Me.btnDeductAssistA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDeductAssistA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeductAssistA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDeductAssistA.Location = New System.Drawing.Point(424, 311)
        Me.btnDeductAssistA.Name = "btnDeductAssistA"
        Me.btnDeductAssistA.Rounded = False
        Me.btnDeductAssistA.Size = New System.Drawing.Size(24, 24)
        Me.btnDeductAssistA.TabIndex = 64
        Me.btnDeductAssistA.Text = "-"
        Me.btnDeductAssistA.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAddAssistA
        '
        Me.btnAddAssistA.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAssistA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAddAssistA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAssistA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAddAssistA.Location = New System.Drawing.Point(394, 311)
        Me.btnAddAssistA.Name = "btnAddAssistA"
        Me.btnAddAssistA.Rounded = False
        Me.btnAddAssistA.Size = New System.Drawing.Size(24, 24)
        Me.btnAddAssistA.TabIndex = 63
        Me.btnAddAssistA.Text = "+"
        Me.btnAddAssistA.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblTeamAAssists
        '
        Me.lblTeamAAssists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTeamAAssists.Location = New System.Drawing.Point(332, 314)
        Me.lblTeamAAssists.Name = "lblTeamAAssists"
        Me.lblTeamAAssists.Size = New System.Drawing.Size(56, 21)
        Me.lblTeamAAssists.TabIndex = 62
        Me.lblTeamAAssists.Text = "0"
        Me.lblTeamAAssists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAssistsA
        '
        Me.lblAssistsA.AutoSize = True
        Me.lblAssistsA.ForeColor = System.Drawing.Color.White
        Me.lblAssistsA.Location = New System.Drawing.Point(272, 314)
        Me.lblAssistsA.Name = "lblAssistsA"
        Me.lblAssistsA.Size = New System.Drawing.Size(60, 21)
        Me.lblAssistsA.TabIndex = 61
        Me.lblAssistsA.Text = "Assists"
        '
        'btnDeductFoulB
        '
        Me.btnDeductFoulB.BackColor = System.Drawing.Color.Transparent
        Me.btnDeductFoulB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDeductFoulB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeductFoulB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDeductFoulB.Location = New System.Drawing.Point(726, 281)
        Me.btnDeductFoulB.Name = "btnDeductFoulB"
        Me.btnDeductFoulB.Rounded = False
        Me.btnDeductFoulB.Size = New System.Drawing.Size(24, 24)
        Me.btnDeductFoulB.TabIndex = 60
        Me.btnDeductFoulB.Text = "-"
        Me.btnDeductFoulB.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnDeductFoulA
        '
        Me.btnDeductFoulA.BackColor = System.Drawing.Color.Transparent
        Me.btnDeductFoulA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDeductFoulA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeductFoulA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDeductFoulA.Location = New System.Drawing.Point(424, 278)
        Me.btnDeductFoulA.Name = "btnDeductFoulA"
        Me.btnDeductFoulA.Rounded = False
        Me.btnDeductFoulA.Size = New System.Drawing.Size(24, 24)
        Me.btnDeductFoulA.TabIndex = 59
        Me.btnDeductFoulA.Text = "-"
        Me.btnDeductFoulA.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnDeductB
        '
        Me.btnDeductB.BackColor = System.Drawing.Color.Transparent
        Me.btnDeductB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDeductB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeductB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDeductB.Location = New System.Drawing.Point(716, 232)
        Me.btnDeductB.Name = "btnDeductB"
        Me.btnDeductB.Rounded = False
        Me.btnDeductB.Size = New System.Drawing.Size(40, 32)
        Me.btnDeductB.TabIndex = 58
        Me.btnDeductB.Text = "-"
        Me.btnDeductB.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnDeductA
        '
        Me.btnDeductA.BackColor = System.Drawing.Color.Transparent
        Me.btnDeductA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDeductA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeductA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDeductA.Location = New System.Drawing.Point(414, 232)
        Me.btnDeductA.Name = "btnDeductA"
        Me.btnDeductA.Rounded = False
        Me.btnDeductA.Size = New System.Drawing.Size(40, 32)
        Me.btnDeductA.TabIndex = 57
        Me.btnDeductA.Text = "-"
        Me.btnDeductA.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnCloseMatch
        '
        Me.btnCloseMatch.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseMatch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCloseMatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseMatch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCloseMatch.Location = New System.Drawing.Point(368, 450)
        Me.btnCloseMatch.Name = "btnCloseMatch"
        Me.btnCloseMatch.Rounded = False
        Me.btnCloseMatch.Size = New System.Drawing.Size(106, 32)
        Me.btnCloseMatch.TabIndex = 56
        Me.btnCloseMatch.Text = "Close Match"
        Me.btnCloseMatch.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblTeamBPlayerPoints
        '
        Me.lblTeamBPlayerPoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTeamBPlayerPoints.Location = New System.Drawing.Point(669, 188)
        Me.lblTeamBPlayerPoints.Name = "lblTeamBPlayerPoints"
        Me.lblTeamBPlayerPoints.Size = New System.Drawing.Size(72, 21)
        Me.lblTeamBPlayerPoints.TabIndex = 55
        Me.lblTeamBPlayerPoints.Text = "0"
        Me.lblTeamBPlayerPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPointsB
        '
        Me.lblPointsB.AutoSize = True
        Me.lblPointsB.ForeColor = System.Drawing.Color.White
        Me.lblPointsB.Location = New System.Drawing.Point(605, 188)
        Me.lblPointsB.Name = "lblPointsB"
        Me.lblPointsB.Size = New System.Drawing.Size(58, 21)
        Me.lblPointsB.TabIndex = 54
        Me.lblPointsB.Text = "Points"
        '
        'lblTeamAPlayerPoints
        '
        Me.lblTeamAPlayerPoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTeamAPlayerPoints.Location = New System.Drawing.Point(359, 188)
        Me.lblTeamAPlayerPoints.Name = "lblTeamAPlayerPoints"
        Me.lblTeamAPlayerPoints.Size = New System.Drawing.Size(72, 21)
        Me.lblTeamAPlayerPoints.TabIndex = 53
        Me.lblTeamAPlayerPoints.Text = "0"
        Me.lblTeamAPlayerPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPointsA
        '
        Me.lblPointsA.AutoSize = True
        Me.lblPointsA.ForeColor = System.Drawing.Color.White
        Me.lblPointsA.Location = New System.Drawing.Point(295, 188)
        Me.lblPointsA.Name = "lblPointsA"
        Me.lblPointsA.Size = New System.Drawing.Size(58, 21)
        Me.lblPointsA.TabIndex = 52
        Me.lblPointsA.Text = "Points"
        '
        'grpTeamBPlayers
        '
        Me.grpTeamBPlayers.BackColor = System.Drawing.Color.Transparent
        Me.grpTeamBPlayers.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpTeamBPlayers.Controls.Add(Me.lbTeamBPlayers)
        Me.grpTeamBPlayers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpTeamBPlayers.Location = New System.Drawing.Point(795, 108)
        Me.grpTeamBPlayers.Name = "grpTeamBPlayers"
        Me.grpTeamBPlayers.ShowText = True
        Me.grpTeamBPlayers.Size = New System.Drawing.Size(240, 317)
        Me.grpTeamBPlayers.TabIndex = 51
        Me.grpTeamBPlayers.Text = "Players"
        '
        'lbTeamBPlayers
        '
        Me.lbTeamBPlayers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbTeamBPlayers.FormattingEnabled = True
        Me.lbTeamBPlayers.ItemHeight = 17
        Me.lbTeamBPlayers.Location = New System.Drawing.Point(0, 41)
        Me.lbTeamBPlayers.Name = "lbTeamBPlayers"
        Me.lbTeamBPlayers.Size = New System.Drawing.Size(240, 276)
        Me.lbTeamBPlayers.TabIndex = 1
        '
        'grpTeamAPlayers
        '
        Me.grpTeamAPlayers.BackColor = System.Drawing.Color.Transparent
        Me.grpTeamAPlayers.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpTeamAPlayers.Controls.Add(Me.lbTeamAPlayers)
        Me.grpTeamAPlayers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpTeamAPlayers.Location = New System.Drawing.Point(8, 109)
        Me.grpTeamAPlayers.Name = "grpTeamAPlayers"
        Me.grpTeamAPlayers.ShowText = True
        Me.grpTeamAPlayers.Size = New System.Drawing.Size(240, 317)
        Me.grpTeamAPlayers.TabIndex = 50
        Me.grpTeamAPlayers.Text = "Players"
        '
        'lbTeamAPlayers
        '
        Me.lbTeamAPlayers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbTeamAPlayers.FormattingEnabled = True
        Me.lbTeamAPlayers.ItemHeight = 17
        Me.lbTeamAPlayers.Location = New System.Drawing.Point(0, 41)
        Me.lbTeamAPlayers.Name = "lbTeamAPlayers"
        Me.lbTeamAPlayers.Size = New System.Drawing.Size(240, 276)
        Me.lbTeamAPlayers.TabIndex = 0
        '
        'btnAddFoulB
        '
        Me.btnAddFoulB.BackColor = System.Drawing.Color.Transparent
        Me.btnAddFoulB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAddFoulB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFoulB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAddFoulB.Location = New System.Drawing.Point(696, 281)
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
        Me.lblTeamBFouls.Location = New System.Drawing.Point(634, 281)
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
        Me.lblFoulB.Location = New System.Drawing.Point(574, 281)
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
        Me.btnAddFoulA.Location = New System.Drawing.Point(394, 278)
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
        Me.lblTeamAFouls.Location = New System.Drawing.Point(332, 278)
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
        Me.lblFoulA.Location = New System.Drawing.Point(272, 278)
        Me.lblFoulA.Name = "lblFoulA"
        Me.lblFoulA.Size = New System.Drawing.Size(50, 21)
        Me.lblFoulA.TabIndex = 44
        Me.lblFoulA.Text = "Fouls"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(75, 461)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 21)
        Me.lblStatus.TabIndex = 43
        Me.lblStatus.Text = "_____"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 461)
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
        Me.lblTeamA.Location = New System.Drawing.Point(20, 56)
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
        Me.btnAdd3B.Location = New System.Drawing.Point(578, 232)
        Me.btnAdd3B.Name = "btnAdd3B"
        Me.btnAdd3B.Rounded = False
        Me.btnAdd3B.Size = New System.Drawing.Size(40, 32)
        Me.btnAdd3B.TabIndex = 41
        Me.btnAdd3B.Text = "+3"
        Me.btnAdd3B.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnFinishMatch
        '
        Me.btnFinishMatch.BackColor = System.Drawing.Color.Transparent
        Me.btnFinishMatch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnFinishMatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinishMatch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnFinishMatch.Location = New System.Drawing.Point(480, 450)
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
        Me.lblAScore.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblAScore.Location = New System.Drawing.Point(340, 44)
        Me.lblAScore.Name = "lblAScore"
        Me.lblAScore.Size = New System.Drawing.Size(188, 82)
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
        Me.btnAdd2B.Location = New System.Drawing.Point(670, 232)
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
        Me.btnAdd1A.Location = New System.Drawing.Point(322, 232)
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
        Me.btnAdd1B.Location = New System.Drawing.Point(624, 232)
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
        Me.btnAdd2A.Location = New System.Drawing.Point(368, 232)
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
        Me.btnAdd3A.Location = New System.Drawing.Point(276, 232)
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
        Me.lblTeamB.Location = New System.Drawing.Point(733, 56)
        Me.lblTeamB.Name = "lblTeamB"
        Me.lblTeamB.Size = New System.Drawing.Size(307, 61)
        Me.lblTeamB.TabIndex = 30
        Me.lblTeamB.Text = "Team B"
        Me.lblTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBScore
        '
        Me.lblBScore.BackColor = System.Drawing.Color.Transparent
        Me.lblBScore.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblBScore.Location = New System.Drawing.Point(534, 44)
        Me.lblBScore.Name = "lblBScore"
        Me.lblBScore.Size = New System.Drawing.Size(188, 82)
        Me.lblBScore.TabIndex = 34
        Me.lblBScore.Text = "0"
        Me.lblBScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpSelection
        '
        Me.grpSelection.BackColor = System.Drawing.Color.Transparent
        Me.grpSelection.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpSelection.Controls.Add(Me.cboMatches)
        Me.grpSelection.Controls.Add(Me.Label1)
        Me.grpSelection.Controls.Add(Me.cboEvents)
        Me.grpSelection.Controls.Add(Me.lblFirstName)
        Me.grpSelection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelection.Location = New System.Drawing.Point(0, 0)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.ShowText = True
        Me.grpSelection.Size = New System.Drawing.Size(1043, 95)
        Me.grpSelection.TabIndex = 32
        Me.grpSelection.Text = "Match Selection"
        '
        'cboMatches
        '
        Me.cboMatches.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cboMatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMatches.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMatches.ForeColor = System.Drawing.Color.White
        Me.cboMatches.Location = New System.Drawing.Point(592, 42)
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
        Me.Label1.Location = New System.Drawing.Point(475, 41)
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
        Me.cboEvents.Location = New System.Drawing.Point(159, 42)
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
        Me.TabPage2.Size = New System.Drawing.Size(1043, 642)
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
        Me.FlatGroupBox1.Size = New System.Drawing.Size(1045, 545)
        Me.FlatGroupBox1.TabIndex = 1
        Me.FlatGroupBox1.Text = "Matches List"
        '
        'lstMatches
        '
        Me.lstMatches.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader7, Me.ColumnHeader11, Me.ColumnHeader8})
        Me.lstMatches.FullRowSelect = True
        Me.lstMatches.GridLines = True
        Me.lstMatches.Location = New System.Drawing.Point(5, 38)
        Me.lstMatches.MultiSelect = False
        Me.lstMatches.Name = "lstMatches"
        Me.lstMatches.Size = New System.Drawing.Size(1027, 495)
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
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "MVP"
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
        Me.grpEventSelection.Size = New System.Drawing.Size(1047, 95)
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
        Me.TabPage3.Size = New System.Drawing.Size(1043, 642)
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
        'frmScorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 741)
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
        Me.grpTeamBPlayers.ResumeLayout(False)
        Me.grpTeamAPlayers.ResumeLayout(False)
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
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpTeamBPlayers As AMA.FlatGroupBox
    Friend WithEvents lbTeamBPlayers As System.Windows.Forms.ListBox
    Friend WithEvents grpTeamAPlayers As AMA.FlatGroupBox
    Friend WithEvents lbTeamAPlayers As System.Windows.Forms.ListBox
    Friend WithEvents lblTeamBPlayerPoints As System.Windows.Forms.Label
    Friend WithEvents lblPointsB As System.Windows.Forms.Label
    Friend WithEvents lblTeamAPlayerPoints As System.Windows.Forms.Label
    Friend WithEvents lblPointsA As System.Windows.Forms.Label
    Friend WithEvents btnCloseMatch As AMA.FlatButton
    Friend WithEvents btnDeductB As AMA.FlatButton
    Friend WithEvents btnDeductA As AMA.FlatButton
    Friend WithEvents btnDeductFoulB As AMA.FlatButton
    Friend WithEvents btnDeductFoulA As AMA.FlatButton
    Friend WithEvents btnDeductAssistA As AMA.FlatButton
    Friend WithEvents btnAddAssistA As AMA.FlatButton
    Friend WithEvents lblTeamAAssists As System.Windows.Forms.Label
    Friend WithEvents lblAssistsA As System.Windows.Forms.Label
    Friend WithEvents btnDeductStealA As AMA.FlatButton
    Friend WithEvents btnAddStealA As AMA.FlatButton
    Friend WithEvents lblTeamASteals As System.Windows.Forms.Label
    Friend WithEvents lblStealsA As System.Windows.Forms.Label
    Friend WithEvents btnDeductStealB As AMA.FlatButton
    Friend WithEvents btnAddStealB As AMA.FlatButton
    Friend WithEvents lblTeamBSteals As System.Windows.Forms.Label
    Friend WithEvents lblStealsB As System.Windows.Forms.Label
    Friend WithEvents btnDeductAssistB As AMA.FlatButton
    Friend WithEvents btnAddAssistB As AMA.FlatButton
    Friend WithEvents lblTeamBAssists As System.Windows.Forms.Label
    Friend WithEvents lblAssistsB As System.Windows.Forms.Label
End Class
