
Public Class Player
    Inherits BaseModel

    Private ReadOnly gravitation As Int16 = 15
    Private ReadOnly jumpForce As Int16 = 80

    Private isJump As Boolean


    Public Sub New()
        MyBase.New(New List(Of Bitmap)() From {
            My.Resources.redbird_upflap,
            My.Resources.redbird_midflap,
            My.Resources.redbird_downflap
        }, 150)

        modelPicture.Size = New Size(68, 48)
        modelPicture.Location = New Point(250, 300)
    End Sub

    Public Overrides Sub TimerAcion_Tick(sender As Object, e As EventArgs)
        Dim rectModel As New Rectangle(modelPicture.Location, New Size(modelPicture.Size.Width, modelPicture.Size.Height))
        Dim rectBase As New Rectangle(GameScreen.base.Location, GameScreen.base.Size)

        If rectModel.IntersectsWith(rectBase) Then
            Die()
        Else
            Drop()
        End If
    End Sub

    Public Sub Jump()
        isJump = True
        modelPicture.Top -= jumpForce
        isJump = False
    End Sub

    Public Sub Drop()

        If isJump Then
            Return
        End If
        modelPicture.Top += gravitation
    End Sub

    Public Sub Die()
        Events.OnLoseStateInGame()
    End Sub
End Class
