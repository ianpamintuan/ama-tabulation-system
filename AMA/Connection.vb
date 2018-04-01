Imports MySql.Data.MySqlClient
Imports System.IO

Module Connection

    Public dbConn As New MySqlConnection
    Public dbCmd As New MySqlCommand
    Public dbReader As MySqlDataReader

    Private dbHost, dbName, dbUser, dbPass, dbPort As String

    Public Sub LoadDBSettings()
        Try
            Dim SR As New StreamReader(Application.StartupPath & "\Config.ini")

            '############# Database Connection Details #############
            dbHost = SR.ReadLine
            dbName = SR.ReadLine
            dbUser = SR.ReadLine
            dbPass = SR.ReadLine
            dbPort = SR.ReadLine
            '############# Database Connection Details #############

        Catch ex As FileNotFoundException
            MsgBox("Error in loading settings.", MsgBoxStyle.Critical)
            End
        End Try
    End Sub

    Public Sub OpenDBConnection()

        LoadDBSettings()

        Try

            If dbConn.State = ConnectionState.Closed Then

                LoadDBSettings()

                dbConn.ConnectionString = "Data Source='" & dbHost & "'; Database='" & dbName & "'; User='" & dbUser & "'; Password='" & dbPass & "'; Port='" & dbPort & "';"
                dbConn.Open()
                dbCmd.Connection = dbConn

            End If

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MySqlError")
            End
        End Try

    End Sub

    Public Sub CloseDBConnection()

        dbCmd.Dispose()
        dbConn.Close()

    End Sub

End Module
