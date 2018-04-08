Public Class frmPageantReport

    Private Sub frmPageantForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        frmJudgeTally.Show()
        Me.Dispose()

    End Sub
End Class