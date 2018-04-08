Public Class frmCategories

    Dim flag1 As Boolean
    Dim index As Integer
    Dim tempCategoryID As Integer
    Dim ConfirmationMessage As String = ""
    Dim CategoryName As String = ""

    Private Sub InitializeFlags()

        flag1 = True

    End Sub

    Private Sub PerformCancel()

        saveMode = ""

        grpTable.Enabled = True
        grpInfo.Enabled = False
        txtCategoryName.Text = ""
        chkShow.Checked = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnBack.Enabled = True

        ErrorProvider1.SetError(txtCategoryName, "")

    End Sub

    Private Sub CategoryValidation()

        If txtCategoryName.Text.Trim = "" Then

            ErrorProvider1.SetError(txtCategoryName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtCategoryName, 5)
            flag1 = False

        ElseIf txtCategoryName.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtCategoryName, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtCategoryName, 5)
            flag1 = False

        ElseIf IsNumeric(txtCategoryName.Text) = True Or txtCategoryName.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtCategoryName, "Numeric characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtCategoryName, 5)
            flag1 = False

        Else

            ErrorProvider1.SetError(txtCategoryName, "")

        End If

    End Sub

    Private Sub LoadPageantCategories(Query As String)

        Dim index As Integer = 0

        With lstPageantCategories

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("criteria_category_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("criteria_category_name").ToString)

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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        grpTable.Enabled = False
        grpInfo.Enabled = True
        txtCategoryName.Focus()

        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnBack.Enabled = False

        saveMode = "Add"

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        PerformCancel()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmDashboard.Show()
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        InitializeFlags()

        If saveMode = "Add" Then

            CategoryValidation()

            If flag1 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to add this category?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "SELECT * FROM tblcriteria_categories WHERE criteria_category_name = '" & txtCategoryName.Text.Trim & "'"
                    dbReader = dbCmd.ExecuteReader()

                    If dbReader.HasRows = True Then

                        CheckIfDbReaderIsClosed()

                        MsgBox("This category is already existing!", MsgBoxStyle.Critical, "Error")
                        Exit Sub

                    End If

                    CheckIfDbReaderIsClosed()

                    OpenDBConnection()
                    dbCmd.CommandText = "INSERT INTO tblcriteria_categories(criteria_category_name) VALUES('" & txtCategoryName.Text.Trim & "')"
                    dbCmd.ExecuteNonQuery()

                    LoadPageantCategories("SELECT * FROM tblcriteria_categories ORDER BY criteria_category_id ASC")

                    MsgBox("Pageant category added successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()
                    MsgBox("Error on adding pageant category", MsgBoxStyle.Critical, "Error")

                End Try


            End If

        ElseIf saveMode = "Edit" Then

            CategoryValidation()

            If flag1 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If

            If MsgBox("Do you want to edit this category?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

                Try

                    OpenDBConnection()
                    dbCmd.CommandText = "SELECT * FROM tblcriteria_categories WHERE criteria_category_name = '" & txtCategoryName.Text.Trim & "' AND criteria_category_id != " & tempCategoryID
                    dbReader = dbCmd.ExecuteReader()

                    If dbReader.HasRows = True Then

                        CheckIfDbReaderIsClosed()

                        MsgBox("This category is already existing!", MsgBoxStyle.Critical, "Error")
                        Exit Sub

                    End If

                    CheckIfDbReaderIsClosed()

                    OpenDBConnection()
                    dbCmd.CommandText = "UPDATE tblcriteria_categories SET criteria_category_name = '" & txtCategoryName.Text.Trim & "' WHERE criteria_category_id = " & tempCategoryID
                    dbCmd.ExecuteNonQuery()

                    LoadPageantCategories("SELECT * FROM tblcriteria_categories ORDER BY criteria_category_id ASC")

                    MsgBox("Pageant category updated successfully!", MsgBoxStyle.Information, "Message")

                    PerformCancel()

                Catch ex As Exception

                    CheckIfDbReaderIsClosed()
                    MsgBox("Error on updating pageant category", MsgBoxStyle.Critical, "Error")

                End Try

            End If

        End If

    End Sub

    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadPageantCategories("SELECT * FROM tblcriteria_categories ORDER BY criteria_category_id ASC")

    End Sub

    Private Sub lstPageantCategories_DoubleClick(sender As Object, e As EventArgs) Handles lstPageantCategories.DoubleClick

        If chkShow.Checked = True Or lstPageantCategories.Items.Count = 0 Then

            Exit Sub

        End If

        If Not IsNothing(lstPageantCategories.FocusedItem) Then

            index = lstPageantCategories.FocusedItem.Index

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

        With lstPageantCategories.Items(index)

            tempCategoryID = .SubItems(0).Text
            txtCategoryName.Text = .SubItems(1).Text

        End With

        saveMode = "Edit"

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked = True Then

            lstPageantCategories.CheckBoxes = True
            lstPageantCategories.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            btnAdd.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnCancel.Enabled = True
            btnBack.Enabled = False

        Else

            With lstPageantCategories

                For i = 0 To .Items.Count - 1
                    .Items(i).Checked = False
                Next

            End With

            lstPageantCategories.CheckBoxes = False
            lstPageantCategories.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            PerformCancel()

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstPageantCategories.CheckedItems.Count = 0 Then

            MsgBox("Please select a category to delete.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If lstPageantCategories.CheckedItems.Count > 1 Then

            ConfirmationMessage = "Do you want to delete these categories?"

        Else

            For i = 0 To lstPageantCategories.Items.Count - 1

                If lstPageantCategories.Items(i).Checked = True Then

                    CategoryName = lstPageantCategories.Items(i).SubItems(1).Text

                End If

            Next

            ConfirmationMessage = "Do you want to delete " & CategoryName & " category?"

        End If

        If MsgBox(ConfirmationMessage & vbNewLine & "WARNING: This action can not be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmation Message") = MsgBoxResult.Yes Then

            OpenDBConnection()
            For i = 0 To lstPageantCategories.Items.Count - 1
                If lstPageantCategories.Items(i).Checked = True Then

                    dbCmd.CommandText = "DELETE FROM tblcriteria_categories WHERE criteria_category_id = '" & lstPageantCategories.Items(i).SubItems(0).Text & "'"
                    dbCmd.ExecuteNonQuery()

                End If
            Next

            LoadPageantCategories("SELECT * FROM tblcriteria_categories ORDER BY criteria_category_id ASC")

            MsgBox("Category(ies) deleted successfully", MsgBoxStyle.Information, "Message")

            PerformCancel()

        End If

    End Sub
End Class