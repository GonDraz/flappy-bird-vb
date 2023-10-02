
Public MustInherit Class Events
    Public Shared Event StateChanged As Action
    Public Shared Event ApplicationStarted As Action

    Public Shared Event GameState As Action
    Public Shared Event MenuState As Action
    Public Shared Event LoginState As Action
    Public Shared Event ScoreState As Action

    Public Shared Event StartStateInGame As Action
    Public Shared Event PlayStateInGame As Action
    Public Shared Event PauseStateInGame As Action
    Public Shared Event LoseStateInGame As Action



    Public Shared Sub OnStateChanged()
        RaiseEvent StateChanged()
    End Sub

    Public Shared Sub OnApplicationStarted()
        RaiseEvent ApplicationStarted()
    End Sub

    Public Shared Sub OnGameState()
        RaiseEvent GameState()
    End Sub
    Public Shared Sub OnMenuState()
        RaiseEvent MenuState()
    End Sub
    Public Shared Sub OnLoginState()
        RaiseEvent LoginState()
    End Sub
    Public Shared Sub OnScoreState()
        RaiseEvent ScoreState()
    End Sub

    Public Shared Sub OnStartStateInGame()
        RaiseEvent StartStateInGame()
    End Sub
    Public Shared Sub OnPlayStateInGame()
        RaiseEvent PlayStateInGame()
    End Sub
    Public Shared Sub OnPauseStateInGame()
        RaiseEvent PauseStateInGame()
    End Sub

    Public Shared Sub OnLoseStateInGame()
        RaiseEvent LoseStateInGame()
    End Sub


End Class
