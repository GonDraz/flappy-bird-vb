Imports flappy_bird_vb.Managers

Public Class Application
    Implements ISubscribable
    Private applicationManager As ApplicationManager

    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchForm(PreLoadScreen)

        Subscribe()
        applicationManager = New ApplicationManager
    End Sub

    Public Sub SwitchForm(form As Form)
        mainPanel.Controls.Clear()
        form.TopLevel = False
        mainPanel.Controls.Add(form)
        form.Show()
    End Sub

    Public Sub Subscribe() Implements ISubscribable.Subscribe
        AddHandler flappy_bird_vb.Events.MenuState, AddressOf OnMenuState
        AddHandler flappy_bird_vb.Events.GameState, AddressOf OnGameState
        AddHandler flappy_bird_vb.Events.LoginState, AddressOf OnLoginState
        AddHandler flappy_bird_vb.Events.ScoreState, AddressOf OnScoreState
    End Sub

    Private Sub OnScoreState()
        SwitchForm(ScoreScreen)
    End Sub

    Public Sub OnMenuState()
        SwitchForm(MenuScreen)
        MenuScreen.textUser.Text = DataManager.username

    End Sub
    Public Sub OnGameState()
        SwitchForm(GameScreen)
    End Sub
    Public Sub OnLoginState()
        SwitchForm(LoginScreen)
    End Sub

    Public Sub Unsubscribe() Implements ISubscribable.Unsubscribe
    End Sub

    Public Sub Quit()
        Windows.Forms.Application.Exit()
    End Sub
End Class
