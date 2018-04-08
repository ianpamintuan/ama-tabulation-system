Public Class frmPageantMenu

    Private Sub btnContestants_Click(sender As Object, e As EventArgs) Handles btnContestants.Click

        frmContestants.Show()
        Me.Close()

    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click

        frmCategories.Show()
        Me.Close()

    End Sub

    Private Sub btnCriterias_Click(sender As Object, e As EventArgs) Handles btnCriterias.Click

        frmCriterias.Show()
        Me.Close()

    End Sub
End Class