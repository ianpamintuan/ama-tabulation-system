<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsersRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsersRegistration))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FormSkin1 = New AMA.FormSkin()
        Me.btnCancel = New AMA.FlatButton()
        Me.btnDelete = New AMA.FlatButton()
        Me.btnSave = New AMA.FlatButton()
        Me.btnAdd = New AMA.FlatButton()
        Me.grpTable = New AMA.FlatGroupBox()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.lstUserAccounts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpInfo = New AMA.FlatGroupBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.cboEvent = New System.Windows.Forms.ComboBox()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtEmail = New AMA.FlatTextBox()
        Me.txtFirstName = New AMA.FlatTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New AMA.FlatTextBox()
        Me.cboRoles = New System.Windows.Forms.ComboBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New AMA.FlatTextBox()
        Me.txtConfirmPassword = New AMA.FlatTextBox()
        Me.txtUsername = New AMA.FlatTextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New AMA.FlatTextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnBack = New AMA.FlatButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.grpTable.SuspendLayout()
        Me.grpInfo.SuspendLayout()
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
        Me.FormSkin1.Controls.Add(Me.btnCancel)
        Me.FormSkin1.Controls.Add(Me.btnDelete)
        Me.FormSkin1.Controls.Add(Me.btnSave)
        Me.FormSkin1.Controls.Add(Me.btnAdd)
        Me.FormSkin1.Controls.Add(Me.grpTable)
        Me.FormSkin1.Controls.Add(Me.grpInfo)
        Me.FormSkin1.Controls.Add(Me.btnBack)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(976, 701)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Account Registration"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCancel.Location = New System.Drawing.Point(516, 641)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Rounded = False
        Me.btnCancel.Size = New System.Drawing.Size(162, 48)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDelete.Location = New System.Drawing.Point(348, 641)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Rounded = False
        Me.btnDelete.Size = New System.Drawing.Size(162, 48)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(180, 641)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(162, 48)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd.Location = New System.Drawing.Point(12, 641)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Rounded = False
        Me.btnAdd.Size = New System.Drawing.Size(162, 48)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'grpTable
        '
        Me.grpTable.BackColor = System.Drawing.Color.Transparent
        Me.grpTable.BaseColor = System.Drawing.Color.White
        Me.grpTable.Controls.Add(Me.chkShow)
        Me.grpTable.Controls.Add(Me.lstUserAccounts)
        Me.grpTable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTable.Location = New System.Drawing.Point(3, 386)
        Me.grpTable.Name = "grpTable"
        Me.grpTable.ShowText = True
        Me.grpTable.Size = New System.Drawing.Size(970, 249)
        Me.grpTable.TabIndex = 28
        Me.grpTable.Text = "User Accounts"
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(14, 212)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(166, 25)
        Me.chkShow.TabIndex = 2
        Me.chkShow.Text = "Show Checkboxes"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'lstUserAccounts
        '
        Me.lstUserAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lstUserAccounts.FullRowSelect = True
        Me.lstUserAccounts.GridLines = True
        Me.lstUserAccounts.Location = New System.Drawing.Point(14, 40)
        Me.lstUserAccounts.MultiSelect = False
        Me.lstUserAccounts.Name = "lstUserAccounts"
        Me.lstUserAccounts.Size = New System.Drawing.Size(939, 166)
        Me.lstUserAccounts.TabIndex = 0
        Me.lstUserAccounts.UseCompatibleStateImageBehavior = False
        Me.lstUserAccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Middle Name"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Last Name"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Email"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Role"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Event ID"
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpInfo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpInfo.Controls.Add(Me.chkShowPassword)
        Me.grpInfo.Controls.Add(Me.cboEvent)
        Me.grpInfo.Controls.Add(Me.lblEvent)
        Me.grpInfo.Controls.Add(Me.lblFirstName)
        Me.grpInfo.Controls.Add(Me.txtEmail)
        Me.grpInfo.Controls.Add(Me.txtFirstName)
        Me.grpInfo.Controls.Add(Me.lblEmail)
        Me.grpInfo.Controls.Add(Me.lblLastName)
        Me.grpInfo.Controls.Add(Me.txtLastName)
        Me.grpInfo.Controls.Add(Me.cboRoles)
        Me.grpInfo.Controls.Add(Me.lblMiddleName)
        Me.grpInfo.Controls.Add(Me.Label1)
        Me.grpInfo.Controls.Add(Me.txtMiddleName)
        Me.grpInfo.Controls.Add(Me.txtConfirmPassword)
        Me.grpInfo.Controls.Add(Me.txtUsername)
        Me.grpInfo.Controls.Add(Me.lblConfirmPassword)
        Me.grpInfo.Controls.Add(Me.lblUsername)
        Me.grpInfo.Controls.Add(Me.txtPassword)
        Me.grpInfo.Controls.Add(Me.lblPassword)
        Me.grpInfo.Enabled = False
        Me.grpInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(3, 50)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.ShowText = True
        Me.grpInfo.Size = New System.Drawing.Size(970, 330)
        Me.grpInfo.TabIndex = 27
        Me.grpInfo.Text = "User Information"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.Color.White
        Me.chkShowPassword.Location = New System.Drawing.Point(672, 144)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(139, 25)
        Me.chkShowPassword.TabIndex = 29
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'cboEvent
        '
        Me.cboEvent.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEvent.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEvent.ForeColor = System.Drawing.Color.White
        Me.cboEvent.Location = New System.Drawing.Point(672, 279)
        Me.cboEvent.Name = "cboEvent"
        Me.cboEvent.Size = New System.Drawing.Size(267, 33)
        Me.cboEvent.TabIndex = 28
        Me.cboEvent.Visible = False
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.BackColor = System.Drawing.Color.Transparent
        Me.lblEvent.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblEvent.Location = New System.Drawing.Point(464, 278)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(64, 30)
        Me.lblEvent.TabIndex = 27
        Me.lblEvent.Text = "Event"
        Me.lblEvent.Visible = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(9, 48)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(113, 30)
        Me.lblFirstName.TabIndex = 8
        Me.lblFirstName.Text = "First Name"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(172, 207)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = False
        Me.txtEmail.Size = New System.Drawing.Size(267, 37)
        Me.txtEmail.TabIndex = 26
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEmail.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.UseSystemPasswordChar = False
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(172, 45)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Multiline = False
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = False
        Me.txtFirstName.Size = New System.Drawing.Size(267, 37)
        Me.txtFirstName.TabIndex = 9
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFirstName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFirstName.UseSystemPasswordChar = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(9, 207)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(63, 30)
        Me.lblEmail.TabIndex = 25
        Me.lblEmail.Text = "Email"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(9, 153)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(112, 30)
        Me.lblLastName.TabIndex = 10
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.Transparent
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(172, 153)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Multiline = False
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = False
        Me.txtLastName.Size = New System.Drawing.Size(267, 37)
        Me.txtLastName.TabIndex = 11
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLastName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLastName.UseSystemPasswordChar = False
        '
        'cboRoles
        '
        Me.cboRoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRoles.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoles.ForeColor = System.Drawing.Color.White
        Me.cboRoles.Items.AddRange(New Object() {"Administrator", "Scorer", "Judge"})
        Me.cboRoles.Location = New System.Drawing.Point(672, 230)
        Me.cboRoles.Name = "cboRoles"
        Me.cboRoles.Size = New System.Drawing.Size(267, 33)
        Me.cboRoles.TabIndex = 23
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblMiddleName.Location = New System.Drawing.Point(9, 99)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(139, 30)
        Me.lblMiddleName.TabIndex = 12
        Me.lblMiddleName.Text = "Middle Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(464, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 30)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Role"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(172, 99)
        Me.txtMiddleName.MaxLength = 32767
        Me.txtMiddleName.Multiline = False
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = False
        Me.txtMiddleName.Size = New System.Drawing.Size(267, 37)
        Me.txtMiddleName.TabIndex = 13
        Me.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMiddleName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMiddleName.UseSystemPasswordChar = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(672, 178)
        Me.txtConfirmPassword.MaxLength = 32767
        Me.txtConfirmPassword.Multiline = False
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.ReadOnly = False
        Me.txtConfirmPassword.Size = New System.Drawing.Size(267, 37)
        Me.txtConfirmPassword.TabIndex = 19
        Me.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtConfirmPassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(672, 48)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.Size = New System.Drawing.Size(267, 37)
        Me.txtUsername.TabIndex = 14
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsername.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(464, 178)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(180, 30)
        Me.lblConfirmPassword.TabIndex = 18
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(464, 48)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(106, 30)
        Me.lblUsername.TabIndex = 16
        Me.lblUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(672, 101)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.Size = New System.Drawing.Size(267, 37)
        Me.txtPassword.TabIndex = 15
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(464, 101)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(100, 30)
        Me.lblPassword.TabIndex = 17
        Me.lblPassword.Text = "Password"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBack.Location = New System.Drawing.Point(802, 641)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Rounded = False
        Me.btnBack.Size = New System.Drawing.Size(162, 48)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "Back"
        Me.btnBack.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmUsersRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 701)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsersRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistration"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.grpTable.ResumeLayout(False)
        Me.grpTable.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As AMA.FlatTextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As AMA.FlatTextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As AMA.FlatTextBox
    Friend WithEvents txtUsername As AMA.FlatTextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As AMA.FlatTextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As AMA.FlatTextBox
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents cboRoles As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As AMA.FlatButton
    Friend WithEvents txtEmail As AMA.FlatTextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents grpInfo As AMA.FlatGroupBox
    Friend WithEvents grpTable As AMA.FlatGroupBox
    Friend WithEvents btnCancel As AMA.FlatButton
    Friend WithEvents btnDelete As AMA.FlatButton
    Friend WithEvents btnSave As AMA.FlatButton
    Friend WithEvents btnAdd As AMA.FlatButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lstUserAccounts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents cboEvent As System.Windows.Forms.ComboBox
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
End Class
