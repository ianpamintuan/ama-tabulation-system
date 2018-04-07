<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FormSkin1 = New AMA.FormSkin()
        Me.btnCancel = New AMA.FlatButton()
        Me.btnSave = New AMA.FlatButton()
        Me.FlatGroupBox1 = New AMA.FlatGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboRoles = New System.Windows.Forms.ComboBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New AMA.FlatTextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New AMA.FlatTextBox()
        Me.txtUsername = New AMA.FlatTextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtEmail = New AMA.FlatTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtLastName = New AMA.FlatTextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtMiddleName = New AMA.FlatTextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtFirstName = New AMA.FlatTextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.FlatMini1 = New AMA.FlatMini()
        Me.FlatClose1 = New AMA.FlatClose()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
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
        Me.FormSkin1.Controls.Add(Me.btnSave)
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
        Me.FormSkin1.Size = New System.Drawing.Size(571, 651)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Registration"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCancel.Location = New System.Drawing.Point(406, 591)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Rounded = False
        Me.btnCancel.Size = New System.Drawing.Size(153, 48)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(232, 591)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(162, 48)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.Label1)
        Me.FlatGroupBox1.Controls.Add(Me.cboRoles)
        Me.FlatGroupBox1.Controls.Add(Me.lblConfirmPassword)
        Me.FlatGroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.FlatGroupBox1.Controls.Add(Me.lblPassword)
        Me.FlatGroupBox1.Controls.Add(Me.txtPassword)
        Me.FlatGroupBox1.Controls.Add(Me.txtUsername)
        Me.FlatGroupBox1.Controls.Add(Me.lblUsername)
        Me.FlatGroupBox1.Controls.Add(Me.txtEmail)
        Me.FlatGroupBox1.Controls.Add(Me.lblEmail)
        Me.FlatGroupBox1.Controls.Add(Me.txtLastName)
        Me.FlatGroupBox1.Controls.Add(Me.lblLastName)
        Me.FlatGroupBox1.Controls.Add(Me.txtMiddleName)
        Me.FlatGroupBox1.Controls.Add(Me.lblMiddleName)
        Me.FlatGroupBox1.Controls.Add(Me.txtFirstName)
        Me.FlatGroupBox1.Controls.Add(Me.lblFirstName)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatGroupBox1.Location = New System.Drawing.Point(1, 50)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(567, 471)
        Me.FlatGroupBox1.TabIndex = 2
        Me.FlatGroupBox1.Text = "User Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 30)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Role"
        '
        'cboRoles
        '
        Me.cboRoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRoles.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoles.ForeColor = System.Drawing.Color.White
        Me.cboRoles.Items.AddRange(New Object() {"Administrator"})
        Me.cboRoles.Location = New System.Drawing.Point(231, 424)
        Me.cboRoles.Name = "cboRoles"
        Me.cboRoles.Size = New System.Drawing.Size(267, 33)
        Me.cboRoles.TabIndex = 24
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(11, 374)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(180, 30)
        Me.lblConfirmPassword.TabIndex = 33
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(231, 374)
        Me.txtConfirmPassword.MaxLength = 32767
        Me.txtConfirmPassword.Multiline = False
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.ReadOnly = False
        Me.txtConfirmPassword.Size = New System.Drawing.Size(267, 37)
        Me.txtConfirmPassword.TabIndex = 32
        Me.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtConfirmPassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(11, 319)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(100, 30)
        Me.lblPassword.TabIndex = 31
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(231, 319)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.Size = New System.Drawing.Size(267, 37)
        Me.txtPassword.TabIndex = 30
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(231, 264)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.Size = New System.Drawing.Size(267, 37)
        Me.txtUsername.TabIndex = 29
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsername.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(11, 264)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(106, 30)
        Me.lblUsername.TabIndex = 28
        Me.lblUsername.Text = "Username"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(231, 211)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = False
        Me.txtEmail.Size = New System.Drawing.Size(267, 37)
        Me.txtEmail.TabIndex = 27
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEmail.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.UseSystemPasswordChar = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(12, 211)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(63, 30)
        Me.lblEmail.TabIndex = 26
        Me.lblEmail.Text = "Email"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.Transparent
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(231, 158)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Multiline = False
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = False
        Me.txtLastName.Size = New System.Drawing.Size(267, 37)
        Me.txtLastName.TabIndex = 16
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLastName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLastName.UseSystemPasswordChar = False
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(12, 158)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(112, 30)
        Me.lblLastName.TabIndex = 15
        Me.lblLastName.Text = "Last Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(231, 105)
        Me.txtMiddleName.MaxLength = 32767
        Me.txtMiddleName.Multiline = False
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = False
        Me.txtMiddleName.Size = New System.Drawing.Size(267, 37)
        Me.txtMiddleName.TabIndex = 14
        Me.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMiddleName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMiddleName.UseSystemPasswordChar = False
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblMiddleName.Location = New System.Drawing.Point(11, 105)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(139, 30)
        Me.lblMiddleName.TabIndex = 13
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(231, 50)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Multiline = False
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = False
        Me.txtFirstName.Size = New System.Drawing.Size(267, 37)
        Me.txtFirstName.TabIndex = 10
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFirstName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFirstName.UseSystemPasswordChar = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(11, 50)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(113, 30)
        Me.lblFirstName.TabIndex = 9
        Me.lblFirstName.Text = "First Name"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(517, 12)
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
        Me.FlatClose1.Location = New System.Drawing.Point(541, 13)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 651)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistration"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents FlatMini1 As AMA.FlatMini
    Friend WithEvents FlatClose1 As AMA.FlatClose
    Friend WithEvents FlatGroupBox1 As AMA.FlatGroupBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As AMA.FlatTextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As AMA.FlatTextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As AMA.FlatTextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As AMA.FlatTextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As AMA.FlatTextBox
    Friend WithEvents txtPassword As AMA.FlatTextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As AMA.FlatTextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents cboRoles As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As AMA.FlatButton
    Friend WithEvents btnCancel As AMA.FlatButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
