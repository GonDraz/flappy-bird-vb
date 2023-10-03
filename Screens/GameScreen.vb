
Imports flappy_bird_vb.GameManager
Imports flappy_bird_vb.Managers

Public Class GameScreen

    Public player As New Player
    Public WithEvents timerSpam As New Timer
    Public WithEvents timerPipeAction As New Timer
    Public pipes As New List(Of Pipe)()


    Public Sub TimerSpam_Tick(sender As Object, e As EventArgs) Handles timerSpam.Tick
        Dim pipe As New Pipe
        pipes.Add(pipe)
        Controls.Add(pipe.topPipe.modelPicture)
        Controls.Add(pipe.bottomPipe.modelPicture)
        If pipes.Count > 0 Then
            If pipes(0).topPipe.modelPicture.Location.X <= pipes(0).topPipe.modelPicture.Size.Width Then
                Controls.Remove(pipes(0).topPipe.modelPicture)
                Controls.Remove(pipes(0).bottomPipe.modelPicture)
                pipes.Remove(pipes(0))
            End If
        End If
    End Sub

    Public Sub TimerPipeAction_Tick(sender As Object, e As EventArgs) Handles timerPipeAction.Tick
        For Each pipe As Pipe In pipes
            pipe.Move()

            If pipes.Count > 0 Then

                If pipe.qua Then

                    If pipe.Safe(New Rectangle(player.modelPicture.Location, player.modelPicture.Size)) Then
                        player.Die()
                    End If

                    If pipe.topPipe.modelPicture.Location.X <= player.modelPicture.Location.X Then

                        score += 1
                        scoreLB.Text = score.ToString
                        pipe.qua = False
                    End If
                End If
            End If
        Next
    End Sub


    Private Sub ViewGamePlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler flappy_bird_vb.Events.StartStateInGame, AddressOf OnStartStateInGame

        flappy_bird_vb.Events.OnStartStateInGame()
        DoubleBuffered = True
    End Sub

    Private Sub OnStartStateInGame()
        player = New Player
        pipes = New List(Of Pipe)()
        Controls.Add(player.modelPicture)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        OnClick()

    End Sub

    Private Sub pauseButton_Click(sender As Object, e As EventArgs) Handles pauseButton.Click
        flappy_bird_vb.Events.OnPauseStateInGame()
    End Sub

    Private Sub base_Click(sender As Object, e As EventArgs) Handles base.Click
        OnClick()
    End Sub

    Private Sub OnClick()
        Select Case state
            Case GameState.Start
                flappy_bird_vb.Events.OnPlayStateInGame()
                Exit Select
            Case GameState.Play
                player.Jump()
                Exit Select
            Case GameState.Pause
                flappy_bird_vb.Events.OnPlayStateInGame()
                player.Jump()
                Exit Select
            Case GameState.Lose
                Exit Select
            Case Else
                Debug.Print("Game State Null")
        End Select
    End Sub


    Private Sub RemovePicture()

        Controls.Remove(player.modelPicture)
        For Each pipe In pipes
            Controls.Remove(pipe.topPipe.modelPicture)
            Controls.Remove(pipe.bottomPipe.modelPicture)
        Next
    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click
        RemovePicture()
        flappy_bird_vb.Events.OnStartStateInGame()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        StateManager.ChangeState(StateManager.State.Menu)
    End Sub

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        StateManager.ChangeState(StateManager.State.Score)
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        flappy_bird_vb.Events.OnPlayStateInGame()
    End Sub
End Class