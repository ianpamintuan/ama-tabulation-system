Public Class frmDashboard

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click

        frmUsersRegistration.Show()
        Me.Close()


    End Sub

    Private Sub btnIntramurals_Click(sender As Object, e As EventArgs) Handles btnIntramurals.Click

        frmIntramurals.Show()
        Me.Close()

    End Sub

    Private Sub btnPlayers_Click(sender As Object, e As EventArgs)

        frmPlayers.Show()
        Me.Close()

    End Sub

    Private Sub btnTeams_Click(sender As Object, e As EventArgs) Handles btnTeams.Click

        frmTeams.Show()
        Me.Close()

    End Sub

    Private Sub btnPageant_Click(sender As Object, e As EventArgs) Handles btnPageant.Click

        frmPageant.Show()
        Me.Close()

    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click

        frmEvents.Show()
        Me.Close()

    End Sub

    Private Sub btnMatches_Click(sender As Object, e As EventArgs) Handles btnMatches.Click

        frmMatches.Show()
        Me.Close()

    End Sub

    Private Sub btnPlayers_Click_1(sender As Object, e As EventArgs) Handles btnPlayers.Click

        frmPlayers.Show()
        Me.Close()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        If MsgBox("Do you want to logout of the system?", MsgBoxStyle.YesNo, "Confirmation Message") = MsgBoxResult.Yes Then

            frmLogin.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        txtName.Text = userName
        txtRole.Text = userType
        txtDate.Text = Date.Now

    End Sub

    Private Sub lblAccountSettings_Click(sender As Object, e As EventArgs) Handles lblAccountSettings.Click

        frmMyProfile.ShowDialog()

    End Sub

End Class