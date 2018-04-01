Public Class frmPageant

    Dim flag1, flag2, flag3, flag4 As Boolean
    Dim index, tempEventID, tempContestantID, tempTotalCandidates As Integer
    Dim ConfirmationMessage As String = ""
    Dim ContestantName As String = ""

    Public Sub InitializeFlags()

        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True

    End Sub

    Private Sub PerformCancel()

        saveMode = ""

        grpTable.Enabled = True
        grpInfo.Enabled = False
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboTitle.SelectedIndex = -1
        cboEvents.SelectedIndex = -1
        chkShow.Checked = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = False
        btnBack.Enabled = True

        ErrorProvider1.SetError(txtFirstName, "")
        ErrorProvider1.SetError(txtLastName, "")
        ErrorProvider1.SetError(cboTitle, "")
        ErrorProvider1.SetError(cboEvents, "")

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

    Public Sub TitleValidation()

        If cboTitle.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboTitle, "Please choose a title.")
            ErrorProvider1.SetIconPadding(cboTitle, 10)
            flag3 = False

        Else

            ErrorProvider1.SetError(cboTitle, "")

        End If

    End Sub

    Public Sub EventValidation()

        If cboEvents.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboEvents, "Please choose an event.")
            ErrorProvider1.SetIconPadding(cboEvents, 10)
            flag4 = False

        Else

            ErrorProvider1.SetError(cboEvents, "")

        End If

    End Sub

    Public Sub LoadEventsOptions()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_name FROM tblevents WHERE is_pageant = 1 ORDER BY event_name ASC"
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

    Public Sub LoadContestants(Query As String)

        Dim index As Integer = 0

        With lstContestants

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("contestant_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("first_name").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("last_name").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("title").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("event_id").ToString)

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

    Public Sub CountContestants(Query As String)

        tempTotalCandidates = 0

        Try

            OpenDBConnection()
            dbCmd.CommandText = Query
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    tempTotalCandidates = dbReader.Item("total_candidates").ToString()

                    index += 1

                End While


            End If

            CheckIfDbReaderIsClosed()


        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

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
            TitleValidation()
            EventValidation()

            If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to add this contestant?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "SELECT event_id FROM tblevents WHERE event_name = '" & cboEvents.Text & "' AND is_pageant = 1"
                    dbReader = dbCmd.ExecuteReader

                    If dbReader.HasRows = True Then

                        While dbReader.Read

                            tempEventID = dbReader.Item("event_id").ToString

                        End While

                    End If

                    CheckIfDbReaderIsClosed()

                    CountContestants("SELECT COUNT(contestant_id) AS total_candidates FROM tblcontestants WHERE event_id = " & tempEventID & " AND title = '" & cboTitle.Text & "'")

                    If tempTotalCandidates >= 10 Then

                        MsgBox("The total candidates for " & cboEvents.Text & " is already reached the limit.", MsgBoxStyle.Critical, "Error")
                        Exit Sub

                    End If

                    OpenDBConnection()
                    dbCmd.CommandText = "INSERT INTO tblcontestants(first_name, last_name, title, event_id) VALUES('" & txtFirstName.Text.Trim & "', '" & txtLastName.Text.Trim & "', '" & cboTitle.Text & "', " & tempEventID & ")"
                    dbCmd.ExecuteNonQuery()

                    LoadContestants("SELECT * FROM tblcontestants ORDER BY last_name ASC")

                    MsgBox("Contestant added successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()
                    MsgBox("Error in adding a contestant." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

                End Try

            End If

        ElseIf saveMode = "Edit" Then

            FirstNameValidation()
            LastNameValidation()
            TitleValidation()
            EventValidation()

            If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you update the information about this contestant?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation Message") = MsgBoxResult.Yes Then

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
                    dbCmd.CommandText = "UPDATE tblcontestants SET first_name = '" & txtFirstName.Text.Trim & "', last_name = '" & txtLastName.Text.Trim & "', title = '" & cboTitle.Text & "', event_id = " & tempEventID & "  WHERE contestant_id = " & tempContestantID
                    dbCmd.ExecuteNonQuery()

                    LoadContestants("SELECT * FROM tblcontestants ORDER BY last_name ASC")

                    MsgBox("Contestant updated successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()
                    MsgBox("Error on updating the contestant's information." & ex.ToString, MsgBoxStyle.Critical, "Error")

                End Try

            End If

        End If

    End Sub

    Private Sub frmPageant_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadEventsOptions()
        LoadContestants("SELECT * FROM tblcontestants ORDER BY last_name ASC")

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked = True Then

            lstContestants.CheckBoxes = True
            lstContestants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            btnAdd.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnCancel.Enabled = True
            btnBack.Enabled = False

        Else

            With lstContestants

                For i = 0 To .Items.Count - 1
                    .Items(i).Checked = False
                Next

            End With

            lstContestants.CheckBoxes = False
            lstContestants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            PerformCancel()

        End If

    End Sub

    Private Sub lstContestants_DoubleClick(sender As Object, e As EventArgs) Handles lstContestants.DoubleClick

        If chkShow.Checked = True Or lstContestants.Items.Count = 0 Then

            Exit Sub

        End If

        If Not IsNothing(lstContestants.FocusedItem) Then

            index = lstContestants.FocusedItem.Index

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

        With lstContestants.Items(index)

            tempContestantID = .SubItems(0).Text
            txtFirstName.Text = .SubItems(1).Text
            txtLastName.Text = .SubItems(2).Text
            cboTitle.Text = .SubItems(3).Text
            tempEventID = .SubItems(4).Text

            Try

                OpenDBConnection()
                dbCmd.CommandText = "SELECT event_name FROM tblevents WHERE event_id = " & tempEventID
                dbReader = dbCmd.ExecuteReader

                If dbReader.HasRows = True Then

                    dbReader.Read()

                    cboEvents.Text = dbReader.Item("event_name").ToString

                End If

                CheckIfDbReaderIsClosed()

            Catch ex As Exception

                CheckIfDbReaderIsClosed()
                MsgBox("Error on loading the Event name on the combo box.", MsgBoxStyle.Critical, "Error")

            End Try

        End With

        CheckIfDbReaderIsClosed()

        saveMode = "Edit"

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstContestants.CheckedItems.Count = 0 Then

            MsgBox("Please select contestant(s) to delete.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If lstContestants.CheckedItems.Count > 1 Then

            ConfirmationMessage = "Do you want to delete these contestants?"

        Else

            For i = 0 To lstContestants.Items.Count - 1

                If lstContestants.Items(i).Checked = True Then

                    ContestantName = lstContestants.Items(i).SubItems(1).Text & " " & lstContestants.Items(i).SubItems(2).Text

                End If

            Next

            ConfirmationMessage = "Do you want to delete contestant " & ContestantName & "?"

        End If

        If MsgBox(ConfirmationMessage & vbNewLine & "WARNING: This action can not be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmation Message") = MsgBoxResult.Yes Then

            OpenDBConnection()
            For i = 0 To lstContestants.Items.Count - 1
                If lstContestants.Items(i).Checked = True Then

                    dbCmd.CommandText = "DELETE FROM tblcontestants WHERE contestant_id = '" & lstContestants.Items(i).SubItems(0).Text & "'"
                    dbCmd.ExecuteNonQuery()

                End If
            Next

            LoadContestants("SELECT * FROM tblcontestants ORDER BY last_name ASC")

            MsgBox("Contestants(s) deleted successfully", MsgBoxStyle.Information, "Message")

            PerformCancel()

        End If

    End Sub
End Class