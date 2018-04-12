<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTeams))
        Me.FormSkin1 = New AMA.FormSkin()
        Me.btnCancel = New AMA.FlatButton()
        Me.grpTable = New AMA.FlatGroupBox()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.lstTeams = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New AMA.FlatButton()
        Me.btnSave = New AMA.FlatButton()
        Me.grpInfo = New AMA.FlatGroupBox()
        Me.cboSports = New System.Windows.Forms.ComboBox()
        Me.lblSport = New System.Windows.Forms.Label()
        Me.txtTeamName = New AMA.FlatTextBox()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.btnAdd = New AMA.FlatButton()
        Me.btnBack = New AMA.FlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FormSkin1.SuspendLayout()
        Me.grpTable.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btnCancel)
        Me.FormSkin1.Controls.Add(Me.grpTable)
        Me.FormSkin1.Controls.Add(Me.btnDelete)
        Me.FormSkin1.Controls.Add(Me.btnSave)
        Me.FormSkin1.Controls.Add(Me.grpInfo)
        Me.FormSkin1.Controls.Add(Me.btnAdd)
        Me.FormSkin1.Controls.Add(Me.btnBack)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(790, 600)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Teams"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCancel.Location = New System.Drawing.Point(439, 540)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Rounded = False
        Me.btnCancel.Size = New System.Drawing.Size(137, 48)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'grpTable
        '
        Me.grpTable.BackColor = System.Drawing.Color.Transparent
        Me.grpTable.BaseColor = System.Drawing.Color.White
        Me.grpTable.Controls.Add(Me.chkShow)
        Me.grpTable.Controls.Add(Me.lstTeams)
        Me.grpTable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTable.Location = New System.Drawing.Point(0, 266)
        Me.grpTable.Name = "grpTable"
        Me.grpTable.ShowText = True
        Me.grpTable.Size = New System.Drawing.Size(790, 268)
        Me.grpTable.TabIndex = 1
        Me.grpTable.Text = "Team's List"
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(12, 232)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(166, 25)
        Me.chkShow.TabIndex = 3
        Me.chkShow.Text = "Show Checkboxes"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'lstTeams
        '
        Me.lstTeams.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstTeams.FullRowSelect = True
        Me.lstTeams.GridLines = True
        Me.lstTeams.Location = New System.Drawing.Point(12, 41)
        Me.lstTeams.MultiSelect = False
        Me.lstTeams.Name = "lstTeams"
        Me.lstTeams.Size = New System.Drawing.Size(766, 185)
        Me.lstTeams.TabIndex = 0
        Me.lstTeams.UseCompatibleStateImageBehavior = False
        Me.lstTeams.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Team ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Team Name"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sport"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDelete.Location = New System.Drawing.Point(296, 540)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Rounded = False
        Me.btnDelete.Size = New System.Drawing.Size(137, 48)
        Me.btnDelete.TabIndex = 44
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
        Me.btnSave.Location = New System.Drawing.Point(153, 540)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(137, 48)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpInfo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpInfo.Controls.Add(Me.cboSports)
        Me.grpInfo.Controls.Add(Me.lblSport)
        Me.grpInfo.Controls.Add(Me.txtTeamName)
        Me.grpInfo.Controls.Add(Me.lblTeamName)
        Me.grpInfo.Enabled = False
        Me.grpInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(0, 51)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.ShowText = True
        Me.grpInfo.Size = New System.Drawing.Size(790, 209)
        Me.grpInfo.TabIndex = 0
        Me.grpInfo.Text = "Team Information"
        '
        'cboSports
        '
        Me.cboSports.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cboSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSports.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSports.ForeColor = System.Drawing.Color.White
        Me.cboSports.Location = New System.Drawing.Point(175, 105)
        Me.cboSports.Name = "cboSports"
        Me.cboSports.Size = New System.Drawing.Size(267, 33)
        Me.cboSports.TabIndex = 24
        '
        'lblSport
        '
        Me.lblSport.AutoSize = True
        Me.lblSport.BackColor = System.Drawing.Color.Transparent
        Me.lblSport.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblSport.Location = New System.Drawing.Point(12, 104)
        Me.lblSport.Name = "lblSport"
        Me.lblSport.Size = New System.Drawing.Size(62, 30)
        Me.lblSport.TabIndex = 11
        Me.lblSport.Text = "Sport"
        '
        'txtTeamName
        '
        Me.txtTeamName.BackColor = System.Drawing.Color.Transparent
        Me.txtTeamName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamName.Location = New System.Drawing.Point(175, 51)
        Me.txtTeamName.MaxLength = 32767
        Me.txtTeamName.Multiline = False
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.ReadOnly = False
        Me.txtTeamName.Size = New System.Drawing.Size(267, 37)
        Me.txtTeamName.TabIndex = 10
        Me.txtTeamName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTeamName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTeamName.UseSystemPasswordChar = False
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblTeamName.Location = New System.Drawing.Point(12, 51)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(126, 30)
        Me.lblTeamName.TabIndex = 9
        Me.lblTeamName.Text = "Team Name"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd.Location = New System.Drawing.Point(10, 540)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Rounded = False
        Me.btnAdd.Size = New System.Drawing.Size(137, 48)
        Me.btnAdd.TabIndex = 42
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBack.Location = New System.Drawing.Point(616, 540)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Rounded = False
        Me.btnBack.Size = New System.Drawing.Size(162, 48)
        Me.btnBack.TabIndex = 41
        Me.btnBack.Text = "Back"
        Me.btnBack.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmTeams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 600)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTeams"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTeam"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.grpTable.ResumeLayout(False)
        Me.grpTable.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents grpInfo As AMA.FlatGroupBox
    Friend WithEvents lblTeamName As System.Windows.Forms.Label
    Friend WithEvents lblSport As System.Windows.Forms.Label
    Friend WithEvents txtTeamName As AMA.FlatTextBox
    Friend WithEvents grpTable As AMA.FlatGroupBox
    Friend WithEvents lstTeams As System.Windows.Forms.ListView
    Friend WithEvents btnCancel As AMA.FlatButton
    Friend WithEvents btnDelete As AMA.FlatButton
    Friend WithEvents btnSave As AMA.FlatButton
    Friend WithEvents btnAdd As AMA.FlatButton
    Friend WithEvents btnBack As AMA.FlatButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents cboSports As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
