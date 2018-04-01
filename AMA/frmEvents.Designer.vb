<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvents))
        Me.FormSkin1 = New AMA.FormSkin()
        Me.btnCancel = New AMA.FlatButton()
        Me.btnDelete = New AMA.FlatButton()
        Me.btnSave = New AMA.FlatButton()
        Me.btnAdd = New AMA.FlatButton()
        Me.btnBack = New AMA.FlatButton()
        Me.grpTable = New AMA.FlatGroupBox()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.lstEvents = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpInfo = New AMA.FlatGroupBox()
        Me.chkPageant = New System.Windows.Forms.CheckBox()
        Me.lblPageant = New System.Windows.Forms.Label()
        Me.chkCriteria = New System.Windows.Forms.CheckBox()
        Me.lblCriteria = New System.Windows.Forms.Label()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEventDescription = New AMA.FlatTextBox()
        Me.lblEventDesc = New System.Windows.Forms.Label()
        Me.txtEventName = New AMA.FlatTextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
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
        Me.FormSkin1.Controls.Add(Me.btnDelete)
        Me.FormSkin1.Controls.Add(Me.btnSave)
        Me.FormSkin1.Controls.Add(Me.btnAdd)
        Me.FormSkin1.Controls.Add(Me.btnBack)
        Me.FormSkin1.Controls.Add(Me.grpTable)
        Me.FormSkin1.Controls.Add(Me.grpInfo)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(934, 602)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Events"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCancel.Location = New System.Drawing.Point(517, 542)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Rounded = False
        Me.btnCancel.Size = New System.Drawing.Size(162, 48)
        Me.btnCancel.TabIndex = 37
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
        Me.btnDelete.Location = New System.Drawing.Point(349, 542)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Rounded = False
        Me.btnDelete.Size = New System.Drawing.Size(162, 48)
        Me.btnDelete.TabIndex = 36
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
        Me.btnSave.Location = New System.Drawing.Point(181, 542)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(162, 48)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdd.Location = New System.Drawing.Point(13, 542)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Rounded = False
        Me.btnAdd.Size = New System.Drawing.Size(162, 48)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBack.Location = New System.Drawing.Point(760, 542)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Rounded = False
        Me.btnBack.Size = New System.Drawing.Size(162, 48)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "Back"
        Me.btnBack.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'grpTable
        '
        Me.grpTable.BackColor = System.Drawing.Color.Transparent
        Me.grpTable.BaseColor = System.Drawing.Color.White
        Me.grpTable.Controls.Add(Me.chkShow)
        Me.grpTable.Controls.Add(Me.lstEvents)
        Me.grpTable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTable.Location = New System.Drawing.Point(0, 280)
        Me.grpTable.Name = "grpTable"
        Me.grpTable.ShowText = True
        Me.grpTable.Size = New System.Drawing.Size(931, 256)
        Me.grpTable.TabIndex = 1
        Me.grpTable.Text = "Events List"
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(17, 221)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(166, 25)
        Me.chkShow.TabIndex = 4
        Me.chkShow.Text = "Show Checkboxes"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'lstEvents
        '
        Me.lstEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstEvents.FullRowSelect = True
        Me.lstEvents.GridLines = True
        Me.lstEvents.Location = New System.Drawing.Point(17, 43)
        Me.lstEvents.MultiSelect = False
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(889, 176)
        Me.lstEvents.TabIndex = 0
        Me.lstEvents.UseCompatibleStateImageBehavior = False
        Me.lstEvents.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Event ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Event Name"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Event Description"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Event Date"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Has Criteria"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Is Pageant"
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpInfo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpInfo.Controls.Add(Me.chkPageant)
        Me.grpInfo.Controls.Add(Me.lblPageant)
        Me.grpInfo.Controls.Add(Me.chkCriteria)
        Me.grpInfo.Controls.Add(Me.lblCriteria)
        Me.grpInfo.Controls.Add(Me.dtpEventDate)
        Me.grpInfo.Controls.Add(Me.Label1)
        Me.grpInfo.Controls.Add(Me.txtEventDescription)
        Me.grpInfo.Controls.Add(Me.lblEventDesc)
        Me.grpInfo.Controls.Add(Me.txtEventName)
        Me.grpInfo.Controls.Add(Me.lblFirstName)
        Me.grpInfo.Enabled = False
        Me.grpInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(0, 50)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.ShowText = True
        Me.grpInfo.Size = New System.Drawing.Size(906, 224)
        Me.grpInfo.TabIndex = 0
        Me.grpInfo.Text = "Event Information"
        '
        'chkPageant
        '
        Me.chkPageant.AutoSize = True
        Me.chkPageant.Location = New System.Drawing.Point(682, 169)
        Me.chkPageant.Name = "chkPageant"
        Me.chkPageant.Size = New System.Drawing.Size(108, 25)
        Me.chkPageant.TabIndex = 19
        Me.chkPageant.Text = "is pageant"
        Me.chkPageant.UseVisualStyleBackColor = True
        '
        'lblPageant
        '
        Me.lblPageant.AutoSize = True
        Me.lblPageant.BackColor = System.Drawing.Color.Transparent
        Me.lblPageant.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblPageant.Location = New System.Drawing.Point(540, 163)
        Me.lblPageant.Name = "lblPageant"
        Me.lblPageant.Size = New System.Drawing.Size(89, 30)
        Me.lblPageant.TabIndex = 18
        Me.lblPageant.Text = "Pageant"
        '
        'chkCriteria
        '
        Me.chkCriteria.AutoSize = True
        Me.chkCriteria.Location = New System.Drawing.Point(682, 110)
        Me.chkCriteria.Name = "chkCriteria"
        Me.chkCriteria.Size = New System.Drawing.Size(115, 25)
        Me.chkCriteria.TabIndex = 17
        Me.chkCriteria.Text = "Has criteria"
        Me.chkCriteria.UseVisualStyleBackColor = True
        '
        'lblCriteria
        '
        Me.lblCriteria.AutoSize = True
        Me.lblCriteria.BackColor = System.Drawing.Color.Transparent
        Me.lblCriteria.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblCriteria.Location = New System.Drawing.Point(540, 104)
        Me.lblCriteria.Name = "lblCriteria"
        Me.lblCriteria.Size = New System.Drawing.Size(79, 30)
        Me.lblCriteria.TabIndex = 16
        Me.lblCriteria.Text = "Criteria"
        '
        'dtpEventDate
        '
        Me.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEventDate.Location = New System.Drawing.Point(682, 50)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(199, 29)
        Me.dtpEventDate.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(540, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Event Date"
        '
        'txtEventDescription
        '
        Me.txtEventDescription.BackColor = System.Drawing.Color.Transparent
        Me.txtEventDescription.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventDescription.Location = New System.Drawing.Point(233, 104)
        Me.txtEventDescription.MaxLength = 32767
        Me.txtEventDescription.Multiline = True
        Me.txtEventDescription.Name = "txtEventDescription"
        Me.txtEventDescription.ReadOnly = False
        Me.txtEventDescription.Size = New System.Drawing.Size(267, 99)
        Me.txtEventDescription.TabIndex = 13
        Me.txtEventDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEventDescription.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEventDescription.UseSystemPasswordChar = False
        '
        'lblEventDesc
        '
        Me.lblEventDesc.AutoSize = True
        Me.lblEventDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblEventDesc.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblEventDesc.Location = New System.Drawing.Point(12, 104)
        Me.lblEventDesc.Name = "lblEventDesc"
        Me.lblEventDesc.Size = New System.Drawing.Size(175, 30)
        Me.lblEventDesc.TabIndex = 12
        Me.lblEventDesc.Text = "Event Description"
        '
        'txtEventName
        '
        Me.txtEventName.BackColor = System.Drawing.Color.Transparent
        Me.txtEventName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventName.Location = New System.Drawing.Point(233, 49)
        Me.txtEventName.MaxLength = 32767
        Me.txtEventName.Multiline = False
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.ReadOnly = False
        Me.txtEventName.Size = New System.Drawing.Size(267, 37)
        Me.txtEventName.TabIndex = 11
        Me.txtEventName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEventName.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEventName.UseSystemPasswordChar = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(12, 49)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(126, 30)
        Me.lblFirstName.TabIndex = 10
        Me.lblFirstName.Text = "Event Name"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 602)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEvents"
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
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtEventDescription As AMA.FlatTextBox
    Friend WithEvents lblEventDesc As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEventDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEventName As AMA.FlatTextBox
    Friend WithEvents grpTable As AMA.FlatGroupBox
    Friend WithEvents lstEvents As System.Windows.Forms.ListView
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As AMA.FlatButton
    Friend WithEvents btnDelete As AMA.FlatButton
    Friend WithEvents btnSave As AMA.FlatButton
    Friend WithEvents btnAdd As AMA.FlatButton
    Friend WithEvents btnBack As AMA.FlatButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkCriteria As System.Windows.Forms.CheckBox
    Friend WithEvents lblCriteria As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkPageant As System.Windows.Forms.CheckBox
    Friend WithEvents lblPageant As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
