Public Class frmLogin

    Dim flag1, flag2 As Boolean

    Private Sub UsernameValidation()

        If txtUsername.Text.Trim = "" Then

            ErrorProvider1.SetError(txtUsername, "Empty username is not allowed.")
            ErrorProvider1.SetIconPadding(txtUsername, 5)
            flag1 = False

        ElseIf txtUsername.Text.IndexOfAny(restrictedCharactersForUsername) > -1 Then

            ErrorProvider1.SetError(txtUsername, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtUsername, 5)
            flag1 = False

        ElseIf txtUsername.Text.IndexOfAny("-_1234567890") = 0 Then

            ErrorProvider1.SetError(txtUsername, "The first character must be a letter.")
            ErrorProvider1.SetIconPadding(txtUsername, 5)
            flag1 = False

        Else

            ErrorProvider1.SetError(txtUsername, "")

        End If

    End Sub

    Private Sub PasswordValidation()

        If txtPassword.Text.Trim = "" Then

            ErrorProvider1.SetError(txtPassword, "Empty password is not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword, 5)
            flag2 = False

        ElseIf txtPassword.Text.IndexOfAny(restrictedCharactersForPassword) > -1 Then

            ErrorProvider1.SetError(txtPassword, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword, 5)
            flag2 = False

        ElseIf txtPassword.Text.Length < 8 Then

            ErrorProvider1.SetError(txtPassword, "Password must be at least 8 characters.")
            ErrorProvider1.SetIconPadding(txtPassword, 5)
            flag2 = False

        Else

            ErrorProvider1.SetError(txtPassword, "")

        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        flag1 = True
        flag2 = True

        UsernameValidation()
        PasswordValidation()

        If flag1 = False Or flag2 = False Then

            MsgBox("Please complete all the required fields and errors!", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        OpenDBConnection()
        dbCmd.CommandText = "SELECT CONCAT(first_name, ' ' , middle_name, ' ', last_name) AS Fullname, username, role, user_id, event_id FROM tblusers WHERE BINARY tblusers.username = '" & txtUsername.Text & "' AND BINARY tblusers.password = '" & txtPassword.Text & "'"
        dbReader = dbCmd.ExecuteReader

        If dbReader.HasRows = True Then

            dbReader.Read()

            userName = dbReader.Item("Fullname")
            UN = dbReader.Item("username")
            userType = dbReader.Item("role")
            userID = dbReader.Item("user_id")

            If userType = "Judge" Then

                eventID = dbReader.Item("event_id")

            End If

            CheckIfDbReaderIsClosed()

            MsgBox("Welcome " & userName & "!", MsgBoxStyle.Information, "Message")

            If userType = "Administrator" Then

                frmDashboard.Show()
                Me.Close()

            ElseIf userType = "Scorer" Then

                frmScorer.Show()
                Me.Close()

            Else

                frmJudge.Show()
                Me.Close()

            End If

        Else

            MsgBox("Incorrect username or password.", MsgBoxStyle.Critical, "Error")
            CheckIfDbReaderIsClosed()
            Exit Sub

        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        frmRegistration.Show()
        Me.Close()

    End Sub
End Class
