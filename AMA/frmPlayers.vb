Public Class frmPlayers

    Dim flag1, flag2, flag3, flag4 As Boolean
    Dim index As Integer
    Dim tempPlayerID As Integer
    Dim ConfirmationMessage As String = ""
    Dim FullName As String = ""

    Private Sub InitializeFlags()

        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True

    End Sub

    Private Sub PerformCancel()

        saveMode = ""

        grpTable.Enabled = True
        grpInfo.Enabled = False
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboTeam.SelectedIndex = -1
        cboSports.SelectedIndex = -1
        chkShow.Checked = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = False
        btnBack.Enabled = True

        ErrorProvider1.SetError(txtFirstName, "")
        ErrorProvider1.SetError(txtLastName, "")
        ErrorProvider1.SetError(cboTeam, "")
        ErrorProvider1.SetError(cboSports, "")

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmDashboard.Show()
        Me.Close()

    End Sub

End Class