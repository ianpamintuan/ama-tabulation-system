<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPageantMenu
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
        Me.btnPageantResults = New AMA.FlatButton()
        Me.btnCriterias = New AMA.FlatButton()
        Me.btnCategories = New AMA.FlatButton()
        Me.btnContestants = New AMA.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btnPageantResults)
        Me.FormSkin1.Controls.Add(Me.btnCriterias)
        Me.FormSkin1.Controls.Add(Me.btnCategories)
        Me.FormSkin1.Controls.Add(Me.btnContestants)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(433, 438)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Pageant Menu"
        '
        'btnPageantResults
        '
        Me.btnPageantResults.BackColor = System.Drawing.Color.Transparent
        Me.btnPageantResults.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnPageantResults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPageantResults.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnPageantResults.Location = New System.Drawing.Point(56, 329)
        Me.btnPageantResults.Name = "btnPageantResults"
        Me.btnPageantResults.Rounded = False
        Me.btnPageantResults.Size = New System.Drawing.Size(317, 64)
        Me.btnPageantResults.TabIndex = 3
        Me.btnPageantResults.Text = "Pageant Results"
        Me.btnPageantResults.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnCriterias
        '
        Me.btnCriterias.BackColor = System.Drawing.Color.Transparent
        Me.btnCriterias.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCriterias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCriterias.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCriterias.Location = New System.Drawing.Point(56, 248)
        Me.btnCriterias.Name = "btnCriterias"
        Me.btnCriterias.Rounded = False
        Me.btnCriterias.Size = New System.Drawing.Size(317, 64)
        Me.btnCriterias.TabIndex = 2
        Me.btnCriterias.Text = "Pageant Criterias"
        Me.btnCriterias.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnCategories
        '
        Me.btnCategories.BackColor = System.Drawing.Color.Transparent
        Me.btnCategories.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategories.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCategories.Location = New System.Drawing.Point(56, 167)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Rounded = False
        Me.btnCategories.Size = New System.Drawing.Size(317, 64)
        Me.btnCategories.TabIndex = 1
        Me.btnCategories.Text = "Pageant Categories"
        Me.btnCategories.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnContestants
        '
        Me.btnContestants.BackColor = System.Drawing.Color.Transparent
        Me.btnContestants.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnContestants.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContestants.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnContestants.Location = New System.Drawing.Point(56, 87)
        Me.btnContestants.Name = "btnContestants"
        Me.btnContestants.Rounded = False
        Me.btnContestants.Size = New System.Drawing.Size(317, 64)
        Me.btnContestants.TabIndex = 0
        Me.btnContestants.Text = "Contestants"
        Me.btnContestants.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmPageantMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 438)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPageantMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPageantMenu"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As AMA.FormSkin
    Friend WithEvents btnCriterias As AMA.FlatButton
    Friend WithEvents btnCategories As AMA.FlatButton
    Friend WithEvents btnContestants As AMA.FlatButton
    Friend WithEvents btnPageantResults As AMA.FlatButton
End Class
