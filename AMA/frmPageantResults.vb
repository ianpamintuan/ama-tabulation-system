Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmPageantResults

    Dim EventID As Integer = -1
    Dim TotalJudges As Integer = 0

    Dim PrintQuery As String
    Dim dbAdapter As New MySqlDataAdapter
    Dim dbDataSet As DataSet

    Public Sub LoadDataSet()

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

    Public Sub LoadJudgeTally(Query As String, lst As ListView)

        Dim index As Integer = 0

        With lst

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("contestant_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("full_name").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("score").ToString)

                        index += 1

                    End While

                    .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

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

    Public Sub SetWinnerMr()

        Dim name As String = ""
        Dim score As Double = 0
        Dim highest As Double = 0

        For Each item As ListViewItem In Me.lstTotalMr.Items

            score = item.SubItems.Item(2).Text

            If score > highest Then

                highest = score
                name = item.SubItems.Item(1).Text

            End If

        Next

        lblWinnerMrName.Text = name

    End Sub

    Public Sub SetWinnerMs()

        Dim name As String = ""
        Dim score As Double = 0
        Dim highest As Double = 0

        For Each item As ListViewItem In Me.lstTotalMs.Items

            score = item.SubItems.Item(2).Text

            If score > highest Then

                highest = score
                name = item.SubItems.Item(1).Text

            End If

        Next

        lblWinnerMsName.Text = name

    End Sub

    Private Sub frmPageantResults_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadEventsOptions()

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
            Exit Sub

        End If

        LoadJudgeTally("SELECT tblscores.contestant_id, CONCAT(tblcontestants.first_name, ' ', tblcontestants.last_name) AS full_name,  (SUM(tblscores.score) / COUNT(DISTINCT(tblscores.category_id))) / " & TotalJudges & " AS score FROM tblscores INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id WHERE tblscores.event_id = " & EventID & " AND tblcontestants.title = 'Ms' GROUP BY tblscores.contestant_id", lstTotalMs)
        LoadJudgeTally("SELECT tblscores.contestant_id, CONCAT(tblcontestants.first_name, ' ', tblcontestants.last_name) AS full_name,  (SUM(tblscores.score) / COUNT(DISTINCT(tblscores.category_id))) / " & TotalJudges & " AS score FROM tblscores INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id WHERE tblscores.event_id = " & EventID & " AND tblcontestants.title = 'Mr' GROUP BY tblscores.contestant_id", lstTotalMr)
        SetWinnerMr()
        SetWinnerMs()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If cboEvents.SelectedIndex = -1 Then

            MsgBox("Please choose an event!", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        PrintQuery = "SELECT tblscores.contestant_id, CONCAT(tblcontestants.first_name, ' ', tblcontestants.last_name) AS full_name,  (SUM(tblscores.score) / COUNT(DISTINCT(tblscores.category_id))) / " & TotalJudges & " AS score, tblevents.event_name FROM tblscores INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id LEFT JOIN tblevents ON tblevents.event_id = tblscores.event_id WHERE tblscores.event_id = " & EventID & " GROUP BY tblscores.contestant_id, tblcontestants.title"

        LoadDataSet()

        Dim param1 As New ReportParameter("ReportParameter1", lblWinnerMrName.Text)
        Dim param2 As New ReportParameter("ReportParameter2", lblWinnerMsName.Text)

        With frmPageantReport.ReportViewer1
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dbDataSet.Tables("myDS")))
            .LocalReport.SetParameters(New ReportParameter() {param1})
            .LocalReport.SetParameters(New ReportParameter() {param2})
            .RefreshReport()
        End With

        frmPageantReport.ShowDialog()

    End Sub

End Class