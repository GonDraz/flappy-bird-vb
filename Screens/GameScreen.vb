﻿Imports TheArtOfDevHtmlRenderer

Public Class GameScreen

    Public player As New Player
    Public WithEvents timerSpam As New Timer
    Public WithEvents timerPipeAction As New Timer
    Public pipes As New List(Of Pipe)()


    Public Sub TimerSpam_Tick(sender As Object, e As EventArgs) Handles timerSpam.Tick
        Dim pipe As New Pipe
        pipes.Add(pipe)
        Me.Controls.Add(pipe.topPipe.modelPicture)
        Me.Controls.Add(pipe.bottomPipe.modelPicture)

        If pipes.Count > 0 Then
            If pipes(0).topPipe.modelPicture.Location.X <= pipes(0).topPipe.modelPicture.Size.Width Then
                Me.Controls.Remove(pipes(0).topPipe.modelPicture)
                Me.Controls.Remove(pipes(0).bottomPipe.modelPicture)
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

                        GameManager.score += 1
                        scoreLB.Text = GameManager.score.ToString
                        pipe.qua = False
                    End If
                End If
            End If
        Next
    End Sub


    Private Sub ViewGamePlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(player.modelPicture)
        Me.DoubleBuffered = True
        'player.timerAcion.Enabled = True
        flappy_bird_vb.Events.OnStartStateInGame()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        OnClick()

    End Sub

    Private Sub pauseButton_Click(sender As Object, e As EventArgs) Handles pauseButton.Click
        flappy_bird_vb.Events.OnPauseStateInGame()
    End Sub

    Private Sub base_Click(sender As Object, e As EventArgs) Handles base.Click
        OnClick()
    End Sub

    Private Sub OnClick()
        Select Case GameManager.state
            Case GameManager.GameState.Start
                flappy_bird_vb.Events.OnPlayStateInGame()
                Exit Select
            Case GameManager.GameState.Play
                player.Jump()
                Exit Select
            Case GameManager.GameState.Pause
                flappy_bird_vb.Events.OnPlayStateInGame()
                player.Jump()
                Exit Select
            Case Else
                Debug.Print("Game State Null")
        End Select
    End Sub
End Class