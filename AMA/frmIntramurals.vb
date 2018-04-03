Public Class frmIntramurals

    Dim flag1, flag2 As Boolean
    Dim index As Integer
    Dim tempSportID As Integer
    Dim ConfirmationMessage As String = ""
    Dim SportName As String = ""

    Public Sub InitializeFlags()

        flag1 = True
        flag2 = True

    End Sub

    Private Sub PerformCancel()

        saveMode = ""

        grpTable.Enabled = True
        grpInfo.Enabled = False
        txtSportName.Text = ""
        cboSports.SelectedIndex = -1
        chkShow.Checked = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = False
        btnBack.Enabled = True

        ErrorProvider1.SetError(txtSportName, "")
        ErrorProvider1.SetError(cboSports, "")

    End Sub

    Public Sub SportNameValidation()

        If txtSportName.Text.Trim = "" Then

            ErrorProvider1.SetError(txtSportName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtSportName, 5)
            flag1 = False

        ElseIf txtSportName.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtSportName, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtSportName, 5)
            flag1 = False

        ElseIf IsNumeric(txtSportName.Text) = True Or txtSportName.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtSportName, "Numeric characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtSportName, 5)
            flag1 = False

        Else

            ErrorProvider1.SetError(txtSportName, "")

            OpenDBConnection()
            dbCmd.CommandText = "SELECT * FROM tblsports WHERE name = '" & txtSportName.Text.Trim & "';"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True And saveMode = "Add" Then

                ErrorProvider1.SetError(txtSportName, "Sport is already saved on the database.")
                ErrorProvider1.SetIconPadding(txtSportName, 3)
                flag1 = False

                CheckIfDbReaderIsClosed()

            Else

                ErrorProvider1.SetError(txtSportName, "")

                CheckIfDbReaderIsClosed()

            End If

        End If

    End Sub

    Public Sub CategoryValidation()

        If cboSports.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboSports, "Please choose a category.")
            ErrorProvider1.SetIconPadding(cboSports, 10)
            flag2 = False

        Else

            ErrorProvider1.SetError(cboSports, "")

        End If

    End Sub

    Private Sub LoadSports(Query As String)

        Dim index As Integer = 0

        With lstSports

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("sport_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("name").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("sport_category").ToString)

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmDashboard.Show()
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        grpTable.Enabled = False
        grpInfo.Enabled = True
        txtSportName.Focus()

        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnBack.Enabled = False

        saveMode = "Add"

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        InitializeFlags()

        If saveMode = "Add" Then

            SportNameValidation()
            CategoryValidation()

            If flag1 = False Or flag2 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to add this sport?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "INSERT INTO tblsports(name, sport_category) VALUES('" & txtSportName.Text.Trim & "', '" & cboSports.Text & "')"
                    dbCmd.ExecuteNonQuery()

                    LoadSports("SELECT * FROM tblsports ORDER BY sport_id ASC")

                    MsgBox("Sport added successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    MsgBox("Error in adding sport." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

                End Try

            End If

        ElseIf saveMode = "Edit" Then

            SportNameValidation()
            CategoryValidation()

            If flag1 = False Or flag2 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to update the information about this sport?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

                OpenDBConnection()
                dbCmd.CommandText = "UPDATE tblsports SET name = '" & txtSportName.Text.Trim & "', sport_category = '" & cboSports.Text & "'  WHERE sport_id = " & tempSportID
                dbCmd.ExecuteNonQuery()

                LoadSports("SELECT * FROM tblsports ORDER BY sport_id ASC")

                MsgBox("Sport updated successfully!", MsgBoxStyle.Information, "Message")

                PerformCancel()

            End If

        End If

    End Sub

    Private Sub lstSports_DoubleClick(sender As Object, e As EventArgs) Handles lstSports.DoubleClick

        If chkShow.Checked = True Or lstSports.Items.Count = 0 Then

            Exit Sub

        End If

        If Not IsNothing(lstSports.FocusedItem) Then

            index = lstSports.FocusedItem.Index

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

        With lstSports.Items(index)

            tempSportID = .SubItems(0).Text
            txtSportName.Text = .SubItems(1).Text
            cboSports.Text = .SubItems(2).Text

        End With

        CheckIfDbReaderIsClosed()

        saveMode = "Edit"

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        PerformCancel()

    End Sub

    Private Sub frmIntramurals_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadSports("SELECT * FROM tblsports ORDER BY sport_id ASC")

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked = True Then

            lstSports.CheckBoxes = True
            lstSports.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            btnAdd.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnCancel.Enabled = True
            btnBack.Enabled = False

        Else

            With lstSports

                For i = 0 To .Items.Count - 1
                    .Items(i).Checked = False
                Next

            End With

            lstSports.CheckBoxes = False
            lstSports.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            PerformCancel()

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstSports.CheckedItems.Count = 0 Then

            MsgBox("Please select sport(s) to delete.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If lstSports.CheckedItems.Count > 1 Then

            ConfirmationMessage = "Do you want to delete these sports?"

        Else

            For i = 0 To lstSports.Items.Count - 1

                If lstSports.Items(i).Checked = True Then

                    SportName = lstSports.Items(i).SubItems(1).Text

                End If

            Next

            ConfirmationMessage = "Do you want to delete " & SportName & "?"

        End If

        If MsgBox(ConfirmationMessage & vbNewLine & "WARNING: This action can not be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmation Message") = MsgBoxResult.Yes Then

            OpenDBConnection()
            For i = 0 To lstSports.Items.Count - 1
                If lstSports.Items(i).Checked = True Then

                    dbCmd.CommandText = "DELETE FROM tblsports WHERE sport_id = '" & lstSports.Items(i).SubItems(0).Text & "'"
                    dbCmd.ExecuteNonQuery()

                End If
            Next

            LoadSports("SELECT * FROM tblsports ORDER BY sport_id ASC")

            MsgBox("Sport(s) deleted successfully", MsgBoxStyle.Information, "Message")

            PerformCancel()

        End If

    End Sub

End Class