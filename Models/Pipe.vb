
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Class TopPipe
    Inherits BaseModel
    Public Sub New(sizeImage As Size, location As Point)
        MyBase.New(My.Resources.pipe_green)


        modelPicture.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical
        modelPicture.Size = sizeImage

        modelPicture.Location = location
    End Sub
End Class


Class BottomPipe
    Inherits BaseModel
    Public Sub New(sizeImage As Size, location As Point)
        MyBase.New(My.Resources.pipe_green)

        modelPicture.Size = sizeImage

        modelPicture.Location = location
    End Sub
End Class


Class Pipe
    ReadOnly distance As Int16 = 500
    ReadOnly stepMove As Int16 = 20
    ReadOnly sizeImage As New Size(100, 300)

    Private randomLocationY As Integer = New Random().Next(-250, 0)

    Private locationTop As New Point(GameScreen.Size.Width, randomLocationY)
    Private locationBottom As New Point(GameScreen.Size.Width, randomLocationY + distance)

    Public topPipe As New TopPipe(sizeImage, locationTop)
    Public bottomPipe As New BottomPipe(sizeImage, locationBottom)

    Public WithEvents timerMove As New Timer(New System.ComponentModel.Container())


    Public Overridable Sub TimerMove_Tick(sender As Object, e As EventArgs) Handles timerMove.Tick
        topPipe.modelPicture.Left -= stepMove
        bottomPipe.modelPicture.Left -= stepMove
    End Sub

End Class

