Public Class frmJudgeTally

    Dim EventName As String = ""
    Dim TotalJudges As Integer = 0

    Public Sub LoadEventName()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_name FROM tblevents WHERE is_pageant = 1 AND event_id = " & eventID
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    EventName = dbReader.Item("event_name").ToString()

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub CountJudgesSheet()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT COUNT(DISTINCT(judge_id)) AS total_judges FROM tblscores WHERE event_id = " & eventID
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

    Private Sub frmJudgeTally_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadEventName()
        lblEventName.Text = EventName
        lblEventName2.Text = EventName
        lblJudgeName.Text = userName
        LoadJudgeTally("SELECT tblscores.contestant_id, CONCAT(tblcontestants.first_name, ' ', tblcontestants.last_name) AS full_name,  (SUM(tblscores.score) / 5) AS score FROM tblscores INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id WHERE tblscores.judge_id = " & userID & " AND tblscores.event_id = " & eventID & " AND tblcontestants.title = 'Mr' GROUP BY tblscores.contestant_id", lstScoresTallyMr)
        LoadJudgeTally("SELECT tblscores.contestant_id, CONCAT(tblcontestants.first_name, ' ', tblcontestants.last_name) AS full_name,  (SUM(tblscores.score) / 5) AS score FROM tblscores INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id WHERE tblscores.judge_id = " & userID & " AND tblscores.event_id = " & eventID & " AND tblcontestants.title = 'Ms' GROUP BY tblscores.contestant_id", lstScoresTallyMs)
        CountJudgesSheet()
        lblTotalJudges.Text = TotalJudges

        If TotalJudges < 3 Then

            lblWinnerMr.Visible = False
            lblWinnerMrName.Visible = False
            lblWinnerMs.Visible = False
            lblWinnerMsName.Visible = False

        Else

            lblWinnerMr.Visible = True
            lblWinnerMrName.Visible = True
            lblWinnerMs.Visible = True
            lblWinnerMsName.Visible = True

            LoadJudgeTally("SELECT tblscores.contestant_id, CONCAT(tblcontestants.first_name, ' ', tblcontestants.last_name) AS full_name,  (SUM(tblscores.score) / 5) / " & TotalJudges & " AS score FROM tblscores INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id WHERE tblscores.event_id = " & eventID & " AND tblcontestants.title = 'Ms' GROUP BY tblscores.contestant_id", lstTotalMs)
            LoadJudgeTally("SELECT tblscores.contestant_id, CONCAT(tblcontestants.first_name, ' ', tblcontestants.last_name) AS full_name,  (SUM(tblscores.score) / 5) / " & TotalJudges & " AS score FROM tblscores INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id WHERE tblscores.event_id = " & eventID & " AND tblcontestants.title = 'Mr' GROUP BY tblscores.contestant_id", lstTotalMr)
            SetWinnerMr()
            SetWinnerMs()

        End If

    End Sub
End Class