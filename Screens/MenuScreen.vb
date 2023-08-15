Imports flappy_bird_vb.Managers

Public Class MenuScreen
    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        StateManager.ChangeState(StateManager.State.Game)
    End Sub
End Class