Public Class frmMyProfile

    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean
    Dim tempUserID As Integer = 0
    Dim tempPassword As String = ""

    Private Sub InitializeFlags()

        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True
        flag5 = True
        flag6 = True
        flag7 = True
        flag8 = True

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

    Private Sub MiddleNameValidation()

        If txtMiddleName.Text.Trim = "" Then

            ErrorProvider1.SetError(txtMiddleName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtMiddleName, 5)
            flag3 = False

        ElseIf txtMiddleName.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtMiddleName, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtMiddleName, 5)
            flag3 = False

        ElseIf IsNumeric(txtMiddleName.Text) = True Or txtMiddleName.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtMiddleName, "Numeric characters are not characters allowed in this field.")
            ErrorProvider1.SetIconPadding(txtMiddleName, 5)
            flag3 = False

        Else

            ErrorProvider1.SetError(txtMiddleName, "")

        End If

    End Sub

    Private Sub EmailValidation()

        If txtEmail.Text.Trim = "" Then

            ErrorProvider1.SetError(txtEmail, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtEmail, 5)
            flag4 = False

        ElseIf txtEmail.Text.IndexOfAny(restrictedCharactersForEmail) > -1 Then

            ErrorProvider1.SetError(txtEmail, "Only letters, numbers, dot, at sign, underscore and dash are the only characters allowed.")
            ErrorProvider1.SetIconPadding(txtEmail, 5)
            flag4 = False

        ElseIf IsNumeric(txtEmail.Text) = True Or txtEmail.Text.IndexOfAny("-_1234567890") = 0 Then

            ErrorProvider1.SetError(txtEmail, "Email must contain and starts with letters.")
            ErrorProvider1.SetIconPadding(txtEmail, 5)
            flag4 = False

        ElseIf txtEmail.Text.Contains("@") = False Or txtEmail.Text.Contains(".") = False Then

            ErrorProvider1.SetError(txtEmail, "This is not a valid email.")
            ErrorProvider1.SetIconPadding(txtEmail, 5)
            flag4 = False

        Else

            ErrorProvider1.SetError(txtEmail, "")

        End If

    End Sub

    Private Sub UsernameValidation()

        If txtUsername.Text.Trim = "" Then

            ErrorProvider1.SetError(txtUsername, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        ElseIf txtUsername.Text.IndexOfAny(restrictedCharactersForUsername) > -1 Then

            ErrorProvider1.SetError(txtUsername, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        ElseIf txtUsername.Text.IndexOfAny("-_1234567890") = 0 Then

            ErrorProvider1.SetError(txtUsername, "The first character must be a letter.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        ElseIf txtUsername.Text.Length < 3 Then

            ErrorProvider1.SetError(txtUsername, "Username must me at least 3 characters.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        Else

            ErrorProvider1.SetError(txtUsername, "")

            OpenDBConnection()
            dbCmd.CommandText = "SELECT * FROM tblusers WHERE BINARY username = '" & txtUsername.Text.Trim & "' AND user_id != " & userID
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                ErrorProvider1.SetError(txtUsername, "Username is already taken.")
                ErrorProvider1.SetIconPadding(txtUsername, 3)
                flag5 = False

                CheckIfDbReaderIsClosed()

            Else

                ErrorProvider1.SetError(txtUsername, "")

                CheckIfDbReaderIsClosed()

            End If

        End If

    End Sub

    Private Sub PasswordValidation()

        If txtPassword.Text.Trim = "" Then

            ErrorProvider1.SetError(txtPassword, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword, 3)
            flag6 = False

        ElseIf txtPassword.Text.IndexOfAny(restrictedCharactersForPassword) > -1 Then

            ErrorProvider1.SetError(txtPassword, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword, 3)
            flag6 = False

        ElseIf txtPassword.Text.Length < 8 Then

            ErrorProvider1.SetError(txtPassword, "Password must be at least 8 characters.")
            ErrorProvider1.SetIconPadding(txtPassword, 3)
            flag6 = False

        Else

            OpenDBConnection()
            dbCmd.CommandText = "SELECT * FROM tblusers WHERE BINARY password = '" & txtPassword.Text & "' AND user_id = " & userID
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = False Then

                ErrorProvider1.SetError(txtPassword, "Incorrect password.")
                ErrorProvider1.SetIconPadding(txtPassword, 3)
                flag6 = False

                CheckIfDbReaderIsClosed()

            Else

                ErrorProvider1.SetError(txtPassword, "")

                CheckIfDbReaderIsClosed()

            End If

        End If

    End Sub

    Private Sub NewPasswordValidation()

        If txtNewPassword.Text.Trim = "" Then

            ErrorProvider1.SetError(txtNewPassword, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtNewPassword, 3)
            flag6 = False

        ElseIf txtNewPassword.Text.IndexOfAny(restrictedCharactersForPassword) > -1 Then

            ErrorProvider1.SetError(txtNewPassword, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtNewPassword, 3)
            flag6 = False

        ElseIf txtNewPassword.Text.Length < 8 Then

            ErrorProvider1.SetError(txtNewPassword, "New password must be at least 8 characters.")
            ErrorProvider1.SetIconPadding(txtNewPassword, 3)
            flag6 = False

        Else

            ErrorProvider1.SetError(txtNewPassword, "")

        End If

    End Sub

    Private Sub LoadMyProfile()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT * FROM tblusers LEFT JOIN tblevents ON tblusers.event_id = tblevents.event_id WHERE user_id = " & userID
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    txtFirstName.Text = dbReader.Item("first_name").ToString()
                    txtMiddleName.Text = dbReader.Item("middle_name").ToString()
                    txtLastName.Text = dbReader.Item("last_name").ToString()
                    txtEmail.Text = dbReader.Item("email").ToString()
                    lblRole.Text = dbReader.Item("role").ToString()

                    If dbReader.Item("event_id") <> 0 Then

                        lblEvent.Text = dbReader.Item("event_name").ToString()

                    Else

                        lblEvent.Text = "None"

                    End If

                    txtUsername.Text = dbReader.Item("username").ToString()

                    tempPassword = dbReader.Item("password").ToString()

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading my profile" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub frmMyProfile_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadMyProfile()

    End Sub

    Private Sub chkChangePassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkChangePassword.CheckedChanged

        If chkChangePassword.Checked = True Then

            lblNewPassword.Visible = True
            txtNewPassword.Visible = True

        Else

            lblNewPassword.Visible = False
            txtNewPassword.Visible = False

        End If

    End Sub

    Private Sub btnUpdateInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateInfo.Click

        InitializeFlags()

        FirstNameValidation()
        MiddleNameValidation()
        LastNameValidation()
        EmailValidation()
        UsernameValidation()
        PasswordValidation()

        If chkChangePassword.Checked = True Then

            NewPasswordValidation()

        End If

        If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Then

            MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If MsgBox("Do you want to update your account details?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

            Try

                OpenDBConnection()

                If chkChangePassword.Checked = True Then

                    dbCmd.CommandText = "UPDATE tblusers SET first_name = '" & txtFirstName.Text.Trim & "', middle_name = '" & txtMiddleName.Text.Trim & "', last_name = '" & txtLastName.Text.Trim & "', email = '" & txtEmail.Text.Trim & "', username= '" & txtUsername.Text.Trim & "', password = '" & txtNewPassword.Text.Trim & "' WHERE user_id = " & userID

                Else

                    dbCmd.CommandText = "UPDATE tblusers SET first_name = '" & txtFirstName.Text.Trim & "', middle_name = '" & txtMiddleName.Text.Trim & "', last_name = '" & txtLastName.Text.Trim & "', email = '" & txtEmail.Text.Trim & "', username= '" & txtUsername.Text.Trim & "', password = '" & txtPassword.Text.Trim & "' WHERE user_id = " & userID

                End If

                dbCmd.ExecuteNonQuery()

                MsgBox("Your profile is now successfully updated!", MsgBoxStyle.Information, "Message")

                Me.Dispose()

            Catch ex As Exception

                MsgBox("Error on updating account profile", MsgBoxStyle.Critical, "Error")

            End Try

        End If

    End Sub
End Class