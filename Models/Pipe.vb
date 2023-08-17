
Public Class TopPipe
    Inherits BaseModel
    Public Sub New(sizeImage As Size, location As Point)
        MyBase.New(My.Resources.pipe_green)


        modelPicture.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical
        modelPicture.Size = sizeImage

        modelPicture.Location = location
    End Sub
End Class


Public Class BottomPipe
    Inherits BaseModel
    Public Sub New(sizeImage As Size, location As Point)
        MyBase.New(My.Resources.pipe_green)

        modelPicture.Size = sizeImage

        modelPicture.Location = location
    End Sub
End Class


Public Class Pipe
    ReadOnly distance As Int16 = 500
    ReadOnly stepMove As Int16 = 10
    ReadOnly sizeImage As New Size(100, 300)

    Private randomLocationY As Int16 = New Random().Next(-250, 0)

    Private locationTop As New Point(GameScreen.Size.Width, randomLocationY)
    Private locationBottom As New Point(GameScreen.Size.Width, randomLocationY + distance)

    Public topPipe As New TopPipe(sizeImage, locationTop)
    Public bottomPipe As New BottomPipe(sizeImage, locationBottom)

    Public qua As Boolean = True



    Public Function Safe(rectPlayer As Rectangle) As Boolean

        Dim rectTop As New Rectangle(topPipe.modelPicture.Location, topPipe.modelPicture.Size)
        Dim rectBottom As New Rectangle(bottomPipe.modelPicture.Location, bottomPipe.modelPicture.Size)


        If rectTop.IntersectsWith(rectPlayer) Then
            Return True
        End If

        If rectBottom.IntersectsWith(rectPlayer) Then
            Return True
        End If

        Return False
    End Function

    Public Overridable Sub Move()
        topPipe.modelPicture.Left -= stepMove
        bottomPipe.modelPicture.Left -= stepMove
    End Sub

End Class

