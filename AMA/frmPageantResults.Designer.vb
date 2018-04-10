<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPageantResults
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
        Me.FormSkin1 = New AMA.FormSkin()
        Me.lblWinnerMsName = New System.Windows.Forms.Label()
        Me.lblWinnerMs = New System.Windows.Forms.Label()
        Me.lblWinnerMrName = New System.Windows.Forms.Label()
        Me.lblWinnerMr = New System.Windows.Forms.Label()
        Me.btnPrint = New AMA.FlatButton()
        Me.btnBack = New AMA.FlatButton()
        Me.grpPageantSummary = New AMA.FlatGroupBox()
        Me.FlatTabControl3 = New AMA.FlatTabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lstTotalMr = New AMA.ffListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.lstTotalMs = New AMA.ffListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpSelection = New AMA.FlatGroupBox()
        Me.cboEvents = New System.Windows.Forms.ComboBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        Me.grpPageantSummary.SuspendLayout()
        Me.FlatTabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.grpSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.lblWinnerMsName)
        Me.FormSkin1.Controls.Add(Me.lblWinnerMs)
        Me.FormSkin1.Controls.Add(Me.lblWinnerMrName)
        Me.FormSkin1.Controls.Add(Me.lblWinnerMr)
        Me.FormSkin1.Controls.Add(Me.btnPrint)
        Me.FormSkin1.Controls.Add(Me.btnBack)
        Me.FormSkin1.Controls.Add(Me.grpPageantSummary)
        Me.FormSkin1.Controls.Add(Me.grpSelection)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(807, 655)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Pageant Results"
        '
        'lblWinnerMsName
        '
        Me.lblWinnerMsName.BackColor = System.Drawing.Color.Transparent
        Me.lblWinnerMsName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerMsName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblWinnerMsName.Location = New System.Drawing.Point(132, 545)
        Me.lblWinnerMsName.Name = "lblWinnerMsName"
        Me.lblWinnerMsName.Size = New System.Drawing.Size(606, 40)
        Me.lblWinnerMsName.TabIndex = 40
        Me.lblWinnerMsName.Text = "Name"
        Me.lblWinnerMsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWinnerMs
        '
        Me.lblWinnerMs.AutoSize = True
        Me.lblWinnerMs.BackColor = System.Drawing.Color.Transparent
        Me.lblWinnerMs.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerMs.ForeColor = System.Drawing.Color.White
        Me.lblWinnerMs.Location = New System.Drawing.Point(3, 553)
        Me.lblWinnerMs.Name = "lblWinnerMs"
        Me.lblWinnerMs.Size = New System.Drawing.Size(123, 25)
        Me.lblWinnerMs.TabIndex = 39
        Me.lblWinnerMs.Text = "Winner(Ms):"
        Me.lblWinnerMs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWinnerMrName
        '
        Me.lblWinnerMrName.BackColor = System.Drawing.Color.Transparent
        Me.lblWinnerMrName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerMrName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblWinnerMrName.Location = New System.Drawing.Point(132, 492)
        Me.lblWinnerMrName.Name = "lblWinnerMrName"
        Me.lblWinnerMrName.Size = New System.Drawing.Size(661, 40)
        Me.lblWinnerMrName.TabIndex = 38
        Me.lblWinnerMrName.Text = "Name"
        Me.lblWinnerMrName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWinnerMr
        '
        Me.lblWinnerMr.AutoSize = True
        Me.lblWinnerMr.BackColor = System.Drawing.Color.Transparent
        Me.lblWinnerMr.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerMr.ForeColor = System.Drawing.Color.White
        Me.lblWinnerMr.Location = New System.Drawing.Point(3, 501)
        Me.lblWinnerMr.Name = "lblWinnerMr"
        Me.lblWinnerMr.Size = New System.Drawing.Size(123, 25)
        Me.lblWinnerMr.TabIndex = 36
        Me.lblWinnerMr.Text = "Winner(Mr):"
        Me.lblWinnerMr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnPrint.Location = New System.Drawing.Point(575, 611)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Rounded = False
        Me.btnPrint.Size = New System.Drawing.Size(106, 32)
        Me.btnPrint.TabIndex = 35
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBack.Location = New System.Drawing.Point(687, 611)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Rounded = False
        Me.btnBack.Size = New System.Drawing.Size(106, 32)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "Back"
        Me.btnBack.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'grpPageantSummary
        '
        Me.grpPageantSummary.BackColor = System.Drawing.Color.Transparent
        Me.grpPageantSummary.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpPageantSummary.Controls.Add(Me.FlatTabControl3)
        Me.grpPageantSummary.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpPageantSummary.Location = New System.Drawing.Point(0, 147)
        Me.grpPageantSummary.Name = "grpPageantSummary"
        Me.grpPageantSummary.ShowText = True
        Me.grpPageantSummary.Size = New System.Drawing.Size(807, 342)
        Me.grpPageantSummary.TabIndex = 27
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
        Me.FlatTabControl3.Size = New System.Drawing.Size(793, 294)
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
        Me.TabPage5.Size = New System.Drawing.Size(785, 246)
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
        Me.lstTotalMr.Size = New System.Drawing.Size(779, 240)
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
        Me.TabPage6.Size = New System.Drawing.Size(785, 246)
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
        Me.lstTotalMs.Size = New System.Drawing.Size(779, 240)
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
        'grpSelection
        '
        Me.grpSelection.BackColor = System.Drawing.Color.Transparent
        Me.grpSelection.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpSelection.Controls.Add(Me.cboEvents)
        Me.grpSelection.Controls.Add(Me.lblFirstName)
        Me.grpSelection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelection.Location = New System.Drawing.Point(0, 46)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.ShowText = True
        Me.grpSelection.Size = New System.Drawing.Size(807, 95)
        Me.grpSelection.TabIndex = 33
        Me.grpSelection.Text = "Event Selection"
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
        'frmPageantResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 655)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPageantResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPageantResults"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.grpPageantSummary.ResumeLayout(False)
        Me.FlatTabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents grpSelection As AMA.FlatGroupBox
    Friend WithEvents cboEvents As System.Windows.Forms.ComboBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents grpPageantSummary As AMA.FlatGroupBox
    Friend WithEvents FlatTabControl3 As AMA.FlatTabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lstTotalMr As AMA.ffListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents lstTotalMs As AMA.ffListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As AMA.FlatButton
    Friend WithEvents btnBack As AMA.FlatButton
    Friend WithEvents lblWinnerMr As System.Windows.Forms.Label
    Friend WithEvents lblWinnerMrName As System.Windows.Forms.Label
    Friend WithEvents lblWinnerMsName As System.Windows.Forms.Label
    Friend WithEvents lblWinnerMs As System.Windows.Forms.Label
End Class
