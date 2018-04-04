<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJudge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJudge))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FormSkin1 = New AMA.FormSkin()
        Me.FlatMini1 = New AMA.FlatMini()
        Me.FlatClose1 = New AMA.FlatClose()
        Me.FlatTabControl1 = New AMA.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnSubmitScores = New AMA.FlatButton()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblJudgeName = New System.Windows.Forms.Label()
        Me.grpSheet = New AMA.FlatGroupBox()
        Me.lbCategories = New System.Windows.Forms.ListBox()
        Me.btnUpdate = New AMA.FlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCriteria = New AMA.FlatGroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nupCriteriaValue4 = New System.Windows.Forms.NumericUpDown()
        Me.nupCriteriaValue3 = New System.Windows.Forms.NumericUpDown()
        Me.nupCriteriaValue2 = New System.Windows.Forms.NumericUpDown()
        Me.nupCriteriaValue1 = New System.Windows.Forms.NumericUpDown()
        Me.lblPercentage4 = New System.Windows.Forms.Label()
        Me.lblPercentage3 = New System.Windows.Forms.Label()
        Me.lblPercentage2 = New System.Windows.Forms.Label()
        Me.lblPercentage1 = New System.Windows.Forms.Label()
        Me.lblCriteria4 = New System.Windows.Forms.Label()
        Me.lblCriteria3 = New System.Windows.Forms.Label()
        Me.lblCriteria2 = New System.Windows.Forms.Label()
        Me.lblCriteria1 = New System.Windows.Forms.Label()
        Me.tabTitle = New AMA.FlatTabControl()
        Me.tabMr = New System.Windows.Forms.TabPage()
        Me.lbMr = New System.Windows.Forms.ListBox()
        Me.tabMs = New System.Windows.Forms.TabPage()
        Me.lbMs = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnChange = New AMA.FlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLogout = New AMA.FlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpSheet.SuspendLayout()
        Me.grpCriteria.SuspendLayout()
        CType(Me.nupCriteriaValue4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupCriteriaValue3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupCriteriaValue2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupCriteriaValue1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTitle.SuspendLayout()
        Me.tabMr.SuspendLayout()
        Me.tabMs.SuspendLayout()
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
        Me.FormSkin1.Size = New System.Drawing.Size(850, 580)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Judge Dashboard"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(796, 13)
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
        Me.FlatClose1.Location = New System.Drawing.Point(820, 13)
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
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 50)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(850, 530)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnSubmitScores)
        Me.TabPage1.Controls.Add(Me.lblEventName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblJudgeName)
        Me.TabPage1.Controls.Add(Me.grpSheet)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(842, 482)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Scores Sheet"
        '
        'btnSubmitScores
        '
        Me.btnSubmitScores.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmitScores.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSubmitScores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmitScores.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSubmitScores.Location = New System.Drawing.Point(715, 414)
        Me.btnSubmitScores.Name = "btnSubmitScores"
        Me.btnSubmitScores.Rounded = False
        Me.btnSubmitScores.Size = New System.Drawing.Size(106, 55)
        Me.btnSubmitScores.TabIndex = 15
        Me.btnSubmitScores.Text = "Submit Scores"
        Me.btnSubmitScores.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblEventName
        '
        Me.lblEventName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblEventName.Location = New System.Drawing.Point(81, 396)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(394, 40)
        Me.lblEventName.TabIndex = 26
        Me.lblEventName.Text = "Event Name"
        Me.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Event:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Judge:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJudgeName
        '
        Me.lblJudgeName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudgeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblJudgeName.Location = New System.Drawing.Point(81, 429)
        Me.lblJudgeName.Name = "lblJudgeName"
        Me.lblJudgeName.Size = New System.Drawing.Size(394, 40)
        Me.lblJudgeName.TabIndex = 23
        Me.lblJudgeName.Text = "Judge Name"
        Me.lblJudgeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpSheet
        '
        Me.grpSheet.BackColor = System.Drawing.Color.Transparent
        Me.grpSheet.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpSheet.Controls.Add(Me.lbCategories)
        Me.grpSheet.Controls.Add(Me.btnUpdate)
        Me.grpSheet.Controls.Add(Me.Label1)
        Me.grpSheet.Controls.Add(Me.grpCriteria)
        Me.grpSheet.Controls.Add(Me.tabTitle)
        Me.grpSheet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSheet.Location = New System.Drawing.Point(2, 0)
        Me.grpSheet.Name = "grpSheet"
        Me.grpSheet.ShowText = True
        Me.grpSheet.Size = New System.Drawing.Size(839, 371)
        Me.grpSheet.TabIndex = 0
        Me.grpSheet.Text = "Judge Sheet"
        '
        'lbCategories
        '
        Me.lbCategories.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategories.FormattingEnabled = True
        Me.lbCategories.ItemHeight = 17
        Me.lbCategories.Location = New System.Drawing.Point(12, 80)
        Me.lbCategories.Name = "lbCategories"
        Me.lbCategories.Size = New System.Drawing.Size(205, 242)
        Me.lbCategories.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(713, 290)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Rounded = False
        Me.btnUpdate.Size = New System.Drawing.Size(106, 32)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Categories"
        '
        'grpCriteria
        '
        Me.grpCriteria.BackColor = System.Drawing.Color.Transparent
        Me.grpCriteria.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpCriteria.Controls.Add(Me.lblTotal)
        Me.grpCriteria.Controls.Add(Me.Label2)
        Me.grpCriteria.Controls.Add(Me.nupCriteriaValue4)
        Me.grpCriteria.Controls.Add(Me.nupCriteriaValue3)
        Me.grpCriteria.Controls.Add(Me.nupCriteriaValue2)
        Me.grpCriteria.Controls.Add(Me.nupCriteriaValue1)
        Me.grpCriteria.Controls.Add(Me.lblPercentage4)
        Me.grpCriteria.Controls.Add(Me.lblPercentage3)
        Me.grpCriteria.Controls.Add(Me.lblPercentage2)
        Me.grpCriteria.Controls.Add(Me.lblPercentage1)
        Me.grpCriteria.Controls.Add(Me.lblCriteria4)
        Me.grpCriteria.Controls.Add(Me.lblCriteria3)
        Me.grpCriteria.Controls.Add(Me.lblCriteria2)
        Me.grpCriteria.Controls.Add(Me.lblCriteria1)
        Me.grpCriteria.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpCriteria.Location = New System.Drawing.Point(483, 50)
        Me.grpCriteria.Name = "grpCriteria"
        Me.grpCriteria.ShowText = True
        Me.grpCriteria.Size = New System.Drawing.Size(351, 230)
        Me.grpCriteria.TabIndex = 2
        Me.grpCriteria.Text = "Criteria"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(261, 190)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 40)
        Me.lblTotal.TabIndex = 22
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Total"
        '
        'nupCriteriaValue4
        '
        Me.nupCriteriaValue4.Location = New System.Drawing.Point(261, 157)
        Me.nupCriteriaValue4.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nupCriteriaValue4.Name = "nupCriteriaValue4"
        Me.nupCriteriaValue4.Size = New System.Drawing.Size(75, 25)
        Me.nupCriteriaValue4.TabIndex = 19
        Me.nupCriteriaValue4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nupCriteriaValue3
        '
        Me.nupCriteriaValue3.Location = New System.Drawing.Point(261, 122)
        Me.nupCriteriaValue3.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nupCriteriaValue3.Name = "nupCriteriaValue3"
        Me.nupCriteriaValue3.Size = New System.Drawing.Size(75, 25)
        Me.nupCriteriaValue3.TabIndex = 18
        Me.nupCriteriaValue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nupCriteriaValue2
        '
        Me.nupCriteriaValue2.Location = New System.Drawing.Point(261, 85)
        Me.nupCriteriaValue2.Maximum = New Decimal(New Integer() {35, 0, 0, 0})
        Me.nupCriteriaValue2.Name = "nupCriteriaValue2"
        Me.nupCriteriaValue2.Size = New System.Drawing.Size(75, 25)
        Me.nupCriteriaValue2.TabIndex = 17
        Me.nupCriteriaValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nupCriteriaValue1
        '
        Me.nupCriteriaValue1.Location = New System.Drawing.Point(261, 48)
        Me.nupCriteriaValue1.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nupCriteriaValue1.Name = "nupCriteriaValue1"
        Me.nupCriteriaValue1.Size = New System.Drawing.Size(75, 25)
        Me.nupCriteriaValue1.TabIndex = 16
        Me.nupCriteriaValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPercentage4
        '
        Me.lblPercentage4.AutoSize = True
        Me.lblPercentage4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage4.ForeColor = System.Drawing.Color.White
        Me.lblPercentage4.Location = New System.Drawing.Point(192, 156)
        Me.lblPercentage4.Name = "lblPercentage4"
        Me.lblPercentage4.Size = New System.Drawing.Size(41, 21)
        Me.lblPercentage4.TabIndex = 11
        Me.lblPercentage4.Text = "10%"
        '
        'lblPercentage3
        '
        Me.lblPercentage3.AutoSize = True
        Me.lblPercentage3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage3.ForeColor = System.Drawing.Color.White
        Me.lblPercentage3.Location = New System.Drawing.Point(192, 121)
        Me.lblPercentage3.Name = "lblPercentage3"
        Me.lblPercentage3.Size = New System.Drawing.Size(41, 21)
        Me.lblPercentage3.TabIndex = 10
        Me.lblPercentage3.Text = "30%"
        '
        'lblPercentage2
        '
        Me.lblPercentage2.AutoSize = True
        Me.lblPercentage2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage2.ForeColor = System.Drawing.Color.White
        Me.lblPercentage2.Location = New System.Drawing.Point(192, 84)
        Me.lblPercentage2.Name = "lblPercentage2"
        Me.lblPercentage2.Size = New System.Drawing.Size(41, 21)
        Me.lblPercentage2.TabIndex = 9
        Me.lblPercentage2.Text = "35%"
        '
        'lblPercentage1
        '
        Me.lblPercentage1.AutoSize = True
        Me.lblPercentage1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage1.ForeColor = System.Drawing.Color.White
        Me.lblPercentage1.Location = New System.Drawing.Point(192, 47)
        Me.lblPercentage1.Name = "lblPercentage1"
        Me.lblPercentage1.Size = New System.Drawing.Size(41, 21)
        Me.lblPercentage1.TabIndex = 8
        Me.lblPercentage1.Text = "25%"
        '
        'lblCriteria4
        '
        Me.lblCriteria4.AutoSize = True
        Me.lblCriteria4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteria4.ForeColor = System.Drawing.Color.White
        Me.lblCriteria4.Location = New System.Drawing.Point(18, 156)
        Me.lblCriteria4.Name = "lblCriteria4"
        Me.lblCriteria4.Size = New System.Drawing.Size(125, 21)
        Me.lblCriteria4.TabIndex = 3
        Me.lblCriteria4.Text = "Audience Impact"
        '
        'lblCriteria3
        '
        Me.lblCriteria3.AutoSize = True
        Me.lblCriteria3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteria3.ForeColor = System.Drawing.Color.White
        Me.lblCriteria3.Location = New System.Drawing.Point(18, 121)
        Me.lblCriteria3.Name = "lblCriteria3"
        Me.lblCriteria3.Size = New System.Drawing.Size(134, 21)
        Me.lblCriteria3.TabIndex = 2
        Me.lblCriteria3.Text = "Poise and Bearing"
        '
        'lblCriteria2
        '
        Me.lblCriteria2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteria2.ForeColor = System.Drawing.Color.White
        Me.lblCriteria2.Location = New System.Drawing.Point(18, 68)
        Me.lblCriteria2.Name = "lblCriteria2"
        Me.lblCriteria2.Size = New System.Drawing.Size(168, 53)
        Me.lblCriteria2.TabIndex = 1
        Me.lblCriteria2.Text = "Uniqueness/Creativity/Style of Attire"
        Me.lblCriteria2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriteria1
        '
        Me.lblCriteria1.AutoSize = True
        Me.lblCriteria1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteria1.ForeColor = System.Drawing.Color.White
        Me.lblCriteria1.Location = New System.Drawing.Point(18, 47)
        Me.lblCriteria1.Name = "lblCriteria1"
        Me.lblCriteria1.Size = New System.Drawing.Size(87, 21)
        Me.lblCriteria1.TabIndex = 0
        Me.lblCriteria1.Text = "Personality"
        '
        'tabTitle
        '
        Me.tabTitle.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tabTitle.Controls.Add(Me.tabMr)
        Me.tabTitle.Controls.Add(Me.tabMs)
        Me.tabTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabTitle.ItemSize = New System.Drawing.Size(120, 40)
        Me.tabTitle.Location = New System.Drawing.Point(234, 33)
        Me.tabTitle.Name = "tabTitle"
        Me.tabTitle.SelectedIndex = 0
        Me.tabTitle.Size = New System.Drawing.Size(243, 289)
        Me.tabTitle.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabTitle.TabIndex = 1
        '
        'tabMr
        '
        Me.tabMr.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabMr.Controls.Add(Me.lbMr)
        Me.tabMr.Location = New System.Drawing.Point(4, 44)
        Me.tabMr.Name = "tabMr"
        Me.tabMr.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMr.Size = New System.Drawing.Size(235, 241)
        Me.tabMr.TabIndex = 0
        Me.tabMr.Text = "Mr"
        '
        'lbMr
        '
        Me.lbMr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMr.FormattingEnabled = True
        Me.lbMr.ItemHeight = 17
        Me.lbMr.Location = New System.Drawing.Point(3, 3)
        Me.lbMr.Name = "lbMr"
        Me.lbMr.Size = New System.Drawing.Size(229, 235)
        Me.lbMr.TabIndex = 0
        '
        'tabMs
        '
        Me.tabMs.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabMs.Controls.Add(Me.lbMs)
        Me.tabMs.Location = New System.Drawing.Point(4, 44)
        Me.tabMs.Name = "tabMs"
        Me.tabMs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMs.Size = New System.Drawing.Size(235, 241)
        Me.tabMs.TabIndex = 1
        Me.tabMs.Text = "Ms"
        '
        'lbMs
        '
        Me.lbMs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMs.FormattingEnabled = True
        Me.lbMs.ItemHeight = 17
        Me.lbMs.Location = New System.Drawing.Point(3, 3)
        Me.lbMs.Name = "lbMs"
        Me.lbMs.Size = New System.Drawing.Size(229, 235)
        Me.lbMs.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.btnChange)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.btnLogout)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(842, 482)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Option"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 30)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Logout"
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.Transparent
        Me.btnChange.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnChange.Location = New System.Drawing.Point(243, 31)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Rounded = False
        Me.btnChange.Size = New System.Drawing.Size(106, 32)
        Me.btnChange.TabIndex = 18
        Me.btnChange.Text = "Change"
        Me.btnChange.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(23, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 30)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Account Settings"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnLogout.Location = New System.Drawing.Point(243, 83)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Rounded = False
        Me.btnLogout.Size = New System.Drawing.Size(106, 34)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'frmJudge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 580)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmJudge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJudge"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpSheet.ResumeLayout(False)
        Me.grpSheet.PerformLayout()
        Me.grpCriteria.ResumeLayout(False)
        Me.grpCriteria.PerformLayout()
        CType(Me.nupCriteriaValue4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupCriteriaValue3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupCriteriaValue2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupCriteriaValue1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTitle.ResumeLayout(False)
        Me.tabMr.ResumeLayout(False)
        Me.tabMs.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents FlatTabControl1 As AMA.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grpSheet As AMA.FlatGroupBox
    Friend WithEvents tabTitle As AMA.FlatTabControl
    Friend WithEvents tabMr As System.Windows.Forms.TabPage
    Friend WithEvents grpCriteria As AMA.FlatGroupBox
    Friend WithEvents lblCriteria4 As System.Windows.Forms.Label
    Friend WithEvents lblCriteria3 As System.Windows.Forms.Label
    Friend WithEvents lblCriteria2 As System.Windows.Forms.Label
    Friend WithEvents lblCriteria1 As System.Windows.Forms.Label
    Friend WithEvents lblPercentage4 As System.Windows.Forms.Label
    Friend WithEvents lblPercentage3 As System.Windows.Forms.Label
    Friend WithEvents lblPercentage2 As System.Windows.Forms.Label
    Friend WithEvents lblPercentage1 As System.Windows.Forms.Label
    Friend WithEvents FlatMini1 As AMA.FlatMini
    Friend WithEvents FlatClose1 As AMA.FlatClose
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnUpdate As AMA.FlatButton
    Friend WithEvents lbCategories As System.Windows.Forms.ListBox
    Friend WithEvents nupCriteriaValue1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupCriteriaValue2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupCriteriaValue4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupCriteriaValue3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbMr As System.Windows.Forms.ListBox
    Friend WithEvents lbMs As System.Windows.Forms.ListBox
    Friend WithEvents tabMs As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblJudgeName As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblEventName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScores As AMA.FlatButton
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnChange As AMA.FlatButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As AMA.FlatButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
