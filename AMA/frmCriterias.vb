Public Class frmCriterias

    Dim flag1 As Boolean
    Dim index As Integer
    Dim tempCriteriaID As Integer
    Dim TotalPercentage As Integer = 0

    Private Sub InitializeFlags()

        flag1 = True

    End Sub

    Private Sub PerformCancel()

        saveMode = ""

        grpTable.Enabled = True
        grpInfo.Enabled = False
        txtCriteriaName.Text = ""
        nupPercentage.Value = 0

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnBack.Enabled = True

        ErrorProvider1.SetError(txtCriteriaName, "")

    End Sub

    Private Sub CriteriaValidation()

        If txtCriteriaName.Text.Trim = "" Then

            ErrorProvider1.SetError(txtCriteriaName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtCriteriaName, 5)
            flag1 = False

        ElseIf txtCriteriaName.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtCriteriaName, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtCriteriaName, 5)
            flag1 = False

        ElseIf IsNumeric(txtCriteriaName.Text) = True Or txtCriteriaName.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtCriteriaName, "Numeric characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtCriteriaName, 5)
            flag1 = False

        Else

            ErrorProvider1.SetError(txtCriteriaName, "")

        End If

    End Sub

    Private Function PercentageValidation()

        TotalPercentage = 0

        With lstPageantCriterias

            For i = 0 To lstPageantCriterias.Items.Count - 1

                TotalPercentage += Val(lstPageantCriterias.Items.Item(i).SubItems(2).Text)

            Next

            If TotalPercentage < 100 Or TotalPercentage > 100 Then

                MsgBox("The total percentage for all the criterias must be equal to 100. Please re-edit the percentages.", MsgBoxStyle.Critical, "Error")
                Return False

            Else

                Return True

            End If

        End With

    End Function

    Private Sub LoadPageantCriterias(Query As String)

        Dim index As Integer = 0

        With lstPageantCriterias

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = Query
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("criteria_id").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("criteria_name").ToString)
                        .Items(index).SubItems.Add(dbReader.Item("percentage").ToString)

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

        If PercentageValidation() Then

            frmDashboard.Show()
            Me.Close()

        End If

    End Sub

    Private Sub frmCriterias_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Not PercentageValidation() Then

            e.Cancel = True

        End If

    End Sub

    Private Sub frmCriterias_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadPageantCriterias("SELECT * FROM tblcriterias ORDER BY criteria_id ASC")

    End Sub

    Private Sub lstPageantCriterias_DoubleClick(sender As Object, e As EventArgs) Handles lstPageantCriterias.DoubleClick

        If Not IsNothing(lstPageantCriterias.FocusedItem) Then

            index = lstPageantCriterias.FocusedItem.Index

        Else

            Exit Sub

        End If

        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnBack.Enabled = False

        grpInfo.Enabled = True
        grpTable.Enabled = False

        With lstPageantCriterias.Items(index)

            tempCriteriaID = .SubItems(0).Text
            txtCriteriaName.Text = .SubItems(1).Text
            nupPercentage.Value = .SubItems(2).Text

        End With

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        PerformCancel()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        InitializeFlags()

        CriteriaValidation()

        If flag1 = False Then

            MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If MsgBox("Do you want to edit this criteria?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

            Try

                OpenDBConnection()
                dbCmd.CommandText = "SELECT * FROM tblcriterias WHERE criteria_name = '" & txtCriteriaName.Text & "' AND criteria_id != " & tempCriteriaID
                dbReader = dbCmd.ExecuteReader

                If dbReader.HasRows = True Then

                    CheckIfDbReaderIsClosed()

                    MsgBox("This criteria is already existing!", MsgBoxStyle.Critical, "Error")
                    Exit Sub

                End If

                CheckIfDbReaderIsClosed()

                OpenDBConnection()
                dbCmd.CommandText = "UPDATE tblcriterias SET criteria_name = '" & txtCriteriaName.Text & "', percentage = " & nupPercentage.Value & " WHERE criteria_id = " & tempCriteriaID
                dbCmd.ExecuteNonQuery()

                LoadPageantCriterias("SELECT * FROM tblcriterias ORDER BY criteria_id ASC")

                MsgBox("Pageant criteria updated successfully!", MsgBoxStyle.Information, "Message")

                PerformCancel()

            Catch ex As Exception

                CheckIfDbReaderIsClosed()
                MsgBox("Error on updating pageant criteria", MsgBoxStyle.Critical, "Error")

            End Try

        End If

    End Sub
End Class