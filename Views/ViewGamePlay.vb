Public Class ViewGamePlay

    Dim player As New Player

    Private Sub ViewGamePlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Controls.Add(player.modelPicture)



        Me.DoubleBuffered = True
        player.timerAcion.Enabled = True
    End Sub



    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        player.Jump()

    End Sub
End Class