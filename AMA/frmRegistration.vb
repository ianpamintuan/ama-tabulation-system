Public Class frmRegistration

    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean
    Dim index As Integer
    Dim tempUserID, tempEventID, tempTotalJudges As Integer
    Dim ConfirmationMessage As String = ""
    Dim FullName As String = ""
    Dim tempEventName As String = ""

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
            dbCmd.CommandText = "SELECT * FROM tblusers WHERE BINARY username = '" & txtUsername.Text.Trim & "';"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True And saveMode = "Add" Then

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

            ErrorProvider1.SetError(txtPassword, "")

        End If

    End Sub

    Private Sub ConfirmPasswordValidation()

        If txtConfirmPassword.Text.Trim = "" Then

            ErrorProvider1.SetError(txtConfirmPassword, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtConfirmPassword, 3)
            flag7 = False

        ElseIf txtConfirmPassword.Text.IndexOfAny(restrictedCharactersForPassword) > -1 Then

            ErrorProvider1.SetError(txtConfirmPassword, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtConfirmPassword, 3)
            flag7 = False

        ElseIf String.Compare(txtPassword.Text, txtConfirmPassword.Text, False) < 0 Or String.Compare(txtPassword.Text, txtConfirmPassword.Text, False) > 0 Then

            ErrorProvider1.SetError(txtConfirmPassword, "Your password does not match.")
            ErrorProvider1.SetIconPadding(txtConfirmPassword, 3)
            flag7 = False

        Else

            ErrorProvider1.SetError(txtConfirmPassword, "")

        End If

    End Sub

    Public Sub RoleValidation()

        If cboRoles.SelectedIndex = -1 Then

            ErrorProvider1.SetError(cboRoles, "Please choose a role.")
            ErrorProvider1.SetIconPadding(cboRoles, 10)
            flag8 = False

        Else

            ErrorProvider1.SetError(cboRoles, "")

        End If

    End Sub

    Public Sub EventValidation()

        If cboRoles.Text = "Judge" Then

            If cboEvent.SelectedIndex = -1 Then

                ErrorProvider1.SetError(cboEvent, "Please choose an event.")
                ErrorProvider1.SetIconPadding(cboEvent, 10)
                flag8 = False

            Else

                ErrorProvider1.SetError(cboEvent, "")

            End If

        End If


    End Sub

    Public Sub LoadEvents()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_name FROM tblevents WHERE is_pageant = 1 ORDER BY event_name ASC"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    cboEvent.Items.Add(dbReader.Item("event_name").ToString)

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in loading events", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub GetEventID()

        Try

            OpenDBConnection()
            dbCmd.CommandText = "SELECT event_id FROM tblevents WHERE is_pageant = 1 AND event_name = '" & cboEvent.Text & "'"
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    tempEventID = dbReader.Item("event_id").ToString()

                End While

            End If

            CheckIfDbReaderIsClosed()

        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox("Error in getting event id", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Sub CountJudges(Query As String)

        tempTotalJudges = 0

        Try

            OpenDBConnection()
            dbCmd.CommandText = Query
            dbReader = dbCmd.ExecuteReader

            If dbReader.HasRows = True Then

                While dbReader.Read

                    tempTotalJudges = dbReader.Item("total_judges").ToString()

                    index += 1

                End While


            End If

            CheckIfDbReaderIsClosed()


        Catch ex As Exception

            CheckIfDbReaderIsClosed()

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If MsgBox("Do you want to cancel account registration?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then

            frmLogin.Show()
            Me.Close()

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        InitializeFlags()

        FirstNameValidation()
        MiddleNameValidation()
        LastNameValidation()
        EmailValidation()
        UsernameValidation()
        PasswordValidation()
        ConfirmPasswordValidation()
        RoleValidation()
        EventValidation()

        If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Or flag7 = False Or flag8 = False Then

            MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        If MsgBox("Do you want to register this user?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation Message") = MsgBoxResult.Yes Then

            Try

                OpenDBConnection()

                GetEventID()

                If cboRoles.Text <> "Judge" Then

                    dbCmd.CommandText = "INSERT INTO tblusers(first_name, middle_name, last_name, email, username, password, role) VALUES('" & txtFirstName.Text.Trim & "', '" & txtMiddleName.Text.Trim & "', '" & txtLastName.Text.Trim & "', '" & txtEmail.Text.Trim & "', '" & txtUsername.Text.Trim & "', '" & txtPassword.Text.Trim & "', '" & cboRoles.Text & "')"

                Else

                    CountJudges("SELECT COUNT(user_id) AS total_judges FROM tblusers WHERE event_id = " & tempEventID)

                    If tempTotalJudges >= 3 Then

                        MsgBox("The total judges for " & cboEvent.Text & " is already reached the limit.", MsgBoxStyle.Critical, "Error")
                        Exit Sub

                    End If

                    dbCmd.CommandText = "INSERT INTO tblusers(first_name, middle_name, last_name, email, username, password, role, event_id) VALUES('" & txtFirstName.Text.Trim & "', '" & txtMiddleName.Text.Trim & "', '" & txtLastName.Text.Trim & "', '" & txtEmail.Text.Trim & "', '" & txtUsername.Text.Trim & "', '" & txtPassword.Text.Trim & "', '" & cboRoles.Text & "', " & tempEventID & ")"

                End If

                dbCmd.ExecuteNonQuery()

                MsgBox("User added successfully!" & vbNewLine & "You can now use the user that you have created.", MsgBoxStyle.Information, "Message")

                frmLogin.Show()
                Me.Close()

            Catch ex As Exception

                MsgBox("Error in registering user." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

            End Try

        End If

    End Sub

    Private Sub cboRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoles.SelectedIndexChanged

        If cboRoles.Text = "Judge" Then

            lblEvent.Visible = True
            cboEvent.Visible = True

        Else

            lblEvent.Visible = False
            cboEvent.Visible = False

        End If

    End Sub

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadEvents()

    End Sub

End Class