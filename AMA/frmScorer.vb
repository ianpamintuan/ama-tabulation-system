Public Class frmScorer

    Dim flag1, flag2 As Boolean
    Dim index, tempEventID, tempMatchID, selectedMatch, TeamAScore, TeamBScore, TeamAFoul, TeamBFoul, tempSportID As Integer
    Dim selectedEvent As String = ""
    Dim winner As String = ""
    Dim eventFilter As String = ""
    Dim tempTeam As String = ""
    Dim tempSportType As String = ""

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

            btnPauseMatch.Visible = False
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

            MsgBox("This match is already finished. You can check other unfinished matches.")

        Else

            btnPauseMatch.Visible = True
            btnFinishMatch.Visible = True
            grpSelection.Enabled = False
            btnAdd1A.Visible = True
            btnAdd1B.Visible = True
            btnAddFoulA.Visible = True
            btnAddFoulB.Visible = True

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

            MsgBox(tempSportType)

        End If

    End Sub

    Private Sub frmScorer_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadEventsOptions()

    End Sub

    Private Sub cboEvents_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboEvents.SelectedIndexChanged

        LoadEvent()

    End Sub

    Private Sub btnPauseMatch_Click(sender As Object, e As EventArgs) Handles btnPauseMatch.Click

        If MsgBox("Do you want to pause this match?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

            Try

                OpenDBConnection()
                dbCmd.CommandText = "UPDATE tblmatches SET a_score = '" & lblAScore.Text.ToString & "', b_score = '" & lblBScore.Text & "', a_fouls = '" & lblTeamAFouls.Text & "', b_fouls = '" & lblTeamBFouls.Text & "', status = 'Paused' WHERE match_id = " & selectedMatch
                dbCmd.ExecuteNonQuery()

                MsgBox("Match successfully paused at the moment.", MsgBoxStyle.Information, "Message")
                MatchReset()

            Catch ex As Exception

                MsgBox("Error on pausing the match.", MsgBoxStyle.Critical, "Error")

            End Try

        End If

    End Sub

    Private Sub btnFinishMatch_Click(sender As Object, e As EventArgs) Handles btnFinishMatch.Click

        If MsgBox("Do you want to end this match?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

            Try

                If Val(lblAScore.Text) > Val(lblBScore.Text) Then

                    winner = lblTeamA.Text

                Else

                    winner = lblTeamB.Text

                End If

                OpenDBConnection()
                dbCmd.CommandText = "UPDATE tblmatches SET a_score = '" & lblAScore.Text.ToString & "', b_score = '" & lblBScore.Text & "', a_fouls = '" & lblTeamAFouls.Text & "', b_fouls = '" & lblTeamBFouls.Text & "', winner = '" & winner & "', status = 'Finished' WHERE match_id = " & selectedMatch
                dbCmd.ExecuteNonQuery()

                MsgBox("Match successfully ended the match.", MsgBoxStyle.Information, "Message")
                MatchReset()

            Catch ex As Exception

                MsgBox("Error on ending the match.", MsgBoxStyle.Critical, "Error")

            End Try

        End If

    End Sub

    Private Sub btnAdd1A_Click(sender As Object, e As EventArgs) Handles btnAdd1A.Click

        If MsgBox("Add 1 point to Team " & lblTeamA.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

            TeamAScore = Val(lblAScore.Text)
            TeamAScore += 1
            lblAScore.Text = TeamAScore

        End If

    End Sub

    Private Sub btnAdd2A_Click(sender As Object, e As EventArgs) Handles btnAdd2A.Click

        If MsgBox("Add 2 points to Team " & lblTeamA.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

            TeamAScore = Val(lblAScore.Text)
            TeamAScore += 2
            lblAScore.Text = TeamAScore

        End If

    End Sub

    Private Sub btnAdd3A_Click(sender As Object, e As EventArgs) Handles btnAdd3A.Click

        If MsgBox("Add 3 points to Team " & lblTeamA.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

            TeamAScore = Val(lblAScore.Text)
            TeamAScore += 3
            lblAScore.Text = TeamAScore

        End If

    End Sub

    Private Sub btnAdd1B_Click(sender As Object, e As EventArgs) Handles btnAdd1B.Click

        If MsgBox("Add 1 point to Team " & lblTeamB.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

            TeamBScore = Val(lblBScore.Text)
            TeamBScore += 1
            lblBScore.Text = TeamBScore

        End If

    End Sub

    Private Sub btnAdd2B_Click(sender As Object, e As EventArgs) Handles btnAdd2B.Click

        If MsgBox("Add 2 points to Team " & lblTeamB.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

            TeamBScore = Val(lblBScore.Text)
            TeamBScore += 2
            lblBScore.Text = TeamBScore

        End If

    End Sub

    Private Sub btnAdd3B_Click(sender As Object, e As EventArgs) Handles btnAdd3B.Click

        If MsgBox("Add 3 points to Team " & lblTeamB.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

            TeamBScore = Val(lblBScore.Text)
            TeamBScore += 3
            lblBScore.Text = TeamBScore

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

        If MsgBox("Add 1 foul to Team " & lblTeamA.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

            TeamAFoul = Val(lblTeamAFouls.Text)
            TeamAFoul += 1
            lblTeamAFouls.Text = TeamAFoul

        End If

    End Sub

    Private Sub btnAddFoulB_Click(sender As Object, e As EventArgs) Handles btnAddFoulB.Click

        If MsgBox("Add 1 foul to Team " & lblTeamB.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes Then

            TeamBFoul = Val(lblTeamBFouls.Text)
            TeamBFoul += 1
            lblTeamBFouls.Text = TeamBFoul

        End If

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        frmMyProfile.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        UpdateFullName()
        lblScorerName.Text = userName

    End Sub
End Class