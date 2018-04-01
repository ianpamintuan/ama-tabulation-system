Public Class frmJudge

    Dim flag1 As Boolean
    Dim index, flag As Integer
    Dim categoryMr(,,) As Integer
    Dim categoryMs(,,) As Integer
    Dim EventName As String = ""

    Public Sub InitializeFlags()

        flag1 = True

    End Sub

    Public Sub LoadEventName()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_name FROM tblevents WHERE is_pageant = 1 AND event_id = " & eventID
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    EventName = dbReader.Item("event_name").ToString()

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub CountTotal()

        lblTotal.Text = nupCriteriaValue1.Value + nupCriteriaValue2.Value + nupCriteriaValue3.Value + nupCriteriaValue4.Value

    End Sub

    Public Sub SaveScoresTemp()

        Dim selectedCategory As Integer = lbCategories.SelectedIndex
        Dim selectedMr As Integer = -1
        selectedMr = lbMr.SelectedIndex
        Dim selectedMs As Integer = -1
        selectedMs = lbMs.SelectedIndex
        Dim i, j As Integer

        If selectedMr <> -1 And selectedCategory <> -1 Then

            For i = 0 To 4 Step 1

                If selectedCategory = i Then

                    categoryMr(i, selectedMr, 0) = nupCriteriaValue1.Value
                    categoryMr(i, selectedMr, 1) = nupCriteriaValue2.Value
                    categoryMr(i, selectedMr, 2) = nupCriteriaValue3.Value
                    categoryMr(i, selectedMr, 3) = nupCriteriaValue4.Value

                End If

            Next

        Else

            For i = 0 To 4 Step 1

                If selectedCategory = i Then

                    categoryMs(i, selectedMs, 0) = nupCriteriaValue1.Value
                    categoryMs(i, selectedMs, 1) = nupCriteriaValue2.Value
                    categoryMs(i, selectedMs, 2) = nupCriteriaValue3.Value
                    categoryMs(i, selectedMs, 3) = nupCriteriaValue4.Value


                End If

            Next

        End If

    End Sub

    Public Sub LoadTempScores()

        Dim selectedCategory As Integer = lbCategories.SelectedIndex
        Dim selectedMr As Integer = -1
        selectedMr = lbMr.SelectedIndex
        Dim selectedMs As Integer = -1
        selectedMs = lbMs.SelectedIndex
        Dim i As Integer

        If selectedMr <> -1 And selectedCategory <> -1 Then

            For i = 0 To 4 Step 1

                If selectedCategory = i Then

                    Try

                        nupCriteriaValue1.Value = categoryMr(i, selectedMr, 0)

                    Catch ex As Exception

                        nupCriteriaValue1.Value = 0

                    End Try

                    Try

                        nupCriteriaValue2.Value = categoryMr(i, selectedMr, 1)

                    Catch ex As Exception

                        nupCriteriaValue2.Value = 0

                    End Try

                    Try

                        nupCriteriaValue3.Value = categoryMr(i, selectedMr, 2)

                    Catch ex As Exception

                        nupCriteriaValue3.Value = 0

                    End Try

                    Try

                        nupCriteriaValue4.Value = categoryMr(i, selectedMr, 3)

                    Catch ex As Exception

                        nupCriteriaValue4.Value = 0

                    End Try

                End If

            Next

        Else

            For i = 0 To 4 Step 1

                If selectedCategory = i Then

                    Try

                        nupCriteriaValue1.Value = categoryMs(i, selectedMs, 0)

                    Catch ex As Exception

                        nupCriteriaValue1.Value = 0

                    End Try

                    Try

                        nupCriteriaValue2.Value = categoryMs(i, selectedMs, 1)

                    Catch ex As Exception

                        nupCriteriaValue2.Value = 0

                    End Try

                    Try

                        nupCriteriaValue3.Value = categoryMs(i, selectedMs, 2)

                    Catch ex As Exception

                        nupCriteriaValue3.Value = 0

                    End Try

                    Try

                        nupCriteriaValue4.Value = categoryMs(i, selectedMs, 3)

                    Catch ex As Exception

                        nupCriteriaValue4.Value = 0

                    End Try

                End If

            Next

        End If

        CountTotal()

    End Sub

    Public Sub LoadCategories()

        Dim index As Integer = 0

        With lbCategories

            .Items.Clear()

            Try

                OpenDBConnection()
                dbCmd.CommandText = "SELECT * FROM tblcriteria_categories"
                dbReader = dbCmd.ExecuteReader

                Application.UseWaitCursor = True

                If dbReader.HasRows = True Then

                    While dbReader.Read

                        .Items.Add(dbReader.Item("criteria_category_name").ToString)

                        index += 1

                    End While

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

    Public Sub LoadContestants(Query As String, lbName As ListBox)

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

                        .Items.Add(dbReader.Item("contestant_id").ToString & " " & dbReader.Item("full_name").ToString)

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

    Public Sub LoadScores()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT tblscores.*, tblcontestants.title FROM tblscores"
            dbCmd.CommandText &= " INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id"
            dbCmd.CommandText &= " WHERE tblscores.judge_id = " & userID & " And tblscores.event_id = " & eventID
            'SELECT tblscores.*, tblcontestants.title FROM tblscores
            'INNER JOIN tblcontestants ON tblcontestants.contestant_id = tblscores.contestant_id
            'WHERE tblscores.judge_id = 1 And tblscores.event_id = 1
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                MsgBox("You already submitted your scores for this event. Redirecting to your score tally.", MsgBoxStyle.Information, "Message")

                CheckIfDbReaderIsClosed()

                frmJudgeTally.Show()
                Me.Close()

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub frmJudge_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadCategories()
        LoadContestants("SELECT contestant_id, CONCAT(first_name, ' ', last_name) AS full_name FROM tblcontestants WHERE title = 'Mr' AND event_id = " & eventID, lbMr)
        LoadContestants("SELECT contestant_id, CONCAT(first_name, ' ', last_name) AS full_name FROM tblcontestants WHERE title = 'Ms' AND event_id = " & eventID, lbMs)
        categoryMs = New Integer(5, lbMs.Items.Count, 4) {}
        categoryMr = New Integer(5, lbMr.Items.Count, 4) {}
        lblJudgeName.Text = userName
        LoadEventName()
        lblEventName.Text = EventName
        LoadScores()

    End Sub

    Private Sub lbMr_Click(sender As Object, e As EventArgs) Handles lbMr.Click

        If lbMs.SelectedItems.Count > 0 Then
            lbMs.SelectedIndex = -1
        End If

    End Sub


    Private Sub lbMr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMr.SelectedIndexChanged

        LoadTempScores()

    End Sub

    Private Sub lbMs_Click(sender As Object, e As EventArgs) Handles lbMs.Click

        If lbMr.SelectedItems.Count > 0 Then
            lbMr.SelectedIndex = -1
        End If

    End Sub

    Private Sub lbMs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMs.SelectedIndexChanged

        LoadTempScores()

    End Sub

    Private Sub lbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCategories.SelectedIndexChanged

        LoadTempScores()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If lbCategories.SelectedIndex = -1 Or (lbMr.SelectedIndex = -1 And lbMs.SelectedIndex = -1) Then

            MsgBox("Please choose a category and candidate before updating the scores", MsgBoxStyle.Critical, "Message")

        Else

            SaveScoresTemp()

        End If

    End Sub

    Private Sub nupCriteriaValue1_KeyUp(sender As Object, e As KeyEventArgs) Handles nupCriteriaValue1.KeyUp

        CountTotal()

    End Sub

    Private Sub nupCriteriaValue2_KeyUp(sender As Object, e As KeyEventArgs) Handles nupCriteriaValue2.KeyUp

        CountTotal()

    End Sub

    Private Sub nupCriteriaValue3_KeyUp(sender As Object, e As KeyEventArgs) Handles nupCriteriaValue3.KeyUp

        CountTotal()

    End Sub

    Private Sub nupCriteriaValue4_KeyUp(sender As Object, e As KeyEventArgs) Handles nupCriteriaValue4.KeyUp

        CountTotal()

    End Sub

    Private Sub btnSubmitScores_Click(sender As Object, e As EventArgs) Handles btnSubmitScores.Click

        If MsgBox("Do you want to submit all the pageant scores?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

            Dim i, j, k, category_id, criteria_id, judge_id, event_id, score As Integer
            Dim contestant_id As String = ""
            flag = 0

            For i = 0 To lbMr.Items.Count - 1 Step 1

                For j = 0 To 4 Step 1

                    For k = 0 To 3 Step 1

                        If categoryMr(j, i, k) = Nothing Then

                            flag += 1

                        End If

                    Next

                Next

            Next

            For i = 0 To lbMs.Items.Count - 1 Step 1

                For j = 0 To 4 Step 1

                    For k = 0 To 3 Step 1

                        If categoryMs(j, i, k) = Nothing Then

                            flag += 1

                        End If

                    Next

                Next

            Next

            If flag > 0 Then

                MsgBox("Please complete all the scores.", MsgBoxStyle.Critical, "Message")
                Exit Sub

            End If

            Try

                'Scores for Mr
                For i = 0 To lbMr.Items.Count - 1 Step 1

                    For j = 0 To 4 Step 1

                        For k = 0 To 3 Step 1

                            event_id = eventID
                            judge_id = userID
                            category_id = j + 1
                            criteria_id = k + 1
                            score = categoryMr(j, i, k)
                            Dim temp = lbMr.Items.Item(i).ToString
                            Dim test = temp.Split(New Char() {" "c})
                            contestant_id = test(0)

                            Try

                                OpenDBConnection()
                                dbCmd.CommandText = "INSERT INTO tblscores(event_id, judge_id, criteria_id, category_id, contestant_id, score) VALUES(" & event_id & ", " & judge_id & ", " & criteria_id & ", " & category_id & ", " & contestant_id & ", " & score & ")"
                                dbCmd.ExecuteNonQuery()

                            Catch ex As Exception

                                MsgBox("Error on saving the male contestants scores." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

                            End Try

                        Next

                    Next

                Next

                'Scores for Ms
                For i = 0 To lbMs.Items.Count - 1 Step 1

                    For j = 0 To 4 Step 1

                        For k = 0 To 3 Step 1

                            event_id = eventID
                            judge_id = userID
                            category_id = j + 1
                            criteria_id = k + 1
                            score = categoryMs(j, i, k)
                            Dim temp = lbMs.Items.Item(i).ToString
                            Dim test = temp.Split(New Char() {" "c})
                            contestant_id = test(0)

                            Try

                                OpenDBConnection()
                                dbCmd.CommandText = "INSERT INTO tblscores(event_id, judge_id, criteria_id, category_id, contestant_id, score) VALUES(" & event_id & ", " & judge_id & ", " & criteria_id & ", " & category_id & ", " & contestant_id & ", " & score & ")"
                                dbCmd.ExecuteNonQuery()

                            Catch ex As Exception

                                MsgBox("Error on saving the female contestants scores." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

                            End Try

                        Next

                    Next

                Next

                MsgBox("Successfully submitted your judge sheet scores!", MsgBoxStyle.Information, "Message")

                LoadScores()

            Catch ex As Exception

                MsgBox("Error on the judge scores." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

            End Try

        End If


    End Sub

    Private Sub nupCriteriaValue1_ValueChanged(sender As Object, e As EventArgs) Handles nupCriteriaValue1.ValueChanged

        CountTotal()

    End Sub

    Private Sub nupCriteriaValue2_ValueChanged(sender As Object, e As EventArgs) Handles nupCriteriaValue2.ValueChanged

        CountTotal()

    End Sub

    Private Sub nupCriteriaValue3_ValueChanged(sender As Object, e As EventArgs) Handles nupCriteriaValue3.ValueChanged

        CountTotal()

    End Sub

    Private Sub nupCriteriaValue4_ValueChanged(sender As Object, e As EventArgs) Handles nupCriteriaValue4.ValueChanged

        CountTotal()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        If MsgBox("Do you want to logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

            frmLogin.Show()
            Me.Close()

        End If

    End Sub

End Class