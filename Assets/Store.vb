Public Class Store
    Public Shared Function ChangeBoolToNum(value As Boolean) As Integer
        If value Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Shared Function ChangeNumToBool(value As Integer) As Boolean
        If value = 1 Then
            Return True
        ElseIf value = 0 Then
            Return False
        Else
            Return False
        End If
    End Function

    Public Shared Function CheckNull(text As String) As Boolean
        If text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
