<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJudgeTally
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJudgeTally))
        Me.FormSkin1 = New AMA.FormSkin()
        Me.FlatMini1 = New AMA.FlatMini()
        Me.FlatClose1 = New AMA.FlatClose()
        Me.FlatTabControl1 = New AMA.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpScoresTally = New AMA.FlatGroupBox()
        Me.FlatTabControl2 = New AMA.FlatTabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lstScoresTallyMr = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lstScoresTallyMs = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblJudgeName = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblWinnerMsName = New System.Windows.Forms.Label()
        Me.lblWinnerMrName = New System.Windows.Forms.Label()
        Me.lblWinnerMs = New System.Windows.Forms.Label()
        Me.lblWinnerMr = New System.Windows.Forms.Label()
        Me.lblTotalJudges = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEventName2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpPageantSummary = New AMA.FlatGroupBox()
        Me.FlatTabControl3 = New AMA.FlatTabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lstTotalMr = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.lstTotalMs = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpScoresTally.SuspendLayout()
        Me.FlatTabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpPageantSummary.SuspendLayout()
        Me.FlatTabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(791, 562)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Judge Tally"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(737, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 2
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(761, 13)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 1
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 47)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(791, 515)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lblEventName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.grpScoresTally)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblJudgeName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(783, 467)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "My Sheet"
        '
        'lblEventName
        '
        Me.lblEventName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblEventName.Location = New System.Drawing.Point(81, 384)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(394, 40)
        Me.lblEventName.TabIndex = 30
        Me.lblEventName.Text = "Event Name"
        Me.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Event:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpScoresTally
        '
        Me.grpScoresTally.BackColor = System.Drawing.Color.Transparent
        Me.grpScoresTally.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpScoresTally.Controls.Add(Me.FlatTabControl2)
        Me.grpScoresTally.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpScoresTally.Location = New System.Drawing.Point(0, 0)
        Me.grpScoresTally.Name = "grpScoresTally"
        Me.grpScoresTally.ShowText = True
        Me.grpScoresTally.Size = New System.Drawing.Size(784, 364)
        Me.grpScoresTally.TabIndex = 0
        Me.grpScoresTally.Text = "Scores Tally"
        '
        'FlatTabControl2
        '
        Me.FlatTabControl2.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl2.Controls.Add(Me.TabPage3)
        Me.FlatTabControl2.Controls.Add(Me.TabPage4)
        Me.FlatTabControl2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl2.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl2.Location = New System.Drawing.Point(8, 39)
        Me.FlatTabControl2.Name = "FlatTabControl2"
        Me.FlatTabControl2.SelectedIndex = 0
        Me.FlatTabControl2.Size = New System.Drawing.Size(767, 325)
        Me.FlatTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.lstScoresTallyMr)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(759, 277)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Mr"
        '
        'lstScoresTallyMr
        '
        Me.lstScoresTallyMr.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstScoresTallyMr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstScoresTallyMr.FullRowSelect = True
        Me.lstScoresTallyMr.GridLines = True
        Me.lstScoresTallyMr.Location = New System.Drawing.Point(3, 3)
        Me.lstScoresTallyMr.MultiSelect = False
        Me.lstScoresTallyMr.Name = "lstScoresTallyMr"
        Me.lstScoresTallyMr.Size = New System.Drawing.Size(753, 271)
        Me.lstScoresTallyMr.TabIndex = 0
        Me.lstScoresTallyMr.UseCompatibleStateImageBehavior = False
        Me.lstScoresTallyMr.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Contestant ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Score"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.lstScoresTallyMs)
        Me.TabPage4.Location = New System.Drawing.Point(4, 44)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(759, 277)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Ms"
        '
        'lstScoresTallyMs
        '
        Me.lstScoresTallyMs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstScoresTallyMs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstScoresTallyMs.FullRowSelect = True
        Me.lstScoresTallyMs.GridLines = True
        Me.lstScoresTallyMs.Location = New System.Drawing.Point(3, 3)
        Me.lstScoresTallyMs.MultiSelect = False
        Me.lstScoresTallyMs.Name = "lstScoresTallyMs"
        Me.lstScoresTallyMs.Size = New System.Drawing.Size(753, 271)
        Me.lstScoresTallyMs.TabIndex = 0
        Me.lstScoresTallyMs.UseCompatibleStateImageBehavior = False
        Me.lstScoresTallyMs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Contestant ID"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Score"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Judge:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJudgeName
        '
        Me.lblJudgeName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudgeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblJudgeName.Location = New System.Drawing.Point(81, 417)
        Me.lblJudgeName.Name = "lblJudgeName"
        Me.lblJudgeName.Size = New System.Drawing.Size(394, 40)
        Me.lblJudgeName.TabIndex = 27
        Me.lblJudgeName.Text = "Judge Name"
        Me.lblJudgeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.lblWinnerMsName)
        Me.TabPage2.Controls.Add(Me.lblWinnerMrName)
        Me.TabPage2.Controls.Add(Me.lblWinnerMs)
        Me.TabPage2.Controls.Add(Me.lblWinnerMr)
        Me.TabPage2.Controls.Add(Me.lblTotalJudges)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.lblEventName2)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.grpPageantSummary)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(783, 467)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Overall"
        '
        'lblWinnerMsName
        '
        Me.lblWinnerMsName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerMsName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblWinnerMsName.Location = New System.Drawing.Point(152, 419)
        Me.lblWinnerMsName.Name = "lblWinnerMsName"
        Me.lblWinnerMsName.Size = New System.Drawing.Size(606, 40)
        Me.lblWinnerMsName.TabIndex = 38
        Me.lblWinnerMsName.Text = "Name"
        Me.lblWinnerMsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWinnerMrName
        '
        Me.lblWinnerMrName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerMrName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblWinnerMrName.Location = New System.Drawing.Point(152, 380)
        Me.lblWinnerMrName.Name = "lblWinnerMrName"
        Me.lblWinnerMrName.Size = New System.Drawing.Size(606, 40)
        Me.lblWinnerMrName.TabIndex = 37
        Me.lblWinnerMrName.Text = "Name"
        Me.lblWinnerMrName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWinnerMs
        '
        Me.lblWinnerMs.AutoSize = True
        Me.lblWinnerMs.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerMs.ForeColor = System.Drawing.Color.White
        Me.lblWinnerMs.Location = New System.Drawing.Point(10, 427)
        Me.lblWinnerMs.Name = "lblWinnerMs"
        Me.lblWinnerMs.Size = New System.Drawing.Size(123, 25)
        Me.lblWinnerMs.TabIndex = 36
        Me.lblWinnerMs.Text = "Winner(Ms):"
        Me.lblWinnerMs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWinnerMr
        '
        Me.lblWinnerMr.AutoSize = True
        Me.lblWinnerMr.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerMr.ForeColor = System.Drawing.Color.White
        Me.lblWinnerMr.Location = New System.Drawing.Point(10, 388)
        Me.lblWinnerMr.Name = "lblWinnerMr"
        Me.lblWinnerMr.Size = New System.Drawing.Size(123, 25)
        Me.lblWinnerMr.TabIndex = 35
        Me.lblWinnerMr.Text = "Winner(Mr):"
        Me.lblWinnerMr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalJudges
        '
        Me.lblTotalJudges.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalJudges.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTotalJudges.Location = New System.Drawing.Point(688, 338)
        Me.lblTotalJudges.Name = "lblTotalJudges"
        Me.lblTotalJudges.Size = New System.Drawing.Size(63, 40)
        Me.lblTotalJudges.TabIndex = 34
        Me.lblTotalJudges.Text = "0"
        Me.lblTotalJudges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(457, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Judges sheet submitted:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEventName2
        '
        Me.lblEventName2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblEventName2.Location = New System.Drawing.Point(82, 338)
        Me.lblEventName2.Name = "lblEventName2"
        Me.lblEventName2.Size = New System.Drawing.Size(341, 40)
        Me.lblEventName2.TabIndex = 32
        Me.lblEventName2.Text = "Event Name"
        Me.lblEventName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Event:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpPageantSummary
        '
        Me.grpPageantSummary.BackColor = System.Drawing.Color.Transparent
        Me.grpPageantSummary.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpPageantSummary.Controls.Add(Me.FlatTabControl3)
        Me.grpPageantSummary.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpPageantSummary.Location = New System.Drawing.Point(1, 1)
        Me.grpPageantSummary.Name = "grpPageantSummary"
        Me.grpPageantSummary.ShowText = True
        Me.grpPageantSummary.Size = New System.Drawing.Size(782, 342)
        Me.grpPageantSummary.TabIndex = 0
        Me.grpPageantSummary.Text = "Pageant Summary"
        '
        'FlatTabControl3
        '
        Me.FlatTabControl3.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl3.Controls.Add(Me.TabPage5)
        Me.FlatTabControl3.Controls.Add(Me.TabPage6)
        Me.FlatTabControl3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl3.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl3.Location = New System.Drawing.Point(7, 39)
        Me.FlatTabControl3.Name = "FlatTabControl3"
        Me.FlatTabControl3.SelectedIndex = 0
        Me.FlatTabControl3.Size = New System.Drawing.Size(769, 294)
        Me.FlatTabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl3.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.lstTotalMr)
        Me.TabPage5.Location = New System.Drawing.Point(4, 44)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(761, 246)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Mr"
        '
        'lstTotalMr
        '
        Me.lstTotalMr.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lstTotalMr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTotalMr.FullRowSelect = True
        Me.lstTotalMr.GridLines = True
        Me.lstTotalMr.Location = New System.Drawing.Point(3, 3)
        Me.lstTotalMr.MultiSelect = False
        Me.lstTotalMr.Name = "lstTotalMr"
        Me.lstTotalMr.Size = New System.Drawing.Size(755, 240)
        Me.lstTotalMr.TabIndex = 0
        Me.lstTotalMr.UseCompatibleStateImageBehavior = False
        Me.lstTotalMr.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Contestant ID"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Name"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.lstTotalMs)
        Me.TabPage6.Location = New System.Drawing.Point(4, 44)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(761, 246)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Ms"
        '
        'lstTotalMs
        '
        Me.lstTotalMs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lstTotalMs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTotalMs.FullRowSelect = True
        Me.lstTotalMs.GridLines = True
        Me.lstTotalMs.Location = New System.Drawing.Point(3, 3)
        Me.lstTotalMs.MultiSelect = False
        Me.lstTotalMs.Name = "lstTotalMs"
        Me.lstTotalMs.Size = New System.Drawing.Size(755, 240)
        Me.lstTotalMs.TabIndex = 0
        Me.lstTotalMs.UseCompatibleStateImageBehavior = False
        Me.lstTotalMs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Contestant ID"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Name"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Total"
        '
        'frmJudgeTally
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 562)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmJudgeTally"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJudgeTally"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpScoresTally.ResumeLayout(False)
        Me.FlatTabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.grpPageantSummary.ResumeLayout(False)
        Me.FlatTabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents FlatTabControl1 As AMA.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grpScoresTally As AMA.FlatGroupBox
    Friend WithEvents lstScoresTallyMr As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblEventName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblJudgeName As System.Windows.Forms.Label
    Friend WithEvents FlatMini1 As AMA.FlatMini
    Friend WithEvents FlatClose1 As AMA.FlatClose
    Friend WithEvents FlatTabControl2 As AMA.FlatTabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents lstScoresTallyMs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpPageantSummary As AMA.FlatGroupBox
    Friend WithEvents FlatTabControl3 As AMA.FlatTabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lstTotalMr As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents lblWinnerMrName As System.Windows.Forms.Label
    Friend WithEvents lblWinnerMs As System.Windows.Forms.Label
    Friend WithEvents lblWinnerMr As System.Windows.Forms.Label
    Friend WithEvents lblTotalJudges As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEventName2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWinnerMsName As System.Windows.Forms.Label
    Friend WithEvents lstTotalMs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
End Class
