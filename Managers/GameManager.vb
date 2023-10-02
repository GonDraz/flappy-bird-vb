Imports System.IO
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Suite.Descriptions

Public Class GameManager
    Implements IManager

    Public ReadOnly intervalSpam As Int16 = 1000
    Public ReadOnly intervalPipeAction As Int16 = 20
    Public Shared score As Integer = 0

    Public Enum GameState
        Start
        Play
        Pause
        Lose
    End Enum

    Public Shared state As GameState

    Public Sub SwichPanel(panel As Panel)
        HidePanel()
        panel.Visible = True
    End Sub

    Public Sub HidePanel()
        GameScreen.pnlPause.Visible = False
        GameScreen.pnlGameOver.Visible = False
    End Sub

    Public Sub Run() Implements IManager.Run
        AddHandler Events.StartStateInGame, AddressOf OnStartStateInGame
        AddHandler Events.PlayStateInGame, AddressOf OnPlayStateInGame
        AddHandler Events.PauseStateInGame, AddressOf OnPauseStateInGame
        AddHandler Events.LoseStateInGame, AddressOf OnLoseStateInGame

    End Sub

    Private Sub OnStartStateInGame()
        state = GameState.Start

        score = 0

        GameScreen.timerSpam.Interval = intervalSpam
        GameScreen.timerPipeAction.Interval = intervalPipeAction


        GameScreen.timerSpam.Enabled = False
        GameScreen.timerPipeAction.Enabled = False

        GameScreen.player.timerAcion.Enabled = False
        GameScreen.player.timerAnimation.Enabled = False

        HidePanel()
    End Sub

    Private Sub OnPlayStateInGame()
        state = GameState.Play

        GameScreen.timerSpam.Enabled = True
        GameScreen.timerPipeAction.Enabled = True


        GameScreen.player.timerAcion.Enabled = True
        GameScreen.player.timerAnimation.Enabled = True

        HidePanel()
    End Sub

    Private Sub OnPauseStateInGame()
        state = GameState.Pause

        GameScreen.timerSpam.Enabled = False
        GameScreen.timerPipeAction.Enabled = False


        GameScreen.player.timerAcion.Enabled = False
        GameScreen.player.timerAnimation.Enabled = False

        SwichPanel(GameScreen.pnlPause)
    End Sub
    Private Sub OnLoseStateInGame()
        state = GameState.Lose

        GameScreen.timerSpam.Enabled = False
        GameScreen.timerPipeAction.Enabled = False

        GameScreen.player.timerAcion.Enabled = False
        GameScreen.player.timerAnimation.Enabled = False

        SwichPanel(GameScreen.pnlGameOver)
    End Sub

End Class
