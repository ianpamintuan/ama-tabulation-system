Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmAwardResults

    Dim EventID, TotalJudges As Integer

    Dim PrintQuery As String
    Dim dbAdapter As New MySqlDataAdapter
    Dim dbDataSet As DataSet

    Private Sub LoadDataSet()

        OpenDBConnection()

        dbAdapter.SelectCommand = dbConn.CreateCommand
        dbAdapter.SelectCommand.CommandText = PrintQuery
        dbAdapter.SelectCommand.ExecuteReader()

        CloseDBConnection()

        dbDataSet = New DataSet("myDS")
        dbAdapter.Fill(dbDataSet, "myDS")

    End Sub

    Public Sub LoadEventsOptions()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_id, event_name FROM tblevents WHERE is_pageant = 1 ORDER BY event_name ASC"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    cboEvents.Items.Add(dbReader.Item("event_id").ToString & " " & dbReader.Item("event_name").ToString)

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub CountJudgesSheet()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT COUNT(DISTINCT(judge_id)) AS total_judges FROM tblscores WHERE event_id = " & EventID
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    TotalJudges = dbReader.Item("total_judges").ToString()

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in counting judges." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub LoadCategories()

        Dim index As Integer = 0

        With lbCategories

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = "SELECT * FROM tblcriteria_categories"
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("criteria_category_id").ToString & " " & dbReader.Item("criteria_category_name").ToString)

                        index += 1

                    End While

                End If

                dbReader.Close()

                Application.UseWaitCursor = False

            Catch ex As Exception

                Application.UseWaitCursor = False

                CheckIfDbReaderIsClosed()

                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

        End With


    End Sub

    Private Sub LoadAwardWinners(CategoryID As Integer)

        OpenDBConnection()
        dbCmd.CommandText = "SELECT tblscores.contestant_id, CONCAT(tblcontestants.first_name, ' ', tblcontestants.last_name) AS full_name,  (SUM(tblscores.score) / 3) AS score FROM tblscores INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id WHERE tblscores.event_id = " & EventID & " AND category_id = " & CategoryID & " AND tblcontestants.title = 'Ms' GROUP BY tblscores.contestant_id ORDER BY score DESC LIMIT 1"
        dbReader = dbCmd.ExecuteReader

        If dbReader.HasRows Then

            dbReader.Read()
            lblFemaleContestant.Text = dbReader.Item("full_name")

        End If

        CheckIfDbReaderIsClosed()

        OpenDBConnection()
        dbCmd.CommandText = "SELECT tblscores.contestant_id, CONCAT(tblcontestants.first_name, ' ', tblcontestants.last_name) AS full_name,  (SUM(tblscores.score) / 3) AS score FROM tblscores INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id WHERE tblscores.event_id = " & EventID & " AND category_id = " & CategoryID & " AND tblcontestants.title = 'Mr' GROUP BY tblscores.contestant_id ORDER BY score DESC LIMIT 1"
        dbReader = dbCmd.ExecuteReader

        If dbReader.HasRows Then

            dbReader.Read()
            lblMaleContestant.Text = dbReader.Item("full_name")

        End If

        CheckIfDbReaderIsClosed()

    End Sub

    Private Sub lbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCategories.SelectedIndexChanged

        Dim temp = lbCategories.Items.Item(lbCategories.SelectedIndex).ToString
        Dim test = temp.Split(New Char() {" "c})
        Dim CategoryID = test(0)
        Dim category = ""
        For i = 0 To test.Length - 1 Step 1
            If i <> 0 Then
                category &= test(i) & " "
            End If
        Next

        lblBestCategory.Text = "Best in " & category

        LoadAwardWinners(CategoryID)

    End Sub

    Private Sub btnPrintAward_Click(sender As Object, e As EventArgs) Handles btnPrintAward.Click

        If cboEvents.SelectedIndex = -1 Then

            MsgBox("Please choose an event.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If lbCategories.SelectedIndex = -1 Then

            MsgBox("Please choose a category.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        PrintQuery = "SELECT * FROM tblevents WHERE event_id = " & EventID

        LoadDataSet()

        Dim param1 As New ReportParameter("ReportParameter1", lblBestCategory.Text)
        Dim param2 As New ReportParameter("ReportParameter2", lblMaleContestant.Text)
        Dim param3 As New ReportParameter("ReportParameter3", lblFemaleContestant.Text)

        With frmAwardReport.ReportViewer1
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dbDataSet.Tables("myDS")))
            .LocalReport.SetParameters(New ReportParameter() {param1})
            .LocalReport.SetParameters(New ReportParameter() {param2})
            .LocalReport.SetParameters(New ReportParameter() {param3})
            .RefreshReport()
        End With

        frmAwardReport.ShowDialog()

    End Sub

    Private Sub frmAwardResults_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadEventsOptions()
        LoadCategories()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmDashboard.Show()
        Me.Close()

    End Sub

    Private Sub cboEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEvents.SelectedIndexChanged

        Dim temp = cboEvents.Text
        Dim test = temp.Split(New Char() {" "c})
        EventID = test(0)

        CountJudgesSheet()

        If TotalJudges < 3 Then

            MsgBox("The judges haven't submitted all of their judge sheet. Please wait for them to finish.", MsgBoxStyle.Critical, "Error")
            lblFemaleContestant.Text = "_____"
            lblMaleContestant.Text = "_____"
            Exit Sub

        End If

    End Sub
End Class