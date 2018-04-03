Public Class frmTeams

    Dim flag1, flag2 As Boolean
    Dim index As Integer
    Dim tempTeamID, tempSportID As Integer
    Dim ConfirmationMessage As String = ""
    Dim TeamName As String = ""

    Public Sub InitializeFlags()

        flag1 = True
        flag2 = True

    End Sub

    Private Sub PerformCancel()

        saveMode = ""

        grpTable.Enabled = True
        grpInfo.Enabled = False
        txtTeamName.Text = ""
        cboSports.SelectedIndex = -1
        chkShow.Checked = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = False
        btnBack.Enabled = True

        ErrorProvider1.SetError(txtTeamName, "")
        ErrorProvider1.SetError(cboSports, "")

    End Sub

    Public Sub TeamNameValidation()

        If txtTeamName.Text.Trim = "" Then

            ErrorProvider1.SetError(txtTeamName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtTeamName, 5)
            flag1 = False

        ElseIf txtTeamName.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtTeamName, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtTeamName, 5)
            flag1 = False

        ElseIf IsNumeric(txtTeamName.Text) = True Or txtTeamName.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtTeamName, "Numeric characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtTeamName, 5)
            flag1 = False

        Else

            ErrorProvider1.SetError(txtTeamName, "")

            OpenDBConnection()
            dbCmd.CommandText = "SELECT * FROM tblteams WHERE team_name = '" & txtTeamName.Text.Trim & "';"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True And saveMode = "Add" Then

                ErrorProvider1.SetError(txtTeamName, "Team is already registered on our database.")
                ErrorProvider1.SetIconPadding(txtTeamName, 3)
                flag1 = False

                CheckIfDbReaderIsClosed()

            Else

                ErrorProvider1.SetError(txtTeamName, "")

                CheckIfDbReaderIsClosed()

            End If

        End If

    End Sub

    Public Sub SportValidation()

        If cboSports.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboSports, "Please choose a sport.")
            ErrorProvider1.SetIconPadding(cboSports, 10)
            flag2 = False

        Else

            ErrorProvider1.SetError(cboSports, "")

        End If

    End Sub

    Public Sub LoadSportsOptions()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT name FROM tblsports ORDER BY name ASC"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    cboSports.Items.Add(dbReader.Item("name").ToString)

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading sports", MsgBoxStyle.Critical, "Error")

        End Try
        

    End Sub

    Public Sub LoadTeams(Query As String)

        Dim index As Integer = 0

        With lstTeams

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("team_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("team_name").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("sport_id").ToString)

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmDashboard.Show()
        Me.Close()

    End Sub

    Private Sub frmTeams_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadSportsOptions()
        LoadTeams("SELECT * FROM tblteams ORDER BY team_id ASC")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        grpTable.Enabled = False
        grpInfo.Enabled = True
        txtTeamName.Focus()

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

            TeamNameValidation()
            SportValidation()

            If flag1 = False Or flag2 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to add this team?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "SELECT sport_id FROM tblsports WHERE name = '" & cboSports.Text & "'"
                    dbReader = dbCmd.ExecuteReader

                    If dbReader.HasRows = True Then

                        While dbReader.Read

                            tempSportID = dbReader.Item("sport_id").ToString

                        End While

                    End If

                    CheckIfDbReaderIsClosed()

                    OpenDBConnection()
                    dbCmd.CommandText = "INSERT INTO tblteams(team_name, sport_id) VALUES('" & txtTeamName.Text.Trim & "', '" & tempSportID & "')"
                    dbCmd.ExecuteNonQuery()

                    LoadTeams("SELECT * FROM tblteams ORDER BY team_id ASC")

                    MsgBox("Team added successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()
                    MsgBox("Error in adding team." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

                End Try

            End If

        ElseIf saveMode = "Edit" Then

            TeamNameValidation()
            SportValidation()

            If flag1 = False Or flag2 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to update the information about this team?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "SELECT sport_id FROM tblsports WHERE name = '" & cboSports.Text & "'"
                    dbReader = dbCmd.ExecuteReader

                    If dbReader.HasRows = True Then

                        dbReader.Read()

                        tempSportID = dbReader.Item("sport_id").ToString

                    End If

                    CheckIfDbReaderIsClosed()

                    OpenDBConnection()
                    dbCmd.CommandText = "UPDATE tblteams SET team_name = '" & txtTeamName.Text.Trim & "', sport_id = '" & tempSportID & "'  WHERE team_id = " & tempTeamID
                    dbCmd.ExecuteNonQuery()

                    LoadTeams("SELECT * FROM tblteams ORDER BY team_id ASC")

                    MsgBox("Team updated successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()
                    MsgBox("Error on updating the team information." & ex.ToString, MsgBoxStyle.Critical, "Error")

                End Try

            End If

        End If

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked = True Then

            lstTeams.CheckBoxes = True
            lstTeams.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            btnAdd.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnCancel.Enabled = True
            btnBack.Enabled = False

        Else

            With lstTeams

                For i = 0 To .Items.Count - 1
                    .Items(i).Checked = False
                Next

            End With

            lstTeams.CheckBoxes = False
            lstTeams.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            PerformCancel()

        End If

    End Sub

    Private Sub lstTeams_DoubleClick(sender As Object, e As EventArgs) Handles lstTeams.DoubleClick

        If chkShow.Checked = True Or lstTeams.Items.Count = 0 Then

            Exit Sub

        End If

        If Not IsNothing(lstTeams.FocusedItem) Then

            index = lstTeams.FocusedItem.Index

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

        With lstTeams.Items(index)

            tempTeamID = .SubItems(0).Text
            txtTeamName.Text = .SubItems(1).Text

            Try

                OpenDBConnection()
                dbCmd.CommandText = "SELECT name FROM tblsports WHERE sport_id = " & .SubItems(2).Text
                dbReader = dbCmd.ExecuteReader

                If dbReader.HasRows = True Then

                    dbReader.Read()

                    cboSports.Text = dbReader.Item("name").ToString

                End If

                CheckIfDbReaderIsClosed()

            Catch ex As Exception

                CheckIfDbReaderIsClosed()
                MsgBox("Error on loading the Sport name on the combo box.", MsgBoxStyle.Critical, "Error")

            End Try

        End With

        CheckIfDbReaderIsClosed()

        saveMode = "Edit"

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstTeams.CheckedItems.Count = 0 Then

            MsgBox("Please select teams(s) to delete.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If lstTeams.CheckedItems.Count > 1 Then

            ConfirmationMessage = "Do you want to delete these teams?"

        Else

            For i = 0 To lstTeams.Items.Count - 1

                If lstTeams.Items(i).Checked = True Then

                    TeamName = lstTeams.Items(i).SubItems(1).Text

                End If

            Next

            ConfirmationMessage = "Do you want to delete " & TeamName & "?"

        End If

        If MsgBox(ConfirmationMessage & vbNewLine & "WARNING: This action can not be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmation Message") = MsgBoxResult.Yes Then

            OpenDBConnection()
            For i = 0 To lstTeams.Items.Count - 1
                If lstTeams.Items(i).Checked = True Then

                    dbCmd.CommandText = "DELETE FROM tblteams WHERE team_id = '" & lstTeams.Items(i).SubItems(0).Text & "'"
                    dbCmd.ExecuteNonQuery()

                End If
            Next

            LoadTeams("SELECT * FROM tblteams ORDER BY team_id ASC")

            MsgBox("Team(s) deleted successfully", MsgBoxStyle.Information, "Message")

            PerformCancel()

        End If

    End Sub

End Class