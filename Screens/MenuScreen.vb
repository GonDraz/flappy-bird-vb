Imports flappy_bird_vb.Managers

Public Class MenuScreen
    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        StateManager.ChangeState(StateManager.State.Game)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Quit()
    End Sub

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        StateManager.ChangeState(StateManager.State.Score)
    End Sub
End Class