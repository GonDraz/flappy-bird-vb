Imports System.Configuration
Imports Guna.UI2.WinForms

Public Class BaseModel

    Public modelPicture As New Guna2PictureBox

    'Animation
    Public WithEvents timerAnimation As New Timer(New System.ComponentModel.Container())
    Public animationImages As List(Of Bitmap)
    Dim indexAnimationImage As Int16 = 0
    Public intervalAnimation As Int16

    'Acion
    Public WithEvents timerAcion As New Timer(New System.ComponentModel.Container())
    Public intervalAcion As Int16 = 1

    Public Sub New(images As List(Of Bitmap), intervalAnimation As Int16)
        If images Is Nothing Then
            MsgBox("khong tim thay anh")
            Return
        End If
        Me.intervalAnimation = intervalAnimation

        animationImages = images
        SetPicture()

        timerAnimation.Interval = intervalAnimation
        timerAnimation.Enabled = True

    End Sub

    Public Sub New(image As Bitmap)
        SetPicture()
        modelPicture.Image = image
    End Sub

    Public Sub SetPicture()
        modelPicture.UseTransparentBackground = True
        modelPicture.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub TimerAmination_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick
        If indexAnimationImage = animationImages.Count Then
            indexAnimationImage = 0
        End If
        modelPicture.Image = animationImages(indexAnimationImage)
        indexAnimationImage += 1
    End Sub


    Public Overridable Sub TimerAcion_Tick(sender As Object, e As EventArgs) Handles timerAcion.Tick
    End Sub
End Class
