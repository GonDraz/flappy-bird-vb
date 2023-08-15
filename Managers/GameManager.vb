﻿Public Class GameManager
    Implements IManager

    Public ReadOnly intervalSpam As Int16 = 1200


    Public Enum GameState
        Start
        Play
        Pause
        Lose
    End Enum

    Public Shared state As GameState


    Public Sub Run() Implements IManager.Run
        AddHandler Events.StartStateInGame, AddressOf OnStartStateInGame
        AddHandler Events.PlayStateInGame, AddressOf OnPlayStateInGame
        AddHandler Events.PauseStateInGame, AddressOf OnPauseStateInGame
        AddHandler Events.LoseStateInGame, AddressOf OnLoseStateInGame
    End Sub

    Private Sub OnStartStateInGame()
        state = GameState.Start

        GameScreen.timerSpam.Interval = intervalSpam
        GameScreen.timerSpam.Enabled = False

        GameScreen.player.timerAcion.Enabled = False
        GameScreen.player.timerAnimation.Enabled = False
    End Sub

    Private Sub OnPlayStateInGame()
        state = GameState.Play

        GameScreen.timerSpam.Enabled = True

        GameScreen.player.timerAcion.Enabled = True
        GameScreen.player.timerAnimation.Enabled = True
    End Sub

    Private Sub OnPauseStateInGame()
        state = GameState.Pause

        GameScreen.timerSpam.Enabled = False

        GameScreen.player.timerAcion.Enabled = False
        GameScreen.player.timerAnimation.Enabled = False
    End Sub
    Private Sub OnLoseStateInGame()
        state = GameState.Lose

        GameScreen.timerSpam.Enabled = False

        GameScreen.player.timerAcion.Enabled = False
        GameScreen.player.timerAnimation.Enabled = False
    End Sub
End Class
