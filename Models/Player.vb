
Public Class Player
    Inherits BaseModel

    Private ReadOnly gravitation As Int16 = 20
    Private ReadOnly jumpForce As Int16 = 80

    Public Sub New()
        MyBase.New(New List(Of Bitmap)() From {
            My.Resources.redbird_upflap,
            My.Resources.redbird_midflap,
            My.Resources.redbird_downflap
        }, 100)

        modelPicture.Size = New Size(68, 48)
        modelPicture.Location = New Point(250, 300)
    End Sub

    Public Overrides Sub TimerAcion_Tick(sender As Object, e As EventArgs)
        Drop()
    End Sub

    Public Sub Jump()
        modelPicture.Top -= jumpForce
    End Sub

    Public Sub Drop()
        modelPicture.Top += gravitation
    End Sub

    Public Sub Die()

    End Sub


End Class
