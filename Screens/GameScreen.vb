Imports System.IO

Public Class GameScreen

    Public player As New Player
    Public WithEvents timerSpam As New Timer
    'Public pipes As New Player


    Public Sub TimerSpam_Tick(sender As Object, e As EventArgs) Handles timerSpam.Tick
        Dim pipe As New Pipe

        Me.Controls.Add(pipe.topPipe.modelPicture)
        Me.Controls.Add(pipe.bottomPipe.modelPicture)
        pipe.timerMove.Interval = 50
        pipe.timerMove.Enabled = True
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