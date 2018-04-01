Public Class frmEvents

    Dim flag1, flag2, flag3 As Boolean
    Dim index As Integer
    Dim tempEventID, tempCriteria, tempPageant As Integer
    Dim ConfirmationMessage As String = ""
    Dim EventName As String = ""

    Public Sub InitializeFlags()

        flag1 = True
        flag2 = True
        flag3 = True

    End Sub

    Private Sub PerformCancel()

        saveMode = ""

        grpTable.Enabled = True
        grpInfo.Enabled = False
        txtEventName.Text = ""
        txtEventDescription.Text = ""
        dtpEventDate.Text = Now
        chkCriteria.Checked = False
        chkPageant.Checked = False
        chkShow.Checked = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = False
        btnBack.Enabled = True

        ErrorProvider1.SetError(txtEventName, "")
        ErrorProvider1.SetError(txtEventDescription, "")

    End Sub

    Public Sub EventNameValidation()

        If txtEventName.Text.Trim = "" Then

            ErrorProvider1.SetError(txtEventName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtEventName, 5)
            flag1 = False

        ElseIf txtEventName.Text.IndexOfAny(restrictedCharactersForEvents) > -1 Then

            ErrorProvider1.SetError(txtEventName, "Only letters and numbers are allowed on this field.")
            ErrorProvider1.SetIconPadding(txtEventName, 5)
            flag1 = False

        ElseIf IsNumeric(txtEventName.Text) = True Or txtEventName.Text.IndexOfAny("1234567890") = 0 Then

            ErrorProvider1.SetError(txtEventName, "Event Name must start with a letter.")
            ErrorProvider1.SetIconPadding(txtEventName, 5)
            flag1 = False

        Else

            ErrorProvider1.SetError(txtEventName, "")

            OpenDBConnection()
            dbCmd.CommandText = "SELECT * FROM tblevents WHERE event_name = '" & txtEventName.Text.Trim & "';"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True And saveMode = "Add" Then

                ErrorProvider1.SetError(txtEventName, "Event name is already taken.")
                ErrorProvider1.SetIconPadding(txtEventName, 3)
                flag1 = False

                CheckIfDbReaderIsClosed()

            Else

                ErrorProvider1.SetError(txtEventName, "")

                CheckIfDbReaderIsClosed()

            End If

        End If

    End Sub

    Public Sub EventDescriptionValidation()

        If txtEventDescription.Text.Trim = "" Then

            ErrorProvider1.SetError(txtEventDescription, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtEventDescription, 5)
            flag2 = False

        ElseIf txtEventDescription.Text.IndexOfAny(restrictedCharactersForEvents) > -1 Then

            ErrorProvider1.SetError(txtEventDescription, "Only letters and numbers are allowed on this field.")
            ErrorProvider1.SetIconPadding(txtEventDescription, 5)
            flag2 = False

        ElseIf IsNumeric(txtEventDescription.Text) = True Or txtEventDescription.Text.IndexOfAny("1234567890") = 0 Then

            ErrorProvider1.SetError(txtEventDescription, "Event description must start with a letter.")
            ErrorProvider1.SetIconPadding(txtEventDescription, 5)
            flag2 = False

        Else

            ErrorProvider1.SetError(txtEventDescription, "")

        End If

    End Sub

    Private Sub LoadEvents(Query As String)

        Dim index As Integer = 0

        With lstEvents

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("event_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("event_name").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("event_description").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("event_date").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("has_criteria").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("is_pageant").ToString)

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
        txtEventName.Focus()

        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnBack.Enabled = False

        saveMode = "Add"

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        InitializeFlags()

        If saveMode = "Add" Then

            EventNameValidation()
            EventDescriptionValidation()

            If flag1 = False Or flag2 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to add this event?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    If chkCriteria.Checked = True Then

                        tempCriteria = 1

                    Else

                        tempCriteria = 0

                    End If

                    If chkPageant.Checked = True Then

                        tempPageant = 1

                    Else

                        tempPageant = 0

                    End If

                    OpenDBConnection()
                    dbCmd.CommandText = "INSERT INTO tblevents(event_name, event_description, event_date, has_criteria, is_pageant) VALUES('" & txtEventName.Text.Trim & "', '" & txtEventDescription.Text & "', '" & dtpEventDate.Text & "', " & tempCriteria & ", " & tempPageant & ")"
                    dbCmd.ExecuteNonQuery()

                    LoadEvents("SELECT * FROM tblevents ORDER BY event_name ASC")

                    MsgBox("Event added successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    MsgBox("Error in adding an event." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

                End Try

            End If

        ElseIf saveMode = "Edit" Then

            EventNameValidation()
            EventDescriptionValidation()

            If flag1 = False Or flag2 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to update the information about this event?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then


                If chkCriteria.Checked = True Then

                    tempCriteria = 1

                Else

                    tempCriteria = 0

                End If

                If chkPageant.Checked = True Then

                    tempPageant = 1

                Else

                    tempPageant = 0

                End If

                OpenDBConnection()
                dbCmd.CommandText = "UPDATE tblevents SET event_name = '" & txtEventName.Text.Trim & "', event_description = '" & txtEventDescription.Text.Trim & "', event_date = '" & dtpEventDate.Text & "', has_criteria = " & tempCriteria & ", is_pageant = " & tempPageant & "  WHERE event_id = " & tempEventID
                dbCmd.ExecuteNonQuery()

                LoadEvents("SELECT * FROM tblevents ORDER BY event_name ASC")

                MsgBox("Event updated successfully!", MsgBoxStyle.Information, "Message")

                PerformCancel()

            End If

        End If

    End Sub

    Private Sub frmEvents_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadEvents("SELECT * FROM tblEvents ORDER BY event_name ASC")

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        PerformCancel()

    End Sub

    Private Sub lstEvents_DoubleClick(sender As Object, e As EventArgs) Handles lstEvents.DoubleClick

        If chkShow.Checked = True Or lstEvents.Items.Count = 0 Then

            Exit Sub

        End If

        If Not IsNothing(lstEvents.FocusedItem) Then

            index = lstEvents.FocusedItem.Index

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

        With lstEvents.Items(index)

            tempEventID = .SubItems(0).Text
            txtEventName.Text = .SubItems(1).Text
            txtEventDescription.Text = .SubItems(2).Text
            dtpEventDate.Text = .SubItems(3).Text

            If .SubItems(4).Text = 1 Then

                chkCriteria.Checked = True

            Else

                chkCriteria.Checked = False

            End If

            If .SubItems(5).Text = 1 Then

                chkPageant.Checked = True

            Else

                chkPageant.Checked = False

            End If

        End With

        CheckIfDbReaderIsClosed()

        saveMode = "Edit"

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked = True Then

            lstEvents.CheckBoxes = True
            lstEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            btnAdd.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnCancel.Enabled = True
            btnBack.Enabled = False

        Else

            With lstEvents

                For i = 0 To .Items.Count - 1
                    .Items(i).Checked = False
                Next

            End With

            lstEvents.CheckBoxes = False
            lstEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            PerformCancel()

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstEvents.CheckedItems.Count = 0 Then

            MsgBox("Please select event(s) to delete.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If lstEvents.CheckedItems.Count > 1 Then

            ConfirmationMessage = "Do you want to delete these events?"

        Else

            For i = 0 To lstEvents.Items.Count - 1

                If lstEvents.Items(i).Checked = True Then

                    EventName = lstEvents.Items(i).SubItems(1).Text

                End If

            Next

            ConfirmationMessage = "Do you want to delete " & EventName & "?"

        End If

        If MsgBox(ConfirmationMessage & vbNewLine & "WARNING: This action can not be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmation Message") = MsgBoxResult.Yes Then

            OpenDBConnection()
            For i = 0 To lstEvents.Items.Count - 1
                If lstEvents.Items(i).Checked = True Then

                    dbCmd.CommandText = "DELETE FROM tblevents WHERE event_id = '" & lstEvents.Items(i).SubItems(0).Text & "'"
                    dbCmd.ExecuteNonQuery()

                End If
            Next

            LoadEvents("SELECT * FROM tblevents ORDER BY event_name ASC")

            MsgBox("Event(s) deleted successfully", MsgBoxStyle.Information, "Message")

            PerformCancel()

        End If

    End Sub

End Class