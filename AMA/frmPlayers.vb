Public Class frmPlayers

    Dim flag1, flag2, flag3 As Boolean
    Dim index As Integer
    Dim tempPlayerID, tempTeamID As Integer
    Dim ConfirmationMessage As String = ""
    Dim PlayerName As String = ""

    Private Sub InitializeFlags()

        flag1 = True
        flag2 = True
        flag3 = True

    End Sub

    Private Sub PerformCancel()

        saveMode = ""

        grpTable.Enabled = True
        grpInfo.Enabled = False
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboTeam.SelectedIndex = -1
        chkShow.Checked = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = False
        btnBack.Enabled = True

        ErrorProvider1.SetError(txtFirstName, "")
        ErrorProvider1.SetError(txtLastName, "")
        ErrorProvider1.SetError(cboTeam, "")

    End Sub

    Private Sub FirstNameValidation()

        If txtFirstname.Text.Trim = "" Then

            ErrorProvider1.SetError(txtFirstName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtFirstName, 5)
            flag1 = False

        ElseIf txtFirstname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtFirstName, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtFirstName, 5)
            flag1 = False

        ElseIf IsNumeric(txtFirstName.Text) = True Or txtFirstName.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtFirstName, "Numeric characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtFirstName, 5)
            flag1 = False

        Else

            ErrorProvider1.SetError(txtFirstName, "")

        End If

    End Sub

    Private Sub LastNameValidation()

        If txtLastname.Text.Trim = "" Then

            ErrorProvider1.SetError(txtLastName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtLastName, 5)
            flag2 = False

        ElseIf txtLastName.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtLastName, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtLastName, 5)
            flag2 = False

        ElseIf IsNumeric(txtLastName.Text) = True Or txtLastName.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtLastName, "Numeric characters are not characters allowed in this field.")
            ErrorProvider1.SetIconPadding(txtLastName, 5)
            flag2 = False

        Else

            ErrorProvider1.SetError(txtLastName, "")

        End If

    End Sub

    Public Sub TeamValidation()

        If cboTeam.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboTeam, "Please choose a team.")
            ErrorProvider1.SetIconPadding(cboTeam, 10)
            flag3 = False

        Else

            ErrorProvider1.SetError(cboTeam, "")

        End If

    End Sub

    Public Sub LoadTeams()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT team_name FROM tblteams"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    cboTeam.Items.Add(dbReader.Item("team_name"))

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading teams.", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub LoadPlayers(Query As String)

        Dim index As Integer = 0

        With lstPlayers

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("player_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("first_name").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("last_name").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("team_id").ToString)

                        index += 1

                    End While

                    .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

                End If

                CheckIfDbReaderIsClosed()

                Application.UseWaitCursor = False

            Catch ex As Exception

                Application.UseWaitCursor = False

                CheckIfDbReaderIsClosed()

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

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
        txtFirstName.Focus()

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

            FirstNameValidation()
            LastNameValidation()
            TeamValidation()

            If flag1 = False Or flag2 = False Or flag3 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to add this player?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation Message") = MsgBoxResult.Yes Then

                tempTeamID = 0

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "SELECT team_id FROM tblteams WHERE team_name = '" & cboTeam.Text & "'"
                    dbReader = dbCmd.ExecuteReader

                    If dbReader.HasRows = True Then

                        dbReader.Read()

                        tempTeamID = dbReader.Item("team_id").ToString

                    End If

                    CheckIfDbReaderIsClosed()

                    OpenDBConnection()
                    dbCmd.CommandText = "INSERT INTO tblplayers(first_name, last_name, team_id) VALUES('" & txtFirstName.Text.Trim & "', '" & txtLastName.Text.Trim & "', " & tempTeamID & ")"
                    dbCmd.ExecuteNonQuery()

                    LoadPlayers("SELECT * FROM tblplayers ORDER BY player_id ASC")

                    MsgBox("Player added successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()

                    MsgBox("Error in adding a player.", MsgBoxStyle.Critical, "Error")

                End Try

            End If

        ElseIf saveMode = "Edit" Then

            FirstNameValidation()
            LastNameValidation()
            TeamValidation()

            If flag1 = False Or flag2 = False Or flag3 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you update the information about this player?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "SELECT team_id FROM tblteams WHERE team_name = '" & cboTeam.Text & "'"
                    dbReader = dbCmd.ExecuteReader

                    If dbReader.HasRows = True Then

                        While dbReader.Read

                            tempTeamID = dbReader.Item("team_id").ToString

                        End While

                    End If

                    CheckIfDbReaderIsClosed()

                    OpenDBConnection()
                    dbCmd.CommandText = "UPDATE tblplayers SET first_name = '" & txtFirstName.Text.Trim & "', last_name = '" & txtLastName.Text.Trim & "', team_id = " & tempTeamID & "  WHERE player_id = " & tempPlayerID
                    dbCmd.ExecuteNonQuery()

                    LoadPlayers("SELECT * FROM tblplayers ORDER BY player_id ASC")

                    MsgBox("Player updated successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()

                    MsgBox("Error on updating the player's information." & ex.ToString, MsgBoxStyle.Critical, "Error")

                End Try

            End If


        End If

    End Sub

    Private Sub frmPlayers_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadTeams()
        LoadPlayers("SELECT * FROM tblplayers ORDER BY player_id ASC")

    End Sub

    Private Sub lstPlayers_DoubleClick(sender As Object, e As EventArgs) Handles lstPlayers.DoubleClick

        If chkShow.Checked = True Or lstPlayers.Items.Count = 0 Then

            Exit Sub

        End If

        If Not IsNothing(lstPlayers.FocusedItem) Then

            index = lstPlayers.FocusedItem.Index

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

        With lstPlayers.Items(index)

            tempPlayerID = .SubItems(0).Text
            txtFirstName.Text = .SubItems(1).Text
            txtLastName.Text = .SubItems(2).Text
            tempTeamID = .SubItems(3).Text

            Try

                OpenDBConnection()
                dbCmd.CommandText = "SELECT team_name FROM tblteams WHERE team_id = " & tempTeamID
                dbReader = dbCmd.ExecuteReader

                If dbReader.HasRows = True Then

                    dbReader.Read()

                    cboTeam.Text = dbReader.Item("team_name").ToString

                End If

                CheckIfDbReaderIsClosed()

            Catch ex As Exception

                CheckIfDbReaderIsClosed()
                MsgBox("Error on loading the Team name on the combo box.", MsgBoxStyle.Critical, "Error")

            End Try

        End With

        CheckIfDbReaderIsClosed()

        saveMode = "Edit"

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked = True Then

            lstPlayers.CheckBoxes = True
            lstPlayers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            btnAdd.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnCancel.Enabled = True
            btnBack.Enabled = False

        Else

            With lstPlayers

                For i = 0 To .Items.Count - 1
                    .Items(i).Checked = False
                Next

            End With

            lstPlayers.CheckBoxes = False
            lstPlayers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            PerformCancel()

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstPlayers.CheckedItems.Count = 0 Then

            MsgBox("Please select player(s) to delete.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If lstPlayers.CheckedItems.Count > 1 Then

            ConfirmationMessage = "Do you want to delete these players?"

        Else

            For i = 0 To lstPlayers.Items.Count - 1

                If lstPlayers.Items(i).Checked = True Then

                    PlayerName = lstPlayers.Items(i).SubItems(1).Text & " " & lstPlayers.Items(i).SubItems(2).Text

                End If

            Next

            ConfirmationMessage = "Do you want to delete player " & PlayerName & "?"

        End If

        If MsgBox(ConfirmationMessage & vbNewLine & "WARNING: This action can not be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmation Message") = MsgBoxResult.Yes Then

            OpenDBConnection()
            For i = 0 To lstPlayers.Items.Count - 1
                If lstPlayers.Items(i).Checked = True Then

                    dbCmd.CommandText = "DELETE FROM tblplayers WHERE player_id = '" & lstPlayers.Items(i).SubItems(0).Text & "'"
                    dbCmd.ExecuteNonQuery()

                End If
            Next

            LoadPlayers("SELECT * FROM tblplayers ORDER BY player_id ASC")

            MsgBox("Player(s) deleted successfully", MsgBoxStyle.Information, "Message")

            PerformCancel()

        End If

    End Sub
End Class