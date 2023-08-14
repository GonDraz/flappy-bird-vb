
Public Class ApplicationManager
    Private ReadOnly managers As New List(Of Type)() From {GetType(StateManager)}


    Public Sub New()
        RunProgram()
        LoadManagers()
    End Sub

    Private Sub RunProgram()
        'Application.SwitchForm(ViewGamePlay)
    End Sub


    Private Sub StartProgram()
        'Application.SwitchForm(ViewGamePlay)
    End Sub

    Private Sub LoadManagers()
        Dim tasks As New List(Of Task)()

        For Each manager As Type In managers
            tasks.Add(Task.Factory.StartNew(Sub() LoadManager(manager)))
        Next


        Task.WaitAll(tasks.ToArray())
        Application.SwitchForm(ViewGamePlay)
        StartProgram()
    End Sub


    Private Sub LoadManager(manager As Type)
        Dim runnableManager As IManager = TryCast(Activator.CreateInstance(manager), IManager)
        If runnableManager IsNot Nothing Then
            runnableManager.Run()
        Else
            Debug.Print("Không thể khởi tạo đối tượng Manager :" & manager.GetType().Name)
        End If
    End Sub

End Class
