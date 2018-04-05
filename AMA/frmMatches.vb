Public Class frmMatches

    Dim flag1, flag2, flag3 As Boolean
    Dim index As Integer
    Dim tempEventID, tempMatchID As Integer
    Dim ConfirmationMessage As String = ""
    Dim MatchName As String = ""

    Public Sub InitializeFlags()

        flag1 = True
        flag2 = True
        flag3 = True

    End Sub

    Private Sub PerformCancel()

        saveMode = ""

        grpTable.Enabled = True
        grpInfo.Enabled = False
        cboEvents.SelectedIndex = -1
        cboTeamA.SelectedIndex = -1
        cboTeamB.SelectedIndex = -1
        chkShow.Checked = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = False
        btnBack.Enabled = True

        ErrorProvider1.SetError(cboEvents, "")
        ErrorProvider1.SetError(cboTeamA, "")
        ErrorProvider1.SetError(cboTeamB, "")

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

    Public Sub TeamAValidation()

        If cboTeamA.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboTeamA, "Please choose the first team.")
            ErrorProvider1.SetIconPadding(cboTeamA, 10)
            flag2 = False

        Else

            ErrorProvider1.SetError(cboTeamA, "")

        End If

    End Sub

    Public Sub TeamBValidation()

        If cboTeamB.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboTeamB, "Please choose the second team.")
            ErrorProvider1.SetIconPadding(cboTeamB, 10)
            flag3 = False

        ElseIf cboTeamB.Text = cboTeamA.Text Then

            ErrorProvider1.SetError(cboTeamB, "Teams should not be the same.")
            ErrorProvider1.SetIconPadding(cboTeamB, 10)
            flag3 = False

        Else

            ErrorProvider1.SetError(cboTeamB, "")

        End If

    End Sub

    Public Sub LoadEventsOptions()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_name FROM tblevents WHERE has_criteria = 0 AND is_pageant = 0 ORDER BY event_name ASC"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    cboEvents.Items.Add(dbReader.Item("event_name").ToString)

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub LoadTeamsOptions()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT team_name FROM tblteams ORDER BY team_name ASC"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    cboTeamA.Items.Add(dbReader.Item("team_name").ToString)
                    cboTeamB.Items.Add(dbReader.Item("team_name").ToString)

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub LoadMatches(Query As String)

        Dim index As Integer = 0

        With lstMatches

            .BeginUpdate()

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

                .EndUpdate()

                CheckIfDbReaderIsClosed()

                Application.UseWaitCursor = False

            Catch ex As Exception

                Application.UseWaitCursor = False

                CheckIfDbReaderIsClosed()

                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

        End With

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmDashboard.Show()
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        grpTable.Enabled = False
        grpInfo.Enabled = True
        cboEvents.Focus()

        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnBack.Enabled = False

        saveMode = "Add"

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        PerformCancel()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        InitializeFlags()

        If saveMode = "Add" Then

            EventsValidation()
            TeamAValidation()
            TeamBValidation()

            If flag1 = False Or flag2 = False Or flag3 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to add this match?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "SELECT event_id FROM tblevents WHERE event_name = '" & cboEvents.Text & "'"
                    dbReader = dbCmd.ExecuteReader

                    If dbReader.HasRows = True Then

                        While dbReader.Read

                            tempEventID = dbReader.Item("event_id").ToString

                        End While

                    End If

                    CheckIfDbReaderIsClosed()

                    OpenDBConnection()
                    dbCmd.CommandText = "INSERT INTO tblmatches(event_id, team_a, team_b) VALUES('" & tempEventID & "', '" & cboTeamA.Text & "', '" & cboTeamB.Text & "')"
                    dbCmd.ExecuteNonQuery()

                    LoadMatches("SELECT * FROM tblmatches ORDER BY match_id ASC")

                    MsgBox("Match added successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()
                    MsgBox("Error in adding match." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

                End Try

            End If

        ElseIf saveMode = "Edit" Then

            EventsValidation()
            TeamAValidation()
            TeamBValidation()

            If flag1 = False Or flag2 = False Or flag3 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to update the information about this match?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "SELECT event_id FROM tblevents WHERE event_name = '" & cboEvents.Text & "'"
                    dbReader = dbCmd.ExecuteReader

                    If dbReader.HasRows = True Then

                        While dbReader.Read

                            tempEventID = dbReader.Item("event_id").ToString

                        End While

                    End If

                    CheckIfDbReaderIsClosed()

                    OpenDBConnection()
                    dbCmd.CommandText = "UPDATE tblmatches SET event_id = " & tempEventID & ", team_a = '" & cboTeamA.Text & "', team_b = '" & cboTeamB.Text & "'  WHERE match_id = " & tempMatchID
                    dbCmd.ExecuteNonQuery()

                    LoadMatches("SELECT * FROM tblmatches ORDER BY match_id ASC")

                    MsgBox("Team updated successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()
                    MsgBox("Error on updating the match information." & ex.ToString, MsgBoxStyle.Critical, "Error")

                End Try

            End If

        End If

    End Sub

    Private Sub frmMatches_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadEventsOptions()
        LoadTeamsOptions()
        LoadMatches("SELECT * FROM tblmatches ORDER BY match_id ASC")

    End Sub

    Private Sub lstMatches_DoubleClick(sender As Object, e As EventArgs) Handles lstMatches.DoubleClick

        If chkShow.Checked = True Or lstMatches.Items.Count = 0 Then

            Exit Sub

        End If

        If Not IsNothing(lstMatches.FocusedItem) Then

            index = lstMatches.FocusedItem.Index

        Else

            Exit Sub

        End If

        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnBack.Enabled = False

        grpInfo.Enabled = True
        grpTable.Enabled = False

        With lstMatches.Items(index)

            tempMatchID = .SubItems(0).Text
            tempEventID = .SubItems(1).Text

            Try

                OpenDBConnection()
                dbCmd.CommandText = "SELECT event_name FROM tblevents WHERE event_id = " & tempEventID
                dbReader = dbCmd.ExecuteReader

                If dbReader.HasRows = True Then

                    dbReader.Read()

                    cboEvents.Text = dbReader.Item("event_name").ToString

                End If

                CheckIfDbReaderIsClosed()

                cboTeamA.Text = .SubItems(2).Text
                cboTeamB.Text = .SubItems(3).Text

            Catch ex As Exception

                CheckIfDbReaderIsClosed()
                MsgBox("Error on loading the Event name on the combo box.", MsgBoxStyle.Critical, "Error")

            End Try

        End With

        CheckIfDbReaderIsClosed()

        saveMode = "Edit"

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked = True Then

            lstMatches.CheckBoxes = True
            lstMatches.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            btnAdd.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnCancel.Enabled = True
            btnBack.Enabled = False

        Else

            With lstMatches

                For i = 0 To .Items.Count - 1
                    .Items(i).Checked = False
                Next

            End With

            lstMatches.CheckBoxes = False
            lstMatches.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            PerformCancel()

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstMatches.CheckedItems.Count = 0 Then

            MsgBox("Please select match(es) to delete.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If lstMatches.CheckedItems.Count > 1 Then

            ConfirmationMessage = "Do you want to delete these matches?"

        Else

            For i = 0 To lstMatches.Items.Count - 1

                If lstMatches.Items(i).Checked = True Then

                    MatchName = lstMatches.Items(i).SubItems(0).Text

                End If

            Next

            ConfirmationMessage = "Do you want to delete match #" & MatchName & "?"

        End If

        If MsgBox(ConfirmationMessage & vbNewLine & "WARNING: This action can not be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmation Message") = MsgBoxResult.Yes Then

            OpenDBConnection()
            For i = 0 To lstMatches.Items.Count - 1
                If lstMatches.Items(i).Checked = True Then

                    dbCmd.CommandText = "DELETE FROM tblmatches WHERE match_id = '" & lstMatches.Items(i).SubItems(0).Text & "'"
                    dbCmd.ExecuteNonQuery()

                End If
            Next

            LoadMatches("SELECT * FROM tblmatches ORDER BY match_id ASC")

            MsgBox("Match(s) deleted successfully", MsgBoxStyle.Information, "Message")

            PerformCancel()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If grpInfo.Enabled = False And chkShow.Checked = False And lstMatches.SelectedItems.Count = 0 Then

            LoadMatches("SELECT * FROM tblmatches ORDER BY match_id ASC")

        End If

    End Sub

End Class