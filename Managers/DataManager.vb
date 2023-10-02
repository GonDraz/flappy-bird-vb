Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.IO
Imports flappy_bird_vb.Managers

Public Class DataManager
    Implements IManager


    Private Shared dbName As String = "flappy_bird_vb_gondraz.db"
    Private Shared dbPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & dbName
    Private Shared connString As String = "Data Source=" & dbPath & "; Version=3 ;PRAGMA legacy_file_format = TRUE; Integrated Security=true"
    Public Shared connection As New SQLiteConnection(connString)
    Public Shared command As New SQLiteCommand("", connection)

    Public Shared username As String


    Private isOpened As Boolean = False

    Public Sub Run() Implements IManager.Run
        If File.Exists(dbPath) = False Then
            CreateDataFile()
        Else
            LoadData()
        End If
        AddHandler Events.ApplicationStarted, AddressOf OnApplicationStarted
    End Sub

    Private Sub OnApplicationStarted()

        If isOpened = False Then
            Return
        End If

        connection.Open()
        command.Connection = connection

        command.CommandText = "SELECT save FROM application LIMIT 1;"
        Dim sqlResponse As Integer = command.ExecuteScalar()
        If sqlResponse = 0 Then
            StateManager.ChangeState(StateManager.State.Login)
        Else
            StateManager.ChangeState(StateManager.State.Menu)
        End If
        connection.Close()


        connection.Open()
        command.Connection = connection

        command.CommandText = "SELECT name FROM application LIMIT 1;"
        username = command.ExecuteScalar()
        connection.Close()

    End Sub

    Private Sub LoadData()
        connection.Open()
        command.Connection = connection

        command.CommandText = "Select * from application"

        Try
            command.ExecuteNonQuery()
        Catch ex As Exception

            Debug.Print("ex: " & ex.ToString)
            command.CommandText = DataCommand.CreateDatabase
            command.ExecuteNonQuery()
            connection.Close()
        End Try

        Debug.Print("database tại : " & dbPath)
        connection.Close()
        isOpened = True
    End Sub

    Private Sub CreateDataFile()
        File.Create(dbPath)
        System.Windows.Forms.Application.Restart()
    End Sub
End Class
