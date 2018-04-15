<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAwardResults
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
        Me.grpSelection = New AMA.FlatGroupBox()
        Me.cboEvents = New System.Windows.Forms.ComboBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnBack = New AMA.FlatButton()
        Me.btnPrintAward = New AMA.FlatButton()
        Me.lblFemaleContestant = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMaleContestant = New System.Windows.Forms.Label()
        Me.lblBestCategory = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FlatGroupBox1 = New AMA.FlatGroupBox()
        Me.lbCategories = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        Me.grpSelection.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.grpSelection)
        Me.FormSkin1.Controls.Add(Me.btnBack)
        Me.FormSkin1.Controls.Add(Me.btnPrintAward)
        Me.FormSkin1.Controls.Add(Me.lblFemaleContestant)
        Me.FormSkin1.Controls.Add(Me.Label12)
        Me.FormSkin1.Controls.Add(Me.lblMaleContestant)
        Me.FormSkin1.Controls.Add(Me.lblBestCategory)
        Me.FormSkin1.Controls.Add(Me.Label8)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.Label7)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(826, 514)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Award Results"
        '
        'grpSelection
        '
        Me.grpSelection.BackColor = System.Drawing.Color.Transparent
        Me.grpSelection.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.grpSelection.Controls.Add(Me.cboEvents)
        Me.grpSelection.Controls.Add(Me.lblFirstName)
        Me.grpSelection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelection.Location = New System.Drawing.Point(0, 103)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.ShowText = True
        Me.grpSelection.Size = New System.Drawing.Size(807, 95)
        Me.grpSelection.TabIndex = 34
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
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBack.Location = New System.Drawing.Point(708, 470)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Rounded = False
        Me.btnBack.Size = New System.Drawing.Size(106, 32)
        Me.btnBack.TabIndex = 42
        Me.btnBack.Text = "Back"
        Me.btnBack.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnPrintAward
        '
        Me.btnPrintAward.BackColor = System.Drawing.Color.Transparent
        Me.btnPrintAward.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnPrintAward.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintAward.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnPrintAward.Location = New System.Drawing.Point(596, 470)
        Me.btnPrintAward.Name = "btnPrintAward"
        Me.btnPrintAward.Rounded = False
        Me.btnPrintAward.Size = New System.Drawing.Size(106, 32)
        Me.btnPrintAward.TabIndex = 41
        Me.btnPrintAward.Text = "Print"
        Me.btnPrintAward.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblFemaleContestant
        '
        Me.lblFemaleContestant.BackColor = System.Drawing.Color.Transparent
        Me.lblFemaleContestant.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemaleContestant.ForeColor = System.Drawing.Color.White
        Me.lblFemaleContestant.Location = New System.Drawing.Point(292, 388)
        Me.lblFemaleContestant.Name = "lblFemaleContestant"
        Me.lblFemaleContestant.Size = New System.Drawing.Size(499, 30)
        Me.lblFemaleContestant.TabIndex = 12
        Me.lblFemaleContestant.Text = "__________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(292, 358)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 30)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Female"
        '
        'lblMaleContestant
        '
        Me.lblMaleContestant.BackColor = System.Drawing.Color.Transparent
        Me.lblMaleContestant.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaleContestant.ForeColor = System.Drawing.Color.White
        Me.lblMaleContestant.Location = New System.Drawing.Point(292, 301)
        Me.lblMaleContestant.Name = "lblMaleContestant"
        Me.lblMaleContestant.Size = New System.Drawing.Size(499, 30)
        Me.lblMaleContestant.TabIndex = 10
        Me.lblMaleContestant.Text = "__________"
        '
        'lblBestCategory
        '
        Me.lblBestCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblBestCategory.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestCategory.ForeColor = System.Drawing.Color.White
        Me.lblBestCategory.Location = New System.Drawing.Point(292, 241)
        Me.lblBestCategory.Name = "lblBestCategory"
        Me.lblBestCategory.Size = New System.Drawing.Size(499, 30)
        Me.lblBestCategory.TabIndex = 9
        Me.lblBestCategory.Text = "Best in"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(294, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 30)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Male"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.lbCategories)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(19, 204)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(241, 245)
        Me.FlatGroupBox1.TabIndex = 2
        Me.FlatGroupBox1.Text = "Category"
        '
        'lbCategories
        '
        Me.lbCategories.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbCategories.FormattingEnabled = True
        Me.lbCategories.ItemHeight = 17
        Me.lbCategories.Location = New System.Drawing.Point(0, 37)
        Me.lbCategories.Name = "lbCategories"
        Me.lbCategories.Size = New System.Drawing.Size(241, 208)
        Me.lbCategories.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 37)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Awards"
        '
        'frmAwardResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 514)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAwardResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAwardResults"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FlatGroupBox1 As AMA.FlatGroupBox
    Friend WithEvents lbCategories As System.Windows.Forms.ListBox
    Friend WithEvents lblFemaleContestant As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMaleContestant As System.Windows.Forms.Label
    Friend WithEvents lblBestCategory As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBack As AMA.FlatButton
    Friend WithEvents btnPrintAward As AMA.FlatButton
    Friend WithEvents grpSelection As AMA.FlatGroupBox
    Friend WithEvents cboEvents As System.Windows.Forms.ComboBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
End Class
