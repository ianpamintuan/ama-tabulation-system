Public Class frmPlayersReport

    Private Sub frmPlayersReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        frmMatches.Show()
        Me.Dispose()

    End Sub
End Class