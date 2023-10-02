Imports System.Data.SqlClient

Namespace Managers

    Public Class StateManager
        Implements IManager

        Public Enum State
            None
            Game
            Menu
            Setting
            Login
        End Enum


        Public Sub Run() Implements IManager.Run
        End Sub

        Public Shared currentState As State
        Public Shared previousState As State

        Public Shared Sub ChangeState(state As State)
            If currentState = state Then
                Select Case state
                    'Case state.Season
                    '    Events.OnSeasonState()
                    'Exit Select
                End Select

                Return
            End If

            previousState = currentState

            Debug.Print("CHANGE STATE : " & previousState.ToString & " -> " & state.ToString)
            currentState = state

            Events.OnStateChanged()

            Select Case currentState
                Case State.None
                    Exit Select
                Case State.Menu
                    Events.OnMenuState()
                    Exit Select
                Case State.Game
                    Events.OnGameState()
                    Exit Select
                Case State.Login
                    Events.OnLoginState()
                    Exit Select
                Case Else
                    Debug.Print("State Null")
            End Select
        End Sub

        Public Shared Sub ChangeStateToPrevious()
            ChangeState(previousState)
        End Sub

    End Class
End Namespace