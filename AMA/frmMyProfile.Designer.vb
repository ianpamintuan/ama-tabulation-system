<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyProfile
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
        Me.FormSkin1 = New AMA.FormSkin()
        Me.btnCancel = New AMA.FlatButton()
        Me.btnUpdateInfo = New AMA.FlatButton()
        Me.grpUserInfo = New AMA.FlatGroupBox()
        Me.txtUsername = New AMA.FlatTextBox()
        Me.chkChangePassword = New System.Windows.Forms.CheckBox()
        Me.txtNewPassword = New AMA.FlatTextBox()
        Me.txtPassword = New AMA.FlatTextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New AMA.FlatTextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New AMA.FlatTextBox()
        Me.txtMiddleName = New AMA.FlatTextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtFirstName = New AMA.FlatTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FormSkin1.SuspendLayout()
        Me.grpUserInfo.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btnCancel)
        Me.FormSkin1.Controls.Add(Me.btnUpdateInfo)
        Me.FormSkin1.Controls.Add(Me.grpUserInfo)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(461, 535)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "My Profile"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCancel.Location = New System.Drawing.Point(343, 491)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Rounded = False
        Me.btnCancel.Size = New System.Drawing.Size(106, 32)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnUpdateInfo
        '
        Me.btnUpdateInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateInfo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnUpdateInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnUpdateInfo.Location = New System.Drawing.Point(231, 491)
        Me.btnUpdateInfo.Name = "btnUpdateInfo"
        Me.btnUpdateInfo.Rounded = False
        Me.btnUpdateInfo.Size = New System.Drawing.Size(106, 32)
        Me.btnUpdateInfo.TabIndex = 3
        Me.btnUpdateInfo.Text = "Update"
        Me.btnUpdateInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'grpUserInfo
        '
        Me.grpUserInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpUserInfo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpUserInfo.Controls.Add(Me.txtUsername)
        Me.grpUserInfo.Controls.Add(Me.chkChangePassword)
        Me.grpUserInfo.Controls.Add(Me.txtNewPassword)
        Me.grpUserInfo.Controls.Add(Me.txtPassword)
        Me.grpUserInfo.Controls.Add(Me.lblNewPassword)
        Me.grpUserInfo.Controls.Add(Me.lblEvent)
        Me.grpUserInfo.Controls.Add(Me.Label6)
        Me.grpUserInfo.Controls.Add(Me.lblPassword)
        Me.grpUserInfo.Controls.Add(Me.lblRole)
        Me.grpUserInfo.Controls.Add(Me.Label5)
        Me.grpUserInfo.Controls.Add(Me.lblUsername)
        Me.grpUserInfo.Controls.Add(Me.lblEmail)
        Me.grpUserInfo.Controls.Add(Me.txtEmail)
        Me.grpUserInfo.Controls.Add(Me.lblLastName)
        Me.grpUserInfo.Controls.Add(Me.txtLastName)
        Me.grpUserInfo.Controls.Add(Me.txtMiddleName)
        Me.grpUserInfo.Controls.Add(Me.lblMiddleName)
        Me.grpUserInfo.Controls.Add(Me.txtFirstName)
        Me.grpUserInfo.Controls.Add(Me.Label4)
        Me.grpUserInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserInfo.Location = New System.Drawing.Point(3, 50)
        Me.grpUserInfo.Name = "grpUserInfo"
        Me.grpUserInfo.ShowText = True
        Me.grpUserInfo.Size = New System.Drawing.Size(455, 485)
        Me.grpUserInfo.TabIndex = 3
        Me.grpUserInfo.Text = "User Information"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(141, 283)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.Size = New System.Drawing.Size(267, 33)
        Me.txtUsername.TabIndex = 34
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsername.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'chkChangePassword
        '
        Me.chkChangePassword.AutoSize = True
        Me.chkChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.chkChangePassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChangePassword.ForeColor = System.Drawing.Color.White
        Me.chkChangePassword.Location = New System.Drawing.Point(141, 357)
        Me.chkChangePassword.Name = "chkChangePassword"
        Me.chkChangePassword.Size = New System.Drawing.Size(153, 25)
        Me.chkChangePassword.TabIndex = 33
        Me.chkChangePassword.Text = "Change Password"
        Me.chkChangePassword.UseVisualStyleBackColor = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(141, 389)
        Me.txtNewPassword.MaxLength = 32767
        Me.txtNewPassword.Multiline = False
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.ReadOnly = False
        Me.txtNewPassword.Size = New System.Drawing.Size(267, 30)
        Me.txtNewPassword.TabIndex = 20
        Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNewPassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNewPassword.UseSystemPasswordChar = True
        Me.txtNewPassword.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(141, 322)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.Size = New System.Drawing.Size(267, 30)
        Me.txtPassword.TabIndex = 20
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblNewPassword
        '
        Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblNewPassword.Location = New System.Drawing.Point(11, 384)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(106, 60)
        Me.lblNewPassword.TabIndex = 21
        Me.lblNewPassword.Text = "New Password"
        Me.lblNewPassword.Visible = False
        '
        'lblEvent
        '
        Me.lblEvent.BackColor = System.Drawing.Color.Transparent
        Me.lblEvent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblEvent.Location = New System.Drawing.Point(137, 249)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(272, 30)
        Me.lblEvent.TabIndex = 32
        Me.lblEvent.Text = "Event"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 21)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Event"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(9, 322)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 20)
        Me.lblPassword.TabIndex = 19
        Me.lblPassword.Text = "Password"
        '
        'lblRole
        '
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(138, 209)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(272, 30)
        Me.lblRole.TabIndex = 30
        Me.lblRole.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 21)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Role"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(9, 283)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(83, 20)
        Me.lblUsername.TabIndex = 17
        Me.lblUsername.Text = "Username"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(11, 170)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 21)
        Me.lblEmail.TabIndex = 28
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(142, 170)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = False
        Me.txtEmail.Size = New System.Drawing.Size(267, 33)
        Me.txtEmail.TabIndex = 27
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEmail.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.UseSystemPasswordChar = False
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(11, 131)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(84, 21)
        Me.lblLastName.TabIndex = 16
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.Transparent
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(142, 131)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Multiline = False
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = False
        Me.txtLastName.Size = New System.Drawing.Size(267, 33)
        Me.txtLastName.TabIndex = 15
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLastName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLastName.UseSystemPasswordChar = False
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(142, 92)
        Me.txtMiddleName.MaxLength = 32767
        Me.txtMiddleName.Multiline = False
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = False
        Me.txtMiddleName.Size = New System.Drawing.Size(267, 33)
        Me.txtMiddleName.TabIndex = 14
        Me.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMiddleName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMiddleName.UseSystemPasswordChar = False
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblMiddleName.Location = New System.Drawing.Point(9, 92)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(104, 21)
        Me.lblMiddleName.TabIndex = 13
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(142, 52)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Multiline = False
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = False
        Me.txtFirstName.Size = New System.Drawing.Size(267, 33)
        Me.txtFirstName.TabIndex = 10
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFirstName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFirstName.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "First Name"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMyProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 535)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMyProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMyProfile"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents grpUserInfo As AMA.FlatGroupBox
    Friend WithEvents btnUpdateInfo As AMA.FlatButton
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As AMA.FlatTextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As AMA.FlatTextBox
    Friend WithEvents txtMiddleName As AMA.FlatTextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As AMA.FlatTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As AMA.FlatTextBox
    Friend WithEvents txtPassword As AMA.FlatTextBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents btnCancel As AMA.FlatButton
    Friend WithEvents chkChangePassword As System.Windows.Forms.CheckBox
    Friend WithEvents txtUsername As AMA.FlatTextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
