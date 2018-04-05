Public Class frmScorer

    Dim flag1, flag2 As Boolean
    Dim index, tempEventID, tempMatchID, selectedMatch, TeamAScore, TeamBScore, TeamAFoul, TeamBFoul, tempSportID, tempTeamAID, tempTeamBID As Integer
    Dim selectedEvent As String = ""
    Dim winner As String = ""
    Dim eventFilter As String = ""
    Dim tempTeam As String = ""
    Dim tempSportType As String = ""
    Dim MVP As String = ""
    Dim teamAPlayersStats(,) As Integer
    Dim teamBPlayersStats(,) As Integer

    Public Sub InitializeFlags()

        flag1 = True
        flag2 = True

    End Sub

    Public Sub MatchReset()

        lblTeamA.Text = "Team A"
        lblTeamB.Text = "Team B"
        lblAScore.Text = "0"
        lblBScore.Text = "0"
        lblStatus.Text = "_____"
        lblTeamAFouls.Text = "0"
        lblTeamBFouls.Text = "0"
        lblTeamAPlayerPoints.Text = "0"
        lblTeamBPlayerPoints.Text = "0"

        btnAdd1A.Visible = True
        btnAdd1B.Visible = True
        btnAdd2A.Visible = True
        btnAdd2B.Visible = True
        btnAdd3A.Visible = True
        btnAdd3B.Visible = True

        lblFoulA.Visible = True
        lblTeamAFouls.Visible = True
        btnAddFoulA.Visible = True

        lblFoulB.Visible = True
        lblTeamBFouls.Visible = True
        btnAddFoulB.Visible = True

        grpInfo.Enabled = False
        grpSelection.Enabled = True

        lbTeamAPlayers.Enabled = True
        lbTeamBPlayers.Enabled = True
        lbTeamAPlayers.SelectedIndex = -1
        lbTeamBPlayers.SelectedIndex = -1
        lbTeamAPlayers.Items.Clear()
        lbTeamBPlayers.Items.Clear()

    End Sub

    Public Sub EventsValidation()

        If cboEvents.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboEvents, "Please choose an event.")
            ErrorProvider1.SetIconPadding(cboEvents, 10)
            flag1 = False

        Else

            ErrorProvider1.SetError(cboEvents, "")

        End If

    End Sub

    Public Sub MatchValidation()

        If cboMatches.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboMatches, "Please choose an event.")
            ErrorProvider1.SetIconPadding(cboMatches, 10)
            flag2 = False

        Else

            ErrorProvider1.SetError(cboMatches, "")

        End If

    End Sub

    Public Function PlayerValidation(lbTeam As ListBox)

        If lbTeam.SelectedIndex = -1 Then

            MsgBox("Please choose a player", MsgBoxStyle.Exclamation, "Message")
            Return False

        Else

            Return True

        End If

    End Function

    Public Sub LoadEventsOptions()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_id, event_name FROM tblevents WHERE has_criteria = 0 AND is_pageant = 0 ORDER BY event_name ASC"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    cboEvents.Items.Add(dbReader.Item("event_name").ToString)
                    cboEventsFilter.Items.Add(dbReader.Item("event_name").ToString)

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub LoadMatchesOptions(EventID As Integer)

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT match_id FROM tblmatches WHERE event_id = " & EventID
            dbReader = dbCmd.ExecuteReader

            cboMatches.Items.Clear()

            If dbReader.HasRows = True Then

                While dbReader.Read

                    cboMatches.Items.Add(dbReader.Item("match_id").ToString)

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading matches", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub LoadEvent()

        selectedEvent = cboEvents.Text

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_id FROM tblevents WHERE has_criteria = 0 AND is_pageant = 0 AND event_name = '" & selectedEvent & "'"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                dbReader.Read()

                tempEventID = dbReader.Item("event_id").ToString

            End If

            CheckIfDbReaderIsClosed()

            LoadMatchesOptions(tempEventID)

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub LoadMatch()

        Try

            selectedMatch = cboMatches.Text

            OpenDBConnection()
            dbCmd.CommandText = "SELECT * FROM tblmatches WHERE match_id = " & selectedMatch
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                dbReader.Read()

                tempTeam = dbReader.Item("team_a").ToString

                lblTeamA.Text = dbReader.Item("team_a").ToString
                lblTeamB.Text = dbReader.Item("team_b").ToString
                lblAScore.Text = dbReader.Item("a_score").ToString
                lblBScore.Text = dbReader.Item("b_score").ToString
                lblStatus.Text = dbReader.Item("status").ToString
                lblTeamAFouls.Text = dbReader.Item("a_fouls").ToString
                lblTeamBFouls.Text = dbReader.Item("b_fouls").ToString

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading matches", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub LoadAllMatches(Query As String)

        Dim index As Integer = 0

        With lstMatches

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("match_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("event_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("team_a").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("team_b").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("a_score").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("b_score").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("a_fouls").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("b_fouls").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("winner").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("mvp").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("status").ToString)

                        index += 1

                    End While

                    .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

                End If

                CheckIfDbReaderIsClosed()

                Application.UseWaitCursor = False

            Catch ex As Exception

                Application.UseWaitCursor = False

                CheckIfDbReaderIsClosed()

                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

        End With

    End Sub

    Public Sub LoadPlayers(Query As String, lbName As ListBox, Team As Char)

        Dim index As Integer = 0

        With lbName

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("player_id").ToString & " " & dbReader.Item("full_name").ToString)

                        If Team = "A" Then

                            tempTeamAID = dbReader.Item("team_id").ToString

                        ElseIf Team = "B" Then

                            tempTeamBID = dbReader.Item("team_id").ToString

                        End If

                        index += 1

                    End While

                End If

                CheckIfDbReaderIsClosed()

                Application.UseWaitCursor = False

            Catch ex As Exception

                Application.UseWaitCursor = False

                CheckIfDbReaderIsClosed()

                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

        End With

    End Sub

    Public Sub UpdateTeamScore()

        Dim TotalAScore = 0
        Dim TotalBScore = 0

        For i = 0 To lbTeamAPlayers.Items.Count - 1 Step 1

            TotalAScore += teamAPlayersStats(i, 0)

        Next

        For i = 0 To lbTeamBPlayers.Items.Count - 1 Step 1

            TotalBScore += teamBPlayersStats(i, 0)

        Next

        lblAScore.Text = TotalAScore
        lblBScore.Text = TotalBScore

    End Sub

    Public Sub LoadScores()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT player_id, points, fouls FROM tblplayerscores WHERE team_id = " & tempTeamAID & " AND match_id = " & cboMatches.Text
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                Dim ctr = 0

                While dbReader.Read

                    teamAPlayersStats(ctr, 0) = dbReader.Item("points")
                    teamAPlayersStats(ctr, 1) = dbReader.Item("fouls")

                    ctr += 1

                End While

            End If

            CheckIfDbReaderIsClosed()

            OpenDBConnection()
            dbCmd.CommandText = "SELECT player_id, points, fouls FROM tblplayerscores WHERE team_id = " & tempTeamBID & " AND match_id = " & cboMatches.Text
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                Dim ctr = 0

                While dbReader.Read

                    teamBPlayersStats(ctr, 0) = dbReader.Item("points")
                    teamBPlayersStats(ctr, 1) = dbReader.Item("fouls")

                    ctr += 1

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading scores" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        If MsgBox("Do you want to logout", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation Message") = MsgBoxResult.Yes Then

            frmLogin.Show()
            Me.Close()

        End If

    End Sub

    Private Sub btnLoadMatch_Click(sender As Object, e As EventArgs) Handles btnLoadMatch.Click

        InitializeFlags()
        EventsValidation()
        MatchValidation()

        If flag1 = False Or flag2 = False Then

            MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        grpInfo.Enabled = True

        LoadMatch()
        LoadPlayers("SELECT player_id, CONCAT(first_name, ' ', last_name) AS full_name, tblplayers.team_id FROM tblplayers INNER JOIN tblteams ON tblteams.team_id = tblplayers.team_id WHERE tblteams.team_name = '" & lblTeamA.Text & "'", lbTeamAPlayers, "A")
        LoadPlayers("SELECT player_id, CONCAT(first_name, ' ', last_name) AS full_name, tblplayers.team_id FROM tblplayers INNER JOIN tblteams ON tblteams.team_id = tblplayers.team_id WHERE tblteams.team_name = '" & lblTeamB.Text & "'", lbTeamBPlayers, "B")

        teamAPlayersStats = New Integer(lbTeamAPlayers.Items.Count, 2) {}
        teamBPlayersStats = New Integer(lbTeamBPlayers.Items.Count, 2) {}

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT sport_id FROM tblteams WHERE team_name = '" & tempTeam & "'"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                dbReader.Read()

                tempSportID = dbReader.Item("sport_id")

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading sport id." & ex.ToString, MsgBoxStyle.Critical, "Error")

        End Try

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT name FROM tblSports WHERE sport_id = " & tempSportID
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                dbReader.Read()

                tempSportType = dbReader.Item("name")

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading sport name." & ex.ToString, MsgBoxStyle.Critical, "Error")

        End Try

        cboMatches.SelectedText = selectedMatch

        If lblStatus.Text = "Finished" Then

            btnFinishMatch.Visible = False
            grpSelection.Enabled = True
            btnAdd1A.Visible = False
            btnAdd1B.Visible = False
            btnAddFoulA.Visible = False
            btnAddFoulB.Visible = False
            btnAdd2A.Visible = False
            btnAdd2B.Visible = False
            btnAdd3A.Visible = False
            btnAdd3B.Visible = False
            lbTeamAPlayers.Enabled = False
            lbTeamBPlayers.Enabled = False
            lblFoulA.Visible = False
            lblTeamAFouls.Visible = False
            btnAddFoulA.Visible = False
            lblFoulB.Visible = False
            lblTeamBFouls.Visible = False
            btnAddFoulB.Visible = False
            lblPointsA.Visible = False
            lblTeamAPlayerPoints.Visible = False
            lblPointsB.Visible = False
            lblTeamBPlayerPoints.Visible = False
            btnCloseMatch.Visible = False

            MsgBox("This match is already finished. You can check other unfinished matches.")

        Else

            btnFinishMatch.Visible = True
            grpSelection.Enabled = False
            btnAdd1A.Visible = True
            btnAdd1B.Visible = True
            btnAddFoulA.Visible = True
            btnAddFoulB.Visible = True
            lbTeamAPlayers.Enabled = True
            lbTeamBPlayers.Enabled = True
            lblFoulA.Visible = True
            lblTeamAFouls.Visible = True
            btnAddFoulA.Visible = True
            lblFoulB.Visible = True
            lblTeamBFouls.Visible = True
            btnAddFoulB.Visible = True
            lblPointsA.Visible = True
            lblTeamAPlayerPoints.Visible = True
            lblPointsB.Visible = True
            lblTeamBPlayerPoints.Visible = True
            btnCloseMatch.Visible = True

            If tempSportType <> "Basketball" Then

                btnAdd2A.Visible = False
                btnAdd2B.Visible = False
                btnAdd3A.Visible = False
                btnAdd3B.Visible = False

            Else

                btnAdd2A.Visible = True
                btnAdd2B.Visible = True
                btnAdd3A.Visible = True
                btnAdd3B.Visible = True

            End If

        End If

    End Sub

    Private Sub frmScorer_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadEventsOptions()

    End Sub

    Private Sub cboEvents_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboEvents.SelectedIndexChanged

        LoadEvent()

    End Sub

    Private Sub btnFinishMatch_Click(sender As Object, e As EventArgs) Handles btnFinishMatch.Click

        If MsgBox("Do you want to end this match?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

            Try

                If Val(lblAScore.Text) > Val(lblBScore.Text) Then

                    winner = lblTeamA.Text

                    Dim highest = 0

                    Dim index = -1

                    For i = 0 To lbTeamAPlayers.Items.Count - 1 Step 1

                        If teamAPlayersStats(i, 0) > highest Then

                            highest = teamAPlayersStats(i, 0)
                            index = i

                        End If

                    Next

                    Dim temp = lbTeamAPlayers.Items.Item(index).ToString
                    Dim test = temp.Split(New Char() {" "c})

                    MVP = test(1) & " " & test(2)

                Else

                    winner = lblTeamB.Text

                    Dim highest = 0

                    Dim index = -1

                    For i = 0 To lbTeamBPlayers.Items.Count - 1 Step 1

                        If teamBPlayersStats(i, 0) > highest Then

                            highest = teamBPlayersStats(i, 0)

                            index = i

                        End If

                    Next

                    Dim temp = lbTeamBPlayers.Items.Item(index).ToString
                    Dim test = temp.Split(New Char() {" "c})

                    MVP = test(1) & " " & test(2)

                End If

                OpenDBConnection()
                dbCmd.CommandText = "UPDATE tblmatches SET a_score = '" & lblAScore.Text.ToString & "', b_score = '" & lblBScore.Text & "', a_fouls = '" & lblTeamAFouls.Text & "', b_fouls = '" & lblTeamBFouls.Text & "', winner = '" & winner & "', mvp = '" & MVP & "', status = 'Finished' WHERE match_id = " & selectedMatch
                dbCmd.ExecuteNonQuery()

                dbCmd.CommandText = "SELECT * FROM tblplayerscores WHERE match_id = " & cboMatches.Text
                dbReader = dbCmd.ExecuteReader

                If dbReader.HasRows = False Then

                    CheckIfDbReaderIsClosed()

                    For i = 0 To lbTeamAPlayers.Items.Count - 1 Step 1

                        Dim temp = lbTeamAPlayers.Items.Item(i).ToString
                        Dim test = temp.Split(New Char() {" "c})
                        Dim PlayerID = test(0)

                        dbCmd.CommandText = "INSERT INTO tblplayerscores(player_id, team_id, match_id, points, fouls) VALUES(" & PlayerID & ", " & tempTeamAID & ", " & cboMatches.Text & ", " & teamAPlayersStats(i, 0) & ", " & teamAPlayersStats(i, 1) & ")"
                        dbCmd.ExecuteNonQuery()

                    Next

                    For i = 0 To lbTeamBPlayers.Items.Count - 1 Step 1

                        Dim temp = lbTeamBPlayers.Items.Item(i).ToString
                        Dim test = temp.Split(New Char() {" "c})
                        Dim PlayerID = test(0)

                        dbCmd.CommandText = "INSERT INTO tblplayerscores(player_id, team_id, match_id, points, fouls) VALUES(" & PlayerID & ", " & tempTeamBID & ", " & cboMatches.Text & ", " & teamBPlayersStats(i, 0) & ", " & teamBPlayersStats(i, 1) & ")"
                        dbCmd.ExecuteNonQuery()

                    Next

                End If

                MsgBox("Match successfully ended the match.", MsgBoxStyle.Information, "Message")
                MatchReset()

            Catch ex As Exception

                MsgBox("Error on ending the match." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

            End Try

        End If

    End Sub

    Private Sub btnAdd1A_Click(sender As Object, e As EventArgs) Handles btnAdd1A.Click

        If PlayerValidation(lbTeamAPlayers) Then

            Dim PlayerPoints = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0)

            If MsgBox("Add 1 point to " & lbTeamAPlayers.SelectedItem.ToString & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

                PlayerPoints += 1
                teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0) = PlayerPoints
                lblTeamAPlayerPoints.Text = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0)
                UpdateTeamScore()

            End If

        End If

    End Sub

    Private Sub btnAdd2A_Click(sender As Object, e As EventArgs) Handles btnAdd2A.Click

        If PlayerValidation(lbTeamAPlayers) Then

            Dim PlayerPoints = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0)

            If MsgBox("Add 2 points to " & lbTeamAPlayers.SelectedItem.ToString & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

                PlayerPoints += 2
                teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0) = PlayerPoints
                lblTeamAPlayerPoints.Text = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0)
                UpdateTeamScore()

            End If

        End If

    End Sub

    Private Sub btnAdd3A_Click(sender As Object, e As EventArgs) Handles btnAdd3A.Click

        If PlayerValidation(lbTeamAPlayers) Then

            Dim PlayerPoints = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0)

            If MsgBox("Add 3 points to " & lbTeamAPlayers.SelectedItem.ToString & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

                PlayerPoints += 3
                teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0) = PlayerPoints
                lblTeamAPlayerPoints.Text = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0)
                UpdateTeamScore()

            End If

        End If

    End Sub

    Private Sub btnAdd1B_Click(sender As Object, e As EventArgs) Handles btnAdd1B.Click

        If PlayerValidation(lbTeamBPlayers) Then

            Dim PlayerPoints = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0)

            If MsgBox("Add 1 point to " & lbTeamBPlayers.SelectedItem.ToString & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

                PlayerPoints += 1
                teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0) = PlayerPoints
                lblTeamBPlayerPoints.Text = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0)
                UpdateTeamScore()

            End If

        End If

    End Sub

    Private Sub btnAdd2B_Click(sender As Object, e As EventArgs) Handles btnAdd2B.Click

        If PlayerValidation(lbTeamBPlayers) Then

            Dim PlayerPoints = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0)

            If MsgBox("Add 2 points to " & lbTeamBPlayers.SelectedItem.ToString & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

                PlayerPoints += 2
                teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0) = PlayerPoints
                lblTeamBPlayerPoints.Text = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0)
                UpdateTeamScore()

            End If

        End If

    End Sub

    Private Sub btnAdd3B_Click(sender As Object, e As EventArgs) Handles btnAdd3B.Click

        If PlayerValidation(lbTeamBPlayers) Then

            Dim PlayerPoints = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0)

            If MsgBox("Add 3 points to " & lbTeamBPlayers.SelectedItem.ToString & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

                PlayerPoints += 3
                teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0) = PlayerPoints
                lblTeamBPlayerPoints.Text = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0)
                UpdateTeamScore()

            End If

        End If

    End Sub

    Private Sub cboEventsFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEventsFilter.SelectedIndexChanged

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_id FROM tblevents WHERE has_criteria = 0 AND is_pageant = 0 AND event_name = '" & cboEventsFilter.Text & "'"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                dbReader.Read()

                eventFilter = dbReader.Item("event_id").ToString

            End If

            CheckIfDbReaderIsClosed()

            LoadMatchesOptions(tempEventID)

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events", MsgBoxStyle.Critical, "Error")

        End Try

        LoadAllMatches("SELECT * FROM tblmatches WHERE event_id = " & eventFilter)

    End Sub

    Private Sub btnAddFoulA_Click(sender As Object, e As EventArgs) Handles btnAddFoulA.Click

        If PlayerValidation(lbTeamAPlayers) Then

            Dim PlayerFouls = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 1)

            If MsgBox("Add 1 foul to " & lbTeamAPlayers.SelectedItem.ToString & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

                PlayerFouls += 1
                teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 1) = PlayerFouls
                lblTeamAFouls.Text = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 1)

            End If

        End If

    End Sub

    Private Sub btnAddFoulB_Click(sender As Object, e As EventArgs) Handles btnAddFoulB.Click

        If PlayerValidation(lbTeamBPlayers) Then

            Dim PlayerFouls = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 1)

            If MsgBox("Add 1 foul to " & lbTeamBPlayers.SelectedItem.ToString & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

                PlayerFouls += 1
                teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 1) = PlayerFouls
                lblTeamBFouls.Text = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 1)

            End If

        End If

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        frmMyProfile.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        UpdateFullName()
        lblScorerName.Text = userName

    End Sub

    Private Sub lbTeamAPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTeamAPlayers.SelectedIndexChanged

        If lbTeamAPlayers.SelectedIndex <> -1 Then

            lblTeamAPlayerPoints.Text = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 0)
            lblTeamAFouls.Text = teamAPlayersStats(lbTeamAPlayers.SelectedIndex, 1)

        End If

    End Sub

    Private Sub lbTeamBPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTeamBPlayers.SelectedIndexChanged

        If lbTeamBPlayers.SelectedIndex <> -1 Then

            lblTeamBPlayerPoints.Text = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 0)
            lblTeamBFouls.Text = teamBPlayersStats(lbTeamBPlayers.SelectedIndex, 1)

        End If

    End Sub

    Private Sub btnCloseMatch_Click(sender As Object, e As EventArgs) Handles btnCloseMatch.Click

        If MsgBox("Your match result will not be saved. Are you sure you want to close the match?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then

            MatchReset()

        End If

    End Sub
End Class