
Imports System.Web.UI.WebControls
Namespace Managers


    Public Class ApplicationManager
        Private ReadOnly managers As New List(Of Type)() From {
        GetType(StateManager),
        GetType(GameManager),
        GetType(PlayerManager)
        }


        Public Sub New()

            Dim tasks As New List(Of Task)()

            For Each manager As Type In managers
                tasks.Add(Task.Factory.StartNew(Sub() LoadManager(manager)))
            Next

            Task.WaitAll(tasks.ToArray())
            Debug.Print("finish loading")
            Events.OnApplicationStarted()
        End Sub



        Private Sub LoadManager(manager As Type)
            Dim runnableManager As IManager = TryCast(Activator.CreateInstance(manager), IManager)
            If runnableManager IsNot Nothing Then
                Debug.Print("Load : " & manager.Name)
                runnableManager.Run()
                'MenuScreen.progress.Value = 45
            Else
                Debug.Print("Unable to initialize object : " & manager.Name)
            End If
        End Sub
    End Class

End Namespace