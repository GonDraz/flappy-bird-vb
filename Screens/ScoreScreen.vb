Imports System.Data.SQLite
Imports System.Web.UI.WebControls
Imports System.Windows
Imports flappy_bird_vb.Managers

Public Class ScoreScreen
    Private Sub ScoreScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler flappy_bird_vb.Events.ScoreState, AddressOf OnScoreState
        LoadData()
    End Sub

    Private Sub OnScoreState()
        LoadData()
    End Sub

    Private Sub LoadData()
        DataManager.connection.Open()
        DataManager.command.Connection = DataManager.connection
        DataManager.command.CommandText = "select * from score"
        Dim rdr As SQLiteDataReader = DataManager.command.ExecuteReader
        Dim table As New DataTable

        table.Load(rdr)
        dataView.DataSource = table
        DataManager.connection.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        StateManager.ChangeStateToPrevious()
    End Sub
End Class